<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        btnLostandFrecords = New Button()
        btnLostandFound = New Button()
        Button1 = New Button()
        btnNew = New Button()
        btnRecords = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.YellowGreen
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1038, 94)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 21)
        Label1.TabIndex = 0
        Label1.Text = "CRISIS RESPONSE AND DOCUMENTATION SYSTEM (CRDS) "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Linen
        Panel2.Controls.Add(btnLostandFrecords)
        Panel2.Controls.Add(btnLostandFound)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btnNew)
        Panel2.Controls.Add(btnRecords)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(193, 493)
        Panel2.TabIndex = 1
        ' 
        ' btnLostandFrecords
        ' 
        btnLostandFrecords.FlatStyle = FlatStyle.Flat
        btnLostandFrecords.Image = CType(resources.GetObject("btnLostandFrecords.Image"), Image)
        btnLostandFrecords.Location = New Point(0, 377)
        btnLostandFrecords.Name = "btnLostandFrecords"
        btnLostandFrecords.Size = New Size(193, 83)
        btnLostandFrecords.TabIndex = 6
        btnLostandFrecords.Text = "LOST AND FOUND RECORDS"
        btnLostandFrecords.TextImageRelation = TextImageRelation.ImageAboveText
        btnLostandFrecords.UseVisualStyleBackColor = True
        ' 
        ' btnLostandFound
        ' 
        btnLostandFound.FlatStyle = FlatStyle.Flat
        btnLostandFound.Image = CType(resources.GetObject("btnLostandFound.Image"), Image)
        btnLostandFound.ImageAlign = ContentAlignment.TopCenter
        btnLostandFound.Location = New Point(0, 305)
        btnLostandFound.Name = "btnLostandFound"
        btnLostandFound.Size = New Size(193, 56)
        btnLostandFound.TabIndex = 5
        btnLostandFound.Text = "LOST AND FOUND"
        btnLostandFound.TextAlign = ContentAlignment.BottomCenter
        btnLostandFound.TextImageRelation = TextImageRelation.ImageAboveText
        btnLostandFound.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(0, 230)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 56)
        Button1.TabIndex = 4
        Button1.Text = "HOTLINES"
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.Location = New Point(0, 168)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(193, 56)
        btnNew.TabIndex = 3
        btnNew.Text = "NEW "
        btnNew.TextImageRelation = TextImageRelation.ImageAboveText
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnRecords
        ' 
        btnRecords.FlatStyle = FlatStyle.Flat
        btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), Image)
        btnRecords.Location = New Point(0, 106)
        btnRecords.Name = "btnRecords"
        btnRecords.Size = New Size(193, 56)
        btnRecords.TabIndex = 2
        btnRecords.Text = " INCIDENT RECORDS"
        btnRecords.TextImageRelation = TextImageRelation.ImageAboveText
        btnRecords.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(193, 151)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1038, 587)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        IsMdiContainer = True
        Name = "Form1"
        Text = "LOST AND FOUND"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRecords As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLostandFound As Button
    Friend WithEvents btnLostandFrecords As Button

End Class
