Imports System
Imports System.IO
Imports System.Net
Imports System.Text


Public Class resource_extractor
    Dim executing_assembly As System.Reflection.Assembly = _
        Me.GetType.Assembly.GetEntryAssembly()

    ' Get our namespace.
    Dim my_namespace As String = _
        executing_assembly.GetName().Name.ToString()

    Dim iconf As New movieinfoplus.configuration

    Private Sub checkfolderisthere()
        'see if folders exsist, if they don't, make them
        If Not Directory.Exists(iconf.basefolder) Then Directory.CreateDirectory(iconf.basefolder)
        If Not Directory.Exists(iconf.thirdpartyfolder) Then Directory.CreateDirectory(iconf.thirdpartyfolder)
        If Not Directory.Exists(iconf.xmlmainfolder) Then Directory.CreateDirectory(iconf.xmlmainfolder)
        If Not Directory.Exists(iconf.cachefolder) Then Directory.CreateDirectory(iconf.cachefolder)
        If Not Directory.Exists(iconf.tempfolder) Then Directory.CreateDirectory(iconf.tempfolder)
        If Not Directory.Exists(iconf.xmlfolder) Then Directory.CreateDirectory(iconf.xmlfolder)
        If Not Directory.Exists(iconf.xmlfolderposters) Then Directory.CreateDirectory(iconf.xmlfolderposters)
        If Not Directory.Exists(iconf.xmlfolderimdb) Then Directory.CreateDirectory(iconf.xmlfolderimdb)
        If Not Directory.Exists(iconf.iconcachefolder) Then Directory.CreateDirectory(iconf.iconcachefolder)
        If Not Directory.Exists(iconf.postercachefolder) Then Directory.CreateDirectory(iconf.postercachefolder)
        If Not Directory.Exists(iconf.imdbcachefolder) Then Directory.CreateDirectory(iconf.imdbcachefolder)
        If Not Directory.Exists(iconf.listsfolder) Then Directory.CreateDirectory(iconf.listsfolder)
        If Not Directory.Exists(iconf.listsTempfolder) Then Directory.CreateDirectory(iconf.listsTempfolder)
        If Not Directory.Exists(iconf.sevenzipfolder) Then Directory.CreateDirectory(iconf.sevenzipfolder)
        If Not Directory.Exists(iconf.wgetfolder) Then Directory.CreateDirectory(iconf.wgetfolder)
        If Not Directory.Exists(iconf.dirUnRAR) Then Directory.CreateDirectory(iconf.dirUnRAR)
        If Not Directory.Exists(iconf.resourcefolder) Then Directory.CreateDirectory(iconf.resourcefolder)
        If Not Directory.Exists(iconf.ImageMagickFolder) Then Directory.CreateDirectory(iconf.ImageMagickFolder)

    End Sub
    'binfilelocal, " e " + """" + fileToUncompress + """" -o" + """" + folderToSaveExtractedContentsTo + """"
    Private Sub decompress7zip(ByRef fileToUncompress As String, ByRef folderToSaveExtractedContentsTo As String)
        Dim binfilelocal As String = """" + iconf.sevenzipfolder + "7za.exe" + """"
        System.Diagnostics.Process.Start(binfilelocal, " e " + """" + fileToUncompress + """" + " -o" + """" + folderToSaveExtractedContentsTo + """")

    End Sub

    Private Sub decompress(ByRef fileToUncompress As String, ByRef folderToSaveExtractedContentsTo As String)
        Dim binfilelocal As String = """" + iconf.dirUnRAR + "UnRAR.exe" + """"
        System.Diagnostics.Process.Start(binfilelocal, " e " + """" + fileToUncompress + """" + " -y -o+ " + """" + folderToSaveExtractedContentsTo + """")
        Debug.Print(binfilelocal, " e " + fileToUncompress + " -y -o+ " + folderToSaveExtractedContentsTo)
    End Sub
    Private Sub writeresPosterXML() '~3MB limit
        checkfolderisthere()
        ' Get our namespace.
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(3000000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.tempfolder + "posterxmls.rar")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".posterxmls.rar")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile PosterXMLs failed")
        End Try
    End Sub
    Private Sub writeresIMDBXML() '~6MB limit
        checkfolderisthere()
        ' Get our namespace.
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(6000000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.tempfolder + "imdbcache.rar")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".imdbcache.rar")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile PosterXMLs failed")
        End Try
    End Sub
    Private Sub writeresImageMagik() '~6MB limit
        checkfolderisthere()
        ' Get our namespace.
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(6000000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.tempfolder + "ImageMagick.rar")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".ImageMagick.rar")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile ImageMagick.rar failed")
        End Try
    End Sub
    Private Sub writeresUnRAR() '~400KB limit
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(400000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.dirUnRAR + "UnRAR.exe")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".UnRAR.exe")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile of UnRAR.exe failed")
        End Try
    End Sub

    Private Sub writeresimdbnfoupdate() '~400KB limit
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(400000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.basefolder + "imdbnfoupdate.xml")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".imdbnfoupdate.xml")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile of imdbnfoupdate.xml failed")
        End Try
    End Sub

    Private Sub writeresWget() '3MB limit
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(3000000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.wgetfolder + "wget.exe")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".wget.exe")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed")
        End Try
    End Sub

    Private Sub writeres7zip() '3MB limit
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(3000000) {}
        Try
            Dim outStream As Stream = System.IO.File.Create(iconf.sevenzipfolder + "7za.exe")
            Dim inStream As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".7za.exe")
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed")
        End Try
    End Sub

    Private Sub writeres_pngs() 'varied limit
        writeres_pngs_red_x()
        writeres_pngs_green_check()
        writeres_pngs_questionmark()
        writeres_pngs_emptystar()
        writeres_pngs_fullstar()
        writeres_pngs_halfstar()
        'writeres_pngs_1080p()
        'writeres_pngs_720p()
        'writeres_pngs_SD()
        'writeres_pngs_sterio()
        'writeres_pngs_71()
        'writeres_pngs_51()
        'writeres_pngs_mono()
    End Sub
