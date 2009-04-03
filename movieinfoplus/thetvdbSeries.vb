Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
    ' <summary>Represents a Data.Series node.</summary>
    Public Class [Series]
        Private p_element_id As String
        Private p_element_time As String

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
    End Class


    <XmlRoot("Data")> _
    Public Class [TVSeriesData]
        Private p_element_series() As TvSeries

        ' <summary>Series[] Series xml element.</summary>
        <XmlElement("Series")> _
        Public Property [SeriesArray]() As TvSeries()
            Get
                Return Me.p_element_series
            End Get
            Set(ByVal Value As TvSeries())
                Me.p_element_series = Value
            End Set
        End Property

        Public Sub readTVSeriesXML(ByVal xmllocationandfilename As String, ByRef vTVSeriesData As TVSeriesData)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Try
                Dim gRTVSeriesData As TVSeriesData = CType(serializer.Deserialize(gROReader), TVSeriesData)
                gROReader.Close()
                vTVSeriesData = gRTVSeriesData
            Catch ex As Exception
                gROReader.Close()
                If File.Exists(xmlfile) Then
                    System.Threading.Thread.Sleep(500)
                    File.Delete(xmlfile)
                End If
            End Try
          
        End Sub
    End Class
    Public Class [TvSeries]
        Private p_element_seriesid As String
        Private p_element_language As String
        Private p_element_SeriesName As String
        Private p_element_banner As String
        Private p_element_Overview As String
        Private p_element_FirstAired As String
        Private p_element_IMDB_ID As String
        Private p_element_zap2it_id As String
        Private p_element_id As String

        <XmlElement("seriesid")> _
      Public Property [seriesid]() As String
            Get
                Return Me.p_element_seriesid
            End Get
            Set(ByVal Value As String)
                Me.p_element_seriesid = Value
            End Set
        End Property
        <XmlElement("language")> _
      Public Property [language]() As String
            Get
                Return Me.p_element_language
            End Get
            Set(ByVal Value As String)
                Me.p_element_language = Value
            End Set
        End Property
        <XmlElement("SeriesName")> _
      Public Property [SeriesName]() As String
            Get
                Return Me.p_element_SeriesName
            End Get
            Set(ByVal Value As String)
                Me.p_element_SeriesName = Value
            End Set
        End Property
        <XmlElement("banner")> _
      Public Property [banner]() As String
            Get
                Return Me.p_element_banner
            End Get
            Set(ByVal Value As String)
                Me.p_element_banner = Value
            End Set
        End Property
        <XmlElement("Overview")> _
      Public Property [Overview]() As String
            Get
                Return Me.p_element_Overview
            End Get
            Set(ByVal Value As String)
                Me.p_element_Overview = Value
            End Set
        End Property
        <XmlElement("FirstAired")> _
      Public Property [FirstAired]() As String
            Get
                Return Me.p_element_FirstAired
            End Get
            Set(ByVal Value As String)
                Me.p_element_FirstAired = Value
            End Set
        End Property
        <XmlElement("IMDB_ID")> _
      Public Property [IMDB_ID]() As String
            Get
                Return Me.p_element_IMDB_ID
            End Get
            Set(ByVal Value As String)
                Me.p_element_IMDB_ID = Value
            End Set
        End Property
        <XmlElement("zap2it_id")> _
      Public Property [zap2it_id]() As String
            Get
                Return Me.p_element_zap2it_id
            End Get
            Set(ByVal Value As String)
                Me.p_element_zap2it_id = Value
            End Set
        End Property
        <XmlElement("time")> _
      Public Property [Time]() As String
            Get
                Return Me.p_element_id
            End Get
            Set(ByVal Value As String)
                Me.p_element_id = Value
            End Set
        End Property

    End Class
End Namespace