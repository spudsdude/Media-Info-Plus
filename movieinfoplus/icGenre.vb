Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.IO

Namespace thegenre
    Public Class mygenre
        Private p_element_genre As String
        Property genre() As String
            Get
                Return p_element_genre
            End Get
            Set(ByVal value As String)
                p_element_genre = value
            End Set
        End Property
    End Class
    Public Class mygenres
        Private p_element_genres As New List(Of String)
        <XmlElement("mygenres")> _
        Property genres() As List(Of String)
            Get
                Return p_element_genres
            End Get
            Set(ByVal value As List(Of String))
                p_element_genres = value
            End Set
        End Property

        Public Sub saveConfig(ByRef curgenre As mygenres, ByVal mygenresxml As String)
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim writer As New StreamWriter(mygenresxml)
            serializer.Serialize(writer, curgenre)
            writer.Close()
            writer.Dispose()
        End Sub
        Public Function getmygenres(ByVal mygenresxml As String) As mygenres
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gRmygenres As mygenres
            Dim gROReader As New StreamReader(mygenresxml)
            Try
                gRmygenres = CType(serializer.Deserialize(gROReader), mygenres)
                gROReader.Close()
                gROReader.Dispose()
            Catch ex As Exception
                gROReader.Close()
                gROReader.Dispose()
                'gRconf = New configuration
            End Try

            Return gRmygenres
        End Function
    End Class
End Namespace
