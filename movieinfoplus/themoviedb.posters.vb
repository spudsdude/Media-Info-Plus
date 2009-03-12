Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace mip.themoviedb.posters
    ' <summary>Represents an xml root Items document element.</summary>
    <XmlRoot("Items")> _
    Public Class [posters]
        Private p_element_item As List(Of Item)

        ' <summary>Item[] Item xml element.</summary>
        <XmlElement("Item")> _
        Public Property [Items]() As List(Of Item)
            Get
                Return Me.p_element_item
            End Get
            Set(ByVal Value As List(Of Item))
                Me.p_element_item = Value
            End Set
        End Property
    End Class

    ' <summary>Represents a Items.Item node.</summary>
    Public Class [Item]
        Private p_element_small As System.String
        Private p_element_medium As System.String
        Private p_element_large As System.String
        Private p_element_full As System.String

        ' <summary>String small element.</summary>
        <XmlElement("small")> _
        Public Property [Small]() As System.String
            Get
                Return Me.p_element_small
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_small = Value
            End Set
        End Property

        ' <summary>String medium element.</summary>
        <XmlElement("medium")> _
        Public Property [Medium]() As System.String
            Get
                Return Me.p_element_medium
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_medium = Value
            End Set
        End Property

        ' <summary>String large element.</summary>
        <XmlElement("large")> _
        Public Property [Large]() As System.String
            Get
                Return Me.p_element_large
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_large = Value
            End Set
        End Property

        ' <summary>String full element.</summary>
        <XmlElement("full")> _
        Public Property [Full]() As System.String
            Get
                Return Me.p_element_full
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_full = Value
            End Set
        End Property
    End Class
End Namespace