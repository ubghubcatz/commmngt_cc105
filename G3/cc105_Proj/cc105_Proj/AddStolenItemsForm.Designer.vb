<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStolenItemsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStolenItemsForm))
        ItemName_TextBox = New TextBox()
        ItemDesc_TextBox = New TextBox()
        Price_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SaveItem_Btn = New Button()
        SuspendLayout()
        ' 
        ' ItemName_TextBox
        ' 
        resources.ApplyResources(ItemName_TextBox, "ItemName_TextBox")
        ItemName_TextBox.Name = "ItemName_TextBox"
        ' 
        ' ItemDesc_TextBox
        ' 
        resources.ApplyResources(ItemDesc_TextBox, "ItemDesc_TextBox")
        ItemDesc_TextBox.Name = "ItemDesc_TextBox"
        ' 
        ' Price_TextBox
        ' 
        resources.ApplyResources(Price_TextBox, "Price_TextBox")
        Price_TextBox.Name = "Price_TextBox"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.Green
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.ForeColor = Color.Green
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.ForeColor = Color.Green
        Label3.Name = "Label3"
        ' 
        ' SaveItem_Btn
        ' 
        SaveItem_Btn.BackColor = Color.Green
        resources.ApplyResources(SaveItem_Btn, "SaveItem_Btn")
        SaveItem_Btn.ForeColor = Color.White
        SaveItem_Btn.Name = "SaveItem_Btn"
        SaveItem_Btn.UseVisualStyleBackColor = False
        ' 
        ' AddStolenItemsForm
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        Controls.Add(SaveItem_Btn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Price_TextBox)
        Controls.Add(ItemDesc_TextBox)
        Controls.Add(ItemName_TextBox)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddStolenItemsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ItemName_TextBox As TextBox
    Friend WithEvents ItemDesc_TextBox As TextBox
    Friend WithEvents Price_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveItem_Btn As Button
End Class
