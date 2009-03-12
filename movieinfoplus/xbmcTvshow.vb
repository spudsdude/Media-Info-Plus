Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic
Imports movieinfoplus.mip.mov



Namespace xbmc
    ' <summary>Represents an xml root tvshow document element.</summary>
    <XmlRoot("tvshow")> _
    Public Class [xbmcTvshow]
        Private p_element_title As String
        Private p_element_rating As String
        Private p_element_season As String
        Private p_element_episode As String
        Private p_element_displayseason As String
        Private p_element_displayepisode As String
        Private p_element_episodeguideurl As String
        Private p_element_plot As String
        Private p_element_thumb As String
        Private p_element_mpaa As String
        Private p_element_watched As String
        Private p_element_id As String
        Private p_element_tvdbid As String
        Private p_element_genre As String
        Private p_element_premiered As String
        Private p_element_studio As String
        Private p_element_actor As New List(Of Actor)

        Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vxbmcTvshow As xbmcTvshow)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRxbmcTvshow As xbmcTvshow = CType(serializer.Deserialize(gROReader), xbmcTvshow)
            gROReader.Close()
            vxbmcTvshow = gRxbmcTvshow
        End Sub

        Public Sub writeXML(ByRef folderlocation As String)
            Dim id As String = Me.Id
            Dim writefile As Boolean = True

            'If File.Exists(mainform.rconf.imdbcachefolder + id + ".xml") Then writefile = False
            'If overwrite Then
            'writefile = True
            'End If

            If writefile Then
                'System.Xml.Serialization.XmlSerialize
                Dim serializer As New XmlSerializer(Me.GetType())
                Try
                    Dim writer As New StreamWriter(folderlocation + "\tvshow.nfo") 'mainform.rconf.imdbcachefolder + "\" + id + ".xml")
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

        ' <summary>String displayseason element.</summary>
        <XmlElement("displayseason")> _
        Public Property [Displayseason]() As String
            Get
                Return Me.p_element_displayseason
            End Get
            Set(ByVal Value As String)
                Me.p_element_displayseason = Value
            End Set
        End Property

        ' <summary>String displayepisode element.</summary>
        <XmlElement("displayepisode")> _
        Public Property [Displayepisode]() As String
            Get
                Return Me.p_element_displayepisode
            End Get
            Set(ByVal Value As String)
                Me.p_element_displayepisode = Value
            End Set
        End Property

        ' <summary>String episodeguideurl element.</summary>
        <XmlElement("episodeguideurl")> _
        Public Property [Episodeguideurl]() As String
            Get
                Return Me.p_element_episodeguideurl
            End Get
            Set(ByVal Value As String)
                Me.p_element_episodeguideurl = Value
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

        ' <summary>String mpaa element.</summary>
        <XmlElement("mpaa")> _
        Public Property [Mpaa]() As String
            Get
                Return Me.p_element_mpaa
            End Get
            Set(ByVal Value As String)
                Me.p_element_mpaa = Value
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

        ' <summary>String tvdbid element.</summary>
        <XmlElement("tvdbid")> _
        Public Property [Tvdbid]() As String
            Get
                Return Me.p_element_tvdbid
            End Get
            Set(ByVal Value As String)
                Me.p_element_tvdbid = Value
            End Set
        End Property

        ' <summary>String genre element.</summary>
        <XmlElement("genre")> _
        Public Property [Genre]() As String
            Get
                Return Me.p_element_genre
            End Get
            Set(ByVal Value As String)
                Me.p_element_genre = Value
            End Set
        End Property

        ' <summary>String premiered element.</summary>
        <XmlElement("premiered")> _
        Public Property [Premiered]() As String
            Get
                Return Me.p_element_premiered
            End Get
            Set(ByVal Value As String)
                Me.p_element_premiered = Value
            End Set
        End Property

        ' <summary>String studio element.</summary>
        <XmlElement("studio")> _
        Public Property [Studio]() As String
            Get
                Return Me.p_element_studio
            End Get
            Set(ByVal Value As String)
                Me.p_element_studio = Value
            End Set
        End Property

        ' <summary>Actor[] actor xml element.</summary>
        <XmlElement("actor")> _
        Public Property [Actors]() As List(Of Actor)
            Get
                Return Me.p_element_actor
            End Get
            Set(ByVal Value As List(Of Actor))
                Me.p_element_actor = Value
            End Set
        End Property
    End Class
End Namespace