<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeminarForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpSeminarDetails = New System.Windows.Forms.GroupBox()
        Me.lvSeminars = New System.Windows.Forms.ListView()
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSpeaker = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeleteSeminar = New System.Windows.Forms.Button()
        Me.btnAddSeminar = New System.Windows.Forms.Button()
        Me.dtpSeminarDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSpeaker = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtSeminarTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSeminarDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSeminarDetails
        '
        Me.grpSeminarDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSeminarDetails.Controls.Add(Me.lvSeminars)
        Me.grpSeminarDetails.Controls.Add(Me.Label6)
        Me.grpSeminarDetails.Controls.Add(Me.btnDeleteSeminar)
        Me.grpSeminarDetails.Controls.Add(Me.btnAddSeminar)
        Me.grpSeminarDetails.Controls.Add(Me.dtpSeminarDate)
        Me.grpSeminarDetails.Controls.Add(Me.txtDescription)
        Me.grpSeminarDetails.Controls.Add(Me.txtSpeaker)
        Me.grpSeminarDetails.Controls.Add(Me.txtLocation)
        Me.grpSeminarDetails.Controls.Add(Me.txtSeminarTitle)
        Me.grpSeminarDetails.Controls.Add(Me.Label5)
        Me.grpSeminarDetails.Controls.Add(Me.Label4)
        Me.grpSeminarDetails.Controls.Add(Me.Label3)
        Me.grpSeminarDetails.Controls.Add(Me.Label2)
        Me.grpSeminarDetails.Controls.Add(Me.Label1)
        Me.grpSeminarDetails.Location = New System.Drawing.Point(13, 12)
        Me.grpSeminarDetails.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpSeminarDetails.Name = "grpSeminarDetails"
        Me.grpSeminarDetails.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpSeminarDetails.Size = New System.Drawing.Size(508, 525)
        Me.grpSeminarDetails.TabIndex = 0
        Me.grpSeminarDetails.TabStop = False
        '
        'lvSeminars
        '
        Me.lvSeminars.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSeminars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTitle, Me.colDate, Me.colLocation, Me.colSpeaker, Me.colDescription})
        Me.lvSeminars.FullRowSelect = True
        Me.lvSeminars.GridLines = True
        Me.lvSeminars.HideSelection = False
        Me.lvSeminars.Location = New System.Drawing.Point(10, 338)
        Me.lvSeminars.MultiSelect = False
        Me.lvSeminars.Name = "lvSeminars"
        Me.lvSeminars.Size = New System.Drawing.Size(491, 181)
        Me.lvSeminars.TabIndex = 13
        Me.lvSeminars.UseCompatibleStateImageBehavior = False
        Me.lvSeminars.View = System.Windows.Forms.View.Details
        '
        'colTitle
        '
        Me.colTitle.Text = "Title"
        Me.colTitle.Width = 150
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 100
        '
        'colLocation
        '
        Me.colLocation.Text = "Location"
        Me.colLocation.Width = 150
        '
        'colSpeaker
        '
        Me.colSpeaker.Text = "Speaker"
        Me.colSpeaker.Width = 150
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        Me.colDescription.Width = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Registered Seminars:"
        '
        'btnDeleteSeminar
        '
        Me.btnDeleteSeminar.BackColor = System.Drawing.Color.Red
        Me.btnDeleteSeminar.Location = New System.Drawing.Point(256, 247)
        Me.btnDeleteSeminar.Name = "btnDeleteSeminar"
        Me.btnDeleteSeminar.Size = New System.Drawing.Size(245, 42)
        Me.btnDeleteSeminar.TabIndex = 11
        Me.btnDeleteSeminar.Text = "DELETE SEMINAR"
        Me.btnDeleteSeminar.UseVisualStyleBackColor = False
        '
        'btnAddSeminar
        '
        Me.btnAddSeminar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddSeminar.Location = New System.Drawing.Point(10, 247)
        Me.btnAddSeminar.Name = "btnAddSeminar"
        Me.btnAddSeminar.Size = New System.Drawing.Size(240, 42)
        Me.btnAddSeminar.TabIndex = 10
        Me.btnAddSeminar.Text = "ADD SEMINAR"
        Me.btnAddSeminar.UseVisualStyleBackColor = False
        '
        'dtpSeminarDate
        '
        Me.dtpSeminarDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeminarDate.Location = New System.Drawing.Point(94, 45)
        Me.dtpSeminarDate.Name = "dtpSeminarDate"
        Me.dtpSeminarDate.Size = New System.Drawing.Size(200, 21)
        Me.dtpSeminarDate.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(10, 179)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(491, 62)
        Me.txtDescription.TabIndex = 8
        '
        'txtSpeaker
        '
        Me.txtSpeaker.Location = New System.Drawing.Point(94, 110)
        Me.txtSpeaker.Name = "txtSpeaker"
        Me.txtSpeaker.Size = New System.Drawing.Size(200, 21)
        Me.txtSpeaker.TabIndex = 7
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(94, 76)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(200, 21)
        Me.txtLocation.TabIndex = 5
        '
        'txtSeminarTitle
        '
        Me.txtSeminarTitle.Location = New System.Drawing.Point(94, 15)
        Me.txtSeminarTitle.Name = "txtSeminarTitle"
        Me.txtSeminarTitle.Size = New System.Drawing.Size(200, 21)
        Me.txtSeminarTitle.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Speaker:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seminar Details:"
        '
        'SeminarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(534, 553)
        Me.Controls.Add(Me.grpSeminarDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SeminarForm"
        Me.ShowIcon = False
        Me.Text = "SEMINAR CREATOR"
        Me.grpSeminarDetails.ResumeLayout(False)
        Me.grpSeminarDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSeminarDetails As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSpeaker As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtSeminarTitle As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpSeminarDate As DateTimePicker
    Friend WithEvents btnDeleteSeminar As Button
    Friend WithEvents btnAddSeminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lvSeminars As ListView
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents colLocation As ColumnHeader
    Friend WithEvents colSpeaker As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
End Class
