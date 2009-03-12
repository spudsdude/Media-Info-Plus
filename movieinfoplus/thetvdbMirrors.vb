Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace thetvdb
    <XmlRoot("Mirrors")> _
 Public Class [Mirrors]
        Private p_element_mirror As New List(Of Mirror)
        <XmlElement("Mirror")> _
            Public Property [Mirrors]() As List(Of Mirror)
            Get
                Return Me.p_element_mirror
            End Get
            Set(ByVal Value As List(Of Mirror))
                Me.p_element_mirror = Value
            End Set
        End Property
        'Public Sub writeMirrorsXMLfromStream(ByVal xmlstream As Stream)
        '    'Dim id As String = Me.Id
        '    Dim ms As New MirrorsSerializer
        '    ' ms.Serialize(Me)
        '    Dim serializer As New XmlSerializer(Me.GetType())
        '    Dim writer As New StreamWriter(xmlstream) ' + Convert.ToString(id) + ".xml")
        '    serializer.Serialize(writer, Me) 'ms.Serialize(Me))
        '    writer.Close()
        'End Sub
        'Public Sub writeMirrorsXMLfromstring(ByVal xmllocationandfilename As String)
        '    'Dim id As String = Me.Id
        '    Dim ms As New MirrorsSerializer
        '    ' ms.Serialize(Me)
        '    Dim serializer As New XmlSerializer(Me.GetType())
        '    Dim writer As New StreamWriter(xmllocationandfilename) ' + Convert.ToString(id) + ".xml")
        '    serializer.Serialize(writer, Me) 'ms.Serialize(Me))
        '    writer.Close()
        'End Sub
        Public Sub readMirrorsXML(ByVal xmllocationandfilename As String, ByRef tmirrors As Mirrors)
            Dim xmlfile As String = xmllocationandfilename
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRMirrors As Mirrors = CType(serializer.Deserialize(gROReader), Mirrors)
            gROReader.Close()
            tmirrors = gRMirrors
            'Return gRConf
            'Dim id As String = Me.Id
            'Dim ms As New MirrorsSerializer
            ' ms.Serialize(Me)
            'Dim serializer As New XmlSerializer(Me.GetType())
            'Dim reader As New StreamReader(xmllocationandfilename) ' + Convert.ToString(id) + ".xml")

            'reader.Close()
        End Sub
    End Class
End Namespace