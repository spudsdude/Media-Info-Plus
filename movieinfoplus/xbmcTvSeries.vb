Namespace xbmc
    Public Class xbmcTvSeries
        Private p_element_seriesTVDBID As String
        Private p_element_seriesNumber As String
        Private p_element_series As New List(Of xbmc.xbmcEpisodedetails)
        Property xbmctvseriesNumber() As String
            Get
                Return p_element_seriesNumber
            End Get
            Set(ByVal value As String)
                p_element_seriesNumber = value
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
    End Class
End Namespace
