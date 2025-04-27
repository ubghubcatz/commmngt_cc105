Public Class EducationalRequirementsForm
    ' Track how many documents uploaded
    Private documentsUploaded As Integer = 0
    Private totalDocuments As Integer = 5 'All documents must be submitted

    Private Sub EducationalRequirementsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Initialize progress
        progressBarUpload.Value = 0
        lblProgress.Text = "0% Complete"
    End Sub

    ' Upload Certificate of Enrollment/Registration
    Public Shared EnrollmentCertifUploaded = False
    Private Sub btnUploadEnrollment_Click(sender As Object, e As EventArgs) Handles btnUploadEnrollment.Click
        EnrollmentCertifUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtEnrollmentPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Certificate of Enrollment uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Upload School ID (Photocopy)
    Public Shared SchoolIDUploaded = False
    Private Sub btnUploadSchoolID_Click(sender As Object, e As EventArgs) Handles btnUploadSchoolID.Click
        SchoolIDUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtSchoolIDPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("School ID uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Upload Report Card or Transcript (Optional)
    Public Shared ReportCardUploaded = False
    Private Sub btnUploadReportCard_Click(sender As Object, e As EventArgs) Handles btnUploadReportCard.Click
        ReportCardUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtReportCardPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Report Card uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Upload Barangay Certificate of Residency
    Public Shared ResidencyCertfUploaded = False
    Private Sub btnUploadResidencyCert_Click(sender As Object, e As EventArgs) Handles btnUploadResidencyCert.Click
        ResidencyCertfUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtResidencyCertPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Certificate of Residency uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Upload Certificate of Indigency
    Public Shared IndigencyCertifUploaded = False
    Private Sub btnUploadIndigencyCert_Click(sender As Object, e As EventArgs) Handles btnUploadIndigencyCert.Click
        IndigencyCertifUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtIndigencyCertPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Certificate of Indigency uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Check if all documents are uploaded
    Public Shared Function IsAllDocumentsUploaded() As Boolean
        Return EnrollmentCertifUploaded AndAlso
            SchoolIDUploaded AndAlso
            ReportCardUploaded AndAlso
            ResidencyCertfUploaded AndAlso
            IndigencyCertifUploaded
    End Function

    Public Shared Sub ResetDocumentFlags()
        EnrollmentCertifUploaded = False
        SchoolIDUploaded = False
        ReportCardUploaded = False
        ResidencyCertfUploaded = False
        IndigencyCertifUploaded = False
    End Sub

    'Updates Progress Bar
    Private Sub UpdateProgressBar()
        Dim percentComplete As Integer = CInt((documentsUploaded / totalDocuments) * 100)

        If percentComplete > 100 Then percentComplete = 100
        progressBarUpload.Value = percentComplete
        lblProgress.Text = percentComplete.ToString() & "% Complete"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate all required fields
        If String.IsNullOrWhiteSpace(txtStudentLastName.Text) Then
            MessageBox.Show("Please enter your Last Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtStudentFirstName.Text) Then
            MessageBox.Show("Please enter your First Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtStudentMiddleInitial.Text) Then
            MessageBox.Show("Please enter your Middle Initial.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtEnrollmentPath.Text) Then
            MessageBox.Show("Please upload Certificate of Enrollment.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtSchoolIDPath.Text) Then
            MessageBox.Show("Please upload Valid School ID.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtReportCardPath.Text) Then
            MessageBox.Show("Please upload your Report Card.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtResidencyCertPath.Text) Then
            MessageBox.Show("Please upload Barangay Certificate of Residency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtIndigencyCertPath.Text) Then
            MessageBox.Show("Please upload Certificate of Indigency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' All validations passed
        MessageBox.Show("Requirements successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
