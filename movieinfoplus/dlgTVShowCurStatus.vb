Imports System.Windows.Forms
Imports System.IO

Public Class dlgTVShowCurStatus
    Dim tvshowarray As New ArrayList
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bwtvshowstatus_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwtvshowstatus.DoWork

    End Sub
    Private Sub bwtvshowstatus_progresschanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwtvshowstatus.ProgressChanged
        'prgThread.Value = e.ProgressPercentage
        krbStatus.Text += vbNewLine + e.UserState.ToString
        Me.Refresh()
    End Sub
    Private Sub go()
        'System.Threading.Thread.Sleep(100)
        'For Each item In maincollection.lbTVShows.CheckedItems
        '    'ennum sub dir x levels deep
        '    Dim curdircontents() As String
        '    curdircontents = Directory.GetDirectories(item.ToString)
        '    For Each currentdir As String In curdircontents
        '        tvshowarray.Add(currentdir)
        '    Next

        'Next
        'Dim tshows As New tvshowcollection
        'tshows.kbLoadTvShows(tvshowarray)
        'tshows.updatetvshows()
    End Sub

    Private Sub dlgTVShowCurStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        go()
    End Sub


End Class
