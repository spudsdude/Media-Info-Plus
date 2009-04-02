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
                File.Move(pathtonfo, pathtonfo & ".oldversion")
                Return True
            End If
            ' Return True
        End If
    End Function
    Public Sub checknfodata(ByRef currentmovie As movie, ByVal dname As String, ByVal workonline As Boolean)

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
                    If strnfoextonfile = ".nfo" Then
                        'read it up to see if we have a tt/d{6,7} in it if we do set haveidonly to true set the id in the movie
                        Dim strwork As String = File.ReadAllText(pathedfile)
                        Try
                            If Regex.IsMatch(strwork, "(tt\d{6,7})") Then
                                currentmovie.pimdbnumber = Regex.Match(strwork, "(tt\d{6,7})").Groups(1).Value

                                haveidonly = True
                            End If
                        Catch ex As ArgumentException
                            'Syntax error in the regular expression
                        End Try
                        Try
                            Dim curdate As Date = Now()
                            Dim addtext As String = "." & curdate.Day.ToString & "-" & curdate.Month.ToString & "-" & curdate.Year.ToString & "." & curdate.TimeOfDay.ToString
                            File.Move(pathedfile, pathedfile & cleanname(addtext) & ".oldversion")
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
                If File.Exists(maincollection.rconf.imdbcachefolder + "/" + currentmovie.pimdbnumber + ".xml") Then 'And Not cbOverwriteNFO.Checked Then
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

    Public Function getimdbidsearch(ByVal pmname As String, Optional ByVal tolower As Boolean = True) As String
        Try
            Dim baseurlsiid As String = "http://akas.imdb.com/find?s=all&q=" + pmname + "+ &x=0&y=0"
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

    Public Function snagimdbid_dlg(ByVal pmname As String, ByRef tmovie As movie, ByRef v1tstringofimdbpage As String) As String
        Dim lookupname As String = pmname '.ToLower
        lookupname = Strings.Replace(lookupname, "(", "")
        lookupname = Strings.Replace(lookupname, ")", "")
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
            Dim RegexObj As New Regex("(tt\d{6,7})(?:/';"">){1}(.{1,255})</a>.\((\d{4})\)")
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
                    Debug.Print("duplicate: " & tcmitem.id)
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
        dialogMovieSelect.klblCurMoviePath.Text = "Location on drive: " + addfiletofolder(tmovie.getmoviepath, tmovie.preservedmoviename)
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
