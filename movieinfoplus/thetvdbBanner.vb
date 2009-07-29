Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
    'Represents an xml root Banners doc that contains banners
    <XmlRoot("Banners")> _
    Public Class [Banners]
        Private p_element_banner As New List(Of BannersBanner)
        ' <summary>Banner[] Banner xml element.</summary>
        <XmlElement("Banner")> _
        Public Property [Banners]() As List(Of BannersBanner)
            Get
                Return Me.p_element_banner
            End Get
            Set(ByVal Value As List(Of BannersBanner))
                Me.p_element_banner = Value
            End Set
        End Property

        Public Sub readBannerXML(ByVal xmllocationandfilename As String, ByRef vbanners As Banners)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRBanners As Banners = CType(serializer.Deserialize(gROReader), thetvdb.Banners)
            gROReader.Close()
            vbanners = gRBanners
        End Sub
    End Class

    'represents a banners.banner node
    Public Class [BannersBanner]
        Private p_element_id As String
        Private p_element_bannerpath As String
        Private p_element_bannertype As String
        Private p_element_bannertype2 As String
        Private p_element_colors As String
        Private p_element_language As String
        Private p_element_thumbnailpath As String
        Private p_element_vignettepath As String
        Private p_element_season As String

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

        ' <summary>String BannerPath element.</summary>
        <XmlElement("BannerPath")> _
        Public Property [BannerPath]() As String
            Get
                Return Me.p_element_bannerpath
            End Get
            Set(ByVal Value As String)
                Me.p_element_bannerpath = Value
            End Set
        End Property

        ' <summary>String BannerType element.</summary>
        <XmlElement("BannerType")> _
        Public Property [BannerType]() As String
            Get
                Return Me.p_element_bannertype
            End Get
            Set(ByVal Value As String)
                Me.p_element_bannertype = Value
            End Set
        End Property

        ' <summary>String BannerType2 element.</summary>
        <XmlElement("BannerType2")> _
        Public Property [BannerType2]() As String
            Get
                Return Me.p_element_bannertype2
            End Get
            Set(ByVal Value As String)
                Me.p_element_bannertype2 = Value
            End Set
        End Property

        ' <summary>String Colors element.</summary>
        <XmlElement("Colors")> _
        Public Property [Colors]() As String
            Get
                Return Me.p_element_colors
            End Get
            Set(ByVal Value As String)
                Me.p_element_colors = Value
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

        ' <summary>String ThumbnailPath element.</summary>
        <XmlElement("ThumbnailPath")> _
        Public Property [ThumbnailPath]() As String
            Get
                Return Me.p_element_thumbnailpath
            End Get
            Set(ByVal Value As String)
                Me.p_element_thumbnailpath = Value
            End Set
        End Property

        ' <summary>String VignettePath element.</summary>
        <XmlElement("VignettePath")> _
        Public Property [VignettePath]() As String
            Get
                Return Me.p_element_vignettepath
            End Get
            Set(ByVal Value As String)
                Me.p_element_vignettepath = Value
            End Set
        End Property

        <XmlElement("Season")> _
        Public Property [Season]() As String
            Get
                Return Me.p_element_season
            End Get
            Set(ByVal Value As String)
                Me.p_element_season = Value
            End Set
        End Property
    End Class

    ' Represents a Data.Banner node.
    Public Class [Banner]
        Private p_element_seasonnum As String
        Private p_element_series As String
        Private p_element_format As String
        Private p_element_language As String
        Private p_element_path As String
        Private p_element_time As String
        Private p_element_type As String

        ' <summary>String SeasonNum element.</summary>
        <XmlElement("SeasonNum")> _
        Public Property [SeasonNum]() As String
            Get
                Return Me.p_element_seasonnum
            End Get
            Set(ByVal Value As String)
                Me.p_element_seasonnum = Value
            End Set
        End Property

        ' <summary>String Series element.</summary>
        <XmlElement("Series")> _
        Public Property [Series]() As String
            Get
                Return Me.p_element_series
            End Get
            Set(ByVal Value As String)
                Me.p_element_series = Value
            End Set
        End Property

        ' <summary>String format element.</summary>
        <XmlElement("format")> _
        Public Property [Format]() As String
            Get
                Return Me.p_element_format
            End Get
            Set(ByVal Value As String)
                Me.p_element_format = Value
            End Set
        End Property

        ' <summary>String language element.</summary>
        <XmlElement("language")> _
        Public Property [Language]() As String
            Get
                Return Me.p_element_language
            End Get
            Set(ByVal Value As String)
                Me.p_element_language = Value
            End Set
        End Property

        ' <summary>String path element.</summary>
        <XmlElement("path")> _
        Public Property [Path]() As String
            Get
                Return Me.p_element_path
            End Get
            Set(ByVal Value As String)
                Me.p_element_path = Value
            End Set
        End Property

        ' <summary>String time element.</summary>
        <XmlElement("time")> _
        Public Property [Time]() As String
            Get
                Return Me.p_element_time
            End Get
            Set(ByVal Value As String)
                Me.p_element_time = Value
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
    End Class

End Namespace