Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization

Namespace xbmcMediaInfo
    ' <summary>Represents an xml root fileinfo document element.</summary>
    <XmlRoot("fileinfo")> _
    Public Class Fileinfo
        Private p_element_video As New Video
        Private p_element_audio As New Audio
        Private p_element_subtitle As New Subtitle
        ' <summary>video xml element.</summary>
        <XmlElement("video")> _
        Public Property Video() As Video
            Get
                Return Me.p_element_video
            End Get
            Set(ByVal Value As Video)
                Me.p_element_video = Value
            End Set
        End Property

        ' <summary>audio xml element.</summary>
        <XmlElement("audio")> _
         Public Property Audio() As Audio
            Get
                Return Me.p_element_audio
            End Get
            Set(ByVal Value As Audio)
                Me.p_element_audio = Value
            End Set
        End Property
        ' <summary>subtitle xml element.</summary>
        <XmlElement("subtitle")> _
        Public Property Subtitle() As Subtitle
            Get
                Return Me.p_element_subtitle
            End Get
            Set(ByVal Value As Subtitle)
                Me.p_element_subtitle = Value
            End Set
        End Property

        Public Function objtostring(ByRef xmifi As xbmcMediaInfo.Fileinfo) As String
            Dim To_Display As String = ""
            'video
            To_Display += "Video" + vbNewLine
            To_Display += "   Width: " + xmifi.Video.Width + " -x- "
            To_Display += "Height: " + xmifi.Video.Height + vbNewLine
            To_Display += "   Codec: " + xmifi.Video.Codec + vbNewLine
            To_Display += "   Format Info: " + xmifi.Video.Formatinfo + vbNewLine
            To_Display += "   Duration/String1: " + xmifi.Video.Duration + vbNewLine
            To_Display += "   BitRate: " + xmifi.Video.Bitrate + vbNewLine
            To_Display += "   BitRate_Mode/String: " + xmifi.Video.Bitratemode + vbNewLine
            To_Display += "   BitRate_Maximum: " + xmifi.Video.Bitratemax + vbNewLine
            To_Display += "   CodecID: " + xmifi.Video.Codecid + vbNewLine
            To_Display += "   CodecID/Info: " + xmifi.Video.Codecidinfo + vbNewLine 'Format_Version
            To_Display += "   Scan type: " + xmifi.Video.Scantype + vbNewLine
            'To_Display += "   Container: " + "This is the extension of the file" + vbNewLine
            'audio
            To_Display += "Audio" + vbNewLine
            To_Display += "   Codec: " + xmifi.Audio.Codec + vbNewLine
            To_Display += "   Channels: " + xmifi.Audio.Channels + vbNewLine
            To_Display += "   BitRate/String: " + xmifi.Audio.Bitrate + vbNewLine
            To_Display += "   Language: " + xmifi.Audio.Language + vbNewLine
            To_Display += "Subtitles" + vbNewLine
            To_Display += "   Language: " + xmifi.Subtitle.Language + vbNewLine
            Return To_Display
        End Function
    End Class

    ' <summary>Represents a fileinfo.video node.</summary>
    Public Class Video
        Private p_element_width As System.String
        Private p_element_height As System.String
        Private p_element_codec As System.String
        Private p_element_formatinfo As System.String
        Private p_element_duration As System.String
        Private p_element_bitrate As System.String
        Private p_element_bitratemode As System.String
        Private p_element_bitratemax As System.String
        Private p_element_container As System.String
        Private p_element_codecid As System.String
        Private p_element_codecidinfo As System.String
        Private p_element_scantype As System.String

        ' <summary>String width element.</summary>
        <XmlElement("width")> _
        Public Property Width() As System.String
            Get
                Return Me.p_element_width
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_width = Value
            End Set
        End Property

        ' <summary>String height element.</summary>
        <XmlElement("height")> _
        Public Property Height() As System.String
            Get
                Return Me.p_element_height
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_height = Value
            End Set
        End Property

        ' <summary>String codec element.</summary>
        <XmlElement("codec")> _
        Public Property Codec() As System.String
            Get
                Return Me.p_element_codec
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_codec = Value
            End Set
        End Property

        ' <summary>String formatinfo element.</summary>
        <XmlElement("formatinfo")> _
        Public Property Formatinfo() As System.String
            Get
                Return Me.p_element_formatinfo
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_formatinfo = Value
            End Set
        End Property

        ' <summary>String duration element.</summary>
        <XmlElement("duration")> _
        Public Property Duration() As System.String
            Get
                Return Me.p_element_duration
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_duration = Value
            End Set
        End Property

        ' <summary>String bitrate element.</summary>
        <XmlElement("bitrate")> _
        Public Property Bitrate() As System.String
            Get
                Return Me.p_element_bitrate
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_bitrate = Value
            End Set
        End Property

        ' <summary>String bitratemode element.</summary>
        <XmlElement("bitratemode")> _
        Public Property Bitratemode() As System.String
            Get
                Return Me.p_element_bitratemode
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_bitratemode = Value
            End Set
        End Property

        ' <summary>String bitratemax element.</summary>
        <XmlElement("bitratemax")> _
        Public Property Bitratemax() As System.String
            Get
                Return Me.p_element_bitratemax
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_bitratemax = Value
            End Set
        End Property

        ' <summary>String container element.</summary>
        <XmlElement("container")> _
        Public Property Container() As System.String
            Get
                Return Me.p_element_container
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_container = Value
            End Set
        End Property

        ' <summary>String codecid element.</summary>
        <XmlElement("codecid")> _
        Public Property Codecid() As System.String
            Get
                Return Me.p_element_codecid
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_codecid = Value
            End Set
        End Property

        ' <summary>String codecidinfo element.</summary>
        <XmlElement("codecidinfo")> _
        Public Property Codecidinfo() As System.String
            Get
                Return Me.p_element_codecidinfo
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_codecidinfo = Value
            End Set
        End Property

        ' <summary>String scantype element.</summary>
        <XmlElement("scantype")> _
        Public Property Scantype() As System.String
            Get
                Return Me.p_element_scantype
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_scantype = Value
            End Set
        End Property
    End Class

    ' <summary>Represents a fileinfo.audio node.</summary>
    Public Class Audio
        Private p_element_codec As System.String
        Private p_element_channels As System.String
        Private p_element_bitrate As System.String
        Private p_element_language As System.String

        ' <summary>String codec element.</summary>
        <XmlElement("language")> _
        Public Property Language() As System.String
            Get
                Return Me.p_element_language
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_language = Value
            End Set
        End Property


        ' <summary>String codec element.</summary>
        <XmlElement("codec")> _
        Public Property Codec() As System.String
            Get
                Return Me.p_element_codec
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_codec = Value
            End Set
        End Property

        ' <summary>String channels element.</summary>
        <XmlElement("channels")> _
        Public Property Channels() As System.String
            Get
                Return Me.p_element_channels
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_channels = Value
            End Set
        End Property

        ' <summary>String bitrate element.</summary>
        <XmlElement("bitrate")> _
        Public Property Bitrate() As System.String
            Get
                Return Me.p_element_bitrate
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_bitrate = Value
            End Set
        End Property
    End Class
    Public Class Subtitle
        Private p_element_language As System.String

        ' <summary>String codec element.</summary>
        <XmlElement("language")> _
        Public Property Language() As System.String
            Get
                Return Me.p_element_language
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_language = Value
            End Set
        End Property
    End Class
End Namespace
