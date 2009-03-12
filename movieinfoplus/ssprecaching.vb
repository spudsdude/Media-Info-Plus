Public NotInheritable Class ssprecaching

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub ssprecaching_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        startprecache()

        '' '' ''dlgTVShowCurStatus.ShowDialog()
        '' '' ''getmirrors() - only one so far, add additional code later
        '' '' ''rconf.debugtvshows = True
        ' '' ''Dim tshows As New tvshowcollection
        ' '' ''tshows.kbLoadTvShows()
        ' '' ''tshows.updatetvshows()

        ' '' ''If lbTvShowPicker.Items.Count > 0 Then
        ' '' ''    lbTvShowPicker.SelectedIndex = 0
        ' '' ''End If
        ' '' ''TVCurrentTVRightMain.Panel1Collapsed = True
        ' '' ''tsbtvPreCache.Enabled = False

    End Sub
    Private Sub startprecache()
        System.Threading.Thread.Sleep(100)
        maincollection.currenttvshowdownloadlist.Clear()
        Dim tshows As New tvshowcollection
        tshows.precacheTvShows()
        'now we have all the data

        'download the stuff
        If Not maincollection.currenttvshowdownloadlist.Count = 0 Then
            dlgDownloadingFile.downloadlist = maincollection.currenttvshowdownloadlist
            dlgDownloadingFile.downloadingmutliimages = True
            dlgDownloadingFile.ShowDialog()
        End If
        'clear the arraylist
        maincollection.currenttvshowdownloadlist.Clear()

        MsgBox("Pre cache completed, now loading the tvshows")
        maincollection.tsbtvPreCache.Enabled = False
        'load the tvshows into the dialog
        'Dim tshows As New tvshowcollection
        tshows.kbLoadTvShows()
        tshows.updatetvshows()

        If maincollection.lbTvShowPicker.Items.Count > 0 Then
            maincollection.lbTvShowPicker.SelectedIndex = 0
        End If
        maincollection.TVCurrentTVRightMain.Panel1Collapsed = True
        'tsbtvPreCache.Enabled = False
        Me.Dispose()
        Me.Close()
    End Sub
End Class
