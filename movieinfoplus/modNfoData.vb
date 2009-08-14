Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Data

Module modNfoData
    Public Function checkforIMDBIDinnfofile(ByRef tmovie As movie) As Boolean
        If tmovie.pfilemode Then Return False

        'grabs id from nfo file if it exsists
        Dim pathtonfo As String = tmovie.getmoviepath + "\" + tmovie.getmoviename + ".nfo"
        'Debug.Print(tmovie.getmoviepath + "\" + tmovie.getmoviename + ".nfo")
        If File.Exists(pathtonfo) Then
            tmovie.pimdbnumber = tmovie.readnfofile(pathtonfo)
            If tmovie.pimdbnumber = "" Then
                Return False
            Else
                Return True
            End If
            ' Return True
        End If
    End Function
    Public Function checkforIMDBIDinnfofileFileLevel(ByRef tmovie As movie) As Boolean
        If Not tmovie.pfilemode Then Return False

        'grabs id from nfo file if it exsists
        Dim pathtonfo As String = addfiletofolder(tmovie.getmoviepath, stripstackforfilemode(removeextension(tmovie.preservedmoviename)) + ".nfo")
        'Debug.Print(tmovie.getmoviepath + "\" + tmovie.getmoviename + ".nfo")
        If File.Exists(pathtonfo) Then
            tmovie.pimdbnumber = tmovie.readnfofile(pathtonfo)
            If tmovie.pimdbnumber = "" Then
                Return False
            Else
                If Not File.Exists(pathtonfo & ".oldversion") Then
                    If Not maincollection.rconf.pcbmoviesnonforename Then
                        File.Move(pathtonfo, pathtonfo & ".oldversion")
                    End If
                End If
                Return True
            End If
            ' Return True
        End If
    End Function
    Public Sub checktmdbid(ByRef currentmovie As movie)
        Debug.Print(vbNewLine + "------------------------ tmdbid check running -------------------")
        Dim noid As Boolean = False
        If currentmovie.ptmdbid Is Nothing Then noid = True
        If currentmovie.ptmdbid = "" Then noid = True
        Debug.Print("Missing tmdid in current movie: " & noid.ToString & vbNewLine)
        If noid Then
            'get tmdbid by searching for the imdbid 
            Dim tempresults As New tmdbapiv2.Results
            currentmovie.ptmdbid = tempresults.gettmdbidbyimdbid(currentmovie.pimdbnumber)
            Debug.Print("Setting tmdid for movie to:" & currentmovie.ptmdbid & vbNewLine)
        End If
    End Sub
    Public Sub checknfodata(ByRef currentmovie As movie, ByVal dname As String, ByVal workonline As Boolean)
        If currentmovie.pdatafromnfo Then Exit Sub 'nothing to do if it came from an nfo file
        ' ---- IMDB AND NFO -----
        Dim hasnfoalready As Boolean = False
        Dim haveidonly As Boolean = False

        'see if movie data was loaded from nfo file during folder scan
        If Not currentmovie.pdatafromnfo Then
            Debug.Print("no .nfo for movie found")
            'we don't have data so try to get it
            If currentmovie.pfilemode Then
                haveidonly = checkforIMDBIDinnfofileFileLevel(currentmovie)
            Else
                haveidonly = checkforIMDBIDinnfofile(currentmovie)
            End If

            If Not haveidonly Then
                Debug.Print("don't have the id yet")
                'see if there is an nfo file in the folder 
                'Dim parentfolder As String = getparentdirectory(currentmovie.getmoviepath)
                Dim curnfoname As String = ""
                If maincollection.moviemode = "file" Then
                    curnfoname = stripstackforfilemode(removeextension(currentmovie.preservedmoviename))
                Else
                    curnfoname = currentmovie.pmoviename
                End If
                'rev 2401 update, look for movie.nfo but use the name as the more specific option
                If Not File.Exists(addfiletofolder(currentmovie.getmoviepath, curnfoname + ".nfo")) Then
                    curnfoname = "movie"
                End If

                If File.Exists(addfiletofolder(currentmovie.getmoviepath, curnfoname + ".nfo")) Then
                    'read it up to see if we have a tt/d{6,7} in it if we do set haveidonly to true and set the id in the movie
                    Dim strwork As String = File.ReadAllText(addfiletofolder(currentmovie.getmoviepath, curnfoname + ".nfo"))
                    Try
                        If Regex.IsMatch(strwork, "(tt\d{6,7})") Then
                            currentmovie.pimdbnumber = Regex.Match(strwork, "(tt\d{6,7})").Groups(1).Value
                            haveidonly = True
                        End If
                    Catch ex As ArgumentException
                        'Syntax error in the regular expression
                    End Try
                    strwork = ""
                End If
            End If

            If Not haveidonly And Not maincollection.moviemode = "file" Then
                Dim filelist() As String '  As New ArrayList
                filelist = Directory.GetFiles(currentmovie.getmoviepath)
                'Dim totfilecount As Integer = filelist.
                For Each pathedfile As String In filelist
                    Dim strnfoextonfile As String = ""
                    strnfoextonfile = Strings.Right(pathedfile, 4)
                    Dim imdbidtxt As String = ""
                    Try
                        imdbidtxt = Strings.Right(pathedfile, 10)
                    Catch ex As Exception
                        Debug.Print("too short to parse imdbid.txt from current listed item")
                    End Try

                    If strnfoextonfile = ".nfo" Or imdbidtxt = "imdbid.txt" Then
                        'read it up to see if we have a tt/d{6,7} in it if we do set haveidonly to true set the id in the movie
                        Dim strwork As String = File.ReadAllText(pathedfile)
                        Try
                            If Regex.IsMatch(strwork, "(tt\d{6,7})") Then
                                currentmovie.pimdbnumber = Regex.Match(strwork, "(tt\d{6,7})").Groups(1).Value

                                haveidonly = True
                            Else
                                If Regex.IsMatch(strwork, "(itle?\d{6,7})") Then
                                    currentmovie.pimdbnumber = Regex.Match(strwork, "(itle?\d{6,7})").Groups(1).Value
                                    haveidonly = True
                                End If

                                End If
                        Catch ex As ArgumentException
                            'Syntax error in the regular expression
                        End Try
                        Try
                            Dim curdate As Date = Now()
                            Dim addtext As String = "." & curdate.Day.ToString & "-" & curdate.Month.ToString & "-" & curdate.Year.ToString & "." & curdate.TimeOfDay.ToString
                            If Not imdbidtxt = "imdbid.txt" Then
                                If Not maincollection.rconf.pcbmoviesnonforename Then
                                    File.Move(pathedfile, pathedfile & cleanname(addtext) & ".oldversion")
                                End If
                            End If

                        Catch ex As Exception
                        End Try
                        strwork = ""
                    End If
                    If haveidonly Then
                        Exit For
                    End If
                Next
            End If

            If Not haveidonly Then
                'if there is no nfo file, check for a poster file (they have the imdbid in them)
                'TODO: add maincollection.rconf option for manual movie pick list
                'haveidonly = checkforposterfiletogetimdbid(currentmovie)
            End If
        Else
            hasnfoalready = True
        End If
        'see if a folder icon exsists 
        Debug.Print(".nfo data - done")
        '?        pbCurIconUsed.Enabled = True

        Debug.Print("IMDB Information and .nfo file creation")
        '-------------------------------- IMDB Information and .nfo file creation 
        If maincollection.rconf.pcbGetIMDBInfo And Not hasnfoalready Then 'get imdb info
            If currentmovie.pimdbnumber = "" Then
                Debug.Print("no id in movie, grabbing imdb info")
                If maincollection.messageprompts Then maincollection.lblPbar.Text = "-- Connecting to IMDB: " + dname + "--"
                If maincollection.messageprompts Then maincollection.Refresh()
                Dim tstringofimdbpage As String = getimdbidsearch(dname, False)
                If maincollection.messageprompts Then maincollection.lblPbar.Text = " -- Searching IMDB for: " + dname + "--"
                If maincollection.messageprompts Then maincollection.Refresh()
                currentmovie.pimdbnumber = snagimdbid_dlg(dname, currentmovie, tstringofimdbpage)
                If currentmovie.pimdbnumber Is Nothing Then haveidonly = False
                Debug.Print("Assigned Number is: " & currentmovie.pimdbnumber)
            Else
                'do not grab the data, we know the id already
                'hasnfoalready = True
                Debug.Print("we have an id, not parseing imdb again for it")
            End If
            'getimdbidsearchwithwget(tmovie)

            If workonline = True Then 'download mode
                Debug.Print("checking cache for imdb info")
                If File.Exists(maincollection.rconf.imdbcachefolder + currentmovie.pimdbnumber + ".xml") Then 'And Not cbOverwriteNFO.Checked Then
                    'maincollection.lblPbar.Text = " __-- XML already in Cache: IMDB Information for " + tmovie.getmovienamaincollection.ToString + "--__ "
                    'do nothing yet, nfo exsists -- add load nfo code here as well as the option to overwrite nfos in gui
                    Debug.Print(".xml already exsists") ' + cbOverwriteNFO.Checked.ToString)
                Else
                    If maincollection.messageprompts Then maincollection.lblPbar.Text = "-- NO XML Cached: Connecting to IMDB: " + dname + "--"
                    'If maincollection.messageprompts Then maincollection.Refresh()()
                    If Not haveidonly Then
                        'no nfo so get the data
                        If maincollection.messageprompts Then maincollection.lblPbar.Text = "-- Searching IMDB: " + dname + "--"
                        If maincollection.messageprompts Then maincollection.Refresh()
                        Dim tstringofimdbpage As String = getimdbidsearch(dname, False)
                        If maincollection.messageprompts Then maincollection.lblPbar.Text = "-- Gathering IMDB: " + dname + "--"
                        If maincollection.messageprompts Then maincollection.Refresh()
                        currentmovie.pimdbnumber = snagimdbid_dlg(dname, currentmovie, tstringofimdbpage)
                        snagyear(dname, currentmovie, tstringofimdbpage)
                    End If
                End If

                ' getimdbdata(tmovie)
                Dim imdbinfo As New IMDB
                Dim imdbidtemp As String = currentmovie.getimdbid
                If imdbidtemp = "" Then
                    If maincollection.messageprompts Then MsgBox("NO IMDB DATA FOUND, UNABLE TO SAVE NFO FILE")
                    Debug.Print("NO IMDB DATA FOUND, UNABLE TO SAVE NFO FILE")
                Else
                    If maincollection.messageprompts Then maincollection.lblPbar.Text = "-- Parsing IMDB: " + dname + "--"
                    'If maincollection.messageprompts Then maincollection.Refresh()
                    imdbinfo = maincollection.imdbparse(imdbidtemp)
                    'save xml to imdbcache reguardless of gui setting to write nfo
                    ' tmovie.Actors = imdbinfo.Actors
                    imdbinfo.writeIMDBXML(imdbinfo, currentmovie, maincollection.rconf.imdbcachefolder, True)
                    'currentmovie.pdatafromnfo = True
                    'If cbSaveNFO.Checked Then
                    '    'imdbinfo.writeIMDBXML(imdbinfo, tmovie)
                    '    tmovie.saveimdbinfo(tmovie)
                    'End If


                End If
            End If
        End If

    End Sub

