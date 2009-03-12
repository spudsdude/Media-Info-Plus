Option Strict On
Imports System
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Namespace thetvdb
    Public Class DataSerializer
        Private s As XmlSerializer = Nothing
        Private type As Type = Nothing

        Public Sub New()
            Me.type = GetType(tvdbData)
            Me.s = New XmlSerializer(Me.type)
        End Sub

        Public Function Deserialize(ByVal xml As String) As tvdbData
            Dim reader As TextReader = New StringReader(xml)
            Return Deserialize(reader)
        End Function

        Public Function Deserialize(ByVal doc As XmlDocument) As tvdbData
            Dim reader = New StringReader(doc.OuterXml)
            Return Deserialize(reader)
        End Function

        Public Function Deserialize(ByVal reader As TextReader) As tvdbData
            Dim o As tvdbData = CType(s.Deserialize(reader), tvdbData)
            reader.Close()
            Return o
        End Function

        Public Function Serialize(ByVal data As tvdbData) As XmlDocument
            Dim xml As String = StringSerialize(data)
            Dim doc As XmlDocument = New XmlDocument
            doc.PreserveWhitespace = True
            doc.LoadXml(xml)
            doc = Clean(doc)
            Return doc
        End Function

        Private Function StringSerialize(ByVal data As tvdbData) As String
            Dim w As TextWriter = WriterSerialize(data)
            Dim xml As String = w.ToString()
            w.Close()
            Return xml.Trim()
        End Function

        Private Function WriterSerialize(ByVal data As tvdbData) As TextWriter
            Dim w As TextWriter = New StringWriter
            Me.s = New XmlSerializer(Me.type)
            s.Serialize(w, data)
            w.Flush()
            Return w
        End Function

        Private Function Clean(ByVal doc As XmlDocument) As XmlDocument
            doc.RemoveChild(doc.FirstChild)
            Dim first As XmlNode = doc.FirstChild
            For Each n As XmlNode In doc.ChildNodes
                If (n.NodeType = XmlNodeType.Element) Then
                    first = n
                    Exit For
                End If
            Next
            If Not first.Attributes Is Nothing Then
                Dim a As XmlAttribute = Nothing
                a = first.Attributes("xmlns:xsd")
                If Not a Is Nothing Then first.Attributes.Remove(a)
                a = first.Attributes("xmlns:xsi")
                If Not a Is Nothing Then first.Attributes.Remove(a)
            End If
            Return doc
        End Function

        Public Shared Function ReadFile(ByVal file As String) As tvdbData
            Dim serializer As DataSerializer = New DataSerializer
            Try
                Dim xml As String = String.Empty
                Dim reader As StreamReader = New StreamReader(file)
                xml = reader.ReadToEnd()
                reader.Close()
                reader = Nothing
                Return serializer.Deserialize(xml)
            Catch
            End Try
            Return New tvdbData
        End Function

        Public Shared Function WriteFile(ByVal file As String, ByVal config As tvdbData) As Boolean
            Dim ok As Boolean = False
            Dim serializer As DataSerializer = New DataSerializer
            Try
                Dim xml As String = serializer.Serialize(config).OuterXml
                Dim writer As StreamWriter = New StreamWriter(file, False)
                writer.Write(xml.Trim())
                writer.Flush()
                writer.Close()
                writer = Nothing
                ok = True
            Catch
            End Try
            Return ok
        End Function
    End Class
End Namespace