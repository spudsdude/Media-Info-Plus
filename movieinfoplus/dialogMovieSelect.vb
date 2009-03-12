Imports System.Windows.Forms

Public Class dialogMovieSelect
    Public dhashtable As New Hashtable
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub klbPickTheMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles klbPickTheMovie.Click
        displayshowdata()
    End Sub

    Public Sub displayshowdata()
        Dim thetvtvseries As thetvdb.TvSeries = CType(dhashtable(CStr(klbPickTheMovie.SelectedValue)), thetvdb.TvSeries)
        klblAirDay.Text = thetvtvseries.FirstAired
        klblRunTime.Text = thetvtvseries.Time
        klbllang.Text = thetvtvseries.language
        klboverview.Text = thetvtvseries.Overview
        klblImdbid.Text = thetvtvseries.IMDB_ID
        pbBanner.ImageLocation = "http://www.thetvdb.com/banners/" + thetvtvseries.banner
    End Sub
End Class
