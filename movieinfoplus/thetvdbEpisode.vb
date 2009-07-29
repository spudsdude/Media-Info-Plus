Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
    ' <summary>Represents a Data.Episode node.</summary>
    Public Class [Episode]
        Private p_element_id As String
        Private p_element_series As String
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

End Namespace