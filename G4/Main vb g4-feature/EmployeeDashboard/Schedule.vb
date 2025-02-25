Imports Microsoft.Data.SqlClient

Public Class Schedule

    ' Connection String
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=employeeSampleData;Integrated Security=True;TrustServerCertificate=True")


    ' Method para sa ComboBox para pwede pumili kung tanod ba o baranggay health worker

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox Filter options
        cboFilter.Items.Add("All")
        cboFilter.Items.Add("Barangay Tanod")
        cboFilter.Items.Add("Barangay Health Worker")
        cboFilter.SelectedIndex = 0 ' Default to "All"

        LoadShifts()
    End Sub



    ' Method para sa Button para mag Generate and assign ng shifts automatically

    Private Sub btnGenerateShifts_Click(sender As Object, e As EventArgs) Handles btnGenerateShifts.Click
        Dim shiftAssignments As New List(Of Tuple(Of String, String, Date, TimeSpan, TimeSpan))
        Dim shifts As List(Of Tuple(Of TimeSpan, TimeSpan)) = New List(Of Tuple(Of TimeSpan, TimeSpan)) From {
        Tuple.Create(New TimeSpan(7, 0, 0), New TimeSpan(15, 0, 0)),
        Tuple.Create(New TimeSpan(15, 0, 0), New TimeSpan(23, 0, 0)),
        Tuple.Create(New TimeSpan(23, 0, 0), New TimeSpan(7, 0, 0))
    }

        Dim employees As New List(Of Tuple(Of String, String))
        Dim selectedRole As String = cboFilter.SelectedItem.ToString()

        ' SQL query to retrieve employees based on the selected role
        Dim query As String
        If selectedRole = "All" Then
            query = "SELECT EmployeeID, Position FROM EmployeeDetails WHERE Position IN ('Barangay Tanod', 'Barangay Health Worker')"
        Else
            query = "SELECT EmployeeID, Position FROM EmployeeDetails WHERE Position = @Position"
        End If

        ' Retrieve employees based on Position
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=employeeSampleData; Integrated Security=True; TrustServerCertificate=True")
            conn.Open()
            Dim cmd As New SqlCommand(query, conn)

            If selectedRole <> "All" Then
                cmd.Parameters.AddWithValue("@Position", selectedRole)
            End If

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                employees.Add(Tuple.Create(reader("EmployeeID").ToString(), reader("Position").ToString()))
            End While
            reader.Close()

        End Using

        ' Debugging: Check if employees are found
        MessageBox.Show("Employees count: " & employees.Count.ToString())

        If employees.Count = 0 Then
            MessageBox.Show("No employees found with Position 'Barangay Tanod'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Assign shifts for the next 7 days
        Dim startDate As Date = Date.Today
        For i As Integer = 0 To 6
            Dim shiftDate As Date = startDate.AddDays(i)

            For j As Integer = 0 To employees.Count - 1
                Dim employeeID As String = employees(j).Item1
                Dim role As String = employees(j).Item2
                Dim shiftTimes As Tuple(Of TimeSpan, TimeSpan) = shifts(j Mod shifts.Count)

                shiftAssignments.Add(Tuple.Create(employeeID, role, shiftDate, shiftTimes.Item1, shiftTimes.Item2))
            Next
        Next

        ' Debugging: Check if shifts are assigned
        MessageBox.Show("Total shifts to insert: " & shiftAssignments.Count.ToString())

        ' Save shifts to database
        SaveShiftsToDatabase(shiftAssignments)

        ' Refresh DataGridView
        LoadShifts()
    End Sub




    ' Method para magdisplay sa DataGridView

    Private Sub LoadShifts(Optional filter As String = "All")

        Dim query As String = "SELECT ShiftID, EmployeeName, EmployeeID, Role, ShiftDate, StartTime, EndTime FROM ShiftSchedule"

        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=employeeSampleData; Integrated Security=True; TrustServerCertificate=True")
            conn.Open()

            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Add formatted columns for display
                dt.Columns.Add("Start Time", GetType(String))
                dt.Columns.Add("End Time", GetType(String))

                For Each row As DataRow In dt.Rows
                    ' Convert TimeSpan to DateTime for AM/PM formatting
                    Dim startTime As TimeSpan = CType(row("StartTime"), TimeSpan)
                    Dim endTime As TimeSpan = CType(row("EndTime"), TimeSpan)

                    row("Start Time") = New DateTime(1, 1, 1, startTime.Hours, startTime.Minutes, 0).ToString("h:mm tt")
                    row("End Time") = New DateTime(1, 1, 1, endTime.Hours, endTime.Minutes, 0).ToString("h:mm tt")
                Next

                ' Bind only the formatted time columns
                DataGridViewShifts.DataSource = dt
                DataGridViewShifts.Columns("StartTime").Visible = False
                DataGridViewShifts.Columns("EndTime").Visible = False
            End Using
        End Using
    End Sub


    ' Method to Save generated shifts to database

    Private Sub SaveShiftsToDatabase(shiftSchedule As List(Of Tuple(Of String, String, Date, TimeSpan, TimeSpan)))
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=employeeSampleData; Integrated Security=True; TrustServerCertificate=True")
            conn.Open()
            Dim rowsInserted As Integer = 0

            For Each shift In shiftSchedule
                Dim cmd As New SqlCommand("INSERT INTO ShiftSchedule (EmployeeID, EmployeeName, Role, ShiftDate, StartTime, EndTime) 
                                           VALUES (@EmployeeID, (SELECT EmployeeName FROM EmployeeDetails WHERE EmployeeID = @EmployeeID), @Role, @ShiftDate, @StartTime, @EndTime)", conn)
                cmd.Parameters.AddWithValue("@EmployeeID", shift.Item1)
                cmd.Parameters.AddWithValue("@Role", shift.Item2)
                cmd.Parameters.AddWithValue("@ShiftDate", shift.Item3)
                cmd.Parameters.AddWithValue("@StartTime", shift.Item4)
                cmd.Parameters.AddWithValue("@EndTime", shift.Item5)

                Dim result As Integer = cmd.ExecuteNonQuery()
                rowsInserted += result
            Next

            MessageBox.Show(rowsInserted.ToString() & " shifts inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub


    'Method to Reset all Shifts
    Private Sub ResetAllShifts()
        ' Ask for confirmation before deleting shifts
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset all shifts?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            Exit Sub ' Cancel operation if user selects "No"
        End If

        ' Delete all shifts from ShiftSchedule table
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=employeeSampleData; Integrated Security=True; TrustServerCertificate=True")
            conn.Open()
            Dim deleteCmd As New SqlCommand("DELETE FROM ShiftSchedule", conn)
            deleteCmd.ExecuteNonQuery()
        End Using

        ' Notify the user
        MessageBox.Show("All shifts have been reset.", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh DataGridView to reflect the changes
        LoadShifts()
    End Sub

    'Reset Button
    Private Sub btnResetShifts_Click(sender As Object, e As EventArgs) Handles btnResetShifts.Click
        ResetAllShifts()
    End Sub


    ' Refresh DataGridView based on selected filter

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        LoadShifts(cboFilter.SelectedItem.ToString())
    End Sub
End Class
