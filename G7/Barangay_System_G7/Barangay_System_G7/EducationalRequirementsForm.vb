Imports System.Data.OleDb

Public Class EducationalRequirementsForm
    Private documentsUploaded As Integer = 0
    Private totalDocuments As Integer = 5

    Private Sub EducationalRequirementsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        progressBarUpload.Value = 0
        lblProgress.Text = "0% Complete"
    End Sub

    ' General method for uploading and copying files
    Private Function UploadDocument(txtPath As TextBox, documentType As String) As Boolean
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select " & documentType
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim targetFolder As String = Application.StartupPath & "\EducationalDocuments\"
            If Not System.IO.Directory.Exists(targetFolder) Then
                System.IO.Directory.CreateDirectory(targetFolder)
            End If

            Dim fileName As String = System.IO.Path.GetFileName(ofd.FileName)
            Dim targetPath As String = System.IO.Path.Combine(targetFolder, fileName)

            System.IO.File.Copy(ofd.FileName, targetPath, True)
            txtPath.Text = targetPath

            documentsUploaded += 1
            UpdateProgressBar()

            MessageBox.Show(documentType & " uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If

        Return False
    End Function

    ' Button Click Events
    Private Sub btnUploadEnrollment_Click(sender As Object, e As EventArgs) Handles btnUploadEnrollment.Click
        UploadDocument(txtEnrollmentPath, "Certificate of Enrollment")
    End Sub

    Private Sub btnUploadSchoolID_Click(sender As Object, e As EventArgs) Handles btnUploadSchoolID.Click
        UploadDocument(txtSchoolIDPath, "School ID")
    End Sub

    Private Sub btnUploadReportCard_Click(sender As Object, e As EventArgs) Handles btnUploadReportCard.Click
        UploadDocument(txtReportCardPath, "Report Card")
    End Sub

    Private Sub btnUploadResidencyCert_Click(sender As Object, e As EventArgs) Handles btnUploadResidencyCert.Click
        UploadDocument(txtResidencyCertPath, "Certificate of Residency")
    End Sub

    Private Sub btnUploadIndigencyCert_Click(sender As Object, e As EventArgs) Handles btnUploadIndigencyCert.Click
        UploadDocument(txtIndigencyCertPath, "Certificate of Indigency")
    End Sub

    ' Update Progress Bar
    Private Sub UpdateProgressBar()
        Dim percentComplete As Integer = CInt((documentsUploaded / totalDocuments) * 100)
        If percentComplete > 100 Then percentComplete = 100
        progressBarUpload.Value = percentComplete
        lblProgress.Text = percentComplete.ToString() & "% Complete"

        ' Optional: Change Progress Bar color to Green if complete
        If percentComplete = 100 Then
            progressBarUpload.ForeColor = Color.Green
        End If
    End Sub

    ' Validate All Fields
    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtStudentLastName.Text) Then
            MessageBox.Show("Please enter your Last Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtStudentFirstName.Text) Then
            MessageBox.Show("Please enter your First Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtStudentMiddleInitial.Text) Then
            MessageBox.Show("Please enter your Middle Initial.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEnrollmentPath.Text) Then
            MessageBox.Show("Please upload Certificate of Enrollment.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtSchoolIDPath.Text) Then
            MessageBox.Show("Please upload School ID.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtReportCardPath.Text) Then
            MessageBox.Show("Please upload Report Card.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtResidencyCertPath.Text) Then
            MessageBox.Show("Please upload Certificate of Residency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtIndigencyCertPath.Text) Then
            MessageBox.Show("Please upload Certificate of Indigency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Save Data to Database
    Private Sub SaveEducationalRequirements()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EducationalDatabase.accdb;")
        Dim cmd As New OleDbCommand("INSERT INTO EducationalRequirements 
            (StudentLastName, StudentFirstName, StudentMiddleInitial, EnrollmentCertPath, SchoolIDPath, ReportCardPath, ResidencyCertPath, IndigencyCertPath, DateSubmitted)
            VALUES 
            (@StudentLastName, @StudentFirstName, @StudentMiddleInitial, @EnrollmentCertPath, @SchoolIDPath, @ReportCardPath, @ResidencyCertPath, @IndigencyCertPath, @DateSubmitted)", con)

        cmd.Parameters.AddWithValue("@StudentLastName", txtStudentLastName.Text)
        cmd.Parameters.AddWithValue("@StudentFirstName", txtStudentFirstName.Text)
        cmd.Parameters.AddWithValue("@StudentMiddleInitial", txtStudentMiddleInitial.Text)
        cmd.Parameters.AddWithValue("@EnrollmentCertPath", txtEnrollmentPath.Text)
        cmd.Parameters.AddWithValue("@SchoolIDPath", txtSchoolIDPath.Text)
        cmd.Parameters.AddWithValue("@ReportCardPath", txtReportCardPath.Text)
        cmd.Parameters.AddWithValue("@ResidencyCertPath", txtResidencyCertPath.Text)
        cmd.Parameters.AddWithValue("@IndigencyCertPath", txtIndigencyCertPath.Text)
        cmd.Parameters.AddWithValue("@DateSubmitted", DateTime.Now)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Requirements successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ValidateFields() Then
            If MessageBox.Show("Are you sure you want to submit?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                SaveEducationalRequirements()
                ClearForm()
            End If
        End If
    End Sub

    ' Clear Form After Submit
    Private Sub ClearForm()
        txtStudentLastName.Clear()
        txtStudentFirstName.Clear()
        txtStudentMiddleInitial.Clear()
        txtEnrollmentPath.Clear()
        txtSchoolIDPath.Clear()
        txtReportCardPath.Clear()
        txtResidencyCertPath.Clear()
        txtIndigencyCertPath.Clear()
        documentsUploaded = 0
        UpdateProgressBar()
    End Sub
End Class
