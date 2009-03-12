Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace tvdbactor
    ' <summary>Represents a Actors.Actor node.</summary>
    <XmlRoot("Actor")> _
    Public Class [tvdbActor]
        Private p_element_id As String
        Private p_element_image As String
        Private p_element_name As String
        Private p_element_role As String
        Private p_element_sortorder As String

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

        ' <summary>String Image element.</summary>
        <XmlElement("Image")> _
        Public Property [Image]() As String
            Get
                Return Me.p_element_image
            End Get
            Set(ByVal Value As String)
                Me.p_element_image = Value
            End Set
        End Property

        ' <summary>String Name element.</summary>
        <XmlElement("Name")> _
        Public Property [Name]() As String
            Get
                Return Me.p_element_name
            End Get
            Set(ByVal Value As String)
                Me.p_element_name = Value
            End Set
        End Property

        ' <summary>String Role element.</summary>
        <XmlElement("Role")> _
        Public Property [Role]() As String
            Get
                Return Me.p_element_role
            End Get
            Set(ByVal Value As String)
                Me.p_element_role = Value
            End Set
        End Property

        ' <summary>String SortOrder element.</summary>
        <XmlElement("SortOrder")> _
        Public Property [SortOrder]() As String
            Get
                Return Me.p_element_sortorder
            End Get
            Set(ByVal Value As String)
                Me.p_element_sortorder = Value
            End Set
        End Property
    End Class
End Namespace