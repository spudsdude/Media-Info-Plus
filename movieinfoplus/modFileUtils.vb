Imports System.IO

Module modFileUtils
    Public Sub writeStringToFile(ByVal strData As String, ByVal FullPath As String)
        Dim objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
        Catch Ex As Exception
            Debug.Print(Ex.ToString)
        End Try
    End Sub
    Private Function return_media_images_for_tag(ByVal curfile As String) As String
        Select Case curfile.ToLower
            Case "front.jpg"
                Return "mifc1"
            Case "front2.jpg"
                Return "mifc2"
            Case "front3.jpg"
                Return "mifc3"
            Case "front4.jpg"
                Return "mifc4"
            Case "front5.jpg"
                Return "mifc5"
            Case "front6.jpg"
                Return "mifc6"
            Case "front7.jpg"
                Return "mifc7"
            Case "front8.jpg"
                Return "mifc8"
            Case "front9.jpg"
                Return "mifc9"
            Case "front10.jpg"
                Return "mifc10"
            Case "back.jpg"
                Return "mibc1"
            Case "back2.jpg"
                Return "mibc2"
            Case "back3.jpg"
                Return "mibc3"
            Case "back4.jpg"
                Return "mibc4"
            Case "back5.jpg"
                Return "mibc5"
            Case "back6.jpg"
                Return "mibc6"
            Case "back7.jpg"
                Return "mibc7"
            Case "back8.jpg"
                Return "mibc8"
            Case "back9.jpg"
                Return "mibc9"
            Case "back10.jpg"
                Return "mibc10"

            Case "cd1.jpg"
                Return "micd1"
            Case "cd2.jpg"
                Return "micd2"
            Case "cd3.jpg"
                Return "micd3"
            Case "cd4.jpg"
                Return "micd4"
            Case "cd5.jpg"
                Return "micd5"
            Case "cd6.jpg"
                Return "micd6"
            Case "cd7.jpg"
                Return "micd7"
            Case "cd8.jpg"
                Return "micd8"
            Case "cd9.jpg"
                Return "micd9"
            Case "cd10.jpg"
                Return "micd10"
            Case "cd11.jpg"
                Return "micd12"
            Case "cd12.jpg"
                Return "micd12"
            Case "cd13.jpg"
                Return "micd13"
            Case "cd14.jpg"
                Return "micd14"
            Case "cd15.jpg"
                Return "micd15"

            Case "inside.jpg"
                Return "miins1"
            Case "inside2.jpg"
                Return "miins2"
            Case "inside3.jpg"
                Return "miins3"
            Case "inside4.jpg"
                Return "miins4"
            Case "inside5.jpg"
                Return "miins5"
            Case "inside6.jpg"
                Return "miins6"
            Case "inside7.jpg"
                Return "miins7"
            Case "inside8.jpg"
                Return "miins8"
            Case "inside9.jpg"
                Return "miins9"
            Case "inside10.jpg"
                Return "miins10"

            Case "inlay.jpg"
                Return "miinl1"
            Case "inlay2.jpg"
                Return "miinl2"
            Case "inlay3.jpg"
                Return "miinl3"
            Case "inlay4.jpg"
                Return "miinl4"
            Case "inlay5.jpg"
                Return "miinl5"
            Case "inlay6.jpg"
                Return "miinl6"
            Case "inlay7.jpg"
                Return "miinl7"
            Case "inlay8.jpg"
                Return "miinl8"
            Case "inlay9.jpg"
                Return "miinl9"
            Case "inlay10.jpg"
                Return "miinl10"

            Case Else
                Return ""

        End Select
    End Function
    Public Sub deletefile(ByVal filetodelete As String)
        Try
            If File.Exists(filetodelete) Then File.SetAttributes(filetodelete, FileAttributes.Normal)
        Catch ex As Exception

        End Try
        Try
            If File.Exists(filetodelete) Then File.Delete(filetodelete)
        Catch ex As Exception
            System.Threading.Thread.Sleep(500)
            Try
                If File.Exists(filetodelete) Then File.Delete(filetodelete)
            Catch ex2 As Exception

            End Try
        End Try

    End Sub
    Public Function check_movie_has_extra_images(ByVal tmovie As movie) As String
        If tmovie.pfilemode Then Return ""
        If Not Directory.Exists(addfiletofolder(tmovie.getmoviepath, "extras")) Then Return ""
        Dim filelist() As String = Directory.GetFiles(addfiletofolder(tmovie.getmoviepath, "extras"))
        Dim hasFile As Boolean = False
        Dim results As String = ""
        For Each curfile As String In filelist
            If curfile.Contains(".jpg") Then
                Dim curres As String = ""
                curres = return_media_images_for_tag(getfilefrompath(curfile))
                If Not curres = "" Then
                    results += " / " & curres 'return_media_images_for_tag(getfilefrompath(curfile))
                    hasFile = True
                End If

            End If
        Next
        If hasFile Then Return results
        Return ""
    End Function
    Public Function validmoviedirc(ByVal s As String) As Boolean
        Select Case True
            Case Strings.Right(s, 3).ToLower = "cd1"
                Return False
            Case Strings.Right(s, 11).ToLower = "extrathumbs"
                Return False
            Case Strings.Right(s, 6).ToLower = "extras"
                Return False
            Case Strings.Right(s, 3).ToLower = "cd2"
                Return False
            Case Strings.Right(s, 3).ToLower = "cd3"
                Return False
            Case Strings.Right(s, 4).ToLower = "subs"
                Return False
            Case Strings.Right(s, 9).ToLower = "subtitles"
                Return False
            Case Strings.Right(s, 8).ToLower = "video_ts"
                Return False
            Case Strings.Right(s, 8).ToLower = "audio_ts"
                Return False
            Case Strings.Right(s, 7).ToLower = "trailer"
                Return False
            Case Strings.Right(s, 15).ToLower = "temporary files"
                Return False
            Case Strings.Right(s, 8).ToLower = "(noscan)"
                Return False
            Case Strings.Right(s, 6).ToLower = "sample"
                Return False
            Case s.ToUpper.Contains("RECYCLER")
                Return False
            Case s.ToUpper.Contains("$RECYCLE.BIN")
                Return False
            Case s.ToUpper.Contains("LOST+FOUND")
                Return False
            Case s.ToLower.Contains("system volume information")
                Return False
            Case s.ToUpper.Contains("CERTIFICAT")
                Return False
            Case s.ToUpper.Contains("BDMV")
                Return False
            Case s.ToLower.Contains("jacket_p")
                Return False
            Case Else
                Return True
        End Select
    End Function
    Public Function validshowdirc(ByVal s As String) As Boolean
        Select Case True
            Case Strings.Right(s, 3).ToLower = "cd1"
                Return False
            Case Strings.Right(s, 3).ToLower = "cd2"
                Return False
            Case Strings.Right(s, 3).ToLower = "cd3"
                Return False
            Case Strings.Right(s, 4).ToLower = "subs"
                Return False
            Case Strings.Right(s, 9).ToLower = "subtitles"
                Return False
            Case Strings.Right(s, 8).ToLower = "video_ts"
                Return False
            Case Strings.Right(s, 8).ToLower = "audio_ts"
                Return False
            Case Strings.Right(s, 7).ToLower = "trailer"
                Return False
            Case Strings.Right(s, 15).ToLower = "temporary files"
                Return False
            Case Strings.Right(s, 8).ToLower = "(noscan)"
                Return False
            Case Strings.Right(s, 6).ToLower = "sample"
                Return False
            Case Strings.Right(s, 8).ToUpper = "RECYCLER"
                Return False
            Case Strings.Right(s, 12).ToUpper = "$RECYCLE.BIN"
                Return False
            Case Strings.Right(s, 10).ToUpper = "LOST+FOUND"
                Return False
            Case s.ToLower.Contains("system volume information")
                Return False
            Case Else
                Return True
        End Select
    End Function
    Public Function getFileSizeExact(ByVal vFile As String) As Double
        'Dim curFile As FileInfo
        Dim curfile As FileInfo = My.Computer.FileSystem.GetFileInfo(vFile)
        Dim fileSize As Double = curfile.Length
        Return fileSize
    End Function

    Public Sub filetofolder(ByRef currentmovie As movie, ByVal vdstdir As String)
        If Not currentmovie.pfilemode Then Exit Sub
        'Take current Movie name and create a folder
        Dim destdir As String = ""
        destdir = addfiletofolder(vdstdir, currentmovie.pmoviename)

        If Directory.Exists(destdir) Then
            Exit Sub
        Else
            Directory.CreateDirectory(destdir)
        End If

        'current filename
        Dim currentfilename As String = getfilefrompath(currentmovie.preservedmoviename)
        Dim currentpath As String = currentmovie.getmoviepath
        File.Move(addfiletofolder(currentpath, currentmovie.preservedmoviename), addfiletofolder(destdir, getfilefrompath(currentmovie.preservedmoviename)))

        Dim stackedname As String = ""
        stackedname = stripstackforfilemode(removeextension(currentfilename))

        If File.Exists(addfiletofolder(currentpath, currentfilename & "-big.png")) Then
            File.Move(addfiletofolder(currentpath, currentfilename & "-big.png"), addfiletofolder(destdir, "movie.tbn"))
        End If
        If File.Exists(addfiletofolder(currentpath, removeextension(currentfilename) & ".nfo")) Then
            File.Move(addfiletofolder(currentpath, removeextension(currentfilename) & ".nfo"), addfiletofolder(destdir, removeextension(currentfilename) & ".nfo"))
            File.Copy(addfiletofolder(destdir, removeextension(currentfilename) & ".nfo"), addfiletofolder(destdir, "movie.nfo"))
        End If
        If File.Exists(addfiletofolder(currentpath, removeextension(currentfilename) & ".tbn")) Then
            File.Move(addfiletofolder(currentpath, removeextension(currentfilename) & ".tbn"), addfiletofolder(destdir, removeextension(currentfilename) & ".tbn"))
            File.Copy(addfiletofolder(destdir, removeextension(currentfilename) & ".tbn"), addfiletofolder(destdir, "folder.jpg"))
        End If
        If File.Exists(addfiletofolder(currentpath, removeextension(currentfilename) & "-fanart.jpg")) Then
            File.Move(addfiletofolder(currentpath, removeextension(currentfilename) & "-fanart.jpg"), addfiletofolder(destdir, removeextension(currentfilename) & "-fanart.jpg"))
            File.Copy(addfiletofolder(destdir, removeextension(currentfilename) & "-fanart.jpg"), addfiletofolder(destdir, "fanart.jpg"))
        End If

        If File.Exists(addfiletofolder(currentpath, stackedname & ".nfo")) Then
            File.Move(addfiletofolder(currentpath, stackedname & ".nfo"), addfiletofolder(destdir, stackedname & ".nfo"))
            File.Copy(addfiletofolder(destdir, stackedname & ".nfo"), addfiletofolder(destdir, "movie.nfo"))
        End If
        If File.Exists(addfiletofolder(currentpath, stackedname & ".tbn")) Then
            File.Move(addfiletofolder(currentpath, stackedname & ".tbn"), addfiletofolder(destdir, stackedname & ".tbn"))
            File.Copy(addfiletofolder(destdir, stackedname & ".nfo"), addfiletofolder(destdir, "folder.jpg"))
        End If
        If File.Exists(addfiletofolder(currentpath, stackedname & "-fanart.jpg")) Then
            File.Move(addfiletofolder(currentpath, stackedname & "-fanart.jpg"), addfiletofolder(destdir, stackedname & "-fanart.jpg"))
            File.Copy(addfiletofolder(destdir, stackedname & "-fanart.jpg"), addfiletofolder(destdir, "fanart.jpg"))
        End If

        currentmovie.setmoviepath(destdir)
        currentmovie.pfilemode = False

    End Sub
    Public Function getfilefrompath(ByVal filenameandpath As String) As String
        Dim fnPeices1() As String = filenameandpath.ToString.Split(CChar("\"))
        Dim returnedfilename As String = fnPeices1(fnPeices1.Length - 1)
        Return returnedfilename
    End Function
    Public Sub checkzerofilesize(ByVal filename As String)
        'make sure it's not a 0k file
        If File.Exists(filename) Then
            'check it's size, 0k files need to be removed
            Try
                File.SetAttributes(filename, FileAttributes.Normal)
            Catch ex As Exception
                Console.Out.WriteLine(ex.ToString)
            End Try

            Try
                If getFileSizeExact(filename) < 1 Then
                    'Console.Out.WriteLine("Image invalid - Deleteing " & Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                    File.Delete(filename)
                End If

            Catch ex As Exception
                Console.Out.WriteLine(ex.ToString)
            End Try
        End If
    End Sub

    Public Function removeextension(ByRef filename As String) As String
        Dim retstr As String = "none"
        If Not filename = Nothing Then
            If filename.Length > 5 Then
                If Strings.Left(Strings.Right(filename, 3), 1) = "." Then
                    retstr = Strings.Left(filename, filename.Length - 3)
                Else
                    retstr = Strings.Left(filename, filename.Length - 4)
                End If
                'retstr = Strings.Left(filename, filename.Length - 4)
            End If
        End If
        Return retstr
    End Function
End Module
