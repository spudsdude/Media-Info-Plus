Imports System.Windows.Forms

Public Class dlgPickThumbs

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub pbThumb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb1.Click
        pbThumbSelected.ImageLocation = pbThumb1.ImageLocation
        pbThumbSelected.Load()
    End Sub
    Private Sub pbThumb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb2.Click
        pbThumbSelected.ImageLocation = pbThumb2.ImageLocation
        pbThumbSelected.Load()
    End Sub
    Private Sub pbThumb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb3.Click
        pbThumbSelected.ImageLocation = pbThumb3.ImageLocation
        pbThumbSelected.Load()
    End Sub
    Private Sub pbThumb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb4.Click
        pbThumbSelected.ImageLocation = pbThumb4.ImageLocation
        pbThumbSelected.Load()
    End Sub
    Private Sub pbThumb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb5.Click
        pbThumbSelected.ImageLocation = pbThumb5.ImageLocation
        pbThumbSelected.Load()
    End Sub
    Private Sub pbThumb1f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb1f.Click
        pbThumbSelectedFanart.ImageLocation = pbThumb1f.ImageLocation
        pbThumbSelectedFanart.Load()
    End Sub
    Private Sub pbThumb2f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb2f.Click
        pbThumbSelectedFanart.ImageLocation = pbThumb2f.ImageLocation
        pbThumbSelectedFanart.Load()
    End Sub
    Private Sub pbThumb3f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb3f.Click
        pbThumbSelectedFanart.ImageLocation = pbThumb3f.ImageLocation
        pbThumbSelectedFanart.Load()
    End Sub
    Private Sub pbThumb4f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb4f.Click
        pbThumbSelectedFanart.ImageLocation = pbThumb4f.ImageLocation
        pbThumbSelectedFanart.Load()
    End Sub
    Private Sub pbThumb5f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbThumb5f.Click
        pbThumbSelectedFanart.ImageLocation = pbThumb5f.ImageLocation
        pbThumbSelectedFanart.Load()
    End Sub
End Class