#Region "ofdb"
    Public Sub set_movie_details_from_ofdb(ByRef tmovie As movie)
        Dim s As String = ""
        s = downloadofdb_main_details(get_ofdbidlink(tmovie.pimdbnumber))

        Dim ofdb_title As String = ""
        Try
            Dim robjOfdbTitle As New Regex("<td width=""99.""><h2><font face=""Arial,Helvetica,sans-serif"" size=""3""><b>([^<]+)</b></font></h2></td>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_title = robjOfdbTitle.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If maincollection.rconf.pcbofdb_UpdateTitle Then tmovie.peditedmoviename = cleanimdbdata(ofdb_title)

        Dim ofdb_outline As String = ""
        Try
            Dim robjOfdbOutline As New Regex("<b>Inhalt:</b>([^<]+)", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_outline = robjOfdbOutline.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If maincollection.rconf.pcbofdb_UpdateOutline Then tmovie.pplotoutline = cleanimdbdata(ofdb_outline)

        Dim ofdb_genre As String = ""
        Try
            Dim robjOfdbGenres As New Regex("view.php\?page=genre&Genre=[^""]+"">([^<]*)<", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            Dim ofdbGenres As Match = robjOfdbGenres.Match(s)
            While ofdbGenres.Success
                ofdb_genre += ofdbGenres.Groups(1).Value.ToString + " / "
                ofdbGenres = ofdbGenres.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If Strings.Right(ofdb_genre, 3) = " / " Then
            ofdb_genre = Strings.Left(ofdb_genre, ofdb_genre.Length - 3)
        End If
        If maincollection.rconf.pcbofdb_UpdateGenre Then tmovie.pgenre = cleanimdbdata(ofdb_genre)

        Dim ofdb_rating As String = ""
        Try
            Dim robjOfdbRating As New Regex("Note: ([0-9\.]+)", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_rating = robjOfdbRating.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If maincollection.rconf.pcbofdb_UpdateRating Then tmovie.prating = cleanimdbdata(ofdb_rating)

        Dim ofdb_votes As String = ""
        Try
            Dim robjOfdbVotes As New Regex("Stimmen: ([0-9]+)", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_votes = robjOfdbVotes.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If maincollection.rconf.pcbofdb_UpdateVotes Then tmovie.pvotes = cleanimdbdata(ofdb_votes)

        Dim ofdb_ploturl As String = ""
        Try
            Dim robjOfdbPlotUrl As New Regex("Inhalt:</b>[^<]*<a href=""plot/([0-9]+,[0-9]+,.*?)"">", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_ploturl = robjOfdbPlotUrl.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Dim s1 As String
        If Not ofdb_ploturl = "" Then
            s1 = get_ofdb_plot("http://www.ofdb.de/plot/" & ofdb_ploturl)
        End If
        Dim ofdb_plotgroup As String = ""
        Try
            Dim robjOfdbPlotGroup As New Regex("Eine Inhaltsangabe von(.*)<option value=""All"">", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_plotgroup = robjOfdbPlotGroup.Match(s1).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

        Dim ofdb_plotMain As String = ""
        Try
            Dim robjOfdbPlotMain As New Regex("<br><br>([^<]+)", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdb_plotMain = robjOfdbPlotMain.Match(ofdb_plotgroup).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        If maincollection.rconf.pcbofdb_tagline = 0 Then
            tmovie.ptagline = "" ' cleanimdbdata(ofdb_plotMain)
        End If
        If maincollection.rconf.pcbofdb_tagline = 1 Then
            'do nothing ''tmovie.ptagline = cleanimdbdata(ofdb_plotMain)
        End If
        If maincollection.rconf.pcbofdb_tagline = 2 Then
            tmovie.ptagline = cleanimdbdata(ofdb_plotMain)
        End If

        If maincollection.rconf.pcbofdb_UpdatePlot Then tmovie.pplot = cleanimdbdata(ofdb_plotMain)

        Try
            Dim robjOfdbPlotMainAdd As New Regex("<br />([^<]+)", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            Dim ofdbplotadd As Match = robjOfdbPlotMainAdd.Match(ofdb_plotgroup)
            While ofdbplotadd.Success
                If maincollection.rconf.pcbofdb_UpdatePlot Then tmovie.pplot += cleanimdbdata(ofdbplotadd.Groups(1).Value.ToString)
                ofdbplotadd = ofdbplotadd.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

    End Sub
    Private Function get_ofdb_plot(ByVal url As String) As String
        Dim baseurlsiid As String = ""
        baseurlsiid = url
        Dim s As String
        'openpagedata
        Dim request As HttpWebRequest = CType(WebRequest.Create(baseurlsiid), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            s = reader.ReadToEnd()
        End Using
        Return s
    End Function
    Private Function get_ofdbidlink(ByVal imdbid As String) As String
        Dim s As String = get_ofdbid_from_imdbid_websearch(imdbid)
        Dim ofdburl As String = ""
        Try
            Dim robjOfdbID As New Regex("film/([0-9]*,.*?)\""", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            ofdburl = robjOfdbID.Match(s).Groups(1).Value
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Return "http://www.ofdb.de/film/" & ofdburl
    End Function
    Private Function downloadofdb_main_details(ByVal url As String, Optional ByVal tolower As Boolean = False) As String
        Dim baseurlsiid As String = ""
        baseurlsiid = url
        Dim s As String

        'openpagedata
        Dim request As HttpWebRequest = CType(WebRequest.Create(baseurlsiid), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            s = reader.ReadToEnd()
        End Using
        If Not tolower Then Return s
        Dim tvarstolower As String = s.ToLower
        Return tvarstolower
    End Function
    Private Function get_ofdbid_from_imdbid_websearch(ByVal imdbid As String, Optional ByVal tolower As Boolean = True) As String
        If imdbid Is Nothing Then Return ""
        If imdbid Is "" Then Return ""
        Dim baseurlsiid As String = ""
        baseurlsiid = "http://www.ofdb.de/view.php?SText=" & imdbid & "&Kat=IMDb&page=suchergebnis&sourceid=mozilla-search"

        Dim s As String

        'openpagedata
        Dim request As HttpWebRequest = CType(WebRequest.Create(baseurlsiid), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            s = reader.ReadToEnd()
        End Using

        If Not tolower Then Return s
        Dim tvarstolower As String = s.ToLower
        Return tvarstolower
    End Function
#End Region

#Region "tmdb"
    Private Function get_tmdb_byname_websearch(ByVal moviename As String, Optional ByVal tolower As Boolean = True) As String
        If moviename Is Nothing Then Return ""
        If moviename Is "" Then Return ""
        Dim baseurlsiid As String = ""
        '"http://api.themoviedb.org/2.0/Movie.search?title=" & imdbid & "&api_key=0f790eb54e7430c118594f1db0071444"
        baseurlsiid = "http://api.themoviedb.org/2.0/Movie.search?title=" & moviename & "&api_key=0f790eb54e7430c118594f1db0071444"

        Dim s As String

        'openpagedata
        Dim request As HttpWebRequest = CType(WebRequest.Create(baseurlsiid), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            s = reader.ReadToEnd()
        End Using

        If Not tolower Then Return s
        Dim tvarstolower As String = s.ToLower
        Return tvarstolower
    End Function
    Private Function parsetmdbresult(ByVal s As String) As List(Of movie)
        Dim thelist As New List(Of movie)
        Try
            Dim robjTmdbSearch As New Regex("<movie>(.*?)</movie>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
            Dim tmdbSearchMatches As Match = robjTmdbSearch.Match(s)
            While tmdbSearchMatches.Success
                Dim s2 As String = tmdbSearchMatches.Groups(1).Value.ToString
                Dim nmovie As New movie
                'parse out movie info
                Dim tmdb_score As String = ""
                Try
                    Dim robjTmdbScore As New Regex("<score>(.*?)</score>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_score = robjTmdbScore.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.prating = Trim(tmdb_score)

                Dim tmdb_popularity As String = ""
                Try
                    Dim robjTmdbpopularity As New Regex("<popularity>(.*?)</popularity>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_popularity = robjTmdbpopularity.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                ''unused at this time

                Dim tmdb_title As String = ""
                Try
                    Dim robjTmdbtitle As New Regex("<title>(.*?)</title>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_title = robjTmdbtitle.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.pmoviename = Trim(tmdb_title)

                Dim tmdb_alternative_title As String = ""
                Try
                    Dim robjTmdbalternative_title As New Regex("<alternative_title>(.*?)</alternative_title>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_alternative_title = robjTmdbalternative_title.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.poriginaltitle = Trim(tmdb_alternative_title)

                Dim tmdb_type As String = ""
                Try
                    Dim robjTmdb_type As New Regex("<type>(.*?)</type>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_type = robjTmdb_type.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                ''unused at this time

                Dim tmdb_id As String = ""
                Try
                    Dim robjTmdb_id As New Regex("<id>(.*?)</id>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_id = robjTmdb_id.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.ptmdbid = Trim(tmdb_id)

                Dim tmdb_imdb As String = ""
                Try
                    Dim robjTmdb_imdb As New Regex("<imdb>(.*?)</imdb>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_imdb = robjTmdb_imdb.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.pimdbnumber = Trim(tmdb_imdb)

                Dim tmdb_url As String = ""
                Try
                    Dim robjTmdb_url As New Regex("<url>(.*?)</url>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_url = robjTmdb_url.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                '' unused at this time

                Dim tmdb_short_overview As String = ""
                Try
                    Dim robjTmdb_short_overview As New Regex("<short_overview>(.*?)</short_overview>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_short_overview = robjTmdb_short_overview.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.pplotoutline = Trim(tmdb_short_overview)

                Dim tmdb_release As String = ""
                Try
                    Dim robjTmdb_release As New Regex("<release>(.*?)</release>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_release = robjTmdb_release.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                '' unused at this time

                Dim tmdb_poster_original As String = ""
                Try
                    Dim robjTmdb_poster_original As New Regex("<poster size=""original"">(.*?)</poster>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_poster_original = robjTmdb_poster_original.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.ptmdbposter = Trim(tmdb_poster_original)

                Dim tmdb_poster_cover As String = ""
                Try
                    Dim robjTmdb_poster_cover As New Regex("<poster size=""cover"">(.*?)</poster>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_poster_cover = robjTmdb_poster_cover.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.ptmdbposter_thumb = Trim(tmdb_poster_cover)

                Dim tmdb_backdrop_original As String = ""
                Try
                    Dim robjTmdb_backdrop_original As New Regex("<backdrop size=""original"">(.*?)</backdrop>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_backdrop_original = robjTmdb_backdrop_original.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.ptmdbbackground = Trim(tmdb_backdrop_original)

                Dim tmdb_backdrop_mid As String = ""
                Try
                    Dim robjTmdb_backdrop_mid As New Regex("<backdrop size=""mid"">(.*?)</backdrop>", RegexOptions.Singleline Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                    tmdb_backdrop_mid = robjTmdb_backdrop_mid.Match(s2).Groups(1).Value
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                End Try
                nmovie.ptmdbbackground_thumb = Trim(tmdb_backdrop_mid)
                thelist.Add(nmovie)
                '----------------
                tmdbSearchMatches = tmdbSearchMatches.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        Return thelist
    End Function
#End Region

    Public Function getimdbidsearch(ByVal pmname As String, Optional ByVal tolower As Boolean = True) As String
        Try
            Dim strResult As String = ""
            Try
                Dim robjYearStrip As New Regex(" (\d{4})")
                strResult = robjYearStrip.Replace(pmname, "")
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not strResult = "" Then
                pmname = strResult
            End If

            pmname = Strings.Replace(pmname, "&", "&amp;")
            'http://akas.imdb.com/find?s=tt&q=300&x=5&y=2
            Dim baseurlsiid As String = "http://akas.imdb.com/find?s=tt&q=" + urlencode(pmname) + "&x=0&y=0"
            'Dim foundimdbid, retid, retyr As String
            Dim s As String
            'openpagedata
            Dim request As HttpWebRequest = CType(WebRequest.Create(baseurlsiid), HttpWebRequest)
            Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
            'Me.tp3rtbimdbdata.Text
            If Not tolower Then Return s
            Dim tvarstolower As String = s.ToLower
            Return tvarstolower
            'searchit
            'Dim RegexObj As New Regex("<a href=""/title/(?<greturnedid>tt\d{5,9})/"">Blood Diamond</a>.{1,2}((?<gyear>\d{4}))")
            'retid = RegexObj.Match(Me.tp3rtbimdbdata.Text).Groups("gfilename").Value
            'retyr = RegexObj.Match(Me.tp3rtbimdbdata.Text).Groups("gyear").Value
            'foundimdbid = retyr + retid
            'Return (foundimdbid)
        Catch ex As Exception
            Debug.Print("Error getting IMDB data for " + pmname.ToString + ".")
            Return "NO DATA"
        End Try
    End Function
    Public Sub findsimilarbynameonimdb(ByVal searchname As String, ByRef curlistbox As ListBox)
        Dim v1tstringofimdbpage As String = ""
        v1tstringofimdbpage = getimdbidsearch(searchname, False)
        Dim lookupname As String = searchname '.ToLower
        lookupname = Strings.Replace(lookupname, "(", "")
        lookupname = Strings.Replace(lookupname, ")", "")
        'Dim strResult As String = ""
        'Try
        '    Dim robjYearStrip As New Regex(" (\d{4})")
        '    strResult = robjYearStrip.Replace(lookupname, "")
        'Catch ex As ArgumentException
        '    'Syntax error in the regular expression
        'End Try
        'If Not strResult = "" Then
        '    lookupname = strResult
        'End If

        Dim retid As String = ""
        Try
            retid = Regex.Match(v1tstringofimdbpage, "/(?<imdbid1>tt\d{5,9})/").Groups(1).Value
            'If Not retid = "" Then Return retid
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Dim multimode As Boolean = False
        Dim imdbidlist As New ArrayList
        Try
            Dim RegexObj As New Regex("(tt\d{6,7})(?:/';"">){1}(.{1,255})</a>.\((\d{4})")
            Dim MatchResults As Match = RegexObj.Match(v1tstringofimdbpage)
            While MatchResults.Success
                multimode = True
                Dim nid As New maincollection.imdbsearch
                nid.id = MatchResults.Groups(1).Value.ToString
                nid.name = cleanimdbdata(MatchResults.Groups(2).Value.ToString)
                nid.year = MatchResults.Groups(3).Value.ToString
                imdbidlist.Add(nid)
                MatchResults = MatchResults.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

        'If Not multimode Then Return retid 'return single id if only one was located
        Dim dtIDA As New DataTable
        dtIDA.Columns.Add("Path", GetType(System.String))
        dtIDA.Columns.Add("Name")
        dtIDA.Columns.Add("Index")
        'dtIDA.Columns.Add("objShow")
        Dim thashtable As New Hashtable
        Dim cutcmIndex As Integer = 0
        Try 'jivefix 2nd round
            For Each tcmitem As maincollection.imdbsearch In imdbidlist 'update path info for real code
                Try
                    thashtable.Add(tcmitem.id, tcmitem)
                    dtIDA.LoadDataRow(New Object() {"", tcmitem.name & " (" & tcmitem.year & ")", tcmitem.id}, True)
                Catch ex As Exception
                    Debug.Print("duplicate: " & tcmitem.id)
                End Try
                cutcmIndex += 1
            Next
        Catch exTarray As Exception
            Debug.Print("exTarray failed" + vbNewLine + exTarray.ToString)
        End Try
        dialogTvShowSelect.dhashtable = thashtable
        dtIDA.DefaultView.Sort = "Name"
        curlistbox.DataSource = dtIDA.DefaultView
        curlistbox.ValueMember = "Index"
        curlistbox.DisplayMember = "Name"
        'dialogMovieSelect.displayshowdata()
        'dialogMovieSelect.klblCurMovie.Text = "Name: " + pmname
        'dialogMovieSelect.klblCurMoviePath.Text = "Location on drive: " + addfiletofolder(tmovie.getmoviepath, tmovie.preservedmoviename)
        'dialogMovieSelect.Refresh()
        'dialogMovieSelect.ShowDialog()
        'If dialogMovieSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
        'MsgBox("Cancel Selected, the first id (if one was found) will be used.")
        ' If Not retid = "" Then Return retid
        'Else
        'retid = CStr(dialogMovieSelect.klbPickTheMovie.SelectedValue)
        'retid = Strings.Trim(retid)
        'Return retid
        'End If

        'Debug.Print(selectedshow)
        'dialogTvShowSelect.Dispose()
        'If dbgTVShows Then dlgTVShowCurStatus.Show()
        '        Else
        'Dim tvbdseries1 As New thetvdb.TvSeries
        'tvbdseries1 = CType(tarray.Item(0), TvSeries)
        'selectedshow = tvbdseries1.seriesid
        'selectedshow = Strings.Replace(selectedshow, " ", "")
        '        End If
        '    End If
        'now that we have the showid, use the api to get the data


        'skipping other 2 methods as this one is more generic, may result in more bogus results
        'Return retid
    End Sub
    Public Sub ofdbtoallinlist()
        'Dim total As Integer = maincollection.lbMyMovies.Items.Count
        'Dim cou As Integer = 0
        ''If lbMyMovies.SelectedIndex = -1 Then
        ''    lbMyMovies.SelectedIndex = 0
        ''End If
        'maincollection.autopilotrunning = True
        'maincollection.kscMain.Enabled = False
        'maincollection.lbMyMovies.SelectedIndex = 0
        'While cou <= total
        '    If Not cou >= total Then
        '        maincollection.lbMyMovies.SelectedIndex = cou
        '        set_movie_details_from_ofdb(maincollection.currentmovie)
        '        maincollection.saveNfoFromGuiText(False, True)
        '        'maincollection.kscMain.Enabled = False
        '    End If
        '    cou += 1
        'End While
        'maincollection.autopilotrunning = False
        'maincollection.kscMain.Enabled = True
        ''reload all movie data
        '' maincollection.bwloadfolderdata_TDM()
    End Sub
    Public Function snagimdbid_dlg(ByVal pmname As String, ByRef tmovie As movie, ByRef v1tstringofimdbpage As String) As String
        Dim lookupname As String = pmname '.ToLower
        lookupname = Strings.Replace(lookupname, "(", "")
        lookupname = Strings.Replace(lookupname, ")", "")
        'Dim strResult As String = ""
        'Try
        '    Dim robjYearStrip As New Regex(" (\d{4})")
        '    strResult = robjYearStrip.Replace(lookupname, "")
        'Catch ex As ArgumentException
        '    'Syntax error in the regular expression
        'End Try
        'If Not strResult = "" Then
        '    lookupname = strResult
        'End If

        Dim retid As String = ""
        Try
            retid = Regex.Match(v1tstringofimdbpage, "/(?<imdbid1>tt\d{5,9})/").Groups(1).Value
            'If Not retid = "" Then Return retid
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Dim multimode As Boolean = False
        Dim imdbidlist As New ArrayList
        Try
            Dim RegexObj As New Regex("(tt\d{6,7})(?:/';"">){1}(.{1,255})</a>.\((\d{4})")
            Dim MatchResults As Match = RegexObj.Match(v1tstringofimdbpage)
            While MatchResults.Success
                multimode = True
                Dim nid As New maincollection.imdbsearch
                nid.id = MatchResults.Groups(1).Value.ToString
                nid.name = cleanimdbdata(MatchResults.Groups(2).Value.ToString)
                nid.year = MatchResults.Groups(3).Value.ToString
                imdbidlist.Add(nid)
                MatchResults = MatchResults.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

        If Not multimode Then Return retid 'return single id if only one was located
        Dim dtIDA As New DataTable
        dtIDA.Columns.Add("Path", GetType(System.String))
        dtIDA.Columns.Add("Name")
        dtIDA.Columns.Add("Index")
        'dtIDA.Columns.Add("objShow")
        Dim thashtable As New Hashtable
        Dim cutcmIndex As Integer = 0
        Try 'jivefix 2nd round
            For Each tcmitem As maincollection.imdbsearch In imdbidlist 'update path info for real code
                dtIDA.LoadDataRow(New Object() {tmovie.getmoviepath, "(" & tcmitem.year & ") " & tcmitem.id & ": " & tcmitem.name, tcmitem.id}, True)
                Try
                    thashtable.Add(tcmitem.id, tcmitem)
                Catch ex As Exception
                    Debug.Print("Duplicate Match Found, using that for the id: " & tcmitem.id)
                    Return tcmitem.id
                End Try
                cutcmIndex += 1
            Next
        Catch exTarray As Exception
            Debug.Print("exTarray failed" + vbNewLine + exTarray.ToString)
        End Try
        dialogTvShowSelect.dhashtable = thashtable
        dtIDA.DefaultView.Sort = "Name"
        dialogMovieSelect.klbPickTheMovie.DataSource = dtIDA.DefaultView
        dialogMovieSelect.klbPickTheMovie.ValueMember = "Index"
        dialogMovieSelect.klbPickTheMovie.DisplayMember = "Name"
        'dialogMovieSelect.displayshowdata()
        dialogMovieSelect.klblCurMovie.Text = "Name: " + pmname
        dialogMovieSelect.klblCurMoviePath.Text = "Location on drive: " + tmovie.getmoviepath
        dialogMovieSelect.Refresh()
        dialogMovieSelect.ShowDialog()
        If dialogMovieSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
            'MsgBox("Cancel Selected, the first id (if one was found) will be used.")
            If Not retid = "" Then Return retid
        Else
            retid = CStr(dialogMovieSelect.klbPickTheMovie.SelectedValue)
            retid = Strings.Trim(retid)
            Return retid
        End If

        'Debug.Print(selectedshow)
        'dialogTvShowSelect.Dispose()
        'If dbgTVShows Then dlgTVShowCurStatus.Show()
        '        Else
        'Dim tvbdseries1 As New thetvdb.TvSeries
        'tvbdseries1 = CType(tarray.Item(0), TvSeries)
        'selectedshow = tvbdseries1.seriesid
        'selectedshow = Strings.Replace(selectedshow, " ", "")
        '        End If
        '    End If
        'now that we have the showid, use the api to get the data


        'skipping other 2 methods as this one is more generic, may result in more bogus results
        Return retid
    End Function
    Public Function snagyear(ByVal pmname As String, ByRef tmovie As movie, ByRef vtstringofimdbpage As String) As String
        Dim lookupname As String = pmname.ToLower
        lookupname = Strings.Replace(lookupname, "(", "")
        lookupname = Strings.Replace(lookupname, ")", "")
        Dim RegexObj As New Regex("<a href=""/title/(?<greturnedid>tt\d{5,9})/"">" + lookupname + "</a>.{1,2}((?<gyear>\d{4}))")
        Dim retyear As String = RegexObj.Match(vtstringofimdbpage).Groups("gyear").Value
        If retyear = "" Then
            Dim RegexObj2 As New Regex("<title>" + lookupname + ".{0,2}\((?<groupyear>2008)\)", RegexOptions.IgnoreCase)
            Dim retyear2 As String = RegexObj2.Match(vtstringofimdbpage).Groups("groupyear").Value
            If retyear2 = "" Then
                Dim RegexObj3 As New Regex("\((?<imdbyear>\d{4})\)<br>.{0,6}aka <em>"".{0,4}" + lookupname + ".</em>")
                Dim retyear3 As String = RegexObj3.Match(vtstringofimdbpage).Groups("imdbyear").Value
                If retyear3 = "" Then
                    Dim RegexObj4 As New Regex("<title>.{1,86}\((?<imdbyear4>\d{4})\)</title>")
                    Dim retyear4 = RegexObj4.Match(vtstringofimdbpage).Groups("imdbyear4").Value
                    If retyear4 = "" Then
                        Return "0000"
                    Else
                        tmovie.setyear(Convert.ToInt16(retyear4))
                        ' tbyear.Text = Convert.ToString(tmovie.getyear)
                        Return retyear4
                    End If
                Else
                    tmovie.setyear(Convert.ToInt16(retyear3))
                    'tbyear.Text = Convert.ToString(tmovie.getyear)
                    Return retyear3
                End If
            Else
                tmovie.setyear(Convert.ToInt16(retyear2))
                'tbyear.Text = Convert.ToString(tmovie.getyear)
                Return retyear2
            End If
        Else
            tmovie.setyear(Convert.ToInt16(retyear))
            'tbyear.Text = Convert.ToString(tmovie.getyear)
            Return retyear
        End If
    End Function
End Module
