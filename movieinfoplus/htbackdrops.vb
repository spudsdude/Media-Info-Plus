Imports System.Xml.Serialization
Imports System.IO
Imports System.Text.RegularExpressions

Public Class htbackdrops
    Private pitems As New List(Of bditem)
    Private pcachedir As String
    Property cachedir() As String
        Get
            Return pcachedir
        End Get
        Set(ByVal value As String)
            pcachedir = value
        End Set
    End Property
    Property items() As List(Of bditem)
        Get
            Return (pitems)
        End Get
        Set(ByVal value As List(Of bditem))
            pitems = value
        End Set
    End Property
    Public Sub writeXML(ByRef folderlocationandname As String)
        Dim serializer As New XmlSerializer(Me.GetType())
        Try
            Dim writer As New StreamWriter(folderlocationandname)
            serializer.Serialize(writer, Me)
            writer.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub readXML(ByVal xmllocationandfilename As String, ByRef vhtbackdrops As htbackdrops)
        Dim xmlfile As String = xmllocationandfilename
        Dim serializer As New XmlSerializer(Me.GetType())
        Dim gROReader As New StreamReader(xmlfile)
        Dim gRvtvdblangData As htbackdrops = CType(serializer.Deserialize(gROReader), htbackdrops)
        gROReader.Close()
        vhtbackdrops = gRvtvdblangData
    End Sub
    Private Function createlink(ByVal id As String) As String
        'http://www.htbackdrops.com/download.php?image_id=
        Dim downloadurl As String = "http://www.htbackdrops.com/download.php?image_id=" & id
        Return downloadurl
    End Function
    Private Function createthumblink(ByVal nameoffile As String) As String
        Return "http://www.htbackdrops.com/" & nameoffile
    End Function
    Private Function cleanname(ByVal name As String, Optional ByVal trimit As Boolean = False) As String
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
        If trimit Then cleanedname.Trim()
        Return cleanedname
    End Function

    Private Function search(ByVal searchname As String) As String
        'http://www.htbackdrops.com/search.php?search_keywords=
        Dim searchurl As String = "http://www.htbackdrops.com/search.php?search_keywords=" & cleanname(searchname, True)
        Dim whereToSave As String = ""
        whereToSave = maincollection.rconf.tempfolder + "htbackdrops\" + cleanname(searchname, True) + ".html"
        If File.Exists(whereToSave) Then
            Try
                File.Delete(whereToSave)
            Catch ex As Exception
                Debug.Print("Failed to remove htbackdrops temp file :" & ex.ToString)
            End Try
        End If
        wget(searchurl, cleanname(searchname, True), False, cleanname(searchname, True))

       
        Return whereToSave
    End Function
    Private Sub wget(ByRef url As String, ByRef id As String, ByVal wait As Boolean, ByVal vseriesid As String)
        Dim binfilelocal As String = maincollection.rconf.wgetfolder + "wget.exe"
        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        Dim whereToSave As String
        If Not Directory.Exists(maincollection.rconf.tempfolder + "htbackdrops\") Then Directory.CreateDirectory(maincollection.rconf.tempfolder + "htbackdrops\")
        whereToSave = maincollection.rconf.tempfolder + "htbackdrops\" + vseriesid + ".html"
        pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + whereToSave + """"
        'Debug.Print("""" + url + """" + " -P " + """" + rconf.tvdbtempfolder + id.ToString + """")
        If maincollection.rconf.tv_showwgetwindows Then
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        Else
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        End If
        pro1.Start()
        pro1.WaitForExit()
    End Sub
    Private Function parsehtml(ByRef whattoparse As String, ByRef curhtitem As htbackdrops) As Boolean
        Dim filedata As String = File.ReadAllText(whattoparse)
        Try
            'Dim RegexObjName As New Regex("image_id=(\d{1,10}).*?<img src="".(/data/thumbnails/1/.*?.jpg)""")
            Dim RegexObjName As New Regex("image_id=(\d{1,10}).*?<img src="".(/data/thumbnails/1/.*?.jpg)"".*?alt=""(.*?)""")
            Dim MatchResultsName As Match = RegexObjName.Match(filedata)
            While MatchResultsName.Success
                Dim nbditem As New bditem
                nbditem.name = MatchResultsName.Groups(1).Value.ToString
                nbditem.url = createlink(MatchResultsName.Groups(1).Value.ToString)
                nbditem.thumburl = createthumblink(MatchResultsName.Groups(2).Value.ToString)
                nbditem.sname = MatchResultsName.Groups(3).Value.ToString
                nbditem.size = ""
                nbditem.destinationfolder = curhtitem.cachedir & MatchResultsName.Groups(1).Value.ToString & ".jpg"
                curhtitem.items.Add(nbditem)
                MatchResultsName = MatchResultsName.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Return True
    End Function

    Public Sub getdownloadlist(ByRef thearraylist As ArrayList, ByVal searchstring As String) ', ByRef tempfolder As String, ByRef xmlfolder As String, ByRef cachefolder As String) ' As configuration)
        Dim filename As String = search(searchstring)
        Dim curhtitem As New htbackdrops
        curhtitem.cachedir = maincollection.rconf.cachefolder + "htbackdrops\"
        If Not Directory.Exists(curhtitem.cachedir) Then Directory.CreateDirectory(curhtitem.cachedir)
        parsehtml(filename, curhtitem)
        Dim tarray As New ArrayList
        Dim thas As New Hashtable
        If Not curhtitem.items.Count = 0 Then
            For Each curdb As bditem In curhtitem.items
                Try
                    thas.Add(curdb.name, curdb)
                    tarray.Add(curdb) 'filters dups by erroring on duplicate id numbers 
                Catch ex As Exception

                End Try
                'tarray.Add(curdb)
            Next
        End If
        'htpasseeddrop = curhtitem
        thearraylist = tarray
    End Sub

End Class
Public Class bditem
    'name, url, size, thumburl
    Private pname As String
    Private purl As String
    Private psize As String
    Private pthumburl As String
    Private pdestinationfolder As String
    Private psname As String
    Property sname() As String
        Get
            Return psname
        End Get
        Set(ByVal value As String)
            psname = value
        End Set
    End Property
    Property destinationfolder() As String
        Get
            Return pdestinationfolder
        End Get
        Set(ByVal value As String)
            pdestinationfolder = value
        End Set
    End Property
    Property name() As String
        Get
            Return pname
        End Get
        Set(ByVal value As String)
            pname = value
        End Set
    End Property
    Property url() As String
        Get
            Return purl
        End Get
        Set(ByVal value As String)
            purl = value
        End Set
    End Property
    Property size() As String
        Get
            Return psize
        End Get
        Set(ByVal value As String)
            psize = value
        End Set
    End Property
    Property thumburl() As String
        Get
            Return pthumburl
        End Get
        Set(ByVal value As String)
            pthumburl = value
        End Set
    End Property
End Class