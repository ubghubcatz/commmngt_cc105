Imports System.Data.OleDb

Public Class BurialRequirementsForm
    Private documentsUploaded As Integer = 0
    Private totalDocuments As Integer = 4

    Private Sub BurialRequirementsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim targetFolder As String = Application.StartupPath & "\BurialDocuments\"
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
    Private Sub btnUploadDeathCert_Click(sender As Object, e As EventArgs) Handles btnUploadDeathCert.Click
        UploadDocument(txtDeathCertPath, "Death Certificate")
    End Sub

    Private Sub btnUploadValidID_Click(sender As Object, e As EventArgs) Handles btnUploadValidID.Click
        UploadDocument(txtValidIDPath, "Valid ID")
    End Sub

    Private Sub btnUploadBarangayCert_Click(sender As Object, e As EventArgs) Handles btnUploadBarangayCert.Click
        UploadDocument(txtBarangayCertPath, "Barangay Certificate of Residency")
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
        If String.IsNullOrWhiteSpace(txtDeceasedLastName.Text) Then
            MessageBox.Show("Please enter the Last name of the Deceased.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDeceasedFirstName.Text) Then
            MessageBox.Show("Please enter the First name of the Deceased.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDeceasedMiddleName.Text) Then
            MessageBox.Show("Please enter the Middle name of the Deceased.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRelationToDeceased.Text) Then
            MessageBox.Show("Please enter your Relationship to the Deceased.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDeathCertPath.Text) Then
            MessageBox.Show("Please upload the Death Certificate.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtValidIDPath.Text) Then
            MessageBox.Show("Please upload a Valid ID.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtBarangayCertPath.Text) Then
            MessageBox.Show("Please upload Barangay Certificate of Residency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtIndigencyCertPath.Text) Then
            MessageBox.Show("Please upload Certificate of Indigency.", "Missing Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Save Data to Database
    Private Sub SaveBurialRequirements()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BurialDatabase.accdb;")
        Dim cmd As New OleDbCommand("INSERT INTO BurialRequirements 
            (DeceaedLastName, DeceasedFirstName, DeceasedMiddleName, RelationToDeceased, DeathCertPath, IDPath, BarangayCertPath, IndigencyCertPath, DateSubmitted)
            VALUES 
            (@DeceaedLastName, @DeceasedFirstName, @DeceasedMiddleName, @RelationToDeceased, @DeathCertPath, @IDPath, @BarangayCertPath, @IndigencyCertPath, @DateSubmitted)", con)

        cmd.Parameters.AddWithValue("@DeceaedLastName", txtDeceasedLastName.Text)
        cmd.Parameters.AddWithValue("@DeceasedFirstName", txtDeceasedFirstName.Text)
        cmd.Parameters.AddWithValue("@DeceasedMiddleName", txtDeceasedMiddleName.Text)
        cmd.Parameters.AddWithValue("@RelationToDeceased", txtRelationToDeceased.Text)
        cmd.Parameters.AddWithValue("@DeathCertPath", txtDeathCertPath.Text)
        cmd.Parameters.AddWithValue("@IDPath", txtValidIDPath.Text)
        cmd.Parameters.AddWithValue("@BarangayCertPath", txtBarangayCertPath.Text)
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
                SaveBurialRequirements()
                ClearForm()
            End If
        End If
    End Sub

    ' Clear Form After Submit
    Private Sub ClearForm()
        txtDeceasedLastName.Clear()
        txtDeceasedFirstName.Clear()
        txtDeceasedMiddleName.Clear()
        txtRelationToDeceased.Clear()
        txtDeathCertPath.Clear()
        txtValidIDPath.Clear()
        txtBarangayCertPath.Clear()
        txtIndigencyCertPath.Clear()
        documentsUploaded = 0
        UpdateProgressBar()
    End Sub
End Class
