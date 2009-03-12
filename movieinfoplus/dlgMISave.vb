Imports System.Windows.Forms

Public Class dlgMISave
    Dim sin As String = ""
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not sin = "" Then
            maincollection.sinmiString = sin
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub rbf1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf1.Click
        sin = "front.jpg"
    End Sub
    Private Sub rbf2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf2.Click
        sin = "front2.jpg"
    End Sub
    Private Sub rbf3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf3.Click
        sin = "front3.jpg"
    End Sub
    Private Sub rbf4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf4.Click
        sin = "front4.jpg"
    End Sub
    Private Sub rbf5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf5.Click
        sin = "front5.jpg"
    End Sub
    Private Sub rbf6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf6.Click
        sin = "front6.jpg"
    End Sub
    Private Sub rbf7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf7.Click
        sin = "front7.jpg"
    End Sub
    Private Sub rbf8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf8.Click
        sin = "front8.jpg"
    End Sub
    Private Sub rbf9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf9.Click
        sin = "front8.jpg"
    End Sub
    Private Sub rbf10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbf10.Click
        sin = "front10.jpg"
    End Sub

    'back
    Private Sub rbb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb1.Click
        sin = "back.jpg"
    End Sub
    Private Sub rbb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb2.Click
        sin = "back2.jpg"
    End Sub
    Private Sub rbb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb3.Click
        sin = "back3.jpg"
    End Sub
    Private Sub rbb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb4.Click
        sin = "back4.jpg"
    End Sub
    Private Sub rbb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb5.Click
        sin = "back5.jpg"
    End Sub
    Private Sub rbb6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb6.Click
        sin = "back6.jpg"
    End Sub
    Private Sub rbb7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb7.Click
        sin = "back7.jpg"
    End Sub
    Private Sub rbb8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb8.Click
        sin = "back8.jpg"
    End Sub
    Private Sub rbb9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb9.Click
        sin = "back8.jpg"
    End Sub
    Private Sub rbb10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbb10.Click
        sin = "back10.jpg"
    End Sub

    'inlay
    Private Sub rbinlay1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay1.Click
        sin = "inlay.jpg"
    End Sub
    Private Sub rbinlay2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay2.Click
        sin = "inlay2.jpg"
    End Sub
    Private Sub rbinlay3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay3.Click
        sin = "inlay3.jpg"
    End Sub
    Private Sub rbinlay4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay4.Click
        sin = "inlay4.jpg"
    End Sub
    Private Sub rbinlay5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay5.Click
        sin = "inlay5.jpg"
    End Sub
    Private Sub rbinlay6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay6.Click
        sin = "inlay6.jpg"
    End Sub
    Private Sub rbinlay7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay7.Click
        sin = "inlay7.jpg"
    End Sub
    Private Sub rbinlay8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay8.Click
        sin = "inlay8.jpg"
    End Sub
    Private Sub rbinlay9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay9.Click
        sin = "inlay8.jpg"
    End Sub
    Private Sub rbinlay10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinlay10.Click
        sin = "inlay10.jpg"
    End Sub

    Private Sub rbinside1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside1.Click
        sin = "inside.jpg"
    End Sub
    Private Sub rbinside2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside2.Click
        sin = "inside2.jpg"
    End Sub
    Private Sub rbinside3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside3.Click
        sin = "inside3.jpg"
    End Sub
    Private Sub rbinside4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside4.Click
        sin = "inside4.jpg"
    End Sub
    Private Sub rbinside5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside5.Click
        sin = "inside5.jpg"
    End Sub
    Private Sub rbinside6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside6.Click
        sin = "inside6.jpg"
    End Sub
    Private Sub rbinside7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside7.Click
        sin = "inside7.jpg"
    End Sub
    Private Sub rbinside8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside8.Click
        sin = "inside8.jpg"
    End Sub
    Private Sub rbinside9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside9.Click
        sin = "inside8.jpg"
    End Sub
    Private Sub rbinside10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinside10.Click
        sin = "inside10.jpg"
    End Sub
    'cd
    Private Sub rbcd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd1.Click
        sin = "cd1.jpg"
    End Sub
    Private Sub rbcd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd2.Click
        sin = "cd2.jpg"
    End Sub
    Private Sub rbcd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd3.Click
        sin = "cd3.jpg"
    End Sub
    Private Sub rbcd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd4.Click
        sin = "cd4.jpg"
    End Sub
    Private Sub rbcd5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd5.Click
        sin = "cd5.jpg"
    End Sub
    Private Sub rbcd6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd6.Click
        sin = "cd6.jpg"
    End Sub
    Private Sub rbcd7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd7.Click
        sin = "cd7.jpg"
    End Sub
    Private Sub rbcd8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd8.Click
        sin = "cd8.jpg"
    End Sub
    Private Sub rbcd9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd9.Click
        sin = "cd8.jpg"
    End Sub
    Private Sub rbcd10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd10.Click
        sin = "cd10.jpg"
    End Sub
    Private Sub rbcd11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd11.Click
        sin = "cd11.jpg"
    End Sub
    Private Sub rbcd12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd12.Click
        sin = "cd12.jpg"
    End Sub
    Private Sub rbcd13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd13.Click
        sin = "cd13.jpg"
    End Sub
    Private Sub rbcd14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd14.Click
        sin = "cd14.jpg"
    End Sub
    Private Sub rbcd15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcd15.Click
        sin = "cd15.jpg"
    End Sub
End Class
