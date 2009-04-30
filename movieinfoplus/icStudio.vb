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
            Dim result As Integer = Me.Studioname.CompareTo(Compare.Studioname)

            If result = 0 Then
                result = Me.Studioname.CompareTo(Compare.Studioname)
            End If
            Return result
        End Function
        'Private p_element_studio As String
        'Property studio() As String
        '    Get
        '        Return p_element_studio
        '    End Get
        '    Set(ByVal value As String)
        '        p_element_studio = value
        '    End Set
        'End Property
        Private p_element_texture As System.String
        Private p_element_studioname As System.String
        Private p_element_displayonly As Boolean
        ' <summary>String texture element.</summary>
        <XmlElement("displayonly")> _
       Public Property [Displayonly]() As Boolean
            Get
                Return Me.p_element_displayonly
            End Get
            Set(ByVal Value As Boolean)
                Me.p_element_displayonly = Value
            End Set
        End Property
        ' <summary>String texture element.</summary>
        <XmlElement("texture")> _
       Public Property [Texture]() As System.String
            Get
                Return Me.p_element_texture
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_texture = Value
            End Set
        End Property

        ' <summary>String studioname element.</summary>
        <XmlElement("studioname")> _
        Public Property [Studioname]() As System.String
             Get
                Return Me.p_element_studioname
            End Get
             Set(ByVal Value As System.String)
                Me.p_element_studioname = Value
            End Set
        End Property
    End Class
    Public Class mystudios
        Private p_element_studio As New List(Of mystudio)
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
        Property studios() As List(Of mystudio)
            Get
                Return p_element_studio
            End Get
            Set(ByVal value As List(Of mystudio))
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
