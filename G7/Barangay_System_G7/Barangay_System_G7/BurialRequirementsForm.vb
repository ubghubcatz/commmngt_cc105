Public Class BurialRequirementsForm
    ' Track how many documents uploaded
    Private documentsUploaded As Integer = 0
    Private totalDocuments As Integer = 5 'All documents must be submitted

    Private Sub BurialRequirementsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Initialize progress
        progressBarUpload.Value = 0
        lblProgress.Text = "0% Complete"
    End Sub

    'Upload For Death Certificate
    Public Shared DeathCertifUploaded As Boolean = False
    Private Sub btnUploadDeathCert_Click(sender As Object, e As EventArgs) Handles btnUploadDeathCert.Click
        DeathCertifUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Death Certificate File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtDeathCertPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Death Certificate uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Upload For Barangay Certificate
    Public Shared BarangayCertifUploaded As Boolean = False
    Private Sub btnUploadBarangayCert_Click(sender As Object, e As EventArgs) Handles btnUploadBarangayCert.Click
        BarangayCertifUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Barangay Certificate of Residency File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtBarangayCertPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Barangay Certificate of Residency uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Upload For Valid ID
    Public Shared ValidIDUploaded As Boolean = False
    Private Sub btnUploadValidID_Click(sender As Object, e As EventArgs) Handles btnUploadValidID.Click
        ValidIDUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Valid ID File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtValidIDPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Valid ID uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Upload For Certificate of Indigency
    Public Shared IndigencyCertifUploaded As Boolean = False
    Private Sub btnUploadIndigencyCert_Click(sender As Object, e As EventArgs) Handles btnUploadIndigencyCert.Click
        IndigencyCertifUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Certificate of Indigency File"
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

    'Upload For Funeral Contract
    Public Shared FuneralContractUploaded As Boolean = False
    Private Sub btnUploadFuneralContract_Click(sender As Object, e As EventArgs) Handles btnUploadFuneralContract.Click
        FuneralContractUploaded = True
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Funeral Contract File"
        ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtFuneralContractPath.Text = ofd.FileName

            ' Increment upload count and update progress
            documentsUploaded += 1
            UpdateProgressBar()
        End If

        'Document uploaded successfully
        MessageBox.Show("Funeral Contract uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Check if all documents are uploaded
    Public Shared Function IsAllDocumentsUploaded() As Boolean
        Return DeathCertifUploaded AndAlso
            BarangayCertifUploaded AndAlso
            ValidIDUploaded AndAlso
            IndigencyCertifUploaded AndAlso
            FuneralContractUploaded
    End Function

    ' Reset document upload flags
    Public Shared Sub ResetDocumentFlags()
        DeathCertifUploaded = False
        BarangayCertifUploaded = False
        ValidIDUploaded = False
        IndigencyCertifUploaded = False
        FuneralContractUploaded = False
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
        If String.IsNullOrWhiteSpace(txtDeceasedLastName.Text) Then
            MessageBox.Show("Please enter the Last Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtDeceasedFirstName.Text) Then
            MessageBox.Show("Please enter the First Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtDeceasedMiddleName.Text) Then
            MessageBox.Show("Please enter the Middle Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpDateOfBirth.Value >= dtpDateOfDeath.Value Then
            MessageBox.Show("Date of Birth must be earlier than Date of Death.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtDeathCertPath.Text) Then
            MessageBox.Show("Please upload the Death Certificate.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtBarangayCertPath.Text) Then
            MessageBox.Show("Please upload the Barangay Certificate.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtValidIDPath.Text) Then
            MessageBox.Show("Please upload a Valid ID.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtIndigencyCertPath.Text) Then
            MessageBox.Show("Please upload Certificate of Indigency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtFuneralContractPath.Text) Then
            MessageBox.Show("Please upload the Funeral Contract.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' All validations passed
        MessageBox.Show("Requirements successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
