Imports System.Data
Imports System.IO


Public Class mymovies
    Public mwi As New DataTable
    Private Sub getalldata()
        Dim dtIDA As New DataTable
        dtIDA.Columns.Add("Path", GetType(System.String))
        dtIDA.Columns.Add("Name")
        dtIDA.Columns.Add("Index")
        'dtIDA.Columns.Add("objMovie")

        Dim coulistedmovies As Integer = 0
        While coulistedmovies < lbMyMovies.Items.Count
            Dim movhasissues As Boolean = False
            Dim whatissue As String = ""
            Dim tempmovie As New movie
            lbMyMovies.SelectedIndex = coulistedmovies
            tempmovie = CType(maincollection.movies(CInt(lbMyMovies.SelectedValue)), movie)
            Dim tmpath As String = tempmovie.getmoviepath + "\" + tempmovie.pmoviename + ".nfo"
            Dim nmov As New movieinfoplus.mip.mov.Mov
            Try
                nmov = nmov.getmov(tmpath)
                'nmov.printToString() 'debug.output
            Catch ex As Exception
                'MsgBox("No nfo could be parsed for: " + tempmovie.pmoviename)
                'nfo could not be loaded or failed, mark movie as movhasissues
                movhasissues = True
                whatissue += "NFO-"
            End Try
            If Not File.Exists(tempmovie.getmoviepath + "\folder.jpg") Then
                movhasissues = True
                whatissue += "FolderIcon-"
            End If
            If Not File.Exists(tempmovie.getmoviepath + "\" + tempmovie.pmoviename + "-fanart.jpg") Then
                movhasissues = True
                whatissue += "Fanart-"
            End If
            If Not File.Exists(tempmovie.getmoviepath + "\" + tempmovie.pmoviename + ".tbn") Then
                movhasissues = True
                whatissue += "No TBN-"
            End If
            If movhasissues Then
                dtIDA.LoadDataRow(New Object() {tempmovie.getmoviepath, tempmovie.pmoviename + ": " + whatissue, lbMyMovies.SelectedValue}, True)
            End If
            coulistedmovies += 1
        End While

        'dtIDA.DefaultView.Sort = "Description"
        dtIDA.DefaultView.Sort = "Name"
        lbMoviesWithIssues.DataSource = dtIDA.DefaultView
        lbMoviesWithIssues.DisplayMember = "Name"
        lbMoviesWithIssues.ValueMember = "Index"
        mwi = dtIDA
    End Sub

    Private Sub lbMyMovies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMyMovies.MouseDoubleClick
        Debug.Print(CStr(lbMyMovies.SelectedValue)) '.Item(lbMyMovies.SelectedIndex).
        Dim tempmovie As New movie
        'tempmovie = CType(movies(cbox1.SelectedIndex), movie)
        tempmovie = CType(maincollection.movies(CInt(lbMyMovies.SelectedValue)), movie)
        Debug.Print(tempmovie.pmoviename + " " + tempmovie.getmoviepath + " yes" + tempmovie.pyear.ToString + tempmovie.pimdbnumber)
        'Debug.Print("setting a year bValueack to item")
        'tempmovie.pyear = 2008
        'read nfo file in folder
        Dim tmpath As String = tempmovie.getmoviepath + "\" + tempmovie.pmoviename + ".nfo"
        Dim nmov As New movieinfoplus.mip.mov.Mov
        Try
            nmov = nmov.getmov(tmpath)
        Catch ex As Exception
            MsgBox("no nfo could be parsed")
        End Try
        '        nmov.printToString()

        'mainform.movies(CInt(lbMyMovies.SelectedValue)) = nmov

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getalldata()
    End Sub

    Private Sub fixmovieswithissues()
        '? need to determine how to automate fixing ... maybe autopilot?

    End Sub
    Private Sub lbMoviesWithIssues_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMoviesWithIssues.MouseDoubleClick
        Debug.Print(lbMoviesWithIssues.SelectedValue.ToString)
        Debug.Print(maincollection.cbox1.SelectedIndex.ToString)
        maincollection.changecbox1index(CInt(lbMoviesWithIssues.SelectedValue))
        'mainform.cbox1.SelectedIndex = CInt(lbMyMovies.SelectedValue)
        maincollection.processdropdownitems()
        Debug.Print(maincollection.cbox1.SelectedIndex.ToString)

    End Sub

    Private Sub lbMyMovies_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMyMovies.SelectedIndexChanged

    End Sub
End Class