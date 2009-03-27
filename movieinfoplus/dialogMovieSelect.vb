Imports System.Windows.Forms
Imports System.IO

Public Class dialogMovieSelect
    Public dhashtable As New Hashtable
    Private g_tid As String
    Private g_curdispmovie As New movie
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub klbPickTheMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles klbPickTheMovie.Click
        Dim tid As String = CStr(klbPickTheMovie.SelectedValue)
        g_tid = tid
        getmovieinfo_bw() 'displayshowdata()
    End Sub
    Private Sub getmovieinfo_bw()
        'If Me.messageprompts Then krtbTVShowMediaInfo.Text = "Reading TV Show Media Information"
        pbarLoadingInfo.Visible = True
        lblpbarLoadingInfo.Visible = True
        btnCancelLoad.Enabled = True
        btnCancelLoad.Visible = True
        kgPickCorrectShow.Enabled = False
        kgMovieInfo.Enabled = False
        kgImage.Enabled = False
        btnCancel.Visible = False
        btnOK.Visible = False
        Me.Refresh()
        bwloadimage = New System.ComponentModel.BackgroundWorker
        bwloadimage.WorkerReportsProgress = True
        bwloadimage.WorkerSupportsCancellation = True
        bwloadimage.RunWorkerAsync()
    End Sub
    Private Sub bwloadimage_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwloadimage.DoWork
        displayshowdata(g_tid)

    End Sub
    Private Sub bwloadimage_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwloadimage.RunWorkerCompleted
        pbarLoadingInfo.Visible = False
        lblpbarLoadingInfo.Visible = False
        btnCancelLoad.Enabled = False
        btnCancelLoad.Visible = False
        klboverview.Text = g_curdispmovie.pplotoutline
        kgPickCorrectShow.Enabled = True
        kgMovieInfo.Enabled = True
        kgImage.Enabled = True
        btnCancel.Visible = True
        btnOK.Visible = True
        'If Not curdispmovie.pimdbnumber Is Nothing Then klblImdbid.Text = curdispmovie.pimdbnumber
        'Me.tbEditableTitle.Text = currentmovie.peditedmoviename
        'Me.tbMovieName.Text = curdispmovie.getmoviename
        'khgMovieNameGroup.ValuesPrimary.Heading = curdispmovie.getmoviename 'moviename to group box label area
        'Me.tbMovieNameE.Text = curdispmovie.getmoviename
        'Me.tbCredits.Text = curdispmovie.pcredits
        Me.tbDirector.Text = g_curdispmovie.pdirector
        Me.tbGenre.Text = g_curdispmovie.pgenre
        Me.tbIMDBID.Text = g_curdispmovie.pimdbnumber
        Me.tbMpaa.Text = g_curdispmovie.pmpaa
        'Me.rtbPlotOutline.Text = curdispmovie.pplotoutline
        Me.rtbplot.Text = g_curdispmovie.pplot
        Me.tbRating.Text = g_curdispmovie.prating
        Me.tbOriginalTitle.Text = g_curdispmovie.poriginaltitle
        Me.tbRuntime.Text = g_curdispmovie.pruntime
        Me.rtbTagline.Text = g_curdispmovie.ptagline
        Me.tbVotes.Text = g_curdispmovie.pvotes
        Me.tbStudio.Text = g_curdispmovie.pstudio 'tmovie.ptitle
        Me.tbyear.Text = g_curdispmovie.pyear.ToString
        Me.tbTop250.Text = g_curdispmovie.ptop250
        Me.tbTrailer.Text = g_curdispmovie.ptrailer
    End Sub
    Private Sub loadpreview(ByRef whatmovie As movie)
        If bwloadimage.CancellationPending Then Exit Sub
        If Not whatmovie.pdownloadlist.Count = 0 Then
            If bwloadimage.CancellationPending Then Exit Sub
            Dim curdlobj As New miplibfc.mip.dlobject
            If bwloadimage.CancellationPending Then Exit Sub
            curdlobj = CType(whatmovie.pdownloadlist.Item(0), miplibfc.mip.dlobject)
            If bwloadimage.CancellationPending Then Exit Sub
            pbPreviewImage.ImageLocation = curdlobj.URL
            If bwloadimage.CancellationPending Then Exit Sub
            pbPreviewImage.Load()
        Else
            pbPreviewImage.ImageLocation = Nothing
            pbPreviewImage.Image = Nothing
        End If
    End Sub
    Public Sub displayshowdata(ByVal tid As String)
        'Dim thetvtvseries As thetvdb.TvSeries = CType(dhashtable(CStr(klbPickTheMovie.SelectedValue)), thetvdb.TvSeries)

        'get the data about that movie
        Dim curdispmovie As New movie
        If bwloadimage.CancellationPending Then Exit Sub
        curdispmovie = getmovieinfo(tid)
        If bwloadimage.CancellationPending Then Exit Sub
        curdispmovie.pdownloadlist = New ArrayList
        If bwloadimage.CancellationPending Then Exit Sub
        maincollection.downloadtmdbposter_single(curdispmovie, , , True, True)
        If bwloadimage.CancellationPending Then Exit Sub
        loadpreview(curdispmovie)
        If bwloadimage.CancellationPending Then Exit Sub
        g_curdispmovie = curdispmovie
        If bwloadimage.CancellationPending Then Exit Sub
        'klblAirDay.Text = thetvtvseries.FirstAired
        'klblRunTime.Text = thetvtvseries.Time
        'klbllang.Text = thetvtvseries.language
       
        'pbBanner.ImageLocation = "http://www.thetvdb.com/banners/" + thetvtvseries.banner
    End Sub

    Private Function getmovieinfo(ByVal curid As String) As movie
        Dim tempmovie As New movie
        tempmovie.pimdbnumber = curid
        Debug.Print("checking cache for imdb info")
        If File.Exists(maincollection.rconf.imdbcachefolder + "/" + curid + ".xml") Then 'And Not cbOverwriteNFO.Checked Then
            Debug.Print(".xml already exsists") ' + cbOverwriteNFO.Checked.ToString)
        Else
            '' If Me.messageprompts Then lblPbar.Text = "-- NO XML Cached: Connecting to IMDB: " + dname + "--"
            ''If Me.messageprompts Then Me.Refresh()()
            '    'no nfo so get the data
            'If Me.messageprompts Then lblPbar.Text = "-- Searching IMDB: " + dname + "--"
            'If Me.messageprompts Then Me.Refresh()
            'Dim tstringofimdbpage As String = getimdbidsearch(dname)
            'If Me.messageprompts Then lblPbar.Text = "-- Gathering IMDB: " + dname + "--"
            'If Me.messageprompts Then Me.Refresh()
            'currentmovie.pimdbnumber = snagimdbid_dlg(dname, currentmovie, tstringofimdbpage)
            'snagyear(dname, currentmovie, tstringofimdbpage)

            '' getimdbdata(tmovie)
            Dim imdbinfo As New IMDB
            Dim imdbidtemp As String = tempmovie.getimdbid
            If imdbidtemp = "" Then
                'If Me.messageprompts Then MsgBox("NO IMDB DATA FOUND, UNABLE TO SAVE NFO FILE")
                Debug.Print("NO IMDBID, UNABLE TO SAVE NFO FILE")
            Else
                'If Me.messageprompts Then lblPbar.Text = "-- Parsing IMDB: " + dname + "--"
                'If Me.messageprompts Then Me.Refresh()
                imdbinfo = maincollection.imdbparse(imdbidtemp)
                'save xml to imdbcache reguardless of gui setting to write nfo
                ' tmovie.Actors = imdbinfo.Actors
                imdbinfo.writeIMDBXML(imdbinfo, tempmovie, maincollection.rconf.imdbcachefolder, True)
                'If cbSaveNFO.Checked Then
                '    'imdbinfo.writeIMDBXML(imdbinfo, tmovie)
                '    tmovie.saveimdbinfo(tmovie)
                'End If
            End If
        End If
        'get the imdbdata and set the movie object
        If File.Exists(maincollection.rconf.imdbcachefolder + tempmovie.pimdbnumber + ".xml") Then
            Dim timdb As New IMDB
            timdb.readIMDBXML(tempmovie, maincollection.rconf.imdbcachefolder) 'parses movie from the xml file
        Else
            Debug.Print("display movie name and info - no movie nfo file found")
        End If
        Return tempmovie
    End Function




    Private Sub btnCancelLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelLoad.Click
        bwloadimage.CancelAsync()
    End Sub

    Private Sub dialogMovieSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.tbDirector.Text = "" 'g_curdispmovie.pdirector
        Me.tbGenre.Text = "" 'g_curdispmovie.pgenre
        Me.tbIMDBID.Text = "" 'g_curdispmovie.pimdbnumber
        Me.tbMpaa.Text = "" 'g_curdispmovie.pmpaa
        'Me.rtbPlotOutline.Text = curdispmovie.pplotoutline
        Me.rtbplot.Text = "" 'g_curdispmovie.pplot
        Me.tbRating.Text = "" 'g_curdispmovie.prating
        Me.tbOriginalTitle.Text = "" 'g_curdispmovie.poriginaltitle
        Me.tbRuntime.Text = "" 'g_curdispmovie.pruntime
        Me.rtbTagline.Text = "" 'g_curdispmovie.ptagline
        Me.tbVotes.Text = "" 'g_curdispmovie.pvotes
        Me.tbStudio.Text = "" 'g_curdispmovie.pstudio 'tmovie.ptitle
        Me.tbyear.Text = "" 'g_curdispmovie.pyear.ToString
        Me.tbTop250.Text = "" 'g_curdispmovie.ptop250
        Me.tbTrailer.Text = "" 'g_curdispmovie.ptrailer
        pbPreviewImage.Image = Nothing
        pbPreviewImage.ImageLocation = Nothing
    End Sub
End Class
