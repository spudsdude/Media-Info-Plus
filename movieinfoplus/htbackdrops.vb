Imports System.Xml.Serialization
Imports System.IO
Imports System.Text.RegularExpressions

Public Class htbackdrops
    'name, url, size, thumburl
    Private pname As String
    Private purl As String
    Private psize As String
    Private pthumburl As String
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
    Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vhtbackdrops As htbackdrops)
        Dim xmlfile As String = xmllocationandfilename
        Dim serializer As New XmlSerializer(Me.GetType())
        Dim gROReader As New StreamReader(xmlfile)
        Dim gRvtvdblangData As htbackdrops = CType(serializer.Deserialize(gROReader), htbackdrops)
        gROReader.Close()
        vhtbackdrops = gRvtvdblangData
    End Sub
    Private Sub download(ByVal id As String)
        'http://www.htbackdrops.com/download.php?image_id=
        Dim downloadurl As String = "http://www.htbackdrops.com/download.php?image_id=" & id
    End Sub
    Private Function search(ByVal searchname As String) As String
        Dim junk As String = ""
        'http://www.htbackdrops.com/search.php?search_keywords=
        Dim searchurl As String = "http://www.htbackdrops.com/search.php?search_keywords=" & searchname
        Return junk
    End Function
    Private Function parsehtml(ByRef curhtitem As htbackdrops) As Boolean
        Try
            Dim RegexObjName As New Regex("image_id=(\d{1,10}).*?<img src="".(/data/thumbnails/1/.*?.jpg)""")
            Dim MatchResultsName As Match = RegexObjName.Match(url)
            While MatchResultsName.Success
                Dim i As Integer
                For i = 1 To MatchResultsName.Groups.Count
                    Dim GroupObjName As Group = MatchResultsName.Groups(i)
                    If GroupObjName.Success Then

                    End If
                Next
                MatchResultsName = MatchResultsName.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Return True
    End Function

    
End Class
