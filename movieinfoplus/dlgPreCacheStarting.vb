Imports System.Windows.Forms

Public Class dlgPreCacheStarting
    Private Sub go()
        'bwStartPreCache
        System.Threading.Thread.Sleep(100)
        maincollection.currenttvshowdownloadlist.Clear()

        Dim tshows As New tvshowcollection
        tshows.precacheTvShows()

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
        'bwStartPreCache = New System.ComponentModel.BackgroundWorker
        'bwStartPreCache.WorkerReportsProgress = True
        'bwStartPreCache.WorkerSupportsCancellation = True
        'bwStartPreCache.RunWorkerAsync()

    End Sub
    Private Sub bwStartPreCache_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwStartPreCache.DoWork
        Dim tshows As New tvshowcollection
        tshows.precacheTvShows()
        'now we have all the data
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bwStartPreCache_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwStartPreCache.RunWorkerCompleted
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
        Dim tshows As New tvshowcollection
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

    Private Sub dlgPreCacheStarting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        go()
    End Sub
End Class
