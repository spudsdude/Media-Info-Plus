Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace mip.mov
    ' Represents an xml root movie document element compatable with xbmc.
    <XmlRoot("movie")> _
    Public Class [Mov]
        Private p_element_title As System.String
        Private p_element_rating As System.String
        Private p_element_year As System.String
        Private p_element_top250 As System.String
        Private p_element_votes As System.String
        Private p_element_outline As System.String
        Private p_element_plot As System.String
        Private p_element_tagline As System.String
        Private p_element_runtime As System.String
        Private p_element_thumb As System.String
        Private p_element_fanart As New Fanart
        Private p_element_mpaa As System.String
        Private p_element_playcount As System.String
        Private p_element_file As System.String
        Private p_element_path As System.String
        Private p_element_filenameandpath As System.String
        Private p_element_id As System.String
        Private p_element_genre As System.String
        Private p_element_credits As System.String
        Private p_element_director As System.String
        Private p_element_premiered As System.String
        Private p_element_status As System.String
        Private p_element_studio As System.String
        Private p_element_studioreal As System.String
        Private p_element_album As System.String
        Private p_element_trailer As System.String
        Private p_element_watched As System.String
        Private p_element_actor As New List(Of Actor)
        Private p_element_fileinfo As New xbmcMediaInfo.Fileinfo
        Private p_element_certification As String

        'Fileinfo element
        <XmlElement("fileinfo")> _
        Public Property [fileinfo]() As xbmcMediaInfo.Fileinfo
            Get
                Return p_element_fileinfo
            End Get
            Set(ByVal value As xbmcMediaInfo.Fileinfo)
                p_element_fileinfo = value
            End Set
        End Property
        ' String title element.
        <XmlElement("title")> _
        Public Property [Title]() As System.String
            Get
                Return Me.p_element_title
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_title = Value
            End Set
        End Property

        ' String rating element.
        <XmlElement("rating")> _
        Public Property [Rating]() As System.String
            Get
                Return Me.p_element_rating
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_rating = Value
            End Set
        End Property

        ' String year element.
        <XmlElement("year")> _
        Public Property [Year]() As System.String
            Get
                Return Me.p_element_year
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_year = Value
            End Set
        End Property

        ' String top element.
        <XmlElement("top250")> _
        Public Property [Top250]() As System.String
            Get
                Return Me.p_element_top250
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_top250 = Value
            End Set
        End Property

        ' String votes element.
        <XmlElement("votes")> _
        Public Property [Votes]() As System.String
            Get
                Return Me.p_element_votes
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_votes = Value
            End Set
        End Property

        ' String outline element.
        <XmlElement("outline")> _
        Public Property [Outline]() As System.String
            Get
                Return Me.p_element_outline
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_outline = Value
            End Set
        End Property

        ' String plot element.
        <XmlElement("plot")> _
        Public Property [Plot]() As System.String
            Get
                Return Me.p_element_plot
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_plot = Value
            End Set
        End Property

        ' String tagline element.
        <XmlElement("tagline")> _
        Public Property [Tagline]() As System.String
            Get
                Return Me.p_element_tagline
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_tagline = Value
            End Set
        End Property

        ' String runtime element.
        <XmlElement("runtime")> _
        Public Property [Runtime]() As System.String
            Get
                Return Me.p_element_runtime
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_runtime = Value
            End Set
        End Property

        ' String thumb element.
        <XmlElement("thumb")> _
        Public Property [Thumb]() As System.String
            Get
                Return Me.p_element_thumb
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_thumb = Value
            End Set
        End Property

        ' fanart xml element.
        <XmlElement("fanart")> _
        Public Property [Fanart]() As Fanart
            Get
                Return Me.p_element_fanart
            End Get
            Set(ByVal Value As Fanart)
                Me.p_element_fanart = Value
            End Set
        End Property

        ' String mpaa element.
        <XmlElement("mpaa")> _
        Public Property [Mpaa]() As System.String
            Get
                Return Me.p_element_mpaa
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_mpaa = Value
            End Set
        End Property

        ' String mpaa element.
        <XmlElement("certification")> _
        Public Property [Certification]() As System.String
            Get
                Return Me.p_element_certification
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_certification = Value
            End Set
        End Property

        ' String playcount element.
        <XmlElement("playcount")> _
        Public Property [Playcount]() As System.String
            Get
                Return Me.p_element_playcount
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_playcount = Value
            End Set
        End Property

        ' String File element.
        <XmlElement("File")> _
        Public Property [File]() As System.String
            Get
                Return Me.p_element_file
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_file = Value
            End Set
        End Property

        ' String Path element.
        <XmlElement("Path")> _
        Public Property [Path]() As System.String
            Get
                Return Me.p_element_path
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_path = Value
            End Set
        End Property

        ' String filenameandpath element.
        <XmlElement("filenameandpath")> _
        Public Property [Filenameandpath]() As System.String
            Get
                Return Me.p_element_filenameandpath
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_filenameandpath = Value
            End Set
        End Property

        ' String id element.
        <XmlElement("id")> _
        Public Property [Id]() As System.String
            Get
                Return Me.p_element_id
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_id = Value
            End Set
        End Property

        ' String genre element.
        <XmlElement("genre")> _
        Public Property [Genre]() As System.String
            Get
                Return Me.p_element_genre
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_genre = Value
            End Set
        End Property

        ' String credits element.
        <XmlElement("credits")> _
        Public Property [Credits]() As System.String
            Get
                Return Me.p_element_credits
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_credits = Value
            End Set
        End Property

        ' String director element.
        <XmlElement("director")> _
        Public Property [Director]() As System.String
            Get
                Return Me.p_element_director
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_director = Value
            End Set
        End Property

        ' String premiered element.
        <XmlElement("premiered")> _
        Public Property [Premiered]() As System.String
            Get
                Return Me.p_element_premiered
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_premiered = Value
            End Set
        End Property

        ' String status element.
        <XmlElement("status")> _
        Public Property [Status]() As System.String
            Get
                Return Me.p_element_status
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_status = Value
            End Set
        End Property

        ' String studio element.
        <XmlElement("studio")> _
        Public Property [Studio]() As System.String
            Get
                Return Me.p_element_studio
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_studio = Value
            End Set
        End Property
        ' String studio element.
        <XmlElement("studioreal")> _
        Public Property [Studioreal]() As System.String
            Get
                Return Me.p_element_studioreal
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_studioreal = Value
            End Set
        End Property
        ' String album element.
        <XmlElement("album")> _
        Public Property [Album]() As System.String
            Get
                Return Me.p_element_album
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_album = Value
            End Set
        End Property

        ' String trailer element.
        <XmlElement("trailer")> _
        Public Property [Trailer]() As System.String
            Get
                Return Me.p_element_trailer
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_trailer = Value
            End Set
        End Property

        ' String watched element.
        <XmlElement("watched")> _
        Public Property [Watched]() As System.String
            Get
                Return Me.p_element_watched
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_watched = Value
            End Set
        End Property

        ' Actor[] actor xml element.
        <XmlElement("actor")> _
        Public Property [Actors]() As List(Of Actor)
            Get
                Return Me.p_element_actor
            End Get
            Set(ByVal Value As List(Of Actor))
                Me.p_element_actor = Value
            End Set
        End Property

        Public Sub writeMovXML(ByVal folder As String, ByVal filename As String)
            Dim id As String = Me.Id
            Dim ms As New movieinfoplus.mip.movieserial.MovieSerializer
            ' ms.Serialize(Me)
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim writer As New StreamWriter(folder + filename)
            serializer.Serialize(writer, Me)
            writer.Close()
        End Sub
        Public Sub readMovXML(ByVal folder As String)
            Dim id As String = Me.Id
            Dim ms As New movieinfoplus.mip.movieserial.MovieSerializer
            ' ms.Serialize(Me)
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim writer As New StreamWriter(folder) ' + Convert.ToString(id) + ".xml")
            serializer.Serialize(writer, Me) 'ms.Serialize(Me))
            writer.Close()
        End Sub
        Public Function getmov(ByVal stringpathandnameofnfofile As String) As Mov
            Dim xmlfile As String = stringpathandnameofnfofile
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(stringpathandnameofnfofile)
            Dim gRMov As Mov = CType(serializer.Deserialize(gROReader), Mov)
            gROReader.Close()
            Return gRMov
        End Function
        Public Sub movtomovie(ByRef tmov As Mov, ByRef tmovie As movie)
            tmovie.pgenre = tmov.Genre
            tmovie.peditedmoviename = tmov.Title
            tmovie.prating = tmov.Rating
            tmovie.pyear = CInt(tmov.Year)
            tmovie.ptop250 = tmov.Top250
            tmovie.pvotes = tmov.Votes
            tmovie.pplotoutline = tmov.Outline
            tmovie.pplot = tmov.Plot
            tmovie.ptagline = tmov.Tagline
            tmovie.pruntime = tmov.Runtime
            'tmovie.pgenre = tmov.Thumb
            'tmovie. = tmov.fanart As New Fanart
            tmovie.pmpaa = tmov.Mpaa
            'tmovie.ppenre = tmov.Playcount
            'tmovie.pgenre = tmov.File
            'tmovie.pgenre = tmov.Path
            'tmovie.pgenre = tmov.Filenameandpath
            tmovie.pimdbnumber = tmov.Id
            tmovie.pgenre = tmov.Genre
            tmovie.pcredits = tmov.Credits
            tmovie.pdirector = tmov.Director
            'tmovie.pre = tmov.Premiered
            'tmovie.ps = tmov.Status
            tmovie.pstudio = tmov.Studio
            'tmovie.pgenre = tmov.Album
            tmovie.ptrailer = tmov.Trailer
            'tmovie.pwre = tmov.Watched
            ' tmovie.actor = New Actors

            tmovie.fileinfo = tmov.fileinfo

            For Each dude In tmov.Actors
                Dim tactor As New Actor
                tactor.Name = dude.Name
                tactor.Role = dude.Role
                tactor.Thumb = dude.Thumb
                tmovie.Actors.Add(tactor)
            Next
            'tmovie.pactor = tmov.Actors 'As New List(Of Actor)
        End Sub
        Public Function getmov2movie(ByVal stringpathandnameofnfofile As String, ByRef tmovie As movie) As Mov
            Dim xmlfile As String = stringpathandnameofnfofile
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(stringpathandnameofnfofile)
            Dim gRMov As Mov = CType(serializer.Deserialize(gROReader), Mov)
            gROReader.Close()
            'convert mov to movie -- return boolean
            Return gRMov
        End Function
        Public Sub printToString()
            Debug.Print(Me.Id)
            Debug.Print(Me.Mpaa)
            Debug.Print(Me.Year.ToString)
            Debug.Print(Me.Votes.ToString)
        End Sub
    End Class

    ' Represents a movie.fanart node.
    Public Class [Fanart]
        Private p_attribute_url As System.String
        Private p_element_thumb As New List(Of Thumb)

        ' System.String url attribute.
        <XmlAttribute("url")> _
        Public Property [Url]() As System.String
            Get
                Return Me.p_attribute_url
            End Get
            Set(ByVal Value As System.String)
                Me.p_attribute_url = Value
            End Set
        End Property

        ' Thumb[] thumb xml element.
        <XmlElement("thumb")> _
        Public Property [Thumbs]() As List(Of Thumb)
            Get
                Return Me.p_element_thumb
            End Get
            Set(ByVal Value As List(Of Thumb))
                Me.p_element_thumb = Value
            End Set
        End Property
    End Class

    ' Represents a fanart.thumb node.
    Public Class [Thumb]
        Private p_attribute_preview As System.String
        Private p_element_text As System.String

        ' System.String preview attribute.
        <XmlAttribute("preview")> _
        Public Property [Preview]() As System.String
            Get
                Return Me.p_attribute_preview
            End Get
            Set(ByVal Value As System.String)
                Me.p_attribute_preview = Value
            End Set
        End Property

        ' String text element.
        <XmlText()> _
        Public Property [Text]() As System.String
            Get
                Return Me.p_element_text
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_text = Value
            End Set
        End Property


    End Class

    ' Represents a movie.actor node.
    Public Class [Actor]
        Private p_element_name As System.String
        Private p_element_role As System.String
        Private p_element_thumb As System.String

        ' String name element.
        <XmlElement("name")> _
        Public Property [Name]() As System.String
            Get
                Return Me.p_element_name
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_name = Value
            End Set
        End Property

        ' String role element.
        <XmlElement("role")> _
        Public Property [Role]() As System.String
            Get
                Return Me.p_element_role
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_role = Value
            End Set
        End Property

        ' String thumb element.
        <XmlElement("thumb")> _
        Public Property [Thumb]() As System.String
            Get
                Return Me.p_element_thumb
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_thumb = Value
            End Set
        End Property
    End Class
End Namespace

   