Imports System.Runtime.Intrinsics.X86

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gr_Eng As Integer
        Dim gr_Sci As Integer
        Dim gr_Math As Integer
        Dim ave As Integer

        ave = fAve(CInt(txtEng.Text), CInt(txtSci.Text), CInt(txtMath.Text))

        'IIf(ave >= 75, "Passed", "Failed")
        If (ave >= 75) Then
            MsgBox(ave & " is PASSED")
        Else
            MsgBox(ave & " is FAILED")
        End If





    End Sub

    Function fAve(v_Eng As Integer, v_Sci As Integer, v_Math As Integer) As Integer
        fAve = (v_Eng + v_Math + v_Sci) / 3
    End Function
End Class
