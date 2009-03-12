Imports System.Windows.Forms

Public Class ARD

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartARD.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelARD.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

 
    Private Sub buttonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSpecHeaderGroup1.Click

    End Sub

    Private Sub header1ButtonSpec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles header1ButtonSpec.Click

    End Sub

    
End Class
