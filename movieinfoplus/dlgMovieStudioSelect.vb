Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports movieinfoplus.thestudio
Imports System.IO

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
        If gvMystudios Is Nothing Then
            'something must be wrong in the xml, back it up and generate a new one
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
    Private Sub creatdefaultstudios(ByRef pathtoxml As String)
        Dim cdgmystudios As New mystudios
        Dim objDG As Object()
        objDG = New Object() {"20th Century Fox", "Universal", "FilmFour", "Disney", "Gaumont", "United Artists", "New Line Cinema", "Dimension", "Touchstone", "Hollywood Pictures", "Carolco", "Revolution", "Lakeshore Entertainment", "Lucasfilm", "Screen Gems", "Warner Bros", "Tristar", "Castle Rock", "Studio Canal", "Canal+", "Paramount Pictures", "DreamWorks", "Columbia Pictures", "MGM (Metro Goldwyn Mayer)", "Sony Pictures", "Artisan", "Lionsgate", "Miramax"}
        For Each strObj As String In objDG
            cdgmystudios.studios.Add(strObj)
        Next
        cdgmystudios.saveConfig(cdgmystudios, pathtoxml)
    End Sub
    Public Sub prepop(ByRef tmovie As movie, ByRef basefolder As String)
        curMovie = tmovie
        loadmystudios(basefolder)
        If tmovie.pgenre = "" Then Exit Sub
        'cleanup any old items in lists
        Me.lbAllStudio.Items.Clear()
        Me.lbSelectedStudio.Items.Clear()
        strArrayListUsedstudio.Clear()

        Dim fnPeices1() As String = tmovie.pstudio.Split(CChar("/"))
        Dim tstudios As New thestudio.mystudios
        For Each vstudio As String In fnPeices1
            If Not vstudio = "/" Then
                strArrayListUsedstudio.Add(vstudio)
                Me.lbSelectedStudio.Items.Add(vstudio)
                Debug.Print("MovieStudio: " + vstudio)
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
        curMovie.pstudio = newstudio
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
