Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic
Imports movieinfoplus.tvdbactor


Namespace tvdblang
    ' <summary>Represents an xml root Actors document element.</summary>
    <XmlRoot("Actors")> _
    Public Class [Actors]
        Private p_element_actor As New List(Of tvdbactor.tvdbActor)

        Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vActors As Actors)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRActors As Actors = CType(serializer.Deserialize(gROReader), Actors)
            gROReader.Close()
            vActors = gRActors
        End Sub
        ' <summary>Actor[] Actor xml element.</summary>
        <XmlElement("Actor")> _
        Public Property [Actors]() As List(Of tvdbactor.tvdbActor)
            Get
                Return Me.p_element_actor
            End Get
            Set(ByVal Value As List(Of tvdbactor.tvdbActor))
                Me.p_element_actor = Value
            End Set
        End Property
    End Class


    ' <summary>Represents a Data.Series node.</summary>
    Public Class [tvdblangSeries]
        Private p_element_id As String
        Private p_element_actors As String
        Private p_element_airsdayofweek As String
        Private p_element_airstime As String
        Private p_element_contentrating As String
        Private p_element_firstaired As String
        Private p_element_genre As String
        Private p_element_imdbid As String
        Private p_element_language As String
        Private p_element_network As String
        Private p_element_overview As String
        Private p_element_rating As String
        Private p_element_runtime As String
        Private p_element_seriesid As String
        Private p_element_seriesname As String
        Private p_element_status As String
        Private p_element_added As String
        Private p_element_addedby As String
        Private p_element_banner As String
        Private p_element_fanart As String
        Private p_element_lastupdated As String
        Private p_element_poster As String
        Private p_element_zap2itid As String
        Public Sub tvdblangseries2xbmcTvshow(ByRef tls As tvdblangSeries, ByRef xbmctvshow As xbmc.xbmcTvshow, ByRef theactors As tvdblang.Actors)
            Dim ccount As Integer = 0
            While ccount < theactors.Actors.Count
                Dim tactor As New mip.mov.Actor
                tactor.Name = theactors.Actors.Item(ccount).Name
                tactor.Role = theactors.Actors.Item(ccount).Role
                tactor.Thumb = "http://www.thetvdb.com/banners/" + theactors.Actors.Item(ccount).Image
                xbmctvshow.Actors.Add(tactor)
                ccount += 1
            End While
            xbmctvshow.Displayepisode = "-1"
            xbmctvshow.Displayseason = "-1"
            xbmctvshow.Episode = "0"
            xbmctvshow.Episodeguideurl = ""
            xbmctvshow.Genre = tls.Genre
            xbmctvshow.Id = tls.IMDBID
            xbmctvshow.Mpaa = tls.ContentRating
            xbmctvshow.Plot = tls.Overview
            xbmctvshow.Premiered = tls.FirstAired
            xbmctvshow.Rating = tls.Rating
            xbmctvshow.Season = "-1"
            xbmctvshow.Studio = tls.Network
            xbmctvshow.Thumb = ""
            xbmctvshow.Title = tls.SeriesName
            xbmctvshow.Tvdbid = tls.Id
            xbmctvshow.Watched = ""

        End Sub
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

        ' <summary>String Actors element.</summary>
        <XmlElement("Actors")> _
        Public Property [Actors]() As String
            Get
                Return Me.p_element_actors
            End Get
            Set(ByVal Value As String)
                Me.p_element_actors = Value
            End Set
        End Property

        ' <summary>String Airs_DayOfWeek element.</summary>
        <XmlElement("Airs_DayOfWeek")> _
        Public Property [AirsDayOfWeek]() As String
            Get
                Return Me.p_element_airsdayofweek
            End Get
            Set(ByVal Value As String)
                Me.p_element_airsdayofweek = Value
            End Set
        End Property

        ' <summary>String Airs_Time element.</summary>
        <XmlElement("Airs_Time")> _
        Public Property [AirsTime]() As String
            Get
                Return Me.p_element_airstime
            End Get
            Set(ByVal Value As String)
                Me.p_element_airstime = Value
            End Set
        End Property

        ' <summary>String ContentRating element.</summary>
        <XmlElement("ContentRating")> _
        Public Property [ContentRating]() As String
            Get
                Return Me.p_element_contentrating
            End Get
            Set(ByVal Value As String)
                Me.p_element_contentrating = Value
            End Set
        End Property

        ' <summary>String FirstAired element.</summary>
        <XmlElement("FirstAired")> _
        Public Property [FirstAired]() As String
            Get
                Return Me.p_element_firstaired
            End Get
            Set(ByVal Value As String)
                Me.p_element_firstaired = Value
            End Set
        End Property

        ' <summary>String Genre element.</summary>
        <XmlElement("Genre")> _
        Public Property [Genre]() As String
            Get
                Return Me.p_element_genre
            End Get
            Set(ByVal Value As String)
                Me.p_element_genre = Value
            End Set
        End Property

        ' <summary>String IMDB_ID element.</summary>
        <XmlElement("IMDB_ID")> _
        Public Property [IMDBID]() As String
            Get
                Return Me.p_element_imdbid
            End Get
            Set(ByVal Value As String)
                Me.p_element_imdbid = Value
            End Set
        End Property

        ' <summary>String Language element.</summary>
        <XmlElement("Language")> _
        Public Property [Language]() As String
            Get
                Return Me.p_element_language
            End Get
            Set(ByVal Value As String)
                Me.p_element_language = Value
            End Set
        End Property

        ' <summary>String Network element.</summary>
        <XmlElement("Network")> _
        Public Property [Network]() As String
            Get
                Return Me.p_element_network
            End Get
            Set(ByVal Value As String)
                Me.p_element_network = Value
            End Set
        End Property

        ' <summary>String Overview element.</summary>
        <XmlElement("Overview")> _
        Public Property [Overview]() As String
            Get
                Return Me.p_element_overview
            End Get
            Set(ByVal Value As String)
                Me.p_element_overview = Value
            End Set
        End Property

        ' <summary>String Rating element.</summary>
        <XmlElement("Rating")> _
        Public Property [Rating]() As String
            Get
                Return Me.p_element_rating
            End Get
            Set(ByVal Value As String)
                Me.p_element_rating = Value
            End Set
        End Property

        ' <summary>String Runtime element.</summary>
        <XmlElement("Runtime")> _
        Public Property [Runtime]() As String
            Get
                Return Me.p_element_runtime
            End Get
            Set(ByVal Value As String)
                Me.p_element_runtime = Value
            End Set
        End Property

        ' <summary>String SeriesID element.</summary>
        <XmlElement("SeriesID")> _
        Public Property [SeriesID]() As String
            Get
                Return Me.p_element_seriesid
            End Get
            Set(ByVal Value As String)
                Me.p_element_seriesid = Value
            End Set
        End Property

        ' <summary>String SeriesName element.</summary>
        <XmlElement("SeriesName")> _
        Public Property [SeriesName]() As String
            Get
                Return Me.p_element_seriesname
            End Get
            Set(ByVal Value As String)
                Me.p_element_seriesname = Value
            End Set
        End Property

        ' <summary>String Status element.</summary>
        <XmlElement("Status")> _
        Public Property [Status]() As String
            Get
                Return Me.p_element_status
            End Get
            Set(ByVal Value As String)
                Me.p_element_status = Value
            End Set
        End Property

        ' <summary>String added element.</summary>
        <XmlElement("added")> _
        Public Property [Added]() As String
            Get
                Return Me.p_element_added
            End Get
            Set(ByVal Value As String)
                Me.p_element_added = Value
            End Set
        End Property

        ' <summary>String addedBy element.</summary>
        <XmlElement("addedBy")> _
        Public Property [AddedBy]() As String
            Get
                Return Me.p_element_addedby
            End Get
            Set(ByVal Value As String)
                Me.p_element_addedby = Value
            End Set
        End Property

        ' <summary>String banner element.</summary>
        <XmlElement("banner")> _
        Public Property [Banner]() As String
            Get
                Return Me.p_element_banner
            End Get
            Set(ByVal Value As String)
                Me.p_element_banner = Value
            End Set
        End Property

        ' <summary>String fanart element.</summary>
        <XmlElement("fanart")> _
        Public Property [Fanart]() As String
            Get
                Return Me.p_element_fanart
            End Get
            Set(ByVal Value As String)
                Me.p_element_fanart = Value
            End Set
        End Property

        ' <summary>String lastupdated element.</summary>
        <XmlElement("lastupdated")> _
        Public Property [Lastupdated]() As String
            Get
                Return Me.p_element_lastupdated
            End Get
            Set(ByVal Value As String)
                Me.p_element_lastupdated = Value
            End Set
        End Property

        ' <summary>String poster element.</summary>
        <XmlElement("poster")> _
        Public Property [Poster]() As String
            Get
                Return Me.p_element_poster
            End Get
            Set(ByVal Value As String)
                Me.p_element_poster = Value
            End Set
        End Property

        ' <summary>String zap2it_id element.</summary>
        <XmlElement("zap2it_id")> _
        Public Property [Zap2itId]() As String
            Get
                Return Me.p_element_zap2itid
            End Get
            Set(ByVal Value As String)
                Me.p_element_zap2itid = Value
            End Set
        End Property
    End Class
End Namespace