Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports movieinfoplus.thestudio
Imports System.IO
Imports System.Data

Public Class dlgMovieStudioSelect
    Dim strArrayListUsedstudio As New ArrayList
    Public gvMystudios As New mystudios
    Private curMovie As movie
    Private Sub loadmystudios(ByVal basefolder As String)
        'If there is no mystudios.xml, create the base version
        Dim mystudiosxml As String = basefolder + "mystudios.xml"
        If Not File.Exists(mystudiosxml) Then
            creatdefaultstudios(mystudiosxml)
        End If
        Try
            gvMystudios = gvMystudios.getmystudio(mystudiosxml) 'loads the xml
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        If gvMystudios Is Nothing Or Not gvMystudios.version = 1.01 Then
            'something must be wrong in the xml or it's an old version, back it up and generate a new one
            Try 'try to move it to the bakupfile
                Dim t As TimeSpan = (DateTime.UtcNow - New DateTime(1970, 1, 1))
                Dim timestamp As Double = t.TotalSeconds
                Dim srcFile As String = mystudiosxml
                Dim dstFile As String = basefolder + "mystudios." + timestamp.ToString + ".bakup.xml"
                File.Move(srcFile, dstFile)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            creatdefaultstudios(mystudiosxml)
            gvMystudios = gvMystudios.getmystudio(mystudiosxml) 'loads the xml
        End If
    End Sub

    Private Sub creatdefaultstudios2(ByRef pathtoxml As String)
        Dim cdgmystudios As New mystudios
        Dim objDG As Object()
        objDG = New Object() {" bluray", " sddvd", "20th Century Fox", "Universal", "FilmFour", "Channel Four", "Disney", "Gaumont", "United Artists", "New Line Cinema", "Dimension", "Touchstone", "Hollywood Pictures", "Carolco", "Revolution", "Lakeshore Entertainment", "Lucasfilm", "Warner Bros", "Tristar", "Castle Rock", "Studio Canal", "Screen Gems", "Comedy Central", "Mayer", "Canal+", "Paramount Pictures", "DreamWorks", "Columbia Pictures", "MGM (Metro Goldwyn Mayer)", "Sony Pictures", "Artisan", "Lionsgate", "Miramax", "Buena Vista", "Fox Searchlight", "Village Roadshow"}
        Dim dtIDA As New DataTable
        'dtIDA.Columns.Add("Path", GetType(System.String))
        dtIDA.Columns.Add("Name")
        'dtIDA.Columns.Add("Index")

        'tblofmovies = dtIDA
        For Each strObj As String In objDG
            'cdgmystudios.studios.Add(strObj)
            dtIDA.LoadDataRow(New Object() {strObj}, True)
        Next
        dtIDA.DefaultView.Sort = "Name"

        'For Each strObjSorted As String In dtIDA.
        '    cdgmystudios.studios.Add(strObjSorted)
        'Next
        Dim RowPosition As Integer = 0
        While RowPosition < dtIDA.Rows.Count
            cdgmystudios.studios.Add(dtIDA.Rows(RowPosition)("Name").ToString)
            RowPosition += 1

        End While


        cdgmystudios.saveConfig(cdgmystudios, pathtoxml)
    End Sub
    Private Sub creatdefaultstudios(ByRef pathtoxml As String)
        Dim cdgmystudios As New mystudios
        Dim objDG As Object()
        objDG = New Object() {" bluray", " sddvd", "20th Century Fox", "Universal", "FilmFour", "Channel Four", "Disney", "Gaumont", "United Artists", "New Line Cinema", "Dimension", "Touchstone", "Hollywood Pictures", "Carolco", "Revolution", "Lakeshore Entertainment", "Lucasfilm", "Warner Bros", "Tristar", "Castle Rock Entertainment", "Studio Canal", "Screen Gems", "Comedy Central", "Mayer", "Canal+", "Paramount Pictures", "DreamWorks", "Columbia Pictures", "MGM (Metro Goldwyn Mayer)", "Sony Pictures", "Artisan", "Lionsgate", "Miramax", "Buena Vista", "Fox Searchlight", "Village Roadshow"}
        Dim dtIDA As New DataTable
        dtIDA.Columns.Add("Name")

        Dim studioarray As New ArrayList
        For Each strObj As String In objDG
            Dim newstudio As New mystudio
            newstudio.studio = strObj
            studioarray.Add(newstudio)
        Next
        studioarray.Sort()

        Dim obj As mystudio
        For Each obj In studioarray
            'Console.WriteLine(obj.studio)
            cdgmystudios.studios.Add(obj.studio)
        Next
        cdgmystudios.version = 1.01
        'Dim RowPosition As Integer = 0
        'While RowPosition < dtIDA.Rows.Count
        '    cdgmystudios.studios.Add(dtIDA.Rows(RowPosition)("Name").ToString)
        '    RowPosition += 1

        'End While


        cdgmystudios.saveConfig(cdgmystudios, pathtoxml)
    End Sub
    Public Sub prepop(ByRef tmovie As movie, ByRef basefolder As String)
        curMovie = tmovie
        loadmystudios(basefolder)
        '  If tmovie.pstudioreal = "" Then Exit Sub
        'cleanup any old items in lists
        Me.lbAllStudio.Items.Clear()
        Me.lbSelectedStudio.Items.Clear()
        strArrayListUsedstudio.Clear()
        If tmovie.pstudioreal Is Nothing Then
            If Not tmovie.pstudio Is Nothing Then
                tmovie.pstudioreal = tmovie.pstudio
            Else
                tmovie.pstudioreal = ""
            End If

        End If
        Dim fnPeices1() As String = tmovie.pstudioreal.Split(CChar("/"))
        Dim tstudios As New thestudio.mystudios

        For Each vstudio As String In fnPeices1
            If Not vstudio = "/" Then
                If Not vstudio = " " Then
                    strArrayListUsedstudio.Add(vstudio)
                    Me.lbSelectedStudio.Items.Add(vstudio)
                    Debug.Print("MovieStudio: " + vstudio)
                End If
            End If
        Next
        'remove it from the gvmystudios list
        For Each stockstudio As String In gvMystudios.studios
            Dim inuse As Boolean = False
            For Each usedstudio As String In strArrayListUsedstudio
                'Debug.Print(stockgenre + " -- > " + usedgenre)
                If stockstudio = usedstudio Then
                    Debug.Print("---> Matched: " + stockstudio + " -- > " + usedstudio)
                    inuse = True
                End If
            Next
            If Not inuse Then
                lbAllStudio.Items.Add(stockstudio)
            End If
        Next
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim newstudio As String = ""
        For Each pickedstudio In lbSelectedStudio.Items
            newstudio += pickedstudio.ToString + " / "
        Next
        If newstudio.Length > 3 Then
            newstudio = Strings.Left(newstudio, newstudio.Length - 3)
        End If
        'MsgBox(newgenre)
        curMovie.pstudioreal = newstudio
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lbAllGenre_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAllStudio.MouseClick
        If lbAllStudio.SelectedItem Is Nothing Then Exit Sub
        lbSelectedStudio.Items.Add(lbAllStudio.SelectedItem)
        lbAllStudio.Items.Remove(lbAllStudio.SelectedItem)
        lbSelectedStudio.Sorted = True
    End Sub

    Private Sub kbtnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnRemoveAll.Click
        Me.lbSelectedStudio.Items.Clear()
        Me.lbAllStudio.Items.Clear()
        'fill the all list
        For Each stockgenre As String In gvMystudios.studios
            Me.lbAllStudio.Items.Add(stockgenre)
        Next
        'Me.lbAllGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Game-Show", "History", "Horror", "Music", "Musical", "Mystery", "News", "Reality-TV", "Romance", "Sci-Fi", "Short", "Sport", "Talk-Show", "Thriller", "War", "Western"})
    End Sub

    Private Sub lbSelectedGenre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSelectedStudio.Click
        If lbSelectedStudio.SelectedItem Is Nothing Then Exit Sub
        lbAllStudio.Items.Add(lbSelectedStudio.Items.Item(lbSelectedStudio.SelectedIndex))
        lbAllStudio.Sorted = True
        lbSelectedStudio.Items.Remove(lbSelectedStudio.Items.Item(lbSelectedStudio.SelectedIndex))
    End Sub
End Class
