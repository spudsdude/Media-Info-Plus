Imports System.Windows.Forms

Public Class dialogTvShowSelect
    Public dhashtable As New Hashtable
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Dim selectedshow As String = CStr(klbPickTheTvShow.SelectedValue)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub klbPickTheTvShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles klbPickTheTvShow.MouseClick
        displayshowdata()
    End Sub

    Public Sub displayshowdata()
        Dim thetvtvseries As thetvdb.TvSeries = CType(dhashtable(CStr(klbPickTheTvShow.SelectedValue)), thetvdb.TvSeries)
        klblAirDay.Text = thetvtvseries.FirstAired
        klblRunTime.Text = thetvtvseries.Time
        klbllang.Text = thetvtvseries.language
        klboverview.Text = thetvtvseries.Overview
        klblImdbid.Text = thetvtvseries.IMDB_ID
        pbBanner.ImageLocation = "http://www.thetvdb.com/banners/" + thetvtvseries.banner
    End Sub
   

End Class
