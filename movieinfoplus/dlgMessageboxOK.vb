Imports System.Windows.Forms
Imports System.IO
Imports System.Text.RegularExpressions

Public Class dlgMessageboxOK
    Public failedfiles As New List(Of showfileobj)
    Public btnEdit As New ComponentFactory.Krypton.Toolkit.KryptonButton
    Private tseason As String = ""
    Private tepisodes As String = ""
    Dim tmultipart As Boolean = False
    ' Dim rconf As New configuration
    Private rescanneeded As Boolean = False
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'If rescanneeded Then
        '    'run update shows command
        '    maincollection.updateshows()
        'End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub dlgMessageboxOK_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Dim test As New showfileobj
        ''test.showname = "Chuck"
        ''test.path = "t:\tvshows\Chuck\Season 1\"
        ''test.filename = "chuck.s1_episode3.avi"
        ''failedfiles.Add(test)
        ''Dim test2 As New showfileobj
        ''test2.showname = "Chuck"
        ''test2.path = "t:\tvshows\Chuck\Season 1\"
        ''test2.filename = "chuck.s1_episode4.avi"
        ''failedfiles.Add(test2)
        'filename As String
        'path As String
        'newname As String
        'newpath As String
        'showid As String
        'showrootfolder As String
        'showname As String
        'writecommit As Boolean
        'Dim curDT As New Data.DataTable
        'curDT.Columns.Add("Filename", GetType(String))
        'curDT.Columns.Add("path", GetType(String))
        'curDT.Columns.Add("newname", GetType(String))
        'curDT.Columns.Add("newpath", GetType(String))
        'curDT.Columns.Add("showid", GetType(String))
        'curDT.Columns.Add("showrootfolder", GetType(String))
        'curDT.Columns.Add("showname", GetType(String))
        'curDT.Columns.Add("writecommit", GetType(String))
        For Each curfile As showfileobj In failedfiles
            dgFiles.Rows.Add(curfile.showname, curfile.path, curfile.filename, "")
            'Dim curRow As Data.DataRow
            'curRow = dgFiles.Rows.GetNextRow(cou
            'curRow.Item(0) = "asdf"
            'curRow.Item(1) = "A"
            'curRow.Item(2) = "M"
            'curRow.Item(3) = "5/15/65"
            'curRow.Item(4) = "40000"
            'dgFiles.Rows.Add(curRow)
        Next
        ' dgFiles.DataSource = curDT
        'Add Button to the Control collection of the DataGrid.

    End Sub
    'Private Sub btnEditClicked(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MsgBox("click")
    'End Sub
    'Private Sub dgFiles_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgFiles.Paint
    '    If dgFiles.CurrentCell.ColumnIndex = 3 Then
    '        ' btnEdit.Width = dgFiles.GetCurrentCellBounds.Width
    '        btnEdit.Visible = True
    '    End If
    'End Sub
    Private Function addfiletofolder(ByVal tvar_path As String, ByVal tvar_filename As String) As String
        If Not Strings.Right(tvar_path, 1) = "\" Then
            tvar_path += "\"
        End If
        Dim rFullPath As String = tvar_path + tvar_filename
        Return rFullPath
    End Function

    Private Function parsefileforepdata(ByVal item As String) As Boolean
        tseason = ""
        tepisodes = ""
        tmultipart = False
       
        Try

            Dim fnPeices1() As String = item.ToString.Split(CChar("\"))
            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)
            Select Case Strings.Right(tfname, 4).ToLower
                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"
                    Dim tfnameoffile As String = fnPeices1(fnPeices1.Length - 1)
                    Debug.Print(tfnameoffile)
                    Dim haveseason As Boolean = False
                    Dim haveepisode As Boolean = False
                    Dim ctv_season As String = ""
                    Dim ctv_episode As String = ""
                    Dim multiepisode As Boolean = False
                    Dim numofepisodes As Integer = 0
                    Try
                        ctv_season = Regex.Match(tfnameoffile, "(?<season>\d{1,2})[-EeXx](?<episode>[0-9]+)", RegexOptions.IgnoreCase).Groups("season").Value
                        If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)

                        Try
                            Dim RegexObject1 As New Regex("[-EeXx]([0-9]+)")
                            Dim MObj As Match = RegexObject1.Match(tfnameoffile)
                            While MObj.Success
                                Dim GObj As Group = MObj.Groups(1)
                                If GObj.Success Then
                                    numofepisodes += 1
                                    If numofepisodes > 1 Then
                                        ctv_episode += ":" + MObj.Groups(1).Value
                                    Else
                                        ctv_episode = MObj.Groups(1).Value 'Regex.Match(tfnameoffile, "[-EeXx](?<episode>[0-9]+)", RegexOptions.IgnoreCase).Groups("episode").Value
                                    End If
                                End If
                                MObj = MObj.NextMatch()
                            End While
                        Catch ex As ArgumentException
                            Return False
                        End Try
                        If numofepisodes > 1 Then
                            multiepisode = True
                        Else
                            multiepisode = False
                        End If

                        If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)

                        If Not ctv_season = "" Then haveseason = True
                        If Not ctv_episode = "" Then haveepisode = True
                        If Not (haveepisode And haveseason) Then
                            haveepisode = False
                            haveseason = False
                        End If
                    Catch ex As ArgumentException
                        Return False
                    End Try


                    If Not (haveseason And haveepisode) Then
                        Try
                            ctv_season = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("season").Value
                            ' If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 season resulted in :" + ctv_season
                            ctv_episode = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("episode").Value
                            ' If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 episode resulted in :" + ctv_episode
                            If Not ctv_season = "" Then haveseason = True
                            If Not ctv_episode = "" Then haveepisode = True
                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                            If Not (haveepisode And haveseason) Then
                                haveepisode = False
                                haveseason = False
                            End If
                            multiepisode = False
                        Catch ex As ArgumentException
                            Return False
                        End Try
                        'if it has season and episode, then write nfo and tbn for it

                    End If
                    If Not (haveseason And haveepisode) And Not maincollection.rconf.ptvregx1 = "" Then
                        Try
                            ctv_season = Regex.Match(tfnameoffile, maincollection.rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(1).Value
                            If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
                            'If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex season resulted in :" + ctv_season
                            Debug.Print("Regex3 season resulted in :" + ctv_season)
                            ctv_episode = Regex.Match(tfnameoffile, maincollection.rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(2).Value
                            ' If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex episode resulted in :" + ctv_episode
                            Debug.Print("Regex3 episode resulted in :" + ctv_episode)
                            If Not ctv_season = "" Then haveseason = True
                            If Not ctv_episode = "" Then haveepisode = True
                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                            If Not (haveepisode And haveseason) Then
                                haveepisode = False
                                haveseason = False
                            End If
                        Catch ex As ArgumentException
                            Return False
                        End Try
                    End If
                    If Not (haveepisode And haveepisode) Then Return False

                    If (haveepisode And haveseason) And Not multiepisode Then
                        If ctv_episode = "0" Then ctv_episode = "00"
                        tseason = ctv_season
                        tepisodes = ctv_episode

                    ElseIf (haveepisode And haveseason) And multiepisode Then 'multiepisode
                        Dim curxbmcmultiepisode As New xbmc.xbmcmultiepisode
                        tseason = ctv_season
                        tmultipart = True
                        Dim epPeices() As String = ctv_episode.Split(CChar(":"))
                        Dim epcoutot As Integer = epPeices.Length
                        Dim curepcou As Integer = 0
                        While curepcou < epcoutot
                            Dim ctv_episodepiece As String = epPeices(curepcou)
                            'get 2 digit version of episode data
                            If Strings.Left(ctv_episodepiece, 1) = "0" And ctv_episodepiece.Length >= 1 Then
                                ctv_episodepiece = Strings.Right(ctv_episodepiece, ctv_episodepiece.Length - 1)
                            End If
                            If ctv_episodepiece = "0" Then ctv_episodepiece = "00"
                            tepisodes += ctv_episodepiece & " | "
                            curepcou += 1

                        End While
                        Dim curpath As String = item 'maincollection.getfilefrompath(item)
                        Try
                            curxbmcmultiepisode.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End If

                Case Else
                    Return False
            End Select
        Catch ex As Exception 'catch bad filename or location exception
            Return False
        End Try
        'Next
        Return True
    End Function

    Private Function striptvextension(ByVal filename As String) As String
        'removes the extension from a filename
        Return Strings.Left(filename, filename.Length - 4)
    End Function
    Private Sub dgFiles_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFiles.CellContentClick
        'MsgBox(dgFiles.CurrentCell.ColumnIndex.ToString)
        'add check to ensure we are in colum 5
        If dgFiles.CurrentCell.ColumnIndex = 4 Then
            'MsgBox("hi")
            Dim str1 As String = ""
            Dim currow As New DataGridViewRow
            currow = dgFiles.CurrentRow
            str1 += currow.Cells(0).Value.ToString + vbNewLine
            str1 += currow.Cells(1).Value.ToString + vbNewLine
            str1 += currow.Cells(2).Value.ToString + vbNewLine
            str1 += currow.Cells(3).Value.ToString + vbNewLine
            'str1 += currow.Cells(4).Value
            If currow.Cells(3).Value.ToString = "Sucessfully Renamed" Then Exit Sub
            Dim oldfilename As String = addfiletofolder(currow.Cells(1).Value.ToString, currow.Cells(2).Value.ToString)
            Dim newfilename As String = addfiletofolder(currow.Cells(1).Value.ToString, currow.Cells(3).Value.ToString)
            'make sure we can determine what the file is
            Dim couldparse As Boolean = True 'allows renaming, changed if it fails to parse
            If Not parsefileforepdata(newfilename) Then 'currow.Cells(1).Value.ToString & "\" & currow.Cells(3).Value.ToString) Then
                MsgBox("I could not figure out Season and Episode information with that filename, please check the name again.")
                couldparse = False
                Exit Sub 'no need to continue, it doesn't parse correctly
            End If

            If Not File.Exists(oldfilename) Then Exit Sub
            If File.Exists(newfilename) Then
                MsgBox("A file with that name already exists, unable to rename the file.")
                Exit Sub
            End If
            If couldparse Then
                Try
                    File.Move(oldfilename, newfilename)
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
            End If
            If couldparse Then
                Try
                    If File.Exists(striptvextension(oldfilename) & ".srt") Then
                        File.Move(striptvextension(oldfilename) & ".srt", striptvextension(newfilename) & ".srt")
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
            End If

            If File.Exists(newfilename) And Not File.Exists(oldfilename) Then
                rescanneeded = True 'forces rescan on close
                lblrescanrequired.Text = "After clicking 'OK', please click on he 'Update Shows' button to update any renamed episode's."
                currow.Cells(2).Value = currow.Cells(3).Value
                currow.Cells(3).Value = "Sucessfully Renamed"
                'currow.Cells(4).ReadOnly = True
                'currow.Cells(3).ReadOnly = True
                currow.Cells(5).Value = tseason
                currow.Cells(6).Value = tepisodes
                If tmultipart Then
                    currow.Cells(7).Value = "MULITPART"
                Else
                    currow.Cells(7).Value = "N/A"
                End If

            End If
            'MsgBox(str1)

        End If

    End Sub
End Class
