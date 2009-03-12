Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
    ' <summary>Represents an xml root Data document element.</summary>
    <XmlRoot("Data")> _
    Public Class [tvdbData]
        Private p_attribute_time As Integer
        Private p_element_series() As Series
        Private p_element_episode() As Episode
        Private p_element_banner() As Banner

        Public Sub readMirrorsXML(ByVal xmllocationandfilename As String, ByRef vtvdbData As tvdbData)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRtvdbData As tvdbData = CType(serializer.Deserialize(gROReader), tvdbData)
            gROReader.Close()
            vtvdbData = gRtvdbData
            'Return gRConf
            'Dim id As String = Me.Id
            'Dim ms As New MirrorsSerializer
            ' ms.Serialize(Me)
            'Dim serializer As New XmlSerializer(Me.GetType())
            'Dim reader As New StreamReader(xmllocationandfilename) ' + Convert.ToString(id) + ".xml")

            'reader.Close()
        End Sub
        ' <summary>System.Int32 time attribute.</summary>
        <XmlAttribute("time")> _
        Public Property [Time]() As Integer
            Get
                Return Me.p_attribute_time
            End Get
            Set(ByVal Value As Integer)
                Me.p_attribute_time = Value
            End Set
        End Property

        ' <summary>Series[] Series xml element.</summary>
        <XmlElement("Series")> _
        Public Property [Serieses]() As Series()
            Get
                Return Me.p_element_series
            End Get
            Set(ByVal Value As Series())
                Me.p_element_series = Value
            End Set
        End Property

        ' <summary>Episode[] Episode xml element.</summary>
        <XmlElement("Episode")> _
        Public Property [Episodes]() As Episode()
            Get
                Return Me.p_element_episode
            End Get
            Set(ByVal Value As Episode())
                Me.p_element_episode = Value
            End Set
        End Property

        ' <summary>Banner[] Banner xml element.</summary>
        <XmlElement("Banner")> _
        Public Property [Banners]() As Banner()
            Get
                Return Me.p_element_banner
            End Get
            Set(ByVal Value As Banner())
                Me.p_element_banner = Value
            End Set
        End Property

        Public Sub readtvdbDataXML(ByVal xmllocationandfilename As String, ByRef vtvdbData As tvdbData)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRtvdbData As tvdbData = CType(serializer.Deserialize(gROReader), tvdbData)
            gROReader.Close()
            vtvdbData = gRtvdbData
        End Sub
    End Class
End Namespace