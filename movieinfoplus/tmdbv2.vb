Option Explicit On
Option Strict On
Imports System
Imports System.IO
Imports System.Net
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace tmdbapiv2
    <XmlRoot("results")> _
     Public Class [Results]
        Private p_attribute_xmlns As XmlSerializerNamespaces
        Private p_attribute_for As String
        Private p_element_query As Query
        Private p_element_totalresults As String
        Private p_element_moviematches As Moviematches
        Public mykey As String = "0f790eb54e7430c118594f1db0071444" 'File.ReadAllText("c:\program files\movieinfoplus\tmdbapiv2key.txt") '"PUT YOUR OWN KEY HERE, in place of the file loader."
        'get full movie details by TMDB ID (gets all data about the movie)
        Private Sub getfullmoviedetailsbytmdbid(ByRef ttmdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal wait As Boolean, ByVal usewget As Boolean)
            ' old api call  "http://api.themoviedb.org/backdrop.php?imdb=" + imdbid
            ' new api call for imdbid http://api.themoviedb.org/2.0/Movie.imdbLookup?imdb_id= + imdbid + &api_key= + mykey
            If usewget Then
                Dim url As String = "http://api.themoviedb.org/2.0/Movie.getInfo?id=" + ttmdbid + "&api_key=" + mykey '"http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                Dim folder As String = wheretoputxml
                Dim binfilelocal As String = wgetfolder + "wget.exe"
                Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
                Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
                pro1.StartInfo.FileName = binfilelocal
                pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + folder + "tmdb" + ttmdbid + ".xml" + """"
                pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                pro1.Start()
                If wait Then pro1.WaitForExit()
            Else
                'use built in http method
                Try
                    Dim url As String = "http://api.themoviedb.org/2.0/Movie.imdbLookup?imdb_id=" + ttmdbid + "&api_key=" '"http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                    Dim folder As String = wheretoputxml
                    Dim aWebRequest As WebRequest
                    aWebRequest = WebRequest.Create(url.ToLower)
                    Dim aHttpWebResponse As HttpWebResponse
                    aHttpWebResponse = CType(aWebRequest.GetResponse, HttpWebResponse)
                    Dim readStream As Stream
                    readStream = aHttpWebResponse.GetResponseStream
                    Dim buffer As Byte() = New Byte(3000000) {}
                    Try
                        Dim outStream As Stream = System.IO.File.Create(folder + "tmdb" + ttmdbid + ".xml")
                        'executing_assembly.GetManifestResourceStream(my_namespace _
                        '+ ".wget.exe")
                        Dim l As Integer
                        Do
                            l = readStream.Read(buffer, 0, buffer.Length)
                            If l > 0 Then
                                outStream.Write(buffer, 0, l)
                            End If
                        Loop While l > 0
                        outStream.Close()
                        aHttpWebResponse.Close()
                        readStream.Close()
                    Catch ex As Exception
                        Debug.Print(ex.ToString)
                        aHttpWebResponse.Close()
                        readStream.Close()
                    End Try
                Catch ex1 As Exception
                    Debug.Print(ex1.ToString)
                End Try
            End If

        End Sub

        Public Function gettmdbidbyimdbid(ByVal imdbid As String, Optional ByVal overwritethexmlfile As Boolean = False) As String
            'check if the file is already there or overwrite is on
            Dim tmdb_xml_fromimdbid As String = maincollection.rconf.xmlfoldertmdbv2 + imdbid + ".xml"
            Try
                If Not File.Exists(tmdb_xml_fromimdbid) Or overwritethexmlfile Then
                    getTMDBDataByIMDBID(imdbid, maincollection.rconf.wgetfolder, maincollection.rconf.xmlfoldertmdbv2, True, True)
                End If
            Catch po As Exception
                Debug.Print(po.ToString)
            End Try

            'read the file and get the id from it
            Dim vresultsfromtmdb_fromimdbid As New Results
            'set object
            vresultsfromtmdb_fromimdbid = vresultsfromtmdb_fromimdbid.getresultsfromxml(tmdb_xml_fromimdbid)
            Dim tmdbidfromimdbid As String = ""
            Try
                tmdbidfromimdbid = vresultsfromtmdb_fromimdbid.Moviematches.Movie.Item(0).Id
            Catch ex As Exception
                Return ""
            End Try

            Return tmdbidfromimdbid

        End Function

        'get partial details by IMDBID (also allows us to get the TMDB ID)
        Private Sub getTMDBDataByIMDBID(ByRef timdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal wait As Boolean, ByVal usewget As Boolean)
            ' old api call  "http://api.themoviedb.org/backdrop.php?imdb=" + imdbid
            ' new api call for imdbid http://api.themoviedb.org/2.0/Movie.imdbLookup?imdb_id= + imdbid + &api_key=+ mykey
            If usewget Then
                Dim url As String = "http://api.themoviedb.org/2.0/Movie.imdbLookup?imdb_id=" + timdbid + "&api_key=" + mykey '"http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                Dim folder As String = wheretoputxml
                Dim binfilelocal As String = wgetfolder + "wget.exe"
                Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
                Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
                pro1.StartInfo.FileName = binfilelocal
                pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + folder + timdbid + ".xml" + """"
                pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                pro1.Start()
                If wait Then pro1.WaitForExit()
            Else
                'use built in http method
                Try
                    Dim url As String = "http://api.themoviedb.org/2.0/Movie.imdbLookup?imdb_id=" + timdbid + "&api_key=" + mykey '"http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                    Dim folder As String = wheretoputxml
                    Dim aWebRequest As WebRequest
                    aWebRequest = WebRequest.Create(url.ToLower)
                    Dim aHttpWebResponse As HttpWebResponse
                    aHttpWebResponse = CType(aWebRequest.GetResponse, HttpWebResponse)
                    Dim readStream As Stream
                    readStream = aHttpWebResponse.GetResponseStream
                    Dim buffer As Byte() = New Byte(3000000) {}
                    Try
                        Dim outStream As Stream = System.IO.File.Create(folder + timdbid + ".xml")
                        'executing_assembly.GetManifestResourceStream(my_namespace _
                        '+ ".wget.exe")
                        Dim l As Integer
                        Do
                            l = readStream.Read(buffer, 0, buffer.Length)
                            If l > 0 Then
                                outStream.Write(buffer, 0, l)
                            End If
                        Loop While l > 0
                        outStream.Close()
                        aHttpWebResponse.Close()
                        readStream.Close()
                    Catch ex As Exception
                        Debug.Print(ex.ToString)
                        aHttpWebResponse.Close()
                        readStream.Close()
                    End Try
                Catch ex1 As Exception
                    Debug.Print(ex1.ToString)
                End Try
            End If

        End Sub

        'Public function to get the posters
        Public Shared Sub getposters(ByRef tmovie As movie, ByRef theposterobject As tmdbapiv2.Posters, ByVal timdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal twait As Boolean, ByVal overwritethexmlfile As Boolean, ByVal usewget As Boolean) 'As mip.themoviedb.backdrop.backdrops
            Dim vresultsfromtmdb_fromimdbid As New Results
            Dim vresultsfromtmdb_fromtmdbid As New Results

            If timdbid = "" Then
                Exit Sub
            End If
            Dim tmdb_xml_fromimdbid As String = wheretoputxml + timdbid + ".xml"
            Try
                If Not File.Exists(tmdb_xml_fromimdbid) Or overwritethexmlfile Then
                    'file either doesn't exsist or overwritethexmlfile is true
                    If File.Exists(tmdb_xml_fromimdbid) Then 'set attrib, then attempt delete, on fail, try renaming, on fail, messagebox for user intervention
                        Try
                            File.SetAttributes(tmdb_xml_fromimdbid, FileAttributes.Normal)
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try
                        Try
                            File.Delete(tmdb_xml_fromimdbid)
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                            Try
                                File.Move(tmdb_xml_fromimdbid, tmdb_xml_fromimdbid + ".old" + Date.Today.ToString)
                            Catch ex2 As Exception
                            End Try

                        End Try
                    End If
                    If File.Exists(tmdb_xml_fromimdbid) Then
                        System.Threading.Thread.Sleep(10000) '10 second pause
                        Try
                            File.SetAttributes(tmdb_xml_fromimdbid, FileAttributes.Normal)
                            File.Delete(tmdb_xml_fromimdbid)
                        Catch ex As Exception
                        End Try

                    End If
                    If File.Exists(tmdb_xml_fromimdbid) Then
                        MsgBox("Error trying to remove a temp file " + tmdb_xml_fromimdbid + " : Please restart after deleting that file")
                    End If

                    'if we don't have an tmdb id then download the file to get it
                    Dim gettmdbid As Boolean = False
                    If tmovie.ptmdbid Is Nothing Then gettmdbid = True
                    If tmovie.ptmdbid = "" Then gettmdbid = True
                    If gettmdbid Or Not File.Exists(tmdb_xml_fromimdbid) Then
                        vresultsfromtmdb_fromimdbid.getTMDBDataByIMDBID(timdbid, wgetfolder, wheretoputxml, twait, usewget)
                    End If

                End If
                'set object
                vresultsfromtmdb_fromimdbid = vresultsfromtmdb_fromimdbid.getresultsfromxml(tmdb_xml_fromimdbid)
                Dim tmdbidfromimdbid = vresultsfromtmdb_fromimdbid.Moviematches.Movie.Item(0).Id
                theposterobject.tmdbid = tmdbidfromimdbid
                Dim tmdb_xml_fromtmdbid As String = wheretoputxml + "tmdb" + tmdbidfromimdbid + ".xml"
                If Not File.Exists(tmdb_xml_fromtmdbid) Or overwritethexmlfile Then
                    'file either doesn't exsist or overwritethexmlfile is true
                    'download the file
                    vresultsfromtmdb_fromtmdbid.getfullmoviedetailsbytmdbid(tmdbidfromimdbid, wgetfolder, wheretoputxml, twait, usewget)
                End If
                vresultsfromtmdb_fromtmdbid = vresultsfromtmdb_fromtmdbid.getresultsfromxml(tmdb_xml_fromtmdbid)
                For Each tposter As Poster In vresultsfromtmdb_fromtmdbid.Moviematches.Movie.Item(0).Posters
                    If tposter.Size = "original" Then theposterobject.posters.Add(tposter)
                Next
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End Sub

        'Public function to get the backdrops
        Public Shared Sub getbackdrops(ByRef tmovie As movie, ByRef thebackdropobject As tmdbapiv2.Backdrops, ByVal timdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal twait As Boolean, ByVal overwritethexmlfile As Boolean, ByVal usewget As Boolean, ByVal displayonly As Boolean) 'As mip.themoviedb.backdrop.backdrops
            Dim vresultsfromtmdb_fromimdbid As New Results
            Dim vresultsfromtmdb_fromtmdbid As New Results

            If timdbid = "" Then
                Exit Sub
            End If
            Dim tmdb_xml_fromimdbid As String = wheretoputxml + timdbid + ".xml"
            Try
                If (Not File.Exists(tmdb_xml_fromimdbid) Or overwritethexmlfile) And Not displayonly Then
                    'file either doesn't exsist or overwritethexmlfile is true
                    'download the file
                    Dim gettmdbid As Boolean = False
                    If tmovie.ptmdbid Is Nothing Then gettmdbid = True
                    If tmovie.ptmdbid = "" Then gettmdbid = True
                    If gettmdbid Or Not File.Exists(tmdb_xml_fromimdbid) Then
                        vresultsfromtmdb_fromimdbid.getTMDBDataByIMDBID(timdbid, wgetfolder, wheretoputxml, twait, usewget)
                    End If

                End If
                'set object
                vresultsfromtmdb_fromimdbid = vresultsfromtmdb_fromimdbid.getresultsfromxml(tmdb_xml_fromimdbid)
                Dim tmdbidfromimdbid As String = vresultsfromtmdb_fromimdbid.Moviematches.Movie.Item(0).Id
                If Not tmdbidfromimdbid Is Nothing Then
                    'MsgBox("NO ID")
                End If
                Dim tmdb_xml_fromtmdbid As String = wheretoputxml + "tmdb" + tmdbidfromimdbid + ".xml"
                If (Not File.Exists(tmdb_xml_fromimdbid) Or overwritethexmlfile) And Not displayonly Then
                    'file either doesn't exsist or overwritethexmlfile is true
                    'download the file
                    vresultsfromtmdb_fromtmdbid.getfullmoviedetailsbytmdbid(tmdbidfromimdbid, wgetfolder, wheretoputxml, twait, usewget)
                End If
                vresultsfromtmdb_fromtmdbid = vresultsfromtmdb_fromtmdbid.getresultsfromxml(tmdb_xml_fromtmdbid)
                For Each tbackdrop As backdrop In vresultsfromtmdb_fromtmdbid.Moviematches.Movie.Item(0).Backdrops
                    If tbackdrop.Size = "original" Then thebackdropobject.backdrops.Add(tbackdrop)
                Next
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End Sub
      
        'getxmlresults
        Private Function getresultsfromxml(ByVal stringnameofthebackdropsxmlfile As String) As tmdbapiv2.Results
            Dim xmlfile As String = stringnameofthebackdropsxmlfile
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRresults As New tmdbapiv2.Results
            Try
                gRresults = CType(serializer.Deserialize(gROReader), tmdbapiv2.Results)
            Catch ex As Exception
                Debug.Print("backdrop read: " + ex.ToString)
            End Try

            gROReader.Close()
            gROReader.Dispose()
            Return gRresults
        End Function

        ' <summary>XmlSerializerNamespaces attribute.</summary>
        <XmlNamespaceDeclarations()> _
        Public Property [xmlns]() As XmlSerializerNamespaces
            Get
                Return Me.p_attribute_xmlns
            End Get
            Set(ByVal Value As XmlSerializerNamespaces)
                Me.p_attribute_xmlns = Value
            End Set
        End Property

        ' <summary>System.string for attribute.</summary>
        <XmlAttribute("for", Namespace:="")> _
        Public Property [For]() As String
            Get
                Return Me.p_attribute_for
            End Get
            Set(ByVal Value As String)
                Me.p_attribute_for = Value
            End Set
        End Property

        ' <summary>Query xml element.</summary>
        <XmlElement("Query")> _
                Public Property [Query]() As Query
            Get
                Return Me.p_element_query
            End Get
            Set(ByVal Value As Query)
                Me.p_element_query = Value
            End Set
        End Property

        ' <summary>String totalResults element.</summary>
        <XmlElement("totalResults")> _
        Public Property [TotalResults]() As String
            Get
                Return Me.p_element_totalresults
            End Get
            Set(ByVal Value As String)
                Me.p_element_totalresults = Value
            End Set
        End Property

        ' <summary>moviematches xml element.</summary>
        <XmlElement("moviematches", Namespace:="")> _
        Public Property [Moviematches]() As Moviematches
            Get
                Return Me.p_element_moviematches
            End Get
            Set(ByVal Value As Moviematches)
                Me.p_element_moviematches = Value
            End Set
        End Property
    End Class
    Public Class [Category]
        Private p_element_name As String
        Private p_element_url As String

        ' <summary>String name element.</summary>
        <XmlElement("name")> _
        Public Property [Name]() As String
            Get
                Return Me.p_element_name
            End Get
            Set(ByVal Value As String)
                Me.p_element_name = Value
            End Set
        End Property

        ' <summary>String url element.</summary>
        <XmlElement("url")> _
        Public Property [Url]() As String
            Get
                Return Me.p_element_url
            End Get
            Set(ByVal Value As String)
                Me.p_element_url = Value
            End Set
        End Property
    End Class
    Public Class [Country]
        Private p_element_name As String
        Private p_element_shortname As String
        Private p_element_url As String

        ' <summary>String name element.</summary>
        <XmlElement("name")> _
        Public Property [Name]() As String
            Get
                Return Me.p_element_name
            End Get
            Set(ByVal Value As String)
                Me.p_element_name = Value
            End Set
        End Property

        ' <summary>String short_name element.</summary>
        <XmlElement("short_name")> _
        Public Property [ShortName]() As String
            Get
                Return Me.p_element_shortname
            End Get
            Set(ByVal Value As String)
                Me.p_element_shortname = Value
            End Set
        End Property

        ' <summary>String url element.</summary>
        <XmlElement("url")> _
        Public Property [Url]() As String
            Get
                Return Me.p_element_url
            End Get
            Set(ByVal Value As String)
                Me.p_element_url = Value
            End Set
        End Property
    End Class
    Public Class [tmdbMovie]
        Private p_element_score As String
        Private p_element_popularity As New List(Of String)
        Private p_element_title As String
        Private p_element_type As String
        Private p_element_id As String
        Private p_element_imdb As String
        Private p_element_url As String
        Private p_element_shortoverview As String
        Private p_element_rating As String
        Private p_element_release As String
        Private p_element_runtime As String
        Private p_element_budget As String
        Private p_element_revenue As String
        Private p_element_homepage As String
        Private p_element_productioncountries As ProductionCountries
        Private p_element_trailer As Trailer
        Private p_element_poster As New List(Of Poster)
        Private p_element_backdrop As New List(Of Backdrop)
        Private p_element_people As New List(Of Person)
        Private p_element_categories As New List(Of Category)

        ' <summary>String score element.</summary>
        <XmlElement("score")> _
        Public Property [Score]() As String
            Get
                Return Me.p_element_score
            End Get
            Set(ByVal Value As String)
                Me.p_element_score = Value
            End Set
        End Property

        ' <summary>String popularity element.</summary>
        <XmlElement("popularity")> _
        Public Property [Popularity]() As List(Of String)
            Get
                Return Me.p_element_popularity
            End Get
            Set(ByVal Value As List(Of String))
                Me.p_element_popularity = Value
            End Set
        End Property

        ' <summary>String title element.</summary>
        <XmlElement("title")> _
        Public Property [Title]() As String
            Get
                Return Me.p_element_title
            End Get
            Set(ByVal Value As String)
                Me.p_element_title = Value
            End Set
        End Property

        ' <summary>String type element.</summary>
        <XmlElement("type")> _
        Public Property [Type]() As String
            Get
                Return Me.p_element_type
            End Get
            Set(ByVal Value As String)
                Me.p_element_type = Value
            End Set
        End Property

        ' <summary>String id element.</summary>
        <XmlElement("id")> _
        Public Property [Id]() As String
            Get
                Return Me.p_element_id
            End Get
            Set(ByVal Value As String)
                Me.p_element_id = Value
            End Set
        End Property

        ' <summary>String imdb element.</summary>
        <XmlElement("imdb")> _
        Public Property [Imdb]() As String
            Get
                Return Me.p_element_imdb
            End Get
            Set(ByVal Value As String)
                Me.p_element_imdb = Value
            End Set
        End Property

        ' <summary>String url element.</summary>
        <XmlElement("url")> _
        Public Property [Url]() As String
            Get
                Return Me.p_element_url
            End Get
            Set(ByVal Value As String)
                Me.p_element_url = Value
            End Set
        End Property

        ' <summary>String short_overview element.</summary>
        <XmlElement("short_overview")> _
        Public Property [ShortOverview]() As String
            Get
                Return Me.p_element_shortoverview
            End Get
            Set(ByVal Value As String)
                Me.p_element_shortoverview = Value
            End Set
        End Property

        ' <summary>String rating element.</summary>
        <XmlElement("rating")> _
        Public Property [Rating]() As String
            Get
                Return Me.p_element_rating
            End Get
            Set(ByVal Value As String)
                Me.p_element_rating = Value
            End Set
        End Property

        ' <summary>String release element.</summary>
        <XmlElement("release")> _
        Public Property [Release]() As String
            Get
                Return Me.p_element_release
            End Get
            Set(ByVal Value As String)
                Me.p_element_release = Value
            End Set
        End Property

        ' <summary>String runtime element.</summary>
        <XmlElement("runtime")> _
        Public Property [Runtime]() As String
            Get
                Return Me.p_element_runtime
            End Get
            Set(ByVal Value As String)
                Me.p_element_runtime = Value
            End Set
        End Property

        ' <summary>String budget element.</summary>
        <XmlElement("budget")> _
        Public Property [Budget]() As String
            Get
                Return Me.p_element_budget
            End Get
            Set(ByVal Value As String)
                Me.p_element_budget = Value
            End Set
        End Property

        ' <summary>String revenue element.</summary>
        <XmlElement("revenue")> _
        Public Property [Revenue]() As String
            Get
                Return Me.p_element_revenue
            End Get
            Set(ByVal Value As String)
                Me.p_element_revenue = Value
            End Set
        End Property

        ' <summary>String homepage element.</summary>
        <XmlElement("homepage")> _
        Public Property [Homepage]() As String
            Get
                Return Me.p_element_homepage
            End Get
            Set(ByVal Value As String)
                Me.p_element_homepage = Value
            End Set
        End Property

        ' <summary>production_countries xml element.</summary>
        <XmlElement("production_countries")> _
        Public Property [ProductionCountries]() As ProductionCountries
            Get
                Return Me.p_element_productioncountries
            End Get
            Set(ByVal Value As ProductionCountries)
                Me.p_element_productioncountries = Value
            End Set
        End Property

        ' <summary>trailer xml element.</summary>
        <XmlElement("trailer")> _
        Public Property [Trailer]() As Trailer
            Get
                Return Me.p_element_trailer
            End Get
            Set(ByVal Value As Trailer)
                Me.p_element_trailer = Value
            End Set
        End Property

        ' <summary>Poster[] poster xml element.</summary>
        <XmlElement("poster")> _
        Public Property [Posters]() As List(Of Poster)
            Get
                Return Me.p_element_poster
            End Get
            Set(ByVal Value As List(Of Poster))
                Me.p_element_poster = Value
            End Set
        End Property

        ' <summary>Poster[] backdrop xml element.</summary>
        <XmlElement("backdrop")> _
        Public Property [Backdrops]() As List(Of Backdrop)
            Get
                Return Me.p_element_backdrop
            End Get
            Set(ByVal Value As List(Of Backdrop))
                Me.p_element_backdrop = Value
            End Set
        End Property

        ' <summary>Person[] people xml array element.</summary>
        <XmlArrayItem("person", GetType(Person))> _
        <XmlArray("people")> _
        Public Property [People]() As List(Of Person)
            Get
                Return Me.p_element_people
            End Get
            Set(ByVal Value As List(Of Person))
                Me.p_element_people = Value
            End Set
        End Property

        ' <summary>Category[] categories xml array element.</summary>
        <XmlArrayItem("category", GetType(Category))> _
        <XmlArray("categories")> _
        Public Property [Categories]() As List(Of Category)
            Get
                Return Me.p_element_categories
            End Get
            Set(ByVal Value As List(Of Category))
                Me.p_element_categories = Value
            End Set
        End Property
    End Class
    Public Class [Moviematches]
        Private p_element_movie As New list(Of tmdbMovie)

        ' <summary>movie xml element.</summary>
        <XmlElement("movie")> _
        Public Property [Movie]() As list(Of tmdbMovie)
            Get
                Return Me.p_element_movie
            End Get
            Set(ByVal Value As list(Of tmdbMovie))
                Me.p_element_movie = Value
            End Set
        End Property
    End Class
    Public Class [Person]
        Private p_attribute_job As String
        Private p_element_name As String
        Private p_element_url As String

        ' <summary>System.String job attribute.</summary>
        <XmlAttribute("job")> _
        Public Property [Job]() As String
            Get
                Return Me.p_attribute_job
            End Get
            Set(ByVal Value As String)
                Me.p_attribute_job = Value
            End Set
        End Property

        ' <summary>String name element.</summary>
        <XmlElement("name")> _
        Public Property [Name]() As String
            Get
                Return Me.p_element_name
            End Get
            Set(ByVal Value As String)
                Me.p_element_name = Value
            End Set
        End Property

        ' <summary>String url element.</summary>
        <XmlElement("url")> _
        Public Property [Url]() As String
            Get
                Return Me.p_element_url
            End Get
            Set(ByVal Value As String)
                Me.p_element_url = Value
            End Set
        End Property
    End Class
    Public Class [Poster]
        Private p_attribute_size As String
        Private p_element_text As String

        ' <summary>System.String size attribute.</summary>
        <XmlAttribute("size")> _
        Public Property [Size]() As String
            Get
                Return Me.p_attribute_size
            End Get
            Set(ByVal Value As String)
                Me.p_attribute_size = Value
            End Set
        End Property

        ' <summary>String text element.</summary>
        <XmlText()> _
        Public Property [Text]() As String
            Get
                Return Me.p_element_text
            End Get
            Set(ByVal Value As String)
                Me.p_element_text = Value
            End Set
        End Property
    End Class
    Public Class [ProductionCountries]
        Private p_element_country As Country

        ' <summary>country xml element.</summary>
        <XmlElement("country")> _
        Public Property [Country]() As Country
            Get
                Return Me.p_element_country
            End Get
            Set(ByVal Value As Country)
                Me.p_element_country = Value
            End Set
        End Property
    End Class
    Public Class [Query]
        Private p_attribute_searchterms As Integer

        ' <summary>System.Int32 searchTerms attribute.</summary>
        <XmlAttribute("searchTerms")> _
        Public Property [SearchTerms]() As Integer
            Get
                Return Me.p_attribute_searchterms
            End Get
            Set(ByVal Value As Integer)
                Me.p_attribute_searchterms = Value
            End Set
        End Property
    End Class
    Public Class [Trailer]
        Private p_attribute_source As String
        Private p_element_text As String

        ' <summary>System.String source attribute.</summary>
        <XmlAttribute("source")> _
        Public Property [Source]() As String
            Get
                Return Me.p_attribute_source
            End Get
            Set(ByVal Value As String)
                Me.p_attribute_source = Value
            End Set
        End Property

        ' <summary>String text element.</summary>
        <XmlText()> _
        Public Property [Text]() As String
            Get
                Return Me.p_element_text
            End Get
            Set(ByVal Value As String)
                Me.p_element_text = Value
            End Set
        End Property
    End Class
    'Public Class ResultsSerializer
    '    Private s As XmlSerializer = Nothing
    '    Private type As type = Nothing

    '    Public Sub New()
    '        Me.type = GetType(Results)
    '        Me.s = New XmlSerializer(Me.type)
    '    End Sub

    '    Public Function Deserialize(ByVal xml As String) As Results
    '        Dim reader As TextReader = New StringReader(xml)
    '        Return Deserialize(reader)
    '    End Function

    'Public Function Deserialize(ByVal doc As Results) As Results
    '    Dim reader = New StringReader(doc.OuterXml)
    '    Return Deserialize(reader)
    'End Function

    'Public Function Deserialize(ByVal reader As TextReader) As Results
    '    Dim o As Results = s.Deserialize(reader)
    '    reader.Close()
    '    Return o
    'End Function

    'Public Function Serialize(ByVal results As Results) As XmlDocument
    '    Dim xml As String = StringSerialize(results)
    '    Dim doc As XmlDocument = New XmlDocument
    '    doc.PreserveWhitespace = True
    '    doc.LoadXml(xml)
    '    doc = Clean(doc)
    '    Return doc
    'End Function

    'Private Function StringSerialize(ByVal results As Results) As String
    '    Dim w As TextWriter = WriterSerialize(results)
    '    Dim xml As String = w.ToString()
    '    w.Close()
    '    Return xml.Trim()
    'End Function

    'Private Function WriterSerialize(ByVal results As Results) As TextWriter
    '    Dim w As TextWriter = New StringWriter
    '    Me.s = New XmlSerializer(Me.type)
    '    results.xmlns = New XmlSerializerNamespaces()
    '    results.xmlns.Add("opensearch", "http://a9.com/-/spec/opensearch/1.1/")
    '    s.Serialize(w, results)
    '    w.Flush()
    '    Return w
    'End Function

    'Private Function Clean(ByVal doc As XmlDocument) As XmlDocument
    '    doc.RemoveChild(doc.FirstChild)
    '    Dim first As XmlNode = doc.FirstChild
    '    For Each n As XmlNode In doc.ChildNodes
    '        If (n.NodeType = XmlNodeType.Element) Then
    '            first = n
    '            Exit For
    '        End If
    '    Next
    '    If Not first.Attributes Is Nothing Then
    '        Dim a As XmlAttribute = Nothing
    '        a = first.Attributes("xmlns:xsd")
    '        If Not a Is Nothing Then first.Attributes.Remove(a)
    '        a = first.Attributes("xmlns:xsi")
    '        If Not a Is Nothing Then first.Attributes.Remove(a)
    '    End If
    '    Return doc
    'End Function

    'Public Shared Function ReadFile(ByVal file As String) As Results
    '    Dim serializer As ResultsSerializer = New ResultsSerializer
    '    Try
    '        Dim xml As String = String.Empty
    '        Dim reader As StreamReader = New StreamReader(file)
    '        xml = reader.ReadToEnd()
    '        reader.Close()
    '        reader = Nothing
    '        Return serializer.Deserialize(xml)
    '    Catch
    '    End Try
    '    Return New Results
    'End Function

    'Public Shared Function WriteFile(ByVal file As String, ByVal config As Results) As Boolean
    '    Dim ok As Boolean = False
    '    Dim serializer As ResultsSerializer = New ResultsSerializer
    '    Try
    '        Dim xml As String = serializer.Serialize(config).OuterXml
    '        Dim writer As StreamWriter = New StreamWriter(file, False)
    '        writer.Write(xml.Trim())
    '        writer.Flush()
    '        writer.Close()
    '        writer = Nothing
    '        ok = True
    '    Catch
    '    End Try
    '    Return ok
    'End Function
    'End Class
    ' Represents the Items.Item (aka the backdrop)
    'Public Class [Backdrop]
    '    Private p_element_url As System.String
    '    Private p_element_postcard As System.String
    '    Private p_element_thumb As System.String

    '    ' <summary>String URL element.</summary>
    '    <XmlElement("URL")> _
    '    Public Property [URL]() As System.String
    '        Get
    '            Return Me.p_element_url
    '        End Get
    '        Set(ByVal Value As System.String)
    '            Me.p_element_url = Value
    '        End Set
    '    End Property

    '    ' <summary>String Postcard element.</summary>
    '    <XmlElement("Postcard")> _
    '    Public Property [Postcard]() As System.String
    '        Get
    '            Return Me.p_element_postcard
    '        End Get
    '        Set(ByVal Value As System.String)
    '            Me.p_element_postcard = Value
    '        End Set
    '    End Property

    '    ' <summary>String Thumb element.</summary>
    '    <XmlElement("Thumb")> _
    '    Public Property [Thumb]() As System.String
    '        Get
    '            Return Me.p_element_thumb
    '        End Get
    '        Set(ByVal Value As System.String)
    '            Me.p_element_thumb = Value
    '        End Set
    '    End Property
    'End Class
    Public Class backdrop
        Private p_attribute_size As String
        Private p_element_text As String

        ' <summary>System.String size attribute.</summary>
        <XmlAttribute("size")> _
        Public Property [Size]() As String
            Get
                Return Me.p_attribute_size
            End Get
            Set(ByVal Value As String)
                Me.p_attribute_size = Value
            End Set
        End Property

        ' <summary>String text element.</summary>
        <XmlText()> _
        Public Property [Text]() As String
            Get
                Return Me.p_element_text
            End Get
            Set(ByVal Value As String)
                Me.p_element_text = Value
            End Set
        End Property
    End Class
    Public Class Backdrops
        Private p_element_backdrops As New List(Of backdrop)
        Private p_element_tmdbid As String
        Property tmdbid() As String
            Get
                Return p_element_tmdbid
            End Get
            Set(ByVal value As String)
                p_element_tmdbid = value
            End Set
        End Property
        Property backdrops() As List(Of backdrop)
            Get
                Return (p_element_backdrops)
            End Get
            Set(ByVal value As List(Of backdrop))
                p_element_backdrops = value
            End Set
        End Property
    End Class
    Public Class Posters
        Private p_element_posters As New List(Of Poster)
        Private p_element_tmdbid As String
        Property tmdbid() As String
            Get
                Return p_element_tmdbid
            End Get
            Set(ByVal value As String)
                p_element_tmdbid = value
            End Set
        End Property
        Property posters() As List(Of Poster)
            Get
                Return (p_element_posters)
            End Get
            Set(ByVal value As List(Of Poster))
                p_element_posters = value
            End Set
        End Property
    End Class
End Namespace
