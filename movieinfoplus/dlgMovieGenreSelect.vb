Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports movieinfoplus.thegenre
Imports System.IO

Public Class dlgMovieGenreSelect
    Dim strArrayListUsedGenres As New ArrayList
    Public gvMyGenres As New mygenres
    Private curMovie As movie
    Private Sub loadmygneres(ByVal basefolder As String)
        'If there is no mygenres.xml, create the base version
        Dim mygenresxml As String = basefolder + "mygenres.xml"
        If Not File.Exists(mygenresxml) Then
            creatdefaultgenres(mygenresxml)
        End If
        Try
            gvMyGenres = gvMyGenres.getmygenres(mygenresxml) 'loads the xml
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        If gvMyGenres Is Nothing Then
            'something must be wrong in the xml, back it up and generate a new one
            Try 'try to move it to the bakupfile
                Dim t As TimeSpan = (DateTime.UtcNow - New DateTime(1970, 1, 1))
                Dim timestamp As Double = t.TotalSeconds
                Dim srcFile As String = mygenresxml
                Dim dstFile As String = basefolder + "mygenres." + timestamp.ToString + ".bakup.xml"
                File.Move(srcFile, dstFile)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            creatdefaultgenres(mygenresxml)
            gvMyGenres = gvMyGenres.getmygenres(mygenresxml) 'loads the xml
        End If
    End Sub
    Private Sub creatdefaultgenres(ByRef pathtoxml As String)
        Dim cdgMyGenres As New mygenres
        Dim objDG As Object()
        objDG = New Object() {"480p", "540p", "720p", "1080p", "Action", "Adventure", "Animation", "Biography", "Childrens Shows", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Game-Show", "History", "Home Videos", "Horror", "Kids Stuff", "Music", "Musical", "Music Videos", "Mystery", "News", "Reality-TV", "Romance", "Sci-Fi", "Short", "Sport", "Talk-Show", "Thriller", "War", "Western"}
        For Each strObj As String In objDG
            cdgMyGenres.genres.Add(strObj)
        Next
        cdgMyGenres.saveConfig(cdgMyGenres, pathtoxml)
    End Sub
    Public Sub prepop(ByRef tmovie As movie, ByRef basefolder As String)
        curMovie = tmovie
        loadmygneres(basefolder)
        If tmovie.pgenre = "" Then Exit Sub
        'cleanup any old items in lists
        Me.lbAllGenre.Items.Clear()
        Me.lbSelectedGenre.Items.Clear()
        strArrayListUsedGenres.Clear()

        Dim fnPeices1() As String = tmovie.pgenre.Split(CChar(" / "))
        Dim tgeneres As New thegenre.mygenres
        For Each vgenre As String In fnPeices1
            If Not vgenre = "/" Then
                strArrayListUsedGenres.Add(vgenre)
                Me.lbSelectedGenre.Items.Add(vgenre)
                Debug.Print("MovieGenre: " + vgenre)
            End If
        Next
        'remove it from the gvMyGenres list
        For Each stockgenre As String In gvMyGenres.genres
            Dim inuse As Boolean = False
            For Each usedgenre As String In strArrayListUsedGenres
                'Debug.Print(stockgenre + " -- > " + usedgenre)
                If stockgenre = usedgenre Then
                    Debug.Print("---> Matched: " + stockgenre + " -- > " + usedgenre)
                    inuse = True
                End If
            Next
            If Not inuse Then
                lbAllGenre.Items.Add(stockgenre)
            End If
        Next
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim newgenre As String = ""
        For Each pickedgenre In lbSelectedGenre.Items
            newgenre += pickedgenre.ToString + " / "
        Next
        If newgenre.Length > 3 Then
            newgenre = Strings.Left(newgenre, newgenre.Length - 3)
        End If
        'MsgBox(newgenre)
        curMovie.pgenre = newgenre
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lbAllGenre_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAllGenre.MouseClick
        If lbAllGenre.SelectedItem Is Nothing Then Exit Sub
        lbSelectedGenre.Items.Add(lbAllGenre.SelectedItem)
        lbAllGenre.Items.Remove(lbAllGenre.SelectedItem)
        lbSelectedGenre.Sorted = True
    End Sub

    Private Sub kbtnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtnRemoveAll.Click
        Me.lbSelectedGenre.Items.Clear()
        Me.lbAllGenre.Items.Clear()
        'fill the all list
        For Each stockgenre As String In gvMyGenres.genres
            Me.lbAllGenre.Items.Add(stockgenre)
        Next
        'Me.lbAllGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Game-Show", "History", "Horror", "Music", "Musical", "Mystery", "News", "Reality-TV", "Romance", "Sci-Fi", "Short", "Sport", "Talk-Show", "Thriller", "War", "Western"})
    End Sub

    Private Sub lbSelectedGenre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSelectedGenre.Click
        If lbSelectedGenre.SelectedItem Is Nothing Then Exit Sub
        lbAllGenre.Items.Add(lbSelectedGenre.Items.Item(lbSelectedGenre.SelectedIndex))
        lbAllGenre.Sorted = True
        lbSelectedGenre.Items.Remove(lbSelectedGenre.Items.Item(lbSelectedGenre.SelectedIndex))
    End Sub
End Class
