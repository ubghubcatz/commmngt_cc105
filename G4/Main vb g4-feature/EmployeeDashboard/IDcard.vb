Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class IDcard
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=employeeSampleData;Integrated Security=True;TrustServerCertificate=True")

    ' Accept Employee ID from List form
    Public Sub LoadEmployeeDetails(employeeID As String)
        idNumber.Text = employeeID
    End Sub

    Private Sub BtnloadDetails_Click(sender As Object, e As EventArgs) Handles btnloadDetails.Click
        Try
            ' Debugging: Check if Employee ID is passed correctly
            If String.IsNullOrEmpty(idNumber.Text.Trim()) Then
                MessageBox.Show("Please enter an Employee ID before loading details.")
                Exit Sub
            End If

            conn.Open()

            Dim sql As String = "SELECT EmployeeID, FirstName, MiddleName, LastName, Position, photo_path FROM Employees WHERE EmployeeID = @EmployeeID"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@EmployeeID", idNumber.Text.Trim())

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                IDNumberlbl.Text = reader("EmployeeID").ToString()
                lblFullName.Text = $"{reader("FirstName")} {reader("MiddleName")} {reader("LastName")}"
                lblPosition.Text = reader("Position").ToString()

                ' Load Photo
                Dim photoPath As String = reader("photo_path").ToString()
                If Not String.IsNullOrEmpty(photoPath) AndAlso File.Exists(photoPath) Then
                    idPic.Image = Image.FromFile(photoPath)
                    idPic.SizeMode = PictureBoxSizeMode.Zoom ' Or use StretchImage
                    idPic.Image = Image.FromFile(photoPath)

                Else
                    MessageBox.Show("Photo not found: " & photoPath)
                    idPic.Image = Nothing
                End If
            Else
                MessageBox.Show("Employee not found.")
                IDNumberlbl.Text = ""
                lblFullName.Text = ""
                lblPosition.Text = ""
                idPic.Image = Nothing
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub IDcard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
