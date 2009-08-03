Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace tvdblang
    ' <summary>Represents a Data.Episode node.</summary>
    <XmlRoot("Episode")> _
    Public Class [tvdblangEpisode]
        Private p_element_id As String
        Private p_element_combinedepisodenumber As String
        Private p_element_combinedseason As String
        Private p_element_dvdchapter As String
        Private p_element_dvddiscid As String
        Private p_element_dvdepisodenumber As String
        Private p_element_dvdseason As String
        Private p_element_director As String
        Private p_element_epimgflag As String
        Private p_element_episodename As String
        Private p_element_episodenumber As String
        Private p_element_firstaired As String
        Private p_element_gueststars As String
        Private p_element_imdbid As String
        Private p_element_language As String
        Private p_element_overview As String
        Private p_element_productioncode As String
        Private p_element_rating As String
        Private p_element_seasonnumber As String
        Private p_element_writer As String
        Private p_element_absolutenumber As String
        Private p_element_airsafterseason As String
        Private p_element_airsbeforeepisode As String
        Private p_element_airsbeforeseason As String
        Private p_element_filename As String
        Private p_element_lastupdated As String
        Private p_element_seasonid As String
        Private p_element_seriesid As String
        Private p_element_episodefilepath As String
        Private p_element_internal_thumb As String
        Private p_element_internal_actors As List(Of movieinfoplus.mip.mov.Actor)
        Private p_element_fileinfo As New xbmcMediaInfo.Fileinfo
        Private p_element_mutlipart As Boolean
        Private p_element_fullfilenameandpath As String
        Private p_element_miptvdbkey As String

        <XmlIgnore()> _
      Property miptvdbkey() As String
            Get
                Return p_element_miptvdbkey
            End Get
            Set(ByVal value As String)
                p_element_miptvdbkey = value
            End Set
        End Property
        <XmlIgnore()> _
      Property mutlipart() As Boolean
            Get
                Return p_element_mutlipart
            End Get
            Set(ByVal value As Boolean)
                p_element_mutlipart = value
            End Set
        End Property
        <XmlIgnore()> _
