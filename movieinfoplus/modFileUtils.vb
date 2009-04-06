Imports System.IO

Module modFileUtils
    Public Function validmoviedirc(ByVal s As String) As Boolean
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
    Private Function getFileSizeExact(ByVal vFile As String) As Double
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
