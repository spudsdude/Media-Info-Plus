Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace xbmc
    Public Class xbmcmultiepisode
        Private p_element_episodes As New List(Of xbmcEpisodedetails)
        <XmlElement("episodedetails")> _
        Property episodes() As List(Of xbmcEpisodedetails)
            Get
                Return p_element_episodes
            End Get
            Set(ByVal value As List(Of xbmcEpisodedetails))
                p_element_episodes = value
            End Set
        End Property
        Public Sub writeNfo(ByRef folderlocationandname As String)
            'Dim id As String = Me.Id
            Dim writefile As Boolean = True

            'If File.Exists(mainform.rconf.imdbcachefolder + id + ".xml") Then writefile = False
            'If overwrite Then
            'writefile = True
            'End If
            If writefile Then
                'System.Xml.Serialization.XmlSerialize
                Dim serializer As New XmlSerializer(Me.GetType())
                Try
                    Dim writer As New StreamWriter(folderlocationandname) ' + "\tvshow.nfo") 'mainform.rconf.imdbcachefolder + "\" + id + ".xml")
                    serializer.Serialize(writer, Me)
                    writer.Close()
                    'IMDBITEM.imdbtostring()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Debug.Print(ex.ToString)

                End Try
            End If
        End Sub
    End Class
    ' <summary>Represents an xml root episodedetails document element.</summary>
    <XmlRoot("episodedetails")> _
    Public Class [xbmcEpisodedetails]
        Private p_element_title As String
        Private p_element_season As String
        Private p_element_episode As String
        Private p_element_plot As String
        Private p_element_thumb As String
        Private p_element_watched As String
        Private p_element_credits As String
        Private p_element_director As String
        Private p_element_aired As String
        Private p_element_rating As String
        Private p_element_actor As New List(Of mip.mov.Actor)
        Private p_element_filename As String
        Private p_element_episodeid As String
        Private p_element_seriesid As String
        Private p_element_seasonid As String
        Private p_element_votes As String
        Private p_element_fileinfo As New xbmcMediaInfo.Fileinfo
        <XmlIgnore()> _
        Property seasonid() As String
            Get
                Return p_element_seasonid
            End Get
            Set(ByVal value As String)
                p_element_seasonid = value
            End Set
        End Property
        <XmlIgnore()> _
        Property seriesid() As String
            Get
                Return p_element_seriesid
            End Get
            Set(ByVal value As String)
                p_element_seriesid = value
            End Set
        End Property
        <XmlIgnore()> _
       Property episodeid() As String
            Get
                Return p_element_episodeid
            End Get
            Set(ByVal value As String)
                p_element_episodeid = value
            End Set
        End Property
        <XmlIgnore()> _
        Property filename() As String
            Get
                Return p_element_filename
            End Get
            Set(ByVal value As String)
                p_element_filename = value
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

        Public Sub readNfo(ByVal nfolocationandfilename As String, ByRef vxbmcTvEP As xbmcEpisodedetails)
            Dim xmlfile As String = nfolocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRxbmcTvEP As xbmcEpisodedetails = CType(serializer.Deserialize(gROReader), xbmcEpisodedetails)
            gROReader.Close()
            vxbmcTvEP = gRxbmcTvEP
        End Sub

        Public Sub writeNfo(ByRef folderlocationandname As String)
            'Dim id As String = Me.Id
            Dim writefile As Boolean = True

            'If File.Exists(mainform.rconf.imdbcachefolder + id + ".xml") Then writefile = False
            'If overwrite Then
            'writefile = True
            'End If


            If writefile Then
                'System.Xml.Serialization.XmlSerialize
                Dim serializer As New XmlSerializer(Me.GetType())
                Try
                    Dim writer As New StreamWriter(folderlocationandname) ' + "\tvshow.nfo") 'mainform.rconf.imdbcachefolder + "\" + id + ".xml")
                    serializer.Serialize(writer, Me)
                    writer.Close()
                    'IMDBITEM.imdbtostring()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Debug.Print(ex.ToString)

                End Try
            End If
        End Sub

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

        ' <summary>String season element.</summary>
        <XmlElement("season")> _
        Public Property [Season]() As String
            Get
                Return Me.p_element_season
            End Get
            Set(ByVal Value As String)
                Me.p_element_season = Value
            End Set
        End Property

        ' <summary>String episode element.</summary>
        <XmlElement("episode")> _
        Public Property [Episode]() As String
            Get
                Return Me.p_element_episode
            End Get
            Set(ByVal Value As String)
                Me.p_element_episode = Value
            End Set
        End Property
        ' <summary>String title element.</summary>
        <XmlElement("rating")> _
        Public Property [Rating]() As String
            Get
                Return Me.p_element_rating
            End Get
            Set(ByVal Value As String)
                Me.p_element_rating = Value
            End Set
        End Property

        ' <summary>String plot element.</summary>
        <XmlElement("plot")> _
        Public Property [Plot]() As String
            Get
                Return Me.p_element_plot
            End Get
            Set(ByVal Value As String)
                Me.p_element_plot = Value
            End Set
        End Property

        ' <summary>String thumb element.</summary>
        <XmlElement("thumb")> _
        Public Property [Thumb]() As String
            Get
                Return Me.p_element_thumb
            End Get
            Set(ByVal Value As String)
                Me.p_element_thumb = Value
            End Set
        End Property

        ' <summary>String watched element.</summary>
        <XmlElement("watched")> _
        Public Property [Watched]() As String
            Get
                Return Me.p_element_watched
            End Get
            Set(ByVal Value As String)
                Me.p_element_watched = Value
            End Set
        End Property

        ' <summary>String credits element.</summary>
        <XmlElement("credits")> _
        Public Property [Credits]() As String
            Get
                Return Me.p_element_credits
            End Get
            Set(ByVal Value As String)
                Me.p_element_credits = Value
            End Set
        End Property

        ' <summary>String director element.</summary>
        <XmlElement("director")> _
        Public Property [Director]() As String
            Get
                Return Me.p_element_director
            End Get
            Set(ByVal Value As String)
                Me.p_element_director = Value
            End Set
        End Property

        ' <summary>String aired element.</summary>
        <XmlElement("aired")> _
        Public Property [Aired]() As String
            Get
                Return Me.p_element_aired
            End Get
            Set(ByVal Value As String)
                Me.p_element_aired = Value
            End Set
        End Property

        ' <summary>Actor[] actor xml element.</summary>
        <XmlElement("actor")> _
        Public Property [Actors]() As List(Of mip.mov.Actor)
            Get
                Return Me.p_element_actor
            End Get
            Set(ByVal Value As List(Of mip.mov.Actor))
                Me.p_element_actor = Value
            End Set
        End Property

        <XmlElement("votes")> _
       Public Property [Votes]() As String
            Get
                Return Me.p_element_votes
            End Get
            Set(ByVal Value As String)
                Me.p_element_votes = Value
            End Set
        End Property
    End Class
End Namespace