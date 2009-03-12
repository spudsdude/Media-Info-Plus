Imports System.Text.RegularExpressions
Imports System.IO

Public Class nicecover
    Public Sub generatenicecoversxmlcache(ByRef tempfolder As String, ByRef xmlfolder As String)
        Dim lastpage As Integer = 0
        Dim initialpage As Integer = 33
        Dim checkanotherpage As Boolean = False
        Dim lastpageurl As String = ""

        'find the last page
        lastpage = initialpage
        checkanotherpage = getlastpagefornicecovers(lastpage, 0, tempfolder)

        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 5, tempfolder)
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 10, tempfolder)
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 25, tempfolder)
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 50, tempfolder)
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 75, tempfolder) 'accounts for up to 188 pages
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 100, tempfolder) 'accounts for up to 288 pages
        End If
        If checkanotherpage Then
            checkanotherpage = getlastpagefornicecovers(lastpage, 250, tempfolder) 'accounts for up to 438 pages (10x the sites current value)
        End If

        'now that we have the last page, we loop through each page and parse the data
        Dim arrayofnicecovernames As New ArrayList
        Dim curcount As Integer = 0
        While curcount < lastpage
            getnamefromnicecovers(curcount, arrayofnicecovernames, tempfolder)
            curcount += 1
        End While

        'generate posterxml for nicecovers
        For Each nicecovername As String In arrayofnicecovernames
            Dim posterlink As String = ""
            posterlink = "http://www.nicecovers.com/srce/" + Strings.Replace(nicecovername, "-", "") + ".jpg"
            'create object
            Dim newncposter As New nicecoverposters
            newncposter.pmoviename = nicecovername
            newncposter.pposters.Add(posterlink)
            'save object
            newncposter.writeXML(newncposter, xmlfolder, False)
            'done
        Next

    End Sub

    Private Function getlastpagefornicecovers(ByRef lastpage As Integer, ByVal increment As Integer, ByVal folder As String) As Boolean
        Dim retcheckanotherpage As Boolean = False
        Dim pageurl As String = ""
        Dim results As String = ""
        pageurl = "http://nicecovers.com/movie-index/?pgno=" + CStr(lastpage + increment)
        'get page data, parse it
        If File.Exists(folder + "ncpage" + lastpage.ToString) Then File.Delete(folder + "ncpage" + lastpage.ToString)
        dlgDownloadingFile.downloadertxtFileName.Text = pageurl
        dlgDownloadingFile.whereToSave = folder + "ncpage" + lastpage.ToString
        dlgDownloadingFile.ShowDialog()
        results = File.ReadAllText(folder + "ncpage" + lastpage.ToString)
        Try
            Dim RegexObj2 As New Regex("<a href=""http://nicecovers.com/movie-index/\?pgno=(\d{1,3})"">\d{1,3}</a>")
            Dim MatchResults2 As Match = RegexObj2.Match(results)
            While MatchResults2.Success
                Dim i As Integer
                For i = 1 To MatchResults2.Groups.Count
                    Dim GroupObj2 As Group = MatchResults2.Groups(i)
                    If GroupObj2.Success Then
                        If CInt(GroupObj2.Value) > lastpage Then
                            lastpage = CInt(GroupObj2.Value)
                            retcheckanotherpage = True
                        End If
                    End If
                Next
                MatchResults2 = MatchResults2.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Debug.Print(lastpage.ToString)

        Return retcheckanotherpage
    End Function

    Private Sub getnamefromnicecovers(ByVal page As Integer, ByRef arrayofnicecovernames As ArrayList, ByVal folder As String)
        Dim pageurl As String = ""
        Dim results As String = ""
        pageurl = "http://nicecovers.com/movie-index/?pgno=" + CStr(page)
        'wget pageurl then parse it
        If File.Exists(folder + "ncpage" + page.ToString) Then File.Delete(folder + "ncpage" + page.ToString)
        dlgDownloadingFile.downloadertxtFileName.Text = pageurl
        dlgDownloadingFile.whereToSave = folder + "ncpage" + page.ToString
        dlgDownloadingFile.ShowDialog()
        results = File.ReadAllText(folder + "ncpage" + page.ToString)

        Try
            Dim RegexObjName As New Regex("<a href=""http://(?:www.)?nicecovers.com/(?<name>.*?)/""><span class=""head"">")
            Dim MatchResultsName As Match = RegexObjName.Match(results)
            While MatchResultsName.Success
                Dim i As Integer
                For i = 1 To MatchResultsName.Groups.Count
                    Dim GroupObjName As Group = MatchResultsName.Groups(i)
                    If GroupObjName.Success Then
                        arrayofnicecovernames.Add(GroupObjName.Value.ToString)
                    End If
                Next
                MatchResultsName = MatchResultsName.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

    End Sub
End Class