#Region "-- PNG Resource Extraction --"
    Private Sub writeres_pngs_sterio()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "stereo.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".stereo.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for stereo.png")
        End Try
    End Sub
    Private Sub writeres_pngs_71()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "7.1.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".7.1.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for 7.1.png")
        End Try
    End Sub
    Private Sub writeres_pngs_51()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "5.1.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".5.1.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for 5.1.png")
        End Try
    End Sub
    Private Sub writeres_pngs_mono()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "mono.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".mono.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for mono.png")
        End Try
    End Sub
    Private Sub writeres_pngs_SD()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "SD.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".SD.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for SD.png")
        End Try
    End Sub
    Private Sub writeres_pngs_1080p()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "1080p.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".1080p.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for 1080p.png")
        End Try
    End Sub
    Private Sub writeres_pngs_720p()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "720p.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".720p.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for 720p.png")
        End Try
    End Sub
    Private Sub writeres_pngs_red_x()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(50000) {}
        Try
            Dim outStream_red_x As Stream = System.IO.File.Create(iconf.resourcefolder + "red_x.png")
            Dim inStream_red_x As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".red_x.png")
            Dim l As Integer
            Do
                l = inStream_red_x.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_red_x.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_red_x.Close()
            inStream_red_x.Close()
            outStream_red_x = Nothing
            inStream_red_x = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for red_x.png")
        End Try
    End Sub

    Private Sub writeres_pngs_green_check()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(300000) {}
        Try
            Dim outStream_green_check As Stream
            outStream_green_check = System.IO.File.Create(iconf.resourcefolder + "green_check.png")
            Dim inStream_green_check As Stream
            inStream_green_check = executing_assembly.GetManifestResourceStream(my_namespace + ".green_check.png")
            Dim l As Integer
            Do
                l = inStream_green_check.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_green_check.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_green_check.Close()
            inStream_green_check.Close()
            outStream_green_check = Nothing
            inStream_green_check = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for green_check.png")
        End Try
    End Sub

    Private Sub writeres_pngs_questionmark()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(300000) {}

        'Dim buffer As Byte() = New Byte(300000) {}
        Try
            Dim outStream_questionmark As Stream = System.IO.File.Create(iconf.resourcefolder + "questionmark.png")
            Dim inStream_questionmark As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".questionmark.png")
            Dim l As Integer
            Do
                l = inStream_questionmark.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_questionmark.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_questionmark.Close()
            inStream_questionmark.Close()
            outStream_questionmark = Nothing
            inStream_questionmark = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for questionmark.png")
        End Try
    End Sub

    Private Sub writeres_pngs_fullstar()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(300000) {}

        'Dim buffer As Byte() = New Byte(300000) {}
        Try
            Dim outStream_fullstar As Stream = System.IO.File.Create(iconf.resourcefolder + "fullstar.png")
            Dim inStream_fullstar As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".fullstar.png")
            Dim l As Integer
            Do
                l = inStream_fullstar.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_fullstar.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_fullstar.Close()
            inStream_fullstar.Close()
            outStream_fullstar = Nothing
            inStream_fullstar = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for fullstar.png")
        End Try

    End Sub

    Private Sub writeres_pngs_emptystar()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(300000) {}
        Try
            Dim outStream_emptystar As Stream = System.IO.File.Create(iconf.resourcefolder + "emptystar.png")
            Dim inStream_emptystar As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".emptystar.png")
            Dim l As Integer
            Do
                l = inStream_emptystar.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_emptystar.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_emptystar.Close()
            inStream_emptystar.Close()
            outStream_emptystar = Nothing
            inStream_emptystar = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for emptystar.png")
        End Try
    End Sub

    Private Sub writeres_pngs_halfstar()
        checkfolderisthere()
        Dim my_namespace As String = _
            executing_assembly.GetName().Name.ToString()
        Dim Value As Boolean = True

        Dim buffer As Byte() = New Byte(300000) {}

        Try
            Dim outStream_halfstar As Stream = System.IO.File.Create(iconf.resourcefolder + "halfstar.png")
            Dim inStream_halfstar As Stream = executing_assembly.GetManifestResourceStream(my_namespace _
            + ".halfstar.png")
            Dim l As Integer
            Do
                l = inStream_halfstar.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream_halfstar.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream_halfstar.Close()
            inStream_halfstar.Close()
            outStream_halfstar = Nothing
            inStream_halfstar = Nothing
            buffer = Nothing
        Catch
            Value = False
            Debug.Print("SaveBinaryFile failed for halfstar.png")
        End Try
    End Sub
#End Region
    Public Sub createresources(Optional ByVal extractimdbposterxmls As Boolean = True, Optional ByVal force As Boolean = False)
        If force Then
            writeresUnRAR()
            writeres7zip()
            ' writeresImageMagik()
            'writeresPosterXML()
            'writeresIMDBXML()
            writeresWget()
        End If
        'writeresUnRAR()
        'writeres7zip()
        'writeresImageMagik()
        'writeresPosterXML()
        'writeresIMDBXML()
        'writeresWget()
        writeresimdbnfoupdate()
        'writeres_pngs()
        If extractimdbposterxmls Then decompress7zip(iconf.tempfolder + "posterxmls.7z", iconf.xmlfolderposters)
        ' If extractimdbposterxmls Then decompress(iconf.tempfolder + "imdbcache.rar", iconf.imdbcachefolder)
        If extractimdbposterxmls Then decompress7zip(iconf.tempfolder + "ImageMagickMip32.7z", iconf.ImageMagickFolder)
        'decompress(iconf.tempfolder + "ImageMagick.rar", iconf.ImageMagickFolder)
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        createresources(True)
    End Sub
End Class