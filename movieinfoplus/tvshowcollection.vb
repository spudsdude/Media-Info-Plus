Imports System
Imports System.IO
Imports System.Net
Imports System.Text
'Imports System.Windows.Media.Imaging
'Imports System.Windows.Media
'Imports System.Drawing
'Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
'Imports System.Xml
'Imports System.Xml.Serialization
'Imports movieinfoplus
'Imports movieinfoplus.mip.mov
'Imports movieinfoplus.mip.movieserial
'Imports movieinfoplus.mip.themoviedb.backdrop.backdrops
'Imports movieinfoplus.mip.themoviedb.posters.posters
Imports System.Data
'Imports ComponentFactory.Krypton.Toolkit
Imports movieinfoplus.thetvdb
Imports movieinfoplus.tvdblang
Imports System.Xml.Serialization
Public Class showfileobj
    Private p_element_filename As String
    Private p_element_path As String
    Private p_element_newname As String
    Private p_element_newpath As String
    Private p_element_showid As String
    Private p_element_showrootfolder As String
    Private p_element_showname As String
    Private p_element_writecommit As Boolean
    Property filename() As String
        Get
            Return p_element_filename
        End Get
        Set(ByVal value As String)
            p_element_filename = value
        End Set
    End Property
    Property path() As String
        Get
            Return p_element_path
        End Get
        Set(ByVal value As String)
            p_element_path = value
        End Set
    End Property
    Property newname() As String
        Get
            Return p_element_newname
        End Get
        Set(ByVal value As String)
            p_element_newname = value
        End Set
    End Property
    Property newpath() As String
        Get
            Return p_element_newpath
        End Get
        Set(ByVal value As String)
            p_element_newpath = value
        End Set
    End Property
    Property showid() As String
        Get
            Return p_element_showid
        End Get
        Set(ByVal value As String)
            p_element_showid = value
        End Set
    End Property
    Property showname() As String
        Get
            Return p_element_showname
        End Get
        Set(ByVal value As String)
            p_element_showname = value
        End Set
    End Property
    Property showrootfolder() As String
        Get
            Return p_element_showrootfolder
        End Get
        Set(ByVal value As String)
            p_element_showrootfolder = value
        End Set
    End Property
    Property writecommit() As Boolean
        Get
            Return p_element_writecommit
        End Get
        Set(ByVal value As Boolean)
            p_element_writecommit = value
        End Set
    End Property
