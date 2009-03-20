Imports System.Windows.Forms

Public Class autopilotdialog
    Dim primaryselected As String = ""
    Dim secondaryselected As String = "none"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Function calcpicturewidthbyaspectratio(ByRef timage As Image, ByVal theight As Integer) As Double
        Dim fixedHeight As Double = CDbl(theight)
        Dim newWidth As Double = fixedHeight / aspectratio(timage)
        Return newWidth
    End Function
    Private Function fitimagetofixedwidth(ByRef timage As Image, ByVal twidth As Integer) As Double
        Dim fixedWidth As Double = CDbl(twidth)
        Dim newWidth As Double = twidth * aspectratio(timage)
        Return newWidth
    End Function
    Private Function aspectratio(ByRef timage As Image) As Double
        Dim oH As Integer = timage.Height
        Dim oW As Integer = timage.Width
        Dim taspect As Double = oH / oW
        Return taspect
    End Function
    Private Function calcpbsize(ByRef timage As Image) As String
        'Dim taspect As Double = aspectratio(timage)
        'Dim imagetype As String = ""
        'If taspect < 0.25 Then
        '    'wide(Icon)
        '    imagetype = "wideicon"
        'ElseIf taspect > 0.8 And taspect < 1.1 And timage.Height < 500 And timage.Width < 480 Then
        '    'boxed icon or maybe squared poster
        '    imagetype = "boxed"
        'Else
        '    imagetype = "poster" 'consider it a poster
        'End If
        ''set pb to bmp size
        'Try 'fix to check file first and remove try block
        '    Dim x, y As Integer
        '    If (timage.Width > 480 Or timage.Height > 500 Or Not cbDlFormat.SelectedIndex = 2 Or imagetype = "poster") And Not imagetype = "wideicon" Then
        '        Debug.Print("no transparency attempted for current icon, too big, quality setting not highest, or it's a poster")
        '        'scale image size
        '        'set the fixed height and get the new width (based on aspect) then set the picture box sizes
        '        Dim fixedHeight As Double = 450
        '        Dim newWidth As Double = fixedHeight / taspect
        '        'pbCurIconUsed.Image = bmpImage
        '        pbCurIconUsed.Hide()
        '        pbCurIconUsed2.Show()
        '        pbCurIconUsed2.Width = Convert.ToInt32(newWidth)
        '        pbCurIconUsed2.Height = Convert.ToInt32(fixedHeight)
        '        pbCurIconUsed2.Image = pbCurIconUsed.Image

        '        'do not attempt transparency
        '    Else
        '        lblPbar.Text = " ____---- Processing Transparency ----____ "
        '        Me.Refresh()
        '        Dim bmp As New Bitmap(Path + "\folder.jpg")
        '        Dim gp As New System.Drawing.Drawing2D.GraphicsPath
        '        Dim mask1 As Color = System.Drawing.Color.White
        '        Dim mask2 As Color = System.Drawing.Color.Transparent
        '        Dim noshow As String = "Color [A=0, R=0, G=0, B=0]"
        '        For x = 0 To bmp.Width - 1
        '            For y = 0 To bmp.Height - 1
        '                Dim curPixAlpha As Integer = Convert.ToInt16(Strings.Replace(Strings.Replace(Strings.Right(Strings.Left(bmp.GetPixel(x, y).ToString, 12), 3), ",", ""), " ", ""))
        '                If curPixAlpha >= 128 Then
        '                    'Debug.Print("More then 127: " + curPixAlpha.ToString)
        '                    gp.AddRectangle(New Rectangle(x, y, 1, 1))
        '                Else
        '                    'Debug.Print("mask1" + bmp.GetPixel(x, y).ToString)
        '                End If
        '                curPixAlpha = Nothing
        '            Next
        '        Next

        '        'set pbsize
        '        pbCurIconUsed.Height = bmp.Height
        '        pbCurIconUsed.Width = bmp.Width
        '        'setitem
        '        pbCurIconUsed.BackColor = Color.Transparent
        '        pbCurIconUsed.Region = New System.Drawing.Region(gp)
        '        'cleanup
        '        bmp.Dispose()
        '        bmp = Nothing
        '        gp.Dispose()
        '        'End If
        '    End If
        'Catch ex As Exception
        '    Debug.Print(ex.ToString)
        'End Try
        'bmpImage.Dispose()
        '    Catch ex As Exception
        '    'MsgBox("file bad, delete?", MsgBoxStyle.YesNo, "Unable to load folder.jpg")
        '    ' If MsgBoxResult.Yes = MsgBox("Unable to load folder.jpg, it appears to be corrupted." + vbNewLine + vbNewLine + "Do you want to delete it and the associated tbn file?") Then
        '    File.Delete(Path + "\folder.jpg")
        '    If File.Exists(lblCurMovieFolder.Text + "\" + tbMovieName.Text + ".tbn") Then File.Delete(lblCurMovieFolder.Text + "\" + tbMovieName.Text + ".tbn")
        '    'End If
        '    '    MsgBox("Image located at: " + Path + "\folder.jpg" + " is corrupted, I'm deleting it")
        '    'if this fails, the file is corrupt, delete it and the tbn file
        '    pbCurIconUsed.ImageLocation = Nothing
        '    pbCurIconUsed.Hide()
        '    pbCurIconUsed2.ImageLocation = Nothing
        '    pbCurIconUsed2.Hide()
        'End Try
        ''end cur image processing
        'Else 'used when no folder.jpg exsist
        'pbCurIconUsed.ImageLocation = Nothing
        'pbCurIconUsed.Hide()
        'pbCurIconUsed2.ImageLocation = Nothing
        'pbCurIconUsed2.Hide()


        'End If
        Return "no"
    End Function
    Private Sub btnStartProcessing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcessing.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Hide()
        'pbar1.Visible = True
        'tmr1.Start()
        startautopilot()
        'tmr1.Stop()
        'pbar1.Visible = False
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbprimaryiconsquare.Click

    End Sub
    'format 1 - s0 = spb1 'no style box
    'format 1 - s3  = bspb1 'titled case
    'format 1 - s9 = tpb1 'token style
    'format 2 - s0 = pbwns1 'wide no style
    'format 2 - s8 = pbwrs1 'wide rounded shadow 
    'format 2 - s2 = pbwrsscan1 'wide round shadow scanlines
    'format 2 - s10 = pb1 'wide round shadow glass
    'format 3 - tall (not used)
    'format 070 poster 'posterpb1
    Private Sub startautopilot()
        'autopilot(primary, secondary, posterTru, fanartTru, tbnTru, nfoTru, overwritenfoTru)
        Dim buseposter, busefanart, bcnfo, bctbn, bonfo, boei As Boolean
        If cbimpaposter.Checked Then buseposter = True
        If cbmeligrovefanart.Checked Then busefanart = True
        If cbcreatenfo.Checked Then bcnfo = True
        If cbcreatetbn.Checked Then bctbn = True
        If cboverwritenfo.Checked Then bonfo = True
        If cboverwriteexistingicons.Checked Then boei = True
        Debug.Print(maincollection.lbMyMovies.Items.Count.ToString)
        If maincollection.lbMyMovies.Items.Count <= 0 Then
            Debug.Print("no items in drop down, attempting to get some")
            maincollection.readfolderdatafordropdown()

            If maincollection.lbMyMovies.Items.Count <= 0 Then
                Debug.Print(maincollection.lbMyMovies.Items.Count.ToString)
                MsgBox("There's nothing in the folder to process")
                Exit Sub
            End If
        End If

        If primaryselected = "" Then
            MsgBox("You need to select a primary icon type")
        Else
            Debug.Print("Primary set to: " + primaryselected)
            Debug.Print("Secondary set to: " + secondaryselected)
            Debug.Print("use poster: " + buseposter.ToString + "use fanart: " + busefanart.ToString + "create tbn: " + bctbn.ToString + "create nfo: " + bcnfo.ToString + "overwrite nfo:" + bonfo.ToString)

            maincollection.autopilotfromform(primaryselected, secondaryselected, buseposter, busefanart, bctbn, bcnfo, bonfo, boei)
        End If



    End Sub
