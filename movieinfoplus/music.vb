'Public Class music
Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic
Public Class musicartist
    Private p_element_musicalbumsalbums As New List(Of musicalbums)
    Private p_element_stringartistname As String
    Private p_element_path As String
    Property path() As String
        Get
            Return p_element_path
        End Get
        Set(ByVal value As String)
            p_element_path = value
        End Set
    End Property
    Property artistname() As String
        Get
            Return p_element_stringartistname
        End Get
        Set(ByVal value As String)
            p_element_stringartistname = value
        End Set
    End Property
    Property albums() As List(Of musicalbums)
        Get
            Return p_element_musicalbumsalbums
        End Get
        Set(ByVal value As List(Of musicalbums))
            p_element_musicalbumsalbums = value
        End Set
    End Property
End Class

Public Class musicalbums
    Private p_element_music As New List(Of Music)
    Private p_element_albumname As String
    Private p_element_path As String
    Private p_element_downloadlist As New ArrayList
    Property pdownloadlist() As ArrayList
        Get
            Return p_element_downloadlist
        End Get
        Set(ByVal value As ArrayList)
            p_element_downloadlist = value
        End Set
    End Property
    Property path() As String
        Get
            Return p_element_path
        End Get
        Set(ByVal value As String)
            p_element_path = value
        End Set
    End Property
    Property albumname() As String
        Get
            Return p_element_albumname
        End Get
        Set(ByVal value As String)
            p_element_albumname = value
        End Set
    End Property
    Property music() As List(Of Music)
        Get
            Return p_element_music
        End Get
        Set(ByVal value As List(Of Music))
            p_element_music = value
        End Set
    End Property
End Class

' <summary>Represents an xml root music document element.</summary>
<XmlRoot("music")> _
Public Class [Music]
    Private p_element_title As System.String
    Private p_element_artist As System.String
    Private p_element_album As System.String
    Private p_element_year As System.String
    Private p_element_comment As System.String
    Private p_element_tracknum As System.String
    Private p_element_genres As List(Of System.String)
    Private p_element_genre As System.String
    Private p_element_filename As System.String
    Private p_element_location As System.String
    Private p_element_duration As System.String
    Private p_element_bitrate As System.String
    Private p_element_encoder As System.String
    Private p_element_filesize As System.String
    Private p_element_coverart As System.String
    Private p_element_md5 As String
    Public Sub writexml(ByRef folderlocationandname As String)
        Dim serializer As New XmlSerializer(Me.GetType())
        Try
            Dim writer As New StreamWriter(folderlocationandname)
            serializer.Serialize(writer, Me)
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Public Sub readxml(ByVal xmllocationandfilename As String, ByRef currsp As Music)
        Dim xmlfile As String = xmllocationandfilename
        Dim serializer As New XmlSerializer(Me.GetType())
        Dim gROReader As New StreamReader(xmlfile)
        Dim gRrsp As Music = CType(serializer.Deserialize(gROReader), Music)
        gROReader.Close()
        currsp = gRrsp
    End Sub
    ' <summary>String title element.</summary>
    <XmlElement("title")> _
  Public Property [Title]() As System.String
        Get
            Return Me.p_element_title
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_title = Value
        End Set
    End Property
    Public Property md5() As System.String
        Get
            Return Me.p_element_md5
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_md5 = Value
        End Set
    End Property
    Public Property genre() As String
        Get
            Return p_element_genre
        End Get
        Set(ByVal value As String)
            p_element_genre = value
        End Set
    End Property
    ' <summary>String artist element.</summary>
    <XmlElement("artist")> _
    Public Property [Artist]() As System.String
        Get
            Return Me.p_element_artist
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_artist = Value
        End Set
    End Property

    ' <summary>String album element.</summary>
    <XmlElement("album")> _
    Public Property [Album]() As System.String
        Get
            Return Me.p_element_album
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_album = Value
        End Set
    End Property

    ' <summary>String year element.</summary>
    <XmlElement("year")> _
    Public Property [Year]() As System.String
        Get
            Return Me.p_element_year
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_year = Value
        End Set
    End Property

    ' <summary>String comment element.</summary>
    <XmlElement("comment")> _
    Public Property [Comment]() As System.String
        Get
            Return Me.p_element_comment
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_comment = Value
        End Set
    End Property

    ' <summary>String tracknum element.</summary>
    <XmlElement("tracknum")> _
    Public Property [Tracknum]() As System.String
        Get
            Return Me.p_element_tracknum
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_tracknum = Value
        End Set
    End Property

    ' <summary>Genre[] genres xml array element.</summary>
    <XmlArrayItem("genre", GetType(System.String))> _
    <XmlArray("genres")> _
    Public Property [Genres]() As List(Of System.String)
        Get
            Return Me.p_element_genres
        End Get
        Set(ByVal Value As List(Of System.String))
            Me.p_element_genres = Value
        End Set
    End Property

    ' <summary>String filename element.</summary>
    <XmlElement("filename")> _
    Public Property [Filename]() As System.String
        Get
            Return Me.p_element_filename
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_filename = Value
        End Set
    End Property

    ' <summary>String location element.</summary>
    <XmlElement("location")> _
    Public Property [Location]() As System.String
        Get
            Return Me.p_element_location
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_location = Value
        End Set
    End Property

    ' <summary>String duration element.</summary>
    <XmlElement("duration")> _
    Public Property [Duration]() As System.String
        Get
            Return Me.p_element_duration
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_duration = Value
        End Set
    End Property

    ' <summary>String bitrate element.</summary>
    <XmlElement("bitrate")> _
    Public Property [Bitrate]() As System.String
        Get
            Return Me.p_element_bitrate
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_bitrate = Value
        End Set
    End Property

    ' <summary>String encoder element.</summary>
    <XmlElement("encoder")> _
    Public Property [Encoder]() As System.String
        Get
            Return Me.p_element_encoder
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_encoder = Value
        End Set
    End Property

    ' <summary>String filesize element.</summary>
    <XmlElement("filesize")> _
    Public Property [Filesize]() As System.String
        Get
            Return Me.p_element_filesize
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_filesize = Value
        End Set
    End Property

    ' <summary>String coverart element.</summary>
    <XmlElement("coverart")> _
    Public Property [Coverart]() As System.String
        Get
            Return Me.p_element_coverart
        End Get
        Set(ByVal Value As System.String)
            Me.p_element_coverart = Value
        End Set
    End Property
End Class

