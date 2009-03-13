Imports System.Windows.Forms
Imports System.IO
Imports HundredMilesSoftware.UltraID3Lib

Public Class dlgMusicSortWizard
    Private dmusic_count As Integer = 0
    Private musiclist As New ArrayList
    Private rconf As New configuration
    Dim lowercaseit As Boolean = False
    Dim leaveunknownfilesalone As Boolean = False
    Dim useUnderScoreForSpaces As Boolean = False
    Dim srcfolder As String = ""
    Dim dstfolder As String = ""
    Dim pcbDelimiter As Integer = 0 'cbDelimiter.SelectedIndex
    Dim pcbFirst As Integer = 0 'cbFirst.SelectedIndex
    Dim pcbSecond As Integer = 0 'cbSecond.SelectedIndex
    Dim pcbThird As Integer = 0 'cbThird.SelectedIndex
    Dim pcbFourth As Integer = 0 'cbFourth.SelectedIndex
    Dim pcbUse2digitTrackNums As Boolean = False
    Dim gv_musicfilelist As New ArrayList
    Public examplesong As New Music


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' sortmusic(tbSrcMusicFolder.Text, tbDstMusicFolder.Text)
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    
    Private Function getextension(ByRef filename As String) As String
        Dim retstr As String = "none"
        If Not filename = Nothing And filename.Length > 4 Then

            retstr = Strings.Right(filename, 5)
            If Not Strings.Left(retstr, 1) = "." Then
                retstr = Strings.Right(retstr, retstr.Length - 1)
                '4 chars
            End If
            If Not Strings.Left(retstr, 1) = "." Then
                retstr = Strings.Right(retstr, retstr.Length - 1)
                '3 chars (min. num possible)
            End If
        End If
        Return retstr
    End Function
    Public Function removeextension(ByRef filename As String) As String
        Dim retstr As String = "none"
        If Not filename = Nothing Then
            If filename.Length > 5 Then
                retstr = Strings.Left(filename, filename.Length - 4)
            End If
        End If
        Return retstr
    End Function
    Private Function findsimmusicfanart(ByVal vartist As String) As String
        Dim artist As String = cleanname(vartist)
        'exact match on jpg first 
        If File.Exists(rconf.customimagesfolder & "music\fanart\" & artist & ".jpg") Then
            Return (rconf.customimagesfolder & "music\fanart\" & artist & ".jpg")
        End If
        'exact match on png second
        If File.Exists(rconf.customimagesfolder & "music\fanart\" & artist & ".png") Then
            Return (rconf.customimagesfolder & "music\fanart\" & artist & ".png")
        End If

        'if those failed, try to find it with 3 other methods
        Dim retnamew1 As String = ""
        Dim retnamew2 As String = ""
        Dim retnamew3 As String = ""

        Dim clenaartname As String = stripnonchardigitfromstring(artist) '+ "jpg"
        For Each curfile In Directory.GetFiles(rconf.customimagesfolder & "music\fanart\")
            Dim curfileonlyname As String = getfilefrompath(curfile)
            Dim cleanedname As String = stripnonchardigitfromstring(removeextension(curfileonlyname))
            If cleanedname = clenaartname Then ' Or clenaartname.Contains(cleanedname) Or cleanedname.Contains(clenaartname) Then
                retnamew1 = curfile
            ElseIf clenaartname.Contains(cleanedname) Then
                retnamew2 = curfile
            ElseIf cleanedname.Contains(clenaartname) Then
                retnamew3 = curfile
            End If
        Next
        If Not retnamew1 = "" Then Return retnamew1 'matches with only lettersdigits in the artist and fanart name
        If Not retnamew2 = "" Then Return retnamew2 'artist name is contained in fanart file
        If Not retnamew3 = "" Then Return retnamew3 'fanart flie contains artname
        Return ""
    End Function
    'Private Function findsimmusicfanart(ByVal vartist As String) As String
    '    Dim artist As String = cleanname(vartist)
    '    'exact match on jpg first 
    '    If File.Exists(rconf.customimagesfolder & "music\fanart\" & artist & ".jpg") Then
    '        Return (rconf.customimagesfolder & "music\fanart\" & artist & ".jpg")
    '    End If
    '    'exact match on png second
    '    If File.Exists(rconf.customimagesfolder & "music\fanart\" & artist & ".png") Then
    '        Return (rconf.customimagesfolder & "music\fanart\" & artist & ".png")
    '    End If

    '    'if those failed, try to find it with 3 other methods
    '    Dim retnamew1 As String = ""
    '    Dim retnamew2 As String = ""
    '    Dim retnamew3 As String = ""

    '    Dim clenaartname As String = stripnonchardigitfromstring(artist) + "jpg"
    '    For Each curfile In Directory.GetFiles(rconf.customimagesfolder & "music\fanart\")
    '        Dim curfileonlyname As String = getfilefrompath(curfile)
    '        Dim cleanedname As String = stripnonchardigitfromstring(curfileonlyname)
    '        If cleanedname = clenaartname Then ' Or clenaartname.Contains(cleanedname) Or cleanedname.Contains(clenaartname) Then
    '            retnamew1 = curfile
    '        ElseIf clenaartname.Contains(cleanedname) Then
    '            retnamew2 = curfile
    '        ElseIf cleanedname.Contains(clenaartname) Then
    '            retnamew3 = curfile
    '        End If
    '    Next
    '    If Not retnamew1 = "" Then Return retnamew1 'matches with only lettersdigits in the artist and fanart name
    '    If Not retnamew2 = "" Then Return retnamew2 'artist name is contained in fanart file
    '    If Not retnamew3 = "" Then Return retnamew3 'fanart flie contains artname
    '    Return ""
    'End Function

    Private Function stripnonchardigitfromstring(ByVal thestring As String) As String
        Dim retstr As String = ""
        For Each curchar As Char In thestring
            If Char.IsLetterOrDigit(curchar) Then
                retstr += curchar
            End If
        Next
        retstr = retstr.ToLower
        Return retstr
    End Function
    Private Function createnewfilename(ByRef musicobj As Music) As String

        Dim namepart1, namepart2, namepart3, namepart4 As String
        Dim curext As String
        curext = getextension(getfilefrompath(musicobj.Filename))
        If curext = "none" Then
            Return "fail"
        End If


        Dim originalfilename As String = getfilefrompath(musicobj.Filename)
        Dim newfilename As String = ""
        Dim curdelim As String = ""

        ' - <Space><Hyphen><Space>(Default)
        '_ <Underscore>
        '   <Space>
        '-  <Hyphen>
        '.   <Dot>
        '=  <Equals>

        Select Case pcbDelimiter '.SelectedIndex
            Case 0
                curdelim = " - "
            Case 1
                curdelim = "_"
            Case 2
                curdelim = " "
            Case 3
                curdelim = "-"
            Case 4
                curdelim = "."
            Case 5
                curdelim = "="
            Case Else
                curdelim = " - "
        End Select

        Select Case pcbFirst '.SelectedIndex
            Case 0
                namepart1 = musicobj.Artist
            Case 1
                namepart1 = musicobj.Album
            Case 2
                namepart1 = musicobj.Tracknum
                If pcbUse2digitTrackNums And musicobj.Tracknum.Length = 1 Then namepart1 = "0" & namepart1
            Case 3
                namepart1 = musicobj.Title
            Case Else
                namepart1 = musicobj.Artist
        End Select

        Select Case pcbSecond '.SelectedIndex
            Case 0
                namepart2 = musicobj.Artist
            Case 1
                namepart2 = musicobj.Album
            Case 2
                namepart2 = musicobj.Tracknum
                If pcbUse2digitTrackNums And musicobj.Tracknum.Length = 1 Then namepart2 = "0" & namepart2
            Case 3
                namepart2 = musicobj.Title
            Case 4
                namepart2 = ""
            Case Else
                namepart2 = musicobj.Album
        End Select
        Select Case pcbThird '.SelectedIndex
            Case 0
                namepart3 = musicobj.Artist
            Case 1
                namepart3 = musicobj.Album
            Case 2
                namepart3 = musicobj.Tracknum
                If pcbUse2digitTrackNums And musicobj.Tracknum.Length = 1 Then namepart3 = "0" & namepart3
            Case 3
                namepart3 = musicobj.Title
            Case 4
                namepart3 = ""
            Case Else
                namepart3 = musicobj.Tracknum
                If pcbUse2digitTrackNums And musicobj.Tracknum.Length = 1 Then namepart3 = "0" & namepart3
        End Select
        Select Case pcbFourth '.SelectedIndex
            Case 0
                namepart4 = musicobj.Artist
            Case 1
                namepart4 = musicobj.Album
            Case 2
                namepart4 = musicobj.Tracknum
                If pcbUse2digitTrackNums And musicobj.Tracknum.Length = 1 Then namepart4 = "0" & namepart4
            Case 3
                namepart4 = musicobj.Title
            Case 4
                namepart4 = ""
            Case Else
                namepart4 = musicobj.Title
        End Select
        newfilename += namepart1
        If Not namepart2 = "" Then newfilename += curdelim & namepart2
        If Not namepart3 = "" Then newfilename += curdelim & namepart3
        If Not namepart4 = "" Then newfilename += curdelim & namepart4
        newfilename += curext
        newfilename = cleanname(newfilename)
        'newfilename = cleanname(namepart1 + curdelim + namepart2 + curdelim + namepart3 + curdelim + namepart4 + curext)
        If newfilename = "" Then
            Return "fail"
        End If
        Return newfilename
    End Function
    Private Sub EnumerateMusicDirectory(ByVal RootDirectory As String)
        'Dim folderslist As New ArrayList
        'For Each s As String In Directory.GetDirectories(RootDirectory)
        'Debug.WriteLine("File found: " & s)
        'Next s
        For Each s As String In Directory.GetDirectories(RootDirectory)
            'Debug.Print(Strings.Right(s, 8))

            If Not (File.GetAttributes(s) And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then
                '    Debug.WriteLine("Sub Enumerate Directory -- Directory found: " & s)
                'debug counter
                dmusic_count = dmusic_count + 1
                'Debug.Print(dlist_count)
                'Add all files to the global array
                If ((Strings.Right(s, 8)).ToLower = "video_ts" Or (Strings.Right(s, 8)).ToLower = "audio_ts" Or (Strings.Right(s, 7)).ToLower = "trailer" Or (Strings.Right(s, 15)).ToLower = "temporary files" Or (Strings.Right(s, 8)).ToLower = "(noscan)" Or (Strings.Right(s, 6)).ToLower = "sample" Or s.ToUpper = "RECYCLER" Or s.ToUpper = "LOST+FOUND" Or s.ToUpper = "System Volume Information".ToUpper) Then
                    Debug.Print("Sub Enumerate Directory -- found but coded to not add " + Convert.ToString(dmusic_count) + " - skipping")
                Else
                    musiclist.Add(s)
                End If
                EnumerateMusicDirectory(s) ' will parse sub dirs
            End If
        Next s
        'Return junk
    End Sub
    Private Function checkmusicextension(ByRef filename As String) As Boolean

        'check to see if the fileextension is valid
        If filename.Length <= 3 Then Return False 'this would be the shortest possible singlechar(x) where x.wv is valid
        Dim v2digit As String = ""
        v2digit = Strings.Right(filename, 3)
        Dim v3digit As String = ""
        If filename.Length >= 5 Then v3digit = Strings.Right(filename, 4)
        Dim v4digit As String = ""
        If filename.Length >= 6 Then v4digit = Strings.Right(filename, 5)

        If v2digit = ".wv" Then
            Return True
        End If
        If v3digit = ".aif" Or v3digit = ".wav" Or v3digit = ".mp2" Or v3digit = ".mp3" Or v3digit = ".aac" Or v3digit = ".m4a" Or v3digit = ".m4b" Or v3digit = ".m4p" Or v3digit = ".m4v" Or v3digit = ".m4r" Or v3digit = ".3gp" Or v3digit = ".mp4" Or v3digit = ".m4a" Or v3digit = ".amr" Or v3digit = ".ape" Or v3digit = ".ram" Or v3digit = ".shn" Or v3digit = ".wv" Or v3digit = ".mpc" Or v3digit = ".mp+" Or v3digit = ".mpp" Or v3digit = ".spx" Or v3digit = ".ogg" Or v3digit = ".oga" Or v3digit = ".wma" Then
            Return True
        End If
        If v4digit = ".aiff" Or v4digit = ".aifc" Or v4digit = ".flac" Then
            Return True
        End If

        Return False
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
    Function cleanname(ByVal name As String) As String
        Dim cleanedname As String = name
        cleanedname = Strings.Replace(cleanedname, "�", "")
        cleanedname = Strings.Replace(cleanedname, "<", "")
        cleanedname = Strings.Replace(cleanedname, ">", "")
        cleanedname = Strings.Replace(cleanedname, ":", "")
        cleanedname = Strings.Replace(cleanedname, "\", "")
        cleanedname = Strings.Replace(cleanedname, "/", "")
        cleanedname = Strings.Replace(cleanedname, "?", "")
        cleanedname = Strings.Replace(cleanedname, "|", "")
        cleanedname = Strings.Replace(cleanedname, "*", "")
        cleanedname = Strings.Replace(cleanedname, """", "")
        Return cleanedname
    End Function
    Private Function addfiletofolder(ByVal tvar_path As String, ByVal tvar_filename As String) As String
        If Not Strings.Right(tvar_path, 1) = "\" Then
            tvar_path += "\"
        End If
        Dim rFullPath As String = tvar_path + tvar_filename
        Return rFullPath
    End Function
    Private Function getfilefrompath(ByVal filenameandpath As String) As String
        Dim fnPeices1() As String = filenameandpath.ToString.Split(CChar("\"))
        Dim returnedfilename As String = fnPeices1(fnPeices1.Length - 1)
        Return returnedfilename
    End Function
    Private Sub getimagefromid3tagSaveLocal(ByRef TrackFileName As String, ByRef destinationnameandloc As String)
        Dim curTagUltraID3 As New UltraID3
        Try
            'Read the track file
            curTagUltraID3.Read(TrackFileName)
            If curTagUltraID3.ID3v2Tag.ExistsInFile Then

                'Display the Title property of the ID3v23Tag directly
                'MsgBox(TestUltraID3.ID3v2Tag.Title)
                'MsgBox(TestUltraID3.PictureTypeInfos.Count.ToString)
                Dim myArtworkCollection As ID3FrameCollection
                myArtworkCollection = curTagUltraID3.ID3v2Tag.Frames.GetFrames(MultipleInstanceID3v2FrameTypes.ID3v23Picture)
                If myArtworkCollection.Count > 0 Then
                    Dim ra As ID3v2PictureFrame = CType(myArtworkCollection(0), ID3v2PictureFrame)
                    Dim theimage As Bitmap = ra.Picture
                    'pbMusicCurFanart.Image = theimage
                    theimage.Save(destinationnameandloc, System.Drawing.Imaging.ImageFormat.Jpeg)

                Else 'check for v22 image
                    myArtworkCollection = curTagUltraID3.ID3v2Tag.Frames.GetFrames(MultipleInstanceID3v2FrameTypes.ID3v22Picture)
                    If myArtworkCollection.Count > 0 Then
                        Dim ra As ID3v2PictureFrame = CType(myArtworkCollection(0), ID3v2PictureFrame)
                        Dim theimage As Bitmap = ra.Picture
                        'pbMusicCurFanart.Image = theimage
                        theimage.Save(destinationnameandloc, System.Drawing.Imaging.ImageFormat.Jpeg)
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub sortmusic(ByVal sourcedir As String, ByVal destdir As String, ByVal lowercaseit As Boolean, ByVal leaveunknownfilesalone As Boolean, ByVal useUnderScoreForSpaces As Boolean, ByVal Use2digitTrackNums As Boolean)

        'for each file, read up the data and store the xmls, those are what we will be working with, not the files
        Dim curcount As Integer = 0
        For Each musicfile As String In gv_musicfilelist
            If bwStartSorting.CancellationPending Then
                Exit Sub
            End If

            Dim curmusicitem As New Music
            curmusicitem.Filename = musicfile
            'use mediainfo to get data about the file
            Dim curmediainfo As New MediaInfo
            curmediainfo.getmusicdata(curmusicitem)
            Debug.Print(curmusicitem.Artist + " - " + curmusicitem.Album + " - " + curmusicitem.Title + " - " + curmusicitem.Tracknum)
            'organize it for me, initially create artist and title folders, and move the file into that folder
            If Not leaveunknownfilesalone Then
                If curmusicitem.Artist = "" Then curmusicitem.Artist = "Unknown"
            End If

            If Not curmusicitem.Artist = "" Then
                If Not Directory.Exists(destdir + cleanname(curmusicitem.Artist)) Then Directory.CreateDirectory(destdir + cleanname(curmusicitem.Artist))
                If Not File.Exists(destdir + cleanname(curmusicitem.Artist) + "\fanart.jpg") Then
                    Dim newfafile As String = findsimmusicfanart(curmusicitem.Artist)
                    If File.Exists(newfafile) Then
                        '    Debug.Print("I HAVE FANART FOR THIS ONE")
                        File.Copy(newfafile, destdir + cleanname(curmusicitem.Artist) + "\fanart.jpg")
                    End If
                End If
                If Not leaveunknownfilesalone Then
                    If curmusicitem.Album = "" Then curmusicitem.Album = "Unknown"
                End If

                If Not curmusicitem.Album = "" Then
                    If Not Directory.Exists(addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album))) Then
                        Directory.CreateDirectory(addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album)))

                    End If
                    Dim theoldfilename As String = getfilefrompath(curmusicitem.Filename)
                    If Use2digitTrackNums Then
                        If curmusicitem.Tracknum.Length = 1 Then
                            curmusicitem.Tracknum = "0" & curmusicitem.Tracknum
                        End If
                    End If
                    Dim thenewfilename As String = createnewfilename(curmusicitem) 'cleanname(curmusicitem.Artist + "." + curmusicitem.Album + ".[" + curmusicitem.Tracknum + "]." + curmusicitem.Title + Strings.Right(theoldfilename, 4))
                    If Not leaveunknownfilesalone Then
                        If curmusicitem.Album = "Unknown" Or curmusicitem.Artist = "Unknown" Then
                            Dim unknownstr As String = ""
                            unknownstr = Strings.Replace(curmusicitem.Filename, "/", "_")
                            unknownstr = Strings.Replace(unknownstr, "\", "_")
                            unknownstr = Strings.Replace(unknownstr, ":", "_")
                            thenewfilename = unknownstr + "--" + thenewfilename
                        End If
                    End If

                    If lowercaseit Then
                        thenewfilename = thenewfilename.ToLower
                    End If

                    If useUnderScoreForSpaces Then
                        thenewfilename = Strings.Replace(thenewfilename, " ", "_")
                    End If
                    If Not cbRenameMusicFiles.Checked Then
                        thenewfilename = theoldfilename
                    End If
                    Dim pathlen As Integer = addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album)).Length + 1
                    Dim maxsize As Integer = 259
                    maxsize = maxsize - pathlen

                    If thenewfilename.Length >= maxsize Then 'shorten name when required (max is 260 per file)
                        Dim firstpart As String = Strings.Left(thenewfilename, maxsize - 5)
                        Dim lastpart As String = Strings.Right(thenewfilename, 5)
                        thenewfilename = firstpart + lastpart
                    End If
                    Dim newfilename As String = addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + thenewfilename)
                    If newfilename.Length >= 260 Then
                        Debug.Print("too damn long")
                        MsgBox("The name is too long")
                        Exit Sub
                    End If
                    If pathlen > 248 Then
                        MsgBox("new path is too long for your file system, Put your music into a folder that similar to c:\music")
                        Exit Sub
                    End If


                    bwStartSorting.ReportProgress(curcount, vbNewLine + "Current File: " + getfilefrompath(musicfile) + vbNewLine + "New file: " + thenewfilename)
                    'Debug.Print("Copying From: " + theoldfilename + " TO: " + thenewfilename)
                    'If curmusicitem.Album = "Unknown" Or curmusicitem.Artist = "Unknown" Then
                    If Not curmusicitem.Artist = "" Then
                        File.Copy(curmusicitem.Filename, newfilename, True)
                        If Not File.Exists(addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + "folder.jpg")) Then
                            getimagefromid3tagSaveLocal(addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + thenewfilename), addfiletofolder(destdir, cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + "folder.jpg"))
                        End If
                    End If
                    'If File.Exists("f:\music\" + cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + "folder.jpg") Then
                    '    clearoutimagesfromtag("f:\music\" + cleanname(curmusicitem.Artist) + "\" + cleanname(curmusicitem.Album) + "\" + thenewfilename)
                    'End If
                    'End If

                End If


            End If
            Debug.Print(curcount.ToString)

            'write out the xml
            curcount += 1
        Next
    End Sub
    Private Sub readfolderdata()
        Dim lsrcfolder As String = ""
        Dim ldstfolder As String = ""
        lsrcfolder = addfiletofolder(srcfolder, "") 'ensures / at the end
        ldstfolder = addfiletofolder(dstfolder, "") 'ensures / at the end
        'prompt for current music location

        'enumerate the root folder and get all sub folders, add those to the temp array
        EnumerateMusicDirectory(lsrcfolder)
        'for each sub folder, get all files it in, if they end in .mp3 .wav they are music, add those to the main music array
        Dim musicfilelist As New ArrayList

        For Each musicdir As String In musiclist
            Dim musicfiles() As String = Directory.GetFiles(musicdir)
            For Each fileitem In musicfiles
                If checkmusicextension(fileitem) Then
                    musicfilelist.Add(fileitem)
                    Debug.Print(fileitem)
                End If
            Next

        Next
        gv_musicfilelist = musicfilelist
    End Sub
    Private Sub dlgMusicSortWizard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rconf = maincollection.rconf
    End Sub
    Private Sub tbSrcMusicFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSrcMusicFolder.Click
        tbSrcMusicFolder.Text = ""
    End Sub
    Private Sub tbDstMusicFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDstMusicFolder.Click
        tbDstMusicFolder.Text = ""
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If Not Directory.Exists(tbSrcMusicFolder.Text) Then
            MsgBox("Source folder does not exist")
            Exit Sub
        End If
        If Not Directory.Exists(tbDstMusicFolder.Text) Then
            MsgBox("Destination folder does not exist")
            Exit Sub
        End If
        kscMyMain.Panel1Collapsed = True
        kscMyMain.Visible = False
        kgMain.Visible = False
        btnCancel.Visible = False
        btnStart.Visible = False
        lblReadingFolderData.Visible = True
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
        srcfolder = addfiletofolder(tbSrcMusicFolder.Text, "") 'ensures the trailing slash is in place
        dstfolder = addfiletofolder(tbDstMusicFolder.Text, "") 'ensures the trailing slash is in place
        readfolderdata()
        lblReadingFolderData.Visible = False
        kgCurStats.Visible = True
        lowercaseit = cbLowerCaseFileNames.Checked
        leaveunknownfilesalone = cbleaveunknownfilesalone.Checked
        useUnderScoreForSpaces = cbUseUnderScoreForSpaces.Checked
        pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
        pcbDelimiter = cbDelimiter.SelectedIndex
        pcbFirst = cbFirst.SelectedIndex
        pcbSecond = cbSecond.SelectedIndex
        pcbThird = cbThird.SelectedIndex
        pcbFourth = cbFourth.SelectedIndex
        ProgressBar1.Visible = True
        lblStatus.Visible = True
        lblPleaseWait.Visible = True
        btnCancelWorker.Enabled = True
        btnCancelWorker.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Maximum = gv_musicfilelist.Count + 1
        ProgressBar1.MarqueeAnimationSpeed = 20

        bwStartSorting = New System.ComponentModel.BackgroundWorker
        bwStartSorting.WorkerReportsProgress = True
        bwStartSorting.WorkerSupportsCancellation = True
        bwStartSorting.RunWorkerAsync()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub bwStartSorting_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwStartSorting.DoWork
        'prompt for destination location
        ' kscMyMain.Panel2Collapsed = False

        sortmusic(srcfolder, dstfolder, lowercaseit, leaveunknownfilesalone, useUnderScoreForSpaces, pcbUse2digitTrackNums)
    End Sub

    Private Sub bwStartSorting_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwStartSorting.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        lblStatus.Text = "File " + e.ProgressPercentage.ToString + " of " + ProgressBar1.Maximum.ToString + e.UserState.ToString
    End Sub

    Private Sub bwStartSorting_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwStartSorting.RunWorkerCompleted
        lblReadingFolderData.Text = "                      Sorting Completed, you can now close this dialog!"
        kgCurStats.Visible = False
        btnCancelWorker.Visible = False
        lblReadingFolderData.Visible = True
        btnCancel.Text = "Close"
        btnCancel.Visible = True
        btnCancel.BringToFront()
        'MsgBox("Sorting completed")
    End Sub

    Private Sub btnCancelWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelWorker.Click
        bwStartSorting.CancelAsync()

    End Sub

    Private Sub cbDelimiter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDelimiter.SelectedIndexChanged
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If

    End Sub

    Private Sub cbFirst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFirst.SelectedIndexChanged
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub

    Private Sub cbSecond_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecond.SelectedIndexChanged
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub

    Private Sub cbThird_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbThird.SelectedIndexChanged
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub

    Private Sub cbFourth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFourth.SelectedIndexChanged
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub

    Private Sub cbLowerCaseFileNames_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLowerCaseFileNames.Click
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub


    Private Sub cbUseUnderScoreForSpaces_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUseUnderScoreForSpaces.Click
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub
    Private Sub cbUse2digitTrackNums_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUse2digitTrackNums.Click
        If kgRenameMusicFileOptions.Enabled Then
            pcbDelimiter = cbDelimiter.SelectedIndex
            pcbFirst = cbFirst.SelectedIndex
            pcbSecond = cbSecond.SelectedIndex
            pcbThird = cbThird.SelectedIndex
            pcbFourth = cbFourth.SelectedIndex
            pcbUse2digitTrackNums = cbUse2digitTrackNums.Checked
            Dim newname As String = createnewfilename(examplesong)
            If cbLowerCaseFileNames.Checked Then newname = newname.ToLower
            If cbUseUnderScoreForSpaces.Checked Then newname = Strings.Replace(newname, " ", "_")
            lblExampleFormat.Text = newname
        End If
    End Sub

    Private Sub cbRenameMusicFiles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRenameMusicFiles.Click
        kgRenameMusicFileOptions.Enabled = cbRenameMusicFiles.Checked
    End Sub

    Private Sub btnBrowseSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSrc.Click
        Dim folderselected As String = ""
        With fbdBrowse

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = fbdBrowse.SelectedPath
                If fbdBrowse.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(fbdBrowse.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbSrcMusicFolder.Text = folderselected
        End If
    End Sub
    Private Sub btnBrowseDst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseForDstFolder.Click
        Dim folderselected As String = ""
        With fbdBrowse

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = fbdBrowse.SelectedPath
                If fbdBrowse.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(fbdBrowse.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbDstMusicFolder.Text = folderselected
        End If
    End Sub
End Class