End Class
Public Class tvshowcollection
    Dim rconf As configuration = maincollection.rconf
    Public Shared curmirror As String = "http://www.thetvdb.com"
    Public Shared miptvdbkey As String = File.ReadAllText(maincollection.rconf.basefolder + "tvdbkey.txt") '"PUT YOUR KEY HERE"
    Dim curlang As String = rconf.tv_curlang
    Public theshows As New Hashtable
    Public guishows()() As ArrayList
    Public episodes As New ArrayList
    Public seasons As New ArrayList
    Public showarrayofallseasons As New ArrayList
    Dim intProgress As Integer = 0
    Dim dbgTVShows As Boolean = False
    Public gvNoShowsList As String = ""
    Public gvFailedEPList As New List(Of showfileobj) ' = ""
    Private Function getparentdirectory(ByRef filenameandpath As String) As String
        Dim fnPeices1() As String = filenameandpath.ToString.Split(CChar("\"))
        Dim parentdirname As String = "" '= fnPeices1(fnPeices1.Length - 1)
        Dim totnum As Integer = fnPeices1.Length - 1
        Dim curcount As Integer = 0
        While curcount < totnum
            parentdirname += fnPeices1(curcount)
            parentdirname += "\"
            curcount += 1
        End While
        Return parentdirname
    End Function
   
    Private Sub setupmirrors()
        Dim tvdbmirrors As New Mirrors
        getmirrors() 'get mirror list and save it
        readmirrors(tvdbmirrors) 'read up that list
        'Debug.Print(tvdbmirrors.Mirrors.Count.ToString)
        'radomize mirror grab (nothing to do yet, there's only 1 mirror)
        'Dim tRandomizer As New Random
        Try
            curmirror = tvdbmirrors.Mirrors(0).Mirrorpath
        Catch ex As Exception
            curmirror = "http://www.thetvdb.com"
        End Try

        Debug.Print("mirror done")
    End Sub
    'bwstatus
    Private Sub bwtvshowstatusinit()

    End Sub
    'Private Sub bwtvshowstatus_progresschanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwtvshowstatus.ProgressChanged
    '    'prgThread.Value = e.ProgressPercentage
    '    If dbgTVShows then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + e.UserState.ToString
    'End Sub

    'Private Sub bwtvshowstatus_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwtvshowstatus.DoWork


    'End Sub
    Private Function progresscounter() As Integer
        intProgress += 1
        Return intProgress
    End Function

    'Public Sub updatebyfolder(ByRef folder As String)
    '    For Each item In Directory.GetFiles(folder)
    '        'insert the search and processing here
    '        'regex on filename to see if it's a movie (or str left)
    '        'if it is, try to grab season and episode info from it
    '        ''regex for that
    '        Try

    '            Dim fnPeices1() As String = item.ToString.Split(CChar("\"))
    '            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)
    '            Select Case Strings.Right(tfname, 4).ToLower
    '                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"
    '                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "parser for : " + item.ToString + " : Result was : " + tfname.ToString
    '                    'have a movie file, parse it for season and episode
    '                    Dim tfnameoffile As String = fnPeices1(fnPeices1.Length - 1)
    '                    Debug.Print(tfnameoffile)
    '                    'run regex on file name (without extension)
    '                    Dim haveseason As Boolean = False
    '                    Dim haveepisode As Boolean = False
    '                    Dim ctv_season As String = ""
    '                    Dim ctv_episode As String = ""
    '                    Dim multiepisode As Boolean = False
    '                    Dim numofepisodes As Integer = 0
    '                    Try
    '                        ctv_season = Regex.Match(tfnameoffile, "(?<season>\d{1,2})[-EeXx](?<episode>[0-9]+)", RegexOptions.IgnoreCase).Groups("season").Value
    '                        If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex1 season resulted in :" + ctv_season
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "check to see if it's a multipart episode"

    '                        Try
    '                            Dim RegexObject1 As New Regex("[-EeXx]([0-9]+)")
    '                            Dim MObj As Match = RegexObject1.Match(tfnameoffile)
    '                            While MObj.Success
    '                                Dim GObj As Group = MObj.Groups(1)
    '                                If GObj.Success Then
    '                                    numofepisodes += 1
    '                                    If numofepisodes > 1 Then
    '                                        ctv_episode += ":" + MObj.Groups(1).Value
    '                                    Else
    '                                        ctv_episode = MObj.Groups(1).Value 'Regex.Match(tfnameoffile, "[-EeXx](?<episode>[0-9]+)", RegexOptions.IgnoreCase).Groups("episode").Value
    '                                    End If
    '                                End If
    '                                MObj = MObj.NextMatch()
    '                            End While
    '                        Catch ex As ArgumentException
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString ' Syntax error in the regular expression
    '                        End Try
    '                        If numofepisodes > 1 Then
    '                            multiepisode = True
    '                            'MsgBox(numofepisodes.ToString + " " + ctv_episode)
    '                        Else
    '                            multiepisode = False
    '                        End If

    '                        If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex1 episode resulted in :" + ctv_episode
    '                        If Not ctv_season = "" Then haveseason = True
    '                        If Not ctv_episode = "" Then haveepisode = True
    '                        If Not (haveepisode And haveseason) Then
    '                            haveepisode = False
    '                            haveseason = False
    '                        End If
    '                    Catch ex As ArgumentException
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString 'Syntax error in the regular expression
    '                    End Try
    '                    'if it has season and episode, then write nfo and tbn for it

    '                    If Not (haveseason And haveepisode) Then
    '                        Try
    '                            ctv_season = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("season").Value
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 season resulted in :" + ctv_season
    '                            ctv_episode = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("episode").Value
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 episode resulted in :" + ctv_episode
    '                            If Not ctv_season = "" Then haveseason = True
    '                            If Not ctv_episode = "" Then haveepisode = True
    '                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
    '                            If Not (haveepisode And haveseason) Then
    '                                haveepisode = False
    '                                haveseason = False
    '                            End If
    '                            multiepisode = False
    '                        Catch ex As ArgumentException
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString 'Syntax error in the regular expression
    '                        End Try
    '                        'if it has season and episode, then write nfo and tbn for it

    '                    End If
    '                    If Not (haveseason And haveepisode) And Not rconf.ptvregx1 = "" Then
    '                        Try
    '                            ctv_season = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(1).Value
    '                            If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex season resulted in :" + ctv_season
    '                            Debug.Print("Regex3 season resulted in :" + ctv_season)
    '                            ctv_episode = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(2).Value
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex episode resulted in :" + ctv_episode
    '                            Debug.Print("Regex3 episode resulted in :" + ctv_episode)
    '                            If Not ctv_season = "" Then haveseason = True
    '                            If Not ctv_episode = "" Then haveepisode = True
    '                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
    '                            If Not (haveepisode And haveseason) Then
    '                                haveepisode = False
    '                                haveseason = False
    '                            End If
    '                        Catch ex As ArgumentException
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString
    '                        End Try
    '                    End If

    '                    ''if it has season and episode, then write nfo and tbn for it
    '                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Regex Completed --------------"
    '                    If Not (haveepisode And haveepisode) Then
    '                        Dim newfailedshow As New showfileobj
    '                        newfailedshow.filename = tfnameoffile
    '                        newfailedshow.path = getparentdirectory(item)
    '                        newfailedshow.showid = ""
    '                        newfailedshow.showrootfolder = curtvshowpath
    '                        newfailedshow.showname = xbmctvshow1.Title
    '                        newfailedshow.showid = xbmctvshow1.Tvdbid
    '                        newfailedshow.writecommit = False
    '                        gvFailedEPList.Add(newfailedshow) ' += vbNewLine + tfnameoffile
    '                    End If
    '                    If (haveepisode And haveseason) And Not multiepisode Then
    '                        If ctv_episode = "0" Then ctv_episode = "00"
    '                        numtvshowstotal += 1 'numofepisodes
    '                        Dim tepisode1 As New tvdblangEpisode
    '                        tepisode1.miptvdbkey = miptvdbkey
    '                        tepisode1.mutlipart = False
    '                        'get espisode data
    '                        Try
    '                            tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episode), tvdblangEpisode)
    '                            tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
    '                        Catch ex As Exception
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "error pulling episode from array theshows"
    '                            'curepcou += 1
    '                            Continue For 'next for'Continue While 'break out of loop
    '                        End Try

    '                        If Not tepisode1 Is Nothing Then
    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Getting episode image --------------"
    '                            curseason.episodes.Add(tepisode1)
    '                            If rconf.tv_episode_download_boolean Then
    '                                If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
    '                                    'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
    '                                    If Not tepisode1.Filename = "" Then
    '                                        wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
    '                                    End If
    '                                End If
    '                                If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
    '                                    'we should now have it in cache
    '                                    'check episode thumb overwrite option in conf
    '                                    If rconf.tv_episode_overwrite_tbn Then
    '                                        File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
    '                                    Else
    '                                        Try
    '                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
    '                                        Catch ex As Exception
    '                                            'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
    '                                            Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
    '                                        End Try

    '                                    End If
    '                                End If
    '                            End If
    '                            tepisode1.fullfilenameandpath = item
    '                            Dim writnfo As Boolean = False
    '                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
    '                            If rconf.tv_episode_overwrite_nfo Then writnfo = True 'tv_tvshow_nfo_overwrite_boolean
    '                            If writnfo Then
    '                                'get media data
    '                                maincollection.pbar1.Visible = True
    '                                maincollection.lblPbar.Visible = True
    '                                maincollection.lblPbar.BringToFront()
    '                                maincollection.lblPbar.Text = "-- Working On: " + item + "--"
    '                                maincollection.Refresh()
    '                                Dim curmedinfo As New MediaInfo
    '                                curmedinfo.getdata(tepisode1, True)
    '                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
    '                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror)
    '                                xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
    '                            End If

    '                        End If
    '                    ElseIf (haveepisode And haveseason) And multiepisode Then 'multiepisode
    '                        'create mutliepisode obj
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Multipart Episode Found"
    '                        Dim curxbmcmultiepisode As New xbmc.xbmcmultiepisode

    '                        numtvshowstotal += numofepisodes
    '                        'split episodes at the : 
    '                        Dim epPeices() As String = ctv_episode.Split(CChar(":"))
    '                        Dim epcoutot As Integer = epPeices.Length
    '                        Dim curepcou As Integer = 0
    '                        While curepcou < epcoutot
    '                            Dim ctv_episodepiece As String = epPeices(curepcou)
    '                            'get 2 digit version of episode data
    '                            If Strings.Left(ctv_episodepiece, 1) = "0" And ctv_episodepiece.Length >= 1 Then
    '                                ctv_episodepiece = Strings.Right(ctv_episodepiece, ctv_episodepiece.Length - 1)
    '                            End If

    '                            Dim tepisode1 As New tvdblangEpisode

    '                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "get espisode data"
    '                            If ctv_episodepiece = "0" Then ctv_episodepiece = "00"
    '                            Try
    '                                tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episodepiece), tvdblangEpisode)
    '                                tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
    '                                tepisode1.miptvdbkey = miptvdbkey
    '                                tepisode1.mutlipart = True
    '                            Catch ex As Exception
    '                                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "error pulling episode from array theshows"
    '                                curepcou += 1
    '                                Continue While
    '                                'Continue While 'break out of loop
    '                            End Try

    '                            If Not tepisode1 Is Nothing Then
    '                                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Getting episode image --------------"
    '                                curseason.episodes.Add(tepisode1)
    '                                If rconf.tv_episode_download_boolean Then
    '                                    If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
    '                                        'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
    '                                        If Not tepisode1.Filename = "" Then
    '                                            wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
    '                                        End If
    '                                    End If
    '                                    If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
    '                                        'we should now have it in cache
    '                                        'check episode thumb overwrite option in conf
    '                                        If rconf.tv_episode_overwrite_tbn Then
    '                                            File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
    '                                        Else
    '                                            Try
    '                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
    '                                            Catch ex As Exception
    '                                                'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
    '                                                Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
    '                                            End Try
    '                                        End If
    '                                    End If
    '                                    'asdf()
    '                                End If
    '                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
    '                                tepisode1.fullfilenameandpath = item
    '                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror)
    '                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then
    '                                    maincollection.pbar1.Visible = True
    '                                    maincollection.lblPbar.Visible = True
    '                                    maincollection.lblPbar.BringToFront()
    '                                    maincollection.lblPbar.Text = "Scanning: " + getfilefrompath(item) '+ "--"
    '                                    maincollection.Refresh()
    '                                    Dim curmedinfo As New MediaInfo
    '                                    curmedinfo.getdata(tepisode1, True)
    '                                End If
    '                                curxbmcmultiepisode.episodes.Add(xbmced1)
    '                                curepcou += 1
    '                                'xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")

    '                            End If

    '                        End While
    '                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Writing .nfo file: " + Strings.Left(item.ToString, item.Length - 4) + ".nfo"
    '                        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
    '                        Dim writnfo As Boolean = False
    '                        If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
    '                        If rconf.tv_episode_overwrite_nfo Then writnfo = True
    '                        If writnfo Then
    '                            curxbmcmultiepisode.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
    '                        End If
    '                        'Dim epname As String = epPeices(epPeices.Length - 1)


    '                    End If
    '                    'End If
    '                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Done episode processing of single item, movie to next or end --------------"
    '                Case Else
    '                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Non Movie File: " + item.ToString + " : " + tfname.ToString
    '            End Select
    '            filelisting.Add(item)
    '        Catch ex As Exception 'catch bad filename or location exception
    '            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString
    '        End Try
    '    Next
    'End Sub
    Public Sub kbLoadTvShows(Optional ByVal debugon As Boolean = False, Optional ByVal dlo As Boolean = False)
        gvNoShowsList = "" 'clear out the no show data list var

        'Dim stpw As New Stopwatch
        'stpw.Start()
        rconf = rconf.getconfig("config", True)

        If rconf.debugtvshows Or debugon Then
            dbgTVShows = True
        End If
        Dim boguscounter As Integer = 0
        'report progress test
        'dlgTVShowCurStatus.bwtvshowstatus.ReportProgress(progresscounter, "test")
        'setupmirrors()

        'get updates file from server

        Dim tdate As String = ""
        ' getdatesfromtvdb(tdate)
        Debug.Print("getdatefromtvdb done")

        'http://www.thetvdb.com/api/<apikey>/updates/

        'read up xml file for data
        'Dim thetvdbdata As New tvdbData
        'thetvdbdata.readMirrorsXML("c:\program files\movieinfoplus\themoviedbdates.xml", thetvdbdata)


        'Debug.Print("load themoviedbdates done" + System.DateTime.Now.ToString)
        'get all data
        '<mirrorpath_zip>/api/<apikey>/all/<language>.zip
        'wgetTVDB(curmirror + "/api/" + miptvdbkey + "/all/" + curlang + ".zip", "everything", True)
        'dlgTVShowCurStatus.bwtvshowstatus.ReportProgress(progresscounter, "reading drop down")


        If dbgTVShows Then dlgTVShowCurStatus.Show()
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Reading Folder Data"
        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()


        '//TODO Read up folders or some other source for the list of folder names, ignore anything containing .tolower "season"
        'maincollection.lbTVShows.Items.Add("House")
        'maincollection.lbTVShows.Items.Add("House")
        'kcbShowPicker.Items.Add("Supernatural")
        'fake the funk of drop down reading
        'Dim myseries As New tvdbData
        'myseries.Serieses.
        Dim maindttv As New DataTable
        maindttv.Columns.Add("Path", GetType(System.String))
        maindttv.Columns.Add("Name")
        maindttv.Columns.Add("TvdbidNum")
        maindttv.Columns.Add("Index")
        Dim showcount As Integer = 0
        Dim tvshowarray As New ArrayList
        'bwchanges
        'tvshowarray = passedtvshowarray

        For Each item In rconf.pclbTVPaths 'maincollection.lbTVShows.CheckedItems
            'ennum sub dir x levels deep
            Dim curdircontents() As String
            curdircontents = Directory.GetDirectories(item.ToString)
            For Each currentdir As String In curdircontents
                Try
                    If Not validshowdirc(currentdir) Then 'Strings.Right(currentdir.ToUpper, 8) = "RECYCLER" Or Strings.Right(currentdir.ToLower, 8) = "(noscan)" Or Strings.Right(currentdir.ToUpper, 10) = "LOST+FOUND" Or currentdir.ToUpper.Contains("System Volume Information".ToUpper) Then
                        'dont add it
                    Else
                        If Not File.Exists(currentdir & "\noscan") Then tvshowarray.Add(currentdir)
                    End If

                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
            Next
        Next

        While showcount < tvshowarray.Count
            'see if we have any info about the show
            'grab the latest zip file for show
            'find the key first
            'maincollection.lbTVShows.SelectedIndex = showcount
            Dim showfullpathname As String = tvshowarray(showcount).ToString
            Dim fnPeices1() As String = showfullpathname.ToString.Split(CChar("\"))
            Dim tfname As String = Strings.Replace(fnPeices1(fnPeices1.Length - 1), "_", " ")
            tfname = Strings.Replace(tfname, ".", " ")
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + vbNewLine + "-----------------------------------------"
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Processing: " + tfname
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-----------------------------------------"
            Dim selectedshow As String = ""
            Dim tvshownfooverwrite As Boolean = False
            If File.Exists(showfullpathname + "\tvshow.nfo") Then
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Found tvshow.nfo.. attempting to load..."
                'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                'read it to get the series id and set tvshowoverwrite to false
                Dim xbmctvshow1 As New xbmc.xbmcTvshow
                Try
                    xbmctvshow1.readXML(showfullpathname + "\tvshow.nfo", xbmctvshow1)
                    selectedshow = xbmctvshow1.Tvdbid
                    selectedshow = Strings.Replace(selectedshow, " ", "")
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "TMDB ID: " + selectedshow
                    'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                    If Not selectedshow = "" Then tvshownfooverwrite = True
                Catch ex As Exception
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "had an .nfo file, but no xml, the .nfo was not created with MIP, I'll need to grab the full data set."
                    selectedshow = ""
                End Try

                'maindttv.LoadDataRow(New Object() {showfullpathname, xbmctvshow1.Title, showcount}, True)
                'showcount += 1
                'Continue While 'break out of while loop, it's not needed
            End If

            If selectedshow = "" Then
                getTVSeriesList(tfname)
                'Dim tstring As String = httpget(curmirror + "/api/GetSeries.php?seriesname=" + kcbShowPicker.Items(showcount).ToString)
                'Debug.Print(tstring)
                Dim temptvshowdata As New TVSeriesData
                temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + tfname + ".xml", temptvshowdata)
                Dim tarray As New ArrayList
                Try

                    For Each item In temptvshowdata.SeriesArray
                        tarray.Add(item)
                    Next

                Catch ex As Exception
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "No TV Show data exsists for: " + tfname
                    gvNoShowsList += vbNewLine + tfname
                    'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                    showcount += 1
                    Continue While
                End Try

                If Not tarray.Count = 1 Then
                    Dim dtIDA As New DataTable
                    dtIDA.Columns.Add("Path", GetType(System.String))
                    dtIDA.Columns.Add("Name")
                    dtIDA.Columns.Add("Index")
                    dtIDA.Columns.Add("objShow")
                    Dim thashtable As New Hashtable
                    Dim cutcmIndex As Integer = 0
                    Try 'jivefix 2nd round
                        For Each tcmitem As thetvdb.TvSeries In tarray 'update path info for real code
                            dtIDA.LoadDataRow(New Object() {showfullpathname, tcmitem.SeriesName, tcmitem.seriesid, tcmitem}, True)
                            thashtable.Add(tcmitem.seriesid, tcmitem)
                            cutcmIndex += 1
                        Next
                    Catch exTarray As Exception
                        Debug.Print("exTarray failed" + vbNewLine + exTarray.ToString)
                    End Try
                    dialogTvShowSelect.dhashtable = thashtable
                    dtIDA.DefaultView.Sort = "Name"
                    dialogTvShowSelect.klbPickTheTvShow.DataSource = dtIDA.DefaultView
                    dialogTvShowSelect.klbPickTheTvShow.ValueMember = "Index"
                    dialogTvShowSelect.klbPickTheTvShow.DisplayMember = "Name"
                    dialogTvShowSelect.displayshowdata()
                    dialogTvShowSelect.klbltvCurShow.Text = "TV Show Folder Name: " + tfname
                    dialogTvShowSelect.klbltvCurShowPath.Text = "TV Show Location on drive: " + showfullpathname
                    dialogTvShowSelect.Refresh()
                    If dbgTVShows Then dlgTVShowCurStatus.Hide()
                    dialogTvShowSelect.ShowDialog()
                    If dialogTvShowSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                        MsgBox("Cancel Selected, the show has not been added.")
                        showcount += 1
                        Continue While
                    Else
                        selectedshow = CStr(dialogTvShowSelect.klbPickTheTvShow.SelectedValue)
                        selectedshow = Strings.Replace(selectedshow, " ", "")
                    End If

                    Debug.Print(selectedshow)
                    dialogTvShowSelect.Dispose()
                    If dbgTVShows Then dlgTVShowCurStatus.Show()
                Else
                    Dim tvbdseries1 As New thetvdb.TvSeries
                    tvbdseries1 = CType(tarray.Item(0), TvSeries)
                    selectedshow = tvbdseries1.seriesid
                    selectedshow = Strings.Replace(selectedshow, " ", "")
                End If
            End If
            'now that we have the showid, use the api to get the data
            'get the zip file (5 day updates, add gui option to set amount of days to check for updates)
            Dim numtoaddfromconf As Integer = 5
            numtoaddfromconf = CInt(rconf.pcombolTVCheckForNewTVShowData)
            'If File.GetLastWriteTime(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip").AddDays(numtoaddfromconf) < Date.Now Then
            '    If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
            '    If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
            '    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
            'End If



            '--------------------------------------Section Start----------------------------------------
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            'read in banners.xml and then process it
            Dim tbanners As New Banners
            Try
                tbanners.readBannerXML(rconf.tvdbcachefolder + selectedshow + "\banners.xml", tbanners)
            Catch ex As Exception
                'asdf()
                decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                MsgBox("Error in banner read: " + vbNewLine + rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print(rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print("unable to load xml file from cache folder")
                showcount += 1
                Continue While 'break out of while loop, no data in banners 
            End Try

            'download banners/fanarts/posters/etc
            Dim fanartcounter As Integer = 0
            Dim postercounter As Integer = 0
            Dim seasoncounter As Integer = 0
            Dim seriescounter As Integer = 0
            'check for folders
            'rconf.tv_usewgetforimages = False

            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\blank") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\blank")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\text") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\text")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\poster") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\poster")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\posters") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\posters")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\series") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\series")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\season") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\season")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes")
            For Each tmbanner As BannersBanner In tbanners.Banners
                If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'check language and match it, if no match, skip it
                    'See If the file already exsists

                    Dim switchpath As String = Strings.Replace(tmbanner.BannerPath, "/", "\")
                    Debug.Print(switchpath)

                    Select Case tmbanner.BannerType.ToLower
                        Case "fanart"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Fanart Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_fanart_download_boolean And fanartcounter < rconf.tv_tvshow_fanart_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvfanart(tmbanner, selectedshow, switchpath)
                                    If fanartcounter = 1 Or Not File.Exists(showfullpathname + "\fanart.jpg") Then
                                        If Not File.Exists(showfullpathname + "\fanart.jpg") Then
                                            File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\fanart.jpg") '-- copy fanart as fanart.jpg
                                        End If
                                    End If
                                End If
                            End If

                            fanartcounter += 1
                        Case "poster"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Poster Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_posters_download_boolean And postercounter < rconf.tv_tvshow_posters_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvposters(tmbanner, selectedshow, switchpath)
                                    If Not File.Exists(showfullpathname + "\season-all.tbn") Then
                                        File.Copy(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, showfullpathname + "\season-all.tbn")
                                    End If
                                    If Not File.Exists(showfullpathname + "\folder.jpg") Then
                                        If rconf.prbshows_show_usewide_false4poster = False Then
                                            File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\folder.jpg") '-- copy fanart as fanart.jpg
                                        End If
                                    End If
                                End If
                            End If
                            postercounter += 1
                        Case "season"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Season Items: " + switchpath
                            Dim boolGetSeason As Boolean = False
                            Dim boolGetSeasonwide As Boolean = False
                            If rconf.tv_season_banners_download_type_string.ToLower Is Nothing Then
                                rconf.tv_season_banners_download_type_string = "all"
                            End If
                            If rconf.tv_season_banners_download_type_string.ToLower = "" Then
                                rconf.tv_season_banners_download_type_string = "all"
                            End If
                            Try
                                If rconf.tv_season_banners_download_type_string.ToLower = "all" Then
                                    boolGetSeason = True
                                    boolGetSeasonwide = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "season" Then
                                    boolGetSeason = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "seasonwide" Then
                                    boolGetSeasonwide = True
                                End If
                                'workaround for busted configs where the value isn't entered correctly
                                If boolGetSeason = False And boolGetSeasonwide = False Then boolGetSeason = True
                            Catch ex As Exception
                                boolGetSeason = True
                                Debug.Print(ex.ToString)
                                MsgBox("Configuration setting is missing for season selection, please report this bug and include a copy of your config.xml file")
                            End Try


                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'And rconf.tv_getseasonbanners And seasoncounter < rconf.tv_maxtvseasonbanners Then
                                'jive fix'If tmbanner.BannerType2.ToLower = "season" And boolGetSeason And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'jive fix'If tmbanner.BannerType2.ToLower = "seasonwide" And boolGetSeasonwide And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'season auto creation

                                'check series length
                                Dim vSeasonLen As Integer = tmbanner.Season.Length
                                Dim vSeasonPreText As String = ""

                                If vSeasonLen = 1 Then vSeasonPreText = "season0"
                                If vSeasonLen >= 2 Then vSeasonPreText = "season"

                                Dim vSeasonNumConcat As String = vSeasonPreText + tmbanner.Season.ToString
                                If tmbanner.BannerType2.ToLower = rconf.tv_season_banners_toapply_string Then

                                    Dim tvSeasonPreText As String = ""
                                    If vSeasonLen = 1 Then tvSeasonPreText = "Season"
                                    If vSeasonLen >= 2 Then tvSeasonPreText = "Season"
                                    'this way, each numbered season gets a season banner
                                    'add season image to folders
                                    Dim curfolder As String = showfullpathname + "\" + tvSeasonPreText + " " + tmbanner.Season.ToString + "\"
                                    Dim fnamet As String = "folder.jpg"
                                    Dim curfolder2 As String = showfullpathname + "\" + tvSeasonPreText + "_" + tmbanner.Season.ToString + "\"
                                    Dim filetocopy As String = ""
                                    If File.Exists(showfullpathname + "\" + vSeasonNumConcat + ".tbn") Then
                                        filetocopy = showfullpathname + "\" + vSeasonNumConcat + ".tbn"
                                    Else
                                        filetocopy = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
                                    End If

                                    If Directory.Exists(curfolder) Then
                                        If Not File.Exists(curfolder & fnamet) Then
                                            File.Copy(filetocopy, curfolder & fnamet)
                                        End If
                                    End If

                                    If Directory.Exists(curfolder2) Then
                                        If Not File.Exists(curfolder2 & fnamet) Then
                                            File.Copy(filetocopy, curfolder2 & fnamet)
                                        End If
                                    End If

                                    If Not File.Exists(showfullpathname + "\" + vSeasonNumConcat + ".tbn") And File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then
                                        File.Copy(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, showfullpathname + "\" + vSeasonNumConcat + ".tbn")
                                    End If
                                    seasoncounter += 1
                                End If
                            End If

                        Case "series" 'note: series is the wide icons, with different text (or graphical version of text, or no text) for the tvshow
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Series Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_wideicon_download_boolean And seriescounter < rconf.tv_tvshow_wideicon_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvseriesbanners(tmbanner, selectedshow, switchpath)
                                    If seriescounter = 1 Then
                                        If Not File.Exists(showfullpathname + "\folder.jpg") Then
                                            If rconf.prbshows_show_usewide_false4poster = True Then
                                                File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\folder.jpg") '-- copy fanart as fanart.jpg
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            seriescounter += 1
                    End Select
                End If
                'End If
            Next
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            '--------------------------------------Section END------------------------------------------
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Done with Banners Fanart and Posters"
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Processing Actors Data"
            'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
            Dim newtvdbData As New tvdblangData
            Dim newactors As New Actors
            newactors.readXML(rconf.tvdbcachefolder + selectedshow + "\Actors.xml", newactors)
            'tvdblangseries2xbmcTvshow()
            Dim xbmctvshow As New xbmc.xbmcTvshow
            Try
                newtvdbData.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbData)
                Debug.Print("read completed")
                newtvdbData.Series.tvdblangseries2xbmcTvshow(newtvdbData.Series, xbmctvshow, newactors)
                xbmctvshow.Genre = Strings.Replace(xbmctvshow.Genre, "|", "/")
                Try
                    If xbmctvshow.Genre.Length > 0 And Strings.Left(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Right(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                    If xbmctvshow.Genre.Length > 0 And Strings.Right(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Left(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
                xbmctvshow.Episodeguideurl = "http://www.thetvdb.com/api/1D62F2F90030C444/series/" + selectedshow + "/all/" + curlang + ".zip"

                If rconf.pcbshows_UseStudioasRating Then 'digitalhigh request
                    xbmctvshow.Rating = studiotorating(xbmctvshow.Studio).ToString
                Else
                    'xbmctvshow.Rating = xbmctvshow.Studio
                End If
                xbmctvshow.writeXML(showfullpathname) '"c:\")
                'add show to datatable
                maindttv.LoadDataRow(New Object() {showfullpathname + ":" + xbmctvshow.Tvdbid + ":", xbmctvshow.Title, xbmctvshow.Tvdbid, showcount}, True)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try


            'Next




            'wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + tseriesname.Id + "/all/" + curlang + ".zip", "everything", True)
            showcount += 1
        End While
        maindttv.DefaultView.Sort = "Name"
        'System.Threading.Thread.Sleep(10000)
        maincollection.tbloftvshows = maindttv
        maincollection.lbTvShowPicker.ValueMember = "Path"
        maincollection.lbTvShowPicker.DisplayMember = "Name"
        maincollection.lbTvShowPicker.AccessibleName = "TvdbidNum"
        maincollection.lbTvShowPicker.DataSource = maindttv.DefaultView
        'main series is done, now process for episodes

        'process episodes
        'for each show in kcbshowpicker drop down, load that tvshow.nfo
        'stpw.Stop()
        'MsgBox(stpw.Elapsed.ToString)
        Exit Sub

        'For Each tseriesname In thetvdbdata.Serieses
        '    'http://thetvdb.com/api/miptvdbkey/series/73141/all/en.zip'
        '    'http://thetvdb.com/api/miptvdbkey/all/series/70355/all/en.zip
        '    If Not File.Exists("C:\Program Files\movieinfoplus\temp\tvdb\everything\" + tseriesname.Id + ".zip") Then
        '        System.Threading.Thread.Sleep(10000)
        '        wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + tseriesname.Id + "/all/" + curlang + ".zip", "everything", True)
        '    Else
        '        Debug.Print("Already have: " + tseriesname.Id)
        '    End If

        'Debug.Print(tseriesname.Id)
        'Dim tstring As String = httpget(curmirror + "/api/GetSeries.php?seriesname=" + tseriesname.Id)
        'Debug.Print(tstring)
        'Next
        'stpw.Start()
        updatetvshows()
    End Sub
    Private Function studiotorating(ByVal curstringname As String) As Integer
        Select Case curstringname.ToLower
            Case "a&e"
                Return 1
            Case "abc"
                Return 2
            Case "abc family"
                Return 3
            Case "adult swim"
                Return 4
            Case "amc"
                Return 5
            Case "animal planet"
                Return 6
            Case "bbc"
                Return 7
            Case "bbc2"
                Return 8
            Case "bet"
                Return 9
            Case "bravo"
                Return 10
            Case "cartoon network"
                Return 11
            Case "cbs"
                Return 12
            Case "channel 4 uk"
                Return 13
            Case "comedy central"
                Return 14
            Case "cw"
                Return 15
            Case "discovery"
                Return 16
            Case "disney"
                Return 17
            Case "espn"
                Return 18
            Case "food network"
                Return 19
            Case "fox"
                Return 20
            Case "fx"
                Return 21
            Case "hbo"
                Return 22
            Case "history"
                Return 23
            Case "msnbc"
                Return 24
            Case "mtv"
                Return 25
            Case "my tv"
                Return 26
            Case "nbc"
                Return 27
            Case "nickelodeon"
                Return 28
            Case "pbs"
                Return 29
            Case "scifi"
                Return 30
            Case "showtime"
                Return 31
            Case "space"
                Return 32
            Case "spike"
                Return 33
            Case "tbs"
                Return 34
            Case "tnt"
                Return 35
            Case "upn"
                Return 36
            Case "usa"
                Return 37
            Case "versus"
                Return 38
            Case "vh1"
                Return 39
            Case "wgn"
                Return 40
            Case "Syndicated"
                Return 41
            Case Else
                Return 0
        End Select

    End Function

  
    Public Sub updatetvshows()
        'Dim stpw2 As New Stopwatch
        'stpw2.Start()
        gvFailedEPList.Clear() ' = ""
        'dlgTVShowCurStatus.Show()
        'dlgTVShowCurStatus.Refresh()
        'dlgTVShowCurStatus.BringToFront()
        'System.Threading.Thread.Sleep(100)
        'get nfo file for item in dropdown
        'load that info into the hashtable
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Scanning / Update tv shows started"
        Dim numtvshowstotal As Integer = 0
        Dim counter As Integer = 0
        While counter < maincollection.lbTvShowPicker.Items.Count
            maincollection.lbTvShowPicker.SelectedIndex = counter
            Dim curtvshowpath As String = maincollection.lbTvShowPicker.SelectedValue.ToString
            'strip out the id from the path'
            Dim theid As String = Regex.Match(curtvshowpath, "(:\d*?:)").Groups(1).Value
            curtvshowpath = Strings.Replace(curtvshowpath, theid, "")

            Dim xbmctvshow1 As New xbmc.xbmcTvshow
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Attempting to read: " + curtvshowpath + "\tvshow.nfo"
            'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
            Try
                xbmctvshow1.readXML(curtvshowpath + "\tvshow.nfo", xbmctvshow1)
            Catch ex As Exception
                Debug.Print(ex.ToString)
                counter += 1
                Continue While
            End Try
            'create completetvshow object
            Dim curCompleteShow As New completeshows
            curCompleteShow.tvshowname = xbmctvshow1.Title
            curCompleteShow.tvshowid = xbmctvshow1.Tvdbid
            curCompleteShow.showpath = curtvshowpath + "\tvshow.nfo"
            Dim curseason As New seasons
            curseason.seasonnumber = "1" 'basic for now, later this will have to change
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-- read nfo for show completed --"
            Dim selectedshow As String = xbmctvshow1.Tvdbid
            Dim newtvdbdata As New tvdblangData
            Try

                newtvdbdata.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbdata)
                For Each tepisode In newtvdbdata.Episodes
                    Try
                        theshows.Add(tepisode.Seriesid + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber, tepisode)
                        'Debug.Print("Known episodes from tvdb data in " + tepisode.Seriesid + "  are: " + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "duplicate or invalid episode" + ex.ToString
                    End Try

                Next

            Catch ex As Exception
                MsgBox("No TV Shows found for: " + curtvshowpath)
                counter += 1
                Continue While
            End Try
            'enumdir and see what we have
            Dim tarray As New ArrayList
            Dim tdtvlist_count As Integer = 0
            EnumTVDirectory(curtvshowpath, tarray, tdtvlist_count)
            'get all files for all directorys in that path and put into arraylist
            Dim filelisting As New ArrayList
            For Each tdirectory As String In tarray
                Try
                    For Each item In Directory.GetFiles(tdirectory)
                        'insert the search and processing here
                        'regex on filename to see if it's a movie (or str left)
                        'if it is, try to grab season and episode info from it
                        ''regex for that
                        Try

                            Dim fnPeices1() As String = item.ToString.Split(CChar("\"))
                            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)
                            Select Case Strings.Right(tfname, 4).ToLower
                                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"
                                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "parser for : " + item.ToString + " : Result was : " + tfname.ToString
                                    'have a movie file, parse it for season and episode
                                    Dim tfnameoffile As String = fnPeices1(fnPeices1.Length - 1).ToLower
                                    tfnameoffile = Strings.Replace(tfnameoffile, ".x264", "")
                                    tfnameoffile = Strings.Replace(tfnameoffile, ".2hd", "")
                                    Debug.Print(tfnameoffile)
                                    'run regex on file name (without extension)
                                    Dim haveseason As Boolean = False
                                    Dim haveepisode As Boolean = False
                                    Dim ctv_season As String = ""
                                    Dim ctv_episode As String = ""
                                    Dim multiepisode As Boolean = False
                                    Dim numofepisodes As Integer = 0
                                    Try
                                        ctv_season = Regex.Match(tfnameoffile, "(?<season>\d{1,2})[-EeXx](?<episode>[0-9]+)", RegexOptions.IgnoreCase).Groups("season").Value
                                        If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex1 season resulted in :" + ctv_season
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "check to see if it's a multipart episode"

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
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString ' Syntax error in the regular expression
                                        End Try
                                        If numofepisodes > 1 Then
                                            multiepisode = True
                                            'MsgBox(numofepisodes.ToString + " " + ctv_episode)
                                        Else
                                            multiepisode = False
                                        End If

                                        If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex1 episode resulted in :" + ctv_episode
                                        If Not ctv_season = "" Then haveseason = True
                                        If Not ctv_episode = "" Then haveepisode = True
                                        If Not (haveepisode And haveseason) Then
                                            haveepisode = False
                                            haveseason = False
                                        End If
                                    Catch ex As ArgumentException
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString 'Syntax error in the regular expression
                                    End Try
                                    'if it has season and episode, then write nfo and tbn for it

                                    If Not (haveseason And haveepisode) Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("season").Value
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 season resulted in :" + ctv_season
                                            ctv_episode = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("episode").Value
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Regex2 episode resulted in :" + ctv_episode
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                            multiepisode = False
                                        Catch ex As ArgumentException
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString 'Syntax error in the regular expression
                                        End Try
                                        'if it has season and episode, then write nfo and tbn for it

                                    End If
                                    If Not (haveseason And haveepisode) And Not rconf.ptvregx1 = "" Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(1).Value
                                            If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex season resulted in :" + ctv_season
                                            Debug.Print("Regex3 season resulted in :" + ctv_season)
                                            ctv_episode = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(2).Value
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Custom Regex episode resulted in :" + ctv_episode
                                            Debug.Print("Regex3 episode resulted in :" + ctv_episode)
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                        Catch ex As ArgumentException
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString
                                        End Try
                                    End If

                                    ''if it has season and episode, then write nfo and tbn for it
                                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Regex Completed --------------"
                                    If Not (haveepisode And haveepisode) Then
                                        Dim newfailedshow As New showfileobj
                                        newfailedshow.filename = tfnameoffile
                                        newfailedshow.path = getparentdirectory(item)
                                        newfailedshow.showid = ""
                                        newfailedshow.showrootfolder = curtvshowpath
                                        newfailedshow.showname = xbmctvshow1.Title
                                        newfailedshow.showid = xbmctvshow1.Tvdbid
                                        newfailedshow.writecommit = False
                                        gvFailedEPList.Add(newfailedshow) ' += vbNewLine + tfnameoffile
                                    End If
                                    If (haveepisode And haveseason) And Not multiepisode Then
                                        If ctv_episode = "0" Then ctv_episode = "00"
                                        numtvshowstotal += 1 'numofepisodes
                                        Dim tepisode1 As New tvdblangEpisode
                                        tepisode1.miptvdbkey = miptvdbkey
                                        tepisode1.mutlipart = False
                                        'get espisode data
                                        Try
                                            tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episode), tvdblangEpisode)
                                            tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                        Catch ex As Exception
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "error pulling episode from array theshows"
                                            'curepcou += 1
                                            Continue For 'next for'Continue While 'break out of loop
                                        End Try

                                        If Not tepisode1 Is Nothing Then
                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Getting episode image --------------"
                                            curseason.episodes.Add(tepisode1)
                                            If rconf.tv_episode_download_boolean Then
                                                If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                    'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                    If Not tepisode1.Filename = "" Then
                                                        wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                    End If
                                                End If
                                                If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                    'we should now have it in cache

                                                    'make sure it's not a 0k file
                                                    checkzerofilesize(Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                    'check episode thumb overwrite option in conf
                                                    If rconf.tv_episode_overwrite_tbn Then
                                                        File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                    Else
                                                        Try
                                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                            'make sure it's not a 0k file
                                                             checkzerofilesize(Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                        Catch ex As Exception
                                                            'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                            Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                        End Try

                                                    End If
                                                End If
                                            End If
                                            tepisode1.fullfilenameandpath = item
                                            Dim writnfo As Boolean = False
                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                            If rconf.tv_episode_overwrite_nfo Then writnfo = True 'tv_tvshow_nfo_overwrite_boolean
                                            If writnfo Then
                                                'get media data
                                                maincollection.pbar1.Visible = True
                                                maincollection.lblPbar.Visible = True
                                                maincollection.lblPbar.BringToFront()
                                                maincollection.lblPbar.Text = "-- Working On: " + item + "--"
                                                maincollection.Refresh()
                                                Dim curmedinfo As New MediaInfo
                                                curmedinfo.getdata(tepisode1, True)

                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror, xbmctvshow1.Studio, xbmctvshow1.Mpaa)
                                                xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                            End If

                                        End If
                                    ElseIf (haveepisode And haveseason) And multiepisode Then 'multiepisode
                                        'create mutliepisode obj
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Multipart Episode Found"
                                        Dim curxbmcmultiepisode As New xbmc.xbmcmultiepisode

                                        numtvshowstotal += numofepisodes
                                        'split episodes at the : 
                                        Dim epPeices() As String = ctv_episode.Split(CChar(":"))
                                        Dim epcoutot As Integer = epPeices.Length
                                        Dim curepcou As Integer = 0
                                        While curepcou < epcoutot
                                            Dim ctv_episodepiece As String = epPeices(curepcou)
                                            'get 2 digit version of episode data
                                            If Strings.Left(ctv_episodepiece, 1) = "0" And ctv_episodepiece.Length >= 1 Then
                                                ctv_episodepiece = Strings.Right(ctv_episodepiece, ctv_episodepiece.Length - 1)
                                            End If

                                            Dim tepisode1 As New tvdblangEpisode

                                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "get espisode data"
                                            If ctv_episodepiece = "0" Then ctv_episodepiece = "00"
                                            Try
                                                tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episodepiece), tvdblangEpisode)
                                                tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                                tepisode1.miptvdbkey = miptvdbkey
                                                tepisode1.mutlipart = True
                                            Catch ex As Exception
                                                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "error pulling episode from array theshows"
                                                curepcou += 1
                                                Continue While
                                                'Continue While 'break out of loop
                                            End Try

                                            If Not tepisode1 Is Nothing Then
                                                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Getting episode image --------------"
                                                curseason.episodes.Add(tepisode1)
                                                If rconf.tv_episode_download_boolean Then
                                                    If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                        'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                        If Not tepisode1.Filename = "" Then
                                                            wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                        End If
                                                    End If
                                                    If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                        'we should now have it in cache
                                                        checkzerofilesize(Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                        'check episode thumb overwrite option in conf
                                                        If rconf.tv_episode_overwrite_tbn Then
                                                            File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                        Else
                                                            Try
                                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                                checkzerofilesize(Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                            Catch ex As Exception
                                                                'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                                Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                            End Try
                                                        End If
                                                    End If
                                                    'asdf()
                                                End If
                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.fullfilenameandpath = item
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror, xbmctvshow1.Studio, xbmctvshow1.Mpaa)
                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then
                                                    maincollection.pbar1.Visible = True
                                                    maincollection.lblPbar.Visible = True
                                                    maincollection.lblPbar.BringToFront()
                                                    maincollection.lblPbar.Text = "Scanning: " + getfilefrompath(item) '+ "--"
                                                    maincollection.Refresh()
                                                    Dim curmedinfo As New MediaInfo
                                                    curmedinfo.getdata(tepisode1, True)
                                                End If
                                                curxbmcmultiepisode.episodes.Add(xbmced1)
                                                curepcou += 1
                                                'xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")

                                            End If

                                        End While
                                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Writing .nfo file: " + Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                                        Dim writnfo As Boolean = False
                                        If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                        If rconf.tv_episode_overwrite_nfo Then writnfo = True
                                        If writnfo Then
                                            curxbmcmultiepisode.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                        End If
                                        'Dim epname As String = epPeices(epPeices.Length - 1)


                                    End If
                                    'End If
                                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- Done episode processing of single item, movie to next or end --------------"
                                Case Else
                                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Non Movie File: " + item.ToString + " : " + tfname.ToString
                            End Select
                            filelisting.Add(item)
                        Catch ex As Exception 'catch bad filename or location exception
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString
                        End Try
                    Next
                Catch ex As Exception 'catch bad parse of directory
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + ex.ToString
                End Try
            Next

            maincollection.pbar1.Visible = False
            maincollection.lblPbar.Visible = False


            '            Exit Sub
            Try
                'season logic goes here
                Dim curseasoncounter As Integer = 0
                Dim seasonsfound As New ArrayList
                Dim seasonsused As New Hashtable
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- 545 --------------"
                While curseasoncounter < curseason.episodes.Count
                    'scan for all season numbers
                    Dim vcurepisode As tvdblangEpisode = curseason.episodes(curseasoncounter)
                    Try
                        seasonsused.Add(CInt(vcurepisode.SeasonNumber), vcurepisode.SeasonNumber)
                    Catch ex As Exception
                        'Debug.Print("exception here is expected to filter season numbers as the hashtable won't accept duplicates, crude but works")
                    End Try
                    curseasoncounter += 1
                End While
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-------------- 557 --------------"
                Dim tcount As Integer = 0
                While tcount <= 100 'handles 100 seasons
                    'If seasonsused.ContainsValue(CStr(tcount)) Or tcount = 0 Then
                    Dim tseasonholder As New seasons
                    tseasonholder.seasonnumber = CStr(tcount)
                    seasonsfound.Add(tseasonholder)
                    'End If
                    tcount += 1
                End While
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "---------LINE 567------------"
                curseasoncounter = 0
                While curseasoncounter < curseason.episodes.Count
                    'put shows in correct object - fix for bogus missed season
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + curseasoncounter.ToString
                    Dim vcurepisode As tvdblangEpisode = curseason.episodes(curseasoncounter)

                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Parsing season: [" _
                                        + vcurepisode.SeasonNumber + "] from " + Chr(34) + vcurepisode.episodefilepath + Chr(34)

                    Try
                        Dim tempseasonnumber As Integer = 0
                        tempseasonnumber = CInt(vcurepisode.SeasonNumber)
                        Dim tseason As seasons = CType(seasonsfound.Item(tempseasonnumber), movieinfoplus.seasons)
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += "... Done"
                        tseason.episodes.Add(vcurepisode)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += "fixme: " + vbNewLine + ex.ToString '"... Done"
                    End Try
                    curseasoncounter += 1
                End While

                '"filter down the list to just those that have episodes"
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "filter down the list to just those that have episodes"
                For Each tseason1 As seasons In seasonsfound
                    If tseason1.episodes.Count > 0 Then
                        curCompleteShow.seasons.Add(tseason1)
                    End If
                    'If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "================= 582 =================="
                Next
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "filter done"
                'Next
                'curCompleteShow.seasons.Add(curseason)
                showarrayofallseasons.Add(curCompleteShow)
            Catch ex As Exception
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "fixme" + vbNewLine + ex.ToString()
            End Try
            counter += 1
        End While
        'Debug.Print(tvsholistedpath.ToString)
        maincollection.mytvshowcollection = showarrayofallseasons
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "------------ 591----------------"
        File.WriteAllText(rconf.basefolder + "tvshowdebug.log", dlgTVShowCurStatus.krbStatus.Text)

        'update gui counter
        'maincollection.mytvshowcollection = 
        maincollection.klNumTvShows.Text = numtvshowstotal.ToString
        'stpw2.Stop()
        'MsgBox(stpw2.Elapsed.ToString)
        'display missing shows and episodes that didn't scan
        If Not gvNoShowsList = "" Or Not gvFailedEPList.Count = 0 Then
            Dim bfont As New Font(dlgMessageboxOK.message.Font, FontStyle.Bold)
            Dim rfont As New Font(dlgMessageboxOK.message.Font, FontStyle.Regular)
            If Not gvNoShowsList = "" Then
                dlgMessageboxOK.message.Font = bfont
                dlgMessageboxOK.message.Text += "No show data exists for the following shows:" + gvNoShowsList
                dlgMessageboxOK.message.Font = rfont
                dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
            End If
            For Each failedshowobj As showfileobj In gvFailedEPList

            Next
            If Not gvFailedEPList.Count = 0 Then
                dlgMessageboxOK.failedfiles = gvFailedEPList
                dlgMessageboxOK.message.Font = bfont
                dlgMessageboxOK.message.Text += "The following episodes could not be loaded:"
                dlgMessageboxOK.message.Font = rfont
                For Each failedshowobj As showfileobj In gvFailedEPList
                    dlgMessageboxOK.message.Text += vbNewLine & failedshowobj.showname & ": " & failedshowobj.filename
                Next
                dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
                'dlgMessageboxOK.message.Text += "The following episodes could not be loaded:" + gvFailedEPList
                'dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
            End If
            'dlgMessageboxOK.message.SelectionStart = dlgMessageboxOK.message.Find("No show data exists for the following shows:")
            'dlgMessageboxOK.message.SelectionFont = bfont
            ' dlgMessageboxOK.message.SelectionStart = dlgMessageboxOK.message.Find("The following episodes could not be loaded:")
            'dlgMessageboxOK.message.SelectionFont = bfont
            dlgMessageboxOK.ShowInTaskbar = True
            dlgMessageboxOK.BringToFront()
            dlgMessageboxOK.ShowDialog()
        End If
    End Sub

    Public Sub kbLoadTvShowsCmdLine(Optional ByVal overwritenfo As Boolean = False, Optional ByVal debugon As Boolean = False, Optional ByVal dlo As Boolean = False)
        gvNoShowsList = "" 'clear out the no show data list var
        Console.Out.WriteLine("starting to load the episodes")
        'Dim stpw As New Stopwatch
        'stpw.Start()
        rconf = rconf.getconfig("config", True)

        'If rconf.debugtvshows Or debugon Then
        '    dbgTVShows = True
        'End If
        Dim boguscounter As Integer = 0
        'get updates file from server

        Dim tdate As String = ""
        ' getdatesfromtvdb(tdate)
        Debug.Print("getdatefromtvdb done")

        'myseries.Serieses.
        Dim maindttv As New DataTable
        maindttv.Columns.Add("Path", GetType(System.String))
        maindttv.Columns.Add("Name")
        maindttv.Columns.Add("TvdbidNum")
        maindttv.Columns.Add("Index")
        Dim showcount As Integer = 0
        Dim tvshowarray As New ArrayList
        'bwchanges
        'tvshowarray = passedtvshowarray

        For Each item In rconf.pclbTVPaths 'maincollection.lbTVShows.CheckedItems
            'ennum sub dir x levels deep
            Dim curdircontents() As String
            curdircontents = Directory.GetDirectories(item.ToString)
            For Each currentdir As String In curdircontents
                Try
                    If Not validshowdirc(currentdir) Then 'Strings.Right(currentdir.ToUpper, 8) = "RECYCLER" Or Strings.Right(currentdir.ToLower, 8) = "(noscan)" Or currentdir.ToUpper = "LOST+FOUND" Or currentdir.ToUpper = "System Volume Information".ToUpper Then
                        'dont add it
                    Else
                        If Not File.Exists(currentdir & "\noscan") Then tvshowarray.Add(currentdir)
                        Console.Out.WriteLine("Adding: " & currentdir.ToString)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
            Next
        Next
        Console.Out.WriteLine("curdircontents finished")
        While showcount < tvshowarray.Count
            'see if we have any info about the show
            'grab the latest zip file for show
            'find the key first
            'maincollection.lbTVShows.SelectedIndex = showcount
            Dim showfullpathname As String = tvshowarray(showcount).ToString
            Dim fnPeices1() As String = showfullpathname.ToString.Split(CChar("\"))
            Dim tfname As String = Strings.Replace(fnPeices1(fnPeices1.Length - 1), "_", " ")
            tfname = Strings.Replace(tfname, ".", " ")
            Dim selectedshow As String = ""
            Dim tvshownfooverwrite As Boolean = False
            If File.Exists(showfullpathname + "\tvshow.nfo") Then
                'read it to get the series id and set tvshowoverwrite to false
                Dim xbmctvshow1 As New xbmc.xbmcTvshow
                Try
                    xbmctvshow1.readXML(showfullpathname + "\tvshow.nfo", xbmctvshow1)
                    selectedshow = xbmctvshow1.Tvdbid
                    selectedshow = Strings.Replace(selectedshow, " ", "")
                    If Not selectedshow = "" Then tvshownfooverwrite = True
                Catch ex As Exception
                    selectedshow = ""
                End Try

                'maindttv.LoadDataRow(New Object() {showfullpathname, xbmctvshow1.Title, showcount}, True)
                'showcount += 1
                'Continue While 'break out of while loop, it's not needed
            End If

            If selectedshow = "" Then
                getTVSeriesList(tfname)
                'Dim tstring As String = httpget(curmirror + "/api/GetSeries.php?seriesname=" + kcbShowPicker.Items(showcount).ToString)
                'Debug.Print(tstring)
                Dim temptvshowdata As New TVSeriesData
                temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + tfname + ".xml", temptvshowdata)
                Dim tarray As New ArrayList
                Try

                    For Each item In temptvshowdata.SeriesArray
                        tarray.Add(item)
                    Next

                Catch ex As Exception
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "No TV Show data exsists for: " + tfname
                    gvNoShowsList += vbNewLine + tfname
                    'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                    showcount += 1
                    Continue While
                End Try

                If Not tarray.Count = 1 Then
                    showcount += 1
                    Continue While
                End If
                Console.Out.WriteLine("counter during show loc loop: " & showcount.ToString)
                '    Dim dtIDA As New DataTable
                '    dtIDA.Columns.Add("Path", GetType(System.String))
                '    dtIDA.Columns.Add("Name")
                '    dtIDA.Columns.Add("Index")
                '    dtIDA.Columns.Add("objShow")
                '    Dim thashtable As New Hashtable
                '    Dim cutcmIndex As Integer = 0
                '    Try 'jivefix 2nd round
                '        For Each tcmitem As thetvdb.TvSeries In tarray 'update path info for real code
                '            dtIDA.LoadDataRow(New Object() {showfullpathname, tcmitem.SeriesName, tcmitem.seriesid, tcmitem}, True)
                '            thashtable.Add(tcmitem.seriesid, tcmitem)
                '            cutcmIndex += 1
                '        Next
                '    Catch exTarray As Exception
                '        Debug.Print("exTarray failed" + vbNewLine + exTarray.ToString)
                '    End Try
                '    dialogTvShowSelect.dhashtable = thashtable
                '    dtIDA.DefaultView.Sort = "Name"
                '    dialogTvShowSelect.klbPickTheTvShow.DataSource = dtIDA.DefaultView
                '    dialogTvShowSelect.klbPickTheTvShow.ValueMember = "Index"
                '    dialogTvShowSelect.klbPickTheTvShow.DisplayMember = "Name"
                '    dialogTvShowSelect.displayshowdata()
                '    dialogTvShowSelect.klbltvCurShow.Text = "TV Show Folder Name: " + tfname
                '    dialogTvShowSelect.klbltvCurShowPath.Text = "TV Show Location on drive: " + showfullpathname
                '    dialogTvShowSelect.Refresh()
                '    If dbgTVShows Then dlgTVShowCurStatus.Hide()
                '    dialogTvShowSelect.ShowDialog()
                '    If dialogTvShowSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                '        MsgBox("Cancel Selected, the show has not been added.")
                '        showcount += 1
                '        Continue While
                '    Else
                '        selectedshow = CStr(dialogTvShowSelect.klbPickTheTvShow.SelectedValue)
                '        selectedshow = Strings.Replace(selectedshow, " ", "")
                '    End If

                '    Debug.Print(selectedshow)
                '    dialogTvShowSelect.Dispose()
                '    If dbgTVShows Then dlgTVShowCurStatus.Show()
                'Else
                '    Dim tvbdseries1 As New thetvdb.TvSeries
                '    tvbdseries1 = CType(tarray.Item(0), TvSeries)
                '    selectedshow = tvbdseries1.seriesid
                '    selectedshow = Strings.Replace(selectedshow, " ", "")
                'End If
            End If
            'now that we have the showid, use the api to get the data
            'get the zip file (5 day updates, add gui option to set amount of days to check for updates)
            Dim numtoaddfromconf As Integer = 5
            numtoaddfromconf = CInt(rconf.pcombolTVCheckForNewTVShowData)
            'If File.GetLastWriteTime(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip").AddDays(numtoaddfromconf) < Date.Now Then
            '    If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
            '    If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
            '    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
            'End If



            '--------------------------------------Section Start----------------------------------------
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            'read in banners.xml and then process it
            Dim tbanners As New Banners
            Try
                tbanners.readBannerXML(rconf.tvdbcachefolder + selectedshow + "\banners.xml", tbanners)
            Catch ex As Exception
                'MsgBox("Error in banner read: " + vbNewLine + rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print(rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print("unable to load xml file from cache folder")
                showcount += 1
                Console.Out.WriteLine("no xml file in cache folder for " & "-" & selectedshow & "-")

                Continue While 'break out of while loop, no data in banners 
            End Try

            'download banners/fanarts/posters/etc
            Dim fanartcounter As Integer = 0
            Dim postercounter As Integer = 0
            Dim seasoncounter As Integer = 0
            Dim seriescounter As Integer = 0
            'check for folders
            'rconf.tv_usewgetforimages = False

            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\blank") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\blank")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\text") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\text")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\poster") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\poster")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\posters") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\posters")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\series") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\series")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\season") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\season")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes")
            For Each tmbanner As BannersBanner In tbanners.Banners
                If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'check language and match it, if no match, skip it
                    'See If the file already exsists

                    Dim switchpath As String = Strings.Replace(tmbanner.BannerPath, "/", "\")
                    Debug.Print(switchpath)

                    Select Case tmbanner.BannerType.ToLower
                        Case "fanart"
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_fanart_download_boolean And fanartcounter < rconf.tv_tvshow_fanart_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvfanart(tmbanner, selectedshow, switchpath)
                                    If fanartcounter = 1 Or Not File.Exists(showfullpathname + "\fanart.jpg") Then
                                        If Not File.Exists(showfullpathname + "\fanart.jpg") Then
                                            File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\fanart.jpg") '-- copy fanart as fanart.jpg
                                        End If
                                    End If
                                End If
                            End If

                            fanartcounter += 1
                        Case "poster"
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_posters_download_boolean And postercounter < rconf.tv_tvshow_posters_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvposters(tmbanner, selectedshow, switchpath)
                                    If Not File.Exists(showfullpathname + "\season-all.tbn") Then
                                        File.Copy(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, showfullpathname + "\season-all.tbn")
                                    End If
                                    If Not File.Exists(showfullpathname + "\folder.jpg") Then
                                        If rconf.prbshows_show_usewide_false4poster = False Then
                                            File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\folder.jpg") '-- copy fanart as fanart.jpg
                                        End If
                                    End If
                                End If
                            End If
                            postercounter += 1
                        Case "season"
                            Dim boolGetSeason As Boolean = False
                            Dim boolGetSeasonwide As Boolean = False
                            If rconf.tv_season_banners_download_type_string.ToLower Is Nothing Then
                                rconf.tv_season_banners_download_type_string = "all"
                            End If
                            If rconf.tv_season_banners_download_type_string.ToLower = "" Then
                                rconf.tv_season_banners_download_type_string = "all"
                            End If
                            Try
                                If rconf.tv_season_banners_download_type_string.ToLower = "all" Then
                                    boolGetSeason = True
                                    boolGetSeasonwide = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "season" Then
                                    boolGetSeason = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "seasonwide" Then
                                    boolGetSeasonwide = True
                                End If
                                'workaround for busted configs where the value isn't entered correctly
                                If boolGetSeason = False And boolGetSeasonwide = False Then boolGetSeason = True
                            Catch ex As Exception
                                boolGetSeason = True
                                Debug.Print(ex.ToString)
                            End Try


                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'And rconf.tv_getseasonbanners And seasoncounter < rconf.tv_maxtvseasonbanners Then
                                'jive fix'If tmbanner.BannerType2.ToLower = "season" And boolGetSeason And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'jive fix'If tmbanner.BannerType2.ToLower = "seasonwide" And boolGetSeasonwide And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then gettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'season auto creation

                                'check series length
                                Dim vSeasonLen As Integer = tmbanner.Season.Length
                                Dim vSeasonPreText As String = ""

                                If vSeasonLen = 1 Then vSeasonPreText = "season0"
                                If vSeasonLen >= 2 Then vSeasonPreText = "season"

                                Dim vSeasonNumConcat As String = vSeasonPreText + tmbanner.Season.ToString
                                If tmbanner.BannerType2.ToLower = rconf.tv_season_banners_toapply_string Then

                                    Dim tvSeasonPreText As String = ""
                                    If vSeasonLen = 1 Then tvSeasonPreText = "Season"
                                    If vSeasonLen >= 2 Then tvSeasonPreText = "Season"
                                    'this way, each numbered season gets a season banner
                                    'add season image to folders
                                    Dim curfolder As String = showfullpathname + "\" + tvSeasonPreText + " " + tmbanner.Season.ToString + "\"
                                    Dim fnamet As String = "folder.jpg"
                                    Dim curfolder2 As String = showfullpathname + "\" + tvSeasonPreText + "_" + tmbanner.Season.ToString + "\"
                                    Dim filetocopy As String = ""
                                    If File.Exists(showfullpathname + "\" + vSeasonNumConcat + ".tbn") Then
                                        filetocopy = showfullpathname + "\" + vSeasonNumConcat + ".tbn"
                                    Else
                                        filetocopy = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
                                    End If

                                    If Directory.Exists(curfolder) Then
                                        If Not File.Exists(curfolder & fnamet) Then
                                            File.Copy(filetocopy, curfolder & fnamet)
                                        End If
                                    End If

                                    If Directory.Exists(curfolder2) Then
                                        If Not File.Exists(curfolder2 & fnamet) Then
                                            File.Copy(filetocopy, curfolder2 & fnamet)
                                        End If
                                    End If

                                    If Not File.Exists(showfullpathname + "\" + vSeasonNumConcat + ".tbn") And File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then
                                        File.Copy(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, showfullpathname + "\" + vSeasonNumConcat + ".tbn")
                                    End If
                                    seasoncounter += 1
                                End If
                            End If

                        Case "series" 'note: series is the wide icons, with different text (or graphical version of text, or no text) for the tvshow
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_wideicon_download_boolean And seriescounter < rconf.tv_tvshow_wideicon_download_maxnumber_integer Then
                                If File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then 'gettvseriesbanners(tmbanner, selectedshow, switchpath)
                                    If seriescounter = 1 Then
                                        If Not File.Exists(showfullpathname + "\folder.jpg") Then
                                            If rconf.prbshows_show_usewide_false4poster = True Then
                                                File.Copy(rconf.tvdbcachefolder + "\" + selectedshow + "\" + switchpath, showfullpathname + "\folder.jpg") '-- copy fanart as fanart.jpg
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            seriescounter += 1
                    End Select
                End If
                'End If
            Next
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            '--------------------------------------Section END------------------------------------------
            Dim newtvdbData As New tvdblangData
            Dim newactors As New Actors
            newactors.readXML(rconf.tvdbcachefolder + selectedshow + "\Actors.xml", newactors)
            'tvdblangseries2xbmcTvshow()
            Dim xbmctvshow As New xbmc.xbmcTvshow
            Try
                newtvdbData.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbData)
                Debug.Print("read completed")
                newtvdbData.Series.tvdblangseries2xbmcTvshow(newtvdbData.Series, xbmctvshow, newactors)
                xbmctvshow.Genre = Strings.Replace(xbmctvshow.Genre, "|", "/")
                Try
                    If xbmctvshow.Genre.Length > 0 And Strings.Left(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Right(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                    If xbmctvshow.Genre.Length > 0 And Strings.Right(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Left(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
                xbmctvshow.Episodeguideurl = "http://www.thetvdb.com/api/1D62F2F90030C444/series/" + selectedshow + "/all/" + curlang + ".zip"
                If rconf.pcbshows_UseStudioasRating Then
                    xbmctvshow.Rating = xbmctvshow.Studio
                End If
                xbmctvshow.writeXML(showfullpathname) '"c:\")
                'add show to datatable
                maindttv.LoadDataRow(New Object() {showfullpathname + ":" + xbmctvshow.Tvdbid + ":", xbmctvshow.Title, xbmctvshow.Tvdbid, showcount}, True)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try

            'wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + tseriesname.Id + "/all/" + curlang + ".zip", "everything", True)
            showcount += 1
        End While

        ' --------------------------------
        'process episode level items
        ' --------------------------------
        'For Each item In rconf.pclbTVPaths 'maincollection.lbTVShows.CheckedItems
        '    'ennum sub dir x levels deep
        '    Dim curdircontents() As String
        '    curdircontents = Directory.GetDirectories(item.ToString)
        '    For Each currentdir As String In curdircontents
        '        Try
        '            If Strings.Right(currentdir.ToUpper, 8) = "RECYCLER" Or Strings.Right(currentdir.ToLower, 8) = "(noscan)" Or currentdir.ToUpper = "LOST+FOUND" Or currentdir.ToUpper = "System Volume Information".ToUpper Then
        '                'dont add it
        '            Else
        '                If Not File.Exists(currentdir & "\noscan") Then tvshowarray.Add(currentdir)
        '            End If
        '        Catch ex As Exception
        '            Debug.Print(ex.ToString)
        '        End Try
        '    Next
        'Next
        Dim showcount2 As Integer = 0
        While showcount2 < tvshowarray.Count
            'see if we have any info about the show
            'grab the latest zip file for show
            'find the key first
            'maincollection.lbTVShows.SelectedIndex = showcount
            Dim showfullpathname As String = tvshowarray(showcount2).ToString
            Dim curtvshowpath As String = showfullpathname
            Dim xbmctvshow1e As New xbmc.xbmcTvshow
            Try
                xbmctvshow1e.readXML(curtvshowpath + "\tvshow.nfo", xbmctvshow1e)
            Catch ex As Exception
                'if no tvshow.nfo or it fails, goto next one
                Console.Out.WriteLine("No show data for: " & curtvshowpath)
                showcount2 += 1
                Continue While
            End Try
            Dim selectedshow As String = xbmctvshow1e.Tvdbid

            Dim newtvdbdata As New tvdblangData
            Try

                newtvdbdata.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbdata)
                For Each tepisode In newtvdbdata.Episodes
                    Try
                        theshows.Add(tepisode.Seriesid + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber, tepisode)
                        'Debug.Print("Known episodes from tvdb data in " + tepisode.Seriesid + "  are: " + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "duplicate or invalid episode" + ex.ToString
                    End Try

                Next

            Catch ex As Exception
                'MsgBox("No TV Shows found for: " + curtvshowpath)
                'counter += 1
                'Continue While
            End Try


            Dim tarray2 As New ArrayList
            Dim tdtvlist_count As Integer = 0
            EnumTVDirectory(curtvshowpath, tarray2, tdtvlist_count)
            'get all files for all directorys in that path and put into arraylist
            Dim filelisting As New ArrayList
            For Each tdirectory As String In tarray2
                Try
                    For Each item In Directory.GetFiles(tdirectory)
                        'insert the search and processing here
                        'regex on filename to see if it's a movie (or str left)
                        'if it is, try to grab season and episode info from it
                        ''regex for that
                        Try

                            Dim fnPeices2() As String = item.ToString.Split(CChar("\"))
                            Dim tfname2 As String = fnPeices2(fnPeices2.Length - 1)
                            Select Case Strings.Right(tfname2, 4).ToLower
                                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"

                                    'have a movie file, parse it for season and episode
                                    Dim tfnameoffile As String = fnPeices2(fnPeices2.Length - 1).ToLower
                                    tfnameoffile = Strings.Replace(tfnameoffile, ".x264", "")
                                    tfnameoffile = Strings.Replace(tfnameoffile, ".2hd", "")
                                    If debugon Then Console.Out.WriteLine("Media file found, parsing: " & tfnameoffile)
                                    Debug.Print(tfnameoffile)
                                    'run regex on file name (without extension)
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
                                        End Try
                                        If numofepisodes > 1 Then
                                            multiepisode = True
                                            'MsgBox(numofepisodes.ToString + " " + ctv_episode)
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
                                    End Try
                                    'if it has season and episode, then write nfo and tbn for it

                                    If Not (haveseason And haveepisode) Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("season").Value
                                            ctv_episode = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("episode").Value
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                            multiepisode = False
                                        Catch ex As ArgumentException
                                        End Try
                                        'if it has season and episode, then write nfo and tbn for it

                                    End If
                                    If Not (haveseason And haveepisode) And Not rconf.ptvregx1 = "" Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(1).Value
                                            If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
                                            Debug.Print("Regex3 season resulted in :" + ctv_season)
                                            ctv_episode = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(2).Value
                                            Debug.Print("Regex3 episode resulted in :" + ctv_episode)
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                        Catch ex As ArgumentException
                                        End Try
                                    End If

                                    ''if it has season and episode, then write nfo and tbn for it
                                    If Not (haveepisode And haveepisode) Then
                                        Dim newfailedshow As New showfileobj
                                        newfailedshow.filename = tfnameoffile
                                        newfailedshow.path = getparentdirectory(item)
                                        newfailedshow.showid = ""
                                        newfailedshow.showrootfolder = curtvshowpath
                                        newfailedshow.showname = xbmctvshow1e.Title
                                        newfailedshow.showid = xbmctvshow1e.Tvdbid
                                        newfailedshow.writecommit = False
                                        gvFailedEPList.Add(newfailedshow) ' += vbNewLine + tfnameoffile
                                    End If
                                    If (haveepisode And haveseason) And Not multiepisode Then
                                        If ctv_episode = "0" Then ctv_episode = "00"
                                        If debugon Then Console.Out.WriteLine("Found Single Episode: Season " & ctv_season & " - Epsiode" & ctv_episode)
                                        'numtvshowstotal += 1 'numofepisodes
                                        Dim tepisode1 As New tvdblangEpisode
                                        tepisode1.miptvdbkey = miptvdbkey
                                        tepisode1.mutlipart = False
                                        'get espisode data
                                        Try
                                            tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episode), tvdblangEpisode)
                                            tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                        Catch ex As Exception
                                            'curepcou += 1
                                            Continue For 'next for'Continue While 'break out of loop
                                        End Try

                                        If Not tepisode1 Is Nothing Then
                                            'curseason.episodes.Add(tepisode1)
                                            If rconf.tv_episode_download_boolean Then
                                                If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                    'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                    If Not tepisode1.Filename = "" Then
                                                        wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                    End If
                                                End If
                                                If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                    'we should now have it in cache
                                                    'check episode thumb overwrite option in conf
                                                    If rconf.tv_episode_overwrite_tbn Then
                                                        File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                    Else
                                                        Try
                                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                        Catch ex As Exception
                                                            'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                            Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                        End Try

                                                    End If
                                                End If
                                            End If
                                            tepisode1.fullfilenameandpath = item
                                            Dim writnfo As Boolean = False
                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                            If overwritenfo Then writnfo = True 'tv_tvshow_nfo_overwrite_boolean
                                            ' Console.Out.WriteLine("Overwrite: " & writnfo.ToString)
                                            If writnfo Then
                                                'get media data
                                                maincollection.pbar1.Visible = True
                                                maincollection.lblPbar.Visible = True
                                                maincollection.lblPbar.BringToFront()
                                                maincollection.lblPbar.Text = "-- Working On: " + item + "--"
                                                Console.Out.WriteLine("-- Media Info Update for: " + item + "--")
                                                maincollection.Refresh()
                                                Dim curmedinfo As New MediaInfo
                                                curmedinfo.getdata(tepisode1, True)
                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1e.Actors, curmirror, xbmctvshow1e.Studio, xbmctvshow1e.Mpaa)
                                                xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                            End If

                                        End If
                                    ElseIf (haveepisode And haveseason) And multiepisode Then 'multiepisode
                                        'create mutliepisode obj
                                        Dim curxbmcmultiepisode As New xbmc.xbmcmultiepisode

                                        '  numtvshowstotal += numofepisodes
                                        'split episodes at the : 
                                        Dim epPeices() As String = ctv_episode.Split(CChar(":"))
                                        Dim epcoutot As Integer = epPeices.Length
                                        Dim curepcou As Integer = 0
                                        While curepcou < epcoutot

                                            Dim ctv_episodepiece As String = epPeices(curepcou)

                                            'get 2 digit version of episode data
                                            If Strings.Left(ctv_episodepiece, 1) = "0" And ctv_episodepiece.Length >= 1 Then
                                                ctv_episodepiece = Strings.Right(ctv_episodepiece, ctv_episodepiece.Length - 1)
                                            End If

                                            Dim tepisode1 As New tvdblangEpisode

                                            If ctv_episodepiece = "0" Then ctv_episodepiece = "00"
                                            If debugon Then Console.Out.WriteLine("Found Multipart Episode: Season " & ctv_season & " - Epsiode" & ctv_episodepiece)
                                            Try
                                                tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episodepiece), tvdblangEpisode)
                                                tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                                tepisode1.miptvdbkey = miptvdbkey
                                                tepisode1.mutlipart = True
                                            Catch ex As Exception
                                                curepcou += 1
                                                Continue While
                                                'Continue While 'break out of loop
                                            End Try

                                            If Not tepisode1 Is Nothing Then
                                                'curseason.episodes.Add(tepisode1)
                                                If rconf.tv_episode_download_boolean Then
                                                    If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                        'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                        If Not tepisode1.Filename = "" Then
                                                            wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                        End If
                                                    End If
                                                    If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                        'we should now have it in cache
                                                        'check episode thumb overwrite option in conf
                                                        If rconf.tv_episode_overwrite_tbn Then
                                                            File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                        Else
                                                            Try
                                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                            Catch ex As Exception
                                                                'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                                Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                            End Try
                                                        End If
                                                    End If
                                                    'asdf()
                                                End If
                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.fullfilenameandpath = item
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1e.Actors, curmirror, xbmctvshow1e.Studio, xbmctvshow1e.Mpaa)
                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then
                                                    'maincollection.pbar1.Visible = True
                                                    'maincollection.lblPbar.Visible = True
                                                    'maincollection.lblPbar.BringToFront()
                                                    'maincollection.lblPbar.Text = "Scanning: " + getfilefrompath(item) '+ "--"
                                                    'maincollection.Refresh()
                                                    Dim curmedinfo As New MediaInfo
                                                    Console.Out.WriteLine("Scanning Media Info: " + getfilefrompath(item))
                                                    curmedinfo.getdata(tepisode1, True)
                                                End If
                                                curxbmcmultiepisode.episodes.Add(xbmced1)
                                                curepcou += 1
                                                'xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")

                                            End If

                                        End While
                                        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                                        Dim writnfo As Boolean = False
                                        If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                        If overwritenfo Then writnfo = True
                                        If writnfo Then
                                            curxbmcmultiepisode.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                        End If
                                        'Dim epname As String = epPeices(epPeices.Length - 1)


                                    End If
                                    'End If
                                Case Else
                            End Select
                            filelisting.Add(item)
                        Catch ex As Exception 'catch bad filename or location exception
                            Console.Out.WriteLine(ex.ToString)
                        End Try
                    Next
                Catch ex As Exception 'catch bad parse of directory
                    Console.Out.WriteLine(ex.ToString)
                End Try
            Next
            Console.Out.WriteLine("Show Count: " & showcount2.ToString)
            showcount2 += 1
        End While

        'end episode level items



        'Exit Sub 'temp break out for cmd line


        maindttv.DefaultView.Sort = "Name"
        'System.Threading.Thread.Sleep(10000)
        maincollection.tbloftvshows = maindttv
        maincollection.lbTvShowPicker.ValueMember = "Path"
        maincollection.lbTvShowPicker.DisplayMember = "Name"
        maincollection.lbTvShowPicker.AccessibleName = "TvdbidNum"
        maincollection.lbTvShowPicker.DataSource = maindttv.DefaultView
        'main series is done
        '    Exit Sub

    End Sub

    Public Sub updatetvshowsCmdLine()
        Dim numtvshowstotal As Integer = 0
        Dim counter As Integer = 0

        'lbtvshowpicker is not valid here

        While counter < maincollection.lbTvShowPicker.Items.Count
            maincollection.lbTvShowPicker.SelectedIndex = counter
            Dim curtvshowpath As String = maincollection.lbTvShowPicker.SelectedValue.ToString
            'strip out the id from the path'
            Dim theid As String = Regex.Match(curtvshowpath, "(:\d*?:)").Groups(1).Value
            curtvshowpath = Strings.Replace(curtvshowpath, theid, "")

            Dim xbmctvshow1 As New xbmc.xbmcTvshow
            Try
                xbmctvshow1.readXML(curtvshowpath + "\tvshow.nfo", xbmctvshow1)
            Catch ex As Exception
                Debug.Print(ex.ToString)
                counter += 1
                Continue While
            End Try
            'create completetvshow object
            Dim curCompleteShow As New completeshows
            curCompleteShow.tvshowname = xbmctvshow1.Title
            curCompleteShow.tvshowid = xbmctvshow1.Tvdbid
            curCompleteShow.showpath = curtvshowpath + "\tvshow.nfo"
            Dim curseason As New seasons
            curseason.seasonnumber = "1" 'basic for now, later this will have to change
            Dim selectedshow As String = xbmctvshow1.Tvdbid
            Dim newtvdbdata As New tvdblangData
            Try

                newtvdbdata.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbdata)
                For Each tepisode In newtvdbdata.Episodes
                    Try
                        theshows.Add(tepisode.Seriesid + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber, tepisode)
                        'Debug.Print("Known episodes from tvdb data in " + tepisode.Seriesid + "  are: " + "s" + tepisode.SeasonNumber + "e" + tepisode.EpisodeNumber)
                    Catch ex As Exception
                    End Try

                Next

            Catch ex As Exception
                '      MsgBox("No TV Shows found for: " + curtvshowpath)
                counter += 1
                Continue While
            End Try
            'enumdir and see what we have
            Dim tarray As New ArrayList
            Dim tdtvlist_count As Integer = 0
            EnumTVDirectory(curtvshowpath, tarray, tdtvlist_count)
            'get all files for all directorys in that path and put into arraylist
            Dim filelisting As New ArrayList
            For Each tdirectory As String In tarray
                Try
                    For Each item In Directory.GetFiles(tdirectory)
                        'insert the search and processing here
                        'regex on filename to see if it's a movie (or str left)
                        'if it is, try to grab season and episode info from it
                        ''regex for that
                        Try

                            Dim fnPeices1() As String = item.ToString.Split(CChar("\"))
                            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)
                            Select Case Strings.Right(tfname, 4).ToLower
                                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"
                                    'have a movie file, parse it for season and episode
                                    Dim tfnameoffile As String = fnPeices1(fnPeices1.Length - 1)
                                    Debug.Print(tfnameoffile)
                                    'run regex on file name (without extension)
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
                                        End Try
                                        If numofepisodes > 1 Then
                                            multiepisode = True
                                            'MsgBox(numofepisodes.ToString + " " + ctv_episode)
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
                                    End Try
                                    'if it has season and episode, then write nfo and tbn for it

                                    If Not (haveseason And haveepisode) Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("season").Value
                                            ctv_episode = Regex.Match(tfnameoffile, "(?<season>[0-9]+)(?<episode>[0-9][0-9])[^\\/]*", RegexOptions.IgnoreCase).Groups("episode").Value
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                            multiepisode = False
                                        Catch ex As ArgumentException
                                        End Try
                                        'if it has season and episode, then write nfo and tbn for it

                                    End If
                                    If Not (haveseason And haveepisode) And Not rconf.ptvregx1 = "" Then
                                        Try
                                            ctv_season = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(1).Value
                                            If Strings.Left(ctv_season, 1) = "0" And ctv_season.Length >= 1 Then ctv_season = Strings.Right(ctv_season, ctv_season.Length - 1)
                                            Debug.Print("Regex3 season resulted in :" + ctv_season)
                                            ctv_episode = Regex.Match(tfnameoffile, rconf.ptvregx1, RegexOptions.IgnoreCase).Groups(2).Value
                                            Debug.Print("Regex3 episode resulted in :" + ctv_episode)
                                            If Not ctv_season = "" Then haveseason = True
                                            If Not ctv_episode = "" Then haveepisode = True
                                            If Strings.Left(ctv_episode, 1) = "0" And ctv_episode.Length >= 1 Then ctv_episode = Strings.Right(ctv_episode, ctv_episode.Length - 1)
                                            If Not (haveepisode And haveseason) Then
                                                haveepisode = False
                                                haveseason = False
                                            End If
                                        Catch ex As ArgumentException
                                        End Try
                                    End If

                                    ''if it has season and episode, then write nfo and tbn for it
                                    If Not (haveepisode And haveepisode) Then
                                        Dim newfailedshow As New showfileobj
                                        newfailedshow.filename = tfnameoffile
                                        newfailedshow.path = getparentdirectory(item)
                                        newfailedshow.showid = ""
                                        newfailedshow.showrootfolder = curtvshowpath
                                        newfailedshow.showname = xbmctvshow1.Title
                                        newfailedshow.showid = xbmctvshow1.Tvdbid
                                        newfailedshow.writecommit = False
                                        gvFailedEPList.Add(newfailedshow) ' += vbNewLine + tfnameoffile
                                    End If
                                    If (haveepisode And haveseason) And Not multiepisode Then
                                        If ctv_episode = "0" Then ctv_episode = "00"
                                        numtvshowstotal += 1 'numofepisodes
                                        Dim tepisode1 As New tvdblangEpisode
                                        tepisode1.miptvdbkey = miptvdbkey
                                        tepisode1.mutlipart = False
                                        'get espisode data
                                        Try
                                            tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episode), tvdblangEpisode)
                                            tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                        Catch ex As Exception
                                            'curepcou += 1
                                            Continue For 'next for'Continue While 'break out of loop
                                        End Try

                                        If Not tepisode1 Is Nothing Then
                                            curseason.episodes.Add(tepisode1)
                                            If rconf.tv_episode_download_boolean Then
                                                If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                    'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                    If Not tepisode1.Filename = "" Then
                                                        wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                    End If
                                                End If
                                                If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                    'we should now have it in cache
                                                    'check episode thumb overwrite option in conf
                                                    If rconf.tv_episode_overwrite_tbn Then
                                                        File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                    Else
                                                        Try
                                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                        Catch ex As Exception
                                                            'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                            Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                        End Try

                                                    End If
                                                End If
                                            End If
                                            tepisode1.fullfilenameandpath = item
                                            Dim writnfo As Boolean = False
                                            If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                            If rconf.tv_episode_overwrite_nfo Then writnfo = True 'tv_tvshow_nfo_overwrite_boolean
                                            If writnfo Then
                                                'get media data
                                                maincollection.pbar1.Visible = True
                                                maincollection.lblPbar.Visible = True
                                                maincollection.lblPbar.BringToFront()
                                                maincollection.lblPbar.Text = "-- Working On: " + item + "--"
                                                maincollection.Refresh()
                                                Dim curmedinfo As New MediaInfo
                                                curmedinfo.getdata(tepisode1, True)
                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror, xbmctvshow1.Studio, xbmctvshow1.Mpaa)
                                                xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                            End If

                                        End If
                                    ElseIf (haveepisode And haveseason) And multiepisode Then 'multiepisode
                                        'create mutliepisode obj
                                        Dim curxbmcmultiepisode As New xbmc.xbmcmultiepisode

                                        numtvshowstotal += numofepisodes
                                        'split episodes at the : 
                                        Dim epPeices() As String = ctv_episode.Split(CChar(":"))
                                        Dim epcoutot As Integer = epPeices.Length
                                        Dim curepcou As Integer = 0
                                        While curepcou < epcoutot
                                            Dim ctv_episodepiece As String = epPeices(curepcou)
                                            'get 2 digit version of episode data
                                            If Strings.Left(ctv_episodepiece, 1) = "0" And ctv_episodepiece.Length >= 1 Then
                                                ctv_episodepiece = Strings.Right(ctv_episodepiece, ctv_episodepiece.Length - 1)
                                            End If

                                            Dim tepisode1 As New tvdblangEpisode

                                            If ctv_episodepiece = "0" Then ctv_episodepiece = "00"
                                            Try
                                                tepisode1 = CType(theshows(selectedshow + "s" + ctv_season + "e" + ctv_episodepiece), tvdblangEpisode)
                                                tepisode1.episodefilepath = Strings.Left(item.ToString, item.Length - 4) + ".nfo"
                                                tepisode1.miptvdbkey = miptvdbkey
                                                tepisode1.mutlipart = True
                                            Catch ex As Exception
                                                curepcou += 1
                                                Continue While
                                                'Continue While 'break out of loop
                                            End Try

                                            If Not tepisode1 Is Nothing Then
                                                curseason.episodes.Add(tepisode1)
                                                If rconf.tv_episode_download_boolean Then
                                                    If Not File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) And rconf.tv_episode_download_boolean Then
                                                        'wgetTVimages(curmirror + + "/banners/" + tepisode1.Filename
                                                        If Not tepisode1.Filename = "" Then
                                                            wgetTVEpisodeImage(curmirror + "/banners/" + tepisode1.Filename, rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), True)
                                                        End If
                                                    End If
                                                    If File.Exists(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\")) Then
                                                        'we should now have it in cache
                                                        'check episode thumb overwrite option in conf
                                                        If rconf.tv_episode_overwrite_tbn Then
                                                            File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", True)
                                                        Else
                                                            Try
                                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".tbn") Then File.Copy(rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\"), Strings.Left(item.ToString, item.Length - 4) + ".tbn", False)
                                                            Catch ex As Exception
                                                                'Debug.Print("exception handled, if overwrite episode tbn is not set, this is normal.")
                                                                Debug.Print("failed to copy episode image from: " + rconf.tvdbcachefolder + tepisode1.Seriesid + "\" + Strings.Replace(tepisode1.Filename, "/", "\") + vbNewLine + "to: " + Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                                                            End Try
                                                        End If
                                                    End If
                                                    'asdf()
                                                End If
                                                Dim xbmced1 As New xbmc.xbmcEpisodedetails
                                                tepisode1.fullfilenameandpath = item
                                                tepisode1.tvdblangepisode2xbmcTvepisode(tepisode1, xbmced1, xbmctvshow1.Actors, curmirror, xbmctvshow1.Studio, xbmctvshow1.Mpaa)
                                                If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then
                                                    maincollection.pbar1.Visible = True
                                                    maincollection.lblPbar.Visible = True
                                                    maincollection.lblPbar.BringToFront()
                                                    maincollection.lblPbar.Text = "Scanning: " + getfilefrompath(item) '+ "--"
                                                    maincollection.Refresh()
                                                    Dim curmedinfo As New MediaInfo
                                                    curmedinfo.getdata(tepisode1, True)
                                                End If
                                                curxbmcmultiepisode.episodes.Add(xbmced1)
                                                curepcou += 1
                                                'xbmced1.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")

                                            End If

                                        End While
                                        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
                                        Dim writnfo As Boolean = False
                                        If Not File.Exists(Strings.Left(item.ToString, item.Length - 4) + ".nfo") Then writnfo = True
                                        If rconf.tv_episode_overwrite_nfo Then writnfo = True
                                        If writnfo Then
                                            curxbmcmultiepisode.writeNfo(Strings.Left(item.ToString, item.Length - 4) + ".nfo")
                                        End If
                                        'Dim epname As String = epPeices(epPeices.Length - 1)


                                    End If
                                    'End If
                                Case Else
                            End Select
                            filelisting.Add(item)
                        Catch ex As Exception 'catch bad filename or location exception
                        End Try
                    Next
                Catch ex As Exception 'catch bad parse of directory
                End Try
            Next

            Try
                'season logic goes here
                Dim curseasoncounter As Integer = 0
                Dim seasonsfound As New ArrayList
                Dim seasonsused As New Hashtable
                While curseasoncounter < curseason.episodes.Count
                    'scan for all season numbers
                    Dim vcurepisode As tvdblangEpisode = curseason.episodes(curseasoncounter)
                    Try
                        seasonsused.Add(CInt(vcurepisode.SeasonNumber), vcurepisode.SeasonNumber)
                    Catch ex As Exception
                        'Debug.Print("exception here is expected to filter season numbers as the hashtable won't accept duplicates, crude but works")
                    End Try
                    curseasoncounter += 1
                End While
                Dim tcount As Integer = 0
                While tcount <= 100 'handles 100 seasons
                    'If seasonsused.ContainsValue(CStr(tcount)) Or tcount = 0 Then
                    Dim tseasonholder As New seasons
                    tseasonholder.seasonnumber = CStr(tcount)
                    seasonsfound.Add(tseasonholder)
                    'End If
                    tcount += 1
                End While
                curseasoncounter = 0
                While curseasoncounter < curseason.episodes.Count
                    'put shows in correct object - fix for bogus missed season
                    Dim vcurepisode As tvdblangEpisode = curseason.episodes(curseasoncounter)
                    Try
                        Dim tempseasonnumber As Integer = 0
                        tempseasonnumber = CInt(vcurepisode.SeasonNumber)
                        Dim tseason As seasons = CType(seasonsfound.Item(tempseasonnumber), movieinfoplus.seasons)
                        tseason.episodes.Add(vcurepisode)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += "fixme: " + vbNewLine + ex.ToString '"... Done"
                    End Try
                    curseasoncounter += 1
                End While

                '"filter down the list to just those that have episodes"
                For Each tseason1 As seasons In seasonsfound
                    If tseason1.episodes.Count > 0 Then
                        curCompleteShow.seasons.Add(tseason1)
                    End If
                    'If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "================= 582 =================="
                Next
                'Next
                'curCompleteShow.seasons.Add(curseason)
                showarrayofallseasons.Add(curCompleteShow)
            Catch ex As Exception
            End Try
            counter += 1
        End While

        'Debug.Print(tvsholistedpath.ToString)
        maincollection.mytvshowcollection = showarrayofallseasons

        'update gui counter
        maincollection.klNumTvShows.Text = numtvshowstotal.ToString
        'stpw2.Stop()
        'MsgBox(stpw2.Elapsed.ToString)
        'display missing shows and episodes that didn't scan
        'If Not gvNoShowsList = "" Or Not gvFailedEPList.Count = 0 Then
        '    Dim bfont As New Font(dlgMessageboxOK.message.Font, FontStyle.Bold)
        '    Dim rfont As New Font(dlgMessageboxOK.message.Font, FontStyle.Regular)
        '    If Not gvNoShowsList = "" Then
        '        dlgMessageboxOK.message.Font = bfont
        '        dlgMessageboxOK.message.Text += "No show data exists for the following shows:" + gvNoShowsList
        '        dlgMessageboxOK.message.Font = rfont
        '        dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
        '    End If
        '    For Each failedshowobj As showfileobj In gvFailedEPList

        '    Next
        '    If Not gvFailedEPList.Count = 0 Then
        '        dlgMessageboxOK.failedfiles = gvFailedEPList
        '        dlgMessageboxOK.message.Font = bfont
        '        dlgMessageboxOK.message.Text += "The following episodes could not be loaded:"
        '        dlgMessageboxOK.message.Font = rfont
        '        For Each failedshowobj As showfileobj In gvFailedEPList
        '            dlgMessageboxOK.message.Text += vbNewLine & failedshowobj.showname & ": " & failedshowobj.filename
        '        Next
        '        dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
        '        'dlgMessageboxOK.message.Text += "The following episodes could not be loaded:" + gvFailedEPList
        '        'dlgMessageboxOK.message.Text += vbNewLine & "----------------------------" & vbNewLine
        '    End If
        '    'dlgMessageboxOK.message.SelectionStart = dlgMessageboxOK.message.Find("No show data exists for the following shows:")
        '    'dlgMessageboxOK.message.SelectionFont = bfont
        '    ' dlgMessageboxOK.message.SelectionStart = dlgMessageboxOK.message.Find("The following episodes could not be loaded:")
        '    'dlgMessageboxOK.message.SelectionFont = bfont
        '    dlgMessageboxOK.ShowInTaskbar = True
        '    dlgMessageboxOK.BringToFront()
        '    dlgMessageboxOK.ShowDialog()
        'End If
    End Sub

    Private Function getfilefrompath(ByVal filenameandpath As String) As String
        Dim fnPeices1() As String = filenameandpath.ToString.Split(CChar("\"))
        Dim returnedfilename As String = fnPeices1(fnPeices1.Length - 1)
        Return returnedfilename
    End Function
    Public Sub precacheTVShowsCmdLine(ByRef curarray As ArrayList, Optional ByVal debugon As Boolean = False)
        Console.Out.WriteLine("Starting pre-cache of images and data for tv shows")
        'ssprecaching.Show()
        rconf = rconf.getconfig("config", True)
        'If rconf.debugtvshows Or debugon Then
        dbgTVShows = False 'no command line debug
        ' End If
        Dim boguscounter As Integer = 0
        Dim maindttv As New DataTable
        maindttv.Columns.Add("Path", GetType(System.String))
        maindttv.Columns.Add("Name")
        maindttv.Columns.Add("TvdbidNum")
        maindttv.Columns.Add("Index")
        Dim showcount As Integer = 0
        Dim tvshowarray As New ArrayList

        For Each item In rconf.pclbTVPaths 'maincollection.lbTVShows.CheckedItems
            'ennum sub dir x levels deep
            Dim curdircontents() As String
            curdircontents = Directory.GetDirectories(item.ToString)
            For Each currentdir As String In curdircontents
                Try
                    If Not validshowdirc(currentdir) Then 'If Strings.Right(currentdir.ToUpper, 8) = "RECYCLER" Or Strings.Right(currentdir.ToLower, 8) = "(noscan)" Or currentdir.ToUpper = "LOST+FOUND" Or currentdir.ToUpper = "System Volume Information".ToUpper Then
                        'dont add it
                    Else
                        If Not File.Exists(currentdir & "\noscan") Then tvshowarray.Add(currentdir)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try


            Next
        Next


        While showcount < tvshowarray.Count
            Console.Out.WriteLine("")
            Dim showfullpathname As String = tvshowarray(showcount).ToString
            Console.Out.WriteLine("Processing: " & showfullpathname)
            Dim fnPeices1() As String = showfullpathname.ToString.Split(CChar("\"))
            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)

            Dim selectedshow As String = ""
            Dim tvshownfooverwrite As Boolean = False
            If File.Exists(showfullpathname + "\tvshow.nfo") Then
                Dim xbmctvshow1 As New xbmc.xbmcTvshow
                xbmctvshow1.readXML(showfullpathname + "\tvshow.nfo", xbmctvshow1)
                selectedshow = xbmctvshow1.Tvdbid
                selectedshow = Strings.Replace(selectedshow, " ", "")
                If Not selectedshow = "" Then tvshownfooverwrite = True
            End If

            If selectedshow = "" Then 'no nfo file located
                'tvdbid.txt - contains only the show id
                If File.Exists(showfullpathname + "\tvdbid.txt") Then
                    selectedshow = File.ReadAllText(showfullpathname + "\tvdbid.txt")
                    selectedshow.Trim()
                Else
                    showcount += 1
                    Console.Out.WriteLine("------------------------------")
                    Console.Out.WriteLine("No show id for the show was found - skipping")
                    Console.Out.WriteLine("Path: " & showfullpathname)
                    Console.Out.WriteLine("Create a text file named tvdbid.txt with the tvdbid number in it")
                    Console.Out.WriteLine("Or use the GUI to add a new show.")
                    Console.Out.WriteLine("------------------------------")
                    Continue While
                End If
            End If
            Console.Out.WriteLine("Id found: " & selectedshow)
            If selectedshow = "" Then
                Try
                    If Strings.Left(tfname, 3).ToLower = "csi" Then
                        getTVSeriesList("csi")
                    Else
                        getTVSeriesList(tfname)
                    End If
                Catch ex As Exception
                    Console.Out.WriteLine(ex.ToString)
                    showcount += 1 'jive fix
                    Continue While
                End Try

                Dim temptvshowdata As New TVSeriesData
                Try
                    If Strings.Left(tfname, 3).ToLower = "csi" Then
                        temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + "csi" + ".xml", temptvshowdata)
                    Else
                        temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + tfname + ".xml", temptvshowdata)
                    End If

                Catch ex As Exception
                    Console.Out.WriteLine(ex.ToString)
                    showcount += 1 'jive fix
                    Continue While
                End Try

                Dim tarray As New ArrayList
                Try
                    For Each item In temptvshowdata.SeriesArray
                        tarray.Add(item)
                    Next
                Catch ex As Exception
                    Console.Out.WriteLine("No TV Show data exsists for: " + tfname)
                    showcount += 1
                    Continue While

                End Try

                If Not tarray.Count = 1 Then
                    Console.Out.WriteLine("More then 1 TV Show data exsists for: " + tfname)
                    Console.Out.WriteLine("~ You can also add the tvshow id to a tvdbid.txt text file, or scan with MIP ~") 'More then 1 TV Show data exsists for: " + tfname
                    showcount += 1
                    Continue While
                End If
            End If

            '        Dim dtIDA As New DataTable
            '        dtIDA.Columns.Add("Path", GetType(System.String))
            '        dtIDA.Columns.Add("Name")
            '        dtIDA.Columns.Add("Index")
            '        dtIDA.Columns.Add("objShow")
            '        Dim thashtable As New Hashtable
            '        Dim cutcmIndex As Integer = 0
            '        For Each tcmitem As thetvdb.TvSeries In tarray 'update path info for real code
            '            dtIDA.LoadDataRow(New Object() {showfullpathname, tcmitem.SeriesName, tcmitem.seriesid, tcmitem}, True)
            '            thashtable.Add(tcmitem.seriesid, tcmitem)
            '            cutcmIndex += 1
            '        Next
            '        dialogTvShowSelect.dhashtable = thashtable
            '        dtIDA.DefaultView.Sort = "Name"
            '        dialogTvShowSelect.klbPickTheTvShow.DataSource = dtIDA.DefaultView
            '        dialogTvShowSelect.klbPickTheTvShow.ValueMember = "Index"
            '        dialogTvShowSelect.klbPickTheTvShow.DisplayMember = "Name"
            '        dialogTvShowSelect.displayshowdata()
            '        dialogTvShowSelect.klbltvCurShow.Text = "TV Show Folder Name: " + tfname
            '        dialogTvShowSelect.klbltvCurShowPath.Text = "TV Show Location on drive: " + showfullpathname
            '        dialogTvShowSelect.Refresh()
            '        If dbgTVShows Then dlgTVShowCurStatus.Hide()
            '        dialogTvShowSelect.ShowDialog()
            '        If dialogTvShowSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
            '            MsgBox("Cancel Selected, the show has not been added.")
            '            showcount += 1
            '            Continue While
            '        Else
            '            selectedshow = CStr(dialogTvShowSelect.klbPickTheTvShow.SelectedValue)
            '            selectedshow = Strings.Replace(selectedshow, " ", "")
            '        End If

            '        Debug.Print(selectedshow)
            '        dialogTvShowSelect.Dispose()
            '        If dbgTVShows Then dlgTVShowCurStatus.Show()
            '    Else
            '        Dim tvbdseries1 As New thetvdb.TvSeries
            '        tvbdseries1 = CType(tarray.Item(0), TvSeries)
            '        selectedshow = tvbdseries1.seriesid
            '        selectedshow = Strings.Replace(selectedshow, " ", "")
            '    End If
            'End If
            If selectedshow = "" Then 'break out of while loop, no show id
                showcount += 1
                Continue While
            End If
            Dim numtoaddfromconf As Integer = 5
            numtoaddfromconf = CInt(rconf.pcombolTVCheckForNewTVShowData)
            Console.Out.WriteLine(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")

            'check file size, remove 0k zip files
            If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                If getFileSizeExact(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") < 1 Then
                    File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                End If
            End If

            ''old method, checks date on zip file, it's done again later, might as well do it now before the precache starts for new items
            If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                If File.GetLastWriteTime(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip").AddDays(numtoaddfromconf) < Date.Now Then
                    If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                    If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                End If
            End If

            'changed back - will now update on precache
            If Not File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                Try

                    If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)

                    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                Catch ex As Exception
                    Try
                        If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                    Catch ex2 As Exception
                    End Try
                End Try
            End If

            If Not selectedshow = "" Then
                If Not File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                    Debug.Print("error, major")
                    wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    Try
                        decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                    Catch ex As Exception
                        'try to get it again, removing what is prob a 0k zip file
                        If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                            File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                        End If
                        wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    End Try
                    Try
                        decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                    Catch ex As Exception
                        showcount += 1 'jive fix
                        Continue While
                    End Try
                    'decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                End If
            End If
            If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\banners.xml") Then
                Try
                    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                Catch ex As Exception
                    showcount += 1 'break out of loop, no banners.xml or it failed to extract
                    Continue While
                End Try
            End If
            '--------------------------------------Section Start----------------------------------------
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            'read in banners.xml and then process it
            Console.Out.WriteLine("Starting banner processing")
            Dim tbanners As New Banners
            Try
                tbanners.readBannerXML(rconf.tvdbcachefolder + selectedshow + "\banners.xml", tbanners)
            Catch ex As Exception
                'MsgBox("Error in banner read, this means I could not read the file: " + vbNewLine + rconf.tvdbcachefolder + selectedshow + "\banners.xml" + vbNewLine + "It could be that I did not get the zip file from tvdb, or it's corrupted." + vbNewLine + "Moving on to the next show")
                Debug.Print(rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print("unable to load xml file from cache folder")
                showcount += 1
                Continue While 'break out of while loop, no data in banners 
            End Try

            'download banners/fanarts/posters/etc
            Dim fanartcounter As Integer = 0
            Dim postercounter As Integer = 0
            Dim seasoncounter As Integer = 0
            Dim seriescounter As Integer = 0
            'check for folders
            'rconf.tv_usewgetforimages = False
            Console.Out.WriteLine("Image processing running")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\blank") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\blank")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\text") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\text")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\poster") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\poster")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\posters") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\posters")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\series") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\series")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\season") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\season")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes")
            For Each tmbanner As BannersBanner In tbanners.Banners
                If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'check language and match it, if no match, skip it
                    'See If the file already exsists

                    Dim switchpath As String = Strings.Replace(tmbanner.BannerPath, "/", "\")
                    Debug.Print(switchpath)

                    Select Case tmbanner.BannerType.ToLower
                        Case "fanart"
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_fanart_download_boolean And fanartcounter < rconf.tv_tvshow_fanart_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvfanart(tmbanner, selectedshow, switchpath, curarray)
                            End If
                            fanartcounter += 1
                        Case "poster"
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_posters_download_boolean And postercounter < rconf.tv_tvshow_posters_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvposters(tmbanner, selectedshow, switchpath, curarray)
                            End If

                            postercounter += 1
                        Case "season"
                            Dim boolGetSeason As Boolean = False
                            Dim boolGetSeasonwide As Boolean = False

                            Try
                                If rconf.tv_season_banners_download_type_string.ToLower = "all" Then
                                    boolGetSeason = True
                                    boolGetSeasonwide = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "season" Then
                                    boolGetSeason = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "seasonwide" Then
                                    boolGetSeasonwide = True
                                End If
                                'workaround for busted configs where the value isn't entered correctly
                                If boolGetSeason = False And boolGetSeasonwide = False Then boolGetSeason = True
                            Catch ex As Exception
                                boolGetSeason = True
                                Debug.Print(ex.ToString)
                            End Try


                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'And rconf.tv_getseasonbanners And seasoncounter < rconf.tv_maxtvseasonbanners Then
                                If tmbanner.BannerType2.ToLower = "season" And boolGetSeason And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseasonbanners(tmbanner, selectedshow, switchpath, curarray)
                                If tmbanner.BannerType2.ToLower = "seasonwide" And boolGetSeasonwide And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseasonbanners(tmbanner, selectedshow, switchpath, curarray)
                                'check series length
                                Dim vSeasonLen As Integer = tmbanner.Season.Length
                                Dim vSeasonPreText As String = ""

                                If vSeasonLen = 1 Then vSeasonPreText = "season0"
                                If vSeasonLen >= 2 Then vSeasonPreText = "season"

                                Dim vSeasonNumConcat As String = vSeasonPreText + tmbanner.Season.ToString
                                If tmbanner.BannerType2.ToLower = rconf.tv_season_banners_toapply_string Then
                                    seasoncounter += 1
                                End If
                            End If

                        Case "series" 'note: series is the wide icons, with different text (or graphical version of text, or no text) for the tvshow
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_wideicon_download_boolean And seriescounter < rconf.tv_tvshow_wideicon_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseriesbanners(tmbanner, selectedshow, switchpath, curarray)
                            End If
                            seriescounter += 1
                    End Select
                End If
                'End If
            Next
            Console.Out.WriteLine("BANNERS FANART POSTERS STARTING ") ' & selectedshow)
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            '--------------------------------------Section END------------------------------------------

            Dim newtvdbData As New tvdblangData
            Dim newactors As New Actors
            newactors.readXML(rconf.tvdbcachefolder + selectedshow + "\Actors.xml", newactors)
            'tvdblangseries2xbmcTvshow()
            Dim xbmctvshow As New xbmc.xbmcTvshow
            Try
                newtvdbData.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbData)
                Debug.Print("read completed")
                newtvdbData.Series.tvdblangseries2xbmcTvshow(newtvdbData.Series, xbmctvshow, newactors)
                xbmctvshow.Genre = Strings.Replace(xbmctvshow.Genre, "|", "/")
                Try
                    If xbmctvshow.Genre.Length > 0 And Strings.Left(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Right(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                    If xbmctvshow.Genre.Length > 0 And Strings.Right(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Left(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
                xbmctvshow.Episodeguideurl = "http://www.thetvdb.com/api/1D62F2F90030C444/series/" + selectedshow + "/all/" + curlang + ".zip"
                If rconf.pcbshows_UseStudioasRating Then
                    xbmctvshow.Rating = xbmctvshow.Studio
                End If
                xbmctvshow.writeXML(showfullpathname) '"c:\")
                Console.Out.WriteLine("episode level images download setting: " & rconf.tv_episode_download_boolean.ToString)
                If rconf.tv_episode_download_boolean Then
                    For Each curep As tvdblangEpisode In newtvdbData.Episodes
                        Dim switchpath As String = Strings.Replace(curep.Filename, "/", "\")
                        Dim parentdir As String = getparentdirectory(rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                        If Not Directory.Exists(parentdir) Then Directory.CreateDirectory(parentdir)
                        If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) And Not curep.Filename = "" Then
                            Console.Out.WriteLine("no episode level image found.. download required")
                            mgettvepisodeimages(curep, selectedshow, switchpath, curarray)
                        End If
                    Next
                End If
                'maincollection.tsbtvPreCacheMediaIconsdata(xbmctvshow.Title)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            showcount += 1
        End While
        Console.Out.WriteLine("done")
        'maincollection.lblPbar.Text = "Download Processing Completed"
        'maincollection.Refresh()
        'maincollection.lblPbar.Visible = False
        'maincollection.pbar1.Visible = False
        ''ssprecaching.Dispose()
        'ssprecaching.Close()
        'get episodes


    End Sub

    Public Sub precacheTvShows(Optional ByVal debugon As Boolean = False)
        'ssprecaching.Show()
        rconf = rconf.getconfig("config", True)
        If rconf.debugtvshows Or debugon Then
            dbgTVShows = True
        End If
        Dim boguscounter As Integer = 0
        If dbgTVShows Then dlgTVShowCurStatus.Show()
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Reading Folder Data"
        Dim maindttv As New DataTable
        maindttv.Columns.Add("Path", GetType(System.String))
        maindttv.Columns.Add("Name")
        maindttv.Columns.Add("TvdbidNum")
        maindttv.Columns.Add("Index")
        Dim showcount As Integer = 0
        Dim tvshowarray As New ArrayList

        For Each item In rconf.pclbTVPaths 'maincollection.lbTVShows.CheckedItems
            'ennum sub dir x levels deep
            Dim curdircontents() As String
            curdircontents = Directory.GetDirectories(item.ToString)
            For Each currentdir As String In curdircontents
                Try
                    If Not validshowdirc(currentdir) Then 'If Strings.Right(currentdir.ToUpper, 8) = "RECYCLER" Or Strings.Right(currentdir.ToLower, 8) = "(noscan)" Or currentdir.ToUpper = "LOST+FOUND" Or currentdir.ToUpper = "System Volume Information".ToUpper Then
                        'dont add it
                    Else
                        If Not File.Exists(currentdir & "\noscan") Then tvshowarray.Add(currentdir)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try


            Next
        Next
        maincollection.pbar1.Visible = True
        maincollection.lblPbar.Visible = True
        maincollection.lblPbar.BringToFront()
        While showcount < tvshowarray.Count
            Dim showfullpathname As String = tvshowarray(showcount).ToString
            Dim fnPeices1() As String = showfullpathname.ToString.Split(CChar("\"))
            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)

            maincollection.lblPbar.Text = "Preping " + tfname + "'s Download Data"
            maincollection.Refresh()
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + vbNewLine + "-----------------------------------------"
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Processing: " + tfname
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "-----------------------------------------"
            Dim selectedshow As String = ""
            Dim tvshownfooverwrite As Boolean = False
            If File.Exists(showfullpathname + "\tvshow.nfo") Then
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Found tvshow.nfo.. loading..."
                Dim xbmctvshow1 As New xbmc.xbmcTvshow
                xbmctvshow1.readXML(showfullpathname + "\tvshow.nfo", xbmctvshow1)
                selectedshow = xbmctvshow1.Tvdbid
                selectedshow = Strings.Replace(selectedshow, " ", "")
                If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "TMDB ID: " + selectedshow
                If Not selectedshow = "" Then tvshownfooverwrite = True
            End If

            If selectedshow = "" Then
                Try
                    If Strings.Left(tfname, 3).ToLower = "csi" Then
                        getTVSeriesList("csi")
                    Else
                        getTVSeriesList(tfname)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                    showcount += 1 'jive fix
                    Continue While
                End Try

                Dim temptvshowdata As New TVSeriesData
                Try
                    If Strings.Left(tfname, 3).ToLower = "csi" Then
                        temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + "csi" + ".xml", temptvshowdata)
                    Else
                        temptvshowdata.readTVSeriesXML(rconf.basefolder + "temp\tvdb\" + tfname + ".xml", temptvshowdata)
                    End If

                Catch ex As Exception
                    Debug.Print(ex.ToString)
                    showcount += 1 'jive fix
                    Continue While
                End Try

                Dim tarray As New ArrayList
                Try
                    For Each item In temptvshowdata.SeriesArray
                        tarray.Add(item)
                    Next
                Catch ex As Exception
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "No TV Show data exsists for: " + tfname
                    showcount += 1
                    Continue While

                End Try


                If Not tarray.Count = 1 Then
                    Dim dtIDA As New DataTable
                    dtIDA.Columns.Add("Path", GetType(System.String))
                    dtIDA.Columns.Add("Name")
                    dtIDA.Columns.Add("Index")
                    dtIDA.Columns.Add("objShow")
                    Dim thashtable As New Hashtable
                    Dim cutcmIndex As Integer = 0
                    For Each tcmitem As thetvdb.TvSeries In tarray 'update path info for real code
                        dtIDA.LoadDataRow(New Object() {showfullpathname, tcmitem.SeriesName, tcmitem.seriesid, tcmitem}, True)
                        thashtable.Add(tcmitem.seriesid, tcmitem)
                        cutcmIndex += 1
                    Next
                    dialogTvShowSelect.dhashtable = thashtable
                    dtIDA.DefaultView.Sort = "Name"
                    dialogTvShowSelect.klbPickTheTvShow.DataSource = dtIDA.DefaultView
                    dialogTvShowSelect.klbPickTheTvShow.ValueMember = "Index"
                    dialogTvShowSelect.klbPickTheTvShow.DisplayMember = "Name"
                    dialogTvShowSelect.displayshowdata()
                    dialogTvShowSelect.klbltvCurShow.Text = "TV Show Folder Name: " + tfname
                    dialogTvShowSelect.klbltvCurShowPath.Text = "TV Show Location on drive: " + showfullpathname
                    dialogTvShowSelect.Refresh()
                    If dbgTVShows Then dlgTVShowCurStatus.Hide()
                    dialogTvShowSelect.ShowDialog()
                    If dialogTvShowSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                        MsgBox("Cancel Selected, the show has not been added.")
                        showcount += 1
                        Continue While
                    Else
                        selectedshow = CStr(dialogTvShowSelect.klbPickTheTvShow.SelectedValue)
                        selectedshow = Strings.Replace(selectedshow, " ", "")
                    End If

                    Debug.Print(selectedshow)
                    dialogTvShowSelect.Dispose()
                    If dbgTVShows Then dlgTVShowCurStatus.Show()
                Else
                    Dim tvbdseries1 As New thetvdb.TvSeries
                    tvbdseries1 = CType(tarray.Item(0), TvSeries)
                    selectedshow = tvbdseries1.seriesid
                    selectedshow = Strings.Replace(selectedshow, " ", "")
                End If
            End If

            Dim numtoaddfromconf As Integer = 5
            numtoaddfromconf = CInt(rconf.pcombolTVCheckForNewTVShowData)
            'check file size, remove 0k zip files
            If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                If getFileSizeExact(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") < 1 Then
                    File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                End If
            End If

            ''old method, checks date on zip file, it's done again later, might as well do it now before the precache starts for new items
            If File.GetLastWriteTime(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip").AddDays(numtoaddfromconf) < Date.Now Then
                If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
            End If

            'changed back - will now update on precache
            If Not File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                Try
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Looking for zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    If Not selectedshow = "" Then wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Decompressing zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                Catch ex As Exception
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "FAILED during decompression of zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Removing corrupt zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    Try
                        If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                    Catch ex2 As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "FAILED to remove corrupt zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    End Try
                End Try
            End If

            If Not selectedshow = "" Then
                If Not File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "no zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    Debug.Print("error, major")
                    If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "downloading zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                    wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    Try
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "decompressing zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "FAILED during decompression of zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        'try to get it again, removing what is prob a 0k zip file
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "checking for partial zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        If File.Exists(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip") Then
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Removing partial zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                            File.Delete(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip")
                        End If
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading zip file again: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        wgetTVDB(curmirror + "/api/" + miptvdbkey + "/series/" + selectedshow + "/all/" + curlang + ".zip", "everything", True, selectedshow)
                    End Try
                    Try
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "decompressing zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                    Catch ex As Exception
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "FAILED during decompression of zip file: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Moving on to next show, too many failed attempts at getting the data: " + rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip"
                        showcount += 1 'jive fix
                        Continue While
                    End Try
                    'decompresszip(rconf.tvdbtempfolder + "everything\" + selectedshow + ".zip", rconf.tvdbcachefolder + selectedshow, True)
                End If
            End If
            '--------------------------------------Section Start----------------------------------------
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            'read in banners.xml and then process it
            Dim tbanners As New Banners
            Try
                tbanners.readBannerXML(rconf.tvdbcachefolder + selectedshow + "\banners.xml", tbanners)
            Catch ex As Exception
                'MsgBox("Error in banner read, this means I could not read the file: " + vbNewLine + rconf.tvdbcachefolder + selectedshow + "\banners.xml" + vbNewLine + "It could be that I did not get the zip file from tvdb, or it's corrupted." + vbNewLine + "Moving on to the next show")
                Debug.Print(rconf.tvdbcachefolder + selectedshow + "\banners.xml")
                Debug.Print("unable to load xml file from cache folder")
                showcount += 1
                Continue While 'break out of while loop, no data in banners 
            End Try

            'download banners/fanarts/posters/etc
            Dim fanartcounter As Integer = 0
            Dim postercounter As Integer = 0
            Dim seasoncounter As Integer = 0
            Dim seriescounter As Integer = 0
            'check for folders
            'rconf.tv_usewgetforimages = False

            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\fanart\original")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\graphical")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\blank") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\blank")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\text") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\text")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\poster") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\poster")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\posters") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\posters")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\series") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\series")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\season") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\season")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasons")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\seasonswide")
            If Not Directory.Exists(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes") Then Directory.CreateDirectory(rconf.tvdbcachefolder + "\" + selectedshow + "\episodes")
            For Each tmbanner As BannersBanner In tbanners.Banners
                If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'check language and match it, if no match, skip it
                    'See If the file already exsists

                    Dim switchpath As String = Strings.Replace(tmbanner.BannerPath, "/", "\")
                    Debug.Print(switchpath)

                    Select Case tmbanner.BannerType.ToLower
                        Case "fanart"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Fanart Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_fanart_download_boolean And fanartcounter < rconf.tv_tvshow_fanart_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvfanart(tmbanner, selectedshow, switchpath)
                            End If
                            fanartcounter += 1
                        Case "poster"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Poster Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_posters_download_boolean And postercounter < rconf.tv_tvshow_posters_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvposters(tmbanner, selectedshow, switchpath)
                            End If

                            postercounter += 1
                        Case "season"
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Season Items: " + switchpath
                            Dim boolGetSeason As Boolean = False
                            Dim boolGetSeasonwide As Boolean = False

                            Try
                                If rconf.tv_season_banners_download_type_string.ToLower = "all" Then
                                    boolGetSeason = True
                                    boolGetSeasonwide = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "season" Then
                                    boolGetSeason = True
                                ElseIf rconf.tv_season_banners_download_type_string.ToLower = "seasonwide" Then
                                    boolGetSeasonwide = True
                                End If
                                'workaround for busted configs where the value isn't entered correctly
                                If boolGetSeason = False And boolGetSeasonwide = False Then boolGetSeason = True
                            Catch ex As Exception
                                boolGetSeason = True
                                Debug.Print(ex.ToString)
                            End Try


                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) Then 'And rconf.tv_getseasonbanners And seasoncounter < rconf.tv_maxtvseasonbanners Then
                                If tmbanner.BannerType2.ToLower = "season" And boolGetSeason And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseasonbanners(tmbanner, selectedshow, switchpath)
                                If tmbanner.BannerType2.ToLower = "seasonwide" And boolGetSeasonwide And Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseasonbanners(tmbanner, selectedshow, switchpath)
                                'check series length
                                Dim vSeasonLen As Integer = tmbanner.Season.Length
                                Dim vSeasonPreText As String = ""

                                If vSeasonLen = 1 Then vSeasonPreText = "season0"
                                If vSeasonLen >= 2 Then vSeasonPreText = "season"

                                Dim vSeasonNumConcat As String = vSeasonPreText + tmbanner.Season.ToString
                                If tmbanner.BannerType2.ToLower = rconf.tv_season_banners_toapply_string Then
                                    seasoncounter += 1
                                End If
                            End If

                        Case "series" 'note: series is the wide icons, with different text (or graphical version of text, or no text) for the tvshow
                            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Checking Series Items: " + switchpath
                            If (curlang = tmbanner.Language Or rconf.pcbtvlangoverride) And rconf.tv_tvshow_wideicon_download_boolean And seriescounter < rconf.tv_tvshow_wideicon_download_maxnumber_integer Then
                                If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) Then mgettvseriesbanners(tmbanner, selectedshow, switchpath)
                            End If
                            seriescounter += 1
                    End Select
                End If
                'End If
            Next
            '------------------------ BANNERS FANART POSTERS from banners.xml file ---------------------
            '--------------------------------------Section END------------------------------------------
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Done with Banners Fanart and Posters"
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Processing Actors Data"
            'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
            Dim newtvdbData As New tvdblangData
            Dim newactors As New Actors
            newactors.readXML(rconf.tvdbcachefolder + selectedshow + "\Actors.xml", newactors)
            'tvdblangseries2xbmcTvshow()
            Dim xbmctvshow As New xbmc.xbmcTvshow
            Try
                newtvdbData.readXML(rconf.tvdbcachefolder + selectedshow + "\" + curlang + ".xml", newtvdbData)
                Debug.Print("read completed")
                newtvdbData.Series.tvdblangseries2xbmcTvshow(newtvdbData.Series, xbmctvshow, newactors)
                xbmctvshow.Genre = Strings.Replace(xbmctvshow.Genre, "|", "/")
                Try
                    If xbmctvshow.Genre.Length > 0 And Strings.Left(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Right(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                    If xbmctvshow.Genre.Length > 0 And Strings.Right(xbmctvshow.Genre, 1) = "/" Then
                        xbmctvshow.Genre = Strings.Left(xbmctvshow.Genre, xbmctvshow.Genre.Length - 1)
                    End If
                Catch ex As Exception
                    Debug.Print(ex.ToString)
                End Try
                xbmctvshow.Episodeguideurl = "http://www.thetvdb.com/api/1D62F2F90030C444/series/" + selectedshow + "/all/" + curlang + ".zip"
                If rconf.pcbshows_UseStudioasRating Then
                    xbmctvshow.Rating = xbmctvshow.Studio
                End If
                xbmctvshow.writeXML(showfullpathname) '"c:\")
                If rconf.tv_episode_download_boolean Then
                    For Each curep As tvdblangEpisode In newtvdbData.Episodes
                        Dim switchpath As String = Strings.Replace(curep.Filename, "/", "\")
                        Dim parentdir As String = getparentdirectory(rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                        If Not Directory.Exists(parentdir) Then Directory.CreateDirectory(parentdir)
                        If Not File.Exists(rconf.tvdbcachefolder + selectedshow + "\" + switchpath) And Not curep.Filename = "" Then
                            mgettvepisodeimages(curep, selectedshow, switchpath)
                        End If
                    Next
                End If
                maincollection.tsbtvPreCacheMediaIconsdata(xbmctvshow.Title)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            showcount += 1
        End While
        maincollection.lblPbar.Text = "Download Processing Completed"
        maincollection.Refresh()
        maincollection.lblPbar.Visible = False
        maincollection.pbar1.Visible = False
        'ssprecaching.Dispose()
        'ssprecaching.Close()
        'get episodes

    End Sub

    Private Sub EnumTVDirectory(ByVal RootDirectory As String, ByRef thearray As ArrayList, ByRef thecounter As Integer)

        'For Each s As String In Directory.GetDirectories(RootDirectory)
        'Debug.WriteLine("File found: " & s)
        'Next s
        For Each s As String In Directory.GetDirectories(RootDirectory)
            Debug.Print("EnumTVDirecotry running on : " + s)

            If Not (File.GetAttributes(s) And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then
                '    Debug.WriteLine("Sub Enumerate Directory -- Directory found: " & s)
                'debug counter
                thecounter = thecounter + 1
                'Debug.Print(dlist_count)
                'Add all files to the global array
                If ((Strings.Right(s, 8)).ToLower = "video_ts" Or (Strings.Right(s, 8)).ToLower = "audio_ts" Or (Strings.Right(s, 7)).ToLower = "highdef" Or (Strings.Right(s, 15)).ToLower = "temporary files" Or (Strings.Right(s, 8)).ToUpper = "RECYCLER" Or (Strings.Right(s, 8)).ToLower = "(noscan)" Or s.ToUpper = "LOST+FOUND" Or s.ToUpper = "System Volume Information".ToUpper) Then
                    Debug.Print("Sub Enumerate Directory -- found video or audio ts at " + Convert.ToString(thecounter) + " - skipping")
                Else
                    If Not File.Exists(s & "\noscan") Then thearray.Add(s)
                End If
                EnumTVDirectory(s, thearray, thecounter) ' will parse sub dirs
            End If
        Next s
        'Return junk
    End Sub
    Private Sub gettvfanart(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String)

        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
            dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            dlgDownloadingFile.ShowDialog()

            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Fanart: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub gettvposters(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.lblCurItem.Visible = True
            dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            dlgDownloadingFile.ShowDialog()
            'dlgDownloadingFile.go()
            'maincollection.lblCurItem.Text = "Downloading Posters: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'dlgDownloadingFile.Hide()
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub gettvseasonbanners(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            dlgDownloadingFile.ShowDialog()
            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Season Banners: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub gettvseriesbanners(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            dlgDownloadingFile.ShowDialog()
            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Series Banners: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub decompresszip(ByVal fileToUncompress As String, ByVal folderToSaveExtractedContentsTo As String, ByVal wait As Boolean)
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Decompressing " + "archive: " + fileToUncompress
        'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
        Dim binfilelocal As String = """" + rconf.sevenzipfolder + "7za.exe" + """"
        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        pro1.StartInfo.Arguments = " e " + """" + fileToUncompress + """" + " -yo" + """" + folderToSaveExtractedContentsTo + """"

        ''old method
        'Dim binfilelocal As String = """" + rconf.sevenzipfolder + "7za.exe" + """"
        'System.Diagnostics.Process.Start(binfilelocal, " e " + """" + fileToUncompress + """" + " -yo" + """" + folderToSaveExtractedContentsTo + """")
        pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        pro1.Start()
        pro1.WaitForExit()
    End Sub
    Private Sub wgetTVimages(ByVal url As String, ByVal vselectedshow As String, ByVal vtpath As String, ByVal id As String, ByVal wait As Boolean)
        Dim binfilelocal As String = rconf.wgetfolder + "wget.exe"
        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + rconf.tvdbcachefolder + vselectedshow + "\" + vtpath + """" '+ id + ".jpg" + """"
        If rconf.tv_showwgetwindows Then
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        Else
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        End If

        If Not wait Then System.Threading.Thread.Sleep(rconf.tv_wgetsleepinmilliseconds) 'to slow things down and not flag IDS/IPS systems
        pro1.Start()
        If wait Then pro1.WaitForExit()
    End Sub
    Private Sub wgetTVEpisodeImage(ByVal url As String, ByVal destinationpathandname As String, ByVal wait As Boolean)
        'dlgDownloadingFile.downloadertxtFileName.Text = url 'curmirror + "/banners/" + tmbanner.BannerPath
        'dlgDownloadingFile.whereToSave = destinationpathandname 'rconf.tvdbcachefolder + selectedshow + "\" + switchpath
        'dlgDownloadingFile.ShowDialog()
        'first 3 lines are off since the path in the xml changed . rev 2808 change 

        'Dim binfilelocal As String = rconf.wgetfolder + "wget.exe"
        'Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        'pro1.StartInfo.FileName = binfilelocal
        'pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + destinationpathandname + """" '+ id + ".jpg" + """"
        'If rconf.tv_showwgetwindows Then
        '    pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'Else
        '    pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'End If
        'If Not wait Then System.Threading.Thread.Sleep(rconf.tv_wgetsleepinmilliseconds) 'to slow things down and not flag IDS/IPS systems
        'pro1.Start()
        'If wait Then pro1.WaitForExit()
    End Sub
    Private Sub wgetTVDB(ByRef url As String, ByRef id As String, ByVal wait As Boolean, ByVal vseriesid As String)
        Dim binfilelocal As String = rconf.wgetfolder + "wget.exe"

        'If id = "getimdbidsearch" Then
        '    If File.Exists(rconf.tvdbtempfolder + "index.html") Then
        '        File.Delete(rconf.tvdbtempfolder + "tvdb\" + "index.html")
        '    End If
        'End If
        'If id = "getimdbidsearch" Then
        '    dlgDownloadingFile.whereToSave = rconf.tvdbtempfolder + id.ToString + "\index.html"
        '    dlgDownloadingFile.downloadertxtFileName.Text = url 'curmirror + "/banners/" + tmbanner.BannerPath
        '    dlgDownloadingFile.ShowDialog()
        'Else
        '    dlgDownloadingFile.whereToSave = rconf.tvdbtempfolder + "everything\" + vseriesid + ".zip" 'id.ToString + "\index.html"
        '    dlgDownloadingFile.downloadertxtFileName.Text = url 'curmirror + "/banners/" + tmbanner.BannerPath
        '    dlgDownloadingFile.ShowDialog()

        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        Dim whereToSave As String
        whereToSave = rconf.tvdbtempfolder + "everything\" + vseriesid + ".zip"
        pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + whereToSave + """"
        'Debug.Print("""" + url + """" + " -P " + """" + rconf.tvdbtempfolder + id.ToString + """")
        If rconf.tv_showwgetwindows Then
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        Else
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        End If
        pro1.Start()
        pro1.WaitForExit()

        'End If

        'Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        'pro1.StartInfo.FileName = binfilelocal

        'If id = "getimdbidsearch" Then
        '    pro1.StartInfo.Arguments = """" + url + """" + " -O " + """" + rconf.tvdbtempfolder + id.ToString + "\index.html" + """"
        'Else
        '    pro1.StartInfo.Arguments = """" + url + """" + " -P " + """" + rconf.tvdbtempfolder + id.ToString + """"
        '    Debug.Print("""" + url + """" + " -P " + """" + rconf.tvdbtempfolder + id.ToString + """")

        'End If

        'If File.Exists(rconf.tvdbtempfolder + "index.html") Then
        'File.Delete(rconf.tvdbtempfolder + "index.html")
        'End If

        'If rconf.tv_showwgetwindows Then
        '    pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'Else
        '    pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        'End If
        'pro1.Start()
        'If wait Then pro1.WaitForExit()

    End Sub
    Private Sub readmirrors(ByRef tmirrors As Mirrors)
        tmirrors.readMirrorsXML(rconf.basefolder + "themoviedbmirrors.xml", tmirrors)
    End Sub
    Private Sub getdatesfromtvdb(ByRef tdate As String)
        Dim url As String = curmirror + "/api/" + miptvdbkey + "/updates/"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        SaveBin(response, rconf.basefolder + "themoviedbdates.xml")
    End Sub
    Private Sub getmirrors()
        Dim url As String = "http://www.thetvdb.com/api/" + miptvdbkey + "/mirrors.xml"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        SaveBin(response, rconf.basefolder + "\themoviedbmirrors.xml")
    End Sub
    Private Sub getTVSeriesList(ByVal showname As String)
        Dim url As String = curmirror + "/api/GetSeries.php?seriesname=" + showname
        Debug.Print(url)
        'Dim url As String = "http://www.thetvdb.com/api/" + miptvdbkey + "/mirrors.xml"
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
            If File.Exists(rconf.basefolder + "temp\tvdb\" + showname + ".xml") Then File.Delete(rconf.basefolder + "\temp\tvdb\" + showname + ".xml")
            SaveBin(response, rconf.basefolder + "\temp\tvdb\" + showname + ".xml")
        Catch ex As Exception
            Debug.Print("timeout when connecting to tvdb site")
        End Try

    End Sub
    Private Shared Function SaveBin(ByVal response As WebResponse, ByVal FileName As String) As Boolean
        Dim Value As Boolean = True
        Dim buffer As Byte() = New Byte(20000000) {} '20MB
        'FileName = FileName + Convert.ToString("1")

        Try
            If File.Exists(FileName) Then
                File.Delete(FileName)
            End If
            Dim outStream As Stream = System.IO.File.Create(FileName)
            Dim inStream As Stream = response.GetResponseStream()
            Dim l As Integer
            Do
                l = inStream.Read(buffer, 0, buffer.Length)
                If l > 0 Then
                    outStream.Write(buffer, 0, l)
                End If
            Loop While l > 0
            outStream.Close()
            inStream.Close()
        Catch
            Value = False
        End Try
        Return Value
    End Function
    Private Function httpget(ByVal url As String) As String
        Dim s As String
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Using reader As StreamReader = New StreamReader(response.GetResponseStream())
            s = reader.ReadToEnd()
        End Using
        Return s
    End Function
    Private Function httpgetResponse(ByVal url As String) As HttpWebResponse
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
        Return response
    End Function
#Region "Multi-get functions - used for precaching data only"
    Private Sub mgettvfanart(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String, Optional ByRef specificarraylist As ArrayList = Nothing)

        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            'If dbgTVShows Then dlgTVShowCurStatus.Refresh()()
            Dim dlobj As New miplibfc.mip.dlobject
            dlobj.URL = curmirror + "/banners/" + tmbanner.BannerPath
            dlobj.Destination = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            If Not specificarraylist Is Nothing Then
                specificarraylist.Add(dlobj)
            End If
            maincollection.currenttvshowdownloadlist.Add(dlobj)
            'dlgDownloadingFile.nomultidownload = False
            'dlgDownloadingFile.ShowDialog()

            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Fanart: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub mgettvposters(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String, Optional ByRef specificarraylist As ArrayList = Nothing)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.lblCurItem.Visible = True
            Dim dlobj As New miplibfc.mip.dlobject
            dlobj.URL = curmirror + "/banners/" + tmbanner.BannerPath
            dlobj.Destination = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            If Not specificarraylist Is Nothing Then
                specificarraylist.Add(dlobj)
            End If

            maincollection.currenttvshowdownloadlist.Add(dlobj)
            'dlgDownloadingFile.nomultidownload = False
            'dlgDownloadingFile.ShowDialog()
            'dlgDownloadingFile.go()
            'maincollection.lblCurItem.Text = "Downloading Posters: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'dlgDownloadingFile.Hide()
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub mgettvseasonbanners(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String, Optional ByRef specificarraylist As ArrayList = Nothing)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            Dim dlobj As New miplibfc.mip.dlobject
            dlobj.URL = curmirror + "/banners/" + tmbanner.BannerPath
            dlobj.Destination = rconf.tvdbcachefolder + selectedshow + "\" + switchpath

            If Not specificarraylist Is Nothing Then
                specificarraylist.Add(dlobj)
            End If
            maincollection.currenttvshowdownloadlist.Add(dlobj)

            'dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            'dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            'dlgDownloadingFile.nomultidownload = False
            'dlgDownloadingFile.ShowDialog()
            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Season Banners: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub mgettvseriesbanners(ByRef tmbanner As BannersBanner, ByRef selectedshow As String, ByRef switchpath As String, Optional ByRef specificarraylist As ArrayList = Nothing)
        If rconf.tv_usewgetforimages Then
            If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmbanner.BannerPath
            Dim dlobj As New miplibfc.mip.dlobject
            dlobj.URL = curmirror + "/banners/" + tmbanner.BannerPath
            dlobj.Destination = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            If Not specificarraylist Is Nothing Then
                specificarraylist.Add(dlobj)
            End If
            maincollection.currenttvshowdownloadlist.Add(dlobj)


            '            dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmbanner.BannerPath
            '           dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
            '          dlgDownloadingFile.nomultidownload = False
            '         dlgDownloadingFile.ShowDialog()
            'maincollection.lblCurItem.Visible = True
            'maincollection.lblCurItem.Text = "Downloading Series Banners: " + selectedshow + ": " + tmbanner.BannerPath
            'maincollection.Refresh()
            'wgetTVimages(curmirror + "/banners/" + tmbanner.BannerPath, selectedshow, switchpath, tmbanner.Id, True)
            'maincollection.lblCurItem.Visible = False
            'maincollection.Refresh()
        Else
            Try
                Dim response As HttpWebResponse = httpgetResponse(curmirror + "/banners/" + tmbanner.BannerPath)
                SaveBin(response, rconf.tvdbcachefolder + selectedshow + "\" + switchpath)
                If rconf.tv_showwgetwindows Then
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Normal)
                Else
                    File.SetAttributes(rconf.tvdbcachefolder + selectedshow + "\" + switchpath, FileAttributes.Hidden)
                End If

            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
    'mgettvepisodeimages
    Private Sub mgettvepisodeimages(ByRef tmepisode As tvdblangEpisode, ByRef selectedshow As String, ByRef switchpath As String, Optional ByRef specificarraylist As ArrayList = Nothing)
        Dim locmirror As String = "http://images.thetvdb.com.nyud.net:8080"
        If dbgTVShows Then dlgTVShowCurStatus.krbStatus.Text += vbNewLine + "Downloading " + selectedshow + ": " + tmepisode.Filename
        Dim dlobj As New miplibfc.mip.dlobject
        dlobj.URL = curmirror + "/banners/" + tmepisode.Filename
        dlobj.Destination = rconf.tvdbcachefolder + selectedshow + "\" + switchpath

        If Not specificarraylist Is Nothing Then
            specificarraylist.Add(dlobj)
        End If
        maincollection.currenttvshowdownloadlist.Add(dlobj)

        '        dlgDownloadingFile.downloadertxtFileName.Text = curmirror + "/banners/" + tmepisode.Filename
        '        dlgDownloadingFile.whereToSave = rconf.tvdbcachefolder + selectedshow + "\" + switchpath
        '       dlgDownloadingFile.nomultidownload = False
        '      dlgDownloadingFile.ShowDialog()
    End Sub

#End Region
End Class
Public Class completeshows
    Private p_element_tvshowname As String
    Private p_element_tvshowid As String
    Private p_element_path As String
    Private p_element_seasons As New List(Of seasons)
    Property showpath() As String
        Get
            Return p_element_path
        End Get
        Set(ByVal value As String)
            p_element_path = value
        End Set
    End Property
    Property tvshowname() As String
        Get
            Return p_element_tvshowname
        End Get
        Set(ByVal value As String)
            p_element_tvshowname = value
        End Set
    End Property

    Property tvshowid() As String
        Get
            Return p_element_tvshowid

        End Get
        Set(ByVal value As String)
            p_element_tvshowid = value
        End Set
    End Property

    Property seasons() As List(Of seasons)
        Get
            Return p_element_seasons
        End Get
        Set(ByVal value As List(Of seasons))
            p_element_seasons = value
        End Set
    End Property
End Class
Public Class seasons
    Private p_element_episodes As New List(Of tvdblangEpisode)
    Private p_element_seasonnumber As String
    Private p_element_seasonpath As String
    Private p_element_downloadlist As New ArrayList
    <XmlIgnore()> _
  Property pdownloadlist() As ArrayList
        Get
            Return p_element_downloadlist
        End Get
        Set(ByVal value As ArrayList)
            p_element_downloadlist = value
        End Set
    End Property
    <XmlIgnore()> _
    Property seasonpath() As String
        Get
            Return p_element_seasonpath
        End Get
        Set(ByVal value As String)
            p_element_seasonpath = value
        End Set
    End Property
    '<XmlIgnore()> _
    Property episodes() As List(Of tvdblangEpisode)
        Get
            Return p_element_episodes
        End Get
        Set(ByVal value As List(Of tvdblangEpisode))
            p_element_episodes = value
        End Set
    End Property
    Property seasonnumber() As String
        Get
            Return p_element_seasonnumber
        End Get
        Set(ByVal value As String)
            p_element_seasonnumber = value
        End Set
    End Property
End Class

