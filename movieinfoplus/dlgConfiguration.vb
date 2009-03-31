Imports System.Windows.Forms
Imports System.IO

Public Class dlgConfiguration
    Dim rconf As New configuration
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#Region "-- setting changed handler--"
    Private Sub cbGoogleImageSearchPop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGoogleImageSearchPop.Click
        rconf.popgoogleimagesearch = cbGoogleImageSearchPop.Checked
    End Sub
    Private Sub cbAllowAutoMovienameRename_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAllowAutoMovienameRename.Click
        rconf.autorenamemoviefilenames = cbAllowAutoMovienameRename.Checked
    End Sub

    Private Sub cbDownloadPoster_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDownloadPoster.Click
        rconf.pcbDownloadPoster = cbDownloadPoster.Checked
    End Sub
    Private Sub cbGetFanart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGetFanart.Click
        rconf.pcbGetFanart = cbGetFanart.Checked
    End Sub
    Private Sub cbSaveNFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSaveNFO.Click
        rconf.pcbSaveNFO = cbSaveNFO.Checked
    End Sub
    Private Sub cbOverwriteNFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOverwriteNFO.Click
        rconf.pcbOverwriteNFO = cbOverwriteNFO.Checked
    End Sub

    Private Sub cbf1s0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf1s0.Click
        rconf.pcbf1s0 = cbf1s0.Checked
    End Sub
    Private Sub cbf1s3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf1s3.Click
        rconf.pcbf1s3 = cbf1s3.Checked
    End Sub
    Private Sub cbf1s9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf1s9.Click
        rconf.pcbf1s9 = cbf1s9.Checked
    End Sub
    Private Sub cbf3s0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf3s0.Click
        rconf.pcbf3s0 = cbf3s0.Checked
    End Sub
    Private Sub cbf2s0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf2s0.Click
        rconf.pcbf2s0 = cbf2s0.Checked
    End Sub
    Private Sub cbf2s2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf2s2.Click
        rconf.pcbf2s2 = cbf2s2.Checked
    End Sub
    Private Sub cbf2s8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf2s8.Click
        rconf.pcbf2s8 = cbf2s8.Checked
    End Sub
    Private Sub cbf2s10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbf2s10.Click
        rconf.pcbf2s10 = cbf2s10.Checked
    End Sub
    Private Sub cbShowFanart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowFanart.Click
        rconf.pdisplayfanart = cbShowFanart.Checked
    End Sub
    Private Sub cbDlFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDlFormat.SelectedValueChanged
        rconf.pcbDlFormat = cbDlFormat.SelectedIndex
    End Sub
    Private Sub cbMaxIconPerStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMaxIconPerStyle.SelectedValueChanged
        rconf.pcbMaxIconPerStyle = cbMaxIconPerStyle.SelectedIndex
    End Sub
    Private Sub cbFilterDivx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterDivx.Click
        rconf.pcbFilterDivx = cbFilterDivx.Checked
    End Sub
    Private Sub cbFilterXvid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterXvid.Click
        rconf.pcbFilterXvid = cbFilterXvid.Checked
    End Sub
    Private Sub cbFilterAvi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterAvi.Click
        rconf.pcbFilterAvi = cbFilterAvi.Checked
    End Sub
    Private Sub cbFilterDVD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterDVD.Click
        rconf.pcbFilterDVD = cbFilterDVD.Checked
    End Sub
    Private Sub cbFilterBluRay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterBluRay.Click
        rconf.pcbFilterBluRay = cbFilterBluRay.Checked
    End Sub
    Private Sub cbFilter720p_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilter720p.Click
        rconf.pcbFilter720p = cbFilter720p.Checked
    End Sub
    Private Sub cbFilter1080p_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilter1080p.Click
        rconf.pcbFilter1080p = cbFilter1080p.Checked
    End Sub
    Private Sub cbFilterHidef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterHidef.Click
        rconf.pcbFilterHidef = cbFilterHidef.Checked
    End Sub
    Private Sub cbFilterLq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterLq.Click
        rconf.pcbFilterLq = cbFilterLq.Checked
    End Sub
    Private Sub cbFilterH264_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterH264.Click
        rconf.pcbFilterH264 = cbFilterH264.Checked
    End Sub
    Private Sub tbCustomFilter1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomFilter1.TextChanged
        rconf.pcbFilterCustom1 = tbCustomFilter1.Text
    End Sub
    Private Sub tbCustomFilter2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomFilter2.TextChanged
        rconf.pcbFilterCustom2 = tbCustomFilter2.Text
    End Sub
    Private Sub tbCustomFilter3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomFilter3.TextChanged
        rconf.pcbFilterCustom3 = tbCustomFilter3.Text
    End Sub
    Private Sub tbCustomFilter4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomFilter4.TextChanged
        rconf.pcbFilterCustom4 = tbCustomFilter4.Text
    End Sub
    Private Sub tbCustomFilter5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomFilter5.TextChanged
        rconf.pcbFilterCustom5 = tbCustomFilter5.Text
    End Sub
    Private Sub cbFilterCustom1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterCustom2.Click
        rconf.pcbFilterCustom1_enabled = cbFilterCustom1.Checked
    End Sub
    Private Sub cbFilterCustom2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterCustom3.Click
        rconf.pcbFilterCustom2_enabled = cbFilterCustom2.Checked
    End Sub
    Private Sub cbFilterCustom3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterCustom3.Click
        rconf.pcbFilterCustom3_enabled = cbFilterCustom3.Checked
    End Sub
    Private Sub cbFilterCustom4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterCustom4.Click
        rconf.pcbFilterCustom4_enabled = cbFilterCustom4.Checked
    End Sub
    Private Sub cbFilterCustom5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterCustom5.Click
        rconf.pcbFilterCustom5_enabled = cbFilterCustom5.Checked
    End Sub

    Private Sub cbFilter1080i_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilter1080i.Click
        rconf.pcbFilter1080i = cbFilter1080i.Checked
    End Sub

    Private Sub cbFilterYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterYears.Click
        rconf.pcbFilterYears = cbFilterYears.Checked
    End Sub

    Private Sub cbgettmdbposters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGetTMDBPosters.Click
        rconf.pcbGetTMDBPosters = cbGetTMDBPosters.Checked
    End Sub
    Private Sub cbcreatmovienfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateMovieNFO.Click
        rconf.pcbCreateMovieNFO = cbCreateMovieNFO.Checked

    End Sub
    Private Sub krbColorBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorBlack.Click
        maincollection.setguicolor("black")
    End Sub
    Public Sub setguicolor(ByRef vcolor As String)
        Select Case vcolor
            Case "black"
                maincollection.kManager.GlobalPalette = maincollection.kpalette
                rconf.guicolor = "black"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "bubbles"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteBubbles
                rconf.guicolor = "bubbles"
                maincollection.tcMain.SelectedTabColor = Color.RoyalBlue
                maincollection.tcMain.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.TabColor = Color.SteelBlue
                maincollection.tcMain.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.HotColor = Color.Orange
                maincollection.tcPIB.SelectedTabColor = Color.RoyalBlue
                maincollection.tcPIB.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.TabColor = Color.SteelBlue
                maincollection.tcPIB.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.HotColor = Color.Orange
                maincollection.tcFCDN.SelectedTabColor = Color.RoyalBlue
                maincollection.tcFCDN.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.TabColor = Color.SteelBlue
                maincollection.tcFCDN.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.HotColor = Color.Orange
            Case "silver"
                maincollection.kManager.GlobalPalette = maincollection.kpaletteSilver
                rconf.guicolor = "silver"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "bling"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteBling
                rconf.guicolor = "bling"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "blinglarge"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteBlingLarge
                rconf.guicolor = "blinglarge"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "blue"
                maincollection.kManager.GlobalPalette = maincollection.kpaletteBlue
                rconf.guicolor = "blue"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "pink"
                maincollection.kManager.GlobalPalette = maincollection.kPalettePink
                rconf.guicolor = "pink"
                maincollection.tcMain.SelectedTabColor = Color.RoyalBlue
                maincollection.tcMain.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.TabColor = Color.SteelBlue
                maincollection.tcMain.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.HotColor = Color.Orange
                maincollection.tcPIB.SelectedTabColor = Color.RoyalBlue
                maincollection.tcPIB.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.TabColor = Color.SteelBlue
                maincollection.tcPIB.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.HotColor = Color.Orange
                maincollection.tcFCDN.SelectedTabColor = Color.RoyalBlue
                maincollection.tcFCDN.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.TabColor = Color.SteelBlue
                maincollection.tcFCDN.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.HotColor = Color.Orange
            Case "fire"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteBlueSkulls
                rconf.guicolor = "fire"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "skybluelarge"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteSkyBlueLarge
                rconf.guicolor = "skybluelarge"
                maincollection.tcMain.SelectedTabColor = Color.RoyalBlue
                maincollection.tcMain.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.TabColor = Color.SteelBlue
                maincollection.tcMain.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcMain.HotColor = Color.Orange
                maincollection.tcPIB.SelectedTabColor = Color.RoyalBlue
                maincollection.tcPIB.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.TabColor = Color.SteelBlue
                maincollection.tcPIB.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcPIB.HotColor = Color.Orange
                maincollection.tcFCDN.SelectedTabColor = Color.RoyalBlue
                maincollection.tcFCDN.BackColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.TabColor = Color.SteelBlue
                maincollection.tcFCDN.ForeColor = Color.FromArgb(223, 233, 245)
                maincollection.tcFCDN.HotColor = Color.Orange
            Case "green"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteGreen
                rconf.guicolor = "green"
                maincollection.tcMain.SelectedTabColor = Color.SeaGreen
                maincollection.tcMain.BackColor = Color.LightSeaGreen
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case "pro"
                maincollection.kManager.GlobalPalette = maincollection.kPaletteSystem
                rconf.guicolor = "pro"
                maincollection.tcMain.SelectedTabColor = Color.Gray
                maincollection.tcMain.BackColor = Color.Black
                maincollection.tcMain.TabColor = Color.Black
                maincollection.tcMain.ForeColor = Color.White
                maincollection.tcMain.HotColor = Color.Silver
                maincollection.tcPIB.SelectedTabColor = Color.Gray
                maincollection.tcPIB.BackColor = Color.Black
                maincollection.tcPIB.TabColor = Color.Black
                maincollection.tcPIB.ForeColor = Color.White
                maincollection.tcPIB.HotColor = Color.Silver
                maincollection.tcFCDN.SelectedTabColor = Color.Gray
                maincollection.tcFCDN.BackColor = Color.Black
                maincollection.tcFCDN.TabColor = Color.Black
                maincollection.tcFCDN.ForeColor = Color.White
                maincollection.tcFCDN.HotColor = Color.Silver
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub cbGetIMDBInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGetIMDBInfo.Click
        'If cbGetIMDBInfo.Checked = True Then
        '    cbDownloadPoster.Enabled = True
        'Else
        '    cbDownloadPoster.Enabled = False
        'End If
        rconf.pcbGetIMDBInfo = cbGetIMDBInfo.Checked
    End Sub
    Private Sub cboxType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDlFormat.SelectedValueChanged
        Select Case cbDlFormat.SelectedIndex
            Case 0
                maincollection.dltype = "med"
            Case 1
                maincollection.dltype = "large"
            Case 2
                maincollection.dltype = "download"
            Case Else
                maincollection.dltype = "download"
        End Select
        rconf.dltype = maincollection.dltype
    End Sub
    Private Sub cbMaxIconsToDisplay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMaxIconsToDisplay.SelectedValueChanged
        rconf.pcbMaxIconsToDisplay = cbMaxIconsToDisplay.SelectedIndex
    End Sub
    Private Sub cbshowwgetwindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rconf.tv_showwgetwindows = cbtv_showwgetwindows.Checked
    End Sub
    Private Sub krbColorBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorBlue.Click
        setguicolor("blue")
    End Sub
    Private Sub krbColorSilver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorSilver.Click
        setguicolor("silver")
    End Sub
    Private Sub krbColorFire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorFire.Click
        setguicolor("fire")
    End Sub
    Private Sub krbColorHazel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorBling.Click
        setguicolor("bling")
    End Sub
    Private Sub krbColorBubbles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorBubbles.Click
        setguicolor("bubbles")
    End Sub
    Private Sub cbNoNfoChangePrompt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNoNfoChangePrompt.Click
        rconf.pcbNoNfoChangePrompt = cbNoNfoChangePrompt.Checked
    End Sub


    Private Sub cbShowTBN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowTBN.Click
        rconf.pcbshowtbn = cbShowTBN.Checked
    End Sub

    Private Sub cbCreateFanartjpgfile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateFanartjpgfile.Click
        rconf.pcbcreatefanartjpg = cbCreateFanartjpgfile.Checked
    End Sub

    Private Sub cbCreateMovieTbnFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateMovieTbnFile.Click
        rconf.pcbcreatemovietbn = cbCreateMovieTbnFile.Checked
    End Sub

    Private Sub knudPosterHeightfolderjpg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles knudPosterHeightfolderjpg.ValueChanged
        If knudPosterHeightfolderjpg.Value > 0 Then rconf.pknudPosterHeightfolderjpg = knudPosterHeightfolderjpg.Value

    End Sub

    Private Sub knudPosterHeightTBN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles knudPosterHeightTBN.ValueChanged
        If knudPosterHeightTBN.Value > 0 Then rconf.pknudPosterHeightTBN = knudPosterHeightTBN.Value
    End Sub

    Private Sub cbUsefolderjpgfortbn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUsefolderjpgfortbn.Click
        rconf.pcbUseFolderJpgforTBN = cbUsefolderjpgfortbn.Checked
    End Sub


    Private Sub tvgs_cb_tvshow_fanart_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_tvshow_fanart_download.Click
        rconf.tv_tvshow_fanart_download_boolean = tvgs_cb_tvshow_fanart_download.Checked
    End Sub


    Private Sub tvgs_knud_tvshow_fanart_download_maxnumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_knud_tvshow_fanart_download_maxnumber.ValueChanged
        rconf.tv_tvshow_fanart_download_maxnumber_integer = CInt(tvgs_knud_tvshow_fanart_download_maxnumber.Value)
    End Sub


    Private Sub tvgs_combobox_tvshow_fanart_download_size_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_combobox_tvshow_fanart_download_size.SelectedValueChanged
        rconf.tv_tvshow_fanart_download_size_string = tvgs_combobox_tvshow_fanart_download_size.SelectedItem.ToString
    End Sub


    Private Sub tvgs_combobox_tvshow_fanart_toapply_whatsize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_combobox_tvshow_fanart_toapply_whatsize.SelectedValueChanged
        rconf.tv_tvshow_fanart_toapply_whatsize_string = tvgs_combobox_tvshow_fanart_toapply_whatsize.SelectedItem.ToString
    End Sub


    Private Sub tvgs_cb_tvshow_fanart_display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_tvshow_fanart_display.Click
        rconf.tv_tvshow_fanart_display_boolean = tvgs_cb_tvshow_fanart_display.Checked
    End Sub

    Private Sub tvgs_cb_tvshow_nfo_overwrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_tvshow_nfo_overwrite.Click
        rconf.tv_tvshow_nfo_overwrite_boolean = tvgs_cb_tvshow_nfo_overwrite.Checked
    End Sub


    Private Sub tvgs_cb_tvshow_posters_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_tvshow_posters_download.Click
        rconf.tv_tvshow_posters_download_boolean = tvgs_cb_tvshow_posters_download.Checked
    End Sub

    Private Sub tvgs_knud_tvshow_posters_download_maxnumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_knud_tvshow_posters_download_maxnumber.ValueChanged
        rconf.tv_tvshow_posters_download_maxnumber_integer = CInt(tvgs_knud_tvshow_posters_download_maxnumber.Value)
    End Sub


    Private Sub tvgs_knud_tvshow_wideicon_download_maxnumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_knud_tvshow_wideicon_download_maxnumber.ValueChanged
        rconf.tv_tvshow_wideicon_download_maxnumber_integer = CInt(tvgs_knud_tvshow_wideicon_download_maxnumber.Value)
    End Sub

    Private Sub tvgs_cb_tvshow_wideicon_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_tvshow_wideicon_download.Click
        rconf.tv_tvshow_wideicon_download_boolean = tvgs_cb_tvshow_wideicon_download.Checked
    End Sub


    Private Sub tvgs_cb_season_banners_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_season_banners_download.Click
        rconf.tv_season_banners_download_boolean = tvgs_cb_season_banners_download.Checked
    End Sub
    Private Sub tvgs_cb_season_posters_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_season_posters_download.Click
        rconf.tv_season_posters_download_boolean = tvgs_cb_season_posters_download.Checked
    End Sub

    Private Sub tvgs_knud_season_banners_download_maxnumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_knud_season_banners_download_maxnumber.ValueChanged
        rconf.tv_season_banners_download_maxnumber_integer = CInt(tvgs_knud_season_banners_download_maxnumber.Value)
    End Sub


    Private Sub tvgs_knud_season_posters_download_maxnumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_knud_season_posters_download_maxnumber.ValueChanged
        rconf.tv_season_posters_download_maxnumber_integer = CInt(tvgs_knud_season_posters_download_maxnumber.Value)
    End Sub

    Private Sub tvgs_cb_episode_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_cb_episode_download.Click
        rconf.tv_episode_download_boolean = tvgs_cb_episode_download.Checked
    End Sub
    Private Sub tvgs_episode_overwrite_nfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_episode_overwrite_nfo.Click
        rconf.tv_episode_overwrite_nfo = tvgs_episode_overwrite_nfo.Checked
    End Sub

    'Private Sub tvgs_combobox_season_banners_download_type_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_combobox_season_banners_download_type.SelectedValueChanged
    '    rconf.tv_season_banners_download_type_string = tvgs_combobox_season_banners_download_type.SelectedValue.ToString
    'End Sub


    Private Sub krbTVSeasonUsePoster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbTVSeasonUsePoster.Click
        If krbTVSeasonUsePoster.Checked Then
            rconf.tv_season_usewhich_banner_poster = "season"
        Else
            rconf.tv_season_usewhich_banner_poster = "seasonwide"
        End If
    End Sub
    Private Sub krbTVSeasonUseWide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbTVSeasonUseWide.Click
        If krbTVSeasonUseWide.Checked Then
            rconf.tv_season_usewhich_banner_poster = "seasonwide"
        Else
            rconf.tv_season_usewhich_banner_poster = "season"
        End If
    End Sub
    Private Sub cbIgnoreparans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIgnoreparans.Click
        rconf.pcbIgnoreparans = cbIgnoreparans.Checked

    End Sub
    Private Sub clbFolders_MouseRightClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clbPaths.MouseDown
        If e.Button = MouseButtons.Right Then
            If Not clbPaths.SelectedIndex = -1 Then
                If MsgBox("Folder Removal Confirmation: Are you sure you want to remove the following folder?" + vbNewLine + vbNewLine + clbPaths.SelectedItem.ToString, MsgBoxStyle.YesNo, "Confirm Removal of Movie folder") = MsgBoxResult.No Then
                    Exit Sub
                End If
                clbPaths.Items.RemoveAt(clbPaths.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub clbPathsMusic_MouseRightClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clbPathsMusic.MouseDown
        If e.Button = MouseButtons.Right Then
            If Not clbPaths.SelectedIndex = -1 Then
                If MsgBox("Folder Removal Confirmation: Are you sure you want to remove the following folder?" + vbNewLine + vbNewLine + clbPaths.SelectedItem.ToString, MsgBoxStyle.YesNo, "Confirm Removal of Movie folder") = MsgBoxResult.No Then
                    Exit Sub
                End If
                clbPaths.Items.RemoveAt(clbPathsMusic.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub lbTVShows_MouseRightClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbTVShows.MouseDown
        If e.Button = MouseButtons.Right Then
            If Not lbTVShows.SelectedIndex = -1 Then
                If MsgBox("Folder Removal Confirmation: Are you sure you want to remove the following folder?" + vbNewLine + vbNewLine + lbTVShows.SelectedItem.ToString, MsgBoxStyle.YesNo, "Confirm Removal of Tv Show folder") = MsgBoxResult.No Then
                    Exit Sub
                End If
                lbTVShows.Items.RemoveAt(lbTVShows.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub tvgs_combobox_season_banners_download_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_combobox_season_banners_download_type.SelectedIndexChanged
        rconf.tv_season_banners_download_type_string = tvgs_combobox_season_banners_download_type.SelectedItem.ToString
    End Sub
    Private Sub cbtv_lang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtv_lang.SelectedIndexChanged
        rconf.tv_curlang = cbtv_lang.SelectedItem.ToString
    End Sub

    Private Sub tvgs_episode_overwrite_tbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvgs_episode_overwrite_tbn.Click
        rconf.tv_episode_overwrite_tbn = tvgs_episode_overwrite_tbn.Checked
    End Sub
    Private Sub cbgetncposters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbgetncposters.Click
        rconf.pcbgetncposters = cbgetncposters.Checked
    End Sub

    Private Sub cbautocreatefolderjpg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbautocreatefolderjpg.Click
        rconf.pcbautocreatefolderjpg = cbautocreatefolderjpg.Checked
    End Sub

    Private Sub cbautocreatemovietbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbautocreatemovietbn.Click
        rconf.pcbautocreatemovietbn = cbautocreatemovietbn.Checked
    End Sub

    Private Sub cbautocreatemovienametbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbautocreatemovienametbn.Click
        rconf.pcbautocreatemovienametbn = cbautocreatemovienametbn.Checked
    End Sub

    Private Sub cbnopromptfornewposters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbnopromptfornewposters.Click
        rconf.pcbnopromptfornewposters = cbnopromptfornewposters.Checked
    End Sub

    Private Sub cbscanformoviemediainformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbscanformoviemediainformation.Click
        rconf.pcbscanformoviemediainformation = cbscanformoviemediainformation.Checked
    End Sub

    Private Sub cbcopyplotsummaryifnoplot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcopyplotsummaryifnoplot.Click
        rconf.pcbcopyplotsummaryifnoplot = cbcopyplotsummaryifnoplot.Checked
    End Sub
    Private Sub cbCreateMovieNameFanartjpg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateMovieNameFanartjpg.Click
        rconf.pcbcreatemovienamedashfanartjpg = cbCreateMovieNameFanartjpg.Checked
    End Sub

    Private Sub cbcreatemovienamedotnfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcreatemovienamedotnfo.Click
        rconf.pcbcreatemovienamedotnfo = cbcreatemovienamedotnfo.Checked
    End Sub


    Private Sub cbCreateFolderjpg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateFolderjpg.Click
        rconf.pcbCreateFolderjpg = cbCreateFolderjpg.Checked
    End Sub

    Private Sub cbcreatemovienamedottbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcreatemovienamedottbn.Click
        rconf.pcbcreatemovienamedottbn = cbcreatemovienamedottbn.Checked
    End Sub
    Private Sub btnTVAddPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVAddPath.Click
        lbTVShows.Items.Add(tbTVPath.Text, True)

    End Sub


#End Region
    Private Sub setactiveconf(ByRef trconf As configuration)
        'Me.cbformat.SelectedIndex = runconfig.
        'gformat = runconfig.
        Try
            '## Folder locations/paths
            'folder level movies
            clbPaths.Items.Clear()
            For Each listedpath In trconf.pclbPaths
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPaths.Items.Add(listedpath.ToString, True)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next

            For Each listedpath In trconf.pclbPathsUnchecked
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPaths.Items.Add(listedpath.ToString, False)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next

            'file level movies
            clbPathsFileMode.Items.Clear()
            For Each listedpath In trconf.pclbPathsFileMode
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPathsFileMode.Items.Add(listedpath.ToString, True)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next
            For Each listedpath In trconf.pclbPathsFileModeUnchecked
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPathsFileMode.Items.Add(listedpath.ToString, False)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next
            'music
            clbPathsMusic.Items.Clear()
            For Each listedpath In trconf.pclb_checked_music_folders
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPathsMusic.Items.Add(listedpath.ToString, True)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next
            For Each listedpath In trconf.pclb_music_folders
                If Directory.Exists(listedpath.ToString) Then
                    'MsgBox("valid")
                    clbPathsMusic.Items.Add(listedpath.ToString, False)
                Else
                    MsgBox("not adding " + listedpath.ToString + " to drop down, the location is not available")
                End If
            Next
            'tv shows
            lbTVShows.Items.Clear()
            Dim httemp As New Hashtable

            For Each listedpathtv In trconf.pclbTVPaths
                If Directory.Exists(listedpathtv.ToString) Then
                    'crude hashtable workaround to prevent xml hacked multiple shows
                    Try
                        httemp.Add(listedpathtv.ToString, listedpathtv.ToString)
                        lbTVShows.Items.Add(listedpathtv.ToString, True)
                        'rconf.pclbTVPaths.Add(listedpathtv.ToString)
                    Catch ex As Exception

                    End Try
                Else
                    MsgBox("not adding " + listedpathtv.ToString + " to drop down, the location is not available")
                End If
            Next
            For Each listedpathtv In trconf.pclbTVPathsUnchecked
                If Directory.Exists(listedpathtv.ToString) Then
                    'crude hashtable workaround to prevent xml hacked multiple shows
                    Try
                        httemp.Add(listedpathtv.ToString, listedpathtv.ToString)
                        lbTVShows.Items.Add(listedpathtv.ToString, False)
                        'rconf.pclbTVPaths.Add(listedpathtv.ToString)
                    Catch ex As Exception

                    End Try
                Else
                    MsgBox("not adding " + listedpathtv.ToString + " to drop down, the location is not available")
                End If
            Next


            '## Download Settigns
            cbMaxIconsToDisplay.SelectedIndex = trconf.pcbMaxIconsToDisplay
            cbMaxIconPerStyle.SelectedIndex = trconf.pcbMaxIconPerStyle
            cbDlFormat.SelectedIndex = trconf.pcbDlFormat
            cbf1s0.Checked = trconf.pcbf1s0
            cbf1s3.Checked = trconf.pcbf1s3
            cbf1s9.Checked = trconf.pcbf1s9
            cbf2s0.Checked = trconf.pcbf2s0
            cbf2s2.Checked = trconf.pcbf2s2
            cbf2s8.Checked = trconf.pcbf2s8
            cbf2s10.Checked = trconf.pcbf2s10
            cbf3s0.Checked = trconf.pcbf3s0
            cbDownloadPoster.Checked = trconf.pcbDownloadPoster
            cbGetcaldnPosters.Checked = trconf.pcbGetcaldnPosters
            cbGetTMDBPosters.Checked = trconf.pcbGetTMDBPosters
            cbGetIMDBInfo.Checked = trconf.pcbGetIMDBInfo
            cbGetFanart.Checked = trconf.pcbGetFanart
            cbIgnoreparans.Checked = trconf.pcbIgnoreparans
            cbFilterUnderscoreDot.Checked = trconf.pcbFilterUnderscoreDot
            cbtvlangoverridebanners.Checked = trconf.pcbtvlangoverride
            cbFilterNameFileModeEverythingBeforeYear.Checked = trconf.pcbFilterNameFileModeEverythingBeforeYear
            cbFilterNameFileModeEverythingBeforeh264.Checked = trconf.pcbFilterNameFileModeEverythingBeforeh264
            cbFilterNameFileModeEverythingBeforex264.Checked = trconf.pcbFilterNameFileModeEverythingBeforex264
            cbFilterNameFileModeEverythingBefore720p.Checked = trconf.pcbFilterNameFileModeEverythingBefore720p
            cbFilterNameFileModeEverythingBefore1080i.Checked = trconf.pcbFilterNameFileModeEverythingBefore1080i
            cbFilterNameFileModeEverythingBefore1080p.Checked = trconf.pcbFilterNameFileModeEverythingBefore1080p
            cbFilterNameFileModeEverythingBeforeDash.Checked = trconf.pcbFilterNameFileModeEverythingBeforeDash
            cbGetMusicFanartFromHTBackdrops.Checked = trconf.pcbGetMusicFanartFromHTBackdrops
            cbtv_lang.SelectedText = trconf.tv_curlang ' = cbtv_lang.SelectedItem.ToString
            cbMoviesCertificationLang.SelectedText = trconf.pcbMoviesCertificationLang
            cbGeneralSupportSkinBasedFlagging.Checked = rconf.pcbGeneralSupportSkinBasedFlagging
            'set download type, this is used when pulling icons from mediaicons site
            If trconf.pcbDlFormat = 0 Then
                maincollection.dltype = "med"
            End If

            If trconf.pcbDlFormat = 1 Then
                maincollection.dltype = "large"
            End If

            If trconf.pcbDlFormat = 2 Then
                maincollection.dltype = "download"
            End If


            '## Filters 
            If rconf.pcbFilterCustom1 = "" Then
            Else
                tbCustomFilter1.Text = trconf.pcbFilterCustom1
                cbFilterCustom1.Checked = trconf.pcbFilterCustom1_enabled
            End If
            If rconf.pcbFilterCustom2 = "" Then
            Else
                tbCustomFilter2.Text = trconf.pcbFilterCustom2
                cbFilterCustom2.Checked = trconf.pcbFilterCustom2_enabled
            End If
            If rconf.pcbFilterCustom3 = "" Then
            Else
                tbCustomFilter3.Text = trconf.pcbFilterCustom3
                cbFilterCustom3.Checked = trconf.pcbFilterCustom3_enabled
            End If
            If rconf.pcbFilterCustom4 = "" Then
            Else
                tbCustomFilter4.Text = rconf.pcbFilterCustom4
                cbFilterCustom4.Checked = trconf.pcbFilterCustom4_enabled
            End If
            If rconf.pcbFilterCustom5 = "" Then
            Else
                tbCustomFilter5.Text = trconf.pcbFilterCustom5
                cbFilterCustom5.Checked = trconf.pcbFilterCustom5_enabled
            End If
            cbFilter1080p.Checked = trconf.pcbFilter1080p
            cbFilter720p.Checked = trconf.pcbFilter720p
            cbFilterAvi.Checked = trconf.pcbFilterAvi
            cbFilterBluRay.Checked = trconf.pcbFilterBluRay
            cbFilter1080i.Checked = trconf.pcbFilter1080i
            cbFilterYears.Checked = trconf.pcbFilterYears
            cbFilterDivx.Checked = trconf.pcbFilterDivx
            cbFilterDVD.Checked = trconf.pcbFilterDVD
            cbFilterH264.Checked = trconf.pcbFilterH264
            cbFilterHidef.Checked = trconf.pcbFilterHidef
            cbFilterLq.Checked = trconf.pcbFilterLq
            cbFilterXvid.Checked = trconf.pcbFilterXvid
            cbIgnoreparans.Checked = trconf.pcbIgnoreparans 'anything in parans in foldername is ignored (.*?)

            '## Misc
            cbGoogleImageSearchPop.Checked = trconf.popgoogleimagesearch
            cbAllowAutoMovienameRename.Checked = trconf.autorenamemoviefilenames
            tbTvRegex1.Text = trconf.ptvregx1
            cbgetncposters.Checked = trconf.pcbgetncposters
            cbautocreatefolderjpg.Checked = trconf.pcbautocreatefolderjpg
            cbautocreatemovietbn.Checked = trconf.pcbautocreatemovietbn
            cbautocreatemovienametbn.Checked = trconf.pcbautocreatemovienametbn
            cbnopromptfornewposters.Checked = trconf.pcbnopromptfornewposters
            cbscanformoviemediainformation.Checked = trconf.pcbscanformoviemediainformation
            cbcopyplotsummaryifnoplot.Checked = trconf.pcbcopyplotsummaryifnoplot

            '## File settings
            cbSaveNFO.Checked = trconf.pcbSaveNFO
            cbCreateMovieNFO.Checked = trconf.pcbCreateMovieNFO
            cbcreatemovienamedotnfo.Checked = trconf.pcbcreatemovienamedotnfo
            cbOverwriteNFO.Checked = trconf.pcbOverwriteNFO

            cbCreateFolderjpg.Checked = trconf.pcbCreateFolderjpg

            cbcreatemovienamedottbn.Checked = trconf.pcbcreatemovienamedottbn
            cbCreateFanartjpgfile.Checked = trconf.pcbcreatefanartjpg
            cbCreateMovieTbnFile.Checked = trconf.pcbcreatemovietbn

            cbCreateMovieNameFanartjpg.Checked = trconf.pcbcreatemovienamedashfanartjpg
            cbUsefolderjpgfortbn.Checked = trconf.pcbUseFolderJpgforTBN

            '## Prompt Options
            cbNoNfoChangePrompt.Checked = trconf.pcbNoNfoChangePrompt

            '## TV Show Settings
            tvgs_cb_tvshow_posters_download.Checked = trconf.tv_tvshow_posters_download_boolean
            tvgs_cb_tvshow_fanart_download.Checked = trconf.tv_episode_create_fanart
            tvgs_cb_episode_download.Checked = trconf.tv_episode_download_boolean
            tvgs_episode_overwrite_nfo.Checked = trconf.tv_episode_overwrite_nfo
            tvgs_episode_overwrite_tbn.Checked = trconf.tv_episode_overwrite_tbn
            tvgs_cb_season_banners_download.Checked = trconf.tv_season_banners_download_boolean
            tvgs_knud_season_banners_download_maxnumber.Value = trconf.tv_season_banners_download_maxnumber_integer
            tvgs_combobox_season_banners_download_type.SelectedValue = trconf.tv_season_banners_download_type_string
            cbtv_lang.SelectedValue = trconf.tv_curlang
            cbMoviesCertificationLang.SelectedValue = trconf.pcbMoviesCertificationLang
            cbmovie_use_certification_for_mpaa.Checked = trconf.pcbmovie_use_certification_for_mpaa

            'tvgs_combobox_season_banners_download_type.SelectedValue = trconf.tv_season_banners_download_type_string' = "season"
            tvgs_cb_season_posters_download.Checked = trconf.tv_season_posters_download_boolean
            tvgs_knud_season_posters_download_maxnumber.Value = trconf.tv_season_posters_download_maxnumber_integer
            If trconf.pcombolTVCheckForNewTVShowData = Nothing Then
                combolTVCheckForNewTVShowData.SelectedIndex = 4
            Else
                combolTVCheckForNewTVShowData.SelectedIndex = CInt(trconf.pcombolTVCheckForNewTVShowData) - 1
            End If

            If trconf.tv_season_usewhich_banner_poster = "season" Then
                krbTVSeasonUsePoster.Checked = True
            Else
                krbTVSeasonUseWide.Checked = True
            End If
            tvgs_cb_tvshow_fanart_display.Checked = trconf.tv_tvshow_fanart_display_boolean
            tvgs_cb_tvshow_fanart_download.Checked = trconf.tv_tvshow_fanart_download_boolean
            tvgs_knud_tvshow_fanart_download_maxnumber.Value = trconf.tv_tvshow_fanart_download_maxnumber_integer
            tvgs_combobox_tvshow_fanart_download_size.SelectedValue = trconf.tv_tvshow_fanart_download_size_string
            tvgs_combobox_tvshow_fanart_toapply_whatsize.SelectedValue = trconf.tv_tvshow_fanart_toapply_whatsize_string
            tvgs_cb_tvshow_nfo_overwrite.Checked = trconf.tv_tvshow_nfo_overwrite_boolean
            tvgs_cb_tvshow_wideicon_download.Checked = trconf.tv_tvshow_wideicon_download_boolean
            tvgs_knud_tvshow_wideicon_download_maxnumber.Value = trconf.tv_tvshow_wideicon_download_maxnumber_integer

            cbshows_UseStudioasRating.Checked = trconf.pcbshows_UseStudioasRating
            '= trconf.tv_usewgetforimages = True
            '= trconf.tv_wgetsleepinmilliseconds = 100

            '## Display Options
            cbShowFanart.Checked = trconf.pdisplayfanart
            cbShowTBN.Checked = trconf.pcbshowtbn
            knudframeratio.Value = CDec(1.136)

            knudPosterHeightfolderjpg.Value = trconf.pknudPosterHeightfolderjpg
            If knudPosterHeightfolderjpg.Value = 0 Then knudPosterHeightfolderjpg.Value = 300

            knudPosterHeightTBN.Value = trconf.pknudPosterHeightTBN
            If knudPosterHeightTBN.Value = 0 Then knudPosterHeightTBN.Value = 300

            cbtv_showwgetwindows.checked = rconf.tv_showwgetwindows



            If Not rconf.pworkoffline Then maincollection.rbem.Checked = True

            If maincollection.rbem.Checked Then
                maincollection.rbread.Checked = False
            Else
                maincollection.rbread.Checked = True
            End If
            'clbPaths clear and set

            '## Media Images
            getMediaImagesMoviesFront.Checked = trconf.pgetMediaImagesMoviesFront
            getMediaImagesMoviesBack.Checked = trconf.pgetMediaImagesMoviesback
            getMediaImagesMoviesCD1.Checked = trconf.pgetMediaImagesMoviescd1
            getMediaImagesMoviesCD2.Checked = trconf.pgetMediaImagesMoviescd2
            getMediaImagesMoviesCD3.Checked = trconf.pgetMediaImagesMoviescd3
            getMediaImagesMoviesCD4.Checked = trconf.pgetMediaImagesMoviescd4
            getMediaImagesMoviesInlay.Checked = trconf.pgetMediaImagesMoviesinlay
            getMediaImagesMoviesInsert.Checked = trconf.pgetMediaImagesMoviesinsert

            getMediaImagesShowsFront.Checked = trconf.pgetMediaImagesShowsFront
            getMediaImagesShowsBack.Checked = trconf.pgetMediaImagesShowsback
            getMediaImagesShowsCD1.Checked = trconf.pgetMediaImagesShowscd1
            getMediaImagesShowsCD2.Checked = trconf.pgetMediaImagesShowscd2
            getMediaImagesShowsCD3.Checked = trconf.pgetMediaImagesShowscd3
            getMediaImagesShowsCD4.Checked = trconf.pgetMediaImagesShowscd4
            getMediaImagesShowsInlay.Checked = trconf.pgetMediaImagesShowsinlay
            getMediaImagesShowsInsert.Checked = trconf.pgetMediaImagesShowsinsert

            getMediaImagesMusicFront.Checked = trconf.pgetMediaImagesMusicFront
            getMediaImagesMusicBack.Checked = trconf.pgetMediaImagesMusicback
            getMediaImagesMusicCd1.Checked = trconf.pgetMediaImagesMusiccd1
            getMediaImagesMusicCd2.Checked = trconf.pgetMediaImagesMusiccd2
            getMediaImagesMusicCd3.Checked = trconf.pgetMediaImagesMusiccd3
            getMediaImagesMusicCd4.Checked = trconf.pgetMediaImagesMusiccd4
            getMediaImagesMusicInlay.Checked = trconf.pgetMediaImagesMusicinlay
            getMediaImagesMusicInsert.Checked = trconf.pgetMediaImagesMusicinsert

            '##Music
            cbMusicGetAlbumArt.Checked = trconf.pgetMusicAlbumArt
            cbMusicResizeMusicFanart.Checked = trconf.pcbmusicfanartresize
            '## Wine specific options for compatability
            ' rconf.winecompatable = False
            If trconf.winecompatable Then
                'disable the folder selection browse buttons
                btnMoviesBrowseForFolder.Enabled = False
                btnMoviesBrowseForFolderFileMode.Enabled = False
                btnTVBrowse.Enabled = False
                knudframeratio.Enabled = False
                knudPosterHeightfolderjpg.Enabled = False
                knudPosterHeightTBN.Enabled = False
                tvgs_knud_season_banners_download_maxnumber.Enabled = False
                tvgs_knud_season_posters_download_maxnumber.Enabled = False
                tvgs_knud_tvshow_fanart_download_maxnumber.Enabled = False
                tvgs_knud_tvshow_posters_download_maxnumber.Enabled = False
                tvgs_knud_tvshow_wideicon_download_maxnumber.Enabled = False
            End If

            'Select Case rconf.guicolor
            '    Case "black"
            '        kManager.GlobalPalette = kpalette
            '        krbColorBlack.Checked = True
            '        'rconf.guicolor = "black"
            '    Case "silver"
            '        kManager.GlobalPalette = kpaletteSilver
            '        krbColorSilver.Checked = True
            '        'rconf.guicolor = "silver"
            '    Case "hazel"
            '        kManager.GlobalPalette = kpaletteHazel
            '        krbColorHazel.Checked = True
            '        'rconf.guicolor = "hazel"
            '    Case "blue"
            '        kManager.GlobalPalette = kpaletteBlue
            '        krbColorBlue.Checked = True
            '        'rconf.guicolor = "blue"
            '    Case Else
            '        'do nothing
            'End Select
        Catch ex As Exception
        End Try

    End Sub
    'Private Sub saveconfigBku()
    '    Dim curConfig As New configuration
    '    If cbGetIMDBInfo.Checked Then curConfig.pcbGetIMDBInfo = True
    '    If cbDownloadPoster.Checked Then curConfig.pcbDownloadPoster = True
    '    If cbcreatemovienamedottbn.Checked Then curConfig.pcbGenTBN = True
    '    If cbGetFanart.Checked Then curConfig.pcbGetFanart = True
    '    If cbSaveNFO.Checked Then curConfig.pcbSaveNFO = True
    '    If cbOverwriteNFO.Checked Then curConfig.pcbOverwriteNFO = True
    '    If cbf1s0.Checked Then curConfig.pcbf1s0 = True
    '    If cbf1s3.Checked Then curConfig.pcbf1s3 = True
    '    If cbf1s9.Checked Then curConfig.pcbf1s9 = True
    '    If cbf2s0.Checked Then curConfig.pcbf2s0 = True
    '    If cbf2s2.Checked Then curConfig.pcbf2s2 = True
    '    If cbf2s8.Checked Then curConfig.pcbf2s8 = True
    '    If cbf2s10.Checked Then curConfig.pcbf2s10 = True
    '    If cbf3s0.Checked Then curConfig.pcbf3s0 = True
    '    If maincollection.rbread.Checked Then
    '        curConfig.pworkoffline = True
    '    Else
    '        curConfig.pworkoffline = False
    '    End If
    '    curConfig.pcbMaxIconPerStyle = cbMaxIconPerStyle.SelectedIndex
    '    curConfig.pcbMaxIconsToDisplay = cbMaxIconsToDisplay.SelectedIndex
    '    curConfig.pcbDlFormat = cbDlFormat.SelectedIndex

    '    'get length of clbpaths, then get each item, then add to arraylist
    '    Dim len As Integer = clbPaths.Items.Count
    '    If len = 0 Or len > 100 Then
    '        'nothing to process
    '    Else
    '        Dim count As Integer = 0
    '        While count < len
    '            curConfig.pclbPaths.Add(clbPaths.Items(count))
    '            count += 1
    '        End While

    '    End If
    '    'For Each item In CType(clbPaths, ArrayList)

    '    'curConfig.pclbPaths1 = CStr(clbPaths.Items(0))
    '    'curConfig.pclbPaths2 = CStr(clbPaths.Items(1))
    '    If cbFilter1080p.Checked Then curConfig.pcbFilter1080p = True
    '    If cbFilter720p.Checked Then curConfig.pcbFilter720p = True
    '    If cbFilterAvi.Checked Then curConfig.pcbFilterAvi = True
    '    If cbFilterBluRay.Checked Then curConfig.pcbFilterBluRay = True
    '    If cbFilterCustom1.Checked Then curConfig.pcbFilterCustom1 = tbCustomFilter1.Text
    '    If cbFilterCustom2.Checked Then curConfig.pcbFilterCustom2 = tbCustomFilter2.Text
    '    If cbFilterCustom3.Checked Then curConfig.pcbFilterCustom3 = tbCustomFilter3.Text
    '    If cbFilterCustom4.Checked Then curConfig.pcbFilterCustom4 = tbCustomFilter4.Text
    '    If cbFilterCustom5.Checked Then curConfig.pcbFilterCustom5 = tbCustomFilter5.Text
    '    If cbFilterDivx.Checked Then curConfig.pcbFilterDivx = True
    '    If cbFilterDVD.Checked Then curConfig.pcbFilterDVD = True
    '    If cbFilterH264.Checked Then curConfig.pcbFilterH264 = True
    '    If cbFilterHidef.Checked Then curConfig.pcbFilterHidef = True
    '    If cbFilterLq.Checked Then curConfig.pcbFilterLq = True
    '    If cbFilterXvid.Checked Then curConfig.pcbFilterXvid = True

    '    curConfig.saveConfigBku(curConfig)
    '    'save cblist for locations
    '    'save checked options
    '    'save movie? tv?
    'End Sub
    Public Sub saveconfig()
        Dim curConfig As New configuration
        curConfig = rconf

        curConfig.pcbDlFormat = cbDlFormat.SelectedIndex
        curConfig.ptvregx1 = tbTvRegex1.Text

        'folder level movies
        curConfig.pclbPaths.Clear()
        curConfig.pclbPathsUnchecked.Clear()
        'Dim selectedIndex As Integer = clbPaths.SelectedIndex
        If Not clbPaths.Items.Count = 0 Then
            For i As Integer = 0 To clbPaths.Items.Count - 1
                ' Get the selected item's check state.
                Dim chkstate As CheckState
                chkstate = clbPaths.GetItemCheckState(i)
                ' Toggle the item state.
                If (chkstate = CheckState.Checked) Then
                    curConfig.pclbPaths.Add(clbPaths.Items(i))
                Else
                    curConfig.pclbPathsUnchecked.Add(clbPaths.Items(i))
                End If
            Next
        End If


        'filemode movies list
        curConfig.pclbPathsFileMode.Clear()
        curConfig.pclbPathsFileModeUnchecked.Clear()
        'Dim siFileModeMovies As Integer = clbPathsFileMode.SelectedIndex
        If Not clbPathsFileMode.Items.Count = 0 Then
            For i As Integer = 0 To clbPathsFileMode.Items.Count - 1
                ' Get the selected item's check state.
                Dim chkstate As CheckState
                chkstate = clbPathsFileMode.GetItemCheckState(i)
                ' Toggle the item state.
                If (chkstate = CheckState.Checked) Then
                    curConfig.pclbPathsFileMode.Add(clbPathsFileMode.Items(i))
                Else
                    curConfig.pclbPathsFileModeUnchecked.Add(clbPathsFileMode.Items(i))
                End If
            Next
        End If

        'music paths
        curConfig.pclb_checked_music_folders.Clear()
        curConfig.pclb_music_folders.Clear()
        'Dim siMusic As Integer = clbPathsMusic.SelectedIndex
        If Not clbPathsMusic.Items.Count = 0 Then
            For i As Integer = 0 To clbPathsMusic.Items.Count - 1
                ' Get the selected item's check state.
                Dim chkstate As CheckState
                chkstate = clbPathsMusic.GetItemCheckState(i)
                ' Toggle the item state.
                If (chkstate = CheckState.Checked) Then
                    curConfig.pclb_checked_music_folders.Add(clbPathsMusic.Items(i))
                Else
                    curConfig.pclb_music_folders.Add(clbPathsMusic.Items(i))
                End If
            Next
        End If

        'tv shows paths
        curConfig.pclbTVPaths.Clear()
        curConfig.pclbTVPathsUnchecked.Clear()
        'Dim siTV As Integer = lbTVShows.SelectedIndex
        If Not lbTVShows.Items.Count = 0 Then
            For i As Integer = 0 To lbTVShows.Items.Count - 1
                ' Get the selected item's check state.
                Dim chkstate As CheckState
                chkstate = lbTVShows.GetItemCheckState(i)
                ' Toggle the item state.
                If (chkstate = CheckState.Checked) Then
                    curConfig.pclbTVPaths.Add(lbTVShows.Items(i))
                Else
                    curConfig.pclbTVPathsUnchecked.Add(lbTVShows.Items(i))
                End If
            Next
        End If


        If cbFilterCustom1.Checked Then curConfig.pcbFilterCustom1_enabled = True ' = tbCustomFilter1.Text
        If cbFilterCustom2.Checked Then curConfig.pcbFilterCustom2_enabled = True ' = tbCustomFilter2.Text
        If cbFilterCustom3.Checked Then curConfig.pcbFilterCustom3_enabled = True ' = tbCustomFilter3.Text
        If cbFilterCustom4.Checked Then curConfig.pcbFilterCustom4_enabled = True ' = tbCustomFilter4.Text
        If cbFilterCustom5.Checked Then curConfig.pcbFilterCustom5_enabled = True ' = tbCustomFilter5.Text
        curConfig.pcombolTVCheckForNewTVShowData = combolTVCheckForNewTVShowData.SelectedItem.ToString
        curConfig.saveConfig(curConfig)
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

            End If
        Catch ex As Exception
            clbPaths.Items.Add(tbFolder.Text, True)
        End Try
        ''see if it exsists, if not add it to drop down
        'Try
        '    For Each value In clbarray
        '        If value = clbPaths.Items.Add(tbFolder.Text) Then
        '            Exit Sub
        '            MsgBox("already there")
        '        End If

        '    Next
        '    clbPaths.Items.Add(tbFolder.Text)
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub addtolistFileMode()
        'check the added path to make sure it's valid on the system
        'TODO add check
        Try


            If Directory.Exists(tbFolderFileMode.Text) Then
                'MsgBox("valid")
            Else
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub

            End If
            'create array of item in list
            Dim clbarrayFileMode As New ArrayList

            For Each listedpath In clbPathsFileMode.Items
                clbarrayFileMode.Add(listedpath)
            Next

            If clbarrayFileMode.Contains(tbFolderFileMode.Text) Then
                MsgBox("Path already added to list")
                Exit Sub
            Else
                clbPathsFileMode.Items.Add(tbFolderFileMode.Text, True)

            End If
        Catch ex As Exception
            clbPathsFileMode.Items.Add(tbFolderFileMode.Text, True)
        End Try
        ''see if it exsists, if not add it to drop down
        'Try
        '    For Each value In clbarray
        '        If value = clbPaths.Items.Add(tbFolder.Text) Then
        '            Exit Sub
        '            MsgBox("already there")
        '        End If

        '    Next
        '    clbPaths.Items.Add(tbFolder.Text)
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub addtvshowtolist()
        Try
            If Not Directory.Exists(tbTVPath.Text) Then
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub
            End If
            'create array of item in list
            Dim clbarray2 As New ArrayList
            For Each listedpath In lbTVShows.Items
                clbarray2.Add(listedpath)
            Next
            If clbarray2.Contains(tbFolder.Text) Then
                MsgBox("Path already added to list")
                Exit Sub
            Else
                lbTVShows.Items.Add(tbTVPath.Text, True)
            End If
        Catch ex As Exception
            lbTVShows.Items.Add(tbTVPath.Text, True)
        End Try
    End Sub
    Private Sub addmusictolist()
        Try
            If Not Directory.Exists(tbFolderMusic.Text) Then
                MsgBox("No such directory on system, check the path you entered in the box above")
                Exit Sub
            End If
            'create array of item in list
            Dim clbarray2 As New ArrayList
            For Each listedpath In clbPathsMusic.Items
                clbarray2.Add(listedpath)
            Next
            If clbarray2.Contains(tbFolderMusic.Text) Then
                MsgBox("Path is already in the list")
                Exit Sub
            Else
                clbPathsMusic.Items.Add(tbFolderMusic.Text, True)
            End If
        Catch ex As Exception
            clbPathsMusic.Items.Add(tbFolderMusic.Text, True)
        End Try
    End Sub
    Private Sub btnAddtoclb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesAddFolderByPath.Click
        addtolist()
    End Sub
    Private Sub btnRemclb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesClearFolderList.Click
        clbPaths.Items.Clear()
    End Sub
    Private Sub btnAddtoclbFileMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesAddFolderByPathFileMode.Click
        addtolistFileMode()
    End Sub
    Private Sub btnRemclbFileMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesClearFolderListFileMode.Click
        clbPathsFileMode.Items.Clear()
    End Sub
    Private Sub btnMusicClearFolderList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicClearFolderList.Click
        clbPathsMusic.Items.Clear()
    End Sub
    Private Sub btnMoviesBrowseForFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesBrowseForFolder.Click
        Dim folderselected As String = ""
        With FolderBrowserDialog1
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = FolderBrowserDialog1.SelectedPath
                If FolderBrowserDialog1.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbFolder.Text = folderselected
            addtolist()
        End If
    End Sub
    Private Sub btnMoviesBrowseForFolderFileMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoviesBrowseForFolderFileMode.Click
        Dim folderselected As String = ""
        With FolderBrowserDialog1
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = FolderBrowserDialog1.SelectedPath
                If FolderBrowserDialog1.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbFolderFileMode.Text = folderselected
            addtolistFileMode()
        End If
    End Sub
    Private Sub btnMusicBrowseForFolder_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicBrowseForFolder.Click
        Dim folderselected As String = ""
        With FolderBrowserDialog1
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = FolderBrowserDialog1.SelectedPath
                If FolderBrowserDialog1.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbFolderMusic.Text = folderselected
            addmusictolist()
        End If
    End Sub
    Private Sub tbFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolder.Click
        tbFolder.Text = ""
    End Sub
    Private Sub tbFolderFileMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolderFileMode.Click
        tbFolderFileMode.Text = ""
    End Sub
    Private Sub tbFolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolder.TextChanged
        If Directory.Exists(tbFolder.Text) Then
            btnMoviesAddFolderByPath.Enabled = True
        Else
            btnMoviesAddFolderByPath.Enabled = False
        End If

    End Sub
    Private Sub tbFolderFileMode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolderFileMode.TextChanged
        If Directory.Exists(tbFolderFileMode.Text) Then
            btnMoviesAddFolderByPathFileMode.Enabled = True
        Else
            btnMoviesAddFolderByPathFileMode.Enabled = False
        End If

    End Sub
    Private Sub btnTVBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVBrowse.Click
        Dim folderselected As String = ""
        With FolderBrowserDialog1
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                folderselected = FolderBrowserDialog1.SelectedPath
                If FolderBrowserDialog1.SelectedPath = "" Then Exit Sub
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath) Then Exit Sub

            End If
        End With
        If Not folderselected = "" Then
            tbTVPath.Text = folderselected
            addtvshowtolist()
        End If

    End Sub

    Private Sub btnTVClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTVClearList.Click
        lbTVShows.Items.Clear()
    End Sub
    Private Sub tbTVPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTVPath.TextChanged
        If Directory.Exists(tbTVPath.Text) Then
            btnTVAddPath.Enabled = True
        Else
            btnTVAddPath.Enabled = False
        End If
    End Sub
    Private Sub tbTVPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTVPath.Click
        tbTVPath.Text = ""
    End Sub

    'Private Sub dlgConfiguration_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    'prompt to save any changes
    '    If MsgBox("Do you want to save any changes?", MsgBoxStyle.OkCancel, "Save Changes?") = MsgBoxResult.Cancel Then
    '        Exit Sub
    '    Else
    '        saveconfig()
    '        Me.Dispose()
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub dlgConfiguration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rconf = maincollection.rconf
        setactiveconf(rconf)
    End Sub


    Private Sub tbFolderMusic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolderMusic.TextChanged
        If Directory.Exists(tbFolderMusic.Text) Then
            btnMusicAddFolderByPath.Enabled = True
        Else
            btnMusicAddFolderByPath.Enabled = False
        End If
    End Sub
    Private Sub tbFolderMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolderMusic.Click
        tbFolderMusic.Text = ""
    End Sub
    Private Sub btnMusicAddFolderByPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMusicAddFolderByPath.Click
        addmusictolist()
    End Sub

    Private Sub btnsaveconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveconfig.Click
        saveconfig()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub cbCreateMovieTbnFile_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCreateMovieTbnFile.CheckedChanged
        rconf.pcbcreatemovietbn = cbCreateMovieTbnFile.Checked
    End Sub

    Private Sub cbGetcaldnPosters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGetcaldnPosters.Click
        rconf.pcbGetcaldnPosters = cbGetcaldnPosters.Checked
    End Sub

    Private Sub kgNFOFANARTsettings_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles kgNFOFANARTsettings.Paint

    End Sub

    Private Sub tcSettings_SelectedIndexChanging(ByVal sender As System.Object, ByVal e As Dotnetrix.Controls.TabPageChangeEventArgs) Handles tcSettings.SelectedIndexChanging

    End Sub

    Private Sub getMediaImagesMusicFront_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicFront.Click
        rconf.pgetMediaImagesMusicFront = getMediaImagesMusicFront.Checked
    End Sub

    Private Sub getMediaImagesMusicBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicBack.Click
        rconf.pgetMediaImagesMusicback = getMediaImagesMusicBack.Checked
    End Sub

    Private Sub getMediaImagesMusicCd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicCd1.Click
        rconf.pgetMediaImagesMusiccd1 = getMediaImagesMusicCd1.Checked
    End Sub

    Private Sub getMediaImagesMusicCd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicCd2.Click
        rconf.pgetMediaImagesMusiccd2 = getMediaImagesMusicCd2.Checked
    End Sub

    Private Sub getMediaImagesMusicCd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicCd3.Click
        rconf.pgetMediaImagesMusiccd3 = getMediaImagesMusicCd3.Checked
    End Sub

    Private Sub getMediaImagesMusicCd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicCd4.Click
        rconf.pgetMediaImagesMusiccd4 = getMediaImagesMusicCd4.Checked
    End Sub

    Private Sub getMediaImagesMusicInlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicInlay.Click
        rconf.pgetMediaImagesMusicinlay = getMediaImagesMusicInlay.Checked
    End Sub

    Private Sub getMediaImagesMusicInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMusicInsert.Click
        rconf.pgetMediaImagesMusicinsert = getMediaImagesMusicInsert.Checked
    End Sub

    Private Sub getMediaImagesMoviesFront_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesFront.Click
        rconf.pgetMediaImagesMoviesFront = getMediaImagesMoviesFront.Checked
    End Sub

    Private Sub getMediaImagesMoviesBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesBack.Click
        rconf.pgetMediaImagesMoviesback = getMediaImagesMoviesBack.Checked
    End Sub

    Private Sub getMediaImagesMoviesCd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesCD1.Click
        rconf.pgetMediaImagesMoviescd1 = getMediaImagesMoviesCD1.Checked
    End Sub

    Private Sub getMediaImagesMoviesCd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesCD2.Click
        rconf.pgetMediaImagesMoviescd2 = getMediaImagesMoviesCD2.Checked
    End Sub

    Private Sub getMediaImagesMoviesCd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesCD3.Click
        rconf.pgetMediaImagesMoviescd3 = getMediaImagesMoviesCD3.Checked
    End Sub

    Private Sub getMediaImagesMoviesCd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesCD4.Click
        rconf.pgetMediaImagesMoviescd4 = getMediaImagesMoviesCD4.Checked
    End Sub

    Private Sub getMediaImagesMoviesInlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesInlay.Click
        rconf.pgetMediaImagesMoviesinlay = getMediaImagesMoviesInlay.Checked
    End Sub

    Private Sub getMediaImagesMoviesInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesMoviesInsert.Click
        rconf.pgetMediaImagesMoviesinsert = getMediaImagesMoviesInsert.Checked
    End Sub
    Private Sub getMediaImagesShowsFront_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsFront.Click
        rconf.pgetMediaImagesShowsFront = getMediaImagesShowsFront.Checked
    End Sub

    Private Sub getMediaImagesShowsBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsBack.Click
        rconf.pgetMediaImagesShowsback = getMediaImagesShowsBack.Checked
    End Sub

    Private Sub getMediaImagesShowsCd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsCD1.Click
        rconf.pgetMediaImagesShowscd1 = getMediaImagesShowsCD1.Checked
    End Sub

    Private Sub getMediaImagesShowsCd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsCD2.Click
        rconf.pgetMediaImagesShowscd2 = getMediaImagesShowsCD2.Checked
    End Sub

    Private Sub getMediaImagesShowsCd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsCD3.Click
        rconf.pgetMediaImagesShowscd3 = getMediaImagesShowsCD3.Checked
    End Sub

    Private Sub getMediaImagesShowsCd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsCD4.Click
        rconf.pgetMediaImagesShowscd4 = getMediaImagesShowsCD4.Checked
    End Sub

    Private Sub getMediaImagesShowsInlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsInlay.Click
        rconf.pgetMediaImagesShowsinlay = getMediaImagesShowsInlay.Checked
    End Sub

    Private Sub getMediaImagesShowsInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getMediaImagesShowsInsert.Click
        rconf.pgetMediaImagesShowsinsert = getMediaImagesShowsInsert.Checked
    End Sub


    Private Sub krbColorPink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorPink.Click
        setguicolor("pink")
    End Sub

    Private Sub krbColorGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorGreen.Click
        setguicolor("green")
    End Sub

    Private Sub krbColorPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorPro.Click
        setguicolor("pro")
    End Sub
    Private Sub krbColorBlingLarge_Cclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorBlingLarge.Click
        setguicolor("blinglarge")
    End Sub
    Private Sub krbColorSkyBlueLarge_Cclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krbColorSkyBlueLarge.Click
        setguicolor("skybluelarge")
    End Sub
    Private Sub cbMusicGetAlbumArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMusicGetAlbumArt.Click
        rconf.pgetMusicAlbumArt = cbMusicGetAlbumArt.Checked
    End Sub



    Private Sub cbFilterUnderscoreDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterUnderscoreDot.Click
        rconf.pcbFilterUnderscoreDot = cbFilterUnderscoreDot.Checked
    End Sub

    Private Sub pcb_tv_langoverridebanners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtvlangoverridebanners.Click
        rconf.pcbtvlangoverride = cbtvlangoverridebanners.Checked
    End Sub

    Private Sub cbFilterNameFileModeEverythingBeforeDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBeforeYear.Click
        rconf.pcbFilterNameFileModeEverythingBeforeYear = cbFilterNameFileModeEverythingBeforeYear.Checked
    End Sub

    Private Sub cbFilterNameFileModeEverythingBeforeh264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBeforeh264.Click
        rconf.pcbFilterNameFileModeEverythingBeforeh264 = cbFilterNameFileModeEverythingBeforeh264.Checked
    End Sub
    Private Sub cbFilterNameFileModeEverythingBeforex264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBeforex264.Click
        rconf.pcbFilterNameFileModeEverythingBeforex264 = cbFilterNameFileModeEverythingBeforex264.Checked
    End Sub
    Private Sub cbFilterNameFileModeEverythingBefore720p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBefore720p.Click
        rconf.pcbFilterNameFileModeEverythingBefore720p = cbFilterNameFileModeEverythingBefore720p.Checked
    End Sub
    Private Sub cbFilterNameFileModeEverythingBefore1080i_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBefore1080i.Click
        rconf.pcbFilterNameFileModeEverythingBefore1080i = cbFilterNameFileModeEverythingBefore1080i.Checked
    End Sub
    Private Sub cbFilterNameFileModeEverythingBefore1080p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBefore1080p.Click
        rconf.pcbFilterNameFileModeEverythingBefore1080p = cbFilterNameFileModeEverythingBefore1080p.Checked
    End Sub

    Private Sub cbFilterNameFileModeEverythingBeforeDash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterNameFileModeEverythingBeforeDash.Click
        rconf.pcbFilterNameFileModeEverythingBeforeDash = cbFilterNameFileModeEverythingBeforeDash.Checked
    End Sub


    Private Sub cbGetMusicFanartFromHTBackdrops_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGetMusicFanartFromHTBackdrops.Click
        rconf.pcbGetMusicFanartFromHTBackdrops = cbGetMusicFanartFromHTBackdrops.Checked
    End Sub

    Private Sub cbMusicResizeMusicFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMusicResizeMusicFanart.Click
        rconf.pcbmusicfanartresize = cbMusicResizeMusicFanart.Checked
    End Sub

    Private Sub cbshows_UseStudioasRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshows_UseStudioasRating.Click
        rconf.pcbshows_UseStudioasRating = cbshows_UseStudioasRating.Checked
    End Sub

    Private Sub pcbGeneralSupportSkinBasedFlagging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGeneralSupportSkinBasedFlagging.Click
        rconf.pcbGeneralSupportSkinBasedFlagging = cbGeneralSupportSkinBasedFlagging.Checked
    End Sub

    Private Sub cbmovie_use_certification_for_mpaa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmovie_use_certification_for_mpaa.CheckedChanged
        rconf.pcbmovie_use_certification_for_mpaa = cbmovie_use_certification_for_mpaa.Checked
    End Sub
    Private Sub cbMoviesCertificationLang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMoviesCertificationLang.SelectedIndexChanged
        rconf.pcbMoviesCertificationLang = cbMoviesCertificationLang.SelectedItem.ToString
    End Sub
End Class
