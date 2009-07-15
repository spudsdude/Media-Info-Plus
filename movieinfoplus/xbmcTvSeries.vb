Imports System.Xml.Serialization
Imports System.IO

Namespace xbmc
    Public Class xbmcTvSeries
        Private p_element_seriesTVDBID As String
        Private p_element_seriesNumber As Integer
        Private p_element_seriesUseDVDOrder As Boolean = False
        Private p_element_seriesUseAiredOrder As Boolean = True
        Private p_element_series As New List(Of xbmc.xbmcEpisodedetails)
        Property xbmctvseriesNumber() As Integer
            Get
                Return p_element_seriesNumber
            End Get
            Set(ByVal value As Integer)
                p_element_seriesNumber = value
            End Set
        End Property

        Property xbmctvseriesUseDVDOrder() As Boolean
            Get
                Return p_element_seriesUseDVDOrder
            End Get
            Set(ByVal value As Boolean)
                p_element_seriesUseDVDOrder = value
            End Set
        End Property

        Property xbmctvseriesUseAiredOrder() As Boolean
            Get
                Return p_element_seriesUseAiredOrder
            End Get
            Set(ByVal value As Boolean)
                p_element_seriesUseAiredOrder = value
            End Set
        End Property

        Property xbmctvseriesTVDBID() As String
            Get
                Return p_element_seriesTVDBID
            End Get
            Set(ByVal value As String)
                p_element_seriesTVDBID = value
            End Set
        End Property

        Public Property xbmctvseries() As List(Of xbmc.xbmcEpisodedetails)
            Get
                Return p_element_series
            End Get
            Set(ByVal value As List(Of xbmc.xbmcEpisodedetails))
                p_element_series = value
            End Set
        End Property


        Public Sub readXML(ByVal xmllocationandfilename As String, ByRef vxbmcTvshow As xbmcTvSeries)
            Try
                Dim xmlfile As String = xmllocationandfilename
                Dim serializer As New XmlSerializer(Me.GetType())
                Dim gROReader As New StreamReader(xmlfile)
                Dim gRxbmcTvshow As xbmcTvSeries = CType(serializer.Deserialize(gROReader), xbmcTvSeries)
                gROReader.Close()
                vxbmcTvshow = gRxbmcTvshow
            Catch ex As Exception
                'vxbmcTvshow.Tvdbid = ""
            End Try

        End Sub

        Public Sub writeXML(ByRef fullfilelocation As String)
            Dim id As String = CStr(Me.p_element_seriesNumber)
            Dim writefile As Boolean = True
            If writefile Then
                Dim serializer As New XmlSerializer(Me.GetType())
                Try
                    Dim writer As New StreamWriter(fullfilelocation) ' + "\season" + id + ".nfo") 'mainform.rconf.imdbcachefolder + "\" + id + ".xml")
                    serializer.Serialize(writer, Me)
                    writer.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Debug.Print(ex.ToString)
                End Try
            End If
        End Sub
    End Class
End Namespace
