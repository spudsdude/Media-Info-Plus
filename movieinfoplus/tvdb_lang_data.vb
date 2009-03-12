Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace tvdblang
    ' <summary>Represents an xml root Data document element.</summary>
    <XmlRoot("Data")> _
    Public Class [tvdblangData]
        Private p_element_series As tvdblangSeries
        Private p_element_episode As New List(Of tvdblangEpisode)

        Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vtvdblangData As tvdblangData)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRvtvdblangData As tvdblangData = CType(serializer.Deserialize(gROReader), tvdblangData)
            gROReader.Close()
            vtvdblangData = gRvtvdblangData
        End Sub
        ' <summary>Series xml element.</summary>
        <XmlElement("Series")> _
        Public Property [Series]() As tvdblangSeries
            Get
                Return Me.p_element_series
            End Get
            Set(ByVal Value As tvdblangSeries)
                Me.p_element_series = Value
            End Set
        End Property

        ' <summary>Episode[] Episode xml element.</summary>
        <XmlElement("Episode")> _
        Public Property [Episodes]() As List(Of tvdblangEpisode)
            Get
                Return Me.p_element_episode
            End Get
            Set(ByVal Value As List(Of tvdblangEpisode))
                Me.p_element_episode = Value
            End Set
        End Property
    End Class
End Namespace