Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
	' <summary>Represents a Mirrors.Mirror node.</summary>
	Public Class [Mirror]
		Private p_element_id As String
		Private p_element_mirrorpath As String
		Private p_element_typemask As String

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

		' <summary>String mirrorpath element.</summary>
		<XmlElement("mirrorpath")> _
		Public Property [Mirrorpath]() As String
			Get
				Return Me.p_element_mirrorpath
			End Get
			Set(ByVal Value As String)
				Me.p_element_mirrorpath = Value
			End Set
		End Property

		' <summary>String typemask element.</summary>
		<XmlElement("typemask")> _
		Public Property [Typemask]() As String
			Get
				Return Me.p_element_typemask
			End Get
			Set(ByVal Value As String)
				Me.p_element_typemask = Value
			End Set
		End Property
	End Class
End Namespace