#Region "examples"
    'resize from one pb to another
    'Dim fixedHeight As Double = 256
    'Dim newWidth As Double = fixedHeight / aspectratio(pbPoster.Image)
    '    pbprimaryicon.Width = Convert.ToInt32(newWidth)
    '    pbprimaryicon.Height = Convert.ToInt32(fixedHeight)
    '        pbprimaryicon.Image = pbPoster.Image
    '    pbprimaryicon.Width = Convert.ToInt32(newWidth)
    '    pbprimaryicon.Height = Convert.ToInt32(fixedHeight)
    '    pbprimaryicon.Image = pbPoster.Image

#End Region
    Private Sub rbp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp1.Click
        pbprimaryiconsquare.Visible = True
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = False
        pbprimaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.spb1
        primaryselected = "f1s0"
    End Sub
    Private Sub rbp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp2.Click
        pbprimaryiconsquare.Visible = False
        pbprimaryiconwide.Visible = False
        pbprimaryposter.Visible = True
        primaryselected = "poster"
    End Sub
    Private Sub rbp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp3.Click
        pbprimaryiconsquare.Visible = True
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = False
        pbprimaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.bspb1
        primaryselected = "f1s3"
    End Sub
    Private Sub rbp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp4.Click
        pbprimaryiconsquare.Visible = False
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = True
        pbprimaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s0
        primaryselected = "f2s0"
    End Sub
    Private Sub rbp5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp5.Click
        pbprimaryiconsquare.Visible = False
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = True
        pbprimaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s8
        primaryselected = "f2s8"
    End Sub
    Private Sub rbp6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp6.Click
        pbprimaryiconsquare.Visible = False
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = True
        pbprimaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s2
        primaryselected = "f2s2"
    End Sub
    Private Sub rbp7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp7.Click
        pbprimaryiconsquare.Visible = False
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = True
        pbprimaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s10
        primaryselected = "f2s10"
    End Sub
    Private Sub rbs1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs1.Click
        pbsecondaryiconsquare.Visible = True
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = False
        pbsecondaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.spb1
        secondaryselected = "f1s0"
    End Sub
    Private Sub rbs2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs2.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryiconwide.Visible = False
        pbsecondaryposter.Visible = True
        secondaryselected = "poster"
    End Sub
    Private Sub rbs3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs3.Click
        pbsecondaryiconsquare.Visible = True
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = False
        pbsecondaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.bspb1
        secondaryselected = "f1s3"
    End Sub
    Private Sub rbs4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs4.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = True
        pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s0
        secondaryselected = "f2s0"
    End Sub
    Private Sub rbs5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs5.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = True
        pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s8
        secondaryselected = "f2s8"
    End Sub
    Private Sub rbs6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs6.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = True
        pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s2
        secondaryselected = "f2s2"
    End Sub
    Private Sub rbs7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs7.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = True
        pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s10
        secondaryselected = "f2s10"
    End Sub
    Private Sub rbs8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs8.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = False
        'pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s10
    End Sub
    Private Sub rbs9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbs9.Click
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = False
        ' pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s10
        secondaryselected = "none"

    End Sub


   
    Private Sub rbp9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbp9.CheckedChanged
        cbimpaposter.Checked = False
        cbmeligrovefanart.Checked = False
        pbsecondaryiconsquare.Visible = False
        pbsecondaryposter.Visible = False
        pbsecondaryiconwide.Visible = False
        pbprimaryiconsquare.Visible = False
        pbprimaryposter.Visible = False
        pbprimaryiconwide.Visible = False
        rbs9.Checked = True
        primaryselected = "none"
        secondaryselected = "none"
    End Sub

    Private Sub btnMediaDataOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMediaDataOnly.Click
        'autopilot(primary, secondary, posterTru, fanartTru, tbnTru, nfoTru, overwritenfoTru)
        Dim buseposter, busefanart, bcnfo, bctbn, bonfo, boei As Boolean
        buseposter = False
        busefanart = False
        bcnfo = False
        bctbn = False
        bonfo = False
        boei = False

        If maincollection.lbMyMovies.Items.Count <= 0 Then
            Debug.Print("no items in drop down, attempting to get some")
            maincollection.readfolderdatafordropdown()

            If maincollection.lbMyMovies.Items.Count <= 0 Then
                Debug.Print(maincollection.lbMyMovies.Items.Count.ToString)
                MsgBox("There's nothing in the folder to process")
                Exit Sub
            End If
        End If

        'If primaryselected = "" Then
        '    'MsgBox("You need to select a primary icon type")
        'Else
        '    Debug.Print("Primary set to: " + primaryselected)
        '    Debug.Print("Secondary set to: " + secondaryselected)
        '    Debug.Print("use poster: " + buseposter.ToString + "use fanart: " + busefanart.ToString + "create tbn: " + bctbn.ToString + "create nfo: " + bcnfo.ToString + "overwrite nfo:" + bonfo.ToString)
        maincollection.autopilotfromform(primaryselected, secondaryselected, buseposter, busefanart, bctbn, bcnfo, bonfo, boei, True)
        'End If



    End Sub
End Class
