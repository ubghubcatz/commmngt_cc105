Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class List
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=employeeSampleData;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnviewID_Click(sender As Object, e As EventArgs) Handles btnviewID.Click
        ' Get the reference to the main form
        Dim mainForm As Form1 = Me.ParentForm

        ' Check if mainForm exists and has the childform method
        If mainForm IsNot Nothing Then
            mainForm.Childform(New IDcard())
        End If
    End Sub

    'method to fetch employee details from database
    Private Sub LoadEmployees()
        Try
            conn.Open()
            Dim query As String = "SELECT EmployeeID, EmployeeName, Position FROM EmployeeDetails"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)  ' Fill DataTable with data from SQL Server

            ' Bind DataGridView to DataTable
            DataGridView1.DataSource = table


            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            DataGridView1.Columns("EmployeeName").HeaderText = "Full Name"
            DataGridView1.Columns("Position").HeaderText = "Job Title"
            With DataGridView1.ColumnHeadersDefaultCellStyle
                .Font = New Font("Calibri", 12, FontStyle.Bold)
                .ForeColor = Color.White
                .BackColor = Color.DarkBlue
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            ' Enable visual styling
            DataGridView1.EnableHeadersVisualStyles = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load employees when the form opens
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

End Class