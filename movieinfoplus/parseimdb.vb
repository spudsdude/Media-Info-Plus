Imports System.IO
Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports System.Net
Imports movieinfoplus.maincollection


Public Class parseimdb
    'all default folders
    Public basefolder As String = "c:\Program Files\movieinfoplus\"
    Public thirdpartyfolder As String = basefolder + "3rdparty\" '3rdparty foldder conf
    Public xmlmainfolder As String = basefolder + "xml\"
    Public cachefolder As String = basefolder + "cache\"
    Public tempfolder As String = basefolder + "temp\"

    Public xmlfolder As String = xmlmainfolder + "xmls\"
    Public xmlfolderposters As String = xmlmainfolder + "posterxmls\"
    Public xmlfolderimdb As String = xmlmainfolder + "imdbxmls\"

    Public iconcachefolder As String = cachefolder + "iconcache\"
    Public postercachefolder As String = cachefolder + "postercache\"
    Public imdbcachefolder As String = cachefolder + "imdbcache\"

    Public listsfolder As String = thirdpartyfolder + "lists\"
    Public listsTempfolder As String = tempfolder + "lists\"

    Public sevenzipfolder As String = thirdpartyfolder + "7zip\"
    Public wgetfolder As String = thirdpartyfolder + "wget\"
    Public dirUnRAR As String = thirdpartyfolder + "UnRAR\"

    Public dbfilepath As String = "c:\program files\movieinfoplus\database\"
    Public dblocation_old As String = "c:\program files\movieinfoplus\database\moviespre1970.db3"
    Public dblocation As String = "c:\program files\movieinfoplus\database\movies.db3"
    Public moviesarray As New ArrayList
    Public mainhash As New Hashtable
    Private Sub googlegetimdbid(ByRef tmovieref As movie)
        Try
            'Dim baseurlsiid As String = "http://akas.imdb.com/find?s=all&q=" + tmovie.pmoviename + " (" + tmovie.pyear + ")" + "+&x=0&y=0"
            'Dim s As String
            'Dim pre As String = "http://www.google.com/search?num=2&hl=en&q=++http%3A%2F%2Fus.imdb.com%2FTitle%3F"
            'Dim post As String = "&btnG=Search"
            Dim moviepart As String = tmovieref.pmoviename + "%20%28" + tmovieref.pyear.ToString + "%29"
            moviepart = Strings.Replace(moviepart, "#", "%23")
            'Dim searchstring As String = pre + moviepart + post

            Dim searchstring2 As String = "http://us.imdb.com/Title?" + moviepart
            Dim hashedname As String = (tmovieref.pimdbnumber + tmovieref.pyear.ToString)

            If Not Directory.Exists("f:\hashed\" + tmovieref.pmoviename + " (" + tmovieref.pyear.ToString + ")") Then
                If Not tmovieref.pmoviename.Contains("�") And Not tmovieref.pmoviename.Contains(":") And Not tmovieref.pmoviename.Contains("?") And Not tmovieref.pmoviename.Contains("|") And Not tmovieref.pmoviename.Contains("<") And Not tmovieref.pmoviename.Contains(">") Then wget(searchstring2, "f:\hashed\" + tmovieref.pmoviename + " (" + tmovieref.pyear.ToString + ")\", hashedname.GetHashCode().ToString, False)
                System.Threading.Thread.Sleep(76)
            End If

            'Debug.Print(searchstring2)
            '    Dim request As HttpWebRequest = CType(WebRequest.Create(searchstring2), HttpWebRequest)
            '    Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
            '    Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            '        s = reader.ReadToEnd()
            '    End Using
            '    'Regex(portion)
            '    tmovieref.pimdbnumber = Regex.Match(s, "<cite>www.imdb.com/title/(tt\d{6,7})/").Groups(1).Value
        Catch ex As Exception
            Debug.Print("Error getting IMDBID using google for " + tmovieref.pmoviename + ".")
        End Try

    End Sub
    Private Sub wget(ByRef url As String, ByRef folder As String, ByRef id As String, ByVal wait As Boolean)
        Dim binfilelocal As String = wgetfolder + "wget.exe"
        Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
        If id = "getimdbidsearch" Then
            If File.Exists(tempfolder + "getimdbidsearch\" + "index.html") Then
                File.Delete(tempfolder + "getimdbidsearch\" + "index.html")
            End If
        End If
        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal

        If id = "getimdbidsearch" Then
            pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + folder + id.ToString + "\index.html" + """"
        Else
            pro1.StartInfo.Arguments = """" + url + """" + " -P " + """" + folder '+ id.ToString + """"
        End If

        If File.Exists(tempfolder + "getimdbidsearch\" + "index.html") Then
            File.Delete(tempfolder + "getimdbidsearch\" + "index.html")
        End If



        pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        pro1.Start()
        If wait Then pro1.WaitForExit()
        'System.Diagnostics.Process.Start(binfilelocal, url + " -P " + """" + folder + cou.ToString + """")
        'myProcess.WaitForExit()
    End Sub
    Private Sub downloadimdbpage(ByRef tmovie As movie)
        Dim baseurlsiid As String = "http://akas.imdb.com/find?s=all&q=" + tmovie.pmoviename + "+&x=0&y=0"
        'wget(baseurlsiid, rconf.tempfolder, "getimdbidsearch", True)

    End Sub
    Private Sub btnParseIMDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParseIMDB.Click
        parseimdbmovieslist()
        'parseimdbplots()
    End Sub

    Private Sub parseimdbplots()
        Dim filename As String = listsfolder + "\plot.list" 'tbimdblistfile.Text
        Dim data0() As String = File.ReadAllLines(filename)
        'logic read for 
        Dim counter As Integer = 0
        Dim movies As New ArrayList
        Debug.Print(TimeOfDay.ToString)
        While counter < data0.Length - 1
            Dim tmovie As New movie
            'Debug.Print(data0(counter))
            While counter < data0.Length - 1 And Not Strings.Left(data0(counter), 4) = "----"
                counter += 1
            End While
            While counter < data0.Length - 1 And Not Strings.Left(data0(counter), 4) = "MV: "
                counter += 1
            End While

            If counter >= data0.Length - 1 Then
                Exit While
            End If

            Dim strWork As String = data0(counter)
            tmovie.pmoviename = Regex.Match(strWork, """(.*?)""").Groups(1).Value
            If Not tmovie.pmoviename = "" Then 'moviename is not blank and is in quotes, so it's a tv show
                tmovie.ptype = "TV"
            End If
            If tmovie.pmoviename = "" Then 'try another format for the name
                tmovie.pmoviename = Regex.Match(strWork, "MV: (.*?) [(]").Groups(1).Value
            End If
            'get the type if it's not already set by the name being in quotes
            If tmovie.ptype = "" Then tmovie.ptype = Regex.Match(strWork, "(\(.{1,2}\))").Groups(1).Value
            'if there's a { we need to set it as a TV show with the data for it
            If strWork.Contains("{") Then
                Dim tempseasonbyyear As String = ""
                'try year-mm-dd format first
                tempseasonbyyear = Regex.Match(strWork, "[{][(](\d{4}-\d{2}-\d{1,2})[)][}]").Groups(1).Value()
                If Not tempseasonbyyear = "" Then
                    tmovie.episodename = tempseasonbyyear 'set seasonbyyear as the seasonname
                End If
                'if it's not year-mm-dd try episode num #DIGIT.DIGIT
                If tempseasonbyyear = "" Then
                    tmovie.episodename = Regex.Match(strWork, "[{](.*?)[(]\#(\d{1,4})\.(\d{1,4})[)][}]").Groups(1).Value
                    tmovie.episodenum = Regex.Match(strWork, "[{](.*?)[(]\#(\d{1,4})\.(\d{1,4})[)][}]").Groups(3).Value
                    tmovie.seasonnum = Regex.Match(strWork, "[{](.*?)[(]\#(\d{1,4})\.(\d{1,4})[)][}]").Groups(2).Value
                    'set those combined values to the temp var
                    tempseasonbyyear = tmovie.episodename + tmovie.episodenum + tmovie.seasonnum
                    If tempseasonbyyear = "" Then 'still no value, must just be in {some text thing} format so set that
                        tmovie.episodename = Regex.Match(strWork, "[{](.*?)[}]").Groups(1).Value
                    End If
                End If
            End If

            'if we have data in any of these, it's a movie, so set the type
            If Not tmovie.episodename = "" Then tmovie.ptype = "TV"
            If Not tmovie.episodenum = "" Then tmovie.ptype = "TV"
            If Not tmovie.seasonnum = "" Then tmovie.ptype = "TV"
            Try 'try to get the year, sometimes they use non digits like (????)
                tmovie.pyear = CInt(Regex.Match(strWork, "[(](\d{4})[)]").Groups(1).Value)
            Catch ex As Exception 'must be that dumbass (????) format
                tmovie.pyear = 1
            End Try
            strWork = Nothing

            While counter < data0.Length - 1 And Not Strings.Left(data0(counter), 4) = "PL: "
                counter += 1
            End While

            While counter < data0.Length - 1 And Strings.Left(data0(counter), 4) = "PL: "
                Dim tplot As String = Strings.Mid(data0(counter), 5)
                tmovie.pplot += Strings.Replace(tplot, "�", "")
                tplot = Nothing
                counter += 1
            End While

            'Debug.Print("Name: " + tmovie.pmoviename)
            'Debug.Print("Year: " + tmovie.pyear.ToString)
            'Debug.Print("Plot: " + tmovie.pplot)
            movies.Add(tmovie) 'add movie back, it's done
            counter += 1

        End While
        '
        Debug.Print(TimeOfDay.ToString)
        Debug.Print(movies.Count.ToString)

        Dim themoviecounter As Integer = 0
        For Each themovie As movie In movies
            If themovie.ptype = "" Or themovie.ptype.ToLower = "v" Then
                If Not themovie.pyear = 1 Then 'year is not 1 (set when parsing)

                    Dim hashvalue As String = themovie.pmoviename + themovie.pyear.ToString '    Debug.Print("Name: " + themovie.pmoviename)
                    hashvalue.GetHashCode()
                    Try
                        'mainhash.Item(hashvalue.GetHashCode())
                        Dim tmovieh As movie
                        tmovieh = CType(mainhash.Item(hashvalue.GetHashCode), movie)
                        tmovieh.pplot = themovie.pplot
                        Dim tempimdb As New IMDB
                        tempimdb.movietoimdb(tmovieh)
                        tempimdb.writeIMDBXML()
                        'done
                        'mainhash.Add(hashvalue.GetHashCode(), themovie)
                        'moviesarray.Add(themovie)
                    Catch ex As Exception
                        Debug.Print("Error finding item in hashable" + vbNewLine + themovie.pmoviename + " " + themovie.pyear.ToString)
                        'Debug.Print(themovie.episodename + " s" + themovie.seasonnum + "e" + themovie.episodenum)
                    End Try

                    '    Debug.Print("Year: " + themovie.pyear.ToString)
                    '    Debug.Print("Plot: " + themovie.pplot)
                    themoviecounter += 1
                End If
            Else
                'Debug.Print("NON-Movie: " + themovie.ptype + " for " + themovie.pmoviename)
            End If

        Next

        ''write xmls out
        'Dim cccount As Integer = 0
        'While cccount <= mainhash.Count

        'End While


        'Masoom (1983)
        Exit Sub

        'test below

        Dim key As String = "Masoom" + "1983"
        Dim tmovie2 As New movie
        'tmovie2 = CType(movies(CInt(mainhash.Item(key.GetHashCode))), movie)
        tmovie2 = CType(mainhash.Item(key.GetHashCode), movie)

        'movies(mainhash.Item(key.GetHashCode))
        Debug.Print(tmovie2.pmoviename + vbNewLine + tmovie2.pplot + vbNewLine + tmovie2.pyear.ToString)
        'moviesarray = movies 'set main form array 

        'clear out old value
        mainhash.Remove(key.GetHashCode)
        Debug.Print("trying to change the plot to hiya")
        tmovie2.pplot = "hiya"
        mainhash.Add(key.GetHashCode, tmovie2)

        Dim tmovie3 As movie = CType(mainhash.Item(key.GetHashCode), movie)
        Debug.Print(tmovie3.pmoviename + " : " + tmovie3.pplot)
        tmovie3.pplot = "woooowoowow"

        Dim tmovie4 As movie = CType(mainhash.Item(key.GetHashCode), movie)
        Debug.Print(tmovie4.pmoviename + " : " + tmovie4.pplot)
        'tmovie4.pplot = "woooowoowow"

    End Sub


    Private Sub parseimdbmovieslisttodb()
        Dim filename As String = listsfolder + "\movies.list" 'tbimdblistfile.Text
        Dim data0 As String = File.ReadAllText(filename)
        'Dim Path As String = Application.StartupPath & "\"
        Try
            'Dim RegexObj3 As New Regex("(?<moviename>.*?) \((?<year>\d{4})\)")
            Dim RegexObj3 As New Regex("(?<moviename>.*?) \((?<year>\d{4})\).(?<type>\(.{1,2}\))?")
            Dim MatchResults As Match = RegexObj3.Match(data0)
            Dim counter As Integer = 0
            Dim subcounter As Integer = 0
            Dim moviecount As Integer = 0
            Dim gamecount As Integer = 0
            Dim oldmoviecount As Integer = 0
            Dim newermoviecount As Integer = 0
            Dim tvcount As Integer = 0
            While MatchResults.Success
                Dim GroupObj1 As Group = MatchResults.Groups("moviename")
                Dim GroupObj2 As Group = MatchResults.Groups("year")
                Dim GroupObj3 As Group = MatchResults.Groups("type")
                Dim type As String = GroupObj3.Value.ToLower
                If type = "" Then type = "movie"
                Dim moviename As String = GroupObj1.Value
                Dim movienamelength As Integer = moviename.Length
                sqlmask(moviename) ' = Strings.Replace(moviename, "'", "")
                moviename = Strings.Replace(moviename, ";", "")
                Dim Year As Integer = Convert.ToInt16(GroupObj2.Value)
                If type = "movie" Or type = "(v)" Then
                    SQLStmt = "INSERT INTO imdb (Name,Year)  VALUES ('" + moviename + "','" + Year.ToString + "')"
                    moviecount = moviecount + 1
                ElseIf type = "(tv)" Then
                    ' SQLStmt = "INSERT INTO TMDTV (MovieName,Year)  VALUES ('" + moviename + "','" + Year.ToString + "')"
                    tvcount = tvcount + 1
                ElseIf type = "(vg)" Then
                    'SQLStmt = "INSERT INTO TMDG (MovieName,Year)  VALUES ('" + moviename + "','" + Year.ToString + "')"
                    gamecount = gamecount + 1
                End If
                If Year >= 1970 Then
                    ExecuteSQLStmt(dblocation, SQLStmt, True)
                    newermoviecount += 1
                Else
                    ExecuteSQLStmt(dblocation_old, SQLStmt, True)
                    oldmoviecount += 1
                End If

                counter = counter + 1
                subcounter = subcounter + 1
                If subcounter = 100 Then
                    Debug.Print(counter.ToString)
                    Debug.Print("Movies: " + moviecount.ToString + " -- TV Shows: " + tvcount.ToString + " -- Video Games: " + gamecount.ToString)
                    Debug.Print("Old Movies: " + oldmoviecount.ToString + vbNewLine + "Newer Movies: " + newermoviecount.ToString)
                    subcounter = 0
                End If
                MatchResults = MatchResults.NextMatch()
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub parseimdbmovieslist()
        Dim filename As String = listsfolder + "\movies.list" 'tbimdblistfile.Text
        Dim data0() As String = File.ReadAllLines(filename)
        Dim counter As Integer = 0
        Debug.Print(TimeOfDay.ToString)
        Dim movies As New ArrayList
        Dim tempcount As Integer = 0
        While counter < data0.Length - 1
            If counter >= data0.Length Then
                Exit While
            End If

            If Not Strings.Left(data0(counter), 1) = """" Then
                Dim tmovie As New movie
                Dim strWork As String = data0(counter)
                'Dim tYear As String ', tName, tType As String
                'Dim RegexObject1 As New Regex("(.*?) \((\d{4})\).(\(.{1,2}\))?")
                'tmovie.pmoviename = RegexObject1.Match(strWork).Groups(1).Value
                'tYear = RegexObject1.Match(strWork).Groups(2).Value
                'tmovie.ptype = RegexObject1.Match(strWork).Groups(3).Value
                tmovie.pmoviename = Regex.Match(strWork, "(.*?) \((\d{4})\).(\(.{1,2}\))?").Groups(1).Value
                tmovie.ptype = Regex.Match(strWork, "(.*?) \((\d{4})\).(\(.{1,2}\))?").Groups(3).Value
                If tmovie.ptype = "" Then tmovie.ptype = "V"
                If strWork.Contains("{") Then tmovie.ptype = "TV"

                'if we have data in any of these, it's a movie, so set the type
                Try 'try to get the year, sometimes they use non digits like (????)
                    tmovie.pyear = CInt(Regex.Match(strWork, "[(](\d{4})[)]").Groups(1).Value)
                Catch 'ex As Exception 'must be that dumbass (????) format
                    tmovie.pyear = 1
                End Try
                'strWork = Nothing
                'Debug.Print("Name: " + tmovie.pmoviename)
                'Debug.Print("Year: " + tmovie.pyear.ToString)
                'Debug.Print("Type: " + tmovie.ptype)
                If Not tmovie.pmoviename = "" Then movies.Add(tmovie) 'add movie back, it's done
            End If
            counter += 1
            If tempcount = 50000 Then
                tempcount = 1
                Debug.Print("50k " + TimeOfDay.ToString)
            Else
                tempcount += 1
            End If
        End While
        Debug.Print(TimeOfDay.ToString)
        tempcount = 0
        '
        For Each themovie As movie In movies
            If themovie.ptype = "" Or themovie.ptype.ToLower = "v" Then
                If Not themovie.pyear = 1 And Not themovie.pyear = Nothing Then 'year is not 1 (set when parsing)
                    Dim hashvalue As String = themovie.pmoviename + themovie.pyear.ToString '    Debug.Print("Name: " + themovie.pmoviename)
                    hashvalue.GetHashCode()
                    ' '' ''If themovie.pyear >= 1998 Then googlegetimdbid(themovie) 'get imdbid using google search
                    '' '' '' MessageBox.Show(themovie.pimdbnumber)
                    Try
                        mainhash.Add(hashvalue.GetHashCode(), themovie)
                    Catch ex As Exception
                        Debug.Print(vbNewLine + themovie.pmoviename + " " + themovie.pyear.ToString)
                        Debug.Print(themovie.episodename + " s" + themovie.seasonnum + "e" + themovie.episodenum)
                    End Try
                End If
            Else
                'Debug.Print("NON-Movie: " + themovie.ptype + " for " + themovie.pmoviename)
            End If
            If tempcount = 500 Then
                tempcount = 1
                Debug.Print("500" + TimeOfDay.ToString)
                System.Threading.Thread.Sleep(10) 'pause for 30 seconds each 500
            Else
                tempcount += 1
            End If
        Next
        Debug.Print(TimeOfDay.ToString)
        Debug.Print(movies.Count.ToString)
        Debug.Print(mainhash.Count.ToString)
        Debug.Print(" ------- Movie Name and Year Pulled to hashtable ------ ")

    End Sub
    Private Sub loadxmls()
        'loads up all xmls to movie hash table - DEV USE ONLY
        'get list of xmls
        'for each one - create new imdb, load it, then convert to new movie and inject into hashtable
        Dim temparray As New ArrayList
        For Each txmlfile In Directory.GetFiles("F:\hashedxmls")
            Dim anewimdb As New IMDB
            anewimdb = anewimdb.readIMDBXML(txmlfile, True)
            Debug.Print(anewimdb.id)
            Dim anewmovie As New movie
            anewimdb.imdbtomovie(anewmovie)
            anewmovie.pmoviename = anewmovie.ptitle
            If Not anewmovie.pmoviename = "" Then temparray.Add(anewmovie)
        Next
        For Each tmovieobj As movie In temparray
            Dim keyhash As String = tmovieobj.pmoviename + tmovieobj.pyear.ToString
            'keyhash.GetHashCode()
            Try
                mainhash.Add(keyhash.GetHashCode(), tmovieobj)
            Catch ex As Exception

            End Try
        Next

        MessageBox.Show("Temparray Items: " + temparray.Count.ToString + vbNewLine + "Mainhash Table Items: " + mainhash.Count.ToString)
        Debug.Print("done")
    End Sub
    Private Sub loadxmltodb()
        createdb()

        'loads up all xmls to movie hash table - DEV USE ONLY
        'get list of xmls
        'for each one - create new imdb, load it, then convert to new movie and inject into hashtable
        Dim temparray As New ArrayList
        For Each txmlfile In Directory.GetFiles("c:\program files\movieinfoplus\cache\imdbcache")
            Dim anewimdb As New IMDB
            anewimdb = anewimdb.readIMDBXML(txmlfile, True)
            Debug.Print(anewimdb.id)
            Dim anewmovie As New movie
            anewimdb.imdbtomovie(anewmovie)
            anewmovie.pmoviename = anewmovie.ptitle
            If Not anewmovie.pmoviename = "" Then temparray.Add(anewmovie)
        Next
        For Each tmovieobj As movie In temparray
            'Dim keyhash As String = tmovieobj.pmoviename + tmovieobj.pyear.ToString
            'keyhash.GetHashCode()
            'Try
            'mainhash.Add(keyhash.GetHashCode(), tmovieobj)
            'Catch ex As Exception

            'End Try
        Next

        MessageBox.Show("Temparray Items: " + temparray.Count.ToString + vbNewLine + "Mainhash Table Items: " + mainhash.Count.ToString)
        Debug.Print("done")
    End Sub
    Private Sub parseimdbplotlist()
        Dim filename As String = listsfolder + "\plot.list" 'tbimdblistfile.Text
        Dim data0 As String = File.ReadAllText(filename)


        'Dim Path As String = Application.StartupPath & "\"
        Try
            'Dim RegexObj3 As New Regex("(?<moviename>.*?) \((?<year>\d{4})\)")
            Dim RegexObj3 As New Regex("MV: ""(.{2,254})"" [(](\d{4})[)].{1,4}PL: (.{1,8000}?)(?:BY:){1}", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            Dim MatchResults As Match = RegexObj3.Match(data0)
            Dim counter As Integer = 0
            Dim subcounter As Integer = 0
            Dim moviecount As Integer = 0
            Dim gamecount As Integer = 0
            Dim oldmoviecount As Integer = 0
            Dim newermoviecount As Integer = 0
            Dim tvcount As Integer = 0
            While MatchResults.Success
                Dim GroupObj1 As Group = MatchResults.Groups(1) '"moviename")
                Dim GroupObj2 As Group = MatchResults.Groups(2) '"year")
                Dim GroupObj3 As Group = MatchResults.Groups(3) '"plot")
                Dim type As String = GroupObj3.Value.ToLower
                'If type = "" Then type = "movie"
                Dim moviename As String = GroupObj1.Value
                Dim movienamelength As Integer = moviename.Length
                sqlmask(moviename) ' = Strings.Replace(moviename, "'", "")
                moviename = Strings.Replace(moviename, ";", "")
                Dim Year As Integer = Convert.ToInt16(GroupObj2.Value)
                Dim plot As String = GroupObj3.Value
                plot = Strings.Replace(plot, "PL: ", "") 'remove plot tags
                sqlmask(plot)
                'Debug.Print(Year.ToString)
                'Debug.Print(moviename)
                'Debug.Print(plot)

                'SQLStmt = "INSERT INTO imdb (Name,Year)  VALUES ('" + moviename + "','" + Year.ToString + "')"
                moviecount = moviecount + 1
                SQLStmt = "Update imdb SET plot ='" + plot + "' where Name='" + moviename + "' and Year='" + Year.ToString + "'"

                If Year >= 1970 Then
                    ExecuteSQLStmt(dblocation, SQLStmt, True)
                    newermoviecount += 1
                    'Debug.Print(SQLStmt.ToString)
                Else
                    ExecuteSQLStmt(dblocation_old, SQLStmt, True)
                    oldmoviecount += 1
                    'Debug.Print(SQLStmt.ToString)
                End If

                counter = counter + 1
                subcounter = subcounter + 1
                If subcounter = 50 Then
                    Debug.Print(counter.ToString)
                    'Debug.Print("Movies: " + moviecount.ToString + " -- TV Shows: " + tvcount.ToString + " -- Video Games: " + gamecount.ToString)
                    Debug.Print("Old Movies: " + oldmoviecount.ToString + vbNewLine + "Newer Movies: " + newermoviecount.ToString)
                    subcounter = 0
                End If
                MatchResults = MatchResults.NextMatch()
            End While
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        'regex

    End Sub
    Private Sub parseimdb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = Application.StartupPath & "\"
        '
        ' Create a new database (delete existing one)
        '
        '' ''SQLStmt = "DROP TABLE IF EXISTS TMD;" & _
        '' ''        "CREATE TABLE TMD (" & _
        '' ''        "MovieName VARCHAR(50) NOT NULL," & _
        '' ''        "Year VARCHAR(4) NOT NULL)"

        '' ''ExecuteSQLStmt(Path & "test.db3", SQLStmt)
        '
        ' Import data
        '
        'ImportData(Path & "test.db3", "Users", _
        '        "FFMS_ID," & _
        '        "FFMS_RealName," & _
        '        "FFMS_Description," & _
        '        "FFMS_DatabasePermissions," & _
        '        "FFMS_AdministrationAllowed", _
        '        Path & "authentication_users.txt")
        ''
        ' Retrieve data into controls and save to disk file. Finally close database connection
        ' 
        SQLStmt = "SELECT * FROM imdb"
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 1, ListBox1)
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 2, ComboBox1)
        FillDataAdapter(dblocation, 0, SQLStmt, DataGridView1, dbfilepath & "test.txt", True)
        ''
    End Sub

    Private Sub btnClearTMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTMB.Click
        'Dim Path As String = Application.StartupPath & "\"
        'SQLStmt = "DROP TABLE IF EXISTS TMD;" & _
        '        "CREATE TABLE TMD (" & _
        '        "MovieName VARCHAR(50) NOT NULL," & _
        '        "Year VARCHAR(4) NOT NULL)"

        'ExecuteSQLStmt(dblocation, SQLStmt)
    End Sub
    Private Sub createdb()
        'SQLStmt = "DROP TABLE IF EXISTS TMD;" & _
        SQLStmt = "CREATE TABLE imdb (" & _
               "Name VARCHAR(255) NOT NULL," & _
               "Year INT(4) NOT NULL," & _
               "IMDBID VARCHAR(8) NULL," & _
                "AltTitle VARCHAR(255) NULL," & _
                "PlotSummary VARCHAR(1024) NULL," & _
                "Plot VARCHAR(8192) NULL," & _
                "Runtime VARCHAR(255) NULL," & _
                "Tagline VARCHAR(1024) NULL," & _
                "Genre VARCHAR(1024) NULL," & _
                "Director VARCHAR(255) NULL," & _
                "Outline VARCHAR(255) NULL," & _
                "Votes VARCHAR(20) NULL," & _
                "Studio VARCHAR(255) NULL," & _
                "Mpaa VARCHAR(255) NULL," & _
                "Rating VARCHAR(5) NULL)" '," & _
        'uid
        ExecuteSQLStmt(dblocation, SQLStmt, True)
        'SQLStmt = ""

    End Sub
    Public Sub createdb2()
        SQLStmt = "CREATE TABLE imdb (" & _
"Name VARCHAR(255) NOT NULL," & _
"Year INT(4) NOT NULL," & _
"IMDBID VARCHAR(8) NULL," & _
"AltTitle VARCHAR(255) NULL," & _
"PlotSummary VARCHAR(1024) NULL," & _
"Plot VARCHAR(8192) NULL," & _
"Runtime VARCHAR(255) NULL," & _
"Tagline VARCHAR(1024) NULL," & _
"Genre VARCHAR(1024) NULL," & _
"Director VARCHAR(255) NULL," & _
"Outline VARCHAR(255) NULL," & _
"Votes VARCHAR(20) NULL," & _
"Studio VARCHAR(255) NULL," & _
"Mpaa VARCHAR(255) NULL," & _
"Rating VARCHAR(5) NULL)" '," & _
        'uid
        ExecuteSQLStmt(dblocation_old, SQLStmt, True)
    End Sub
    Private Sub btnRunQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunQuery.Click
        Dim Path As String = Application.StartupPath & "\"
        SQLStmt = tbSqlQuery.Text
        'ExecuteSQLStmt(Path & "test.db3", SQLStmt)
        FillDataAdapter(dblocation, 0, SQLStmt, DataGridView1, dbfilepath & "test.txt", True)
    End Sub

    Private Sub btnParseTaglineList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParseTaglineList.Click
        parsetaglinelist()
    End Sub
    Private Sub parsetaglinelist()
        Dim filename As String = tbTaglineList.Text
        Dim data0 As String = File.ReadAllText(filename)
        Dim Path As String = Application.StartupPath & "\"
        'parseing taglines
        '----------------------------------
        'To enable the regex to match correctly, we need to modify the source with Strings.Replace(%taglines list file data%, "#", "##")
        Strings.Replace(data0, "#", "##")
        'Since some names would break the SQL statment, we need to escape the "'" apostrophy or replace it

        Try
            Dim counter As Integer = 0
            Dim subcounter As Integer = 0
            Dim RegexObj As New Regex("# ""{1}(?<moviename>.*?)""{1} .(?<year>\d{4}).*?" & Chr(10) & "(?<tagline>" & Chr(9) & ".*?)#", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            Dim MatchResults As Match = RegexObj.Match(data0)
            While MatchResults.Success
                'do processing
                Dim GroupObj1 As Group = MatchResults.Groups("moviename")
                Dim GroupObj2 As Group = MatchResults.Groups("year")
                Dim GroupObj3 As Group = MatchResults.Groups("tagline")
                Dim moviename As String = GroupObj1.Value
                Dim movienamelength As Integer = moviename.Length
                'mask the moviename, due to ' issues with injection
                sqlmask(moviename) ' = Strings.Replace(moviename, "'", "")
                'moviename = Strings.Replace(moviename, "'", "char22")
                moviename = Strings.Replace(moviename, ";", "")
                Dim Year As Integer = Convert.ToInt16(GroupObj2.Value)
                Dim tagline As String = GroupObj3.Value
                'cleantagline(tagline)
                tagline = rewriteclean(tagline)
                'Strings.Replace(tagline, "'", "z1z2z3")
                'sqlmask(tagline)
                '                SQLStmt = "INSERT INTO TMD (MovieName,Year,Tagline)  VALUES ('" + moviename + "','" + Year.ToString + "','" + tagline.ToString + "' WHERE MovieName = '" + moviename + "')"
                'UPDATE Artists SET ArtistName ='Santana' WHERE ArtistID=5;  
                SQLStmt = "UPDATE TMD SET Tagline = '" + tagline.ToString + "' WHERE MovieName = '" + moviename + "'"
                Debug.Print(SQLStmt)
                ExecuteSQLStmt(dblocation, SQLStmt)
                counter = counter + 1
                subcounter = subcounter + 1
                If subcounter = 10 Then
                    Debug.Print(counter.ToString)
                    subcounter = 0
                End If
                MatchResults = MatchResults.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

    End Sub

    Private Sub btnClearTaglines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTaglines.Click
        Dim Path As String = Application.StartupPath & "\"
        SQLStmt = "DROP TABLE IF EXISTS TMDT;" & _
                "CREATE TABLE TMDT (" & _
                "MovieName VARCHAR(240) NOT NULL," & _
                "Year VARCHAR(4) NOT NULL," & _
                "Tagline VARCHAR(240) NOT NULL)"
        ExecuteSQLStmt(dblocation, SQLStmt)
    End Sub
    Private Sub sqlmask(ByRef data As String)
        data = Strings.Replace(data, "'", "char22")
    End Sub
    Private Function sqlunmask(ByRef data As String) As String
        Dim modData As String = Strings.Replace(data, "char22", "'")
        Return modData
    End Function

    Private Sub btnShowTaglineData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowTaglineData.Click
        Dim Path As String = Application.StartupPath & "\"
        SQLStmt = "SELECT * from TMDT"
        'ExecuteSQLStmt(Path & "test.db3", SQLStmt)
        FillDataAdapter(dblocation, 0, SQLStmt, DataGridView1, dbfilepath & "test.txt", True)

    End Sub

    Private Sub cleantagline(ByRef data As String)
        Strings.Replace(data, ";", "")
        Strings.Replace(data, "'", "")
        'Strings.Replace(data, "�", "")
        Strings.Replace(data, vbCrLf, "")
        Strings.Replace(data, vbLf, "")
        If data.Length >= 240 Then
            Strings.Left(data, 240)
        End If
    End Sub

    Private Sub getSqlDataToThisArrayList(ByRef thearraylist As ArrayList, ByVal sqlString As String, ByVal sqlDB As String)
        thearraylist = StreamDataIntoArrayList(dblocation, sqlString, 0)
    End Sub
    Private Function rewriteclean(ByVal dirtydata As String) As String
        Dim SB As New System.Text.StringBuilder
        'Dim cleandata As String
        Dim allowedchars As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890.!@#$%^&*"
        For Each c As Char In dirtydata
            If c = " " Then
                SB.Append(" ")
            Else
                If allowedchars.IndexOf(c) > 0 Then
                    SB.Append(c)
                End If
            End If
        Next c

        Return SB.ToString
        'Return cleandata

    End Function

    Private Sub btncreatemtgtables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreatemtgtables.Click
        Dim Path As String = Application.StartupPath & "\"
        SQLStmt = "DROP TABLE IF EXISTS TMD;" & _
                "CREATE TABLE TMD (" & _
                "MovieName VARCHAR(240) NOT NULL," & _
                "Year VARCHAR(4) NOT NULL," & _
                "Tagline VARCHAR(240) NULL)"
        ExecuteSQLStmt(dblocation, SQLStmt)

        SQLStmt = "DROP TABLE IF EXISTS TMDTV;" & _
                "CREATE TABLE TMDTV (" & _
                "MovieName VARCHAR(240) NOT NULL," & _
                "Year VARCHAR(4) NOT NULL," & _
                "Tagline VARCHAR(240) NULL)"
        ExecuteSQLStmt(dblocation, SQLStmt)


        SQLStmt = "DROP TABLE IF EXISTS TMDG;" & _
                "CREATE TABLE TMDG (" & _
                "MovieName VARCHAR(240) NOT NULL," & _
                "Year VARCHAR(4) NOT NULL," & _
                "Tagline VARCHAR(240) NULL)"
        ExecuteSQLStmt(dblocation, SQLStmt)
    End Sub

    Private Sub btnTestArrayFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestArrayFill.Click
        Dim Path As String = Application.StartupPath & "\"
        Dim crackarray, fixedarray As New ArrayList
        SQLStmt = "SELECT * FROM TMD"
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 1, ListBox1)
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 2, ComboBox1)
        getSqlDataToThisArrayList(crackarray, SQLStmt, dblocation)
        'unmask the data
        For Each item In crackarray
            Dim itemUnmasked As String
            itemUnmasked = sqlunmask(item.ToString)
            fixedarray.Add(itemUnmasked)
        Next
        Dim restrictCount As Integer = 0
        For Each items In fixedarray
            If restrictCount > 10000 Then
                Exit Sub
            End If
            Debug.Print(items.ToString)
            restrictCount = restrictCount + 1

        Next
    End Sub

    Public Sub sqlGetAllMovies(ByRef passedarraylist As ArrayList)
        Dim Path As String = Application.StartupPath & "\"
        Dim crackarray As New ArrayList
        SQLStmt = "SELECT * FROM imdb"
        getSqlDataToThisArrayList(crackarray, SQLStmt, dblocation)
        'unmask the data
        For Each item In crackarray
            Dim itemUnmasked As String
            itemUnmasked = sqlunmask(item.ToString)
            passedarraylist.Add(itemUnmasked)
        Next
        'Dim restrictCount As Integer = 0
        'For Each items In fixedarray
        '    If restrictCount > 10000 Then
        '        Exit Sub
        '    End If
        '    Debug.Print(items.ToString)
        '    restrictCount = restrictCount + 1

        'Next
    End Sub

    Public Function findyearstrict(ByVal moviename As String) As Integer
        Dim year As Integer = 0
        Dim Path As String = Application.StartupPath & "\"
        Dim crackarray, fixedarray As New ArrayList
        Dim searchname As String = Strings.Replace(moviename, "char22", "'")
        SQLStmt = "SELECT * FROM TMD where moviename = '" + searchname + "'"
        getSqlDataToThisArrayList(crackarray, SQLStmt, dblocation)
        For Each item In crackarray
            fixedarray.Add(sqlunmask(item.ToString))
            Debug.Print(sqlunmask(item.ToString))
        Next
        Return year
    End Function
    Public Function findyear(ByVal Moviename As String) As Integer
        Dim yearret As Integer = 0
        If cbLooseName.Checked = True Then
            yearret = findyearloose(Moviename)
        Else
            yearret = findyearstrict(Moviename)
        End If
        Return yearret

    End Function
    Public Function findyearloose(ByVal moviename As String) As Integer
        Dim year As Integer = 0
        Dim Path As String = Application.StartupPath & "\"
        Dim crackarray, fixedarray As New ArrayList
        Dim searchname As String = Strings.Replace(moviename, "char22", "'")
        'If cbLooseName.Checked = True Then
        SQLStmt = "SELECT * FROM TMD where moviename like '%" + searchname + "%'"
        'Else
        'SQLStmt = "SELECT * FROM TMD where moviename = '" + searchname + "'"
        'End If

        getSqlDataToThisArrayList(crackarray, SQLStmt, dblocation)
        For Each item In crackarray
            'Dim itemUnmasked As String = 
            fixedarray.Add(sqlunmask(item.ToString))
            Debug.Print(sqlunmask(item.ToString))
        Next
        If fixedarray.Count > 1 Then
            MsgBox("more then one found, pick it from the list")
            FillDataAdapter(dblocation, 0, SQLStmt, selectMovie.dgMoviePicker, dbfilepath & "test.txt", True)
            selectMovie.dgMoviePicker.Columns(0).Width = 80
            selectMovie.ShowDialog()

        End If
        Return year
    End Function

    Private Sub btnfindyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfindyear.Click
        Dim moviename As String = tbMovieName.Text
        findyear(moviename)

    End Sub

    Private Sub btnDownloadLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownloadLists.Click
        getimdblists()
    End Sub

    Private Sub getimdblists()
        Dim baseurl As String = "ftp://ftp.fu-berlin.de/pub/misc/movies/database/"
        Dim fnameMovies As String = "movies.list"
        Dim fnameTaglines As String = "taglines.list"
        Dim tempfolder As String = listsTempfolder
        Dim finalfolder As String = listsfolder
        cleanouttemp(tempfolder)
        wget(baseurl + fnameMovies + ".gz", tempfolder)
        wget(baseurl + fnameTaglines + ".gz", tempfolder)
        MsgBox("Download of new IMDB lists is complete when the wget windows close")
    End Sub
    Private Sub btnExtractIMDBLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractIMDBLists.Click
        extractimdblists()
    End Sub
    Private Sub extractimdblists()
        Dim fnameMovies As String = "movies.list"
        Dim fnameTaglines As String = "taglines.list"

        decompress("""" + listsTempfolder + fnameMovies + ".gz" + """", """" + listsfolder + """")
        decompress(listsTempfolder + fnameTaglines + ".gz", listsfolder)
    End Sub
    Private Sub cleanouttemp(ByRef tempfolder As String)
        'clear out temp
        Dim tempdirlist As New ArrayList
        For Each item In Directory.GetFiles(tempfolder)
            tempdirlist.Add(item)
        Next
        Dim counter As Integer = 0
        For Each itemval In tempdirlist
            File.Delete(tempdirlist.Item(counter).ToString)
            counter += 1
        Next
    End Sub
    Private Sub wget(ByRef fileToDownload As String, ByRef folderToSaveFileTo As String)
        Dim binfilelocal As String = wgetfolder + "wget.exe"
        Debug.Print(binfilelocal + """" + " " + fileToDownload + """" + " -P " + """" + folderToSaveFileTo + """")
        System.Diagnostics.Process.Start(binfilelocal, " " + """" + fileToDownload + """" + " -P " + """" + folderToSaveFileTo + """")
    End Sub
    Private Sub decompress(ByRef fileToUncompress As String, ByRef folderToSaveExtractedContentsTo As String)
        Dim binfilelocal As String = dirUnRAR + "UnRARexe"
        System.Diagnostics.Process.Start(binfilelocal, " e " + fileToUncompress + " -y -o+ " + """" + folderToSaveExtractedContentsTo + """")
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'createdb()
        'createdb2()
        loadxmls()
        parseimdbplots()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SQLStmt = "SELECT * FROM imdb"
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 1, ListBox1)
        'StreamDataIntoControl(Path & "test.db3", SQLStmt, 2, ComboBox1)
        FillDataAdapter(dblocation, 0, SQLStmt, DataGridView1, dbfilepath & "test.txt", True)
        ''
    End Sub

    Private Sub btnParseHashedFolderIntoIMDBXMLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParseHashedFolderIntoIMDBXMLS.Click
        Dim tsaIMDB As New IMDB
        tsaIMDB.parsehashedfolder("f:\hashed", False)
    End Sub
End Class