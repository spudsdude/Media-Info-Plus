Imports System.Windows.Forms
Imports movieinfoplus.maincollection
Imports System.IO

Public Class dlgTagIconSelection
    Dim rootfolder As String = movieinfoplus.maincollection.rconf.resourcefolder
    Dim rconf As configuration = movieinfoplus.maincollection.rconf
    Dim dvdiconsdir As String = rootfolder + "\tagimages\default\dvd\"
    Dim sdiconsdir As String = rootfolder + "\tagimages\default\sd\"
    Dim divxiconsdir As String = rootfolder + "\tagimages\default\divx\"
    Dim xvidiconsdir As String = rootfolder + "\tagimages\default\xvid\"
    Dim x1080iiconsdir As String = rootfolder + "\tagimages\default\1080i\"
    Dim x1080piconsdir As String = rootfolder + "\tagimages\default\1080p\"
    Dim x720piconsdir As String = rootfolder + "\tagimages\default\720p\"
    Dim blurayiconsdir As String = rootfolder + "\tagimages\default\bluray\"
    Dim audioiconsdir As String = rootfolder + "\tagimages\default\audio\"
    Dim selectedicondir As String = rootfolder + "\tagimages\selectedimages\"
    Dim custom1icondir As String = rootfolder + "\tagimages\default\custom1\"
    Dim custom2icondir As String = rootfolder + "\tagimages\default\custom2\"
    Dim custom3icondir As String = rootfolder + "\tagimages\default\custom3\"
    'audio folders
    Dim monoiconsdir As String = audioiconsdir + "\mono\"
    Dim stereoiconsdir As String = audioiconsdir + "\stereo\"
    Dim x51iconsdir As String = audioiconsdir + "\51\"
    Dim x71iconsdir As String = audioiconsdir + "\71\"
    Dim dtsiconsdir As String = audioiconsdir + "\dts\"
    Dim dtsesiconsdir As String = audioiconsdir + "\dtses\"
    Dim hdaudioiconsdir As String = audioiconsdir + "\hdaudio\"
    Dim locofcurimage As String = rconf.resourcefolder + "tagimages\samples\1.jpg"
    Public myselectedimagefortagging As String = ""

    Private Sub dlgTagIconSelection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Directory.Exists(selectedicondir) Then Directory.CreateDirectory(selectedicondir) 'Exit Sub 'this must be there with icons in it, so exit if it's not
        If Not Directory.Exists(dvdiconsdir) Then Directory.CreateDirectory(dvdiconsdir)
        If Not Directory.Exists(sdiconsdir) Then Directory.CreateDirectory(sdiconsdir)
        If Not Directory.Exists(divxiconsdir) Then Directory.CreateDirectory(divxiconsdir)
        If Not Directory.Exists(xvidiconsdir) Then Directory.CreateDirectory(xvidiconsdir)
        If Not Directory.Exists(x1080iiconsdir) Then Directory.CreateDirectory(x1080iiconsdir)
        If Not Directory.Exists(x1080piconsdir) Then Directory.CreateDirectory(x1080piconsdir)
        If Not Directory.Exists(x720piconsdir) Then Directory.CreateDirectory(x720piconsdir)
        If Not Directory.Exists(blurayiconsdir) Then Directory.CreateDirectory(blurayiconsdir)
        If Not Directory.Exists(audioiconsdir) Then Directory.CreateDirectory(audioiconsdir)
        If Not Directory.Exists(selectedicondir) Then Directory.CreateDirectory(selectedicondir)
        If Not Directory.Exists(custom1icondir) Then Directory.CreateDirectory(custom1icondir)
        If Not Directory.Exists(custom2icondir) Then Directory.CreateDirectory(custom2icondir)
        If Not Directory.Exists(custom3icondir) Then Directory.CreateDirectory(custom3icondir)
        If Not Directory.Exists(monoiconsdir) Then Directory.CreateDirectory(monoiconsdir)
        If Not Directory.Exists(stereoiconsdir) Then Directory.CreateDirectory(stereoiconsdir)
        If Not Directory.Exists(x51iconsdir) Then Directory.CreateDirectory(x51iconsdir)
        If Not Directory.Exists(x71iconsdir) Then Directory.CreateDirectory(x71iconsdir)
        If Not Directory.Exists(dtsiconsdir) Then Directory.CreateDirectory(dtsiconsdir)
        If Not Directory.Exists(dtsesiconsdir) Then Directory.CreateDirectory(dtsesiconsdir)
        If Not Directory.Exists(hdaudioiconsdir) Then Directory.CreateDirectory(hdaudioiconsdir)
        'setup from conf file
        knudMargin.Value = CDec(rconf.overlayMargin)
        knudSize.Value = CDec(rconf.overlayHeight)
        If rconf.type = ".jpg" Then rbTypeJPG.Checked = True
        If rconf.type = ".png" Then rbTypePNG.Checked = True
        loadicons()
        loadsample()

    End Sub
    Private Sub loadsample()
        pbsizetest.Image = Nothing
        pbsizetest.ImageLocation = Nothing
        pbsizetest.ImageLocation = locofcurimage
        pbsizetest.Load()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub loadicons()
        'load dvd icons from folder
        Dim dvdfilelist() As String = Directory.GetFiles(dvdiconsdir)
        Dim dvdcurcount As Integer = 0
        Dim dvdloopcount As Integer = 0
        While dvdloopcount < dvdfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(dvdfilelist(dvdloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    dvdloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                dvdloopcount += 1
                Continue While
            End Try
            Select Case dvdcurcount
                Case 0
                    pbdvd1.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd1.Enabled = True
                    pbdvd1.Load()
                Case 1
                    pbdvd2.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd2.Enabled = True
                    pbdvd2.Load()
                Case 2
                    pbdvd3.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd3.Enabled = True
                    pbdvd3.Load()
                Case 3
                    pbdvd4.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd4.Enabled = True
                    pbdvd4.Load()
                Case 4
                    pbdvd5.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd5.Enabled = True
                    pbdvd5.Load()
                Case 5
                    pbdvd6.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd6.Enabled = True
                    pbdvd6.Load()
                Case 6
                    pbdvd7.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd7.Enabled = True
                    pbdvd7.Load()
                Case 7
                    pbdvd8.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd8.Enabled = True
                    pbdvd8.Load()
                Case 8
                    pbdvd9.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd9.Enabled = True
                    pbdvd9.Load()
                Case 9
                    pbdvd10.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd10.Enabled = True
                    pbdvd10.Load()
                Case 10
                    pbdvd11.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd11.Enabled = True
                    pbdvd11.Load()
                Case 11
                    pbdvd12.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd12.Enabled = True
                    pbdvd12.Load()
                Case 12
                    pbdvd13.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd13.Enabled = True
                    pbdvd13.Load()
                Case 13
                    pbdvd14.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd14.Enabled = True
                    pbdvd14.Load()
                Case 14
                    pbdvd15.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd15.Enabled = True
                    pbdvd15.Load()
                Case 15
                    pbdvd16.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd16.Enabled = True
                    pbdvd16.Load()
                Case 16
                    pbdvd17.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd17.Enabled = True
                    pbdvd17.Load()
                Case 17
                    pbdvd18.ImageLocation = dvdfilelist(dvdloopcount)
                    pbdvd18.Enabled = True
                    pbdvd18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            dvdcurcount += 1 'increment the pbcounter
            dvdloopcount += 1 'increment the loop counter
        End While
        Try
            pbdvdselected.ImageLocation = selectedicondir + "dvd.png"
            pbdvdselected.Load()
        Catch ex As Exception

        End Try


        'load sd icons from folder
        Dim sdfilelist() As String = Directory.GetFiles(sdiconsdir)
        Dim sdcurcount As Integer = 0
        Dim sdloopcount As Integer = 0
        While sdcurcount < sdfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(sdfilelist(sdloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    sdloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                sdcurcount += 1
                Continue While
            End Try
            Select Case sdcurcount
                Case 0
                    pbsd1.ImageLocation = sdfilelist(sdloopcount)
                    pbsd1.Enabled = True
                    pbsd1.Load()
                Case 1
                    pbsd2.ImageLocation = sdfilelist(sdloopcount)
                    pbsd2.Enabled = True
                    pbsd2.Load()
                Case 2
                    pbsd3.ImageLocation = sdfilelist(sdloopcount)
                    pbsd3.Enabled = True
                    pbsd3.Load()
                Case 3
                    pbsd4.ImageLocation = sdfilelist(sdloopcount)
                    pbsd4.Enabled = True
                    pbsd4.Load()
                Case 4
                    pbsd5.ImageLocation = sdfilelist(sdloopcount)
                    pbsd5.Enabled = True
                    pbsd5.Load()
                Case 5
                    pbsd6.ImageLocation = sdfilelist(sdloopcount)
                    pbsd6.Enabled = True
                    pbsd6.Load()
                Case 6
                    pbsd7.ImageLocation = sdfilelist(sdloopcount)
                    pbsd7.Enabled = True
                    pbsd7.Load()
                Case 7
                    pbsd8.ImageLocation = sdfilelist(sdloopcount)
                    pbsd8.Enabled = True
                    pbsd8.Load()
                Case 8
                    pbsd9.ImageLocation = sdfilelist(sdloopcount)
                    pbsd9.Enabled = True
                    pbsd9.Load()
                Case 9
                    pbsd10.ImageLocation = sdfilelist(sdloopcount)
                    pbsd10.Enabled = True
                    pbsd10.Load()
                Case 10
                    pbsd11.ImageLocation = sdfilelist(sdloopcount)
                    pbsd11.Enabled = True
                    pbsd11.Load()
                Case 11
                    pbsd12.ImageLocation = sdfilelist(sdloopcount)
                    pbsd12.Enabled = True
                    pbsd12.Load()
                Case 12
                    pbsd13.ImageLocation = sdfilelist(sdloopcount)
                    pbsd13.Enabled = True
                    pbsd13.Load()
                Case 13
                    pbsd14.ImageLocation = sdfilelist(sdloopcount)
                    pbsd14.Enabled = True
                    pbsd14.Load()
                Case 14
                    pbsd15.ImageLocation = sdfilelist(sdloopcount)
                    pbsd15.Enabled = True
                    pbsd15.Load()
                Case 15
                    pbsd16.ImageLocation = sdfilelist(sdloopcount)
                    pbsd16.Enabled = True
                    pbsd16.Load()
                Case 16
                    pbsd17.ImageLocation = sdfilelist(sdloopcount)
                    pbsd17.Enabled = True
                    pbsd17.Load()
                Case 17
                    pbsd18.ImageLocation = sdfilelist(sdloopcount)
                    pbsd18.Enabled = True
                    pbsd18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            sdcurcount += 1
            sdloopcount += 1
        End While
        Try
            pbsdselected.ImageLocation = selectedicondir + "sd.png"
            pbsdselected.Load()
        Catch ex As Exception

        End Try


        'load divx icons from folder
        Dim divxfilelist() As String = Directory.GetFiles(divxiconsdir)
        Dim divxcurcount As Integer = 0
        Dim divxloopcount As Integer = 0
        While divxcurcount < divxfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(divxfilelist(divxloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    divxloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                divxcurcount += 1
                Continue While
            End Try
            Select Case divxcurcount
                Case 0
                    pbdivx1.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx1.Enabled = True
                    pbdivx1.Load()
                Case 1
                    pbdivx2.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx2.Enabled = True
                    pbdivx2.Load()
                Case 2
                    pbdivx3.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx3.Enabled = True
                    pbdivx3.Load()
                Case 3
                    pbdivx4.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx4.Enabled = True
                    pbdivx4.Load()
                Case 4
                    pbdivx5.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx5.Enabled = True
                    pbdivx5.Load()
                Case 5
                    pbdivx6.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx6.Enabled = True
                    pbdivx6.Load()
                Case 6
                    pbdivx7.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx7.Enabled = True
                    pbdivx7.Load()
                Case 7
                    pbdivx8.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx8.Enabled = True
                    pbdivx8.Load()
                Case 8
                    pbdivx9.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx9.Enabled = True
                    pbdivx9.Load()
                Case 9
                    pbdivx10.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx10.Enabled = True
                    pbdivx10.Load()
                Case 10
                    pbdivx11.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx11.Enabled = True
                    pbdivx11.Load()
                Case 11
                    pbdivx12.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx12.Enabled = True
                    pbdivx12.Load()
                Case 12
                    pbdivx13.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx13.Enabled = True
                    pbdivx13.Load()
                Case 13
                    pbdivx14.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx14.Enabled = True
                    pbdivx14.Load()
                Case 14
                    pbdivx15.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx15.Enabled = True
                    pbdivx15.Load()
                Case 15
                    pbdivx16.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx16.Enabled = True
                    pbdivx16.Load()
                Case 16
                    pbdivx17.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx17.Enabled = True
                    pbdivx17.Load()
                Case 17
                    pbdivx18.ImageLocation = divxfilelist(divxloopcount)
                    pbdivx18.Enabled = True
                    pbdivx18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            divxcurcount += 1
            divxloopcount += 1
        End While
        Try
            pbdivxselected.ImageLocation = selectedicondir + "divx.png"
            pbdivxselected.Load()
        Catch ex As Exception

        End Try


        'load xvid icons from folder
        Dim xvidfilelist() As String = Directory.GetFiles(xvidiconsdir)
        Dim xvidcurcount As Integer = 0
        Dim xvidloopcount As Integer = 0
        While xvidcurcount < xvidfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xvidfilelist(xvidloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xvidloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xvidcurcount += 1
                Continue While
            End Try
            Select Case xvidcurcount
                Case 0
                    pbxvid1.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid1.Enabled = True
                    pbxvid1.Load()
                Case 1
                    pbxvid2.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid2.Enabled = True
                    pbxvid2.Load()
                Case 2
                    pbxvid3.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid3.Enabled = True
                    pbxvid3.Load()
                Case 3
                    pbxvid4.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid4.Enabled = True
                    pbxvid4.Load()
                Case 4
                    pbxvid5.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid5.Enabled = True
                    pbxvid5.Load()
                Case 5
                    pbxvid6.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid6.Enabled = True
                    pbxvid6.Load()
                Case 6
                    pbxvid7.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid7.Enabled = True
                    pbxvid7.Load()
                Case 7
                    pbxvid8.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid8.Enabled = True
                    pbxvid8.Load()
                Case 8
                    pbxvid9.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid9.Enabled = True
                    pbxvid9.Load()
                Case 9
                    pbxvid10.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid10.Enabled = True
                    pbxvid10.Load()
                Case 10
                    pbxvid11.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid11.Enabled = True
                    pbxvid11.Load()
                Case 11
                    pbxvid12.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid12.Enabled = True
                    pbxvid12.Load()
                Case 12
                    pbxvid13.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid13.Enabled = True
                    pbxvid13.Load()
                Case 13
                    pbxvid14.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid14.Enabled = True
                    pbxvid14.Load()
                Case 14
                    pbxvid15.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid15.Enabled = True
                    pbxvid15.Load()
                Case 15
                    pbxvid16.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid16.Enabled = True
                    pbxvid16.Load()
                Case 16
                    pbxvid17.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid17.Enabled = True
                    pbxvid17.Load()
                Case 17
                    pbxvid18.ImageLocation = xvidfilelist(xvidloopcount)
                    pbxvid18.Enabled = True
                    pbxvid18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xvidcurcount += 1
            xvidloopcount += 1
        End While
        Try
            pbxvidselected.ImageLocation = selectedicondir + "xvid.png"
            pbxvidselected.Load()
        Catch ex As Exception

        End Try


        'load x1080i icons from folder
        Dim x1080ifilelist() As String = Directory.GetFiles(x1080iiconsdir)
        Dim x1080icurcount As Integer = 0
        Dim x1080iloopcount As Integer = 0
        While x1080icurcount < x1080ifilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(x1080ifilelist(x1080iloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    x1080iloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                x1080icurcount += 1
                Continue While
            End Try
            Select Case x1080icurcount
                Case 0
                    pb1080i1.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i1.Enabled = True
                    pb1080i1.Load()
                Case 1
                    pb1080i2.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i2.Enabled = True
                    pb1080i2.Load()
                Case 2
                    pb1080i3.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i3.Enabled = True
                    pb1080i3.Load()
                Case 3
                    pb1080i4.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i4.Enabled = True
                    pb1080i4.Load()
                Case 4
                    pb1080i5.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i5.Enabled = True
                    pb1080i5.Load()
                Case 5
                    pb1080i6.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i6.Enabled = True
                    pb1080i6.Load()
                Case 6
                    pb1080i7.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i7.Enabled = True
                    pb1080i7.Load()
                Case 7
                    pb1080i8.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i8.Enabled = True
                    pb1080i8.Load()
                Case 8
                    pb1080i9.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i9.Enabled = True
                    pb1080i9.Load()
                Case 9
                    pb1080i10.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i10.Enabled = True
                    pb1080i10.Load()
                Case 10
                    pb1080i11.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i11.Enabled = True
                    pb1080i11.Load()
                Case 11
                    pb1080i12.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i12.Enabled = True
                    pb1080i12.Load()
                Case 12
                    pb1080i13.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i13.Enabled = True
                    pb1080i13.Load()
                Case 13
                    pb1080i14.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i14.Enabled = True
                    pb1080i14.Load()
                Case 14
                    pb1080i15.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i15.Enabled = True
                    pb1080i15.Load()
                Case 15
                    pb1080i16.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i16.Enabled = True
                    pb1080i16.Load()
                Case 16
                    pb1080i17.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i17.Enabled = True
                    pb1080i17.Load()
                Case 17
                    pb1080i18.ImageLocation = x1080ifilelist(x1080iloopcount)
                    pb1080i18.Enabled = True
                    pb1080i18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            x1080icurcount += 1
            x1080iloopcount += 1
        End While
        Try
            pb1080iselected.ImageLocation = selectedicondir + "1080i.png"
            pb1080iselected.Load()
        Catch ex As Exception

        End Try


        'load x1080p icons from folder
        Dim x1080pfilelist() As String = Directory.GetFiles(x1080piconsdir)
        Dim x1080pcurcount As Integer = 0
        Dim x1080ploopcount As Integer = 0
        While x1080pcurcount < x1080pfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(x1080pfilelist(x1080ploopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    x1080ploopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                x1080pcurcount += 1
                Continue While
            End Try
            Select Case x1080pcurcount
                Case 0
                    pb1080p1.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p1.Enabled = True
                    pb1080p1.Load()
                Case 1
                    pb1080p2.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p2.Enabled = True
                    pb1080p2.Load()
                Case 2
                    pb1080p3.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p3.Enabled = True
                    pb1080p3.Load()
                Case 3
                    pb1080p4.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p4.Enabled = True
                    pb1080p4.Load()
                Case 4
                    pb1080p5.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p5.Enabled = True
                    pb1080p5.Load()
                Case 5
                    pb1080p6.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p6.Enabled = True
                    pb1080p6.Load()
                Case 6
                    pb1080p7.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p7.Enabled = True
                    pb1080p7.Load()
                Case 7
                    pb1080p8.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p8.Enabled = True
                    pb1080p8.Load()
                Case 8
                    pb1080p9.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p9.Enabled = True
                    pb1080p9.Load()
                Case 9
                    pb1080p10.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p10.Enabled = True
                    pb1080p10.Load()
                Case 10
                    pb1080p11.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p11.Enabled = True
                    pb1080p11.Load()
                Case 11
                    pb1080p12.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p12.Enabled = True
                    pb1080p12.Load()
                Case 12
                    pb1080p13.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p13.Enabled = True
                    pb1080p13.Load()
                Case 13
                    pb1080p14.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p14.Enabled = True
                    pb1080p14.Load()
                Case 14
                    pb1080p15.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p15.Enabled = True
                    pb1080p15.Load()
                Case 15
                    pb1080p16.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p16.Enabled = True
                    pb1080p16.Load()
                Case 16
                    pb1080p17.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p17.Enabled = True
                    pb1080p17.Load()
                Case 17
                    pb1080p18.ImageLocation = x1080pfilelist(x1080ploopcount)
                    pb1080p18.Enabled = True
                    pb1080p18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            x1080pcurcount += 1
            x1080ploopcount += 1
        End While
        Try
            pb1080pselected.ImageLocation = selectedicondir + "1080p.png"
            pb1080pselected.Load()
        Catch ex As Exception

        End Try


        'load x720p icons from folder
        Dim x720pfilelist() As String = Directory.GetFiles(x720piconsdir)
        Dim x720pcurcount As Integer = 0
        Dim x720ploopcount As Integer = 0
        While x720pcurcount < x720pfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(x720pfilelist(x720ploopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    x720ploopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                x720pcurcount += 1
                Continue While
            End Try
            Select Case x720pcurcount
                Case 0
                    pb720p1.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p1.Enabled = True
                    pb720p1.Load()
                Case 1
                    pb720p2.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p2.Enabled = True
                    pb720p2.Load()
                Case 2
                    pb720p3.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p3.Enabled = True
                    pb720p3.Load()
                Case 3
                    pb720p4.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p4.Enabled = True
                    pb720p4.Load()
                Case 4
                    pb720p5.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p5.Enabled = True
                    pb720p5.Load()
                Case 5
                    pb720p6.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p6.Enabled = True
                    pb720p6.Load()
                Case 6
                    pb720p7.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p7.Enabled = True
                    pb720p7.Load()
                Case 7
                    pb720p8.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p8.Enabled = True
                    pb720p8.Load()
                Case 8
                    pb720p9.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p9.Enabled = True
                    pb720p9.Load()
                Case 9
                    pb720p10.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p10.Enabled = True
                    pb720p10.Load()
                Case 10
                    pb720p11.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p11.Enabled = True
                    pb720p11.Load()
                Case 11
                    pb720p12.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p12.Enabled = True
                    pb720p12.Load()
                Case 12
                    pb720p13.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p13.Enabled = True
                    pb720p13.Load()
                Case 13
                    pb720p14.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p14.Enabled = True
                    pb720p14.Load()
                Case 14
                    pb720p15.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p15.Enabled = True
                    pb720p15.Load()
                Case 15
                    pb720p16.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p16.Enabled = True
                    pb720p16.Load()
                Case 16
                    pb720p17.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p17.Enabled = True
                    pb720p17.Load()
                Case 17
                    pb720p18.ImageLocation = x720pfilelist(x720ploopcount)
                    pb720p18.Enabled = True
                    pb720p18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            x720pcurcount += 1
            x720ploopcount += 1
        End While
        Try
            pb720pselected.ImageLocation = selectedicondir + "720p.png"
            pb720pselected.Load()
        Catch ex As Exception

        End Try


        'load xmono icons from folder
        Dim xmonofilelist() As String = Directory.GetFiles(monoiconsdir)
        Dim xmonocurcount As Integer = 0
        Dim xmonoloopcount As Integer = 0
        While xmonocurcount < xmonofilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xmonofilelist(xmonoloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xmonoloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xmonocurcount += 1
                Continue While
            End Try
            Select Case xmonocurcount
                Case 0
                    pbmono1.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono1.Enabled = True
                    pbmono1.Load()
                Case 1
                    pbmono2.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono2.Enabled = True
                    pbmono2.Load()
                Case 2
                    pbmono3.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono3.Enabled = True
                    pbmono3.Load()
                Case 3
                    pbmono4.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono4.Enabled = True
                    pbmono4.Load()
                Case 4
                    pbmono5.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono5.Enabled = True
                    pbmono5.Load()
                Case 5
                    pbmono6.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono6.Enabled = True
                    pbmono6.Load()
                Case 6
                    pbmono7.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono7.Enabled = True
                    pbmono7.Load()
                Case 7
                    pbmono8.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono8.Enabled = True
                    pbmono8.Load()
                Case 8
                    pbmono9.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono9.Enabled = True
                    pbmono9.Load()
                Case 9
                    pbmono10.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono10.Enabled = True
                    pbmono10.Load()
                Case 10
                    pbmono11.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono11.Enabled = True
                    pbmono11.Load()
                Case 11
                    pbmono12.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono12.Enabled = True
                    pbmono12.Load()
                Case 12
                    pbmono13.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono13.Enabled = True
                    pbmono13.Load()
                Case 13
                    pbmono14.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono14.Enabled = True
                    pbmono14.Load()
                Case 14
                    pbmono15.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono15.Enabled = True
                    pbmono15.Load()
                Case 15
                    pbmono16.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono16.Enabled = True
                    pbmono16.Load()
                Case 16
                    pbmono17.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono17.Enabled = True
                    pbmono17.Load()
                Case 17
                    pbmono18.ImageLocation = xmonofilelist(xmonoloopcount)
                    pbmono18.Enabled = True
                    pbmono18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xmonocurcount += 1
            xmonoloopcount += 1
        End While
        Try
            pbmonoselected.ImageLocation = selectedicondir + "mono.png"
            pbmonoselected.Load()
        Catch ex As Exception

        End Try


        'load xbluray icons from folder
        Dim xblurayfilelist() As String = Directory.GetFiles(blurayiconsdir)
        Dim xbluraycurcount As Integer = 0
        Dim xblurayloopcount As Integer = 0
        While xbluraycurcount < xblurayfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xblurayfilelist(xblurayloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xblurayloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xbluraycurcount += 1
                Continue While
            End Try
            Select Case xbluraycurcount
                Case 0
                    pbbluray1.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray1.Enabled = True
                    pbbluray1.Load()
                Case 1
                    pbbluray2.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray2.Enabled = True
                    pbbluray2.Load()
                Case 2
                    pbbluray3.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray3.Enabled = True
                    pbbluray3.Load()
                Case 3
                    pbbluray4.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray4.Enabled = True
                    pbbluray4.Load()
                Case 4
                    pbbluray5.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray5.Enabled = True
                    pbbluray5.Load()
                Case 5
                    pbbluray6.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray6.Enabled = True
                    pbbluray6.Load()
                Case 6
                    pbbluray7.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray7.Enabled = True
                    pbbluray7.Load()
                Case 7
                    pbbluray8.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray8.Enabled = True
                    pbbluray8.Load()
                Case 8
                    pbbluray9.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray9.Enabled = True
                    pbbluray9.Load()
                Case 9
                    pbbluray10.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray10.Enabled = True
                    pbbluray10.Load()
                Case 10
                    pbbluray11.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray11.Enabled = True
                    pbbluray11.Load()
                Case 11
                    pbbluray12.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray12.Enabled = True
                    pbbluray12.Load()
                Case 12
                    pbbluray13.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray13.Enabled = True
                    pbbluray13.Load()
                Case 13
                    pbbluray14.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray14.Enabled = True
                    pbbluray14.Load()
                Case 14
                    pbbluray15.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray15.Enabled = True
                    pbbluray15.Load()
                Case 15
                    pbbluray16.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray16.Enabled = True
                    pbbluray16.Load()
                Case 16
                    pbbluray17.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray17.Enabled = True
                    pbbluray17.Load()
                Case 17
                    pbbluray18.ImageLocation = xblurayfilelist(xblurayloopcount)
                    pbbluray18.Enabled = True
                    pbbluray18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xbluraycurcount += 1
            xblurayloopcount += 1
        End While
        Try
            pbblurayselected.ImageLocation = selectedicondir + "bluray.png"
            pbblurayselected.Load()
        Catch ex As Exception

        End Try


        'load xstereo icons from folder
        Dim xstereofilelist() As String = Directory.GetFiles(stereoiconsdir)
        Dim xstereocurcount As Integer = 0
        Dim xstereoloopcount As Integer = 0
        While xstereocurcount < xstereofilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xstereofilelist(xstereoloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xstereoloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xstereocurcount += 1
                Continue While
            End Try
            Select Case xstereocurcount
                Case 0
                    pbstereo1.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo1.Enabled = True
                    pbstereo1.Load()
                Case 1
                    pbstereo2.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo2.Enabled = True
                    pbstereo2.Load()
                Case 2
                    pbstereo3.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo3.Enabled = True
                    pbstereo3.Load()
                Case 3
                    pbstereo4.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo4.Enabled = True
                    pbstereo4.Load()
                Case 4
                    pbstereo5.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo5.Enabled = True
                    pbstereo5.Load()
                Case 5
                    pbstereo6.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo6.Enabled = True
                    pbstereo6.Load()
                Case 6
                    pbstereo7.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo7.Enabled = True
                    pbstereo7.Load()
                Case 7
                    pbstereo8.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo8.Enabled = True
                    pbstereo8.Load()
                Case 8
                    pbstereo9.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo9.Enabled = True
                    pbstereo9.Load()
                Case 9
                    pbstereo10.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo10.Enabled = True
                    pbstereo10.Load()
                Case 10
                    pbstereo11.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo11.Enabled = True
                    pbstereo11.Load()
                Case 11
                    pbstereo12.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo12.Enabled = True
                    pbstereo12.Load()
                Case 12
                    pbstereo13.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo13.Enabled = True
                    pbstereo13.Load()
                Case 13
                    pbstereo14.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo14.Enabled = True
                    pbstereo14.Load()
                Case 14
                    pbstereo15.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo15.Enabled = True
                    pbstereo15.Load()
                Case 15
                    pbstereo16.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo16.Enabled = True
                    pbstereo16.Load()
                Case 16
                    pbstereo17.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo17.Enabled = True
                    pbstereo17.Load()
                Case 17
                    pbstereo18.ImageLocation = xstereofilelist(xstereoloopcount)
                    pbstereo18.Enabled = True
                    pbstereo18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xstereocurcount += 1
            xstereoloopcount += 1
        End While
        Try
            pbstereoselected.ImageLocation = selectedicondir + "stereo.png"
            pbstereoselected.Load()
        Catch ex As Exception

        End Try


        'load x51 icons from folder
        Dim x51filelist() As String = Directory.GetFiles(x51iconsdir)
        Dim x51curcount As Integer = 0
        Dim x51loopcount As Integer = 0
        While x51curcount < x51filelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(x51filelist(x51loopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    x51loopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                x51curcount += 1
                Continue While
            End Try
            Select Case x51curcount
                Case 0
                    pb511.ImageLocation = x51filelist(x51loopcount)
                    pb511.Enabled = True
                    pb511.Load()
                Case 1
                    pb512.ImageLocation = x51filelist(x51loopcount)
                    pb512.Enabled = True
                    pb512.Load()
                Case 2
                    pb513.ImageLocation = x51filelist(x51loopcount)
                    pb513.Enabled = True
                    pb513.Load()
                Case 3
                    pb514.ImageLocation = x51filelist(x51loopcount)
                    pb514.Enabled = True
                    pb514.Load()
                Case 4
                    pb515.ImageLocation = x51filelist(x51loopcount)
                    pb515.Enabled = True
                    pb515.Load()
                Case 5
                    pb516.ImageLocation = x51filelist(x51loopcount)
                    pb516.Enabled = True
                    pb516.Load()
                Case 6
                    pb517.ImageLocation = x51filelist(x51loopcount)
                    pb517.Enabled = True
                    pb517.Load()
                Case 7
                    pb518.ImageLocation = x51filelist(x51loopcount)
                    pb518.Enabled = True
                    pb518.Load()
                Case 8
                    pb519.ImageLocation = x51filelist(x51loopcount)
                    pb519.Enabled = True
                    pb519.Load()
                Case 9
                    pb5110.ImageLocation = x51filelist(x51loopcount)
                    pb5110.Enabled = True
                    pb5110.Load()
                Case 10
                    pb5111.ImageLocation = x51filelist(x51loopcount)
                    pb5111.Enabled = True
                    pb5111.Load()
                Case 11
                    pb5112.ImageLocation = x51filelist(x51loopcount)
                    pb5112.Enabled = True
                    pb5112.Load()
                Case 12
                    pb5113.ImageLocation = x51filelist(x51loopcount)
                    pb5113.Enabled = True
                    pb5113.Load()
                Case 13
                    pb5114.ImageLocation = x51filelist(x51loopcount)
                    pb5114.Enabled = True
                    pb5114.Load()
                Case 14
                    pb5115.ImageLocation = x51filelist(x51loopcount)
                    pb5115.Enabled = True
                    pb5115.Load()
                Case 15
                    pb5116.ImageLocation = x51filelist(x51loopcount)
                    pb5116.Enabled = True
                    pb5116.Load()
                Case 16
                    pb5117.ImageLocation = x51filelist(x51loopcount)
                    pb5117.Enabled = True
                    pb5117.Load()
                Case 17
                    pb5118.ImageLocation = x51filelist(x51loopcount)
                    pb5118.Enabled = True
                    pb5118.Load()
                Case Else
                    'nothing to do with that 
            End Select
            x51curcount += 1
            x51loopcount += 1
        End While

        Try
            pb51selected.ImageLocation = selectedicondir + "5.1.png"
            pb51selected.Load()
        Catch ex As Exception

        End Try



        'load x71 icons from folder
        Dim x71filelist() As String = Directory.GetFiles(x71iconsdir)
        Dim x71curcount As Integer = 0
        Dim x71loopcount As Integer = 0
        While x71curcount < x71filelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(x71filelist(x71loopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    x71loopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                x71curcount += 1
                Continue While
            End Try
            Select Case x71curcount
                Case 0
                    pb711.ImageLocation = x71filelist(x71loopcount)
                    pb711.Enabled = True
                    pb711.Load()
                Case 1
                    pb712.ImageLocation = x71filelist(x71loopcount)
                    pb712.Enabled = True
                    pb712.Load()
                Case 2
                    pb713.ImageLocation = x71filelist(x71loopcount)
                    pb713.Enabled = True
                    pb713.Load()
                Case 3
                    pb714.ImageLocation = x71filelist(x71loopcount)
                    pb714.Enabled = True
                    pb714.Load()
                Case 4
                    pb715.ImageLocation = x71filelist(x71loopcount)
                    pb715.Enabled = True
                    pb715.Load()
                Case 5
                    pb716.ImageLocation = x71filelist(x71loopcount)
                    pb716.Enabled = True
                    pb716.Load()
                Case 6
                    pb717.ImageLocation = x71filelist(x71loopcount)
                    pb717.Enabled = True
                    pb717.Load()
                Case 7
                    pb718.ImageLocation = x71filelist(x71loopcount)
                    pb718.Enabled = True
                    pb718.Load()
                Case 8
                    pb719.ImageLocation = x71filelist(x71loopcount)
                    pb719.Enabled = True
                    pb719.Load()
                Case 9
                    pb7110.ImageLocation = x71filelist(x71loopcount)
                    pb7110.Enabled = True
                    pb7110.Load()
                Case 10
                    pb7111.ImageLocation = x71filelist(x71loopcount)
                    pb7111.Enabled = True
                    pb7111.Load()
                Case 11
                    pb7112.ImageLocation = x71filelist(x71loopcount)
                    pb7112.Enabled = True
                    pb7112.Load()
                Case 12
                    pb7113.ImageLocation = x71filelist(x71loopcount)
                    pb7113.Enabled = True
                    pb7113.Load()
                Case 13
                    pb7114.ImageLocation = x71filelist(x71loopcount)
                    pb7114.Enabled = True
                    pb7114.Load()
                Case 14
                    pb7115.ImageLocation = x71filelist(x71loopcount)
                    pb7115.Enabled = True
                    pb7115.Load()
                Case 15
                    pb7116.ImageLocation = x71filelist(x71loopcount)
                    pb7116.Enabled = True
                    pb7116.Load()
                Case 16
                    pb7117.ImageLocation = x71filelist(x71loopcount)
                    pb7117.Enabled = True
                    pb7117.Load()
                Case 17
                    pb7118.ImageLocation = x71filelist(x71loopcount)
                    pb7118.Enabled = True
                    pb7118.Load()
                Case Else
                    'nothing to do with that 
            End Select
            x71curcount += 1
            x71loopcount += 1
        End While
        Try
            pb71selected.ImageLocation = selectedicondir + "7.1.png"
            pb71selected.Load()
        Catch ex As Exception

        End Try


        'load xdts icons from folder
        Dim xdtsfilelist() As String = Directory.GetFiles(dtsiconsdir)
        Dim xdtscurcount As Integer = 0
        Dim xdtsloopcount As Integer = 0
        While xdtscurcount < xdtsfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xdtsfilelist(xdtsloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xdtsloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xdtscurcount += 1
                Continue While
            End Try
            Select Case xdtscurcount
                Case 0
                    pbdts1.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts1.Enabled = True
                    pbdts1.Load()
                Case 1
                    pbdts2.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts2.Enabled = True
                    pbdts2.Load()
                Case 2
                    pbdts3.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts3.Enabled = True
                    pbdts3.Load()
                Case 3
                    pbdts4.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts4.Enabled = True
                    pbdts4.Load()
                Case 4
                    pbdts5.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts5.Enabled = True
                    pbdts5.Load()
                Case 5
                    pbdts6.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts6.Enabled = True
                    pbdts6.Load()
                Case 6
                    pbdts7.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts7.Enabled = True
                    pbdts7.Load()
                Case 7
                    pbdts8.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts8.Enabled = True
                    pbdts8.Load()
                Case 8
                    pbdts9.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts9.Enabled = True
                    pbdts9.Load()
                Case 9
                    pbdts10.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts10.Enabled = True
                    pbdts10.Load()
                Case 10
                    pbdts11.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts11.Enabled = True
                    pbdts11.Load()
                Case 11
                    pbdts12.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts12.Enabled = True
                    pbdts12.Load()
                Case 12
                    pbdts13.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts13.Enabled = True
                    pbdts13.Load()
                Case 13
                    pbdts14.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts14.Enabled = True
                    pbdts14.Load()
                Case 14
                    pbdts15.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts15.Enabled = True
                    pbdts15.Load()
                Case 15
                    pbdts16.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts16.Enabled = True
                    pbdts16.Load()
                Case 16
                    pbdts17.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts17.Enabled = True
                    pbdts17.Load()
                Case 17
                    pbdts18.ImageLocation = xdtsfilelist(xdtsloopcount)
                    pbdts18.Enabled = True
                    pbdts18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xdtscurcount += 1
            xdtsloopcount += 1
        End While

        Try
            pbdtsselected.ImageLocation = selectedicondir + "dts.png"
            pbdtsselected.Load()
        Catch ex As Exception

        End Try


        'load xdtses icons from folder
        Dim xdtsesfilelist() As String = Directory.GetFiles(dtsesiconsdir)
        Dim xdtsescurcount As Integer = 0
        Dim xdtsesloopcount As Integer = 0
        While xdtsescurcount < xdtsesfilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xdtsesfilelist(xdtsesloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xdtsesloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xdtsescurcount += 1
                Continue While
            End Try
            Select Case xdtsescurcount
                Case 0
                    pbdtses1.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses1.Enabled = True
                    pbdtses1.Load()
                Case 1
                    pbdtses2.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses2.Enabled = True
                    pbdtses2.Load()
                Case 2
                    pbdtses3.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses3.Enabled = True
                    pbdtses3.Load()
                Case 3
                    pbdtses4.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses4.Enabled = True
                    pbdtses4.Load()
                Case 4
                    pbdtses5.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses5.Enabled = True
                    pbdtses5.Load()
                Case 5
                    pbdtses6.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses6.Enabled = True
                    pbdtses6.Load()
                Case 6
                    pbdtses7.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses7.Enabled = True
                    pbdtses7.Load()
                Case 7
                    pbdtses8.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses8.Enabled = True
                    pbdtses8.Load()
                Case 8
                    pbdtses9.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses9.Enabled = True
                    pbdtses9.Load()
                Case 9
                    pbdtses10.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses10.Enabled = True
                    pbdtses10.Load()
                Case 10
                    pbdtses11.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses11.Enabled = True
                    pbdtses11.Load()
                Case 11
                    pbdtses12.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses12.Enabled = True
                    pbdtses12.Load()
                Case 12
                    pbdtses13.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses13.Enabled = True
                    pbdtses13.Load()
                Case 13
                    pbdtses14.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses14.Enabled = True
                    pbdtses14.Load()
                Case 14
                    pbdtses15.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses15.Enabled = True
                    pbdtses15.Load()
                Case 15
                    pbdtses16.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses16.Enabled = True
                    pbdtses16.Load()
                Case 16
                    pbdtses17.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses17.Enabled = True
                    pbdtses17.Load()
                Case 17
                    pbdtses18.ImageLocation = xdtsesfilelist(xdtsesloopcount)
                    pbdtses18.Enabled = True
                    pbdtses18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xdtsescurcount += 1
            xdtsesloopcount += 1
        End While
        Try
            pbdtsesselected.ImageLocation = selectedicondir + "dtses.png"
            pbdtsesselected.Load()
        Catch ex As Exception

        End Try


        'load xhdaudio icons from folder
        Dim xhdaudiofilelist() As String = Directory.GetFiles(hdaudioiconsdir)
        Dim xhdaudiocurcount As Integer = 0
        Dim xhdaudioloopcount As Integer = 0
        While xhdaudiocurcount < xhdaudiofilelist.Length
            Dim allowedextension As Boolean = False
            Try
                Dim ext As String = Strings.Right(xhdaudiofilelist(xhdaudioloopcount), 4)
                If ext = ".png" Or ext = ".jpg" Or ext = ".tbn" Then
                    allowedextension = True
                End If

                If Not allowedextension Then
                    xhdaudioloopcount += 1
                    Continue While
                End If
            Catch ex As Exception
                xhdaudiocurcount += 1
                Continue While
            End Try
            Select Case xhdaudiocurcount
                Case 0
                    pbhdaudio1.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio1.Enabled = True
                    pbhdaudio1.Load()
                Case 1
                    pbhdaudio2.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio2.Enabled = True
                    pbhdaudio2.Load()
                Case 2
                    pbhdaudio3.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio3.Enabled = True
                    pbhdaudio3.Load()
                Case 3
                    pbhdaudio4.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio4.Enabled = True
                    pbhdaudio4.Load()
                Case 4
                    pbhdaudio5.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio5.Enabled = True
                    pbhdaudio5.Load()
                Case 5
                    pbhdaudio6.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio6.Enabled = True
                    pbhdaudio6.Load()
                Case 6
                    pbhdaudio7.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio7.Enabled = True
                    pbhdaudio7.Load()
                Case 7
                    pbhdaudio8.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio8.Enabled = True
                    pbhdaudio8.Load()
                Case 8
                    pbhdaudio9.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio9.Enabled = True
                    pbhdaudio9.Load()
                Case 9
                    pbhdaudio10.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio10.Enabled = True
                    pbhdaudio10.Load()
                Case 10
                    pbhdaudio11.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio11.Enabled = True
                    pbhdaudio11.Load()
                Case 11
                    pbhdaudio12.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio12.Enabled = True
                    pbhdaudio12.Load()
                Case 12
                    pbhdaudio13.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio13.Enabled = True
                    pbhdaudio13.Load()
                Case 13
                    pbhdaudio14.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio14.Enabled = True
                    pbhdaudio14.Load()
                Case 14
                    pbhdaudio15.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio15.Enabled = True
                    pbhdaudio15.Load()
                Case 15
                    pbhdaudio16.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio16.Enabled = True
                    pbhdaudio16.Load()
                Case 16
                    pbhdaudio17.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio17.Enabled = True
                    pbhdaudio17.Load()
                Case 17
                    pbhdaudio18.ImageLocation = xhdaudiofilelist(xhdaudioloopcount)
                    pbhdaudio18.Enabled = True
                    pbhdaudio18.Load()
                Case Else
                    'nothing to do with that 
            End Select
            xhdaudiocurcount += 1
            xhdaudioloopcount += 1
        End While
        Try
            pbhdaudioselected.ImageLocation = selectedicondir + "hdaudio.png"
            pbhdaudioselected.Load()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub saveci(ByRef curpbicon As PictureBox, ByVal type As String)
        If curpbicon.ImageLocation = Nothing Then Exit Sub


        Select Case type
            Case "dvd"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbdvdselected.Image = Nothing
                pbdvdselected.ImageLocation = Nothing
                pbdvdselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbdvdselected.Load()
                Me.Refresh()
            Case "sd"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbsdselected.Image = Nothing
                pbsdselected.ImageLocation = Nothing
                pbsdselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbsdselected.Load()
                Me.Refresh()
            Case "divx"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbdivxselected.Image = Nothing
                pbdivxselected.ImageLocation = Nothing
                pbdivxselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbdivxselected.Load()
                Me.Refresh()
            Case "xvid"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbxvidselected.Image = Nothing
                pbxvidselected.ImageLocation = Nothing
                pbxvidselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbxvidselected.Load()
                Me.Refresh()
            Case "hd"
                'File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                'pbhdselected.Image = Nothing
                'pbhdselected.ImageLocation = Nothing
                'pbhdselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                'pbhdselected.Load()
                'Me.Refresh()
            Case "720p"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pb720pselected.Image = Nothing
                pb720pselected.ImageLocation = Nothing
                pb720pselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pb720pselected.Load()
                Me.Refresh()
            Case "1080i"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pb1080iselected.Image = Nothing
                pb1080iselected.ImageLocation = Nothing
                pb1080iselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pb1080iselected.Load()
                Me.Refresh()
            Case "1080p"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pb1080pselected.Image = Nothing
                pb1080pselected.ImageLocation = Nothing
                pb1080pselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pb1080pselected.Load()
                Me.Refresh()
            Case "bluray"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbblurayselected.Image = Nothing
                pbblurayselected.ImageLocation = Nothing
                pbblurayselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbblurayselected.Load()
                Me.Refresh()
            Case "custom1"
                'File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                'pbcustom1selected.Image = Nothing
                'pbcustom1selected.ImageLocation = Nothing
                'pbcustom1selected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                'pbcustom1selected.Load()
                Me.Refresh()
            Case "custom2"
                'File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                'pbcustom2selected.Image = Nothing
                'pbcustom2selected.ImageLocation = Nothing
                'pbcustom2selected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                'pbcustom2selected.Load()
                Me.Refresh()
            Case "custom3"
                'File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                'pbcustom3selected.Image = Nothing
                'pbcustom3selected.ImageLocation = Nothing
                'pbcustom3selected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                'pbcustom3selected.Load()
                'Me.Refresh()
            Case "5.1"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pb51selected.Image = Nothing
                pb51selected.ImageLocation = Nothing
                pb51selected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pb51selected.Load()
                Me.Refresh()
            Case "7.1"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pb71selected.Image = Nothing
                pb71selected.ImageLocation = Nothing
                pb71selected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pb71selected.Load()
                Me.Refresh()
            Case "stereo"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbstereoselected.Image = Nothing
                pbstereoselected.ImageLocation = Nothing
                pbstereoselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbstereoselected.Load()
                Me.Refresh()
            Case "mono"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbmonoselected.Image = Nothing
                pbmonoselected.ImageLocation = Nothing
                pbmonoselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbmonoselected.Load()
                Me.Refresh()
            Case "dts"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbdtsselected.Image = Nothing
                pbdtsselected.ImageLocation = Nothing
                pbdtsselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbdtsselected.Load()
                Me.Refresh()
            Case "dtses"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbdtsesselected.Image = Nothing
                pbdtsesselected.ImageLocation = Nothing
                pbdtsesselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbdtsesselected.Load()
                Me.Refresh()
            Case "hdaudio"
                File.Copy(curpbicon.ImageLocation, rootfolder + "tagimages\selectedimages\" + type + ".png", True)
                pbhdaudioselected.Image = Nothing
                pbhdaudioselected.ImageLocation = Nothing
                pbhdaudioselected.ImageLocation = rootfolder + "tagimages\selectedimages\" + type + ".png"
                pbhdaudioselected.Load()
                Me.Refresh()
            Case Else
        End Select
    End Sub


#Region "On click events for picture boxes"


    Private Sub pbdvd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd1.Click
        saveci(pbdvd1, "dvd")
    End Sub
    Private Sub pbdvd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd2.Click
        saveci(pbdvd2, "dvd")
    End Sub
    Private Sub pbdvd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd3.Click
        saveci(pbdvd3, "dvd")
    End Sub
    Private Sub pbdvd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd4.Click
        saveci(pbdvd4, "dvd")
    End Sub
    Private Sub pbdvd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd5.Click
        saveci(pbdvd5, "dvd")
    End Sub
    Private Sub pbdvd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd6.Click
        saveci(pbdvd6, "dvd")
    End Sub
    Private Sub pbdvd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd7.Click
        saveci(pbdvd7, "dvd")
    End Sub
    Private Sub pbdvd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd8.Click
        saveci(pbdvd8, "dvd")
    End Sub
    Private Sub pbdvd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd9.Click
        saveci(pbdvd9, "dvd")
    End Sub
    Private Sub pbdvd10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd10.Click
        saveci(pbdvd10, "dvd")
    End Sub
    Private Sub pbdvd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd11.Click
        saveci(pbdvd11, "dvd")
    End Sub
    Private Sub pbdvd12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd12.Click
        saveci(pbdvd12, "dvd")
    End Sub
    Private Sub pbdvd13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd13.Click
        saveci(pbdvd13, "dvd")
    End Sub
    Private Sub pbdvd14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd14.Click
        saveci(pbdvd14, "dvd")
    End Sub
    Private Sub pbdvd15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd15.Click
        saveci(pbdvd15, "dvd")
    End Sub
    Private Sub pbdvd16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd16.Click
        saveci(pbdvd16, "dvd")
    End Sub
    Private Sub pbdvd17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd17.Click
        saveci(pbdvd17, "dvd")
    End Sub
    Private Sub pbdvd18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdvd18.Click
        saveci(pbdvd18, "dvd")
    End Sub

    Private Sub pbsd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd1.Click
        saveci(pbsd1, "sd")
    End Sub
    Private Sub pbsd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd2.Click
        saveci(pbsd2, "sd")
    End Sub
    Private Sub pbsd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd3.Click
        saveci(pbsd3, "sd")
    End Sub
    Private Sub pbsd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd4.Click
        saveci(pbsd4, "sd")
    End Sub
    Private Sub pbsd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd5.Click
        saveci(pbsd5, "sd")
    End Sub
    Private Sub pbsd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd6.Click
        saveci(pbsd6, "sd")
    End Sub
    Private Sub pbsd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd7.Click
        saveci(pbsd7, "sd")
    End Sub
    Private Sub pbsd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd8.Click
        saveci(pbsd8, "sd")
    End Sub
    Private Sub pbsd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd9.Click
        saveci(pbsd9, "sd")
    End Sub
    Private Sub pbsd10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd10.Click
        saveci(pbsd10, "sd")
    End Sub
    Private Sub pbsd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd11.Click
        saveci(pbsd11, "sd")
    End Sub
    Private Sub pbsd12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd12.Click
        saveci(pbsd12, "sd")
    End Sub
    Private Sub pbsd13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd13.Click
        saveci(pbsd13, "sd")
    End Sub
    Private Sub pbsd14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd14.Click
        saveci(pbsd14, "sd")
    End Sub
    Private Sub pbsd15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd15.Click
        saveci(pbsd15, "sd")
    End Sub
    Private Sub pbsd16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd16.Click
        saveci(pbsd16, "sd")
    End Sub
    Private Sub pbsd17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd17.Click
        saveci(pbsd17, "sd")
    End Sub
    Private Sub pbsd18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbsd18.Click
        saveci(pbsd18, "sd")
    End Sub
    Private Sub pb720p1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p1.Click
        saveci(pb720p1, "720p")
    End Sub
    Private Sub pb720p2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p2.Click
        saveci(pb720p2, "720p")
    End Sub
    Private Sub pb720p3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p3.Click
        saveci(pb720p3, "720p")
    End Sub
    Private Sub pb720p4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p4.Click
        saveci(pb720p4, "720p")
    End Sub
    Private Sub pb720p5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p5.Click
        saveci(pb720p5, "720p")
    End Sub
    Private Sub pb720p6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p6.Click
        saveci(pb720p6, "720p")
    End Sub
    Private Sub pb720p7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p7.Click
        saveci(pb720p7, "720p")
    End Sub
    Private Sub pb720p8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p8.Click
        saveci(pb720p8, "720p")
    End Sub
    Private Sub pb720p9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p9.Click
        saveci(pb720p9, "720p")
    End Sub
    Private Sub pb720p10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p10.Click
        saveci(pb720p10, "720p")
    End Sub
    Private Sub pb720p11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p11.Click
        saveci(pb720p11, "720p")
    End Sub
    Private Sub pb720p12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p12.Click
        saveci(pb720p12, "720p")
    End Sub
    Private Sub pb720p13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p13.Click
        saveci(pb720p13, "720p")
    End Sub
    Private Sub pb720p14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p14.Click
        saveci(pb720p14, "720p")
    End Sub
    Private Sub pb720p15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p15.Click
        saveci(pb720p15, "720p")
    End Sub
    Private Sub pb720p16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p16.Click
        saveci(pb720p16, "720p")
    End Sub
    Private Sub pb720p17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p17.Click
        saveci(pb720p17, "720p")
    End Sub
    Private Sub pb720p18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb720p18.Click
        saveci(pb720p18, "720p")
    End Sub
    Private Sub pb1080i1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i1.Click
        saveci(pb1080i1, "1080i")
    End Sub
    Private Sub pb1080i2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i2.Click
        saveci(pb1080i2, "1080i")
    End Sub
    Private Sub pb1080i3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i3.Click
        saveci(pb1080i3, "1080i")
    End Sub
    Private Sub pb1080i4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i4.Click
        saveci(pb1080i4, "1080i")
    End Sub
    Private Sub pb1080i5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i5.Click
        saveci(pb1080i5, "1080i")
    End Sub
    Private Sub pb1080i6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i6.Click
        saveci(pb1080i6, "1080i")
    End Sub
    Private Sub pb1080i7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i7.Click
        saveci(pb1080i7, "1080i")
    End Sub
    Private Sub pb1080i8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i8.Click
        saveci(pb1080i8, "1080i")
    End Sub
    Private Sub pb1080i9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i9.Click
        saveci(pb1080i9, "1080i")
    End Sub
    Private Sub pb1080i10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i10.Click
        saveci(pb1080i10, "1080i")
    End Sub
    Private Sub pb1080i11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i11.Click
        saveci(pb1080i11, "1080i")
    End Sub
    Private Sub pb1080i12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i12.Click
        saveci(pb1080i12, "1080i")
    End Sub
    Private Sub pb1080i13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i13.Click
        saveci(pb1080i13, "1080i")
    End Sub
    Private Sub pb1080i14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i14.Click
        saveci(pb1080i14, "1080i")
    End Sub
    Private Sub pb1080i15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i15.Click
        saveci(pb1080i15, "1080i")
    End Sub
    Private Sub pb1080i16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i16.Click
        saveci(pb1080i16, "1080i")
    End Sub
    Private Sub pb1080i17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i17.Click
        saveci(pb1080i17, "1080i")
    End Sub
    Private Sub pb1080i18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080i18.Click
        saveci(pb1080i18, "1080i")
    End Sub
    Private Sub pb1080p1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p1.Click
        saveci(pb1080p1, "1080p")
    End Sub
    Private Sub pb1080p2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p2.Click
        saveci(pb1080p2, "1080p")
    End Sub
    Private Sub pb1080p3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p3.Click
        saveci(pb1080p3, "1080p")
    End Sub
    Private Sub pb1080p4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p4.Click
        saveci(pb1080p4, "1080p")
    End Sub
    Private Sub pb1080p5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p5.Click
        saveci(pb1080p5, "1080p")
    End Sub
    Private Sub pb1080p6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p6.Click
        saveci(pb1080p6, "1080p")
    End Sub
    Private Sub pb1080p7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p7.Click
        saveci(pb1080p7, "1080p")
    End Sub
    Private Sub pb1080p8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p8.Click
        saveci(pb1080p8, "1080p")
    End Sub
    Private Sub pb1080p9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p9.Click
        saveci(pb1080p9, "1080p")
    End Sub
    Private Sub pb1080p10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p10.Click
        saveci(pb1080p10, "1080p")
    End Sub
    Private Sub pb1080p11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p11.Click
        saveci(pb1080p11, "1080p")
    End Sub
    Private Sub pb1080p12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p12.Click
        saveci(pb1080p12, "1080p")
    End Sub
    Private Sub pb1080p13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p13.Click
        saveci(pb1080p13, "1080p")
    End Sub
    Private Sub pb1080p14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p14.Click
        saveci(pb1080p14, "1080p")
    End Sub
    Private Sub pb1080p15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p15.Click
        saveci(pb1080p15, "1080p")
    End Sub
    Private Sub pb1080p16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p16.Click
        saveci(pb1080p16, "1080p")
    End Sub
    Private Sub pb1080p17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p17.Click
        saveci(pb1080p17, "1080p")
    End Sub
    Private Sub pb1080p18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1080p18.Click
        saveci(pb1080p18, "1080p")
    End Sub
    Private Sub pbbluray1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray1.Click
        saveci(pbbluray1, "bluray")
    End Sub
    Private Sub pbbluray2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray2.Click
        saveci(pbbluray2, "bluray")
    End Sub
    Private Sub pbbluray3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray3.Click
        saveci(pbbluray3, "bluray")
    End Sub
    Private Sub pbbluray4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray4.Click
        saveci(pbbluray4, "bluray")
    End Sub
    Private Sub pbbluray5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray5.Click
        saveci(pbbluray5, "bluray")
    End Sub
    Private Sub pbbluray6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray6.Click
        saveci(pbbluray6, "bluray")
    End Sub
    Private Sub pbbluray7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray7.Click
        saveci(pbbluray7, "bluray")
    End Sub
    Private Sub pbbluray8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray8.Click
        saveci(pbbluray8, "bluray")
    End Sub
    Private Sub pbbluray9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray9.Click
        saveci(pbbluray9, "bluray")
    End Sub
    Private Sub pbbluray10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray10.Click
        saveci(pbbluray10, "bluray")
    End Sub
    Private Sub pbbluray11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray11.Click
        saveci(pbbluray11, "bluray")
    End Sub
    Private Sub pbbluray12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray12.Click
        saveci(pbbluray12, "bluray")
    End Sub
    Private Sub pbbluray13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray13.Click
        saveci(pbbluray13, "bluray")
    End Sub
    Private Sub pbbluray14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray14.Click
        saveci(pbbluray14, "bluray")
    End Sub
    Private Sub pbbluray15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray15.Click
        saveci(pbbluray15, "bluray")
    End Sub
    Private Sub pbbluray16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray16.Click
        saveci(pbbluray16, "bluray")
    End Sub
    Private Sub pbbluray17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray17.Click
        saveci(pbbluray17, "bluray")
    End Sub
    Private Sub pbbluray18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbluray18.Click
        saveci(pbbluray18, "bluray")
    End Sub
    Private Sub pbdivx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx1.Click
        saveci(pbdivx1, "divx")
    End Sub
    Private Sub pbdivx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx2.Click
        saveci(pbdivx2, "divx")
    End Sub
    Private Sub pbdivx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx3.Click
        saveci(pbdivx3, "divx")
    End Sub
    Private Sub pbdivx4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx4.Click
        saveci(pbdivx4, "divx")
    End Sub
    Private Sub pbdivx5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx5.Click
        saveci(pbdivx5, "divx")
    End Sub
    Private Sub pbdivx6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx6.Click
        saveci(pbdivx6, "divx")
    End Sub
    Private Sub pbdivx7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx7.Click
        saveci(pbdivx7, "divx")
    End Sub
    Private Sub pbdivx8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx8.Click
        saveci(pbdivx8, "divx")
    End Sub
    Private Sub pbdivx9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx9.Click
        saveci(pbdivx9, "divx")
    End Sub
    Private Sub pbdivx10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx10.Click
        saveci(pbdivx10, "divx")
    End Sub
    Private Sub pbdivx11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx11.Click
        saveci(pbdivx11, "divx")
    End Sub
    Private Sub pbdivx12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx12.Click
        saveci(pbdivx12, "divx")
    End Sub
    Private Sub pbdivx13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx13.Click
        saveci(pbdivx13, "divx")
    End Sub
    Private Sub pbdivx14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx14.Click
        saveci(pbdivx14, "divx")
    End Sub
    Private Sub pbdivx15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx15.Click
        saveci(pbdivx15, "divx")
    End Sub
    Private Sub pbdivx16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx16.Click
        saveci(pbdivx16, "divx")
    End Sub
    Private Sub pbdivx17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx17.Click
        saveci(pbdivx17, "divx")
    End Sub
    Private Sub pbdivx18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdivx18.Click
        saveci(pbdivx18, "divx")
    End Sub
    Private Sub pbxvid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid1.Click
        saveci(pbxvid1, "xvid")
    End Sub
    Private Sub pbxvid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid2.Click
        saveci(pbxvid2, "xvid")
    End Sub
    Private Sub pbxvid3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid3.Click
        saveci(pbxvid3, "xvid")
    End Sub
    Private Sub pbxvid4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid4.Click
        saveci(pbxvid4, "xvid")
    End Sub
    Private Sub pbxvid5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid5.Click
        saveci(pbxvid5, "xvid")
    End Sub
    Private Sub pbxvid6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid6.Click
        saveci(pbxvid6, "xvid")
    End Sub
    Private Sub pbxvid7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid7.Click
        saveci(pbxvid7, "xvid")
    End Sub
    Private Sub pbxvid8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid8.Click
        saveci(pbxvid8, "xvid")
    End Sub
    Private Sub pbxvid9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid9.Click
        saveci(pbxvid9, "xvid")
    End Sub
    Private Sub pbxvid10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid10.Click
        saveci(pbxvid10, "xvid")
    End Sub
    Private Sub pbxvid11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid11.Click
        saveci(pbxvid11, "xvid")
    End Sub
    Private Sub pbxvid12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid12.Click
        saveci(pbxvid12, "xvid")
    End Sub
    Private Sub pbxvid13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid13.Click
        saveci(pbxvid13, "xvid")
    End Sub
    Private Sub pbxvid14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid14.Click
        saveci(pbxvid14, "xvid")
    End Sub
    Private Sub pbxvid15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid15.Click
        saveci(pbxvid15, "xvid")
    End Sub
    Private Sub pbxvid16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid16.Click
        saveci(pbxvid16, "xvid")
    End Sub
    Private Sub pbxvid17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid17.Click
        saveci(pbxvid17, "xvid")
    End Sub
    Private Sub pbxvid18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxvid18.Click
        saveci(pbxvid18, "xvid")
    End Sub
    Private Sub pb511_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb511.Click
        saveci(pb511, "5.1")
    End Sub
    Private Sub pb512_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb512.Click
        saveci(pb512, "5.1")
    End Sub
    Private Sub pb513_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb513.Click
        saveci(pb513, "5.1")
    End Sub
    Private Sub pb514_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb514.Click
        saveci(pb514, "5.1")
    End Sub
    Private Sub pb515_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb515.Click
        saveci(pb515, "5.1")
    End Sub
    Private Sub pb516_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb516.Click
        saveci(pb516, "5.1")
    End Sub
    Private Sub pb517_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb517.Click
        saveci(pb517, "5.1")
    End Sub
    Private Sub pb518_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb518.Click
        saveci(pb518, "5.1")
    End Sub
    Private Sub pb519_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb519.Click
        saveci(pb519, "5.1")
    End Sub
    Private Sub pb5110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5110.Click
        saveci(pb5110, "5.1")
    End Sub
    Private Sub pb5111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5111.Click
        saveci(pb5111, "5.1")
    End Sub
    Private Sub pb5112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5112.Click
        saveci(pb5112, "5.1")
    End Sub
    Private Sub pb5113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5113.Click
        saveci(pb5113, "5.1")
    End Sub
    Private Sub pb5114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5114.Click
        saveci(pb5114, "5.1")
    End Sub
    Private Sub pb5115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5115.Click
        saveci(pb5115, "5.1")
    End Sub
    Private Sub pb5116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5116.Click
        saveci(pb5116, "5.1")
    End Sub
    Private Sub pb5117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5117.Click
        saveci(pb5117, "5.1")
    End Sub
    Private Sub pb5118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5118.Click
        saveci(pb5118, "5.1")
    End Sub
    Private Sub pb711_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb711.Click
        saveci(pb711, "7.1")
    End Sub
    Private Sub pb712_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb712.Click
        saveci(pb712, "7.1")
    End Sub
    Private Sub pb713_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb713.Click
        saveci(pb713, "7.1")
    End Sub
    Private Sub pb714_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb714.Click
        saveci(pb714, "7.1")
    End Sub
    Private Sub pb715_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb715.Click
        saveci(pb715, "7.1")
    End Sub
    Private Sub pb716_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb716.Click
        saveci(pb716, "7.1")
    End Sub
    Private Sub pb717_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb717.Click
        saveci(pb717, "7.1")
    End Sub
    Private Sub pb718_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb718.Click
        saveci(pb718, "7.1")
    End Sub
    Private Sub pb719_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb719.Click
        saveci(pb719, "7.1")
    End Sub
    Private Sub pb7110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7110.Click
        saveci(pb7110, "7.1")
    End Sub
    Private Sub pb7111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7111.Click
        saveci(pb7111, "7.1")
    End Sub
    Private Sub pb7112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7112.Click
        saveci(pb7112, "7.1")
    End Sub
    Private Sub pb7113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7113.Click
        saveci(pb7113, "7.1")
    End Sub
    Private Sub pb7114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7114.Click
        saveci(pb7114, "7.1")
    End Sub
    Private Sub pb7115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7115.Click
        saveci(pb7115, "7.1")
    End Sub
    Private Sub pb7116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7116.Click
        saveci(pb7116, "7.1")
    End Sub
    Private Sub pb7117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7117.Click
        saveci(pb7117, "7.1")
    End Sub
    Private Sub pb7118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7118.Click
        saveci(pb7118, "7.1")
    End Sub
    Private Sub pbstereo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo1.Click
        saveci(pbstereo1, "stereo")
    End Sub
    Private Sub pbstereo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo2.Click
        saveci(pbstereo2, "stereo")
    End Sub
    Private Sub pbstereo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo3.Click
        saveci(pbstereo3, "stereo")
    End Sub
    Private Sub pbstereo4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo4.Click
        saveci(pbstereo4, "stereo")
    End Sub
    Private Sub pbstereo5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo5.Click
        saveci(pbstereo5, "stereo")
    End Sub
    Private Sub pbstereo6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo6.Click
        saveci(pbstereo6, "stereo")
    End Sub
    Private Sub pbstereo7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo7.Click
        saveci(pbstereo7, "stereo")
    End Sub
    Private Sub pbstereo8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo8.Click
        saveci(pbstereo8, "stereo")
    End Sub
    Private Sub pbstereo9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo9.Click
        saveci(pbstereo9, "stereo")
    End Sub
    Private Sub pbstereo10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo10.Click
        saveci(pbstereo10, "stereo")
    End Sub
    Private Sub pbstereo11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo11.Click
        saveci(pbstereo11, "stereo")
    End Sub
    Private Sub pbstereo12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo12.Click
        saveci(pbstereo12, "stereo")
    End Sub
    Private Sub pbstereo13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo13.Click
        saveci(pbstereo13, "stereo")
    End Sub
    Private Sub pbstereo14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo14.Click
        saveci(pbstereo14, "stereo")
    End Sub
    Private Sub pbstereo15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo15.Click
        saveci(pbstereo15, "stereo")
    End Sub
    Private Sub pbstereo16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo16.Click
        saveci(pbstereo16, "stereo")
    End Sub
    Private Sub pbstereo17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo17.Click
        saveci(pbstereo17, "stereo")
    End Sub
    Private Sub pbstereo18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstereo18.Click
        saveci(pbstereo18, "stereo")
    End Sub
    Private Sub pbmono1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono1.Click
        saveci(pbmono1, "mono")
    End Sub
    Private Sub pbmono2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono2.Click
        saveci(pbmono2, "mono")
    End Sub
    Private Sub pbmono3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono3.Click
        saveci(pbmono3, "mono")
    End Sub
    Private Sub pbmono4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono4.Click
        saveci(pbmono4, "mono")
    End Sub
    Private Sub pbmono5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono5.Click
        saveci(pbmono5, "mono")
    End Sub
    Private Sub pbmono6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono6.Click
        saveci(pbmono6, "mono")
    End Sub
    Private Sub pbmono7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono7.Click
        saveci(pbmono7, "mono")
    End Sub
    Private Sub pbmono8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono8.Click
        saveci(pbmono8, "mono")
    End Sub
    Private Sub pbmono9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono9.Click
        saveci(pbmono9, "mono")
    End Sub
    Private Sub pbmono10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono10.Click
        saveci(pbmono10, "mono")
    End Sub
    Private Sub pbmono11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono11.Click
        saveci(pbmono11, "mono")
    End Sub
    Private Sub pbmono12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono12.Click
        saveci(pbmono12, "mono")
    End Sub
    Private Sub pbmono13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono13.Click
        saveci(pbmono13, "mono")
    End Sub
    Private Sub pbmono14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono14.Click
        saveci(pbmono14, "mono")
    End Sub
    Private Sub pbmono15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono15.Click
        saveci(pbmono15, "mono")
    End Sub
    Private Sub pbmono16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono16.Click
        saveci(pbmono16, "mono")
    End Sub
    Private Sub pbmono17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono17.Click
        saveci(pbmono17, "mono")
    End Sub
    Private Sub pbmono18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmono18.Click
        saveci(pbmono18, "mono")
    End Sub
    Private Sub pbdts1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts1.Click
        saveci(pbdts1, "dts")
    End Sub
    Private Sub pbdts2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts2.Click
        saveci(pbdts2, "dts")
    End Sub
    Private Sub pbdts3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts3.Click
        saveci(pbdts3, "dts")
    End Sub
    Private Sub pbdts4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts4.Click
        saveci(pbdts4, "dts")
    End Sub
    Private Sub pbdts5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts5.Click
        saveci(pbdts5, "dts")
    End Sub
    Private Sub pbdts6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts6.Click
        saveci(pbdts6, "dts")
    End Sub
    Private Sub pbdts7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts7.Click
        saveci(pbdts7, "dts")
    End Sub
    Private Sub pbdts8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts8.Click
        saveci(pbdts8, "dts")
    End Sub
    Private Sub pbdts9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts9.Click
        saveci(pbdts9, "dts")
    End Sub
    Private Sub pbdts10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts10.Click
        saveci(pbdts10, "dts")
    End Sub
    Private Sub pbdts11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts11.Click
        saveci(pbdts11, "dts")
    End Sub
    Private Sub pbdts12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts12.Click
        saveci(pbdts12, "dts")
    End Sub
    Private Sub pbdts13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts13.Click
        saveci(pbdts13, "dts")
    End Sub
    Private Sub pbdts14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts14.Click
        saveci(pbdts14, "dts")
    End Sub
    Private Sub pbdts15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts15.Click
        saveci(pbdts15, "dts")
    End Sub
    Private Sub pbdts16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts16.Click
        saveci(pbdts16, "dts")
    End Sub
    Private Sub pbdts17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts17.Click
        saveci(pbdts17, "dts")
    End Sub
    Private Sub pbdts18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdts18.Click
        saveci(pbdts18, "dts")
    End Sub
    Private Sub pbdtses1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses1.Click
        saveci(pbdtses1, "dtses")
    End Sub
    Private Sub pbdtses2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses2.Click
        saveci(pbdtses2, "dtses")
    End Sub
    Private Sub pbdtses3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses3.Click
        saveci(pbdtses3, "dtses")
    End Sub
    Private Sub pbdtses4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses4.Click
        saveci(pbdtses4, "dtses")
    End Sub
    Private Sub pbdtses5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses5.Click
        saveci(pbdtses5, "dtses")
    End Sub
    Private Sub pbdtses6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses6.Click
        saveci(pbdtses6, "dtses")
    End Sub
    Private Sub pbdtses7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses7.Click
        saveci(pbdtses7, "dtses")
    End Sub
    Private Sub pbdtses8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses8.Click
        saveci(pbdtses8, "dtses")
    End Sub
    Private Sub pbdtses9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses9.Click
        saveci(pbdtses9, "dtses")
    End Sub
    Private Sub pbdtses10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses10.Click
        saveci(pbdtses10, "dtses")
    End Sub
    Private Sub pbdtses11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses11.Click
        saveci(pbdtses11, "dtses")
    End Sub
    Private Sub pbdtses12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses12.Click
        saveci(pbdtses12, "dtses")
    End Sub
    Private Sub pbdtses13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses13.Click
        saveci(pbdtses13, "dtses")
    End Sub
    Private Sub pbdtses14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses14.Click
        saveci(pbdtses14, "dtses")
    End Sub
    Private Sub pbdtses15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses15.Click
        saveci(pbdtses15, "dtses")
    End Sub
    Private Sub pbdtses16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses16.Click
        saveci(pbdtses16, "dtses")
    End Sub
    Private Sub pbdtses17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses17.Click
        saveci(pbdtses17, "dtses")
    End Sub
    Private Sub pbdtses18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdtses18.Click
        saveci(pbdtses18, "dtses")
    End Sub
    Private Sub pbhdaudio1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio1.Click
        saveci(pbhdaudio1, "hdaudio")
    End Sub
    Private Sub pbhdaudio2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio2.Click
        saveci(pbhdaudio2, "hdaudio")
    End Sub
    Private Sub pbhdaudio3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio3.Click
        saveci(pbhdaudio3, "hdaudio")
    End Sub
    Private Sub pbhdaudio4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio4.Click
        saveci(pbhdaudio4, "hdaudio")
    End Sub
    Private Sub pbhdaudio5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio5.Click
        saveci(pbhdaudio5, "hdaudio")
    End Sub
    Private Sub pbhdaudio6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio6.Click
        saveci(pbhdaudio6, "hdaudio")
    End Sub
    Private Sub pbhdaudio7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio7.Click
        saveci(pbhdaudio7, "hdaudio")
    End Sub
    Private Sub pbhdaudio8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio8.Click
        saveci(pbhdaudio8, "hdaudio")
    End Sub
    Private Sub pbhdaudio9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio9.Click
        saveci(pbhdaudio9, "hdaudio")
    End Sub
    Private Sub pbhdaudio10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio10.Click
        saveci(pbhdaudio10, "hdaudio")
    End Sub
    Private Sub pbhdaudio11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio11.Click
        saveci(pbhdaudio11, "hdaudio")
    End Sub
    Private Sub pbhdaudio12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio12.Click
        saveci(pbhdaudio12, "hdaudio")
    End Sub
    Private Sub pbhdaudio13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio13.Click
        saveci(pbhdaudio13, "hdaudio")
    End Sub
    Private Sub pbhdaudio14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio14.Click
        saveci(pbhdaudio14, "hdaudio")
    End Sub
    Private Sub pbhdaudio15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio15.Click
        saveci(pbhdaudio15, "hdaudio")
    End Sub
    Private Sub pbhdaudio16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio16.Click
        saveci(pbhdaudio16, "hdaudio")
    End Sub
    Private Sub pbhdaudio17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio17.Click
        saveci(pbhdaudio17, "hdaudio")
    End Sub
    Private Sub pbhdaudio18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhdaudio18.Click
        saveci(pbhdaudio18, "hdaudio")
    End Sub
#End Region

#Region "Tagging Menu Events"
    Private Sub SDSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSDTSES.Click
        overlayleft("SD.png", "dtses.png")
    End Sub
    Private Sub SDSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSHDAudio.Click
        overlayleft("SD.png", "hdaudio.png")
    End Sub
    Private Sub SDSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSDTS.Click
        overlayleft("SD.png", "dts.png")
    End Sub
    Private Sub SDSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSDD51.Click
        overlayleft("SD.png", "5.1.png")
    End Sub
    Private Sub SDSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSDD71.Click
        overlayleft("SD.png", "7.1.png")
    End Sub
    Private Sub SDSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSmono.Click
        overlayleft("SD.png", "mono.png")
    End Sub
    Private Sub SDSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SDSStereo.Click
        overlayleft("SD.png", "stereo.png")
    End Sub


    '720p
    Private Sub hd720pSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSDTSES.Click
        overlayleft("720p.png", "dtses.png")
    End Sub
    Private Sub hd720pSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSHDAudio.Click
        overlayleft("720p.png", "hdaudio.png")
    End Sub
    Private Sub hd720pSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSDTS.Click
        overlayleft("720p.png", "dts.png")
    End Sub
    Private Sub hd720pSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSDD51.Click
        overlayleft("720p.png", "5.1.png")
    End Sub
    Private Sub hd720pSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSDD71.Click
        overlayleft("720p.png", "7.1.png")
    End Sub
    Private Sub hd720pSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSmono.Click
        overlayleft("720p.png", "mono.png")
    End Sub
    Private Sub hd720pSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd720pSStereo.Click
        overlayleft("720p.png", "stereo.png")
    End Sub


    '1080i
    Private Sub hd1080iSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSDTSES.Click
        overlayleft("1080i.png", "dtses.png")
    End Sub
    Private Sub hd1080iSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSHDAudio.Click
        overlayleft("1080i.png", "hdaudio.png")
    End Sub
    Private Sub hd1080iSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSDTS.Click
        overlayleft("1080i.png", "dts.png")
    End Sub
    Private Sub hd1080iSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSDD51.Click
        overlayleft("1080i.png", "5.1.png")
    End Sub
    Private Sub hd1080iSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSDD71.Click
        overlayleft("1080i.png", "7.1.png")
    End Sub
    Private Sub hd1080iSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSmono.Click
        overlayleft("1080i.png", "mono.png")
    End Sub
    Private Sub hd1080iSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080iSStereo.Click
        overlayleft("1080i.png", "stereo.png")
    End Sub


    '1080p
    Private Sub hd1080pSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSDTSES.Click
        overlayleft("1080p.png", "dtses.png")
    End Sub
    Private Sub hd1080pSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSHDAudio.Click
        overlayleft("1080p.png", "hdaudio.png")
    End Sub
    Private Sub hd1080pSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSDTS.Click
        overlayleft("1080p.png", "dts.png")
    End Sub
    Private Sub hd1080pSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSDD51.Click
        overlayleft("1080p.png", "5.1.png")
    End Sub
    Private Sub hd1080pSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSDD71.Click
        overlayleft("1080p.png", "7.1.png")
    End Sub
    Private Sub hd1080pSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSmono.Click
        overlayleft("1080p.png", "mono.png")
    End Sub
    Private Sub hd1080pSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hd1080pSStereo.Click
        overlayleft("1080p.png", "stereo.png")
    End Sub


    'bluray
    Private Sub hdbluraySDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySDTSES.Click
        overlayleft("bluray.png", "dtses.png")
    End Sub
    Private Sub hdbluraySHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySHDAudio.Click
        overlayleft("bluray.png", "hdaudio.png")
    End Sub
    Private Sub hdbluraySDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySDTS.Click
        overlayleft("bluray.png", "dts.png")
    End Sub
    Private Sub hdbluraySDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySDD51.Click
        overlayleft("bluray.png", "5.1.png")
    End Sub
    Private Sub hdbluraySDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySDD71.Click
        overlayleft("bluray.png", "7.1.png")
    End Sub
    Private Sub hdbluraySmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySmono.Click
        overlayleft("bluray.png", "mono.png")
    End Sub
    Private Sub hdbluraySSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BluRaySStereo.Click
        overlayleft("bluray.png", "stereo.png")
    End Sub


    'xvid
    Private Sub xvidSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSDTS.Click
        overlayleft("xvid.png", "dts.png")
    End Sub
    Private Sub xvidSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSDD51.Click
        overlayleft("xvid.png", "5.1.png")
    End Sub
    Private Sub xvidSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSDD71.Click
        overlayleft("xvid.png", "7.1.png")
    End Sub
    Private Sub xvidSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSmono.Click
        overlayleft("xvid.png", "mono.png")
    End Sub
    Private Sub xvidSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSStereo.Click
        overlayleft("xvid.png", "stereo.png")
    End Sub
    Private Sub xvidSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSDTSES.Click
        overlayleft("xvid.png", "dtses.png")
    End Sub
    Private Sub xvidSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xvidSHDAudio.Click
        overlayleft("xvid.png", "hdaudio.png")
    End Sub

    'divx
    Private Sub divxSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSDTS.Click
        overlayleft("divx.png", "dts.png")
    End Sub
    Private Sub divxSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSDTSES.Click
        overlayleft("divx.png", "dtses.png")
    End Sub
    Private Sub divxSDHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSHDAudio.Click
        overlayleft("divx.png", "hdaudio.png")
    End Sub
    Private Sub divxSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSDD51.Click
        overlayleft("divx.png", "5.1.png")
    End Sub
    Private Sub divxSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSDD71.Click
        overlayleft("divx.png", "7.1.png")
    End Sub
    Private Sub divxSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSmono.Click
        overlayleft("divx.png", "mono.png")
    End Sub
    Private Sub divxSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divxSStereo.Click
        overlayleft("divx.png", "stereo.png")
    End Sub


    'dvd
    Private Sub dvdSDTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdSDTS.Click
        overlayleft("dvd.png", "dts.png")
    End Sub
    Private Sub dvdSDTSES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDSDTSES.Click
        overlayleft("dvd.png", "dtses.png")
    End Sub
    Private Sub dvdSHDAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDSHDAudio.Click
        overlayleft("dvd.png", "hdaudio.png")
    End Sub
    Private Sub dvdSDD51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdSDD51.Click
        overlayleft("dvd.png", "5.1.png")
    End Sub
    Private Sub dvdSDD71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdSDD71.Click
        overlayleft("dvd.png", "7.1.png")
    End Sub
    Private Sub dvdSmono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdSmono.Click
        overlayleft("dvd.png", "mono.png")
    End Sub
    Private Sub dvdSSterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdSStereo.Click
        overlayleft("dvd.png", "stereo.png")
    End Sub
#End Region

    Private Function addfiletofolder(ByVal tvar_path As String, ByVal tvar_filename As String) As String
        If Not Strings.Right(tvar_path, 1) = "\" Then
            tvar_path += "\"
        End If
        Dim rFullPath As String = tvar_path + tvar_filename
        Return rFullPath
    End Function
    Private Function getparentdirectory(ByRef filenameandpath As String) As String
        Dim fnPeices1() As String = filenameandpath.ToString.Split(CChar("\"))
        Dim parentdirname As String = "" '= fnPeices1(fnPeices1.Length - 1)
        Dim totnum As Integer = fnPeices1.Length - 1
        Dim curcount As Integer = 0
        While curcount < totnum
            parentdirname += fnPeices1(curcount)
            parentdirname += "\"
            curcount += 1
        End While
        Return parentdirname
    End Function
    Private Sub overlayleft(ByVal whattotagLeft As String, ByVal whattotagRight As String)
        'see if the image we are working on was already tagged
        If getparentdirectory(pbsizetest.ImageLocation) = rconf.tempfolder Then
            'it's already been tagged

        Else
            'it's not been tagged before - save it to the curimageused location
            locofcurimage = pbsizetest.ImageLocation
        End If
        'remove temp items
        Try
            If File.Exists(addfiletofolder(rconf.tempfolder, "curimage.png")) Then
                File.SetAttributes(addfiletofolder(rconf.tempfolder, "curimage.png"), FileAttributes.Normal)
                File.Delete(addfiletofolder(rconf.tempfolder, "curimage.png"))
            End If

            If File.Exists(addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type)) Then
                File.SetAttributes(addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type), FileAttributes.Normal)
                File.Delete(addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type))
            End If
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try

        'copy the picture that is in the picture box 
        If Not File.Exists(pbsizetest.ImageLocation) Then Exit Sub

        File.Copy(pbsizetest.ImageLocation, addfiletofolder(rconf.tempfolder, "curimage.png"), True)
        File.SetAttributes(addfiletofolder(rconf.tempfolder, "curimage.png"), FileAttributes.Normal)

        'do the overlay
        Dim binfilelocal As String = "MagickCMD" 'addfiletofolder(rconf.ImageMagickFolder, "composite.exe") ''rconf.wgetfolder + "wget.exe"
        Dim curfolderjpg As String = addfiletofolder(rconf.tempfolder, "curimage.png")
        'move the folder.jpg to a backupfile
        'File.Move(curfolderjpg, curfolderjpg & ".bak")

        Dim imgToOverlayLeft As String = """" + addfiletofolder(rconf.resourcefolder + "tagimages\selectedimages", whattotagLeft) + """"
        Dim imgToOverlayRight As String = """" + addfiletofolder(rconf.resourcefolder + "tagimages\selectedimages", whattotagRight) + """"
        Dim imgToPutItOn As String = """" + addfiletofolder(rconf.tempfolder, "curimage.png") + """"
        Dim imgNewImageNameLocation As String = """" + addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type) + """"

        'open the image and get it's size
        Dim objImage As System.Drawing.Image = System.Drawing.Image.FromFile(addfiletofolder(rconf.tempfolder, "curImage.png"))
        Dim originalImageHeight As Integer = objImage.Height
        Dim originalImageWidth As Integer = objImage.Width
        'objImage = Nothing 'get rid of the image, we are done with it
        objImage.Dispose()

        ' Distance from the edges of the image. Default = 0.02, which is 2% of the thumbnail width
        Dim constOverlayMargin As Double = knudMargin.Value '.02 'rconf.overlayMargin
        ' Height of the overlay. Default = 0.09, which is 9% of the thumbnail height
        Dim constOverlayHeight As Double = knudSize.Value '.09 'rconf.overlayHeight

        Dim geoY As Double = originalImageHeight * constOverlayHeight
        Dim margin As Double = originalImageWidth * constOverlayMargin
        Dim geoX As Double = (originalImageHeight * (1 - constOverlayHeight)) - margin
        Dim exstring As String = "composite -compose atop -geometry 1000x" & CStr(geoY) & "+" & CStr(margin) & "+" & CStr(geoX) & " " & imgToOverlayLeft & " " & imgToPutItOn & " " & imgNewImageNameLocation

        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        pro1.StartInfo.Arguments = exstring
        pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        pro1.Start()
        pro1.WaitForExit()
        Dim overlayratio As Double = originalImageWidth / originalImageHeight '.67453625632377745 '1 '1.4655172413793103
        '1.4655172413793103 448275862068966

        'Overlay the right image (move our finished first image (overlayImage.jpg) to the working image (curImage.jpg)
        File.Delete(addfiletofolder(rconf.tempfolder, "curImage.png"))
        File.Move(addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type), addfiletofolder(rconf.tempfolder, "curImage.png"))
        Dim arrep As Double = 1.4655172413793103 'need to get the overlay items ratio
        Dim geoYr As Double = originalImageHeight * constOverlayHeight
        Dim marginr2 As Double = (originalImageWidth - (originalImageHeight * (constOverlayHeight / overlayratio))) - (originalImageWidth * constOverlayMargin) '- (originalImageWidth * constOverlayMargin)
        Dim marginr As Double = originalImageWidth - (constOverlayMargin * originalImageWidth) - (originalImageHeight * constOverlayHeight * arrep)
        'Dim asdf As Double = 
        Dim geoXr As Double = (originalImageHeight * (1 - constOverlayHeight)) - (originalImageWidth * constOverlayMargin)
        '(originalImageHeight * (1 - constOverlayHeight)) - margin
        Dim exstringr As String = "composite -compose atop -geometry " + "1000" + "x" & CStr(geoYr) & "+" & CStr(marginr) & "+" & CStr(geoXr) & " " & imgToOverlayRight & " " & imgToPutItOn & " " & imgNewImageNameLocation

        Dim pro1r As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1r.StartInfo.FileName = binfilelocal
        pro1r.StartInfo.Arguments = exstringr
        pro1r.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        pro1r.Start()
        pro1r.WaitForExit()

        ''copy the files
        If File.Exists(addfiletofolder(rconf.tempfolder, "finaloverlayimage" + rconf.type)) Then File.Delete(addfiletofolder(rconf.tempfolder, "finaloverlayimage" + rconf.type))
        File.Copy(addfiletofolder(rconf.tempfolder, "overlayImage" + rconf.type), addfiletofolder(rconf.tempfolder, "finaloverlayimage" + rconf.type), True)
        'Try
        '    If savefolderjpg And Not moviemode = "file" Then File.Copy(addfiletofolder(cmpath, "overlayImage.png"), addfiletofolder(cmpath, "folder.jpg"), True)
        '    'If savefolderjpg And Not moviemode = "file" Then Debug.Print("saved: " + addfiletofolder(cmpath, "folder.jpg"))
        '    If savemovienametbn Then File.Copy(addfiletofolder(cmpath, "overlayImage.png"), addfiletofolder(cmpath, currentmovie.pmoviename) + ".tbn", True)
        '    'If savemovienametbn Then Debug.Print("saved: " + addfiletofolder(cmpath, cmname) + ".tbn")
        '    If savemovietbn And Not moviemode = "file" Then File.Copy(addfiletofolder(cmpath, "overlayImage.png"), addfiletofolder(cmpath, "movie.tbn"), True)
        '    'If savemovietbn And Not moviemode = "file" Then Debug.Print("saved: " + addfiletofolder(cmpath, "movie.tbn"))
        'Catch ex As Exception
        '    MessageBox.Show("Unable to save the icons, check permissions on the files in the movie folder", "Saving media icons failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Debug.Print(ex.ToString)
        '    Exit Sub
        'End Try

        'update the display
        pbsizetest.ImageLocation = Nothing
        pbsizetest.Image = Nothing
        pbsizetest.ImageLocation = addfiletofolder(rconf.tempfolder, "finaloverlayimage" + rconf.type)


    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectOwnImageForTagging.Click
        With opfd2
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                'MessageBox.Show("Canceling")
            Else
                Dim fileselectedforposter As String
                fileselectedforposter = opfd2.FileName
                If opfd2.FileName = "" Or opfd2.FileName = "Select your custom image or enter URL" Then Exit Sub
                If Not File.Exists(opfd2.FileName) Then Exit Sub
                pbsizetest.Image = Nothing
                pbsizetest.ImageLocation = Nothing
                pbsizetest.ImageLocation = fileselectedforposter
                pbsizetest.Load()
                myselectedimagefortagging = opfd2.FileName
            End If
        End With
    End Sub

    Private Sub btnRemoveTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTag.Click
        loadsample()
    End Sub

    Private Sub btnSetSizeMargin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetSizeMargin.Click
        rconf.overlayMargin = knudMargin.Value
        rconf.overlayHeight = knudSize.Value
        If rbTypeJPG.Checked Then rconf.type = ".jpg"
        If rbTypePNG.Checked Then rconf.type = ".png"
        'saveconfig()
        rconf.saveConfig(rconf)
    End Sub

    Private Sub Tagdvd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tagdvd.Click

    End Sub

    Private Sub kbtnSaveTaggedImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnSaveTaggedImage.Click
        With sfd1
            .FileName = myselectedimagefortagging
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                'MessageBox.Show("Canceling")
            Else
                Dim fileselectedforposter As String
                fileselectedforposter = sfd1.FileName
                'If opfd2.FileName = "" Or opfd2.FileName = "Select your custom image or enter URL" Then Exit Sub
                'If Not File.Exists(opfd2.FileName) Then Exit Sub
                File.Copy(pbsizetest.ImageLocation, fileselectedforposter, True)

                'pbsizetest.Image = Nothing
                'pbsizetest.ImageLocation = Nothing
                'pbsizetest.ImageLocation = fileselectedforposter
                'pbsizetest.Load()

            End If
        End With
    End Sub

    Private Sub btnResetDefaultsizemargin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetDefaultsizemargin.Click
        knudMargin.Value = CDec(0.02)
        knudSize.Value = CDec(0.12)
        rconf.overlayMargin = knudMargin.Value
        rconf.overlayHeight = knudSize.Value
        rconf.saveConfig(rconf)
        'maincollection.saveconfig()
    End Sub
    Private Sub rbTypeJPG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeJPG.Click
        If rbTypeJPG.Checked Then rconf.type = ".jpg"
        If rbTypePNG.Checked Then rconf.type = ".png"
    End Sub
    Private Sub rbTypePNG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypePNG.Click
        If rbTypeJPG.Checked Then rconf.type = ".jpg"
        If rbTypePNG.Checked Then rconf.type = ".png"
    End Sub
End Class