Property fullfilenameandpath() As String
            Get
                Return p_element_fullfilenameandpath
            End Get
            Set(ByVal value As String)
                p_element_fullfilenameandpath = value
            End Set
        End Property
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
        <XmlIgnore()> _
       Property p_internal_thumb() As String
            Get
                Return p_element_internal_thumb
            End Get
            Set(ByVal value As String)
                p_element_internal_thumb = value
            End Set
        End Property
        <XmlIgnore()> _
        Property p_internal_actors() As List(Of movieinfoplus.mip.mov.Actor)
            Get
                Return p_element_internal_actors
            End Get
            Set(ByVal value As List(Of movieinfoplus.mip.mov.Actor))
                p_element_internal_actors = value
            End Set
        End Property

        <XmlIgnore()> _
        Property episodefilepath() As String
            Get
                Return p_element_episodefilepath
            End Get
            Set(ByVal value As String)
                p_element_episodefilepath = value
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
        Public Sub readXML(ByVal xmllocationandfilename As String, ByRef curtvdblangEpisode As tvdblangEpisode)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRvtvdblangData As tvdblangEpisode = CType(serializer.Deserialize(gROReader), tvdblangEpisode)
            gROReader.Close()
            curtvdblangEpisode = gRvtvdblangData
        End Sub

        Public Sub tvdblangepisode2xbmcTvepisode(ByRef tls As tvdblangEpisode, ByRef xbmctvepisode As xbmc.xbmcEpisodedetails, ByRef theactors As List(Of movieinfoplus.mip.mov.Actor), ByRef currentmirror As String, ByVal curstudio As String, ByVal curmpaa As String)
            'Dim ccount As Integer = 0
            'While ccount < theactors.Actors.Count
            '    Dim tactor As New mip.mov.Actor
            '    tactor.Name = theactors.Actors.Item(ccount).Name
            '    tactor.Role = theactors.Actors.Item(ccount).Role
            '    tactor.Thumb = "http://www.thetvdb.com/banners/" + theactors.Actors.Item(ccount).Image
            '    xbmctvepisode.Actors.Add(tactor)
            '    ccount += 1
            'End While
            tls.p_internal_actors = theactors
            tls.p_internal_thumb = currentmirror + "/banners/" + tls.Filename
            xbmctvepisode.Actors = theactors
            xbmctvepisode.Aired = tls.FirstAired
            xbmctvepisode.Credits = Strings.Replace(tls.Writer, "|", "/")
            xbmctvepisode.Director = tls.Director
            'If maincollection.rconf.pcbGeneralSupportSkinBasedFlagging Then
            If Not curstudio = "" Then curstudio = "net" & curstudio
            xbmctvepisode.Director = tls.Director '& " / " & curstudio & " / " & curmpaa & " / " & tls.fileinfo.toTagData(tls.fileinfo)
            'End If
            xbmctvepisode.Episode = tls.EpisodeNumber
            xbmctvepisode.Plot = tls.Overview
            xbmctvepisode.Season = tls.SeasonNumber
            xbmctvepisode.Thumb = currentmirror + "/banners/" + tls.Filename
            xbmctvepisode.Title = tls.EpisodeName
            xbmctvepisode.Rating = tls.Rating
            xbmctvepisode.Watched = ""
            xbmctvepisode.fileinfo = tls.fileinfo
            xbmctvepisode.episodeid = tls.Id
            xbmctvepisode.seriesid = tls.Seriesid
            xbmctvepisode.seasonid = tls.Seasonid
            xbmctvepisode.Votes = "" '.Replace(curstudio, " ", "_") & " - " & tls.fileinfo.toTagData(tls.fileinfo)
        End Sub

        Public Sub tvdblangepisode2xbmcTvepisodeManualFromGUI(ByRef tls As tvdblangEpisode, ByRef xbmctvepisode As xbmc.xbmcEpisodedetails)
            'Dim ccount As Integer = 0
            'While ccount < theactors.Actors.Count
            '    Dim tactor As New mip.mov.Actor
            '    tactor.Name = theactors.Actors.Item(ccount).Name
            '    tactor.Role = theactors.Actors.Item(ccount).Role
            '    tactor.Thumb = "http://www.thetvdb.com/banners/" + theactors.Actors.Item(ccount).Image
            '    xbmctvepisode.Actors.Add(tactor)
            '    ccount += 1
            'End While
            xbmctvepisode.Actors = tls.p_internal_actors
            xbmctvepisode.Aired = tls.FirstAired
            xbmctvepisode.Credits = Strings.Replace(tls.Writer, "|", "/")
            xbmctvepisode.Director = tls.Director
            xbmctvepisode.Episode = tls.EpisodeNumber
            xbmctvepisode.Plot = tls.Overview
            xbmctvepisode.Season = tls.SeasonNumber
            xbmctvepisode.Thumb = p_internal_thumb
            xbmctvepisode.Title = tls.EpisodeName
            xbmctvepisode.Watched = ""
            xbmctvepisode.fileinfo = tls.fileinfo
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

        ' <summary>String Combined_episodenumber element.</summary>
        <XmlElement("Combined_episodenumber")> _
        Public Property [CombinedEpisodenumber]() As String
            Get
                Return Me.p_element_combinedepisodenumber
            End Get
            Set(ByVal Value As String)
                Me.p_element_combinedepisodenumber = Value
            End Set
        End Property

        ' <summary>String Combined_season element.</summary>
        <XmlElement("Combined_season")> _
        Public Property [CombinedSeason]() As String
            Get
                Return Me.p_element_combinedseason
            End Get
            Set(ByVal Value As String)
                Me.p_element_combinedseason = Value
            End Set
        End Property

        ' <summary>String DVD_chapter element.</summary>
        <XmlElement("DVD_chapter")> _
        Public Property [DVDChapter]() As String
            Get
                Return Me.p_element_dvdchapter
            End Get
            Set(ByVal Value As String)
                Me.p_element_dvdchapter = Value
            End Set
        End Property

        ' <summary>String DVD_discid element.</summary>
        <XmlElement("DVD_discid")> _
        Public Property [DVDDiscid]() As String
            Get
                Return Me.p_element_dvddiscid
            End Get
            Set(ByVal Value As String)
                Me.p_element_dvddiscid = Value
            End Set
        End Property

        ' <summary>String DVD_episodenumber element.</summary>
        <XmlElement("DVD_episodenumber")> _
        Public Property [DVDEpisodenumber]() As String
            Get
                Return Me.p_element_dvdepisodenumber
            End Get
            Set(ByVal Value As String)
                Me.p_element_dvdepisodenumber = Value
            End Set
        End Property

        ' <summary>String DVD_season element.</summary>
        <XmlElement("DVD_season")> _
        Public Property [DVDSeason]() As String
            Get
                Return Me.p_element_dvdseason
            End Get
            Set(ByVal Value As String)
                Me.p_element_dvdseason = Value
            End Set
        End Property

        ' <summary>String Director element.</summary>
        <XmlElement("Director")> _
        Public Property [Director]() As String
            Get
                Return Me.p_element_director
            End Get
            Set(ByVal Value As String)
                Me.p_element_director = Value
            End Set
        End Property

        ' <summary>String EpImgFlag element.</summary>
        <XmlElement("EpImgFlag")> _
        Public Property [EpImgFlag]() As String
            Get
                Return Me.p_element_epimgflag
            End Get
            Set(ByVal Value As String)
                Me.p_element_epimgflag = Value
            End Set
        End Property

        ' <summary>String EpisodeName element.</summary>
        <XmlElement("EpisodeName")> _
        Public Property [EpisodeName]() As String
            Get
                Return Me.p_element_episodename
            End Get
            Set(ByVal Value As String)
                Me.p_element_episodename = Value
            End Set
        End Property

        ' <summary>String EpisodeNumber element.</summary>
        <XmlElement("EpisodeNumber")> _
        Public Property [EpisodeNumber]() As String
            Get
                Return Me.p_element_episodenumber
            End Get
            Set(ByVal Value As String)
                Me.p_element_episodenumber = Value
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

        ' <summary>String GuestStars element.</summary>
        <XmlElement("GuestStars")> _
        Public Property [GuestStars]() As String
            Get
                Return Me.p_element_gueststars
            End Get
            Set(ByVal Value As String)
                Me.p_element_gueststars = Value
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

        ' <summary>String ProductionCode element.</summary>
        <XmlElement("ProductionCode")> _
        Public Property [ProductionCode]() As String
            Get
                Return Me.p_element_productioncode
            End Get
            Set(ByVal Value As String)
                Me.p_element_productioncode = Value
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

        ' <summary>String SeasonNumber element.</summary>
        <XmlElement("SeasonNumber")> _
        Public Property [SeasonNumber]() As String
            Get
                Return Me.p_element_seasonnumber
            End Get
            Set(ByVal Value As String)
                Me.p_element_seasonnumber = Value
            End Set
        End Property

        ' <summary>String Writer element.</summary>
        <XmlElement("Writer")> _
        Public Property [Writer]() As String
            Get
                Return Me.p_element_writer
            End Get
            Set(ByVal Value As String)
                Me.p_element_writer = Value
            End Set
        End Property

        ' <summary>String absolute_number element.</summary>
        <XmlElement("absolute_number")> _
        Public Property [AbsoluteNumber]() As String
            Get
                Return Me.p_element_absolutenumber
            End Get
            Set(ByVal Value As String)
                Me.p_element_absolutenumber = Value
            End Set
        End Property

        ' <summary>String airsafter_season element.</summary>
        <XmlElement("airsafter_season")> _
        Public Property [AirsafterSeason]() As String
            Get
                Return Me.p_element_airsafterseason
            End Get
            Set(ByVal Value As String)
                Me.p_element_airsafterseason = Value
            End Set
        End Property

        ' <summary>String airsbefore_episode element.</summary>
        <XmlElement("airsbefore_episode")> _
        Public Property [AirsbeforeEpisode]() As String
            Get
                Return Me.p_element_airsbeforeepisode
            End Get
            Set(ByVal Value As String)
                Me.p_element_airsbeforeepisode = Value
            End Set
        End Property

        ' <summary>String airsbefore_season element.</summary>
        <XmlElement("airsbefore_season")> _
        Public Property [AirsbeforeSeason]() As String
            Get
                Return Me.p_element_airsbeforeseason
            End Get
            Set(ByVal Value As String)
                Me.p_element_airsbeforeseason = Value
            End Set
        End Property

        ' <summary>String filename element.</summary>
        <XmlElement("filename")> _
        Public Property [Filename]() As String
            Get
                Return Me.p_element_filename
            End Get
            Set(ByVal Value As String)
                Me.p_element_filename = Value
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

        ' <summary>String seasonid element.</summary>
        <XmlElement("seasonid")> _
        Public Property [Seasonid]() As String
            Get
                Return Me.p_element_seasonid
            End Get
            Set(ByVal Value As String)
                Me.p_element_seasonid = Value
            End Set
        End Property

        ' <summary>String seriesid element.</summary>
        <XmlElement("seriesid")> _
        Public Property [Seriesid]() As String
            Get
                Return Me.p_element_seriesid
            End Get
            Set(ByVal Value As String)
                Me.p_element_seriesid = Value
            End Set
        End Property
    End Class
End Namespace