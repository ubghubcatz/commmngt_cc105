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
        Label3 = New Label()
        Label4 = New Label()
        PhoneNum_TxtBox = New TextBox()
        CallDate_DtePicker = New DateTimePicker()
        CallStart_TimePicker = New DateTimePicker()
        CancelCallLog_Btn = New Button()
        ConfirnCallLog_Btn = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        CallType_ComboBox = New ComboBox()
        Label6 = New Label()
        Status_ComboBox = New ComboBox()
        Handled_TxtBox = New TextBox()
        Label7 = New Label()
        Purpose_TxtBox = New TextBox()
        Label8 = New Label()
        CallDuration_TimePicker = New DateTimePicker()
        HandlerResultsListBox = New ListBox()
        PhoneNumResultsListBox = New ListBox()
        Label9 = New Label()
        NotesTxtox = New TextBox()
        Label10 = New Label()
        Purok_Picker = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(11, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 25)
        Label1.TabIndex = 0
        Label1.Text = "Phone Number (09xxxxxxxxx)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(134, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 28)
        Label2.TabIndex = 1
        Label2.Text = "Date Of Call"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(11, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 28)
        Label3.TabIndex = 2
        Label3.Text = "Start Time (24-Hr Format)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(26, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(245, 28)
        Label4.TabIndex = 3
        Label4.Text = "Call Duration (hh:mm:ss)"
        ' 
        ' PhoneNum_TxtBox
        ' 
        PhoneNum_TxtBox.Location = New Point(277, 49)
        PhoneNum_TxtBox.Name = "PhoneNum_TxtBox"
        PhoneNum_TxtBox.Size = New Size(267, 27)
        PhoneNum_TxtBox.TabIndex = 4
        ' 
        ' CallDate_DtePicker
        ' 
        CallDate_DtePicker.CustomFormat = "MM/dd/yyyy"
        CallDate_DtePicker.Format = DateTimePickerFormat.Custom
        CallDate_DtePicker.Location = New Point(277, 124)
        CallDate_DtePicker.Name = "CallDate_DtePicker"
        CallDate_DtePicker.Size = New Size(267, 27)
        CallDate_DtePicker.TabIndex = 5
        CallDate_DtePicker.Value = New Date(2025, 3, 5, 23, 54, 57, 0)
        ' 
        ' CallStart_TimePicker
        ' 
        CallStart_TimePicker.CustomFormat = "HH:mm"
        CallStart_TimePicker.Format = DateTimePickerFormat.Custom
        CallStart_TimePicker.Location = New Point(277, 192)
        CallStart_TimePicker.Name = "CallStart_TimePicker"
        CallStart_TimePicker.ShowUpDown = True
        CallStart_TimePicker.Size = New Size(267, 27)
        CallStart_TimePicker.TabIndex = 8
        ' 
        ' CancelCallLog_Btn
        ' 
        CancelCallLog_Btn.BackColor = Color.Maroon
        CancelCallLog_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelCallLog_Btn.ForeColor = Color.White
        CancelCallLog_Btn.Location = New Point(835, 526)
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
        ConfirnCallLog_Btn.Location = New Point(951, 526)
        ConfirnCallLog_Btn.Name = "ConfirnCallLog_Btn"
        ConfirnCallLog_Btn.Size = New Size(110, 43)
        ConfirnCallLog_Btn.TabIndex = 10
        ConfirnCallLog_Btn.Text = "ADD"
        ConfirnCallLog_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Location = New Point(12, 510)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1049, 10)
        Panel1.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(163, 328)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 28)
        Label5.TabIndex = 12
        Label5.Text = "Call Type"
        ' 
        ' CallType_ComboBox
        ' 
        CallType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CallType_ComboBox.FormattingEnabled = True
        CallType_ComboBox.Items.AddRange(New Object() {"Outgoing", "Incoming"})
        CallType_ComboBox.Location = New Point(277, 328)
        CallType_ComboBox.Name = "CallType_ComboBox"
        CallType_ComboBox.Size = New Size(267, 28)
        CallType_ComboBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(190, 390)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 28)
        Label6.TabIndex = 14
        Label6.Text = "Status"
        ' 
        ' Status_ComboBox
        ' 
        Status_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Status_ComboBox.FormattingEnabled = True
        Status_ComboBox.Items.AddRange(New Object() {"Missed", "Answered", "Declined"})
        Status_ComboBox.Location = New Point(277, 390)
        Status_ComboBox.Name = "Status_ComboBox"
        Status_ComboBox.Size = New Size(267, 28)
        Status_ComboBox.TabIndex = 15
        ' 
        ' Handled_TxtBox
        ' 
        Handled_TxtBox.Location = New Point(794, 49)
        Handled_TxtBox.Name = "Handled_TxtBox"
        Handled_TxtBox.Size = New Size(267, 27)
        Handled_TxtBox.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(658, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 28)
        Label7.TabIndex = 16
        Label7.Text = "Handled By"
        ' 
        ' Purpose_TxtBox
        ' 
        Purpose_TxtBox.Location = New Point(794, 122)
        Purpose_TxtBox.Multiline = True
        Purpose_TxtBox.Name = "Purpose_TxtBox"
        Purpose_TxtBox.Size = New Size(267, 97)
        Purpose_TxtBox.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(658, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 28)
        Label8.TabIndex = 18
        Label8.Text = "Call Purpose"
        ' 
        ' CallDuration_TimePicker
        ' 
        CallDuration_TimePicker.CustomFormat = "HH:mm:ss"
        CallDuration_TimePicker.Format = DateTimePickerFormat.Custom
        CallDuration_TimePicker.Location = New Point(277, 262)
        CallDuration_TimePicker.Name = "CallDuration_TimePicker"
        CallDuration_TimePicker.ShowUpDown = True
        CallDuration_TimePicker.Size = New Size(267, 27)
        CallDuration_TimePicker.TabIndex = 20
        ' 
        ' HandlerResultsListBox
        ' 
        HandlerResultsListBox.FormattingEnabled = True
        HandlerResultsListBox.Location = New Point(794, 72)
        HandlerResultsListBox.Name = "HandlerResultsListBox"
        HandlerResultsListBox.Size = New Size(268, 164)
        HandlerResultsListBox.TabIndex = 21
        ' 
        ' PhoneNumResultsListBox
        ' 
        PhoneNumResultsListBox.FormattingEnabled = True
        PhoneNumResultsListBox.Location = New Point(277, 72)
        PhoneNumResultsListBox.Name = "PhoneNumResultsListBox"
        PhoneNumResultsListBox.Size = New Size(267, 64)
        PhoneNumResultsListBox.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(711, 260)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 28)
        Label9.TabIndex = 23
        Label9.Text = "Notes"
        ' 
        ' NotesTxtox
        ' 
        NotesTxtox.Location = New Point(794, 260)
        NotesTxtox.Multiline = True
        NotesTxtox.Name = "NotesTxtox"
        NotesTxtox.Size = New Size(267, 158)
        NotesTxtox.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(171, 446)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 28)
        Label10.TabIndex = 25
        Label10.Text = "Call Zone"
        ' 
        ' Purok_Picker
        ' 
        Purok_Picker.DropDownStyle = ComboBoxStyle.DropDownList
        Purok_Picker.FormattingEnabled = True
        Purok_Picker.Items.AddRange(New Object() {"Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6", "Purok 7"})
        Purok_Picker.Location = New Point(277, 446)
        Purok_Picker.Name = "Purok_Picker"
        Purok_Picker.Size = New Size(267, 28)
        Purok_Picker.TabIndex = 26
        ' 
        ' Call_Log
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1076, 581)
        Controls.Add(Purok_Picker)
        Controls.Add(Label10)
        Controls.Add(NotesTxtox)
        Controls.Add(Label9)
        Controls.Add(PhoneNumResultsListBox)
        Controls.Add(HandlerResultsListBox)
        Controls.Add(CallDuration_TimePicker)
        Controls.Add(Purpose_TxtBox)
        Controls.Add(Label8)
        Controls.Add(Handled_TxtBox)
        Controls.Add(Label7)
        Controls.Add(Status_ComboBox)
        Controls.Add(Label6)
        Controls.Add(CallType_ComboBox)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(ConfirnCallLog_Btn)
        Controls.Add(CancelCallLog_Btn)
        Controls.Add(CallStart_TimePicker)
        Controls.Add(CallDate_DtePicker)
        Controls.Add(PhoneNum_TxtBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Call_Log"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PhoneNum_TxtBox As TextBox
    Friend WithEvents CallDate_DtePicker As DateTimePicker
    Friend WithEvents CallStart_TimePicker As DateTimePicker
    Friend WithEvents CancelCallLog_Btn As Button
    Friend WithEvents ConfirnCallLog_Btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CallType_ComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Status_ComboBox As ComboBox
    Friend WithEvents Handled_TxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Purpose_TxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CallDuration_TimePicker As DateTimePicker
    Friend WithEvents HandlerResultsListBox As ListBox
    Friend WithEvents PhoneNumResultsListBox As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NotesTxtox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Purok_Picker As ComboBox
End Class
