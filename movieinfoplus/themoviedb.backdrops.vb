Option Explicit On
Option Strict On
Imports System
Imports System.IO
Imports System.Net
Imports System.Xml.Serialization
Imports System.Collections.Generic
Namespace mip.themoviedb.backdrop
    ' root Items
    <XmlRoot("Items")> _
     Public Class [backdrops]
        Private p_element_item As New List(Of Item)

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
 
        Private Sub getthemoviedbbackdrop(ByRef timdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal wait As Boolean, ByVal usewget As Boolean)
            '  "http://api.themoviedb.org/backdrop.php?imdb=" + imdbid
            If usewget Then
                Dim url As String = "http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                Dim folder As String = wheretoputxml
                Dim binfilelocal As String = wgetfolder + "wget.exe"
                Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
                Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
                pro1.StartInfo.FileName = binfilelocal
                pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + folder + "\" + timdbid + ".xml" + """"
                pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                pro1.Start()
                If wait Then pro1.WaitForExit()
            Else
                'use built in http method
                Try
                    Dim url As String = "http://api.themoviedb.org/backdrop.php?imdb=" + timdbid
                    Dim folder As String = wheretoputxml
                    Dim aWebRequest As WebRequest
                    aWebRequest = WebRequest.Create(url.ToLower)
                    Dim aHttpWebResponse As HttpWebResponse
                    aHttpWebResponse = CType(aWebRequest.GetResponse, HttpWebResponse)
                    Dim readStream As Stream
                    readStream = aHttpWebResponse.GetResponseStream
                    Dim buffer As Byte() = New Byte(3000000) {}
                    Try
                        Dim outStream As Stream = System.IO.File.Create(folder + timdbid + ".xml")
                        'executing_assembly.GetManifestResourceStream(my_namespace _
                        '+ ".wget.exe")
                        Dim l As Integer
                        Do
                            l = readStream.Read(buffer, 0, buffer.Length)
                            If l > 0 Then
                                outStream.Write(buffer, 0, l)
                            End If
                        Loop While l > 0
                        outStream.Close()
                        aHttpWebResponse.Close()
                        readStream.Close()
                    Catch ex As Exception
                        Debug.Print(ex.ToString)
                        aHttpWebResponse.Close()
                        readStream.Close()
                    End Try
                Catch ex1 As Exception
                    Debug.Print(ex1.ToString)
                End Try
            End If

        End Sub
        Public Shared Sub getbackdrop(ByRef thebackdropobject As mip.themoviedb.backdrop.backdrops, ByVal timdbid As String, ByRef wgetfolder As String, ByRef wheretoputxml As String, ByVal twait As Boolean, ByVal overwritethexmlfile As Boolean, ByVal usewget As Boolean) 'As mip.themoviedb.backdrop.backdrops
            If timdbid = "" Then
                Exit Sub
            End If
            Dim wherestherexml As String = wheretoputxml + timdbid + ".xml"
            If Not File.Exists(wherestherexml) Or overwritethexmlfile Then
                'file either doesn't exsist or overwritethexmlfile is true
                'download the file
                thebackdropobject.getthemoviedbbackdrop(timdbid, wgetfolder, wheretoputxml, twait, False)
            End If
            'set object
            thebackdropobject = thebackdropobject.getbackdropfromxml(wherestherexml)
        End Sub
        Private Function getbackdropfromxml(ByVal stringnameofthebackdropsxmlfile As String) As mip.themoviedb.backdrop.backdrops
            Dim xmlfile As String = stringnameofthebackdropsxmlfile
            Dim serializer As New XmlSerializer(Me.GetType())
            Dim gROReader As New StreamReader(xmlfile)
            Dim gRbackdrop As New mip.themoviedb.backdrop.backdrops
            Try
                gRbackdrop = CType(serializer.Deserialize(gROReader), mip.themoviedb.backdrop.backdrops)
            Catch ex As Exception
                Debug.Print("backdrop read: " + ex.ToString)
            End Try

            gROReader.Close()
            Return gRbackdrop
        End Function
    End Class

    ' Represents the Items.Item (aka the backdrop)
    Public Class [Item]
        Private p_element_url As System.String
        Private p_element_postcard As System.String
        Private p_element_thumb As System.String

        ' <summary>String URL element.</summary>
        <XmlElement("URL")> _
        Public Property [URL]() As System.String
            Get
                Return Me.p_element_url
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_url = Value
            End Set
        End Property

        ' <summary>String Postcard element.</summary>
        <XmlElement("Postcard")> _
        Public Property [Postcard]() As System.String
            Get
                Return Me.p_element_postcard
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_postcard = Value
            End Set
        End Property

        ' <summary>String Thumb element.</summary>
        <XmlElement("Thumb")> _
        Public Property [Thumb]() As System.String
            Get
                Return Me.p_element_thumb
            End Get
            Set(ByVal Value As System.String)
                Me.p_element_thumb = Value
            End Set
        End Property
    End Class


End Namespace
