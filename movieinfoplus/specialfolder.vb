Imports System.Xml.Serialization
Imports System.IO

Public Class specialfolder
    Private p_element_type As String
    Private p_element_micode As String
    Private p_element_prefix As String
    Property type() As String
        Get
            Return p_element_type
        End Get
        Set(ByVal value As String)
            p_element_type = value
        End Set
    End Property
    Property micode() As String
        Get
            Return p_element_micode
        End Get
        Set(ByVal value As String)
            p_element_micode = value
        End Set
    End Property
    Property prefix() As String
        Get
            Return p_element_prefix
        End Get
        Set(ByVal value As String)
            p_element_prefix = value
        End Set
    End Property
    Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vtvdblangData As specialfolder)
        Dim xmlfile As String = xmllocationandfilename
        Dim serializer As New XmlSerializer(Me.GetType())
        Dim gROReader As New StreamReader(xmlfile)
        Dim gRvtvdblangData As specialfolder = CType(serializer.Deserialize(gROReader), specialfolder)
        gROReader.Close()
        vtvdblangData = gRvtvdblangData
    End Sub
    Public Sub writeNfo(ByRef folderlocationandname As String)
        Dim serializer As New XmlSerializer(Me.GetType())
        Try
            Dim writer As New StreamWriter(folderlocationandname)
            serializer.Serialize(writer, Me)
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Debug.Print(ex.ToString)
        End Try

    End Sub
End Class
