Imports Microsoft.Data.SqlClient

Public Class Attendance
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=employeeSampleData;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click

        Dim empID As String = txtEmployeeID.Text.Trim()

        If empID = "" Then
            MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            ' Step 1: Fetch Employee Details & Photo (JOIN EmployeeDetails and Employee tables)
            Dim query As String = "SELECT e.photo_path, ed.EmployeeName, ed.Position, ed.EmployeeID 
                                   FROM EmployeeDetails ed 
                                   INNER JOIN Employees e ON ed.EmployeeID = e.EmployeeID 
                                   WHERE ed.EmployeeID = @empID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@empID", empID)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Display Employee Details
                lblName.Text = reader("EmployeeName").ToString()
                lblPosition.Text = reader("Position").ToString()
                lblID.Text = reader("EmployeeID").ToString()

                Dim imgPath As String = reader("photo_path").ToString()

                If IO.File.Exists(imgPath) Then
                    Dim img As Image = Image.FromFile(imgPath)
                    pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom ' 🔹 Scale image to fit without distortion
                    pbEmployeePhoto.Image = img
                Else
                    pbEmployeePhoto.Image = Nothing ' No image found
                    pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Normal ' Reset mode if no image
                End If

            Else
                MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            reader.Close()

            ' Step 2: Check Last Attendance Type (Time In/Out)
            Dim checkQuery As String = "SELECT TOP 1 ScanType FROM EmployeeAttendance WHERE EmployeeID = @empID ORDER BY ScanTime DESC"
            Dim checkCmd As New SqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@empID", empID)

            Dim lastScanType As Object = checkCmd.ExecuteScalar()
            Dim newScanType As String = If(lastScanType IsNot Nothing AndAlso lastScanType.ToString() = "IN", "OUT", "IN")

            ' Step 3: Insert Time In/Out Record
            Dim insertQuery As String = "INSERT INTO EmployeeAttendance (EmployeeID, ScanTime, ScanType) VALUES (@empID, GETDATE(), @scanType)"
            Dim insertCmd As New SqlCommand(insertQuery, conn)
            insertCmd.Parameters.AddWithValue("@empID", empID)
            insertCmd.Parameters.AddWithValue("@scanType", newScanType)
            insertCmd.ExecuteNonQuery()

            ' Step 4: Display Time In/Out
            If newScanType = "IN" Then
                lblTimeIn.Text = DateTime.Now.ToString("hh:mm:ss tt")
                lblTimeOut.Text = "N/A"
                MessageBox.Show("Time In recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lblTimeOut.Text = DateTime.Now.ToString("hh:mm:ss tt")
                MessageBox.Show("Time Out recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
End Class