<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Call_Log
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        PhoneNum_TxtBox = New TextBox()
        CallDate_DtePicker = New DateTimePicker()
        CancelCallLog_Btn = New Button()
        ConfirnCallLog_Btn = New Button()
        Panel1 = New Panel()
        Handled_TxtBox = New TextBox()
        Label7 = New Label()
        Purpose_TxtBox = New TextBox()
        Label8 = New Label()
        HandlerResultsListBox = New ListBox()
        Label9 = New Label()
        NotesTxtox = New TextBox()
        CallerEmail_TxtBox = New TextBox()
        Label4 = New Label()
        FirstName_TxtBox = New TextBox()
        Label11 = New Label()
        LastName_TxtBox = New TextBox()
        Label12 = New Label()
        CommType_ComboBox = New ComboBox()
        Label13 = New Label()
        Label6 = New Label()
        Status_ComboBox = New ComboBox()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        CallType_ComboBox = New ComboBox()
        Label5 = New Label()
        Label10 = New Label()
        Purok_Picker = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(7, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 25)
        Label1.TabIndex = 0
        Label1.Text = "Phone Number (09xxxxxxxxx)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(219, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 23)
        Label2.TabIndex = 1
        Label2.Text = "Date"
        ' 
        ' PhoneNum_TxtBox
        ' 
        PhoneNum_TxtBox.BorderStyle = BorderStyle.FixedSingle
        PhoneNum_TxtBox.Location = New Point(273, 66)
        PhoneNum_TxtBox.Name = "PhoneNum_TxtBox"
        PhoneNum_TxtBox.Size = New Size(153, 27)
        PhoneNum_TxtBox.TabIndex = 4
        ' 
        ' CallDate_DtePicker
        ' 
        CallDate_DtePicker.CustomFormat = "MM/dd/yyyy hh:mm tt"
        CallDate_DtePicker.Format = DateTimePickerFormat.Custom
        CallDate_DtePicker.Location = New Point(273, 170)
        CallDate_DtePicker.Name = "CallDate_DtePicker"
        CallDate_DtePicker.ShowUpDown = True
        CallDate_DtePicker.Size = New Size(169, 27)
        CallDate_DtePicker.TabIndex = 5
        CallDate_DtePicker.Value = New Date(2025, 4, 22, 15, 31, 0, 0)
        ' 
        ' CancelCallLog_Btn
        ' 
        CancelCallLog_Btn.BackColor = Color.Maroon
        CancelCallLog_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelCallLog_Btn.ForeColor = Color.White
        CancelCallLog_Btn.Location = New Point(592, 299)
        CancelCallLog_Btn.Name = "CancelCallLog_Btn"
        CancelCallLog_Btn.Size = New Size(110, 43)
        CancelCallLog_Btn.TabIndex = 9
        CancelCallLog_Btn.Text = "CANCEL"
        CancelCallLog_Btn.UseVisualStyleBackColor = False
        ' 
        ' ConfirnCallLog_Btn
        ' 
        ConfirnCallLog_Btn.BackColor = Color.DarkGreen
        ConfirnCallLog_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ConfirnCallLog_Btn.ForeColor = Color.White
        ConfirnCallLog_Btn.Location = New Point(708, 299)
        ConfirnCallLog_Btn.Name = "ConfirnCallLog_Btn"
        ConfirnCallLog_Btn.Size = New Size(110, 43)
        ConfirnCallLog_Btn.TabIndex = 10
        ConfirnCallLog_Btn.Text = "ADD"
        ConfirnCallLog_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Location = New Point(570, 283)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(268, 10)
        Panel1.TabIndex = 11
        ' 
        ' Handled_TxtBox
        ' 
        Handled_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Handled_TxtBox.Location = New Point(570, 8)
        Handled_TxtBox.Name = "Handled_TxtBox"
        Handled_TxtBox.Size = New Size(267, 27)
        Handled_TxtBox.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(443, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 28)
        Label7.TabIndex = 16
        Label7.Text = "Handled By"
        ' 
        ' Purpose_TxtBox
        ' 
        Purpose_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Purpose_TxtBox.Location = New Point(570, 81)
        Purpose_TxtBox.Multiline = True
        Purpose_TxtBox.Name = "Purpose_TxtBox"
        Purpose_TxtBox.Size = New Size(267, 83)
        Purpose_TxtBox.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(474, 76)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 28)
        Label8.TabIndex = 18
        Label8.Text = "Purpose"
        ' 
        ' HandlerResultsListBox
        ' 
        HandlerResultsListBox.FormattingEnabled = True
        HandlerResultsListBox.Location = New Point(570, 31)
        HandlerResultsListBox.Name = "HandlerResultsListBox"
        HandlerResultsListBox.Size = New Size(268, 104)
        HandlerResultsListBox.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(494, 171)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 28)
        Label9.TabIndex = 23
        Label9.Text = "Notes"
        ' 
        ' NotesTxtox
        ' 
        NotesTxtox.BorderStyle = BorderStyle.FixedSingle
        NotesTxtox.Location = New Point(568, 173)
        NotesTxtox.Multiline = True
        NotesTxtox.Name = "NotesTxtox"
        NotesTxtox.Size = New Size(267, 107)
        NotesTxtox.TabIndex = 24
        ' 
        ' CallerEmail_TxtBox
        ' 
        CallerEmail_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CallerEmail_TxtBox.Location = New Point(273, 99)
        CallerEmail_TxtBox.Name = "CallerEmail_TxtBox"
        CallerEmail_TxtBox.Size = New Size(153, 27)
        CallerEmail_TxtBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(209, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 27
        Label4.Text = "Email"
        ' 
        ' FirstName_TxtBox
        ' 
        FirstName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        FirstName_TxtBox.Location = New Point(7, 31)
        FirstName_TxtBox.Name = "FirstName_TxtBox"
        FirstName_TxtBox.Size = New Size(176, 27)
        FirstName_TxtBox.TabIndex = 30
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(7, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 25)
        Label11.TabIndex = 29
        Label11.Text = "First Name"
        ' 
        ' LastName_TxtBox
        ' 
        LastName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        LastName_TxtBox.Location = New Point(209, 31)
        LastName_TxtBox.Name = "LastName_TxtBox"
        LastName_TxtBox.Size = New Size(194, 27)
        LastName_TxtBox.TabIndex = 32
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Green
        Label12.Location = New Point(209, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(101, 25)
        Label12.TabIndex = 31
        Label12.Text = "Last Name"
        ' 
        ' CommType_ComboBox
        ' 
        CommType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CommType_ComboBox.FormattingEnabled = True
        CommType_ComboBox.Items.AddRange(New Object() {"Through Text", "Through Call", "Through Email", "Through Social Media", "Walk-in"})
        CommType_ComboBox.Location = New Point(273, 136)
        CommType_ComboBox.Name = "CommType_ComboBox"
        CommType_ComboBox.Size = New Size(153, 28)
        CommType_ComboBox.TabIndex = 34
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label13.ForeColor = Color.Green
        Label13.Location = New Point(92, 136)
        Label13.Name = "Label13"
        Label13.Size = New Size(175, 23)
        Label13.TabIndex = 33
        Label13.Text = "Communcation Type"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(207, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 23)
        Label6.TabIndex = 36
        Label6.Text = "Status"
        ' 
        ' Status_ComboBox
        ' 
        Status_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Status_ComboBox.FormattingEnabled = True
        Status_ComboBox.Items.AddRange(New Object() {"Missed", "Responded", "Declined", "Queued"})
        Status_ComboBox.Location = New Point(273, 274)
        Status_ComboBox.Name = "Status_ComboBox"
        Status_ComboBox.Size = New Size(153, 28)
        Status_ComboBox.TabIndex = 37
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(7, 55)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(176, 84)
        ListBox1.TabIndex = 38
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(209, 55)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(194, 84)
        ListBox2.TabIndex = 39
        ' 
        ' CallType_ComboBox
        ' 
        CallType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CallType_ComboBox.FormattingEnabled = True
        CallType_ComboBox.Items.AddRange(New Object() {"Outgoing", "Incoming"})
        CallType_ComboBox.Location = New Point(273, 206)
        CallType_ComboBox.Name = "CallType_ComboBox"
        CallType_ComboBox.Size = New Size(153, 28)
        CallType_ComboBox.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(184, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 23)
        Label5.TabIndex = 40
        Label5.Text = "Call Type"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(218, 240)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 23)
        Label10.TabIndex = 42
        Label10.Text = "Zone"
        ' 
        ' Purok_Picker
        ' 
        Purok_Picker.DropDownStyle = ComboBoxStyle.DropDownList
        Purok_Picker.FormattingEnabled = True
        Purok_Picker.Items.AddRange(New Object() {"Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6", "Purok 7"})
        Purok_Picker.Location = New Point(273, 240)
        Purok_Picker.Name = "Purok_Picker"
        Purok_Picker.Size = New Size(153, 28)
        Purok_Picker.TabIndex = 43
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(404, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 27)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(184, 55)
        Button2.Name = "Button2"
        Button2.Size = New Size(22, 27)
        Button2.TabIndex = 44
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Call_Log
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(854, 347)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CallType_ComboBox)
        Controls.Add(Label5)
        Controls.Add(Label10)
        Controls.Add(Purok_Picker)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Label6)
        Controls.Add(Status_ComboBox)
        Controls.Add(CommType_ComboBox)
        Controls.Add(Label13)
        Controls.Add(LastName_TxtBox)
        Controls.Add(Label12)
        Controls.Add(FirstName_TxtBox)
        Controls.Add(Label11)
        Controls.Add(CallDate_DtePicker)
        Controls.Add(Label2)
        Controls.Add(CallerEmail_TxtBox)
        Controls.Add(Label4)
        Controls.Add(NotesTxtox)
        Controls.Add(Label9)
        Controls.Add(HandlerResultsListBox)
        Controls.Add(Purpose_TxtBox)
        Controls.Add(Label8)
        Controls.Add(Handled_TxtBox)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(ConfirnCallLog_Btn)
        Controls.Add(CancelCallLog_Btn)
        Controls.Add(PhoneNum_TxtBox)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Call_Log"
        Text = "New Log"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneNum_TxtBox As TextBox
    Friend WithEvents CallDate_DtePicker As DateTimePicker
    Friend WithEvents CancelCallLog_Btn As Button
    Friend WithEvents ConfirnCallLog_Btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Handled_TxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Purpose_TxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HandlerResultsListBox As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NotesTxtox As TextBox
    Friend WithEvents CallerEmail_TxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FirstName_TxtBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LastName_TxtBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CommType_ComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Status_ComboBox As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents CallType_ComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Purok_Picker As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
