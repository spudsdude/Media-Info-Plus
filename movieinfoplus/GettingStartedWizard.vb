Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Windows.Forms

Public Class GettingStartedWizard

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim LicenseInfo As String
        LicenseInfo = "Media Info Plus (MIP) Copyright 2008/2009 MDI" '+ vbNewLine + _
        '"ImageMagick is embeded into MIP there license information follows" + vbNewLine + vbNewLine + _
        '"Licensed under the ImageMagick License (the " + """" + "License" + """" + "); you may not use" + vbNewLine + _
        '"this file except in compliance with the License.  You may obtain a copy" + vbNewLine + _
        '"of the License at" + vbNewLine + _
        '"http://www.imagemagick.org/script/license.php" + vbNewLine + _
        '"Unless required by applicable law or agreed to in writing, software" + vbNewLine + _
        '"distributed under the License is distributed on an " + """" + "AS IS" + """" + " BASIS, WITHOUT" + vbNewLine + _
        '"WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  See the" + vbNewLine + _
        '"License for the specific language governing permissions and limitations" + vbNewLine + _
        '"under the License."
        'register imagemagick com component
        'Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        'pro1.StartInfo.FileName = "regsvr32"
        'pro1.StartInfo.Arguments = "/c /s " & """" & getparentdirectory(Application.ExecutablePath) + "3rdparty\ImageMagick\ImageMagickObject.dll" & """"
        'pro1.Start()
        'pro1.WaitForExit()


        MessageBox.Show(LicenseInfo, "License Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        saveconfig()
        Dim getres As New resource_extractor
        If File.Exists(getparentdirectory(Application.ExecutablePath) + "noextrez.txt") Then
            getres.createresources(False)
        Else
            getres.createresources(True)
        End If
        'MsgBox("You ** MUST ** restart the application for the settings to take effect")
        Me.Close()
        'Me.Close()

    End Sub
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
    Private Sub saveconfig()
        Dim curConfig As New configuration
        curConfig.tv_tvshow_posters_download_boolean = True
        curConfig.tv_episode_create_fanart = True
        curConfig.tv_episode_download_boolean = True
        curConfig.tv_episode_overwrite_nfo = False
        curConfig.tv_episode_overwrite_tbn = False
        curConfig.tv_season_banners_download_boolean = True
        curConfig.tv_season_banners_download_maxnumber_integer = 8
        curConfig.tv_season_banners_download_type_string = "all"
        curConfig.tv_season_banners_toapply_string = "season"
        curConfig.tv_season_posters_download_boolean = True
        curConfig.tv_season_posters_download_maxnumber_integer = 8
        curConfig.tv_season_usewhich_banner_poster = "season"
        curConfig.tv_tvshow_fanart_display_boolean = True
        curConfig.tv_tvshow_fanart_download_boolean = True
        curConfig.tv_tvshow_fanart_download_maxnumber_integer = 8
        curConfig.tv_tvshow_fanart_download_size_string = "1920 x 1080"
        curConfig.tv_tvshow_fanart_toapply_whatsize_string = "1920 x 1080"
        curConfig.tv_tvshow_posters_download_maxnumber_integer = 8
        curConfig.tv_tvshow_nfo_overwrite_boolean = False
        curConfig.tv_tvshow_wideicon_download_boolean = True
        curConfig.tv_tvshow_wideicon_download_maxnumber_integer = 8
        curConfig.tv_usewgetforimages = True
        curConfig.tv_wgetsleepinmilliseconds = 100
        curConfig.tv_curlang = "en"
        curConfig.pcombolTVCheckForNewTVShowData = "5"

        curConfig.pcbGetIMDBInfo = True
        curConfig.pcbDownloadPoster = True
        curConfig.pcbGetTMDBPosters = True
        curConfig.pcbGetcaldnPosters = True
        curConfig.pcbUseFolderJpgforTBN = True


        curConfig.pcbGetFanart = True
        curConfig.pdisplayfanart = True

        curConfig.pcbGenTBN = True
        curConfig.pcbCreateFolderjpg = True
        curConfig.pcbcreatemovienamedottbn = True
        curConfig.pcbcreatemovietbn = True

        curConfig.pcbcreatefanartjpg = True
        curConfig.pcbcreatemovienamedashfanartjpg = True
        curConfig.pcbgetncposters = False
        curConfig.pcbautocreatefolderjpg = True
        curConfig.pcbautocreatemovietbn = True
        curConfig.pcbautocreatemovienametbn = True
        curConfig.pcbnopromptfornewposters = False
        curConfig.pcbscanformoviemediainformation = True
        curConfig.pcbcopyplotsummaryifnoplot = True

        curConfig.pcbSaveNFO = True
        curConfig.pcbCreateMovieNFO = True
        curConfig.pcbcreatemovienamedotnfo = True
        curConfig.pcbOverwriteNFO = False

        curConfig.pcbf1s0 = True
        curConfig.pcbf1s3 = True
        curConfig.pcbf1s9 = True
        curConfig.pcbf2s0 = True
        curConfig.pcbf2s2 = True
        curConfig.pcbf2s8 = True
        curConfig.pcbf2s10 = True
        curConfig.pcbf3s0 = True
        curConfig.pworkoffline = False
        curConfig.pcbMaxIconPerStyle = 8
        curConfig.pcbMaxIconsToDisplay = 8
        curConfig.pcbDlFormat = 2
        curConfig.overlayMargin = 0.01
        curConfig.overlayHeight = 0.12
        'get length of clbpaths, then get each item, then add to arraylist
        Dim len As Integer = clbPaths.Items.Count
        If len = 0 Then
            'nothing to process
        Else
            Dim count As Integer = 0
            While count < len
                curConfig.pclbPaths.Add(clbPaths.Items(count))
                count += 1
            End While

        End If

        Dim lentv As Integer = lbTVShows.Items.Count
        If lentv = 0 Then
            'nothing to process
        Else
            Dim count As Integer = 0
            While count < lentv
                curConfig.pclbTVPaths.Add(lbTVShows.Items(count))
                count += 1
            End While

        End If
        Dim lenmusic As Integer = lbMusic.Items.Count
        If lenmusic = 0 Then
            'nothing to process
        Else
            Dim count As Integer = 0
            While count < lenmusic
                curConfig.pclb_checked_music_folders.Add(lbTVShows.Items(count))
                count += 1
            End While

        End If

        curConfig.pcbFilter1080p = True
        curConfig.pcbFilter720p = True
        curConfig.pcbFilterAvi = True
        curConfig.pcbFilterBluRay = True
        curConfig.pcbFilterDivx = True
        curConfig.pcbFilterDVD = True
        curConfig.pcbFilterH264 = True
        curConfig.pcbFilterHidef = True
        curConfig.pcbFilterLq = True
        curConfig.pcbFilterXvid = True
        curConfig.pcbFilter1080i = True
        curConfig.pcbFilterYears = True
        'curConfig.pcb
        curConfig.saveConfig(curConfig)
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        ' Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnMoviesAddFolderByPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesAddFolderByPath.Click
        addtolist()

    End Sub

    Private Sub addtolist()
        'check the added path to make sure it's valid on the system
        'TODO add check
        Try

            If Directory.Exists(tbFolder.Text) Then
                'MsgBox("valid")
            Else
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub

            End If
            'create array of item in list
            Dim clbarray As New ArrayList

            For Each listedpath In clbPaths.Items
                clbarray.Add(listedpath)
            Next

            If clbarray.Contains(tbFolder.Text) Then
                MsgBox("Path already added to list")
                Exit Sub
            Else
                clbPaths.Items.Add(tbFolder.Text, True)
                OK_Button.Enabled = True
            End If

        Catch ex As Exception
            clbPaths.Items.Add(tbFolder.Text, True)
        End Try
    End Sub
    Private Sub addtomusiclist()
        'check the added path to make sure it's valid on the system
        'TODO add check
        Try

            If Directory.Exists(tbMusicPath.Text) Then
                'MsgBox("valid")
            Else
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub

            End If
            'create array of item in list
            Dim clbarray As New ArrayList

            For Each listedpath In lbMusic.Items
                clbarray.Add(listedpath)
            Next

            If clbarray.Contains(tbMusicPath.Text) Then
                MsgBox("Path already added to list")
                Exit Sub
            Else
                clbPaths.Items.Add(tbMusicPath.Text, True)
                OK_Button.Enabled = True
            End If

        Catch ex As Exception
            clbPaths.Items.Add(tbMusicPath.Text, True)
        End Try
    End Sub
    Private Sub addtotvlist()
        'check the added path to make sure it's valid on the system
        'TODO add check
        Try


            If Directory.Exists(tbTVPath.Text) Then
                'MsgBox("valid")
            Else
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub

            End If
            'create array of item in list
            Dim clbarray As New ArrayList

            For Each listedpath In lbTVShows.Items
                clbarray.Add(listedpath)
            Next

            If clbarray.Contains(tbTVPath.Text) Then
                MsgBox("Path already added to list")
                Exit Sub
            Else
                lbTVShows.Items.Add(tbTVPath.Text)
                OK_Button.Enabled = True
            End If
        Catch ex As Exception
            lbTVShows.Items.Add(tbTVPath.Text)
        End Try
    End Sub

    Private Sub tbFolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolder.TextChanged
        If Directory.Exists(tbFolder.Text) Then
            btnMoviesAddFolderByPath.Enabled = True
        Else
            btnMoviesAddFolderByPath.Enabled = False
        End If
    End Sub

    Private Sub tbtvfolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTVPath.TextChanged
        If Directory.Exists(tbTVPath.Text) Then
            btnTVAddPath.Enabled = True
        Else
            btnTVAddPath.Enabled = False
        End If
    End Sub
    Private Sub tbMusicPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMusicPath.TextChanged
        If Directory.Exists(tbMusicPath.Text) Then
            btnMusicAddPath.Enabled = True
        Else
            btnMusicAddPath.Enabled = False
        End If
    End Sub
    Private Sub btnMusicBrowseForFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        tbMusicPath.Text = FolderBrowserDialog1.SelectedPath
        addtomusiclist()
    End Sub
    Private Sub btnMoviesBrowseForFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesBrowseForFolder.Click
        FolderBrowserDialog1.ShowDialog()
        tbFolder.Text = FolderBrowserDialog1.SelectedPath
        addtolist()
    End Sub

    Private Sub btnMoviesClearFolderList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesClearFolderList.Click
        clbPaths.Items.Clear()
        Dim haveapath As Boolean = False
        'If clbPaths.Items.Count > 0 Then haveapath = True
        If lbTVShows.Items.Count > 0 Then haveapath = True
        If haveapath Then OK_Button.Enabled = True Else OK_Button.Enabled = False

    End Sub

    Private Sub btnTVAddPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVAddPath.Click
        addtotvlist()
    End Sub

    Private Sub btnTVBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        tbTVPath.Text = FolderBrowserDialog1.SelectedPath
        addtotvlist()
    End Sub

    Private Sub btnTVClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVClearList.Click
        lbTVShows.Items.Clear()
        Dim haveapath As Boolean = False
        If clbPaths.Items.Count > 0 Then haveapath = True
        'If lbTVShows.Items.Count > 0 Then haveapath = True
        If haveapath Then OK_Button.Enabled = True Else OK_Button.Enabled = False

    End Sub
    Private Sub btnMusicClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicClearList.Click
        lbMusic.Items.Clear()
        Dim haveapath As Boolean = False
        If clbPaths.Items.Count > 0 Then haveapath = True
        'If lbTVShows.Items.Count > 0 Then haveapath = True
        If haveapath Then OK_Button.Enabled = True Else OK_Button.Enabled = False

    End Sub
    Private Sub GettingStartedWizard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'saveconfig()
        'MsgBox("Basic Configuration File Created")
        'Dim getres As New resource_extractor
        'MsgBox("Attempting to extract resources")
        'getres.createresources(True)
        'MsgBox("Resources created")
        'Me.Close()
        'If Not Directory.Exists("c:\Program Files\movieinfoplus") Then Directory.CreateDirectory("c:\Program Files\movieinfoplus")
    End Sub
End Class

