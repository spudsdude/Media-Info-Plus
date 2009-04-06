Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.IO

Namespace thestudio
    Public Class mystudio
        Implements IComparable
        Public Function CompareTo(ByVal obj As Object) As Integer _
     Implements System.IComparable.CompareTo
            If Not TypeOf obj Is mystudio Then
                Throw New Exception("Object is not MyObject")
            End If
            Dim Compare As mystudio = CType(obj, mystudio)
            Dim result As Integer = Me.studio.CompareTo(Compare.studio)

            If result = 0 Then
                result = Me.studio.CompareTo(Compare.studio)
            End If
            Return result
        End Function
        Private p_element_studio As String
        Property studio() As String
            Get
                Return p_element_studio
            End Get
            Set(ByVal value As String)
                p_element_studio = value
            End Set
        End Property

    End Class
    Public Class mystudios
        Private p_element_studio As New List(Of String)
        Private p_element_version As Double = 0
        <XmlElement("version")> _
        Property version() As Double
            Get
                Return p_element_version
            End Get
            Set(ByVal value As Double)
                p_element_version = value
            End Set
        End Property
        <XmlElement("mystudio")> _
        Property studios() As List(Of String)
            Get
                Return p_element_studio
            End Get
            Set(ByVal value As List(Of String))
                p_element_studio = value
            End Set
        End Property

        Public Sub saveConfig(ByRef curstudio As mystudios, ByVal mystudioxml As String)
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim writer As New StreamWriter(mystudioxml)
            serializer.Serialize(writer, curstudio)
            writer.Close()
            writer.Dispose()
        End Sub
        Public Function getmystudio(ByVal mystudioxml As String) As mystudios
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gRmystudio As mystudios
            Dim gROReader As New StreamReader(mystudioxml)
            Try
                gRmystudio = CType(serializer.Deserialize(gROReader), mystudios)
                gROReader.Close()
                gROReader.Dispose()
            Catch ex As Exception
                gROReader.Close()
                gROReader.Dispose()
                'gRconf = New configuration
            End Try

            Return gRmystudio
        End Function
    End Class

End Namespace
