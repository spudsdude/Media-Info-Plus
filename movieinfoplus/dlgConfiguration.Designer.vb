<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConfiguration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgConfiguration))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.kgMovieSettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbMoviesCertificationLang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.klblCertLang = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbmovie_use_certification_for_mpaa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnProcessAll = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblMoviesMisc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbAllowAutoMovienameRename = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbcopyplotsummaryifnoplot = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbNoNfoChangePrompt = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klblPosterSizeMovieTBN = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.knudframeratio = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.cbnopromptfornewposters = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbShowFanart = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klblPosterSizefolderjpg = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.knudPosterHeightfolderjpg = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.knudPosterHeightTBN = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.kgAutomaticGenerationSettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbmoviesnonforename = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMovieScanningOptions = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbscanformoviemediainformation = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbautocreatemovienametbn = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbautocreatemovietbn = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbautocreatefolderjpg = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgNFOFANARTsettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbcreateImdbIDtxt = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMovieFileCreate = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbcreatemovienamedotnfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbSaveNFO = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbOverwriteNFO = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbcreatemovienamedottbn = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbCreateMovieNFO = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbUsefolderjpgfortbn = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbSaveSageTVBackgrounds = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbShowTBN = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbCreateMovieTbnFile = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbCreateMovieNameFanartjpg = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbCreateFolderjpg = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbCreateFanartjpgfile = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgMovieDownloadOptions = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.kgMoviesMI = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.getMediaImagesMoviesInsert = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesInlay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesCD4 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesCD3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesCD2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesCD1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesBack = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMoviesFront = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieDLO = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMoviesDownloadGeneral = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblMoviesDownloadGeneral = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbGetTMDBInfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbGetIMDBInfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgMovieBackgrounds = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblFanart = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbGetFanart = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgMoviesDownloadPosters = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblGetPostersFrom = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbGetcaldnPosters = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbDownloadPoster = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbGetTMDBPosters = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbgetncposters = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgNameFilter = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbFilterFolderFileLevel = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterUnderscoreDot = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblFolderLevelNameFilters = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbIgnoreparans = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterYears = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilter1080i = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tbCustomFilter1 = New System.Windows.Forms.TextBox
        Me.Label5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbFilterH264 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterLq = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterHidef = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterDVD = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilter1080p = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterDivx = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilter720p = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterXvid = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterCustom4 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterAvi = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterCustom3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterBluRay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterCustom5 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tbCustomFilter2 = New System.Windows.Forms.TextBox
        Me.cbFilterCustom2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tbCustomFilter3 = New System.Windows.Forms.TextBox
        Me.tbCustomFilter5 = New System.Windows.Forms.TextBox
        Me.tbCustomFilter4 = New System.Windows.Forms.TextBox
        Me.cbFilterCustom1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgTQQIconsGroup = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblGMaxCached = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblGQuality = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbf3s0 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klblTQQIconsLbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbf1s9 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbf1s0 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbf2s0 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.Label1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbf1s3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbf2s10 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbMaxIconsToDisplay = New System.Windows.Forms.ComboBox
        Me.cbMaxIconPerStyle = New System.Windows.Forms.ComboBox
        Me.cbf2s8 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbDlFormat = New System.Windows.Forms.ComboBox
        Me.cbf2s2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgColorSelect = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.krbColorBubbles = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorFire = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorSkyBlueLarge = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorBlingLarge = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorPro = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorGreen = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorPink = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.klblGUILOOK = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.krbColorBling = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorSilver = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorBlue = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbColorBlack = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.cbGoogleImageSearchPop = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnsaveconfig = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kgTVShowSettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.kgTVGlobalSettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbscanforepisodemediainformation = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbshows_UseStudioasRating = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbtvlangoverridebanners = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCustomRegX = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tbTvRegex1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.klblTVGSnoteslbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblGlobalSettingslbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbltv_curlang = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblTVCheckForNewTVShowDatalbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbtv_lang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.combolTVCheckForNewTVShowData = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.kgSettingsTvEpisode = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.tvgs_episode_overwrite_tbn = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tvgs_episode_overwrite_nfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klblTVEpisodesSection = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_cb_episode_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgSettingsTvSeasonBanners = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klbltvseasonwhatstylelbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_combobox_season_banners_download_type = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.tvgs_knud_season_posters_download_maxnumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.krbTVSeasonUsePoster = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.krbTVSeasonUseWide = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_cb_season_posters_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klbltvMaxNumberOfPosters = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_knud_season_banners_download_maxnumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.klblTVBannersSection = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_cb_season_banners_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgSettingsTvShow = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.kgTvShowsShowWidePoster = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblTVPostersSection = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbtvshow_show_usePosterImageForShow = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.klbltvMaxNumberOfPostersToDownload = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbtvshow_show_useWideImageForShow = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.tvgs_cb_tvshow_posters_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tvgs_cb_tvshow_wideicon_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tvgs_knud_tvshow_posters_download_maxnumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.tvgs_cb_tvshow_nfo_overwrite = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tvgs_cb_tvshow_fanart_display = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblFanartToApplylbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblTvShowSettingsLbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblTVFanartSection = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_combobox_tvshow_fanart_download_size = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.tvgs_cb_tvshow_fanart_download = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.klbltvmaxtvfanarttodownload = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tvgs_knud_tvshow_fanart_download_maxnumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
        Me.kgShowsMI = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.getMediaImagesShowsInsert = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsInlay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsCD4 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsCD3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsCD2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsCD1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsBack = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesShowsFront = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tcSettings = New Dotnetrix.Controls.TabControlEX
        Me.tpSettingsGeneral = New Dotnetrix.Controls.TabPageEX
        Me.kgGeneralMisc = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbGeneralSupportSkinBasedFlagging = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbtv_showwgetwindows = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblGeneralMisc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgGeneralProxy = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblIPv4Only = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProxyPort = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProxyIP = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tbProxyPort = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbProxyIP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cbUseProxyServer = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblGeneralProxy = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tpSettingsMovies = New Dotnetrix.Controls.TabPageEX
        Me.kgOfdbSettings = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.rbofdb_usePlotOutline = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbofdb_englishtagline = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbofdb_BlankTagline = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.klblODFBSettingsLabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbofdb_UpdateVotes = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbofdb_UpdateRating = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbofdb_UpdateGenre = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbofdb_UpdatePlot = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbofdb_UpdateOutline = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbofdb_UpdateTitle = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgMoviesNameFilters = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.kgFileLevelFilterOptions = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblUsingCustomExpression = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1 = New System.Windows.Forms.TextBox
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbShowsStripEverythinginParan = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBeforeDash = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFileLevelFilterUnderscoreDot = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBefore1080p = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBefore1080i = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBefore720p = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBeforex264 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbFilterNameFileModeEverythingBeforeh264 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMovieFileLevelFiltersWhatTheyDo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbFilterNameFileModeEverythingBeforeYear = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMoviesFileLevelFilterOptions = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMoviesNameFilterl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMovieFileOptions = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblFCASOMovies = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMovieFolderSelect = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblFolderNameForMovieName = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblVfoldermode = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblVFileMode = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFolderMode = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblRemoveamoivefolder = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFileMode = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnMoviesBrowseForFolderFileMode = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMoviesClearFolderListFileMode = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbFolderFileMode = New System.Windows.Forms.TextBox
        Me.btnMoviesAddFolderByPathFileMode = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.clbPathsFileMode = New System.Windows.Forms.CheckedListBox
        Me.btnMoviesBrowseForFolder = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMoviesClearFolderList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbFolder = New System.Windows.Forms.TextBox
        Me.btnMoviesAddFolderByPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.clbPaths = New System.Windows.Forms.CheckedListBox
        Me.klMovieFolderGroup = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tpSettingsTvShows = New Dotnetrix.Controls.TabPageEX
        Me.kgTvshowpaths = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnTVBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.klblRemoveatvshow1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tbTVPath = New System.Windows.Forms.TextBox
        Me.btnTVClearList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnTVAddPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lbTVShows = New System.Windows.Forms.CheckedListBox
        Me.klbTVShowFolders = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tpSettingsMusic = New Dotnetrix.Controls.TabPageEX
        Me.lblTunesWHat = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMusicAlbumArt = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbMusicResizeMusicFanart = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbGetMusicFanartFromHTBackdrops = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbMusicGetAlbumArt = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMusicAlbumArt = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMusicMI = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.getMediaImagesMusicInsert = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicInlay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicCd4 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicCd3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicCd2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicCd1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicBack = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.getMediaImagesMusicFront = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.klblMusicMI = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbmusic_createAlbumNfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbmusic_createArtistnfo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgTunesTunes = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnMusicBrowseForFolder = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbFolderMusic = New System.Windows.Forms.TextBox
        Me.btnMusicClearFolderList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMusicAddFolderByPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.clbPathsMusic = New System.Windows.Forms.CheckedListBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tpSettingsHV = New Dotnetrix.Controls.TabPageEX
        Me.kgSettingsTVActive = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.Button8 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnRGF = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbtnRemoveAllTempTVFiles = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbtnRemoveAllCachedMovieData = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kscMainSettings = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.kgMovieSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieSettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieSettings.Panel.SuspendLayout()
        Me.kgMovieSettings.SuspendLayout()
        CType(Me.kgAutomaticGenerationSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgAutomaticGenerationSettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgAutomaticGenerationSettings.Panel.SuspendLayout()
        Me.kgAutomaticGenerationSettings.SuspendLayout()
        CType(Me.kgNFOFANARTsettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgNFOFANARTsettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgNFOFANARTsettings.Panel.SuspendLayout()
        Me.kgNFOFANARTsettings.SuspendLayout()
        CType(Me.kgMovieDownloadOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieDownloadOptions.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieDownloadOptions.Panel.SuspendLayout()
        Me.kgMovieDownloadOptions.SuspendLayout()
        CType(Me.kgMoviesMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMoviesMI.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMoviesMI.Panel.SuspendLayout()
        Me.kgMoviesMI.SuspendLayout()
        CType(Me.kgMoviesDownloadGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMoviesDownloadGeneral.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMoviesDownloadGeneral.Panel.SuspendLayout()
        Me.kgMoviesDownloadGeneral.SuspendLayout()
        CType(Me.kgMovieBackgrounds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieBackgrounds.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieBackgrounds.Panel.SuspendLayout()
        Me.kgMovieBackgrounds.SuspendLayout()
        CType(Me.kgMoviesDownloadPosters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMoviesDownloadPosters.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMoviesDownloadPosters.Panel.SuspendLayout()
        Me.kgMoviesDownloadPosters.SuspendLayout()
        CType(Me.kgNameFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgNameFilter.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgNameFilter.Panel.SuspendLayout()
        Me.kgNameFilter.SuspendLayout()
        CType(Me.kgTQQIconsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTQQIconsGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTQQIconsGroup.Panel.SuspendLayout()
        Me.kgTQQIconsGroup.SuspendLayout()
        CType(Me.kgColorSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgColorSelect.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgColorSelect.Panel.SuspendLayout()
        Me.kgColorSelect.SuspendLayout()
        CType(Me.kgTVShowSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTVShowSettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTVShowSettings.Panel.SuspendLayout()
        Me.kgTVShowSettings.SuspendLayout()
        CType(Me.kgTVGlobalSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTVGlobalSettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTVGlobalSettings.Panel.SuspendLayout()
        Me.kgTVGlobalSettings.SuspendLayout()
        CType(Me.kgSettingsTvEpisode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgSettingsTvEpisode.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgSettingsTvEpisode.Panel.SuspendLayout()
        Me.kgSettingsTvEpisode.SuspendLayout()
        CType(Me.kgSettingsTvSeasonBanners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgSettingsTvSeasonBanners.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgSettingsTvSeasonBanners.Panel.SuspendLayout()
        Me.kgSettingsTvSeasonBanners.SuspendLayout()
        CType(Me.kgSettingsTvShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgSettingsTvShow.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgSettingsTvShow.Panel.SuspendLayout()
        Me.kgSettingsTvShow.SuspendLayout()
        CType(Me.kgTvShowsShowWidePoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTvShowsShowWidePoster.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTvShowsShowWidePoster.Panel.SuspendLayout()
        Me.kgTvShowsShowWidePoster.SuspendLayout()
        CType(Me.kgShowsMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgShowsMI.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgShowsMI.Panel.SuspendLayout()
        Me.kgShowsMI.SuspendLayout()
        Me.tcSettings.SuspendLayout()
        Me.tpSettingsGeneral.SuspendLayout()
        CType(Me.kgGeneralMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgGeneralMisc.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgGeneralMisc.Panel.SuspendLayout()
        Me.kgGeneralMisc.SuspendLayout()
        CType(Me.kgGeneralProxy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgGeneralProxy.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgGeneralProxy.Panel.SuspendLayout()
        Me.kgGeneralProxy.SuspendLayout()
        Me.tpSettingsMovies.SuspendLayout()
        CType(Me.kgOfdbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgOfdbSettings.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgOfdbSettings.Panel.SuspendLayout()
        Me.kgOfdbSettings.SuspendLayout()
        CType(Me.kgMoviesNameFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMoviesNameFilters.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMoviesNameFilters.Panel.SuspendLayout()
        Me.kgMoviesNameFilters.SuspendLayout()
        CType(Me.kgFileLevelFilterOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgFileLevelFilterOptions.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgFileLevelFilterOptions.Panel.SuspendLayout()
        Me.kgFileLevelFilterOptions.SuspendLayout()
        CType(Me.kgMovieFileOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieFileOptions.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieFileOptions.Panel.SuspendLayout()
        Me.kgMovieFileOptions.SuspendLayout()
        CType(Me.kgMovieFolderSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieFolderSelect.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieFolderSelect.Panel.SuspendLayout()
        Me.kgMovieFolderSelect.SuspendLayout()
        Me.tpSettingsTvShows.SuspendLayout()
        CType(Me.kgTvshowpaths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTvshowpaths.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTvshowpaths.Panel.SuspendLayout()
        Me.kgTvshowpaths.SuspendLayout()
        Me.tpSettingsMusic.SuspendLayout()
        CType(Me.kgMusicAlbumArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMusicAlbumArt.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMusicAlbumArt.Panel.SuspendLayout()
        Me.kgMusicAlbumArt.SuspendLayout()
        CType(Me.kgMusicMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMusicMI.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMusicMI.Panel.SuspendLayout()
        Me.kgMusicMI.SuspendLayout()
        CType(Me.kgTunesTunes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTunesTunes.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTunesTunes.Panel.SuspendLayout()
        Me.kgTunesTunes.SuspendLayout()
        Me.tpSettingsHV.SuspendLayout()
        CType(Me.kgSettingsTVActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgSettingsTVActive.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgSettingsTVActive.Panel.SuspendLayout()
        Me.kgSettingsTVActive.SuspendLayout()
        CType(Me.kscMainSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscMainSettings.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMainSettings.Panel1.SuspendLayout()
        CType(Me.kscMainSettings.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMainSettings.Panel2.SuspendLayout()
        Me.kscMainSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(796, 654)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'kgMovieSettings
        '
        Me.kgMovieSettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMovieSettings.Location = New System.Drawing.Point(1, 970)
        Me.kgMovieSettings.Name = "kgMovieSettings"
        '
        'kgMovieSettings.Panel
        '
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbMoviesCertificationLang)
        Me.kgMovieSettings.Panel.Controls.Add(Me.klblCertLang)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbmovie_use_certification_for_mpaa)
        Me.kgMovieSettings.Panel.Controls.Add(Me.btnProcessAll)
        Me.kgMovieSettings.Panel.Controls.Add(Me.lblMoviesMisc)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbAllowAutoMovienameRename)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbcopyplotsummaryifnoplot)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbNoNfoChangePrompt)
        Me.kgMovieSettings.Panel.Controls.Add(Me.klblPosterSizeMovieTBN)
        Me.kgMovieSettings.Panel.Controls.Add(Me.knudframeratio)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbnopromptfornewposters)
        Me.kgMovieSettings.Panel.Controls.Add(Me.cbShowFanart)
        Me.kgMovieSettings.Panel.Controls.Add(Me.klblPosterSizefolderjpg)
        Me.kgMovieSettings.Panel.Controls.Add(Me.knudPosterHeightfolderjpg)
        Me.kgMovieSettings.Panel.Controls.Add(Me.knudPosterHeightTBN)
        Me.kgMovieSettings.Size = New System.Drawing.Size(789, 224)
        Me.kgMovieSettings.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kgMovieSettings.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.kgMovieSettings.StateCommon.Border.ColorAngle = 60.0!
        Me.kgMovieSettings.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgMovieSettings.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgMovieSettings.StateCommon.Border.Rounding = 7
        Me.kgMovieSettings.StateCommon.Border.Width = 2
        Me.kgMovieSettings.TabIndex = 82
        '
        'cbMoviesCertificationLang
        '
        Me.cbMoviesCertificationLang.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.cbMoviesCertificationLang.DropDownWidth = 41
        Me.cbMoviesCertificationLang.FormattingEnabled = False
        Me.cbMoviesCertificationLang.Items.AddRange(New Object() {"Iceland", "Brazil", "Portugal", "Argentina", "Australia", "Belgium", "Canada", "Finland", "France", "Germany", "Hong Kong", "Ireland", "Netherlands", "New Zealand", "Peru", "Singapore", "South Korea", "Spain", "Sweden", "Switzerland", "UK", "USA"})
        Me.cbMoviesCertificationLang.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.cbMoviesCertificationLang.Location = New System.Drawing.Point(211, 182)
        Me.cbMoviesCertificationLang.Name = "cbMoviesCertificationLang"
        Me.cbMoviesCertificationLang.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.cbMoviesCertificationLang.Size = New System.Drawing.Size(135, 20)
        Me.cbMoviesCertificationLang.TabIndex = 81
        '
        'klblCertLang
        '
        Me.klblCertLang.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblCertLang.Location = New System.Drawing.Point(21, 183)
        Me.klblCertLang.Name = "klblCertLang"
        Me.klblCertLang.Size = New System.Drawing.Size(179, 21)
        Me.klblCertLang.TabIndex = 91
        Me.klblCertLang.Text = "Certification Language to use"
        Me.klblCertLang.Values.ExtraText = ""
        Me.klblCertLang.Values.Image = Nothing
        Me.klblCertLang.Values.Text = "Certification Language to use"
        '
        'cbmovie_use_certification_for_mpaa
        '
        Me.cbmovie_use_certification_for_mpaa.Checked = True
        Me.cbmovie_use_certification_for_mpaa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbmovie_use_certification_for_mpaa.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbmovie_use_certification_for_mpaa.Location = New System.Drawing.Point(365, 183)
        Me.cbmovie_use_certification_for_mpaa.Name = "cbmovie_use_certification_for_mpaa"
        Me.cbmovie_use_certification_for_mpaa.Size = New System.Drawing.Size(214, 21)
        Me.cbmovie_use_certification_for_mpaa.TabIndex = 82
        Me.cbmovie_use_certification_for_mpaa.Text = "Use Certification data for MPAA"
        Me.cbmovie_use_certification_for_mpaa.Values.ExtraText = ""
        Me.cbmovie_use_certification_for_mpaa.Values.Image = Nothing
        Me.cbmovie_use_certification_for_mpaa.Values.Text = "Use Certification data for MPAA"
        '
        'btnProcessAll
        '
        Me.btnProcessAll.Enabled = False
        Me.btnProcessAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessAll.Location = New System.Drawing.Point(609, 83)
        Me.btnProcessAll.Name = "btnProcessAll"
        Me.btnProcessAll.Size = New System.Drawing.Size(190, 50)
        Me.btnProcessAll.TabIndex = 50
        Me.btnProcessAll.Text = "Process All Movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and recreate nfo files"
        Me.btnProcessAll.Values.ExtraText = ""
        Me.btnProcessAll.Values.Image = Nothing
        Me.btnProcessAll.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcessAll.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcessAll.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcessAll.Values.Text = "Process All Movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and recreate nfo files"
        Me.btnProcessAll.Visible = False
        '
        'lblMoviesMisc
        '
        Me.lblMoviesMisc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMoviesMisc.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMoviesMisc.Location = New System.Drawing.Point(0, 0)
        Me.lblMoviesMisc.Name = "lblMoviesMisc"
        Me.lblMoviesMisc.Size = New System.Drawing.Size(779, 21)
        Me.lblMoviesMisc.TabIndex = 90
        Me.lblMoviesMisc.Text = "Misc. Options"
        Me.lblMoviesMisc.Values.ExtraText = ""
        Me.lblMoviesMisc.Values.Image = Nothing
        Me.lblMoviesMisc.Values.Text = "Misc. Options"
        '
        'cbAllowAutoMovienameRename
        '
        Me.cbAllowAutoMovienameRename.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbAllowAutoMovienameRename.Location = New System.Drawing.Point(7, 32)
        Me.cbAllowAutoMovienameRename.Name = "cbAllowAutoMovienameRename"
        Me.cbAllowAutoMovienameRename.Size = New System.Drawing.Size(235, 21)
        Me.cbAllowAutoMovienameRename.TabIndex = 76
        Me.cbAllowAutoMovienameRename.Text = "Allow Automatic Movie File renaming"
        Me.cbAllowAutoMovienameRename.Values.ExtraText = ""
        Me.cbAllowAutoMovienameRename.Values.Image = Nothing
        Me.cbAllowAutoMovienameRename.Values.Text = "Allow Automatic Movie File renaming"
        '
        'cbcopyplotsummaryifnoplot
        '
        Me.cbcopyplotsummaryifnoplot.Checked = True
        Me.cbcopyplotsummaryifnoplot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcopyplotsummaryifnoplot.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbcopyplotsummaryifnoplot.Location = New System.Drawing.Point(360, 97)
        Me.cbcopyplotsummaryifnoplot.Name = "cbcopyplotsummaryifnoplot"
        Me.cbcopyplotsummaryifnoplot.Size = New System.Drawing.Size(224, 21)
        Me.cbcopyplotsummaryifnoplot.TabIndex = 5
        Me.cbcopyplotsummaryifnoplot.Text = "Copy Plot Summary if Plot is empty"
        Me.cbcopyplotsummaryifnoplot.Values.ExtraText = ""
        Me.cbcopyplotsummaryifnoplot.Values.Image = Nothing
        Me.cbcopyplotsummaryifnoplot.Values.Text = "Copy Plot Summary if Plot is empty"
        '
        'cbNoNfoChangePrompt
        '
        Me.cbNoNfoChangePrompt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbNoNfoChangePrompt.Location = New System.Drawing.Point(7, 62)
        Me.cbNoNfoChangePrompt.Name = "cbNoNfoChangePrompt"
        Me.cbNoNfoChangePrompt.Size = New System.Drawing.Size(207, 37)
        Me.cbNoNfoChangePrompt.TabIndex = 82
        Me.cbNoNfoChangePrompt.Text = "Don't Prompt me when I change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data in the nfo file"
        Me.cbNoNfoChangePrompt.Values.ExtraText = ""
        Me.cbNoNfoChangePrompt.Values.Image = Nothing
        Me.cbNoNfoChangePrompt.Values.Text = "Don't Prompt me when I change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data in the nfo file"
        '
        'klblPosterSizeMovieTBN
        '
        Me.klblPosterSizeMovieTBN.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblPosterSizeMovieTBN.Location = New System.Drawing.Point(424, 139)
        Me.klblPosterSizeMovieTBN.Name = "klblPosterSizeMovieTBN"
        Me.klblPosterSizeMovieTBN.Size = New System.Drawing.Size(186, 21)
        Me.klblPosterSizeMovieTBN.TabIndex = 89
        Me.klblPosterSizeMovieTBN.Text = "Poster Display Size (TBN File)"
        Me.klblPosterSizeMovieTBN.Values.ExtraText = ""
        Me.klblPosterSizeMovieTBN.Values.Image = Nothing
        Me.klblPosterSizeMovieTBN.Values.Text = "Poster Display Size (TBN File)"
        '
        'knudframeratio
        '
        Me.knudframeratio.DecimalPlaces = 6
        Me.knudframeratio.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.knudframeratio.Location = New System.Drawing.Point(1, 97)
        Me.knudframeratio.Maximum = New Decimal(New Integer() {12, 0, 0, 65536})
        Me.knudframeratio.Name = "knudframeratio"
        Me.knudframeratio.Size = New System.Drawing.Size(120, 33)
        Me.knudframeratio.TabIndex = 87
        Me.knudframeratio.Visible = False
        '
        'cbnopromptfornewposters
        '
        Me.cbnopromptfornewposters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbnopromptfornewposters.Location = New System.Drawing.Point(360, 63)
        Me.cbnopromptfornewposters.Name = "cbnopromptfornewposters"
        Me.cbnopromptfornewposters.Size = New System.Drawing.Size(253, 21)
        Me.cbnopromptfornewposters.TabIndex = 3
        Me.cbnopromptfornewposters.Text = "Don't Prompt for new posters or fanart"
        Me.cbnopromptfornewposters.Values.ExtraText = ""
        Me.cbnopromptfornewposters.Values.Image = Nothing
        Me.cbnopromptfornewposters.Values.Text = "Don't Prompt for new posters or fanart"
        '
        'cbShowFanart
        '
        Me.cbShowFanart.Checked = True
        Me.cbShowFanart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowFanart.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbShowFanart.Location = New System.Drawing.Point(360, 33)
        Me.cbShowFanart.Name = "cbShowFanart"
        Me.cbShowFanart.Size = New System.Drawing.Size(269, 21)
        Me.cbShowFanart.TabIndex = 76
        Me.cbShowFanart.Text = "Use Movie's Fanart For Background Image"
        Me.cbShowFanart.Values.ExtraText = ""
        Me.cbShowFanart.Values.Image = Nothing
        Me.cbShowFanart.Values.Text = "Use Movie's Fanart For Background Image"
        '
        'klblPosterSizefolderjpg
        '
        Me.klblPosterSizefolderjpg.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblPosterSizefolderjpg.Location = New System.Drawing.Point(68, 139)
        Me.klblPosterSizefolderjpg.Name = "klblPosterSizefolderjpg"
        Me.klblPosterSizefolderjpg.Size = New System.Drawing.Size(192, 21)
        Me.klblPosterSizefolderjpg.TabIndex = 88
        Me.klblPosterSizefolderjpg.Text = "Poster Display Size (folder.jpg)"
        Me.klblPosterSizefolderjpg.Values.ExtraText = ""
        Me.klblPosterSizefolderjpg.Values.Image = Nothing
        Me.klblPosterSizefolderjpg.Values.Text = "Poster Display Size (folder.jpg)"
        '
        'knudPosterHeightfolderjpg
        '
        Me.knudPosterHeightfolderjpg.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.knudPosterHeightfolderjpg.Location = New System.Drawing.Point(4, 134)
        Me.knudPosterHeightfolderjpg.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.knudPosterHeightfolderjpg.Name = "knudPosterHeightfolderjpg"
        Me.knudPosterHeightfolderjpg.Size = New System.Drawing.Size(63, 33)
        Me.knudPosterHeightfolderjpg.TabIndex = 86
        '
        'knudPosterHeightTBN
        '
        Me.knudPosterHeightTBN.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.knudPosterHeightTBN.Location = New System.Drawing.Point(360, 134)
        Me.knudPosterHeightTBN.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.knudPosterHeightTBN.Name = "knudPosterHeightTBN"
        Me.knudPosterHeightTBN.Size = New System.Drawing.Size(63, 33)
        Me.knudPosterHeightTBN.TabIndex = 87
        '
        'kgAutomaticGenerationSettings
        '
        Me.kgAutomaticGenerationSettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgAutomaticGenerationSettings.Location = New System.Drawing.Point(488, 22)
        Me.kgAutomaticGenerationSettings.Name = "kgAutomaticGenerationSettings"
        '
        'kgAutomaticGenerationSettings.Panel
        '
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.cbmoviesnonforename)
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.lblMovieScanningOptions)
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.cbscanformoviemediainformation)
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.cbautocreatemovienametbn)
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.cbautocreatemovietbn)
        Me.kgAutomaticGenerationSettings.Panel.Controls.Add(Me.cbautocreatefolderjpg)
        Me.kgAutomaticGenerationSettings.Size = New System.Drawing.Size(278, 213)
        Me.kgAutomaticGenerationSettings.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgAutomaticGenerationSettings.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgAutomaticGenerationSettings.StateCommon.Border.ColorAngle = 60.0!
        Me.kgAutomaticGenerationSettings.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgAutomaticGenerationSettings.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgAutomaticGenerationSettings.StateCommon.Border.Rounding = 7
        Me.kgAutomaticGenerationSettings.StateCommon.Border.Width = 2
        Me.kgAutomaticGenerationSettings.TabIndex = 85
        '
        'cbmoviesnonforename
        '
        Me.cbmoviesnonforename.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbmoviesnonforename.Location = New System.Drawing.Point(3, 145)
        Me.cbmoviesnonforename.Name = "cbmoviesnonforename"
        Me.cbmoviesnonforename.Size = New System.Drawing.Size(251, 21)
        Me.cbmoviesnonforename.TabIndex = 7
        Me.cbmoviesnonforename.Text = "Do not move or rename invalid .nfo files"
        Me.cbmoviesnonforename.Values.ExtraText = ""
        Me.cbmoviesnonforename.Values.Image = Nothing
        Me.cbmoviesnonforename.Values.Text = "Do not move or rename invalid .nfo files"
        '
        'lblMovieScanningOptions
        '
        Me.lblMovieScanningOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMovieScanningOptions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMovieScanningOptions.Location = New System.Drawing.Point(0, 0)
        Me.lblMovieScanningOptions.Name = "lblMovieScanningOptions"
        Me.lblMovieScanningOptions.Size = New System.Drawing.Size(268, 21)
        Me.lblMovieScanningOptions.TabIndex = 6
        Me.lblMovieScanningOptions.Text = "Scanning Options"
        Me.lblMovieScanningOptions.Values.ExtraText = ""
        Me.lblMovieScanningOptions.Values.Image = Nothing
        Me.lblMovieScanningOptions.Values.Text = "Scanning Options"
        '
        'cbscanformoviemediainformation
        '
        Me.cbscanformoviemediainformation.Checked = True
        Me.cbscanformoviemediainformation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbscanformoviemediainformation.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbscanformoviemediainformation.Location = New System.Drawing.Point(3, 123)
        Me.cbscanformoviemediainformation.Name = "cbscanformoviemediainformation"
        Me.cbscanformoviemediainformation.Size = New System.Drawing.Size(223, 21)
        Me.cbscanformoviemediainformation.TabIndex = 4
        Me.cbscanformoviemediainformation.Text = "Scan for Movie Media Information"
        Me.cbscanformoviemediainformation.Values.ExtraText = ""
        Me.cbscanformoviemediainformation.Values.Image = Nothing
        Me.cbscanformoviemediainformation.Values.Text = "Scan for Movie Media Information"
        '
        'cbautocreatemovienametbn
        '
        Me.cbautocreatemovienametbn.Checked = True
        Me.cbautocreatemovienametbn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbautocreatemovienametbn.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbautocreatemovienametbn.Location = New System.Drawing.Point(3, 98)
        Me.cbautocreatemovienametbn.Name = "cbautocreatemovienametbn"
        Me.cbautocreatemovienametbn.Size = New System.Drawing.Size(254, 21)
        Me.cbautocreatemovienametbn.TabIndex = 2
        Me.cbautocreatemovienametbn.Text = "Automatically Scan for <moviename>.tbn"
        Me.cbautocreatemovienametbn.Values.ExtraText = ""
        Me.cbautocreatemovienametbn.Values.Image = Nothing
        Me.cbautocreatemovienametbn.Values.Text = "Automatically Scan for <moviename>.tbn"
        '
        'cbautocreatemovietbn
        '
        Me.cbautocreatemovietbn.Checked = True
        Me.cbautocreatemovietbn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbautocreatemovietbn.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbautocreatemovietbn.Location = New System.Drawing.Point(3, 71)
        Me.cbautocreatemovietbn.Name = "cbautocreatemovietbn"
        Me.cbautocreatemovietbn.Size = New System.Drawing.Size(215, 21)
        Me.cbautocreatemovietbn.TabIndex = 1
        Me.cbautocreatemovietbn.Text = "Automatically Scan for movie.tbn"
        Me.cbautocreatemovietbn.Values.ExtraText = ""
        Me.cbautocreatemovietbn.Values.Image = Nothing
        Me.cbautocreatemovietbn.Values.Text = "Automatically Scan for movie.tbn"
        '
        'cbautocreatefolderjpg
        '
        Me.cbautocreatefolderjpg.Checked = True
        Me.cbautocreatefolderjpg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbautocreatefolderjpg.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbautocreatefolderjpg.Location = New System.Drawing.Point(3, 44)
        Me.cbautocreatefolderjpg.Name = "cbautocreatefolderjpg"
        Me.cbautocreatefolderjpg.Size = New System.Drawing.Size(217, 21)
        Me.cbautocreatefolderjpg.TabIndex = 0
        Me.cbautocreatefolderjpg.Text = "Automatically Scan for folder.jpg"
        Me.cbautocreatefolderjpg.Values.ExtraText = ""
        Me.cbautocreatefolderjpg.Values.Image = Nothing
        Me.cbautocreatefolderjpg.Values.Text = "Automatically Scan for folder.jpg"
        '
        'kgNFOFANARTsettings
        '
        Me.kgNFOFANARTsettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgNFOFANARTsettings.Location = New System.Drawing.Point(3, 22)
        Me.kgNFOFANARTsettings.Name = "kgNFOFANARTsettings"
        '
        'kgNFOFANARTsettings.Panel
        '
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbcreateImdbIDtxt)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.lblMovieFileCreate)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbcreatemovienamedotnfo)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbSaveNFO)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbOverwriteNFO)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbcreatemovienamedottbn)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbCreateMovieNFO)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbUsefolderjpgfortbn)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbSaveSageTVBackgrounds)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbShowTBN)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbCreateMovieTbnFile)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbCreateMovieNameFanartjpg)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbCreateFolderjpg)
        Me.kgNFOFANARTsettings.Panel.Controls.Add(Me.cbCreateFanartjpgfile)
        Me.kgNFOFANARTsettings.Size = New System.Drawing.Size(479, 213)
        Me.kgNFOFANARTsettings.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgNFOFANARTsettings.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgNFOFANARTsettings.StateCommon.Border.ColorAngle = 60.0!
        Me.kgNFOFANARTsettings.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgNFOFANARTsettings.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgNFOFANARTsettings.StateCommon.Border.Rounding = 7
        Me.kgNFOFANARTsettings.StateCommon.Border.Width = 2
        Me.kgNFOFANARTsettings.TabIndex = 83
        '
        'cbcreateImdbIDtxt
        '
        Me.cbcreateImdbIDtxt.Checked = True
        Me.cbcreateImdbIDtxt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcreateImdbIDtxt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbcreateImdbIDtxt.Location = New System.Drawing.Point(7, 128)
        Me.cbcreateImdbIDtxt.Name = "cbcreateImdbIDtxt"
        Me.cbcreateImdbIDtxt.Size = New System.Drawing.Size(115, 21)
        Me.cbcreateImdbIDtxt.TabIndex = 92
        Me.cbcreateImdbIDtxt.Text = "Save imdbid.txt"
        Me.cbcreateImdbIDtxt.Values.ExtraText = ""
        Me.cbcreateImdbIDtxt.Values.Image = Nothing
        Me.cbcreateImdbIDtxt.Values.Text = "Save imdbid.txt"
        '
        'lblMovieFileCreate
        '
        Me.lblMovieFileCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMovieFileCreate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMovieFileCreate.Location = New System.Drawing.Point(0, 0)
        Me.lblMovieFileCreate.Name = "lblMovieFileCreate"
        Me.lblMovieFileCreate.Size = New System.Drawing.Size(469, 21)
        Me.lblMovieFileCreate.TabIndex = 91
        Me.lblMovieFileCreate.Text = "File Creation Options"
        Me.lblMovieFileCreate.Values.ExtraText = ""
        Me.lblMovieFileCreate.Values.Image = Nothing
        Me.lblMovieFileCreate.Values.Text = "File Creation Options"
        '
        'cbcreatemovienamedotnfo
        '
        Me.cbcreatemovienamedotnfo.Checked = True
        Me.cbcreatemovienamedotnfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcreatemovienamedotnfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbcreatemovienamedotnfo.Location = New System.Drawing.Point(27, 77)
        Me.cbcreatemovienamedotnfo.Name = "cbcreatemovienamedotnfo"
        Me.cbcreatemovienamedotnfo.Size = New System.Drawing.Size(148, 21)
        Me.cbcreatemovienamedotnfo.TabIndex = 90
        Me.cbcreatemovienamedotnfo.Text = "Save <moviename>.nfo"
        Me.cbcreatemovienamedotnfo.Values.ExtraText = ""
        Me.cbcreatemovienamedotnfo.Values.Image = Nothing
        Me.cbcreatemovienamedotnfo.Values.Text = "Save <moviename>.nfo"
        '
        'cbSaveNFO
        '
        Me.cbSaveNFO.Checked = True
        Me.cbSaveNFO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSaveNFO.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbSaveNFO.Location = New System.Drawing.Point(7, 32)
        Me.cbSaveNFO.Name = "cbSaveNFO"
        Me.cbSaveNFO.Size = New System.Drawing.Size(125, 21)
        Me.cbSaveNFO.TabIndex = 71
        Me.cbSaveNFO.Text = "Save .NFO File(s)"
        Me.cbSaveNFO.Values.ExtraText = ""
        Me.cbSaveNFO.Values.Image = Nothing
        Me.cbSaveNFO.Values.Text = "Save .NFO File(s)"
        '
        'cbOverwriteNFO
        '
        Me.cbOverwriteNFO.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbOverwriteNFO.Location = New System.Drawing.Point(7, 102)
        Me.cbOverwriteNFO.Name = "cbOverwriteNFO"
        Me.cbOverwriteNFO.Size = New System.Drawing.Size(220, 21)
        Me.cbOverwriteNFO.TabIndex = 72
        Me.cbOverwriteNFO.Text = "Overwrite both NFO if they exist"
        Me.cbOverwriteNFO.Values.ExtraText = ""
        Me.cbOverwriteNFO.Values.Image = Nothing
        Me.cbOverwriteNFO.Values.Text = "Overwrite both NFO if they exist"
        '
        'cbcreatemovienamedottbn
        '
        Me.cbcreatemovienamedottbn.Checked = True
        Me.cbcreatemovienamedottbn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcreatemovienamedottbn.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbcreatemovienamedottbn.Location = New System.Drawing.Point(245, 113)
        Me.cbcreatemovienamedottbn.Name = "cbcreatemovienamedottbn"
        Me.cbcreatemovienamedottbn.Size = New System.Drawing.Size(188, 21)
        Me.cbcreatemovienamedottbn.TabIndex = 73
        Me.cbcreatemovienamedottbn.Text = "Create <MovieName>.tbn file"
        Me.cbcreatemovienamedottbn.Values.ExtraText = ""
        Me.cbcreatemovienamedottbn.Values.Image = Nothing
        Me.cbcreatemovienamedottbn.Values.Text = "Create <MovieName>.tbn file"
        '
        'cbCreateMovieNFO
        '
        Me.cbCreateMovieNFO.Checked = True
        Me.cbCreateMovieNFO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateMovieNFO.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbCreateMovieNFO.Location = New System.Drawing.Point(27, 55)
        Me.cbCreateMovieNFO.Name = "cbCreateMovieNFO"
        Me.cbCreateMovieNFO.Size = New System.Drawing.Size(110, 21)
        Me.cbCreateMovieNFO.TabIndex = 77
        Me.cbCreateMovieNFO.Text = "Save movie.nfo"
        Me.cbCreateMovieNFO.Values.ExtraText = ""
        Me.cbCreateMovieNFO.Values.Image = Nothing
        Me.cbCreateMovieNFO.Values.Text = "Save movie.nfo"
        '
        'cbUsefolderjpgfortbn
        '
        Me.cbUsefolderjpgfortbn.Checked = True
        Me.cbUsefolderjpgfortbn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUsefolderjpgfortbn.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbUsefolderjpgfortbn.Location = New System.Drawing.Point(245, 83)
        Me.cbUsefolderjpgfortbn.Name = "cbUsefolderjpgfortbn"
        Me.cbUsefolderjpgfortbn.Size = New System.Drawing.Size(189, 21)
        Me.cbUsefolderjpgfortbn.TabIndex = 85
        Me.cbUsefolderjpgfortbn.Text = "Use Folder.jpg for TBN files"
        Me.cbUsefolderjpgfortbn.Values.ExtraText = ""
        Me.cbUsefolderjpgfortbn.Values.Image = Nothing
        Me.cbUsefolderjpgfortbn.Values.Text = "Use Folder.jpg for TBN files"
        '
        'cbSaveSageTVBackgrounds
        '
        Me.cbSaveSageTVBackgrounds.Checked = True
        Me.cbSaveSageTVBackgrounds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSaveSageTVBackgrounds.Enabled = False
        Me.cbSaveSageTVBackgrounds.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbSaveSageTVBackgrounds.Location = New System.Drawing.Point(245, 23)
        Me.cbSaveSageTVBackgrounds.Name = "cbSaveSageTVBackgrounds"
        Me.cbSaveSageTVBackgrounds.Size = New System.Drawing.Size(134, 21)
        Me.cbSaveSageTVBackgrounds.TabIndex = 79
        Me.cbSaveSageTVBackgrounds.Text = "Save Sage TV Files"
        Me.cbSaveSageTVBackgrounds.Values.ExtraText = ""
        Me.cbSaveSageTVBackgrounds.Values.Image = Nothing
        Me.cbSaveSageTVBackgrounds.Values.Text = "Save Sage TV Files"
        '
        'cbShowTBN
        '
        Me.cbShowTBN.Checked = True
        Me.cbShowTBN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowTBN.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbShowTBN.Location = New System.Drawing.Point(245, 173)
        Me.cbShowTBN.Name = "cbShowTBN"
        Me.cbShowTBN.Size = New System.Drawing.Size(192, 21)
        Me.cbShowTBN.TabIndex = 84
        Me.cbShowTBN.Text = "Show TBN for Current Movie"
        Me.cbShowTBN.Values.ExtraText = ""
        Me.cbShowTBN.Values.Image = Nothing
        Me.cbShowTBN.Values.Text = "Show TBN for Current Movie"
        '
        'cbCreateMovieTbnFile
        '
        Me.cbCreateMovieTbnFile.Checked = True
        Me.cbCreateMovieTbnFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateMovieTbnFile.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbCreateMovieTbnFile.Location = New System.Drawing.Point(245, 143)
        Me.cbCreateMovieTbnFile.Name = "cbCreateMovieTbnFile"
        Me.cbCreateMovieTbnFile.Size = New System.Drawing.Size(145, 21)
        Me.cbCreateMovieTbnFile.TabIndex = 80
        Me.cbCreateMovieTbnFile.Text = "Create movie.tbn file"
        Me.cbCreateMovieTbnFile.Values.ExtraText = ""
        Me.cbCreateMovieTbnFile.Values.Image = Nothing
        Me.cbCreateMovieTbnFile.Values.Text = "Create movie.tbn file"
        '
        'cbCreateMovieNameFanartjpg
        '
        Me.cbCreateMovieNameFanartjpg.Checked = True
        Me.cbCreateMovieNameFanartjpg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateMovieNameFanartjpg.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbCreateMovieNameFanartjpg.Location = New System.Drawing.Point(7, 180)
        Me.cbCreateMovieNameFanartjpg.Name = "cbCreateMovieNameFanartjpg"
        Me.cbCreateMovieNameFanartjpg.Size = New System.Drawing.Size(201, 21)
        Me.cbCreateMovieNameFanartjpg.TabIndex = 83
        Me.cbCreateMovieNameFanartjpg.Text = "Create <moviename>-fanart.jpg"
        Me.cbCreateMovieNameFanartjpg.Values.ExtraText = ""
        Me.cbCreateMovieNameFanartjpg.Values.Image = Nothing
        Me.cbCreateMovieNameFanartjpg.Values.Text = "Create <moviename>-fanart.jpg"
        '
        'cbCreateFolderjpg
        '
        Me.cbCreateFolderjpg.Checked = True
        Me.cbCreateFolderjpg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateFolderjpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCreateFolderjpg.ForeColor = System.Drawing.Color.Black
        Me.cbCreateFolderjpg.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbCreateFolderjpg.Location = New System.Drawing.Point(245, 53)
        Me.cbCreateFolderjpg.Name = "cbCreateFolderjpg"
        Me.cbCreateFolderjpg.Size = New System.Drawing.Size(147, 21)
        Me.cbCreateFolderjpg.TabIndex = 81
        Me.cbCreateFolderjpg.Text = "Create folder.jpg file"
        Me.cbCreateFolderjpg.Values.ExtraText = ""
        Me.cbCreateFolderjpg.Values.Image = Nothing
        Me.cbCreateFolderjpg.Values.Text = "Create folder.jpg file"
        '
        'cbCreateFanartjpgfile
        '
        Me.cbCreateFanartjpgfile.Checked = True
        Me.cbCreateFanartjpgfile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateFanartjpgfile.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbCreateFanartjpgfile.Location = New System.Drawing.Point(7, 154)
        Me.cbCreateFanartjpgfile.Name = "cbCreateFanartjpgfile"
        Me.cbCreateFanartjpgfile.Size = New System.Drawing.Size(125, 21)
        Me.cbCreateFanartjpgfile.TabIndex = 82
        Me.cbCreateFanartjpgfile.Text = "Create fanart.jpg"
        Me.cbCreateFanartjpgfile.Values.ExtraText = ""
        Me.cbCreateFanartjpgfile.Values.Image = Nothing
        Me.cbCreateFanartjpgfile.Values.Text = "Create fanart.jpg"
        '
        'kgMovieDownloadOptions
        '
        Me.kgMovieDownloadOptions.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMovieDownloadOptions.Location = New System.Drawing.Point(1, 654)
        Me.kgMovieDownloadOptions.Name = "kgMovieDownloadOptions"
        '
        'kgMovieDownloadOptions.Panel
        '
        Me.kgMovieDownloadOptions.Panel.Controls.Add(Me.kgMoviesMI)
        Me.kgMovieDownloadOptions.Panel.Controls.Add(Me.lblMovieDLO)
        Me.kgMovieDownloadOptions.Panel.Controls.Add(Me.kgMoviesDownloadGeneral)
        Me.kgMovieDownloadOptions.Panel.Controls.Add(Me.kgMovieBackgrounds)
        Me.kgMovieDownloadOptions.Panel.Controls.Add(Me.kgMoviesDownloadPosters)
        Me.kgMovieDownloadOptions.Size = New System.Drawing.Size(789, 312)
        Me.kgMovieDownloadOptions.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgMovieDownloadOptions.TabIndex = 81
        '
        'kgMoviesMI
        '
        Me.kgMoviesMI.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMoviesMI.Location = New System.Drawing.Point(2, 199)
        Me.kgMoviesMI.Name = "kgMoviesMI"
        '
        'kgMoviesMI.Panel
        '
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesInsert)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesInlay)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesCD4)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesCD3)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesCD2)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesCD1)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesBack)
        Me.kgMoviesMI.Panel.Controls.Add(Me.getMediaImagesMoviesFront)
        Me.kgMoviesMI.Panel.Controls.Add(Me.KryptonLabel5)
        Me.kgMoviesMI.Size = New System.Drawing.Size(761, 97)
        Me.kgMoviesMI.TabIndex = 94
        '
        'getMediaImagesMoviesInsert
        '
        Me.getMediaImagesMoviesInsert.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesInsert.Location = New System.Drawing.Point(581, 61)
        Me.getMediaImagesMoviesInsert.Name = "getMediaImagesMoviesInsert"
        Me.getMediaImagesMoviesInsert.Size = New System.Drawing.Size(92, 21)
        Me.getMediaImagesMoviesInsert.TabIndex = 8
        Me.getMediaImagesMoviesInsert.Text = "Get Inserts"
        Me.getMediaImagesMoviesInsert.Values.ExtraText = ""
        Me.getMediaImagesMoviesInsert.Values.Image = Nothing
        Me.getMediaImagesMoviesInsert.Values.Text = "Get Inserts"
        '
        'getMediaImagesMoviesInlay
        '
        Me.getMediaImagesMoviesInlay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesInlay.Location = New System.Drawing.Point(581, 36)
        Me.getMediaImagesMoviesInlay.Name = "getMediaImagesMoviesInlay"
        Me.getMediaImagesMoviesInlay.Size = New System.Drawing.Size(84, 21)
        Me.getMediaImagesMoviesInlay.TabIndex = 7
        Me.getMediaImagesMoviesInlay.Text = "Get Inlays"
        Me.getMediaImagesMoviesInlay.Values.ExtraText = ""
        Me.getMediaImagesMoviesInlay.Values.Image = Nothing
        Me.getMediaImagesMoviesInlay.Values.Text = "Get Inlays"
        '
        'getMediaImagesMoviesCD4
        '
        Me.getMediaImagesMoviesCD4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesCD4.Location = New System.Drawing.Point(371, 61)
        Me.getMediaImagesMoviesCD4.Name = "getMediaImagesMoviesCD4"
        Me.getMediaImagesMoviesCD4.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMoviesCD4.TabIndex = 6
        Me.getMediaImagesMoviesCD4.Text = "Get CD4 Covers"
        Me.getMediaImagesMoviesCD4.Values.ExtraText = ""
        Me.getMediaImagesMoviesCD4.Values.Image = Nothing
        Me.getMediaImagesMoviesCD4.Values.Text = "Get CD4 Covers"
        '
        'getMediaImagesMoviesCD3
        '
        Me.getMediaImagesMoviesCD3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesCD3.Location = New System.Drawing.Point(371, 36)
        Me.getMediaImagesMoviesCD3.Name = "getMediaImagesMoviesCD3"
        Me.getMediaImagesMoviesCD3.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMoviesCD3.TabIndex = 5
        Me.getMediaImagesMoviesCD3.Text = "Get CD3 Covers"
        Me.getMediaImagesMoviesCD3.Values.ExtraText = ""
        Me.getMediaImagesMoviesCD3.Values.Image = Nothing
        Me.getMediaImagesMoviesCD3.Values.Text = "Get CD3 Covers"
        '
        'getMediaImagesMoviesCD2
        '
        Me.getMediaImagesMoviesCD2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesCD2.Location = New System.Drawing.Point(179, 61)
        Me.getMediaImagesMoviesCD2.Name = "getMediaImagesMoviesCD2"
        Me.getMediaImagesMoviesCD2.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMoviesCD2.TabIndex = 4
        Me.getMediaImagesMoviesCD2.Text = "Get CD2 Covers"
        Me.getMediaImagesMoviesCD2.Values.ExtraText = ""
        Me.getMediaImagesMoviesCD2.Values.Image = Nothing
        Me.getMediaImagesMoviesCD2.Values.Text = "Get CD2 Covers"
        '
        'getMediaImagesMoviesCD1
        '
        Me.getMediaImagesMoviesCD1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesCD1.Location = New System.Drawing.Point(179, 34)
        Me.getMediaImagesMoviesCD1.Name = "getMediaImagesMoviesCD1"
        Me.getMediaImagesMoviesCD1.Size = New System.Drawing.Size(113, 21)
        Me.getMediaImagesMoviesCD1.TabIndex = 3
        Me.getMediaImagesMoviesCD1.Text = "Get CD1 Covers"
        Me.getMediaImagesMoviesCD1.Values.ExtraText = ""
        Me.getMediaImagesMoviesCD1.Values.Image = Nothing
        Me.getMediaImagesMoviesCD1.Values.Text = "Get CD1 Covers"
        '
        'getMediaImagesMoviesBack
        '
        Me.getMediaImagesMoviesBack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesBack.Location = New System.Drawing.Point(7, 61)
        Me.getMediaImagesMoviesBack.Name = "getMediaImagesMoviesBack"
        Me.getMediaImagesMoviesBack.Size = New System.Drawing.Size(118, 21)
        Me.getMediaImagesMoviesBack.TabIndex = 2
        Me.getMediaImagesMoviesBack.Text = "Get Back Covers"
        Me.getMediaImagesMoviesBack.Values.ExtraText = ""
        Me.getMediaImagesMoviesBack.Values.Image = Nothing
        Me.getMediaImagesMoviesBack.Values.Text = "Get Back Covers"
        '
        'getMediaImagesMoviesFront
        '
        Me.getMediaImagesMoviesFront.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMoviesFront.Location = New System.Drawing.Point(7, 34)
        Me.getMediaImagesMoviesFront.Name = "getMediaImagesMoviesFront"
        Me.getMediaImagesMoviesFront.Size = New System.Drawing.Size(123, 21)
        Me.getMediaImagesMoviesFront.TabIndex = 1
        Me.getMediaImagesMoviesFront.Text = "Get Front Covers"
        Me.getMediaImagesMoviesFront.Values.ExtraText = ""
        Me.getMediaImagesMoviesFront.Values.Image = Nothing
        Me.getMediaImagesMoviesFront.Values.Text = "Get Front Covers"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(749, 21)
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Text = "Media Images"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Media Images"
        '
        'lblMovieDLO
        '
        Me.lblMovieDLO.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMovieDLO.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMovieDLO.Location = New System.Drawing.Point(0, 0)
        Me.lblMovieDLO.Name = "lblMovieDLO"
        Me.lblMovieDLO.Size = New System.Drawing.Size(777, 21)
        Me.lblMovieDLO.TabIndex = 98
        Me.lblMovieDLO.Text = "Movie Download Options"
        Me.lblMovieDLO.Values.ExtraText = ""
        Me.lblMovieDLO.Values.Image = Nothing
        Me.lblMovieDLO.Values.Text = "Movie Download Options"
        '
        'kgMoviesDownloadGeneral
        '
        Me.kgMoviesDownloadGeneral.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMoviesDownloadGeneral.Location = New System.Drawing.Point(1, 28)
        Me.kgMoviesDownloadGeneral.Name = "kgMoviesDownloadGeneral"
        '
        'kgMoviesDownloadGeneral.Panel
        '
        Me.kgMoviesDownloadGeneral.Panel.Controls.Add(Me.lblMoviesDownloadGeneral)
        Me.kgMoviesDownloadGeneral.Panel.Controls.Add(Me.cbGetTMDBInfo)
        Me.kgMoviesDownloadGeneral.Panel.Controls.Add(Me.cbGetIMDBInfo)
        Me.kgMoviesDownloadGeneral.Size = New System.Drawing.Size(200, 165)
        Me.kgMoviesDownloadGeneral.TabIndex = 97
        '
        'lblMoviesDownloadGeneral
        '
        Me.lblMoviesDownloadGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMoviesDownloadGeneral.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMoviesDownloadGeneral.Location = New System.Drawing.Point(0, 0)
        Me.lblMoviesDownloadGeneral.Name = "lblMoviesDownloadGeneral"
        Me.lblMoviesDownloadGeneral.Size = New System.Drawing.Size(188, 21)
        Me.lblMoviesDownloadGeneral.TabIndex = 0
        Me.lblMoviesDownloadGeneral.Text = "General"
        Me.lblMoviesDownloadGeneral.Values.ExtraText = ""
        Me.lblMoviesDownloadGeneral.Values.Image = Nothing
        Me.lblMoviesDownloadGeneral.Values.Text = "General"
        '
        'cbGetTMDBInfo
        '
        Me.cbGetTMDBInfo.Checked = True
        Me.cbGetTMDBInfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetTMDBInfo.Enabled = False
        Me.cbGetTMDBInfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetTMDBInfo.Location = New System.Drawing.Point(3, 31)
        Me.cbGetTMDBInfo.Name = "cbGetTMDBInfo"
        Me.cbGetTMDBInfo.Size = New System.Drawing.Size(114, 21)
        Me.cbGetTMDBInfo.TabIndex = 79
        Me.cbGetTMDBInfo.Text = "Get TMDB Info"
        Me.cbGetTMDBInfo.Values.ExtraText = ""
        Me.cbGetTMDBInfo.Values.Image = Nothing
        Me.cbGetTMDBInfo.Values.Text = "Get TMDB Info"
        '
        'cbGetIMDBInfo
        '
        Me.cbGetIMDBInfo.Checked = True
        Me.cbGetIMDBInfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetIMDBInfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetIMDBInfo.Location = New System.Drawing.Point(3, 56)
        Me.cbGetIMDBInfo.Name = "cbGetIMDBInfo"
        Me.cbGetIMDBInfo.Size = New System.Drawing.Size(112, 21)
        Me.cbGetIMDBInfo.TabIndex = 38
        Me.cbGetIMDBInfo.Text = "Get IMDB Info"
        Me.cbGetIMDBInfo.Values.ExtraText = ""
        Me.cbGetIMDBInfo.Values.Image = Nothing
        Me.cbGetIMDBInfo.Values.Text = "Get IMDB Info"
        '
        'kgMovieBackgrounds
        '
        Me.kgMovieBackgrounds.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMovieBackgrounds.Location = New System.Drawing.Point(223, 28)
        Me.kgMovieBackgrounds.Name = "kgMovieBackgrounds"
        '
        'kgMovieBackgrounds.Panel
        '
        Me.kgMovieBackgrounds.Panel.Controls.Add(Me.lblFanart)
        Me.kgMovieBackgrounds.Panel.Controls.Add(Me.cbGetFanart)
        Me.kgMovieBackgrounds.Size = New System.Drawing.Size(193, 165)
        Me.kgMovieBackgrounds.TabIndex = 96
        '
        'lblFanart
        '
        Me.lblFanart.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFanart.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblFanart.Location = New System.Drawing.Point(0, 0)
        Me.lblFanart.Name = "lblFanart"
        Me.lblFanart.Size = New System.Drawing.Size(181, 21)
        Me.lblFanart.TabIndex = 0
        Me.lblFanart.Text = "Backgrounds"
        Me.lblFanart.Values.ExtraText = ""
        Me.lblFanart.Values.Image = Nothing
        Me.lblFanart.Values.Text = "Backgrounds"
        '
        'cbGetFanart
        '
        Me.cbGetFanart.Checked = True
        Me.cbGetFanart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetFanart.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetFanart.Location = New System.Drawing.Point(5, 30)
        Me.cbGetFanart.Name = "cbGetFanart"
        Me.cbGetFanart.Size = New System.Drawing.Size(126, 21)
        Me.cbGetFanart.TabIndex = 70
        Me.cbGetFanart.Text = "Get TMDB Fanart"
        Me.cbGetFanart.Values.ExtraText = ""
        Me.cbGetFanart.Values.Image = Nothing
        Me.cbGetFanart.Values.Text = "Get TMDB Fanart"
        '
        'kgMoviesDownloadPosters
        '
        Me.kgMoviesDownloadPosters.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMoviesDownloadPosters.Location = New System.Drawing.Point(438, 28)
        Me.kgMoviesDownloadPosters.Name = "kgMoviesDownloadPosters"
        '
        'kgMoviesDownloadPosters.Panel
        '
        Me.kgMoviesDownloadPosters.Panel.Controls.Add(Me.lblGetPostersFrom)
        Me.kgMoviesDownloadPosters.Panel.Controls.Add(Me.cbGetcaldnPosters)
        Me.kgMoviesDownloadPosters.Panel.Controls.Add(Me.cbDownloadPoster)
        Me.kgMoviesDownloadPosters.Panel.Controls.Add(Me.cbGetTMDBPosters)
        Me.kgMoviesDownloadPosters.Panel.Controls.Add(Me.cbgetncposters)
        Me.kgMoviesDownloadPosters.Size = New System.Drawing.Size(325, 165)
        Me.kgMoviesDownloadPosters.TabIndex = 95
        '
        'lblGetPostersFrom
        '
        Me.lblGetPostersFrom.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGetPostersFrom.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblGetPostersFrom.Location = New System.Drawing.Point(0, 0)
        Me.lblGetPostersFrom.Name = "lblGetPostersFrom"
        Me.lblGetPostersFrom.Size = New System.Drawing.Size(313, 21)
        Me.lblGetPostersFrom.TabIndex = 0
        Me.lblGetPostersFrom.Text = "Posters"
        Me.lblGetPostersFrom.Values.ExtraText = ""
        Me.lblGetPostersFrom.Values.Image = Nothing
        Me.lblGetPostersFrom.Values.Text = "Posters"
        '
        'cbGetcaldnPosters
        '
        Me.cbGetcaldnPosters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetcaldnPosters.Location = New System.Drawing.Point(3, 100)
        Me.cbGetcaldnPosters.Name = "cbGetcaldnPosters"
        Me.cbGetcaldnPosters.Size = New System.Drawing.Size(241, 21)
        Me.cbGetcaldnPosters.TabIndex = 81
        Me.cbGetcaldnPosters.Text = "Get DVD Covers from calagregory.net"
        Me.cbGetcaldnPosters.Values.ExtraText = ""
        Me.cbGetcaldnPosters.Values.Image = Nothing
        Me.cbGetcaldnPosters.Values.Text = "Get DVD Covers from calagregory.net"
        '
        'cbDownloadPoster
        '
        Me.cbDownloadPoster.Checked = True
        Me.cbDownloadPoster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDownloadPoster.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbDownloadPoster.Location = New System.Drawing.Point(3, 34)
        Me.cbDownloadPoster.Name = "cbDownloadPoster"
        Me.cbDownloadPoster.Size = New System.Drawing.Size(160, 21)
        Me.cbDownloadPoster.TabIndex = 37
        Me.cbDownloadPoster.Text = "Get IMPawards Posters"
        Me.cbDownloadPoster.Values.ExtraText = ""
        Me.cbDownloadPoster.Values.Image = Nothing
        Me.cbDownloadPoster.Values.Text = "Get IMPawards Posters"
        '
        'cbGetTMDBPosters
        '
        Me.cbGetTMDBPosters.Checked = True
        Me.cbGetTMDBPosters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetTMDBPosters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetTMDBPosters.Location = New System.Drawing.Point(3, 56)
        Me.cbGetTMDBPosters.Name = "cbGetTMDBPosters"
        Me.cbGetTMDBPosters.Size = New System.Drawing.Size(131, 21)
        Me.cbGetTMDBPosters.TabIndex = 78
        Me.cbGetTMDBPosters.Text = "Get TMDB Posters"
        Me.cbGetTMDBPosters.Values.ExtraText = ""
        Me.cbGetTMDBPosters.Values.Image = Nothing
        Me.cbGetTMDBPosters.Values.Text = "Get TMDB Posters"
        '
        'cbgetncposters
        '
        Me.cbgetncposters.Enabled = False
        Me.cbgetncposters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbgetncposters.Location = New System.Drawing.Point(3, 78)
        Me.cbgetncposters.Name = "cbgetncposters"
        Me.cbgetncposters.Size = New System.Drawing.Size(161, 21)
        Me.cbgetncposters.TabIndex = 80
        Me.cbgetncposters.Text = "Get NiceCovers Posters"
        Me.cbgetncposters.Values.ExtraText = ""
        Me.cbgetncposters.Values.Image = Nothing
        Me.cbgetncposters.Values.Text = "Get NiceCovers Posters"
        Me.cbgetncposters.Visible = False
        '
        'kgNameFilter
        '
        Me.kgNameFilter.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgNameFilter.Location = New System.Drawing.Point(6, 30)
        Me.kgNameFilter.Name = "kgNameFilter"
        '
        'kgNameFilter.Panel
        '
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterFolderFileLevel)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterUnderscoreDot)
        Me.kgNameFilter.Panel.Controls.Add(Me.lblFolderLevelNameFilters)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbIgnoreparans)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterYears)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilter1080i)
        Me.kgNameFilter.Panel.Controls.Add(Me.tbCustomFilter1)
        Me.kgNameFilter.Panel.Controls.Add(Me.Label5)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterH264)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterLq)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterHidef)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterDVD)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilter1080p)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterDivx)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilter720p)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterXvid)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterCustom4)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterAvi)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterCustom3)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterBluRay)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterCustom5)
        Me.kgNameFilter.Panel.Controls.Add(Me.tbCustomFilter2)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterCustom2)
        Me.kgNameFilter.Panel.Controls.Add(Me.tbCustomFilter3)
        Me.kgNameFilter.Panel.Controls.Add(Me.tbCustomFilter5)
        Me.kgNameFilter.Panel.Controls.Add(Me.tbCustomFilter4)
        Me.kgNameFilter.Panel.Controls.Add(Me.cbFilterCustom1)
        Me.kgNameFilter.Size = New System.Drawing.Size(774, 432)
        Me.kgNameFilter.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgNameFilter.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgNameFilter.StateCommon.Border.ColorAngle = 60.0!
        Me.kgNameFilter.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgNameFilter.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgNameFilter.StateCommon.Border.Rounding = 7
        Me.kgNameFilter.StateCommon.Border.Width = 2
        Me.kgNameFilter.TabIndex = 0
        '
        'cbFilterFolderFileLevel
        '
        Me.cbFilterFolderFileLevel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterFolderFileLevel.Location = New System.Drawing.Point(321, 393)
        Me.cbFilterFolderFileLevel.Name = "cbFilterFolderFileLevel"
        Me.cbFilterFolderFileLevel.Size = New System.Drawing.Size(256, 21)
        Me.cbFilterFolderFileLevel.TabIndex = 73
        Me.cbFilterFolderFileLevel.Text = "Apply File Level Filters to Folder Names"
        Me.cbFilterFolderFileLevel.Values.ExtraText = ""
        Me.cbFilterFolderFileLevel.Values.Image = Nothing
        Me.cbFilterFolderFileLevel.Values.Text = "Apply File Level Filters to Folder Names"
        '
        'cbFilterUnderscoreDot
        '
        Me.cbFilterUnderscoreDot.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterUnderscoreDot.Location = New System.Drawing.Point(8, 393)
        Me.cbFilterUnderscoreDot.Name = "cbFilterUnderscoreDot"
        Me.cbFilterUnderscoreDot.Size = New System.Drawing.Size(174, 21)
        Me.cbFilterUnderscoreDot.TabIndex = 72
        Me.cbFilterUnderscoreDot.Text = "Replace _ and . with space"
        Me.cbFilterUnderscoreDot.Values.ExtraText = ""
        Me.cbFilterUnderscoreDot.Values.Image = Nothing
        Me.cbFilterUnderscoreDot.Values.Text = "Replace _ and . with space"
        '
        'lblFolderLevelNameFilters
        '
        Me.lblFolderLevelNameFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFolderLevelNameFilters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblFolderLevelNameFilters.Location = New System.Drawing.Point(0, 0)
        Me.lblFolderLevelNameFilters.Name = "lblFolderLevelNameFilters"
        Me.lblFolderLevelNameFilters.Size = New System.Drawing.Size(764, 21)
        Me.lblFolderLevelNameFilters.TabIndex = 71
        Me.lblFolderLevelNameFilters.Text = "Folder Level Name Filters"
        Me.lblFolderLevelNameFilters.Values.ExtraText = ""
        Me.lblFolderLevelNameFilters.Values.Image = Nothing
        Me.lblFolderLevelNameFilters.Values.Text = "Folder Level Name Filters"
        '
        'cbIgnoreparans
        '
        Me.cbIgnoreparans.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbIgnoreparans.Location = New System.Drawing.Point(173, 323)
        Me.cbIgnoreparans.Name = "cbIgnoreparans"
        Me.cbIgnoreparans.Size = New System.Drawing.Size(93, 21)
        Me.cbIgnoreparans.TabIndex = 70
        Me.cbIgnoreparans.Text = "Ignore  ( * )"
        Me.cbIgnoreparans.Values.ExtraText = ""
        Me.cbIgnoreparans.Values.Image = Nothing
        Me.cbIgnoreparans.Values.Text = "Ignore  ( * )"
        '
        'cbFilterYears
        '
        Me.cbFilterYears.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterYears.Location = New System.Drawing.Point(8, 354)
        Me.cbFilterYears.Name = "cbFilterYears"
        Me.cbFilterYears.Size = New System.Drawing.Size(323, 21)
        Me.cbFilterYears.TabIndex = 69
        Me.cbFilterYears.Text = "Ignore (%YEAR%) where year is 4 digits i.e.  (2008)"
        Me.cbFilterYears.Values.ExtraText = ""
        Me.cbFilterYears.Values.Image = Nothing
        Me.cbFilterYears.Values.Text = "Ignore (%YEAR%) where year is 4 digits i.e.  (2008)"
        '
        'cbFilter1080i
        '
        Me.cbFilter1080i.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilter1080i.Location = New System.Drawing.Point(8, 323)
        Me.cbFilter1080i.Name = "cbFilter1080i"
        Me.cbFilter1080i.Size = New System.Drawing.Size(107, 21)
        Me.cbFilter1080i.TabIndex = 68
        Me.cbFilter1080i.Text = "Ignore (1080i)"
        Me.cbFilter1080i.Values.ExtraText = ""
        Me.cbFilter1080i.Values.Image = Nothing
        Me.cbFilter1080i.Values.Text = "Ignore (1080i)"
        '
        'tbCustomFilter1
        '
        Me.tbCustomFilter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter1.Location = New System.Drawing.Point(412, 138)
        Me.tbCustomFilter1.Name = "tbCustomFilter1"
        Me.tbCustomFilter1.Size = New System.Drawing.Size(157, 20)
        Me.tbCustomFilter1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.Label5.Location = New System.Drawing.Point(3, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(577, 88)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.Values.ExtraText = ""
        Me.Label5.Values.Image = Nothing
        Me.Label5.Values.Text = resources.GetString("Label5.Values.Text")
        '
        'cbFilterH264
        '
        Me.cbFilterH264.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterH264.Location = New System.Drawing.Point(173, 284)
        Me.cbFilterH264.Name = "cbFilterH264"
        Me.cbFilterH264.Size = New System.Drawing.Size(107, 21)
        Me.cbFilterH264.TabIndex = 37
        Me.cbFilterH264.Text = "Ignore (H264)"
        Me.cbFilterH264.Values.ExtraText = ""
        Me.cbFilterH264.Values.Image = Nothing
        Me.cbFilterH264.Values.Text = "Ignore (H264)"
        '
        'cbFilterLq
        '
        Me.cbFilterLq.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterLq.Location = New System.Drawing.Point(173, 245)
        Me.cbFilterLq.Name = "cbFilterLq"
        Me.cbFilterLq.Size = New System.Drawing.Size(85, 21)
        Me.cbFilterLq.TabIndex = 36
        Me.cbFilterLq.Text = "Ignore (lq)"
        Me.cbFilterLq.Values.ExtraText = ""
        Me.cbFilterLq.Values.Image = Nothing
        Me.cbFilterLq.Values.Text = "Ignore (lq)"
        '
        'cbFilterHidef
        '
        Me.cbFilterHidef.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterHidef.Location = New System.Drawing.Point(173, 206)
        Me.cbFilterHidef.Name = "cbFilterHidef"
        Me.cbFilterHidef.Size = New System.Drawing.Size(106, 21)
        Me.cbFilterHidef.TabIndex = 26
        Me.cbFilterHidef.Text = "Ignore (hidef)"
        Me.cbFilterHidef.Values.ExtraText = ""
        Me.cbFilterHidef.Values.Image = Nothing
        Me.cbFilterHidef.Values.Text = "Ignore (hidef)"
        '
        'cbFilterDVD
        '
        Me.cbFilterDVD.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterDVD.Location = New System.Drawing.Point(8, 245)
        Me.cbFilterDVD.Name = "cbFilterDVD"
        Me.cbFilterDVD.Size = New System.Drawing.Size(101, 21)
        Me.cbFilterDVD.TabIndex = 19
        Me.cbFilterDVD.Text = "Ignore (DVD)"
        Me.cbFilterDVD.Values.ExtraText = ""
        Me.cbFilterDVD.Values.Image = Nothing
        Me.cbFilterDVD.Values.Text = "Ignore (DVD)"
        '
        'cbFilter1080p
        '
        Me.cbFilter1080p.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilter1080p.Location = New System.Drawing.Point(173, 167)
        Me.cbFilter1080p.Name = "cbFilter1080p"
        Me.cbFilter1080p.Size = New System.Drawing.Size(110, 21)
        Me.cbFilter1080p.TabIndex = 25
        Me.cbFilter1080p.Text = "Ignore (1080p)"
        Me.cbFilter1080p.Values.ExtraText = ""
        Me.cbFilter1080p.Values.Image = Nothing
        Me.cbFilter1080p.Values.Text = "Ignore (1080p)"
        '
        'cbFilterDivx
        '
        Me.cbFilterDivx.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterDivx.Location = New System.Drawing.Point(8, 128)
        Me.cbFilterDivx.Name = "cbFilterDivx"
        Me.cbFilterDivx.Size = New System.Drawing.Size(101, 21)
        Me.cbFilterDivx.TabIndex = 20
        Me.cbFilterDivx.Text = "Ignore (Divx)"
        Me.cbFilterDivx.Values.ExtraText = ""
        Me.cbFilterDivx.Values.Image = Nothing
        Me.cbFilterDivx.Values.Text = "Ignore (Divx)"
        '
        'cbFilter720p
        '
        Me.cbFilter720p.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilter720p.Location = New System.Drawing.Point(173, 128)
        Me.cbFilter720p.Name = "cbFilter720p"
        Me.cbFilter720p.Size = New System.Drawing.Size(104, 21)
        Me.cbFilter720p.TabIndex = 24
        Me.cbFilter720p.Text = "Ignore (720p)"
        Me.cbFilter720p.Values.ExtraText = ""
        Me.cbFilter720p.Values.Image = Nothing
        Me.cbFilter720p.Values.Text = "Ignore (720p)"
        '
        'cbFilterXvid
        '
        Me.cbFilterXvid.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterXvid.Location = New System.Drawing.Point(8, 167)
        Me.cbFilterXvid.Name = "cbFilterXvid"
        Me.cbFilterXvid.Size = New System.Drawing.Size(99, 21)
        Me.cbFilterXvid.TabIndex = 21
        Me.cbFilterXvid.Text = "Ignore (xvid)"
        Me.cbFilterXvid.Values.ExtraText = ""
        Me.cbFilterXvid.Values.Image = Nothing
        Me.cbFilterXvid.Values.Text = "Ignore (xvid)"
        '
        'cbFilterCustom4
        '
        Me.cbFilterCustom4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterCustom4.Location = New System.Drawing.Point(575, 250)
        Me.cbFilterCustom4.Name = "cbFilterCustom4"
        Me.cbFilterCustom4.Size = New System.Drawing.Size(151, 21)
        Me.cbFilterCustom4.TabIndex = 35
        Me.cbFilterCustom4.Text = "Ignore Custom Text 4"
        Me.cbFilterCustom4.Values.ExtraText = ""
        Me.cbFilterCustom4.Values.Image = Nothing
        Me.cbFilterCustom4.Values.Text = "Ignore Custom Text 4"
        '
        'cbFilterAvi
        '
        Me.cbFilterAvi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterAvi.Location = New System.Drawing.Point(8, 206)
        Me.cbFilterAvi.Name = "cbFilterAvi"
        Me.cbFilterAvi.Size = New System.Drawing.Size(91, 21)
        Me.cbFilterAvi.TabIndex = 22
        Me.cbFilterAvi.Text = "Ignore (avi)"
        Me.cbFilterAvi.Values.ExtraText = ""
        Me.cbFilterAvi.Values.Image = Nothing
        Me.cbFilterAvi.Values.Text = "Ignore (avi)"
        '
        'cbFilterCustom3
        '
        Me.cbFilterCustom3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterCustom3.Location = New System.Drawing.Point(575, 210)
        Me.cbFilterCustom3.Name = "cbFilterCustom3"
        Me.cbFilterCustom3.Size = New System.Drawing.Size(151, 21)
        Me.cbFilterCustom3.TabIndex = 34
        Me.cbFilterCustom3.Text = "Ignore Custom Text 3"
        Me.cbFilterCustom3.Values.ExtraText = ""
        Me.cbFilterCustom3.Values.Image = Nothing
        Me.cbFilterCustom3.Values.Text = "Ignore Custom Text 3"
        '
        'cbFilterBluRay
        '
        Me.cbFilterBluRay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterBluRay.Location = New System.Drawing.Point(8, 284)
        Me.cbFilterBluRay.Name = "cbFilterBluRay"
        Me.cbFilterBluRay.Size = New System.Drawing.Size(117, 21)
        Me.cbFilterBluRay.TabIndex = 23
        Me.cbFilterBluRay.Text = "Ignore (Blu-ray)"
        Me.cbFilterBluRay.Values.ExtraText = ""
        Me.cbFilterBluRay.Values.Image = Nothing
        Me.cbFilterBluRay.Values.Text = "Ignore (Blu-ray)"
        '
        'cbFilterCustom5
        '
        Me.cbFilterCustom5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterCustom5.Location = New System.Drawing.Point(575, 282)
        Me.cbFilterCustom5.Name = "cbFilterCustom5"
        Me.cbFilterCustom5.Size = New System.Drawing.Size(151, 21)
        Me.cbFilterCustom5.TabIndex = 65
        Me.cbFilterCustom5.Text = "Ignore Custom Text 5"
        Me.cbFilterCustom5.Values.ExtraText = ""
        Me.cbFilterCustom5.Values.Image = Nothing
        Me.cbFilterCustom5.Values.Text = "Ignore Custom Text 5"
        '
        'tbCustomFilter2
        '
        Me.tbCustomFilter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter2.Location = New System.Drawing.Point(412, 174)
        Me.tbCustomFilter2.Name = "tbCustomFilter2"
        Me.tbCustomFilter2.Size = New System.Drawing.Size(157, 20)
        Me.tbCustomFilter2.TabIndex = 27
        '
        'cbFilterCustom2
        '
        Me.cbFilterCustom2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterCustom2.Location = New System.Drawing.Point(575, 178)
        Me.cbFilterCustom2.Name = "cbFilterCustom2"
        Me.cbFilterCustom2.Size = New System.Drawing.Size(151, 21)
        Me.cbFilterCustom2.TabIndex = 33
        Me.cbFilterCustom2.Text = "Ignore Custom Text 2"
        Me.cbFilterCustom2.Values.ExtraText = ""
        Me.cbFilterCustom2.Values.Image = Nothing
        Me.cbFilterCustom2.Values.Text = "Ignore Custom Text 2"
        '
        'tbCustomFilter3
        '
        Me.tbCustomFilter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter3.Location = New System.Drawing.Point(412, 210)
        Me.tbCustomFilter3.Name = "tbCustomFilter3"
        Me.tbCustomFilter3.Size = New System.Drawing.Size(157, 20)
        Me.tbCustomFilter3.TabIndex = 28
        '
        'tbCustomFilter5
        '
        Me.tbCustomFilter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter5.Location = New System.Drawing.Point(412, 282)
        Me.tbCustomFilter5.Name = "tbCustomFilter5"
        Me.tbCustomFilter5.Size = New System.Drawing.Size(157, 20)
        Me.tbCustomFilter5.TabIndex = 66
        '
        'tbCustomFilter4
        '
        Me.tbCustomFilter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter4.Location = New System.Drawing.Point(412, 246)
        Me.tbCustomFilter4.Name = "tbCustomFilter4"
        Me.tbCustomFilter4.Size = New System.Drawing.Size(157, 20)
        Me.tbCustomFilter4.TabIndex = 29
        '
        'cbFilterCustom1
        '
        Me.cbFilterCustom1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterCustom1.Location = New System.Drawing.Point(575, 138)
        Me.cbFilterCustom1.Name = "cbFilterCustom1"
        Me.cbFilterCustom1.Size = New System.Drawing.Size(149, 21)
        Me.cbFilterCustom1.TabIndex = 32
        Me.cbFilterCustom1.Text = "Ignore Custom Text 1"
        Me.cbFilterCustom1.Values.ExtraText = ""
        Me.cbFilterCustom1.Values.Image = Nothing
        Me.cbFilterCustom1.Values.Text = "Ignore Custom Text 1"
        '
        'kgTQQIconsGroup
        '
        Me.kgTQQIconsGroup.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgTQQIconsGroup.Location = New System.Drawing.Point(6, 6)
        Me.kgTQQIconsGroup.Name = "kgTQQIconsGroup"
        '
        'kgTQQIconsGroup.Panel
        '
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.lblGMaxCached)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.lblGQuality)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf3s0)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.klblTQQIconsLbl)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf1s9)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf1s0)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf2s0)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.Label1)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf1s3)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf2s10)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbMaxIconsToDisplay)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbMaxIconPerStyle)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf2s8)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbDlFormat)
        Me.kgTQQIconsGroup.Panel.Controls.Add(Me.cbf2s2)
        Me.kgTQQIconsGroup.Size = New System.Drawing.Size(445, 290)
        Me.kgTQQIconsGroup.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgTQQIconsGroup.TabIndex = 84
        '
        'lblGMaxCached
        '
        Me.lblGMaxCached.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblGMaxCached.Location = New System.Drawing.Point(184, 216)
        Me.lblGMaxCached.Name = "lblGMaxCached"
        Me.lblGMaxCached.Size = New System.Drawing.Size(192, 21)
        Me.lblGMaxCached.TabIndex = 64
        Me.lblGMaxCached.Text = "Max Number of Cached Images"
        Me.lblGMaxCached.Values.ExtraText = ""
        Me.lblGMaxCached.Values.Image = Nothing
        Me.lblGMaxCached.Values.Text = "Max Number of Cached Images"
        '
        'lblGQuality
        '
        Me.lblGQuality.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblGQuality.Location = New System.Drawing.Point(119, 185)
        Me.lblGQuality.Name = "lblGQuality"
        Me.lblGQuality.Size = New System.Drawing.Size(109, 21)
        Me.lblGQuality.TabIndex = 63
        Me.lblGQuality.Text = "Quality of Image"
        Me.lblGQuality.Values.ExtraText = ""
        Me.lblGQuality.Values.Image = Nothing
        Me.lblGQuality.Values.Text = "Quality of Image"
        '
        'cbf3s0
        '
        Me.cbf3s0.Enabled = False
        Me.cbf3s0.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf3s0.Location = New System.Drawing.Point(207, 90)
        Me.cbf3s0.Name = "cbf3s0"
        Me.cbf3s0.Size = New System.Drawing.Size(81, 21)
        Me.cbf3s0.TabIndex = 54
        Me.cbf3s0.Text = "Tall Icons"
        Me.cbf3s0.Values.ExtraText = ""
        Me.cbf3s0.Values.Image = Nothing
        Me.cbf3s0.Values.Text = "Tall Icons"
        Me.cbf3s0.Visible = False
        '
        'klblTQQIconsLbl
        '
        Me.klblTQQIconsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblTQQIconsLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblTQQIconsLbl.Location = New System.Drawing.Point(0, 0)
        Me.klblTQQIconsLbl.Name = "klblTQQIconsLbl"
        Me.klblTQQIconsLbl.Size = New System.Drawing.Size(433, 21)
        Me.klblTQQIconsLbl.TabIndex = 0
        Me.klblTQQIconsLbl.Text = "Media Icons - Wide Images / 3d Box Shots, etc."
        Me.klblTQQIconsLbl.Values.ExtraText = ""
        Me.klblTQQIconsLbl.Values.Image = Nothing
        Me.klblTQQIconsLbl.Values.Text = "Media Icons - Wide Images / 3d Box Shots, etc."
        '
        'cbf1s9
        '
        Me.cbf1s9.Checked = True
        Me.cbf1s9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf1s9.Location = New System.Drawing.Point(207, 62)
        Me.cbf1s9.Name = "cbf1s9"
        Me.cbf1s9.Size = New System.Drawing.Size(93, 21)
        Me.cbf1s9.TabIndex = 57
        Me.cbf1s9.Text = "Token Style"
        Me.cbf1s9.Values.ExtraText = ""
        Me.cbf1s9.Values.Image = Nothing
        Me.cbf1s9.Values.Text = "Token Style"
        '
        'cbf1s0
        '
        Me.cbf1s0.Checked = True
        Me.cbf1s0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s0.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf1s0.Location = New System.Drawing.Point(2, 35)
        Me.cbf1s0.Name = "cbf1s0"
        Me.cbf1s0.Size = New System.Drawing.Size(100, 21)
        Me.cbf1s0.TabIndex = 55
        Me.cbf1s0.Text = "Square Icons"
        Me.cbf1s0.Values.ExtraText = ""
        Me.cbf1s0.Values.Image = Nothing
        Me.cbf1s0.Values.Text = "Square Icons"
        '
        'cbf2s0
        '
        Me.cbf2s0.Checked = True
        Me.cbf2s0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s0.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf2s0.Location = New System.Drawing.Point(2, 62)
        Me.cbf2s0.Name = "cbf2s0"
        Me.cbf2s0.Size = New System.Drawing.Size(54, 21)
        Me.cbf2s0.TabIndex = 53
        Me.cbf2s0.Text = "Wide"
        Me.cbf2s0.Values.ExtraText = ""
        Me.cbf2s0.Values.Image = Nothing
        Me.cbf2s0.Values.Text = "Wide"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.Label1.Location = New System.Drawing.Point(70, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Max Icons to Display"
        Me.Label1.Values.ExtraText = ""
        Me.Label1.Values.Image = Nothing
        Me.Label1.Values.Text = "Max Icons to Display"
        '
        'cbf1s3
        '
        Me.cbf1s3.Checked = True
        Me.cbf1s3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf1s3.Location = New System.Drawing.Point(207, 35)
        Me.cbf1s3.Name = "cbf1s3"
        Me.cbf1s3.Size = New System.Drawing.Size(77, 21)
        Me.cbf1s3.TabIndex = 56
        Me.cbf1s3.Text = "Box Shot"
        Me.cbf1s3.Values.ExtraText = ""
        Me.cbf1s3.Values.Image = Nothing
        Me.cbf1s3.Values.Text = "Box Shot"
        '
        'cbf2s10
        '
        Me.cbf2s10.Checked = True
        Me.cbf2s10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf2s10.Location = New System.Drawing.Point(2, 120)
        Me.cbf2s10.Name = "cbf2s10"
        Me.cbf2s10.Size = New System.Drawing.Size(188, 21)
        Me.cbf2s10.TabIndex = 62
        Me.cbf2s10.Text = "Wide Rounded Shadow Glass"
        Me.cbf2s10.Values.ExtraText = ""
        Me.cbf2s10.Values.Image = Nothing
        Me.cbf2s10.Values.Text = "Wide Rounded Shadow Glass"
        '
        'cbMaxIconsToDisplay
        '
        Me.cbMaxIconsToDisplay.FormattingEnabled = True
        Me.cbMaxIconsToDisplay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cbMaxIconsToDisplay.Location = New System.Drawing.Point(13, 247)
        Me.cbMaxIconsToDisplay.Name = "cbMaxIconsToDisplay"
        Me.cbMaxIconsToDisplay.Size = New System.Drawing.Size(54, 21)
        Me.cbMaxIconsToDisplay.TabIndex = 36
        Me.cbMaxIconsToDisplay.Text = "8"
        '
        'cbMaxIconPerStyle
        '
        Me.cbMaxIconPerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaxIconPerStyle.FormattingEnabled = True
        Me.cbMaxIconPerStyle.Items.AddRange(New Object() {"Cache 1 Icon Per Type", "Cache 2 Icons Per Type", "Cache 3 Icons Per Type", "Cache 4 Icons Per Type", "Cache 5 Icons Per Type", "Cache 6 Icons Per Type", "Cache 7 Icons Per Type", "Cache 8 Icons Per Type", "Cache 9 Icons Per Type", "Cache 10 Icons Per Type", "Cache 11 Icons Per Type", "Cache 12 Icons Per Type", "Cache 13 Icons Per Type", "Cache 14 Icons Per Type", "Cache 15 Icons Per Type", "Cache 16 Icons Per Type", "Cache 17 Icons Per Type", "Cache 18 Icons Per Type", "Cache 19 Icons Per Type", "Cache 20 Icons Per Type", "Cache 21 Icons Per Type", "Cache 22 Icons Per Type", "Cache 23 Icons Per Type", "Cache 24 Icons Per Type", "Cache 25 Icons Per Type", "Cache 26 Icons Per Type", "Cache 27 Icons Per Type", "Cache 28 Icons Per Type", "Cache 29 Icons Per Type", "Cache 30 Icons Per Type", "Cache 31 Icon Per Type", "Cache 32 Icons Per Type", "Cache 33 Icons Per Type", "Cache 34 Icons Per Type", "Cache 35 Icons Per Type", "Cache 36 Icons Per Type", "Cache 37 Icons Per Type", "Cache 38 Icons Per Type", "Cache 39 Icons Per Type", "Cache 40 Icons Per Type", "Cache 41 Icon Per Type", "Cache 42 Icons Per Type", "Cache 43 Icons Per Type", "Cache 44 Icons Per Type", "Cache 45 Icons Per Type", "Cache 46 Icons Per Type", "Cache 47 Icons Per Type", "Cache 48 Icons Per Type", "Cache 49 Icons Per Type", "Cache 50 Icons Per Type", "Cache 51 Icon Per Type", "Cache 52 Icons Per Type", "Cache 53 Icons Per Type", "Cache 54 Icons Per Type", "Cache 55 Icons Per Type", "Cache 56 Icons Per Type", "Cache 57 Icons Per Type", "Cache 58 Icons Per Type", "Cache 59 Icons Per Type", "Cache 60 Icons Per Type", "Cache 61 Icon Per Type", "Cache 62 Icons Per Type", "Cache 63 Icons Per Type", "Cache 64 Icons Per Type", "Cache 65 Icons Per Type", "Cache 66 Icons Per Type", "Cache 67 Icons Per Type", "Cache 68 Icons Per Type", "Cache 69 Icons Per Type", "Cache 70 Icons Per Type", "Cache 71 Icon Per Type", "Cache 72 Icons Per Type", "Cache 73 Icons Per Type", "Cache 74 Icons Per Type", "Cache 75 Icons Per Type", "Cache 76 Icons Per Type", "Cache 77 Icons Per Type", "Cache 78 Icons Per Type", "Cache 79 Icons Per Type", "Cache 80 Icons Per Type", "Cache 81 Icon Per Type", "Cache 82 Icons Per Type", "Cache 83 Icons Per Type", "Cache 84 Icons Per Type", "Cache 85 Icons Per Type", "Cache 86 Icons Per Type", "Cache 87 Icons Per Type", "Cache 88 Icons Per Type", "Cache 89 Icons Per Type", "Cache 90 Icons Per Type", "Cache 91 Icon Per Type", "Cache 92 Icons Per Type", "Cache 93 Icons Per Type", "Cache 94 Icons Per Type", "Cache 95 Icons Per Type", "Cache 96 Icons Per Type", "Cache 97 Icons Per Type", "Cache 98 Icons Per Type", "Cache 99 Icons Per Type", "Cache 100 Icons Per Type"})
        Me.cbMaxIconPerStyle.Location = New System.Drawing.Point(13, 216)
        Me.cbMaxIconPerStyle.Name = "cbMaxIconPerStyle"
        Me.cbMaxIconPerStyle.Size = New System.Drawing.Size(165, 21)
        Me.cbMaxIconPerStyle.TabIndex = 58
        Me.cbMaxIconPerStyle.Text = "Max Number of Cached Icons per style"
        '
        'cbf2s8
        '
        Me.cbf2s8.Checked = True
        Me.cbf2s8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf2s8.Location = New System.Drawing.Point(2, 90)
        Me.cbf2s8.Name = "cbf2s8"
        Me.cbf2s8.Size = New System.Drawing.Size(154, 21)
        Me.cbf2s8.TabIndex = 61
        Me.cbf2s8.Text = "Wide Rounded Shadow"
        Me.cbf2s8.Values.ExtraText = ""
        Me.cbf2s8.Values.Image = Nothing
        Me.cbf2s8.Values.Text = "Wide Rounded Shadow"
        '
        'cbDlFormat
        '
        Me.cbDlFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDlFormat.FormattingEnabled = True
        Me.cbDlFormat.Items.AddRange(New Object() {"Low Quality", "Medium Quality", "Highest Quality"})
        Me.cbDlFormat.Location = New System.Drawing.Point(13, 185)
        Me.cbDlFormat.Name = "cbDlFormat"
        Me.cbDlFormat.Size = New System.Drawing.Size(100, 21)
        Me.cbDlFormat.TabIndex = 59
        Me.cbDlFormat.Text = "Highest Quality"
        '
        'cbf2s2
        '
        Me.cbf2s2.Checked = True
        Me.cbf2s2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbf2s2.Location = New System.Drawing.Point(2, 150)
        Me.cbf2s2.Name = "cbf2s2"
        Me.cbf2s2.Size = New System.Drawing.Size(211, 21)
        Me.cbf2s2.TabIndex = 60
        Me.cbf2s2.Text = "Wide Rounded Shadow Scanlines"
        Me.cbf2s2.Values.ExtraText = ""
        Me.cbf2s2.Values.Image = Nothing
        Me.cbf2s2.Values.Text = "Wide Rounded Shadow Scanlines"
        '
        'kgColorSelect
        '
        Me.kgColorSelect.Location = New System.Drawing.Point(457, 6)
        Me.kgColorSelect.Name = "kgColorSelect"
        '
        'kgColorSelect.Panel
        '
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorBubbles)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorFire)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorSkyBlueLarge)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorBlingLarge)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorPro)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorGreen)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorPink)
        Me.kgColorSelect.Panel.Controls.Add(Me.klblGUILOOK)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorBling)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorSilver)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorBlue)
        Me.kgColorSelect.Panel.Controls.Add(Me.krbColorBlack)
        Me.kgColorSelect.Size = New System.Drawing.Size(196, 290)
        Me.kgColorSelect.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgColorSelect.StateCommon.Border.Rounding = 7
        Me.kgColorSelect.StateCommon.Border.Width = 2
        Me.kgColorSelect.TabIndex = 80
        '
        'krbColorBubbles
        '
        Me.krbColorBubbles.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorBubbles.Location = New System.Drawing.Point(5, 256)
        Me.krbColorBubbles.Name = "krbColorBubbles"
        Me.krbColorBubbles.Size = New System.Drawing.Size(68, 21)
        Me.krbColorBubbles.TabIndex = 11
        Me.krbColorBubbles.Text = "Bubbles"
        Me.krbColorBubbles.Values.ExtraText = ""
        Me.krbColorBubbles.Values.Image = Nothing
        Me.krbColorBubbles.Values.Text = "Bubbles"
        '
        'krbColorFire
        '
        Me.krbColorFire.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorFire.Location = New System.Drawing.Point(5, 209)
        Me.krbColorFire.Name = "krbColorFire"
        Me.krbColorFire.Size = New System.Drawing.Size(94, 21)
        Me.krbColorFire.TabIndex = 10
        Me.krbColorFire.Text = "Wicked Blue"
        Me.krbColorFire.Values.ExtraText = ""
        Me.krbColorFire.Values.Image = Nothing
        Me.krbColorFire.Values.Text = "Wicked Blue"
        '
        'krbColorSkyBlueLarge
        '
        Me.krbColorSkyBlueLarge.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorSkyBlueLarge.Location = New System.Drawing.Point(5, 135)
        Me.krbColorSkyBlueLarge.Name = "krbColorSkyBlueLarge"
        Me.krbColorSkyBlueLarge.Size = New System.Drawing.Size(147, 21)
        Me.krbColorSkyBlueLarge.TabIndex = 9
        Me.krbColorSkyBlueLarge.Text = "Sky Blue (Large Font)"
        Me.krbColorSkyBlueLarge.UseMnemonic = False
        Me.krbColorSkyBlueLarge.Values.ExtraText = ""
        Me.krbColorSkyBlueLarge.Values.Image = Nothing
        Me.krbColorSkyBlueLarge.Values.Text = "Sky Blue (Large Font)"
        '
        'krbColorBlingLarge
        '
        Me.krbColorBlingLarge.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorBlingLarge.Location = New System.Drawing.Point(5, 91)
        Me.krbColorBlingLarge.Name = "krbColorBlingLarge"
        Me.krbColorBlingLarge.Size = New System.Drawing.Size(125, 21)
        Me.krbColorBlingLarge.TabIndex = 8
        Me.krbColorBlingLarge.Text = "Bling (Large Font)"
        Me.krbColorBlingLarge.UseMnemonic = False
        Me.krbColorBlingLarge.Values.ExtraText = ""
        Me.krbColorBlingLarge.Values.Image = Nothing
        Me.krbColorBlingLarge.Values.Text = "Bling (Large Font)"
        '
        'krbColorPro
        '
        Me.krbColorPro.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorPro.Location = New System.Drawing.Point(5, 182)
        Me.krbColorPro.Name = "krbColorPro"
        Me.krbColorPro.Size = New System.Drawing.Size(148, 21)
        Me.krbColorPro.TabIndex = 7
        Me.krbColorPro.Text = "Professional - System"
        Me.krbColorPro.Values.ExtraText = ""
        Me.krbColorPro.Values.Image = Nothing
        Me.krbColorPro.Values.Text = "Professional - System"
        '
        'krbColorGreen
        '
        Me.krbColorGreen.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorGreen.Location = New System.Drawing.Point(5, 158)
        Me.krbColorGreen.Name = "krbColorGreen"
        Me.krbColorGreen.Size = New System.Drawing.Size(125, 21)
        Me.krbColorGreen.TabIndex = 6
        Me.krbColorGreen.Text = "Olvie Drab/Green"
        Me.krbColorGreen.UseMnemonic = False
        Me.krbColorGreen.Values.ExtraText = ""
        Me.krbColorGreen.Values.Image = Nothing
        Me.krbColorGreen.Values.Text = "Olvie Drab/Green"
        '
        'krbColorPink
        '
        Me.krbColorPink.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorPink.Location = New System.Drawing.Point(5, 113)
        Me.krbColorPink.Name = "krbColorPink"
        Me.krbColorPink.Size = New System.Drawing.Size(72, 21)
        Me.krbColorPink.TabIndex = 5
        Me.krbColorPink.Text = "Sky Blue"
        Me.krbColorPink.UseMnemonic = False
        Me.krbColorPink.Values.ExtraText = ""
        Me.krbColorPink.Values.Image = Nothing
        Me.krbColorPink.Values.Text = "Sky Blue"
        '
        'klblGUILOOK
        '
        Me.klblGUILOOK.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblGUILOOK.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblGUILOOK.Location = New System.Drawing.Point(0, 0)
        Me.klblGUILOOK.Name = "klblGUILOOK"
        Me.klblGUILOOK.Size = New System.Drawing.Size(186, 21)
        Me.klblGUILOOK.TabIndex = 4
        Me.klblGUILOOK.Text = "Color Scheme"
        Me.klblGUILOOK.Values.ExtraText = ""
        Me.klblGUILOOK.Values.Image = Nothing
        Me.klblGUILOOK.Values.Text = "Color Scheme"
        '
        'krbColorBling
        '
        Me.krbColorBling.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorBling.Location = New System.Drawing.Point(5, 69)
        Me.krbColorBling.Name = "krbColorBling"
        Me.krbColorBling.Size = New System.Drawing.Size(50, 21)
        Me.krbColorBling.TabIndex = 3
        Me.krbColorBling.Text = "Bling"
        Me.krbColorBling.UseMnemonic = False
        Me.krbColorBling.Values.ExtraText = ""
        Me.krbColorBling.Values.Image = Nothing
        Me.krbColorBling.Values.Text = "Bling"
        '
        'krbColorSilver
        '
        Me.krbColorSilver.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorSilver.Location = New System.Drawing.Point(5, 47)
        Me.krbColorSilver.Name = "krbColorSilver"
        Me.krbColorSilver.Size = New System.Drawing.Size(57, 21)
        Me.krbColorSilver.TabIndex = 2
        Me.krbColorSilver.Text = "Silver"
        Me.krbColorSilver.Values.ExtraText = ""
        Me.krbColorSilver.Values.Image = Nothing
        Me.krbColorSilver.Values.Text = "Silver"
        '
        'krbColorBlue
        '
        Me.krbColorBlue.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorBlue.Location = New System.Drawing.Point(5, 25)
        Me.krbColorBlue.Name = "krbColorBlue"
        Me.krbColorBlue.Size = New System.Drawing.Size(83, 21)
        Me.krbColorBlue.TabIndex = 1
        Me.krbColorBlue.Text = "Black-Blue"
        Me.krbColorBlue.Values.ExtraText = ""
        Me.krbColorBlue.Values.Image = Nothing
        Me.krbColorBlue.Values.Text = "Black-Blue"
        '
        'krbColorBlack
        '
        Me.krbColorBlack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbColorBlack.Location = New System.Drawing.Point(5, 231)
        Me.krbColorBlack.Name = "krbColorBlack"
        Me.krbColorBlack.Size = New System.Drawing.Size(91, 21)
        Me.krbColorBlack.TabIndex = 0
        Me.krbColorBlack.Text = "Wicked Red"
        Me.krbColorBlack.Values.ExtraText = ""
        Me.krbColorBlack.Values.Image = Nothing
        Me.krbColorBlack.Values.Text = "Wicked Red"
        '
        'cbGoogleImageSearchPop
        '
        Me.cbGoogleImageSearchPop.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGoogleImageSearchPop.Location = New System.Drawing.Point(3, 26)
        Me.cbGoogleImageSearchPop.Name = "cbGoogleImageSearchPop"
        Me.cbGoogleImageSearchPop.Size = New System.Drawing.Size(443, 21)
        Me.cbGoogleImageSearchPop.TabIndex = 75
        Me.cbGoogleImageSearchPop.Text = "Open Google Image Search when adding custom Images and Backgrounds"
        Me.cbGoogleImageSearchPop.Values.ExtraText = ""
        Me.cbGoogleImageSearchPop.Values.Image = Nothing
        Me.cbGoogleImageSearchPop.Values.Text = "Open Google Image Search when adding custom Images and Backgrounds"
        '
        'btnsaveconfig
        '
        Me.btnsaveconfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveconfig.ForeColor = System.Drawing.Color.Black
        Me.btnsaveconfig.Location = New System.Drawing.Point(232, 3)
        Me.btnsaveconfig.Name = "btnsaveconfig"
        Me.btnsaveconfig.Size = New System.Drawing.Size(375, 39)
        Me.btnsaveconfig.TabIndex = 63
        Me.btnsaveconfig.Text = "Write Configuration Changes and Close this Setup Dialog box"
        Me.btnsaveconfig.Values.ExtraText = ""
        Me.btnsaveconfig.Values.Image = Nothing
        Me.btnsaveconfig.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnsaveconfig.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnsaveconfig.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnsaveconfig.Values.Text = "Write Configuration Changes and Close this Setup Dialog box"
        '
        'kgTVShowSettings
        '
        Me.kgTVShowSettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgTVShowSettings.Location = New System.Drawing.Point(3, 305)
        Me.kgTVShowSettings.Name = "kgTVShowSettings"
        '
        'kgTVShowSettings.Panel
        '
        Me.kgTVShowSettings.Panel.Controls.Add(Me.kgTVGlobalSettings)
        Me.kgTVShowSettings.Panel.Controls.Add(Me.kgSettingsTvEpisode)
        Me.kgTVShowSettings.Panel.Controls.Add(Me.kgSettingsTvSeasonBanners)
        Me.kgTVShowSettings.Panel.Controls.Add(Me.kgSettingsTvShow)
        Me.kgTVShowSettings.Size = New System.Drawing.Size(793, 874)
        Me.kgTVShowSettings.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kgTVShowSettings.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.kgTVShowSettings.StateCommon.Border.ColorAngle = 60.0!
        Me.kgTVShowSettings.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgTVShowSettings.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgTVShowSettings.StateCommon.Border.Rounding = 7
        Me.kgTVShowSettings.StateCommon.Border.Width = 2
        Me.kgTVShowSettings.TabIndex = 87
        '
        'kgTVGlobalSettings
        '
        Me.kgTVGlobalSettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgTVGlobalSettings.Location = New System.Drawing.Point(0, 7)
        Me.kgTVGlobalSettings.Name = "kgTVGlobalSettings"
        '
        'kgTVGlobalSettings.Panel
        '
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.cbscanforepisodemediainformation)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.cbshows_UseStudioasRating)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.cbtvlangoverridebanners)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.lblCustomRegX)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.tbTvRegex1)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.klblTVGSnoteslbl)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.klblGlobalSettingslbl)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.lbltv_curlang)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.klblTVCheckForNewTVShowDatalbl)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.cbtv_lang)
        Me.kgTVGlobalSettings.Panel.Controls.Add(Me.combolTVCheckForNewTVShowData)
        Me.kgTVGlobalSettings.Size = New System.Drawing.Size(775, 200)
        Me.kgTVGlobalSettings.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgTVGlobalSettings.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgTVGlobalSettings.StateCommon.Border.ColorAngle = 60.0!
        Me.kgTVGlobalSettings.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgTVGlobalSettings.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgTVGlobalSettings.StateCommon.Border.Rounding = 7
        Me.kgTVGlobalSettings.StateCommon.Border.Width = 2
        Me.kgTVGlobalSettings.TabIndex = 78
        '
        'cbscanforepisodemediainformation
        '
        Me.cbscanforepisodemediainformation.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbscanforepisodemediainformation.Location = New System.Drawing.Point(267, 144)
        Me.cbscanforepisodemediainformation.Name = "cbscanforepisodemediainformation"
        Me.cbscanforepisodemediainformation.Size = New System.Drawing.Size(316, 21)
        Me.cbscanforepisodemediainformation.TabIndex = 86
        Me.cbscanforepisodemediainformation.Text = "Scan Episode Media and gather Media Information"
        Me.cbscanforepisodemediainformation.Values.ExtraText = ""
        Me.cbscanforepisodemediainformation.Values.Image = Nothing
        Me.cbscanforepisodemediainformation.Values.Text = "Scan Episode Media and gather Media Information"
        '
        'cbshows_UseStudioasRating
        '
        Me.cbshows_UseStudioasRating.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbshows_UseStudioasRating.Location = New System.Drawing.Point(267, 120)
        Me.cbshows_UseStudioasRating.Name = "cbshows_UseStudioasRating"
        Me.cbshows_UseStudioasRating.Size = New System.Drawing.Size(194, 21)
        Me.cbshows_UseStudioasRating.TabIndex = 85
        Me.cbshows_UseStudioasRating.Text = "Save Studio Into Rating Field"
        Me.cbshows_UseStudioasRating.Values.ExtraText = ""
        Me.cbshows_UseStudioasRating.Values.Image = Nothing
        Me.cbshows_UseStudioasRating.Values.Text = "Save Studio Into Rating Field"
        '
        'cbtvlangoverridebanners
        '
        Me.cbtvlangoverridebanners.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbtvlangoverridebanners.Location = New System.Drawing.Point(267, 93)
        Me.cbtvlangoverridebanners.Name = "cbtvlangoverridebanners"
        Me.cbtvlangoverridebanners.Size = New System.Drawing.Size(203, 21)
        Me.cbtvlangoverridebanners.TabIndex = 84
        Me.cbtvlangoverridebanners.Text = "Language Override for Banners"
        Me.cbtvlangoverridebanners.Values.ExtraText = ""
        Me.cbtvlangoverridebanners.Values.Image = Nothing
        Me.cbtvlangoverridebanners.Values.Text = "Language Override for Banners"
        '
        'lblCustomRegX
        '
        Me.lblCustomRegX.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblCustomRegX.Location = New System.Drawing.Point(3, 170)
        Me.lblCustomRegX.Name = "lblCustomRegX"
        Me.lblCustomRegX.Size = New System.Drawing.Size(91, 21)
        Me.lblCustomRegX.TabIndex = 83
        Me.lblCustomRegX.Text = "Custom Regex"
        Me.lblCustomRegX.Values.ExtraText = ""
        Me.lblCustomRegX.Values.Image = Nothing
        Me.lblCustomRegX.Values.Text = "Custom Regex"
        '
        'tbTvRegex1
        '
        Me.tbTvRegex1.Location = New System.Drawing.Point(115, 166)
        Me.tbTvRegex1.Name = "tbTvRegex1"
        Me.tbTvRegex1.Size = New System.Drawing.Size(642, 34)
        Me.tbTvRegex1.TabIndex = 82
        '
        'klblTVGSnoteslbl
        '
        Me.klblTVGSnoteslbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblTVGSnoteslbl.Location = New System.Drawing.Point(7, 58)
        Me.klblTVGSnoteslbl.Name = "klblTVGSnoteslbl"
        Me.klblTVGSnoteslbl.Size = New System.Drawing.Size(356, 21)
        Me.klblTVGSnoteslbl.TabIndex = 25
        Me.klblTVGSnoteslbl.Text = "* Based off thetvdb.com's modified date on the last update"
        Me.klblTVGSnoteslbl.Values.ExtraText = ""
        Me.klblTVGSnoteslbl.Values.Image = Nothing
        Me.klblTVGSnoteslbl.Values.Text = "* Based off thetvdb.com's modified date on the last update"
        '
        'klblGlobalSettingslbl
        '
        Me.klblGlobalSettingslbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblGlobalSettingslbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblGlobalSettingslbl.Location = New System.Drawing.Point(0, 0)
        Me.klblGlobalSettingslbl.Name = "klblGlobalSettingslbl"
        Me.klblGlobalSettingslbl.Size = New System.Drawing.Size(765, 21)
        Me.klblGlobalSettingslbl.TabIndex = 24
        Me.klblGlobalSettingslbl.Text = "TV Global Settings"
        Me.klblGlobalSettingslbl.Values.ExtraText = ""
        Me.klblGlobalSettingslbl.Values.Image = Nothing
        Me.klblGlobalSettingslbl.Values.Text = "TV Global Settings"
        '
        'lbltv_curlang
        '
        Me.lbltv_curlang.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lbltv_curlang.Location = New System.Drawing.Point(68, 93)
        Me.lbltv_curlang.Name = "lbltv_curlang"
        Me.lbltv_curlang.Size = New System.Drawing.Size(117, 21)
        Me.lbltv_curlang.TabIndex = 81
        Me.lbltv_curlang.Text = "TV Show Language"
        Me.lbltv_curlang.Values.ExtraText = ""
        Me.lbltv_curlang.Values.Image = Nothing
        Me.lbltv_curlang.Values.Text = "TV Show Language"
        '
        'klblTVCheckForNewTVShowDatalbl
        '
        Me.klblTVCheckForNewTVShowDatalbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblTVCheckForNewTVShowDatalbl.Location = New System.Drawing.Point(67, 32)
        Me.klblTVCheckForNewTVShowDatalbl.Name = "klblTVCheckForNewTVShowDatalbl"
        Me.klblTVCheckForNewTVShowDatalbl.Size = New System.Drawing.Size(352, 21)
        Me.klblTVCheckForNewTVShowDatalbl.TabIndex = 23
        Me.klblTVCheckForNewTVShowDatalbl.Text = "Number of Days before  downloading new TV Show Content"
        Me.klblTVCheckForNewTVShowDatalbl.Values.ExtraText = ""
        Me.klblTVCheckForNewTVShowDatalbl.Values.Image = Nothing
        Me.klblTVCheckForNewTVShowDatalbl.Values.Text = "Number of Days before  downloading new TV Show Content"
        '
        'cbtv_lang
        '
        Me.cbtv_lang.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.cbtv_lang.DropDownWidth = 41
        Me.cbtv_lang.FormattingEnabled = False
        Me.cbtv_lang.Items.AddRange(New Object() {"da", "fi", "nl", "de", "it", "es", "fr", "pl", "hu", "el", "tr", "ru", "he", "ja", "pt", "zh", "cs", "sl", "hr", "en", "sv", "no"})
        Me.cbtv_lang.Location = New System.Drawing.Point(6, 90)
        Me.cbtv_lang.Name = "cbtv_lang"
        Me.cbtv_lang.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.cbtv_lang.Size = New System.Drawing.Size(56, 20)
        Me.cbtv_lang.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.cbtv_lang.TabIndex = 80
        '
        'combolTVCheckForNewTVShowData
        '
        Me.combolTVCheckForNewTVShowData.DropDownWidth = 49
        Me.combolTVCheckForNewTVShowData.FormattingEnabled = False
        Me.combolTVCheckForNewTVShowData.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.combolTVCheckForNewTVShowData.Location = New System.Drawing.Point(8, 27)
        Me.combolTVCheckForNewTVShowData.Name = "combolTVCheckForNewTVShowData"
        Me.combolTVCheckForNewTVShowData.Size = New System.Drawing.Size(52, 34)
        Me.combolTVCheckForNewTVShowData.TabIndex = 22
        Me.combolTVCheckForNewTVShowData.Text = "7"
        '
        'kgSettingsTvEpisode
        '
        Me.kgSettingsTvEpisode.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgSettingsTvEpisode.Location = New System.Drawing.Point(5, 518)
        Me.kgSettingsTvEpisode.Name = "kgSettingsTvEpisode"
        '
        'kgSettingsTvEpisode.Panel
        '
        Me.kgSettingsTvEpisode.Panel.Controls.Add(Me.tvgs_episode_overwrite_tbn)
        Me.kgSettingsTvEpisode.Panel.Controls.Add(Me.tvgs_episode_overwrite_nfo)
        Me.kgSettingsTvEpisode.Panel.Controls.Add(Me.klblTVEpisodesSection)
        Me.kgSettingsTvEpisode.Panel.Controls.Add(Me.tvgs_cb_episode_download)
        Me.kgSettingsTvEpisode.Size = New System.Drawing.Size(770, 119)
        Me.kgSettingsTvEpisode.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kgSettingsTvEpisode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kgSettingsTvEpisode.StateCommon.Border.ColorAngle = 220.0!
        Me.kgSettingsTvEpisode.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgSettingsTvEpisode.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgSettingsTvEpisode.StateCommon.Border.Rounding = 10
        Me.kgSettingsTvEpisode.StateCommon.Border.Width = 2
        Me.kgSettingsTvEpisode.TabIndex = 15
        '
        'tvgs_episode_overwrite_tbn
        '
        Me.tvgs_episode_overwrite_tbn.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_episode_overwrite_tbn.Location = New System.Drawing.Point(15, 77)
        Me.tvgs_episode_overwrite_tbn.Name = "tvgs_episode_overwrite_tbn"
        Me.tvgs_episode_overwrite_tbn.Size = New System.Drawing.Size(197, 21)
        Me.tvgs_episode_overwrite_tbn.TabIndex = 10
        Me.tvgs_episode_overwrite_tbn.Text = "Overwrite Existing .TBN Files"
        Me.tvgs_episode_overwrite_tbn.Values.ExtraText = ""
        Me.tvgs_episode_overwrite_tbn.Values.Image = Nothing
        Me.tvgs_episode_overwrite_tbn.Values.Text = "Overwrite Existing .TBN Files"
        '
        'tvgs_episode_overwrite_nfo
        '
        Me.tvgs_episode_overwrite_nfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_episode_overwrite_nfo.Location = New System.Drawing.Point(14, 53)
        Me.tvgs_episode_overwrite_nfo.Name = "tvgs_episode_overwrite_nfo"
        Me.tvgs_episode_overwrite_nfo.Size = New System.Drawing.Size(198, 21)
        Me.tvgs_episode_overwrite_nfo.TabIndex = 9
        Me.tvgs_episode_overwrite_nfo.Text = "Overwrite Existing .NFO Files"
        Me.tvgs_episode_overwrite_nfo.Values.ExtraText = ""
        Me.tvgs_episode_overwrite_nfo.Values.Image = Nothing
        Me.tvgs_episode_overwrite_nfo.Values.Text = "Overwrite Existing .NFO Files"
        '
        'klblTVEpisodesSection
        '
        Me.klblTVEpisodesSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblTVEpisodesSection.Location = New System.Drawing.Point(26, -3)
        Me.klblTVEpisodesSection.Name = "klblTVEpisodesSection"
        Me.klblTVEpisodesSection.Size = New System.Drawing.Size(188, 21)
        Me.klblTVEpisodesSection.TabIndex = 8
        Me.klblTVEpisodesSection.Text = "Episode Settings (Per Episode)"
        Me.klblTVEpisodesSection.Values.ExtraText = ""
        Me.klblTVEpisodesSection.Values.Image = Nothing
        Me.klblTVEpisodesSection.Values.Text = "Episode Settings (Per Episode)"
        '
        'tvgs_cb_episode_download
        '
        Me.tvgs_cb_episode_download.Checked = True
        Me.tvgs_cb_episode_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_episode_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_episode_download.Location = New System.Drawing.Point(14, 30)
        Me.tvgs_cb_episode_download.Name = "tvgs_cb_episode_download"
        Me.tvgs_cb_episode_download.Size = New System.Drawing.Size(194, 21)
        Me.tvgs_cb_episode_download.TabIndex = 3
        Me.tvgs_cb_episode_download.Text = "Download TV Episode Thumbs"
        Me.tvgs_cb_episode_download.Values.ExtraText = ""
        Me.tvgs_cb_episode_download.Values.Image = Nothing
        Me.tvgs_cb_episode_download.Values.Text = "Download TV Episode Thumbs"
        '
        'kgSettingsTvSeasonBanners
        '
        Me.kgSettingsTvSeasonBanners.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgSettingsTvSeasonBanners.Location = New System.Drawing.Point(4, 641)
        Me.kgSettingsTvSeasonBanners.Name = "kgSettingsTvSeasonBanners"
        '
        'kgSettingsTvSeasonBanners.Panel
        '
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.klbltvseasonwhatstylelbl)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.tvgs_combobox_season_banners_download_type)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.tvgs_knud_season_posters_download_maxnumber)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.krbTVSeasonUsePoster)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.krbTVSeasonUseWide)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.KryptonLabel3)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.tvgs_cb_season_posters_download)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.klbltvMaxNumberOfPosters)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.tvgs_knud_season_banners_download_maxnumber)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.klblTVBannersSection)
        Me.kgSettingsTvSeasonBanners.Panel.Controls.Add(Me.tvgs_cb_season_banners_download)
        Me.kgSettingsTvSeasonBanners.Size = New System.Drawing.Size(771, 215)
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.ColorAngle = 220.0!
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.Rounding = 10
        Me.kgSettingsTvSeasonBanners.StateCommon.Border.Width = 2
        Me.kgSettingsTvSeasonBanners.TabIndex = 12
        '
        'klbltvseasonwhatstylelbl
        '
        Me.klbltvseasonwhatstylelbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbltvseasonwhatstylelbl.Location = New System.Drawing.Point(61, 65)
        Me.klbltvseasonwhatstylelbl.Name = "klbltvseasonwhatstylelbl"
        Me.klbltvseasonwhatstylelbl.Size = New System.Drawing.Size(268, 21)
        Me.klbltvseasonwhatstylelbl.TabIndex = 19
        Me.klbltvseasonwhatstylelbl.Text = "What style of Wide Icon should I download?"
        Me.klbltvseasonwhatstylelbl.Values.ExtraText = ""
        Me.klbltvseasonwhatstylelbl.Values.Image = Nothing
        Me.klbltvseasonwhatstylelbl.Values.Text = "What style of Wide Icon should I download?"
        '
        'tvgs_combobox_season_banners_download_type
        '
        Me.tvgs_combobox_season_banners_download_type.DropDownWidth = 108
        Me.tvgs_combobox_season_banners_download_type.FormattingEnabled = False
        Me.tvgs_combobox_season_banners_download_type.Items.AddRange(New Object() {"All", "Blank", "Graphical", "Text"})
        Me.tvgs_combobox_season_banners_download_type.Location = New System.Drawing.Point(2, 63)
        Me.tvgs_combobox_season_banners_download_type.Name = "tvgs_combobox_season_banners_download_type"
        Me.tvgs_combobox_season_banners_download_type.Size = New System.Drawing.Size(55, 34)
        Me.tvgs_combobox_season_banners_download_type.TabIndex = 18
        Me.tvgs_combobox_season_banners_download_type.Text = "All"
        '
        'tvgs_knud_season_posters_download_maxnumber
        '
        Me.tvgs_knud_season_posters_download_maxnumber.Location = New System.Drawing.Point(3, 124)
        Me.tvgs_knud_season_posters_download_maxnumber.Name = "tvgs_knud_season_posters_download_maxnumber"
        Me.tvgs_knud_season_posters_download_maxnumber.Size = New System.Drawing.Size(43, 33)
        Me.tvgs_knud_season_posters_download_maxnumber.TabIndex = 18
        Me.tvgs_knud_season_posters_download_maxnumber.UseMnemonic = False
        Me.tvgs_knud_season_posters_download_maxnumber.Value = New Decimal(New Integer() {48, 0, 0, 0})
        '
        'krbTVSeasonUsePoster
        '
        Me.krbTVSeasonUsePoster.Checked = True
        Me.krbTVSeasonUsePoster.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbTVSeasonUsePoster.Location = New System.Drawing.Point(11, 157)
        Me.krbTVSeasonUsePoster.Name = "krbTVSeasonUsePoster"
        Me.krbTVSeasonUsePoster.Size = New System.Drawing.Size(227, 21)
        Me.krbTVSeasonUsePoster.TabIndex = 14
        Me.krbTVSeasonUsePoster.Text = "Use Poster for Seasons Thumbnails"
        Me.krbTVSeasonUsePoster.Values.ExtraText = ""
        Me.krbTVSeasonUsePoster.Values.Image = Nothing
        Me.krbTVSeasonUsePoster.Values.Text = "Use Poster for Seasons Thumbnails"
        '
        'krbTVSeasonUseWide
        '
        Me.krbTVSeasonUseWide.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.krbTVSeasonUseWide.Location = New System.Drawing.Point(11, 179)
        Me.krbTVSeasonUseWide.Name = "krbTVSeasonUseWide"
        Me.krbTVSeasonUseWide.Size = New System.Drawing.Size(250, 21)
        Me.krbTVSeasonUseWide.TabIndex = 15
        Me.krbTVSeasonUseWide.Text = "Use Wide Icon For Seasons Thumbnails"
        Me.krbTVSeasonUseWide.Values.ExtraText = ""
        Me.krbTVSeasonUseWide.Values.Image = Nothing
        Me.krbTVSeasonUseWide.Values.Text = "Use Wide Icon For Seasons Thumbnails"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(49, 127)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(266, 21)
        Me.KryptonLabel3.TabIndex = 17
        Me.KryptonLabel3.Text = "Max Number of Season Posters to Download"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Max Number of Season Posters to Download"
        '
        'tvgs_cb_season_posters_download
        '
        Me.tvgs_cb_season_posters_download.Checked = True
        Me.tvgs_cb_season_posters_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_season_posters_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_season_posters_download.Location = New System.Drawing.Point(9, 44)
        Me.tvgs_cb_season_posters_download.Name = "tvgs_cb_season_posters_download"
        Me.tvgs_cb_season_posters_download.Size = New System.Drawing.Size(189, 21)
        Me.tvgs_cb_season_posters_download.TabIndex = 16
        Me.tvgs_cb_season_posters_download.Text = "Download TV Season Posters"
        Me.tvgs_cb_season_posters_download.Values.ExtraText = ""
        Me.tvgs_cb_season_posters_download.Values.Image = Nothing
        Me.tvgs_cb_season_posters_download.Values.Text = "Download TV Season Posters"
        '
        'klbltvMaxNumberOfPosters
        '
        Me.klbltvMaxNumberOfPosters.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbltvMaxNumberOfPosters.Location = New System.Drawing.Point(49, 97)
        Me.klbltvMaxNumberOfPosters.Name = "klbltvMaxNumberOfPosters"
        Me.klbltvMaxNumberOfPosters.Size = New System.Drawing.Size(289, 21)
        Me.klbltvMaxNumberOfPosters.TabIndex = 12
        Me.klbltvMaxNumberOfPosters.Text = "Max Number of Season Wide Icons to Download"
        Me.klbltvMaxNumberOfPosters.Values.ExtraText = ""
        Me.klbltvMaxNumberOfPosters.Values.Image = Nothing
        Me.klbltvMaxNumberOfPosters.Values.Text = "Max Number of Season Wide Icons to Download"
        '
        'tvgs_knud_season_banners_download_maxnumber
        '
        Me.tvgs_knud_season_banners_download_maxnumber.Location = New System.Drawing.Point(3, 94)
        Me.tvgs_knud_season_banners_download_maxnumber.Name = "tvgs_knud_season_banners_download_maxnumber"
        Me.tvgs_knud_season_banners_download_maxnumber.Size = New System.Drawing.Size(43, 33)
        Me.tvgs_knud_season_banners_download_maxnumber.TabIndex = 13
        Me.tvgs_knud_season_banners_download_maxnumber.UseMnemonic = False
        Me.tvgs_knud_season_banners_download_maxnumber.Value = New Decimal(New Integer() {48, 0, 0, 0})
        '
        'klblTVBannersSection
        '
        Me.klblTVBannersSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblTVBannersSection.Location = New System.Drawing.Point(40, -3)
        Me.klblTVBannersSection.Name = "klblTVBannersSection"
        Me.klblTVBannersSection.Size = New System.Drawing.Size(181, 21)
        Me.klblTVBannersSection.TabIndex = 9
        Me.klblTVBannersSection.Text = "Season Settings (Per Season)"
        Me.klblTVBannersSection.Values.ExtraText = ""
        Me.klblTVBannersSection.Values.Image = Nothing
        Me.klblTVBannersSection.Values.Text = "Season Settings (Per Season)"
        '
        'tvgs_cb_season_banners_download
        '
        Me.tvgs_cb_season_banners_download.Checked = True
        Me.tvgs_cb_season_banners_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_season_banners_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_season_banners_download.Location = New System.Drawing.Point(9, 22)
        Me.tvgs_cb_season_banners_download.Name = "tvgs_cb_season_banners_download"
        Me.tvgs_cb_season_banners_download.Size = New System.Drawing.Size(212, 21)
        Me.tvgs_cb_season_banners_download.TabIndex = 5
        Me.tvgs_cb_season_banners_download.Text = "Download TV Season Wide Icons"
        Me.tvgs_cb_season_banners_download.Values.ExtraText = ""
        Me.tvgs_cb_season_banners_download.Values.Image = Nothing
        Me.tvgs_cb_season_banners_download.Values.Text = "Download TV Season Wide Icons"
        '
        'kgSettingsTvShow
        '
        Me.kgSettingsTvShow.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgSettingsTvShow.Location = New System.Drawing.Point(-1, 213)
        Me.kgSettingsTvShow.Name = "kgSettingsTvShow"
        '
        'kgSettingsTvShow.Panel
        '
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.kgTvShowsShowWidePoster)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_cb_tvshow_nfo_overwrite)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_cb_tvshow_fanart_display)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.KryptonLabel4)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.klblFanartToApplylbl)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.klblTvShowSettingsLbl)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.klblTVFanartSection)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_combobox_tvshow_fanart_download_size)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_cb_tvshow_fanart_download)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_combobox_tvshow_fanart_toapply_whatsize)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.klbltvmaxtvfanarttodownload)
        Me.kgSettingsTvShow.Panel.Controls.Add(Me.tvgs_knud_tvshow_fanart_download_maxnumber)
        Me.kgSettingsTvShow.Size = New System.Drawing.Size(783, 299)
        Me.kgSettingsTvShow.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kgSettingsTvShow.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kgSettingsTvShow.StateCommon.Border.ColorAngle = 220.0!
        Me.kgSettingsTvShow.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgSettingsTvShow.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgSettingsTvShow.StateCommon.Border.Rounding = 10
        Me.kgSettingsTvShow.StateCommon.Border.Width = 2
        Me.kgSettingsTvShow.TabIndex = 10
        '
        'kgTvShowsShowWidePoster
        '
        Me.kgTvShowsShowWidePoster.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgTvShowsShowWidePoster.Location = New System.Drawing.Point(408, 44)
        Me.kgTvShowsShowWidePoster.Name = "kgTvShowsShowWidePoster"
        '
        'kgTvShowsShowWidePoster.Panel
        '
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.klblTVPostersSection)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.rbtvshow_show_usePosterImageForShow)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.klbltvMaxNumberOfPostersToDownload)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.rbtvshow_show_useWideImageForShow)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.tvgs_cb_tvshow_posters_download)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.tvgs_cb_tvshow_wideicon_download)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.tvgs_knud_tvshow_posters_download_maxnumber)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.KryptonLabel2)
        Me.kgTvShowsShowWidePoster.Panel.Controls.Add(Me.tvgs_knud_tvshow_wideicon_download_maxnumber)
        Me.kgTvShowsShowWidePoster.Size = New System.Drawing.Size(299, 228)
        Me.kgTvShowsShowWidePoster.TabIndex = 24
        '
        'klblTVPostersSection
        '
        Me.klblTVPostersSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblTVPostersSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblTVPostersSection.Location = New System.Drawing.Point(0, 0)
        Me.klblTVPostersSection.Name = "klblTVPostersSection"
        Me.klblTVPostersSection.Size = New System.Drawing.Size(287, 21)
        Me.klblTVPostersSection.TabIndex = 13
        Me.klblTVPostersSection.Text = "Wide Images and Posters"
        Me.klblTVPostersSection.Values.ExtraText = ""
        Me.klblTVPostersSection.Values.Image = Nothing
        Me.klblTVPostersSection.Values.Text = "Wide Images and Posters"
        '
        'rbtvshow_show_usePosterImageForShow
        '
        Me.rbtvshow_show_usePosterImageForShow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.rbtvshow_show_usePosterImageForShow.Location = New System.Drawing.Point(26, 194)
        Me.rbtvshow_show_usePosterImageForShow.Name = "rbtvshow_show_usePosterImageForShow"
        Me.rbtvshow_show_usePosterImageForShow.Size = New System.Drawing.Size(205, 21)
        Me.rbtvshow_show_usePosterImageForShow.TabIndex = 23
        Me.rbtvshow_show_usePosterImageForShow.Text = "Use Poster Image for the Show"
        Me.rbtvshow_show_usePosterImageForShow.Values.ExtraText = ""
        Me.rbtvshow_show_usePosterImageForShow.Values.Image = Nothing
        Me.rbtvshow_show_usePosterImageForShow.Values.Text = "Use Poster Image for the Show"
        '
        'klbltvMaxNumberOfPostersToDownload
        '
        Me.klbltvMaxNumberOfPostersToDownload.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbltvMaxNumberOfPostersToDownload.Location = New System.Drawing.Point(64, 74)
        Me.klbltvMaxNumberOfPostersToDownload.Name = "klbltvMaxNumberOfPostersToDownload"
        Me.klbltvMaxNumberOfPostersToDownload.Size = New System.Drawing.Size(228, 21)
        Me.klbltvMaxNumberOfPostersToDownload.TabIndex = 7
        Me.klbltvMaxNumberOfPostersToDownload.Text = "How many posters should I download?"
        Me.klbltvMaxNumberOfPostersToDownload.Values.ExtraText = ""
        Me.klbltvMaxNumberOfPostersToDownload.Values.Image = Nothing
        Me.klbltvMaxNumberOfPostersToDownload.Values.Text = "How many posters should I download?"
        '
        'rbtvshow_show_useWideImageForShow
        '
        Me.rbtvshow_show_useWideImageForShow.Checked = True
        Me.rbtvshow_show_useWideImageForShow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.rbtvshow_show_useWideImageForShow.Location = New System.Drawing.Point(26, 167)
        Me.rbtvshow_show_useWideImageForShow.Name = "rbtvshow_show_useWideImageForShow"
        Me.rbtvshow_show_useWideImageForShow.Size = New System.Drawing.Size(198, 21)
        Me.rbtvshow_show_useWideImageForShow.TabIndex = 22
        Me.rbtvshow_show_useWideImageForShow.Text = "Use Wide Image for the Show"
        Me.rbtvshow_show_useWideImageForShow.Values.ExtraText = ""
        Me.rbtvshow_show_useWideImageForShow.Values.Image = Nothing
        Me.rbtvshow_show_useWideImageForShow.Values.Text = "Use Wide Image for the Show"
        '
        'tvgs_cb_tvshow_posters_download
        '
        Me.tvgs_cb_tvshow_posters_download.Checked = True
        Me.tvgs_cb_tvshow_posters_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_tvshow_posters_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_tvshow_posters_download.Location = New System.Drawing.Point(19, 42)
        Me.tvgs_cb_tvshow_posters_download.Name = "tvgs_cb_tvshow_posters_download"
        Me.tvgs_cb_tvshow_posters_download.Size = New System.Drawing.Size(179, 21)
        Me.tvgs_cb_tvshow_posters_download.TabIndex = 4
        Me.tvgs_cb_tvshow_posters_download.Text = "Download TV Show Posters"
        Me.tvgs_cb_tvshow_posters_download.Values.ExtraText = ""
        Me.tvgs_cb_tvshow_posters_download.Values.Image = Nothing
        Me.tvgs_cb_tvshow_posters_download.Values.Text = "Download TV Show Posters"
        '
        'tvgs_cb_tvshow_wideicon_download
        '
        Me.tvgs_cb_tvshow_wideicon_download.Checked = True
        Me.tvgs_cb_tvshow_wideicon_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_tvshow_wideicon_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_tvshow_wideicon_download.Location = New System.Drawing.Point(24, 104)
        Me.tvgs_cb_tvshow_wideicon_download.Name = "tvgs_cb_tvshow_wideicon_download"
        Me.tvgs_cb_tvshow_wideicon_download.Size = New System.Drawing.Size(202, 21)
        Me.tvgs_cb_tvshow_wideicon_download.TabIndex = 14
        Me.tvgs_cb_tvshow_wideicon_download.Text = "Download TV Show Wide Icons"
        Me.tvgs_cb_tvshow_wideicon_download.Values.ExtraText = ""
        Me.tvgs_cb_tvshow_wideicon_download.Values.Image = Nothing
        Me.tvgs_cb_tvshow_wideicon_download.Values.Text = "Download TV Show Wide Icons"
        '
        'tvgs_knud_tvshow_posters_download_maxnumber
        '
        Me.tvgs_knud_tvshow_posters_download_maxnumber.Location = New System.Drawing.Point(17, 71)
        Me.tvgs_knud_tvshow_posters_download_maxnumber.Name = "tvgs_knud_tvshow_posters_download_maxnumber"
        Me.tvgs_knud_tvshow_posters_download_maxnumber.Size = New System.Drawing.Size(43, 33)
        Me.tvgs_knud_tvshow_posters_download_maxnumber.TabIndex = 11
        Me.tvgs_knud_tvshow_posters_download_maxnumber.UseMnemonic = False
        Me.tvgs_knud_tvshow_posters_download_maxnumber.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(64, 134)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(243, 21)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Text = "How many wide icons should I download?"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "How many wide icons should I download?"
        '
        'tvgs_knud_tvshow_wideicon_download_maxnumber
        '
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.Location = New System.Drawing.Point(19, 131)
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.Name = "tvgs_knud_tvshow_wideicon_download_maxnumber"
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.Size = New System.Drawing.Size(43, 33)
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.TabIndex = 16
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.UseMnemonic = False
        Me.tvgs_knud_tvshow_wideicon_download_maxnumber.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'tvgs_cb_tvshow_nfo_overwrite
        '
        Me.tvgs_cb_tvshow_nfo_overwrite.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_tvshow_nfo_overwrite.Location = New System.Drawing.Point(208, 224)
        Me.tvgs_cb_tvshow_nfo_overwrite.Name = "tvgs_cb_tvshow_nfo_overwrite"
        Me.tvgs_cb_tvshow_nfo_overwrite.Size = New System.Drawing.Size(198, 21)
        Me.tvgs_cb_tvshow_nfo_overwrite.TabIndex = 21
        Me.tvgs_cb_tvshow_nfo_overwrite.Text = "Overwrite Existing .NFO Files"
        Me.tvgs_cb_tvshow_nfo_overwrite.Values.ExtraText = ""
        Me.tvgs_cb_tvshow_nfo_overwrite.Values.Image = Nothing
        Me.tvgs_cb_tvshow_nfo_overwrite.Values.Text = "Overwrite Existing .NFO Files"
        '
        'tvgs_cb_tvshow_fanart_display
        '
        Me.tvgs_cb_tvshow_fanart_display.Checked = True
        Me.tvgs_cb_tvshow_fanart_display.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_tvshow_fanart_display.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_tvshow_fanart_display.Location = New System.Drawing.Point(4, 224)
        Me.tvgs_cb_tvshow_fanart_display.Name = "tvgs_cb_tvshow_fanart_display"
        Me.tvgs_cb_tvshow_fanart_display.Size = New System.Drawing.Size(176, 21)
        Me.tvgs_cb_tvshow_fanart_display.TabIndex = 20
        Me.tvgs_cb_tvshow_fanart_display.Text = "Use Fanart As Background"
        Me.tvgs_cb_tvshow_fanart_display.Values.ExtraText = ""
        Me.tvgs_cb_tvshow_fanart_display.Values.Image = Nothing
        Me.tvgs_cb_tvshow_fanart_display.Values.Text = "Use Fanart As Background"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(68, 133)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(223, 21)
        Me.KryptonLabel4.TabIndex = 19
        Me.KryptonLabel4.Text = "What size fanart should I download?"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "What size fanart should I download?"
        '
        'klblFanartToApplylbl
        '
        Me.klblFanartToApplylbl.Enabled = False
        Me.klblFanartToApplylbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblFanartToApplylbl.Location = New System.Drawing.Point(68, 177)
        Me.klblFanartToApplylbl.Name = "klblFanartToApplylbl"
        Me.klblFanartToApplylbl.Size = New System.Drawing.Size(319, 21)
        Me.klblFanartToApplylbl.TabIndex = 18
        Me.klblFanartToApplylbl.Text = "What size fanart should I save to the tvshow folder?"
        Me.klblFanartToApplylbl.Values.ExtraText = ""
        Me.klblFanartToApplylbl.Values.Image = Nothing
        Me.klblFanartToApplylbl.Values.Text = "What size fanart should I save to the tvshow folder?"
        '
        'klblTvShowSettingsLbl
        '
        Me.klblTvShowSettingsLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblTvShowSettingsLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblTvShowSettingsLbl.Location = New System.Drawing.Point(0, 0)
        Me.klblTvShowSettingsLbl.Name = "klblTvShowSettingsLbl"
        Me.klblTvShowSettingsLbl.Size = New System.Drawing.Size(773, 21)
        Me.klblTvShowSettingsLbl.TabIndex = 17
        Me.klblTvShowSettingsLbl.Text = "TV Show Settings (Per Show)"
        Me.klblTvShowSettingsLbl.Values.ExtraText = ""
        Me.klblTvShowSettingsLbl.Values.Image = Nothing
        Me.klblTvShowSettingsLbl.Values.Text = "TV Show Settings (Per Show)"
        '
        'klblTVFanartSection
        '
        Me.klblTVFanartSection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblTVFanartSection.Location = New System.Drawing.Point(0, 31)
        Me.klblTVFanartSection.Name = "klblTVFanartSection"
        Me.klblTVFanartSection.Size = New System.Drawing.Size(169, 21)
        Me.klblTVFanartSection.TabIndex = 8
        Me.klblTVFanartSection.Text = "Fanart / Background Image"
        Me.klblTVFanartSection.Values.ExtraText = ""
        Me.klblTVFanartSection.Values.Image = Nothing
        Me.klblTVFanartSection.Values.Text = "Fanart / Background Image"
        '
        'tvgs_combobox_tvshow_fanart_download_size
        '
        Me.tvgs_combobox_tvshow_fanart_download_size.DropDownWidth = 108
        Me.tvgs_combobox_tvshow_fanart_download_size.FormattingEnabled = False
        Me.tvgs_combobox_tvshow_fanart_download_size.Items.AddRange(New Object() {"All", "1280 x 720", "1920 x 1080"})
        Me.tvgs_combobox_tvshow_fanart_download_size.Location = New System.Drawing.Point(2, 130)
        Me.tvgs_combobox_tvshow_fanart_download_size.Name = "tvgs_combobox_tvshow_fanart_download_size"
        Me.tvgs_combobox_tvshow_fanart_download_size.Size = New System.Drawing.Size(62, 34)
        Me.tvgs_combobox_tvshow_fanart_download_size.TabIndex = 7
        Me.tvgs_combobox_tvshow_fanart_download_size.Text = "All"
        '
        'tvgs_cb_tvshow_fanart_download
        '
        Me.tvgs_cb_tvshow_fanart_download.Checked = True
        Me.tvgs_cb_tvshow_fanart_download.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tvgs_cb_tvshow_fanart_download.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.tvgs_cb_tvshow_fanart_download.Location = New System.Drawing.Point(4, 61)
        Me.tvgs_cb_tvshow_fanart_download.Name = "tvgs_cb_tvshow_fanart_download"
        Me.tvgs_cb_tvshow_fanart_download.Size = New System.Drawing.Size(174, 21)
        Me.tvgs_cb_tvshow_fanart_download.TabIndex = 3
        Me.tvgs_cb_tvshow_fanart_download.Text = "Download TV Show Fanart"
        Me.tvgs_cb_tvshow_fanart_download.Values.ExtraText = ""
        Me.tvgs_cb_tvshow_fanart_download.Values.Image = Nothing
        Me.tvgs_cb_tvshow_fanart_download.Values.Text = "Download TV Show Fanart"
        '
        'tvgs_combobox_tvshow_fanart_toapply_whatsize
        '
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.DropDownWidth = 108
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.Enabled = False
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.FormattingEnabled = False
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.Items.AddRange(New Object() {"1280 x 720", "1920 x 1080"})
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.Location = New System.Drawing.Point(3, 175)
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.Name = "tvgs_combobox_tvshow_fanart_toapply_whatsize"
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.Size = New System.Drawing.Size(62, 34)
        Me.tvgs_combobox_tvshow_fanart_toapply_whatsize.TabIndex = 12
        '
        'klbltvmaxtvfanarttodownload
        '
        Me.klbltvmaxtvfanarttodownload.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbltvmaxtvfanarttodownload.Location = New System.Drawing.Point(49, 90)
        Me.klbltvmaxtvfanarttodownload.Name = "klbltvmaxtvfanarttodownload"
        Me.klbltvmaxtvfanarttodownload.Size = New System.Drawing.Size(266, 21)
        Me.klbltvmaxtvfanarttodownload.TabIndex = 6
        Me.klbltvmaxtvfanarttodownload.Text = "How many fanart images Should I download?"
        Me.klbltvmaxtvfanarttodownload.Values.ExtraText = ""
        Me.klbltvmaxtvfanarttodownload.Values.Image = Nothing
        Me.klbltvmaxtvfanarttodownload.Values.Text = "How many fanart images Should I download?"
        '
        'tvgs_knud_tvshow_fanart_download_maxnumber
        '
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.Location = New System.Drawing.Point(2, 86)
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.Name = "tvgs_knud_tvshow_fanart_download_maxnumber"
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.Size = New System.Drawing.Size(43, 33)
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.TabIndex = 0
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.UseMnemonic = False
        Me.tvgs_knud_tvshow_fanart_download_maxnumber.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'kgShowsMI
        '
        Me.kgShowsMI.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgShowsMI.Location = New System.Drawing.Point(3, 206)
        Me.kgShowsMI.Name = "kgShowsMI"
        '
        'kgShowsMI.Panel
        '
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsInsert)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsInlay)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsCD4)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsCD3)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsCD2)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsCD1)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsBack)
        Me.kgShowsMI.Panel.Controls.Add(Me.getMediaImagesShowsFront)
        Me.kgShowsMI.Panel.Controls.Add(Me.KryptonLabel7)
        Me.kgShowsMI.Size = New System.Drawing.Size(788, 95)
        Me.kgShowsMI.TabIndex = 95
        '
        'getMediaImagesShowsInsert
        '
        Me.getMediaImagesShowsInsert.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsInsert.Location = New System.Drawing.Point(607, 59)
        Me.getMediaImagesShowsInsert.Name = "getMediaImagesShowsInsert"
        Me.getMediaImagesShowsInsert.Size = New System.Drawing.Size(92, 21)
        Me.getMediaImagesShowsInsert.TabIndex = 8
        Me.getMediaImagesShowsInsert.Text = "Get Inserts"
        Me.getMediaImagesShowsInsert.Values.ExtraText = ""
        Me.getMediaImagesShowsInsert.Values.Image = Nothing
        Me.getMediaImagesShowsInsert.Values.Text = "Get Inserts"
        '
        'getMediaImagesShowsInlay
        '
        Me.getMediaImagesShowsInlay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsInlay.Location = New System.Drawing.Point(607, 34)
        Me.getMediaImagesShowsInlay.Name = "getMediaImagesShowsInlay"
        Me.getMediaImagesShowsInlay.Size = New System.Drawing.Size(84, 21)
        Me.getMediaImagesShowsInlay.TabIndex = 7
        Me.getMediaImagesShowsInlay.Text = "Get Inlays"
        Me.getMediaImagesShowsInlay.Values.ExtraText = ""
        Me.getMediaImagesShowsInlay.Values.Image = Nothing
        Me.getMediaImagesShowsInlay.Values.Text = "Get Inlays"
        '
        'getMediaImagesShowsCD4
        '
        Me.getMediaImagesShowsCD4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsCD4.Location = New System.Drawing.Point(390, 59)
        Me.getMediaImagesShowsCD4.Name = "getMediaImagesShowsCD4"
        Me.getMediaImagesShowsCD4.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesShowsCD4.TabIndex = 6
        Me.getMediaImagesShowsCD4.Text = "Get CD4 Covers"
        Me.getMediaImagesShowsCD4.Values.ExtraText = ""
        Me.getMediaImagesShowsCD4.Values.Image = Nothing
        Me.getMediaImagesShowsCD4.Values.Text = "Get CD4 Covers"
        '
        'getMediaImagesShowsCD3
        '
        Me.getMediaImagesShowsCD3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsCD3.Location = New System.Drawing.Point(390, 34)
        Me.getMediaImagesShowsCD3.Name = "getMediaImagesShowsCD3"
        Me.getMediaImagesShowsCD3.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesShowsCD3.TabIndex = 5
        Me.getMediaImagesShowsCD3.Text = "Get CD3 Covers"
        Me.getMediaImagesShowsCD3.Values.ExtraText = ""
        Me.getMediaImagesShowsCD3.Values.Image = Nothing
        Me.getMediaImagesShowsCD3.Values.Text = "Get CD3 Covers"
        '
        'getMediaImagesShowsCD2
        '
        Me.getMediaImagesShowsCD2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsCD2.Location = New System.Drawing.Point(179, 61)
        Me.getMediaImagesShowsCD2.Name = "getMediaImagesShowsCD2"
        Me.getMediaImagesShowsCD2.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesShowsCD2.TabIndex = 4
        Me.getMediaImagesShowsCD2.Text = "Get CD2 Covers"
        Me.getMediaImagesShowsCD2.Values.ExtraText = ""
        Me.getMediaImagesShowsCD2.Values.Image = Nothing
        Me.getMediaImagesShowsCD2.Values.Text = "Get CD2 Covers"
        '
        'getMediaImagesShowsCD1
        '
        Me.getMediaImagesShowsCD1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsCD1.Location = New System.Drawing.Point(179, 34)
        Me.getMediaImagesShowsCD1.Name = "getMediaImagesShowsCD1"
        Me.getMediaImagesShowsCD1.Size = New System.Drawing.Size(113, 21)
        Me.getMediaImagesShowsCD1.TabIndex = 3
        Me.getMediaImagesShowsCD1.Text = "Get CD1 Covers"
        Me.getMediaImagesShowsCD1.Values.ExtraText = ""
        Me.getMediaImagesShowsCD1.Values.Image = Nothing
        Me.getMediaImagesShowsCD1.Values.Text = "Get CD1 Covers"
        '
        'getMediaImagesShowsBack
        '
        Me.getMediaImagesShowsBack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsBack.Location = New System.Drawing.Point(7, 61)
        Me.getMediaImagesShowsBack.Name = "getMediaImagesShowsBack"
        Me.getMediaImagesShowsBack.Size = New System.Drawing.Size(118, 21)
        Me.getMediaImagesShowsBack.TabIndex = 2
        Me.getMediaImagesShowsBack.Text = "Get Back Covers"
        Me.getMediaImagesShowsBack.Values.ExtraText = ""
        Me.getMediaImagesShowsBack.Values.Image = Nothing
        Me.getMediaImagesShowsBack.Values.Text = "Get Back Covers"
        '
        'getMediaImagesShowsFront
        '
        Me.getMediaImagesShowsFront.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesShowsFront.Location = New System.Drawing.Point(7, 34)
        Me.getMediaImagesShowsFront.Name = "getMediaImagesShowsFront"
        Me.getMediaImagesShowsFront.Size = New System.Drawing.Size(123, 21)
        Me.getMediaImagesShowsFront.TabIndex = 1
        Me.getMediaImagesShowsFront.Text = "Get Front Covers"
        Me.getMediaImagesShowsFront.Values.ExtraText = ""
        Me.getMediaImagesShowsFront.Values.Image = Nothing
        Me.getMediaImagesShowsFront.Values.Text = "Get Front Covers"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel7.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(776, 21)
        Me.KryptonLabel7.TabIndex = 0
        Me.KryptonLabel7.Text = "Media Images"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Media Images"
        '
        'tcSettings
        '
        Me.tcSettings.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel
        Me.tcSettings.BackColor = System.Drawing.Color.Black
        Me.tcSettings.Controls.Add(Me.tpSettingsGeneral)
        Me.tcSettings.Controls.Add(Me.tpSettingsTvShows)
        Me.tcSettings.Controls.Add(Me.tpSettingsMovies)
        Me.tcSettings.Controls.Add(Me.tpSettingsMusic)
        Me.tcSettings.Controls.Add(Me.tpSettingsHV)
        Me.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSettings.ForeColor = System.Drawing.Color.White
        Me.tcSettings.Location = New System.Drawing.Point(0, 0)
        Me.tcSettings.Name = "tcSettings"
        Me.tcSettings.SelectedIndex = 2
        Me.tcSettings.Size = New System.Drawing.Size(821, 618)
        Me.tcSettings.TabIndex = 88
        Me.tcSettings.UseVisualStyles = False
        '
        'tpSettingsGeneral
        '
        Me.tpSettingsGeneral.Controls.Add(Me.kgGeneralMisc)
        Me.tpSettingsGeneral.Controls.Add(Me.kgGeneralProxy)
        Me.tpSettingsGeneral.Controls.Add(Me.kgTQQIconsGroup)
        Me.tpSettingsGeneral.Controls.Add(Me.kgColorSelect)
        Me.tpSettingsGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tpSettingsGeneral.Name = "tpSettingsGeneral"
        Me.tpSettingsGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSettingsGeneral.Size = New System.Drawing.Size(813, 589)
        Me.tpSettingsGeneral.TabIndex = 0
        Me.tpSettingsGeneral.Text = "General"
        Me.tpSettingsGeneral.UseVisualStyleBackColor = True
        '
        'kgGeneralMisc
        '
        Me.kgGeneralMisc.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgGeneralMisc.Location = New System.Drawing.Point(8, 302)
        Me.kgGeneralMisc.Name = "kgGeneralMisc"
        '
        'kgGeneralMisc.Panel
        '
        Me.kgGeneralMisc.Panel.Controls.Add(Me.cbGeneralSupportSkinBasedFlagging)
        Me.kgGeneralMisc.Panel.Controls.Add(Me.cbtv_showwgetwindows)
        Me.kgGeneralMisc.Panel.Controls.Add(Me.lblGeneralMisc)
        Me.kgGeneralMisc.Panel.Controls.Add(Me.cbGoogleImageSearchPop)
        Me.kgGeneralMisc.Size = New System.Drawing.Size(640, 152)
        Me.kgGeneralMisc.TabIndex = 86
        '
        'cbGeneralSupportSkinBasedFlagging
        '
        Me.cbGeneralSupportSkinBasedFlagging.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGeneralSupportSkinBasedFlagging.Location = New System.Drawing.Point(6, 116)
        Me.cbGeneralSupportSkinBasedFlagging.Name = "cbGeneralSupportSkinBasedFlagging"
        Me.cbGeneralSupportSkinBasedFlagging.Size = New System.Drawing.Size(507, 21)
        Me.cbGeneralSupportSkinBasedFlagging.TabIndex = 81
        Me.cbGeneralSupportSkinBasedFlagging.Text = "Support Skin Based Flagging" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cbGeneralSupportSkinBasedFlagging.Values.ExtraText = "Stores data in Writer Field for Movies, Votes Field for Episodes"
        Me.cbGeneralSupportSkinBasedFlagging.Values.Image = Nothing
        Me.cbGeneralSupportSkinBasedFlagging.Values.Text = "Support Skin Based Flagging" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbtv_showwgetwindows
        '
        Me.cbtv_showwgetwindows.Checked = True
        Me.cbtv_showwgetwindows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbtv_showwgetwindows.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbtv_showwgetwindows.Location = New System.Drawing.Point(3, 59)
        Me.cbtv_showwgetwindows.Name = "cbtv_showwgetwindows"
        Me.cbtv_showwgetwindows.Size = New System.Drawing.Size(379, 21)
        Me.cbtv_showwgetwindows.TabIndex = 80
        Me.cbtv_showwgetwindows.Text = "Show wget windows for TV Show and Music Fanart Downloads"
        Me.cbtv_showwgetwindows.Values.ExtraText = ""
        Me.cbtv_showwgetwindows.Values.Image = Nothing
        Me.cbtv_showwgetwindows.Values.Text = "Show wget windows for TV Show and Music Fanart Downloads"
        '
        'lblGeneralMisc
        '
        Me.lblGeneralMisc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGeneralMisc.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblGeneralMisc.Location = New System.Drawing.Point(0, 0)
        Me.lblGeneralMisc.Name = "lblGeneralMisc"
        Me.lblGeneralMisc.Size = New System.Drawing.Size(628, 21)
        Me.lblGeneralMisc.TabIndex = 76
        Me.lblGeneralMisc.Text = "Misc Options"
        Me.lblGeneralMisc.Values.ExtraText = ""
        Me.lblGeneralMisc.Values.Image = Nothing
        Me.lblGeneralMisc.Values.Text = "Misc Options"
        '
        'kgGeneralProxy
        '
        Me.kgGeneralProxy.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgGeneralProxy.Location = New System.Drawing.Point(11, 467)
        Me.kgGeneralProxy.Name = "kgGeneralProxy"
        '
        'kgGeneralProxy.Panel
        '
        Me.kgGeneralProxy.Panel.Controls.Add(Me.lblIPv4Only)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.lblProxyPort)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.lblProxyIP)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.tbProxyPort)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.tbProxyIP)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.cbUseProxyServer)
        Me.kgGeneralProxy.Panel.Controls.Add(Me.lblGeneralProxy)
        Me.kgGeneralProxy.Size = New System.Drawing.Size(381, 152)
        Me.kgGeneralProxy.TabIndex = 85
        Me.kgGeneralProxy.Visible = False
        '
        'lblIPv4Only
        '
        Me.lblIPv4Only.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIPv4Only.Location = New System.Drawing.Point(0, 119)
        Me.lblIPv4Only.Name = "lblIPv4Only"
        Me.lblIPv4Only.Size = New System.Drawing.Size(369, 21)
        Me.lblIPv4Only.TabIndex = 6
        Me.lblIPv4Only.Text = "Note: IP address must be IPv4, IPv6 is not supported" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblIPv4Only.Values.ExtraText = ""
        Me.lblIPv4Only.Values.Image = Nothing
        Me.lblIPv4Only.Values.Text = "Note: IP address must be IPv4, IPv6 is not supported" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblProxyPort
        '
        Me.lblProxyPort.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblProxyPort.Location = New System.Drawing.Point(4, 82)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(39, 21)
        Me.lblProxyPort.TabIndex = 5
        Me.lblProxyPort.Text = "Port:"
        Me.lblProxyPort.Values.ExtraText = ""
        Me.lblProxyPort.Values.Image = Nothing
        Me.lblProxyPort.Values.Text = "Port:"
        '
        'lblProxyIP
        '
        Me.lblProxyIP.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblProxyIP.Location = New System.Drawing.Point(2, 56)
        Me.lblProxyIP.Name = "lblProxyIP"
        Me.lblProxyIP.Size = New System.Drawing.Size(79, 21)
        Me.lblProxyIP.TabIndex = 4
        Me.lblProxyIP.Text = "IP Address:"
        Me.lblProxyIP.Values.ExtraText = ""
        Me.lblProxyIP.Values.Image = Nothing
        Me.lblProxyIP.Values.Text = "IP Address:"
        '
        'tbProxyPort
        '
        Me.tbProxyPort.Location = New System.Drawing.Point(88, 78)
        Me.tbProxyPort.Name = "tbProxyPort"
        Me.tbProxyPort.Size = New System.Drawing.Size(52, 24)
        Me.tbProxyPort.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbProxyPort.StateCommon.Border.Rounding = 0
        Me.tbProxyPort.StateCommon.Border.Width = 0
        Me.tbProxyPort.TabIndex = 3
        '
        'tbProxyIP
        '
        Me.tbProxyIP.Location = New System.Drawing.Point(88, 52)
        Me.tbProxyIP.Name = "tbProxyIP"
        Me.tbProxyIP.Size = New System.Drawing.Size(219, 24)
        Me.tbProxyIP.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbProxyIP.StateCommon.Border.Rounding = 0
        Me.tbProxyIP.StateCommon.Border.Width = 0
        Me.tbProxyIP.TabIndex = 2
        '
        'cbUseProxyServer
        '
        Me.cbUseProxyServer.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbUseProxyServer.Location = New System.Drawing.Point(6, 30)
        Me.cbUseProxyServer.Name = "cbUseProxyServer"
        Me.cbUseProxyServer.Size = New System.Drawing.Size(125, 21)
        Me.cbUseProxyServer.TabIndex = 1
        Me.cbUseProxyServer.Text = "Use Proxy Server"
        Me.cbUseProxyServer.Values.ExtraText = ""
        Me.cbUseProxyServer.Values.Image = Nothing
        Me.cbUseProxyServer.Values.Text = "Use Proxy Server"
        '
        'lblGeneralProxy
        '
        Me.lblGeneralProxy.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGeneralProxy.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblGeneralProxy.Location = New System.Drawing.Point(0, 0)
        Me.lblGeneralProxy.Name = "lblGeneralProxy"
        Me.lblGeneralProxy.Size = New System.Drawing.Size(369, 21)
        Me.lblGeneralProxy.TabIndex = 0
        Me.lblGeneralProxy.Text = "Proxy Options"
        Me.lblGeneralProxy.Values.ExtraText = ""
        Me.lblGeneralProxy.Values.Image = Nothing
        Me.lblGeneralProxy.Values.Text = "Proxy Options"
        '
        'tpSettingsMovies
        '
        Me.tpSettingsMovies.AutoScroll = True
        Me.tpSettingsMovies.Controls.Add(Me.kgOfdbSettings)
        Me.tpSettingsMovies.Controls.Add(Me.kgMovieSettings)
        Me.tpSettingsMovies.Controls.Add(Me.kgMoviesNameFilters)
        Me.tpSettingsMovies.Controls.Add(Me.kgMovieFileOptions)
        Me.tpSettingsMovies.Controls.Add(Me.kgMovieDownloadOptions)
        Me.tpSettingsMovies.Controls.Add(Me.kgMovieFolderSelect)
        Me.tpSettingsMovies.Location = New System.Drawing.Point(4, 25)
        Me.tpSettingsMovies.Name = "tpSettingsMovies"
        Me.tpSettingsMovies.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSettingsMovies.Size = New System.Drawing.Size(813, 589)
        Me.tpSettingsMovies.TabIndex = 1
        Me.tpSettingsMovies.Text = "Movies"
        Me.tpSettingsMovies.UseVisualStyleBackColor = True
        '
        'kgOfdbSettings
        '
        Me.kgOfdbSettings.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgOfdbSettings.Location = New System.Drawing.Point(2, 1200)
        Me.kgOfdbSettings.Name = "kgOfdbSettings"
        '
        'kgOfdbSettings.Panel
        '
        Me.kgOfdbSettings.Panel.Controls.Add(Me.rbofdb_usePlotOutline)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.rbofdb_englishtagline)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.rbofdb_BlankTagline)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.klblODFBSettingsLabel)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdateVotes)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdateRating)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdateGenre)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdatePlot)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdateOutline)
        Me.kgOfdbSettings.Panel.Controls.Add(Me.cbofdb_UpdateTitle)
        Me.kgOfdbSettings.Size = New System.Drawing.Size(787, 172)
        Me.kgOfdbSettings.TabIndex = 88
        '
        'rbofdb_usePlotOutline
        '
        Me.rbofdb_usePlotOutline.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.rbofdb_usePlotOutline.Location = New System.Drawing.Point(316, 94)
        Me.rbofdb_usePlotOutline.Name = "rbofdb_usePlotOutline"
        Me.rbofdb_usePlotOutline.Size = New System.Drawing.Size(184, 21)
        Me.rbofdb_usePlotOutline.TabIndex = 13
        Me.rbofdb_usePlotOutline.Text = "Use Plot Outline for Tagline"
        Me.rbofdb_usePlotOutline.Values.ExtraText = ""
        Me.rbofdb_usePlotOutline.Values.Image = Nothing
        Me.rbofdb_usePlotOutline.Values.Text = "Use Plot Outline for Tagline"
        '
        'rbofdb_englishtagline
        '
        Me.rbofdb_englishtagline.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.rbofdb_englishtagline.Location = New System.Drawing.Point(316, 72)
        Me.rbofdb_englishtagline.Name = "rbofdb_englishtagline"
        Me.rbofdb_englishtagline.Size = New System.Drawing.Size(108, 21)
        Me.rbofdb_englishtagline.TabIndex = 12
        Me.rbofdb_englishtagline.Text = "English Tagline"
        Me.rbofdb_englishtagline.Values.ExtraText = ""
        Me.rbofdb_englishtagline.Values.Image = Nothing
        Me.rbofdb_englishtagline.Values.Text = "English Tagline"
        '
        'rbofdb_BlankTagline
        '
        Me.rbofdb_BlankTagline.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.rbofdb_BlankTagline.Location = New System.Drawing.Point(316, 52)
        Me.rbofdb_BlankTagline.Name = "rbofdb_BlankTagline"
        Me.rbofdb_BlankTagline.Size = New System.Drawing.Size(98, 21)
        Me.rbofdb_BlankTagline.TabIndex = 11
        Me.rbofdb_BlankTagline.Text = "Blank Tagline"
        Me.rbofdb_BlankTagline.Values.ExtraText = ""
        Me.rbofdb_BlankTagline.Values.Image = Nothing
        Me.rbofdb_BlankTagline.Values.Text = "Blank Tagline"
        '
        'klblODFBSettingsLabel
        '
        Me.klblODFBSettingsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblODFBSettingsLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblODFBSettingsLabel.Location = New System.Drawing.Point(0, 0)
        Me.klblODFBSettingsLabel.Name = "klblODFBSettingsLabel"
        Me.klblODFBSettingsLabel.Size = New System.Drawing.Size(775, 21)
        Me.klblODFBSettingsLabel.TabIndex = 10
        Me.klblODFBSettingsLabel.Text = "OFDB Settings"
        Me.klblODFBSettingsLabel.Values.ExtraText = ""
        Me.klblODFBSettingsLabel.Values.Image = Nothing
        Me.klblODFBSettingsLabel.Values.Text = "OFDB Settings"
        '
        'cbofdb_UpdateVotes
        '
        Me.cbofdb_UpdateVotes.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdateVotes.Location = New System.Drawing.Point(8, 140)
        Me.cbofdb_UpdateVotes.Name = "cbofdb_UpdateVotes"
        Me.cbofdb_UpdateVotes.Size = New System.Drawing.Size(102, 21)
        Me.cbofdb_UpdateVotes.TabIndex = 5
        Me.cbofdb_UpdateVotes.Text = "Update Votes"
        Me.cbofdb_UpdateVotes.Values.ExtraText = ""
        Me.cbofdb_UpdateVotes.Values.Image = Nothing
        Me.cbofdb_UpdateVotes.Values.Text = "Update Votes"
        '
        'cbofdb_UpdateRating
        '
        Me.cbofdb_UpdateRating.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdateRating.Location = New System.Drawing.Point(8, 118)
        Me.cbofdb_UpdateRating.Name = "cbofdb_UpdateRating"
        Me.cbofdb_UpdateRating.Size = New System.Drawing.Size(105, 21)
        Me.cbofdb_UpdateRating.TabIndex = 4
        Me.cbofdb_UpdateRating.Text = "Update Rating"
        Me.cbofdb_UpdateRating.Values.ExtraText = ""
        Me.cbofdb_UpdateRating.Values.Image = Nothing
        Me.cbofdb_UpdateRating.Values.Text = "Update Rating"
        '
        'cbofdb_UpdateGenre
        '
        Me.cbofdb_UpdateGenre.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdateGenre.Location = New System.Drawing.Point(8, 96)
        Me.cbofdb_UpdateGenre.Name = "cbofdb_UpdateGenre"
        Me.cbofdb_UpdateGenre.Size = New System.Drawing.Size(103, 21)
        Me.cbofdb_UpdateGenre.TabIndex = 3
        Me.cbofdb_UpdateGenre.Text = "Update Genre"
        Me.cbofdb_UpdateGenre.Values.ExtraText = ""
        Me.cbofdb_UpdateGenre.Values.Image = Nothing
        Me.cbofdb_UpdateGenre.Values.Text = "Update Genre"
        '
        'cbofdb_UpdatePlot
        '
        Me.cbofdb_UpdatePlot.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdatePlot.Location = New System.Drawing.Point(7, 52)
        Me.cbofdb_UpdatePlot.Name = "cbofdb_UpdatePlot"
        Me.cbofdb_UpdatePlot.Size = New System.Drawing.Size(91, 21)
        Me.cbofdb_UpdatePlot.TabIndex = 2
        Me.cbofdb_UpdatePlot.Text = "Update Plot"
        Me.cbofdb_UpdatePlot.Values.ExtraText = ""
        Me.cbofdb_UpdatePlot.Values.Image = Nothing
        Me.cbofdb_UpdatePlot.Values.Text = "Update Plot"
        '
        'cbofdb_UpdateOutline
        '
        Me.cbofdb_UpdateOutline.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdateOutline.Location = New System.Drawing.Point(7, 74)
        Me.cbofdb_UpdateOutline.Name = "cbofdb_UpdateOutline"
        Me.cbofdb_UpdateOutline.Size = New System.Drawing.Size(137, 21)
        Me.cbofdb_UpdateOutline.TabIndex = 1
        Me.cbofdb_UpdateOutline.Text = "Update Plot Outline"
        Me.cbofdb_UpdateOutline.Values.ExtraText = ""
        Me.cbofdb_UpdateOutline.Values.Image = Nothing
        Me.cbofdb_UpdateOutline.Values.Text = "Update Plot Outline"
        '
        'cbofdb_UpdateTitle
        '
        Me.cbofdb_UpdateTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbofdb_UpdateTitle.Location = New System.Drawing.Point(7, 30)
        Me.cbofdb_UpdateTitle.Name = "cbofdb_UpdateTitle"
        Me.cbofdb_UpdateTitle.Size = New System.Drawing.Size(97, 21)
        Me.cbofdb_UpdateTitle.TabIndex = 0
        Me.cbofdb_UpdateTitle.Text = "Update Title"
        Me.cbofdb_UpdateTitle.Values.ExtraText = ""
        Me.cbofdb_UpdateTitle.Values.Image = Nothing
        Me.cbofdb_UpdateTitle.Values.Text = "Update Title"
        '
        'kgMoviesNameFilters
        '
        Me.kgMoviesNameFilters.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMoviesNameFilters.Location = New System.Drawing.Point(1, 1378)
        Me.kgMoviesNameFilters.Name = "kgMoviesNameFilters"
        '
        'kgMoviesNameFilters.Panel
        '
        Me.kgMoviesNameFilters.Panel.Controls.Add(Me.kgFileLevelFilterOptions)
        Me.kgMoviesNameFilters.Panel.Controls.Add(Me.lblMoviesNameFilterl)
        Me.kgMoviesNameFilters.Panel.Controls.Add(Me.kgNameFilter)
        Me.kgMoviesNameFilters.Size = New System.Drawing.Size(789, 840)
        Me.kgMoviesNameFilters.TabIndex = 87
        '
        'kgFileLevelFilterOptions
        '
        Me.kgFileLevelFilterOptions.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgFileLevelFilterOptions.Location = New System.Drawing.Point(8, 468)
        Me.kgFileLevelFilterOptions.Name = "kgFileLevelFilterOptions"
        '
        'kgFileLevelFilterOptions.Panel
        '
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.lblUsingCustomExpression)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.tbFilterNameFileModeEverythingBeforeUserDefined1)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBeforeUserDefined1)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbShowsStripEverythinginParan)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBeforeDash)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFileLevelFilterUnderscoreDot)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBefore1080p)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBefore1080i)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBefore720p)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBeforex264)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBeforeh264)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.lblMovieFileLevelFiltersWhatTheyDo)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.cbFilterNameFileModeEverythingBeforeYear)
        Me.kgFileLevelFilterOptions.Panel.Controls.Add(Me.lblMoviesFileLevelFilterOptions)
        Me.kgFileLevelFilterOptions.Size = New System.Drawing.Size(772, 363)
        Me.kgFileLevelFilterOptions.TabIndex = 1
        '
        'lblUsingCustomExpression
        '
        Me.lblUsingCustomExpression.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblUsingCustomExpression.Location = New System.Drawing.Point(499, 88)
        Me.lblUsingCustomExpression.Name = "lblUsingCustomExpression"
        Me.lblUsingCustomExpression.Size = New System.Drawing.Size(215, 114)
        Me.lblUsingCustomExpression.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblUsingCustomExpression.TabIndex = 78
        Me.lblUsingCustomExpression.Text = "Example: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(.*)german " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will get all the information beofre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "german in " & _
            "the file name." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not case sensitive" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblUsingCustomExpression.Values.ExtraText = ""
        Me.lblUsingCustomExpression.Values.Image = Nothing
        Me.lblUsingCustomExpression.Values.Text = "Example: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(.*)german " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will get all the information beofre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "german in " & _
            "the file name." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not case sensitive" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbFilterNameFileModeEverythingBeforeUserDefined1
        '
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1.Location = New System.Drawing.Point(499, 63)
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1.Name = "tbFilterNameFileModeEverythingBeforeUserDefined1"
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1.Size = New System.Drawing.Size(142, 19)
        Me.tbFilterNameFileModeEverythingBeforeUserDefined1.TabIndex = 77
        '
        'cbFilterNameFileModeEverythingBeforeUserDefined1
        '
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Location = New System.Drawing.Point(357, 67)
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Name = "cbFilterNameFileModeEverythingBeforeUserDefined1"
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Size = New System.Drawing.Size(403, 18)
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.StateDisabled.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.TabIndex = 76
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Text = "Use everything before _____________________  as the Movie Name"
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBeforeUserDefined1.Values.Text = "Use everything before _____________________  as the Movie Name"
        '
        'cbShowsStripEverythinginParan
        '
        Me.cbShowsStripEverythinginParan.Checked = True
        Me.cbShowsStripEverythinginParan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowsStripEverythinginParan.Enabled = False
        Me.cbShowsStripEverythinginParan.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbShowsStripEverythinginParan.Location = New System.Drawing.Point(385, 327)
        Me.cbShowsStripEverythinginParan.Name = "cbShowsStripEverythinginParan"
        Me.cbShowsStripEverythinginParan.Size = New System.Drawing.Size(260, 21)
        Me.cbShowsStripEverythinginParan.TabIndex = 75
        Me.cbShowsStripEverythinginParan.Text = "Strip out everything in ( ) from the name"
        Me.cbShowsStripEverythinginParan.Values.ExtraText = ""
        Me.cbShowsStripEverythinginParan.Values.Image = Nothing
        Me.cbShowsStripEverythinginParan.Values.Text = "Strip out everything in ( ) from the name"
        '
        'cbFilterNameFileModeEverythingBeforeDash
        '
        Me.cbFilterNameFileModeEverythingBeforeDash.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBeforeDash.Location = New System.Drawing.Point(6, 67)
        Me.cbFilterNameFileModeEverythingBeforeDash.Name = "cbFilterNameFileModeEverythingBeforeDash"
        Me.cbFilterNameFileModeEverythingBeforeDash.Size = New System.Drawing.Size(329, 21)
        Me.cbFilterNameFileModeEverythingBeforeDash.TabIndex = 74
        Me.cbFilterNameFileModeEverythingBeforeDash.Text = "Use everything before a -  (dash) as the Movie Name"
        Me.cbFilterNameFileModeEverythingBeforeDash.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBeforeDash.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBeforeDash.Values.Text = "Use everything before a -  (dash) as the Movie Name"
        '
        'cbFileLevelFilterUnderscoreDot
        '
        Me.cbFileLevelFilterUnderscoreDot.Checked = True
        Me.cbFileLevelFilterUnderscoreDot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFileLevelFilterUnderscoreDot.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFileLevelFilterUnderscoreDot.Location = New System.Drawing.Point(5, 327)
        Me.cbFileLevelFilterUnderscoreDot.Name = "cbFileLevelFilterUnderscoreDot"
        Me.cbFileLevelFilterUnderscoreDot.Size = New System.Drawing.Size(174, 21)
        Me.cbFileLevelFilterUnderscoreDot.TabIndex = 73
        Me.cbFileLevelFilterUnderscoreDot.Text = "Replace _ and . with space"
        Me.cbFileLevelFilterUnderscoreDot.Values.ExtraText = ""
        Me.cbFileLevelFilterUnderscoreDot.Values.Image = Nothing
        Me.cbFileLevelFilterUnderscoreDot.Values.Text = "Replace _ and . with space"
        '
        'cbFilterNameFileModeEverythingBefore1080p
        '
        Me.cbFilterNameFileModeEverythingBefore1080p.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBefore1080p.Location = New System.Drawing.Point(5, 254)
        Me.cbFilterNameFileModeEverythingBefore1080p.Name = "cbFilterNameFileModeEverythingBefore1080p"
        Me.cbFilterNameFileModeEverythingBefore1080p.Size = New System.Drawing.Size(329, 21)
        Me.cbFilterNameFileModeEverythingBefore1080p.TabIndex = 8
        Me.cbFilterNameFileModeEverythingBefore1080p.Text = "Use everything before the 1080p as the Movie Name"
        Me.cbFilterNameFileModeEverythingBefore1080p.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBefore1080p.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBefore1080p.Values.Text = "Use everything before the 1080p as the Movie Name"
        '
        'cbFilterNameFileModeEverythingBefore1080i
        '
        Me.cbFilterNameFileModeEverythingBefore1080i.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBefore1080i.Location = New System.Drawing.Point(5, 216)
        Me.cbFilterNameFileModeEverythingBefore1080i.Name = "cbFilterNameFileModeEverythingBefore1080i"
        Me.cbFilterNameFileModeEverythingBefore1080i.Size = New System.Drawing.Size(326, 21)
        Me.cbFilterNameFileModeEverythingBefore1080i.TabIndex = 7
        Me.cbFilterNameFileModeEverythingBefore1080i.Text = "Use everything before the 1080i as the Movie Name"
        Me.cbFilterNameFileModeEverythingBefore1080i.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBefore1080i.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBefore1080i.Values.Text = "Use everything before the 1080i as the Movie Name"
        '
        'cbFilterNameFileModeEverythingBefore720p
        '
        Me.cbFilterNameFileModeEverythingBefore720p.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBefore720p.Location = New System.Drawing.Point(5, 178)
        Me.cbFilterNameFileModeEverythingBefore720p.Name = "cbFilterNameFileModeEverythingBefore720p"
        Me.cbFilterNameFileModeEverythingBefore720p.Size = New System.Drawing.Size(323, 21)
        Me.cbFilterNameFileModeEverythingBefore720p.TabIndex = 6
        Me.cbFilterNameFileModeEverythingBefore720p.Text = "Use everything before the 720p as the Movie Name"
        Me.cbFilterNameFileModeEverythingBefore720p.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBefore720p.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBefore720p.Values.Text = "Use everything before the 720p as the Movie Name"
        '
        'cbFilterNameFileModeEverythingBeforex264
        '
        Me.cbFilterNameFileModeEverythingBeforex264.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBeforex264.Location = New System.Drawing.Point(5, 140)
        Me.cbFilterNameFileModeEverythingBeforex264.Name = "cbFilterNameFileModeEverythingBeforex264"
        Me.cbFilterNameFileModeEverythingBeforex264.Size = New System.Drawing.Size(324, 21)
        Me.cbFilterNameFileModeEverythingBeforex264.TabIndex = 5
        Me.cbFilterNameFileModeEverythingBeforex264.Text = "Use everything before the x264 as the Movie Name"
        Me.cbFilterNameFileModeEverythingBeforex264.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBeforex264.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBeforex264.Values.Text = "Use everything before the x264 as the Movie Name"
        '
        'cbFilterNameFileModeEverythingBeforeh264
        '
        Me.cbFilterNameFileModeEverythingBeforeh264.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBeforeh264.Location = New System.Drawing.Point(5, 102)
        Me.cbFilterNameFileModeEverythingBeforeh264.Name = "cbFilterNameFileModeEverythingBeforeh264"
        Me.cbFilterNameFileModeEverythingBeforeh264.Size = New System.Drawing.Size(324, 21)
        Me.cbFilterNameFileModeEverythingBeforeh264.TabIndex = 4
        Me.cbFilterNameFileModeEverythingBeforeh264.Text = "Use everything before the h264 as the Movie Name"
        Me.cbFilterNameFileModeEverythingBeforeh264.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBeforeh264.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBeforeh264.Values.Text = "Use everything before the h264 as the Movie Name"
        '
        'lblMovieFileLevelFiltersWhatTheyDo
        '
        Me.lblMovieFileLevelFiltersWhatTheyDo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieFileLevelFiltersWhatTheyDo.Location = New System.Drawing.Point(1, 23)
        Me.lblMovieFileLevelFiltersWhatTheyDo.Name = "lblMovieFileLevelFiltersWhatTheyDo"
        Me.lblMovieFileLevelFiltersWhatTheyDo.Size = New System.Drawing.Size(500, 21)
        Me.lblMovieFileLevelFiltersWhatTheyDo.TabIndex = 3
        Me.lblMovieFileLevelFiltersWhatTheyDo.Text = "File Level Filters will look in the name and use everything up until the selected" & _
            " option"
        Me.lblMovieFileLevelFiltersWhatTheyDo.Values.ExtraText = ""
        Me.lblMovieFileLevelFiltersWhatTheyDo.Values.Image = Nothing
        Me.lblMovieFileLevelFiltersWhatTheyDo.Values.Text = "File Level Filters will look in the name and use everything up until the selected" & _
            " option"
        '
        'cbFilterNameFileModeEverythingBeforeYear
        '
        Me.cbFilterNameFileModeEverythingBeforeYear.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbFilterNameFileModeEverythingBeforeYear.Location = New System.Drawing.Point(4, 289)
        Me.cbFilterNameFileModeEverythingBeforeYear.Name = "cbFilterNameFileModeEverythingBeforeYear"
        Me.cbFilterNameFileModeEverythingBeforeYear.Size = New System.Drawing.Size(321, 21)
        Me.cbFilterNameFileModeEverythingBeforeYear.TabIndex = 2
        Me.cbFilterNameFileModeEverythingBeforeYear.Text = "Use everything before the Year as the Movie Name"
        Me.cbFilterNameFileModeEverythingBeforeYear.Values.ExtraText = ""
        Me.cbFilterNameFileModeEverythingBeforeYear.Values.Image = Nothing
        Me.cbFilterNameFileModeEverythingBeforeYear.Values.Text = "Use everything before the Year as the Movie Name"
        '
        'lblMoviesFileLevelFilterOptions
        '
        Me.lblMoviesFileLevelFilterOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMoviesFileLevelFilterOptions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMoviesFileLevelFilterOptions.Location = New System.Drawing.Point(0, 0)
        Me.lblMoviesFileLevelFilterOptions.Name = "lblMoviesFileLevelFilterOptions"
        Me.lblMoviesFileLevelFilterOptions.Size = New System.Drawing.Size(760, 21)
        Me.lblMoviesFileLevelFilterOptions.TabIndex = 0
        Me.lblMoviesFileLevelFilterOptions.Text = "File Level Filter Options"
        Me.lblMoviesFileLevelFilterOptions.Values.ExtraText = ""
        Me.lblMoviesFileLevelFilterOptions.Values.Image = Nothing
        Me.lblMoviesFileLevelFilterOptions.Values.Text = "File Level Filter Options"
        '
        'lblMoviesNameFilterl
        '
        Me.lblMoviesNameFilterl.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMoviesNameFilterl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMoviesNameFilterl.Location = New System.Drawing.Point(0, 0)
        Me.lblMoviesNameFilterl.Name = "lblMoviesNameFilterl"
        Me.lblMoviesNameFilterl.Size = New System.Drawing.Size(777, 21)
        Me.lblMoviesNameFilterl.TabIndex = 0
        Me.lblMoviesNameFilterl.Text = "Name Filters"
        Me.lblMoviesNameFilterl.Values.ExtraText = ""
        Me.lblMoviesNameFilterl.Values.Image = Nothing
        Me.lblMoviesNameFilterl.Values.Text = "Name Filters"
        '
        'kgMovieFileOptions
        '
        Me.kgMovieFileOptions.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMovieFileOptions.Location = New System.Drawing.Point(1, 398)
        Me.kgMovieFileOptions.Name = "kgMovieFileOptions"
        '
        'kgMovieFileOptions.Panel
        '
        Me.kgMovieFileOptions.Panel.Controls.Add(Me.lblFCASOMovies)
        Me.kgMovieFileOptions.Panel.Controls.Add(Me.kgNFOFANARTsettings)
        Me.kgMovieFileOptions.Panel.Controls.Add(Me.kgAutomaticGenerationSettings)
        Me.kgMovieFileOptions.Size = New System.Drawing.Size(786, 250)
        Me.kgMovieFileOptions.TabIndex = 86
        '
        'lblFCASOMovies
        '
        Me.lblFCASOMovies.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFCASOMovies.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblFCASOMovies.Location = New System.Drawing.Point(0, 0)
        Me.lblFCASOMovies.Name = "lblFCASOMovies"
        Me.lblFCASOMovies.Size = New System.Drawing.Size(774, 21)
        Me.lblFCASOMovies.TabIndex = 86
        Me.lblFCASOMovies.Text = "File Creation and Scanning Options"
        Me.lblFCASOMovies.Values.ExtraText = ""
        Me.lblFCASOMovies.Values.Image = Nothing
        Me.lblFCASOMovies.Values.Text = "File Creation and Scanning Options"
        '
        'kgMovieFolderSelect
        '
        Me.kgMovieFolderSelect.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMovieFolderSelect.Location = New System.Drawing.Point(1, 1)
        Me.kgMovieFolderSelect.Name = "kgMovieFolderSelect"
        '
        'kgMovieFolderSelect.Panel
        '
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.lblFolderNameForMovieName)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.lblVfoldermode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.lblVFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.lblFolderMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.klblRemoveamoivefolder)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.lblFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesBrowseForFolderFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesClearFolderListFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.tbFolderFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesAddFolderByPathFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.clbPathsFileMode)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesBrowseForFolder)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesClearFolderList)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.tbFolder)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesAddFolderByPath)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.clbPaths)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.klMovieFolderGroup)
        Me.kgMovieFolderSelect.Size = New System.Drawing.Size(789, 391)
        Me.kgMovieFolderSelect.TabIndex = 83
        '
        'lblFolderNameForMovieName
        '
        Me.lblFolderNameForMovieName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblFolderNameForMovieName.Location = New System.Drawing.Point(483, 8)
        Me.lblFolderNameForMovieName.Name = "lblFolderNameForMovieName"
        Me.lblFolderNameForMovieName.Size = New System.Drawing.Size(212, 21)
        Me.lblFolderNameForMovieName.TabIndex = 101
        Me.lblFolderNameForMovieName.Text = "Uses Folder Name for Movie Name"
        Me.lblFolderNameForMovieName.Values.ExtraText = ""
        Me.lblFolderNameForMovieName.Values.Image = Nothing
        Me.lblFolderNameForMovieName.Values.Text = "Uses Folder Name for Movie Name"
        '
        'lblVfoldermode
        '
        Me.lblVfoldermode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblVfoldermode.Location = New System.Drawing.Point(9, 71)
        Me.lblVfoldermode.Name = "lblVfoldermode"
        Me.lblVfoldermode.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.lblVfoldermode.Size = New System.Drawing.Size(21, 81)
        Me.lblVfoldermode.TabIndex = 100
        Me.lblVfoldermode.Text = "Folder Level"
        Me.lblVfoldermode.Values.ExtraText = ""
        Me.lblVfoldermode.Values.Image = Nothing
        Me.lblVfoldermode.Values.Text = "Folder Level"
        '
        'lblVFileMode
        '
        Me.lblVFileMode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblVFileMode.Location = New System.Drawing.Point(9, 241)
        Me.lblVFileMode.Name = "lblVFileMode"
        Me.lblVFileMode.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.lblVFileMode.Size = New System.Drawing.Size(21, 65)
        Me.lblVFileMode.TabIndex = 99
        Me.lblVFileMode.Text = "File Level"
        Me.lblVFileMode.Values.ExtraText = ""
        Me.lblVFileMode.Values.Image = Nothing
        Me.lblVFileMode.Values.Text = "File Level"
        '
        'lblFolderMode
        '
        Me.lblFolderMode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblFolderMode.Location = New System.Drawing.Point(30, 26)
        Me.lblFolderMode.Name = "lblFolderMode"
        Me.lblFolderMode.Size = New System.Drawing.Size(402, 21)
        Me.lblFolderMode.TabIndex = 98
        Me.lblFolderMode.Text = "Folder Level: Got seperate folders for each movie? Add those here!"
        Me.lblFolderMode.Values.ExtraText = ""
        Me.lblFolderMode.Values.Image = Nothing
        Me.lblFolderMode.Values.Text = "Folder Level: Got seperate folders for each movie? Add those here!"
        '
        'klblRemoveamoivefolder
        '
        Me.klblRemoveamoivefolder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.klblRemoveamoivefolder.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblRemoveamoivefolder.Location = New System.Drawing.Point(0, 358)
        Me.klblRemoveamoivefolder.Name = "klblRemoveamoivefolder"
        Me.klblRemoveamoivefolder.Size = New System.Drawing.Size(777, 21)
        Me.klblRemoveamoivefolder.TabIndex = 93
        Me.klblRemoveamoivefolder.Text = "To remove a Movie Folder - Highlight and Right Click the mouse"
        Me.klblRemoveamoivefolder.Values.ExtraText = ""
        Me.klblRemoveamoivefolder.Values.Image = Nothing
        Me.klblRemoveamoivefolder.Values.Text = "To remove a Movie Folder - Highlight and Right Click the mouse"
        '
        'lblFileMode
        '
        Me.lblFileMode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblFileMode.Location = New System.Drawing.Point(41, 201)
        Me.lblFileMode.Name = "lblFileMode"
        Me.lblFileMode.Size = New System.Drawing.Size(386, 21)
        Me.lblFileMode.TabIndex = 97
        Me.lblFileMode.Text = "File Level: Got a folder full of different movies? Add those here!"
        Me.lblFileMode.Values.ExtraText = ""
        Me.lblFileMode.Values.Image = Nothing
        Me.lblFileMode.Values.Text = "File Level: Got a folder full of different movies? Add those here!"
        '
        'btnMoviesBrowseForFolderFileMode
        '
        Me.btnMoviesBrowseForFolderFileMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMoviesBrowseForFolderFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesBrowseForFolderFileMode.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesBrowseForFolderFileMode.Location = New System.Drawing.Point(548, 220)
        Me.btnMoviesBrowseForFolderFileMode.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoviesBrowseForFolderFileMode.Name = "btnMoviesBrowseForFolderFileMode"
        Me.btnMoviesBrowseForFolderFileMode.Size = New System.Drawing.Size(104, 36)
        Me.btnMoviesBrowseForFolderFileMode.TabIndex = 92
        Me.btnMoviesBrowseForFolderFileMode.Text = "Browse"
        Me.btnMoviesBrowseForFolderFileMode.Values.ExtraText = ""
        Me.btnMoviesBrowseForFolderFileMode.Values.Image = Nothing
        Me.btnMoviesBrowseForFolderFileMode.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesBrowseForFolderFileMode.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesBrowseForFolderFileMode.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesBrowseForFolderFileMode.Values.Text = "Browse"
        '
        'btnMoviesClearFolderListFileMode
        '
        Me.btnMoviesClearFolderListFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesClearFolderListFileMode.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesClearFolderListFileMode.Location = New System.Drawing.Point(652, 220)
        Me.btnMoviesClearFolderListFileMode.Name = "btnMoviesClearFolderListFileMode"
        Me.btnMoviesClearFolderListFileMode.Size = New System.Drawing.Size(112, 36)
        Me.btnMoviesClearFolderListFileMode.TabIndex = 96
        Me.btnMoviesClearFolderListFileMode.Text = "Clear List"
        Me.btnMoviesClearFolderListFileMode.Values.ExtraText = ""
        Me.btnMoviesClearFolderListFileMode.Values.Image = Nothing
        Me.btnMoviesClearFolderListFileMode.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesClearFolderListFileMode.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesClearFolderListFileMode.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesClearFolderListFileMode.Values.Text = "Clear List"
        '
        'tbFolderFileMode
        '
        Me.tbFolderFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolderFileMode.Location = New System.Drawing.Point(41, 233)
        Me.tbFolderFileMode.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolderFileMode.Name = "tbFolderFileMode"
        Me.tbFolderFileMode.Size = New System.Drawing.Size(389, 22)
        Me.tbFolderFileMode.TabIndex = 93
        Me.tbFolderFileMode.Text = "Enter the path and click add or click browse to select"
        '
        'btnMoviesAddFolderByPathFileMode
        '
        Me.btnMoviesAddFolderByPathFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesAddFolderByPathFileMode.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesAddFolderByPathFileMode.Location = New System.Drawing.Point(432, 220)
        Me.btnMoviesAddFolderByPathFileMode.Name = "btnMoviesAddFolderByPathFileMode"
        Me.btnMoviesAddFolderByPathFileMode.Size = New System.Drawing.Size(116, 36)
        Me.btnMoviesAddFolderByPathFileMode.TabIndex = 95
        Me.btnMoviesAddFolderByPathFileMode.Text = "Add Path"
        Me.btnMoviesAddFolderByPathFileMode.Values.ExtraText = ""
        Me.btnMoviesAddFolderByPathFileMode.Values.Image = Nothing
        Me.btnMoviesAddFolderByPathFileMode.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesAddFolderByPathFileMode.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesAddFolderByPathFileMode.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesAddFolderByPathFileMode.Values.Text = "Add Path"
        '
        'clbPathsFileMode
        '
        Me.clbPathsFileMode.CheckOnClick = True
        Me.clbPathsFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbPathsFileMode.FormattingEnabled = True
        Me.clbPathsFileMode.Location = New System.Drawing.Point(43, 257)
        Me.clbPathsFileMode.Name = "clbPathsFileMode"
        Me.clbPathsFileMode.Size = New System.Drawing.Size(715, 106)
        Me.clbPathsFileMode.TabIndex = 94
        '
        'btnMoviesBrowseForFolder
        '
        Me.btnMoviesBrowseForFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMoviesBrowseForFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesBrowseForFolder.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesBrowseForFolder.Location = New System.Drawing.Point(546, 49)
        Me.btnMoviesBrowseForFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoviesBrowseForFolder.Name = "btnMoviesBrowseForFolder"
        Me.btnMoviesBrowseForFolder.Size = New System.Drawing.Size(104, 36)
        Me.btnMoviesBrowseForFolder.TabIndex = 7
        Me.btnMoviesBrowseForFolder.Text = "Browse"
        Me.btnMoviesBrowseForFolder.Values.ExtraText = ""
        Me.btnMoviesBrowseForFolder.Values.Image = Nothing
        Me.btnMoviesBrowseForFolder.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesBrowseForFolder.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesBrowseForFolder.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesBrowseForFolder.Values.Text = "Browse"
        '
        'btnMoviesClearFolderList
        '
        Me.btnMoviesClearFolderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesClearFolderList.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesClearFolderList.Location = New System.Drawing.Point(650, 49)
        Me.btnMoviesClearFolderList.Name = "btnMoviesClearFolderList"
        Me.btnMoviesClearFolderList.Size = New System.Drawing.Size(112, 36)
        Me.btnMoviesClearFolderList.TabIndex = 45
        Me.btnMoviesClearFolderList.Text = "Clear List"
        Me.btnMoviesClearFolderList.Values.ExtraText = ""
        Me.btnMoviesClearFolderList.Values.Image = Nothing
        Me.btnMoviesClearFolderList.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesClearFolderList.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesClearFolderList.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesClearFolderList.Values.Text = "Clear List"
        '
        'tbFolder
        '
        Me.tbFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolder.Location = New System.Drawing.Point(41, 60)
        Me.tbFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Size = New System.Drawing.Size(387, 22)
        Me.tbFolder.TabIndex = 8
        Me.tbFolder.Text = "Enter the path and click add or click browse to select"
        '
        'btnMoviesAddFolderByPath
        '
        Me.btnMoviesAddFolderByPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesAddFolderByPath.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesAddFolderByPath.Location = New System.Drawing.Point(430, 49)
        Me.btnMoviesAddFolderByPath.Name = "btnMoviesAddFolderByPath"
        Me.btnMoviesAddFolderByPath.Size = New System.Drawing.Size(116, 36)
        Me.btnMoviesAddFolderByPath.TabIndex = 44
        Me.btnMoviesAddFolderByPath.Text = "Add Path"
        Me.btnMoviesAddFolderByPath.Values.ExtraText = ""
        Me.btnMoviesAddFolderByPath.Values.Image = Nothing
        Me.btnMoviesAddFolderByPath.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesAddFolderByPath.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesAddFolderByPath.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesAddFolderByPath.Values.Text = "Add Path"
        '
        'clbPaths
        '
        Me.clbPaths.CheckOnClick = True
        Me.clbPaths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbPaths.FormattingEnabled = True
        Me.clbPaths.Location = New System.Drawing.Point(43, 86)
        Me.clbPaths.Name = "clbPaths"
        Me.clbPaths.Size = New System.Drawing.Size(715, 106)
        Me.clbPaths.TabIndex = 43
        '
        'klMovieFolderGroup
        '
        Me.klMovieFolderGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.klMovieFolderGroup.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klMovieFolderGroup.Location = New System.Drawing.Point(0, 0)
        Me.klMovieFolderGroup.Name = "klMovieFolderGroup"
        Me.klMovieFolderGroup.Size = New System.Drawing.Size(777, 21)
        Me.klMovieFolderGroup.TabIndex = 46
        Me.klMovieFolderGroup.Text = "Movie Folder Locations - Select the root Movie Folders"
        Me.klMovieFolderGroup.Values.ExtraText = ""
        Me.klMovieFolderGroup.Values.Image = Nothing
        Me.klMovieFolderGroup.Values.Text = "Movie Folder Locations - Select the root Movie Folders"
        '
        'tpSettingsTvShows
        '
        Me.tpSettingsTvShows.AutoScroll = True
        Me.tpSettingsTvShows.Controls.Add(Me.kgShowsMI)
        Me.tpSettingsTvShows.Controls.Add(Me.kgTvshowpaths)
        Me.tpSettingsTvShows.Controls.Add(Me.kgTVShowSettings)
        Me.tpSettingsTvShows.Location = New System.Drawing.Point(4, 25)
        Me.tpSettingsTvShows.Name = "tpSettingsTvShows"
        Me.tpSettingsTvShows.Size = New System.Drawing.Size(813, 589)
        Me.tpSettingsTvShows.TabIndex = 2
        Me.tpSettingsTvShows.Text = "Shows"
        Me.tpSettingsTvShows.UseVisualStyleBackColor = True
        '
        'kgTvshowpaths
        '
        Me.kgTvshowpaths.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgTvshowpaths.Location = New System.Drawing.Point(3, 0)
        Me.kgTvshowpaths.Name = "kgTvshowpaths"
        '
        'kgTvshowpaths.Panel
        '
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVBrowse)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.klblRemoveatvshow1)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.tbTVPath)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVClearList)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVAddPath)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.lbTVShows)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.klbTVShowFolders)
        Me.kgTvshowpaths.Size = New System.Drawing.Size(785, 200)
        Me.kgTvshowpaths.TabIndex = 88
        '
        'btnTVBrowse
        '
        Me.btnTVBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTVBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnTVBrowse.Location = New System.Drawing.Point(561, 16)
        Me.btnTVBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTVBrowse.Name = "btnTVBrowse"
        Me.btnTVBrowse.Size = New System.Drawing.Size(93, 40)
        Me.btnTVBrowse.TabIndex = 7
        Me.btnTVBrowse.Text = "Browse"
        Me.btnTVBrowse.Values.ExtraText = ""
        Me.btnTVBrowse.Values.Image = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnTVBrowse.Values.Text = "Browse"
        '
        'klblRemoveatvshow1
        '
        Me.klblRemoveatvshow1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblRemoveatvshow1.Location = New System.Drawing.Point(259, 172)
        Me.klblRemoveatvshow1.Name = "klblRemoveatvshow1"
        Me.klblRemoveatvshow1.Size = New System.Drawing.Size(279, 21)
        Me.klblRemoveatvshow1.TabIndex = 92
        Me.klblRemoveatvshow1.Text = "To remove a Tv Show Highlight and Right Click" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.klblRemoveatvshow1.Values.ExtraText = ""
        Me.klblRemoveatvshow1.Values.Image = Nothing
        Me.klblRemoveatvshow1.Values.Text = "To remove a Tv Show Highlight and Right Click" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbTVPath
        '
        Me.tbTVPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTVPath.Location = New System.Drawing.Point(5, 30)
        Me.tbTVPath.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTVPath.Name = "tbTVPath"
        Me.tbTVPath.Size = New System.Drawing.Size(413, 22)
        Me.tbTVPath.TabIndex = 8
        Me.tbTVPath.Text = "Enter the path and click add or click browse to select"
        '
        'btnTVClearList
        '
        Me.btnTVClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVClearList.ForeColor = System.Drawing.Color.Black
        Me.btnTVClearList.Location = New System.Drawing.Point(659, 16)
        Me.btnTVClearList.Name = "btnTVClearList"
        Me.btnTVClearList.Size = New System.Drawing.Size(101, 40)
        Me.btnTVClearList.TabIndex = 45
        Me.btnTVClearList.Text = "Clear List"
        Me.btnTVClearList.Values.ExtraText = ""
        Me.btnTVClearList.Values.Image = Nothing
        Me.btnTVClearList.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnTVClearList.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnTVClearList.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnTVClearList.Values.Text = "Clear List"
        '
        'btnTVAddPath
        '
        Me.btnTVAddPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVAddPath.ForeColor = System.Drawing.Color.Black
        Me.btnTVAddPath.Location = New System.Drawing.Point(448, 16)
        Me.btnTVAddPath.Name = "btnTVAddPath"
        Me.btnTVAddPath.Size = New System.Drawing.Size(108, 40)
        Me.btnTVAddPath.TabIndex = 44
        Me.btnTVAddPath.Text = "Add Path"
        Me.btnTVAddPath.Values.ExtraText = ""
        Me.btnTVAddPath.Values.Image = Nothing
        Me.btnTVAddPath.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnTVAddPath.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnTVAddPath.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnTVAddPath.Values.Text = "Add Path"
        '
        'lbTVShows
        '
        Me.lbTVShows.FormattingEnabled = True
        Me.lbTVShows.Location = New System.Drawing.Point(5, 57)
        Me.lbTVShows.Name = "lbTVShows"
        Me.lbTVShows.Size = New System.Drawing.Size(755, 109)
        Me.lbTVShows.TabIndex = 47
        '
        'klbTVShowFolders
        '
        Me.klbTVShowFolders.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klbTVShowFolders.Location = New System.Drawing.Point(0, 3)
        Me.klbTVShowFolders.Name = "klbTVShowFolders"
        Me.klbTVShowFolders.Size = New System.Drawing.Size(264, 21)
        Me.klbTVShowFolders.TabIndex = 46
        Me.klbTVShowFolders.Text = "TV Shows - Select the root TV Show folder"
        Me.klbTVShowFolders.Values.ExtraText = ""
        Me.klbTVShowFolders.Values.Image = Nothing
        Me.klbTVShowFolders.Values.Text = "TV Shows - Select the root TV Show folder"
        '
        'tpSettingsMusic
        '
        Me.tpSettingsMusic.Controls.Add(Me.lblTunesWHat)
        Me.tpSettingsMusic.Controls.Add(Me.kgMusicAlbumArt)
        Me.tpSettingsMusic.Controls.Add(Me.kgMusicMI)
        Me.tpSettingsMusic.Controls.Add(Me.cbmusic_createAlbumNfo)
        Me.tpSettingsMusic.Controls.Add(Me.cbmusic_createArtistnfo)
        Me.tpSettingsMusic.Controls.Add(Me.kgTunesTunes)
        Me.tpSettingsMusic.Location = New System.Drawing.Point(4, 25)
        Me.tpSettingsMusic.Name = "tpSettingsMusic"
        Me.tpSettingsMusic.Size = New System.Drawing.Size(813, 589)
        Me.tpSettingsMusic.TabIndex = 3
        Me.tpSettingsMusic.Text = "Tunes"
        Me.tpSettingsMusic.UseVisualStyleBackColor = True
        '
        'lblTunesWHat
        '
        Me.lblTunesWHat.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblTunesWHat.Location = New System.Drawing.Point(328, 21)
        Me.lblTunesWHat.Name = "lblTunesWHat"
        Me.lblTunesWHat.Size = New System.Drawing.Size(91, 21)
        Me.lblTunesWHat.TabIndex = 94
        Me.lblTunesWHat.Text = "Tunes = Music"
        Me.lblTunesWHat.Values.ExtraText = ""
        Me.lblTunesWHat.Values.Image = Nothing
        Me.lblTunesWHat.Values.Text = "Tunes = Music"
        '
        'kgMusicAlbumArt
        '
        Me.kgMusicAlbumArt.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMusicAlbumArt.Location = New System.Drawing.Point(398, 69)
        Me.kgMusicAlbumArt.Name = "kgMusicAlbumArt"
        '
        'kgMusicAlbumArt.Panel
        '
        Me.kgMusicAlbumArt.Panel.Controls.Add(Me.cbMusicResizeMusicFanart)
        Me.kgMusicAlbumArt.Panel.Controls.Add(Me.cbGetMusicFanartFromHTBackdrops)
        Me.kgMusicAlbumArt.Panel.Controls.Add(Me.cbMusicGetAlbumArt)
        Me.kgMusicAlbumArt.Panel.Controls.Add(Me.lblMusicAlbumArt)
        Me.kgMusicAlbumArt.Size = New System.Drawing.Size(403, 161)
        Me.kgMusicAlbumArt.TabIndex = 93
        '
        'cbMusicResizeMusicFanart
        '
        Me.cbMusicResizeMusicFanart.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbMusicResizeMusicFanart.Location = New System.Drawing.Point(3, 80)
        Me.cbMusicResizeMusicFanart.Name = "cbMusicResizeMusicFanart"
        Me.cbMusicResizeMusicFanart.Size = New System.Drawing.Size(260, 37)
        Me.cbMusicResizeMusicFanart.TabIndex = 3
        Me.cbMusicResizeMusicFanart.Text = "Resize Music Fanart for xbox (960x540)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - requires image magick be installed"
        Me.cbMusicResizeMusicFanart.Values.ExtraText = ""
        Me.cbMusicResizeMusicFanart.Values.Image = Nothing
        Me.cbMusicResizeMusicFanart.Values.Text = "Resize Music Fanart for xbox (960x540)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - requires image magick be installed"
        '
        'cbGetMusicFanartFromHTBackdrops
        '
        Me.cbGetMusicFanartFromHTBackdrops.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbGetMusicFanartFromHTBackdrops.Location = New System.Drawing.Point(3, 52)
        Me.cbGetMusicFanartFromHTBackdrops.Name = "cbGetMusicFanartFromHTBackdrops"
        Me.cbGetMusicFanartFromHTBackdrops.Size = New System.Drawing.Size(237, 21)
        Me.cbGetMusicFanartFromHTBackdrops.TabIndex = 2
        Me.cbGetMusicFanartFromHTBackdrops.Text = "Get Backgrounds from HT Backdrops"
        Me.cbGetMusicFanartFromHTBackdrops.Values.ExtraText = ""
        Me.cbGetMusicFanartFromHTBackdrops.Values.Image = Nothing
        Me.cbGetMusicFanartFromHTBackdrops.Values.Text = "Get Backgrounds from HT Backdrops"
        '
        'cbMusicGetAlbumArt
        '
        Me.cbMusicGetAlbumArt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbMusicGetAlbumArt.Location = New System.Drawing.Point(3, 30)
        Me.cbMusicGetAlbumArt.Name = "cbMusicGetAlbumArt"
        Me.cbMusicGetAlbumArt.Size = New System.Drawing.Size(108, 21)
        Me.cbMusicGetAlbumArt.TabIndex = 1
        Me.cbMusicGetAlbumArt.Text = "Get Album Art"
        Me.cbMusicGetAlbumArt.Values.ExtraText = ""
        Me.cbMusicGetAlbumArt.Values.Image = Nothing
        Me.cbMusicGetAlbumArt.Values.Text = "Get Album Art"
        '
        'lblMusicAlbumArt
        '
        Me.lblMusicAlbumArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMusicAlbumArt.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMusicAlbumArt.Location = New System.Drawing.Point(0, 0)
        Me.lblMusicAlbumArt.Name = "lblMusicAlbumArt"
        Me.lblMusicAlbumArt.Size = New System.Drawing.Size(391, 21)
        Me.lblMusicAlbumArt.TabIndex = 0
        Me.lblMusicAlbumArt.Text = "Album Art and Fanart"
        Me.lblMusicAlbumArt.Values.ExtraText = ""
        Me.lblMusicAlbumArt.Values.Image = Nothing
        Me.lblMusicAlbumArt.Values.Text = "Album Art and Fanart"
        '
        'kgMusicMI
        '
        Me.kgMusicMI.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgMusicMI.Location = New System.Drawing.Point(7, 68)
        Me.kgMusicMI.Name = "kgMusicMI"
        '
        'kgMusicMI.Panel
        '
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicInsert)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicInlay)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicCd4)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicCd3)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicCd2)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicCd1)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicBack)
        Me.kgMusicMI.Panel.Controls.Add(Me.getMediaImagesMusicFront)
        Me.kgMusicMI.Panel.Controls.Add(Me.klblMusicMI)
        Me.kgMusicMI.Size = New System.Drawing.Size(385, 162)
        Me.kgMusicMI.TabIndex = 92
        '
        'getMediaImagesMusicInsert
        '
        Me.getMediaImagesMusicInsert.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicInsert.Location = New System.Drawing.Point(224, 115)
        Me.getMediaImagesMusicInsert.Name = "getMediaImagesMusicInsert"
        Me.getMediaImagesMusicInsert.Size = New System.Drawing.Size(92, 21)
        Me.getMediaImagesMusicInsert.TabIndex = 8
        Me.getMediaImagesMusicInsert.Text = "Get Inserts"
        Me.getMediaImagesMusicInsert.Values.ExtraText = ""
        Me.getMediaImagesMusicInsert.Values.Image = Nothing
        Me.getMediaImagesMusicInsert.Values.Text = "Get Inserts"
        '
        'getMediaImagesMusicInlay
        '
        Me.getMediaImagesMusicInlay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicInlay.Location = New System.Drawing.Point(224, 90)
        Me.getMediaImagesMusicInlay.Name = "getMediaImagesMusicInlay"
        Me.getMediaImagesMusicInlay.Size = New System.Drawing.Size(84, 21)
        Me.getMediaImagesMusicInlay.TabIndex = 7
        Me.getMediaImagesMusicInlay.Text = "Get Inlays"
        Me.getMediaImagesMusicInlay.Values.ExtraText = ""
        Me.getMediaImagesMusicInlay.Values.Image = Nothing
        Me.getMediaImagesMusicInlay.Values.Text = "Get Inlays"
        '
        'getMediaImagesMusicCd4
        '
        Me.getMediaImagesMusicCd4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicCd4.Location = New System.Drawing.Point(224, 65)
        Me.getMediaImagesMusicCd4.Name = "getMediaImagesMusicCd4"
        Me.getMediaImagesMusicCd4.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMusicCd4.TabIndex = 6
        Me.getMediaImagesMusicCd4.Text = "Get CD4 Covers"
        Me.getMediaImagesMusicCd4.Values.ExtraText = ""
        Me.getMediaImagesMusicCd4.Values.Image = Nothing
        Me.getMediaImagesMusicCd4.Values.Text = "Get CD4 Covers"
        '
        'getMediaImagesMusicCd3
        '
        Me.getMediaImagesMusicCd3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicCd3.Location = New System.Drawing.Point(224, 40)
        Me.getMediaImagesMusicCd3.Name = "getMediaImagesMusicCd3"
        Me.getMediaImagesMusicCd3.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMusicCd3.TabIndex = 5
        Me.getMediaImagesMusicCd3.Text = "Get CD3 Covers"
        Me.getMediaImagesMusicCd3.Values.ExtraText = ""
        Me.getMediaImagesMusicCd3.Values.Image = Nothing
        Me.getMediaImagesMusicCd3.Values.Text = "Get CD3 Covers"
        '
        'getMediaImagesMusicCd2
        '
        Me.getMediaImagesMusicCd2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicCd2.Location = New System.Drawing.Point(17, 121)
        Me.getMediaImagesMusicCd2.Name = "getMediaImagesMusicCd2"
        Me.getMediaImagesMusicCd2.Size = New System.Drawing.Size(114, 21)
        Me.getMediaImagesMusicCd2.TabIndex = 4
        Me.getMediaImagesMusicCd2.Text = "Get CD2 Covers"
        Me.getMediaImagesMusicCd2.Values.ExtraText = ""
        Me.getMediaImagesMusicCd2.Values.Image = Nothing
        Me.getMediaImagesMusicCd2.Values.Text = "Get CD2 Covers"
        '
        'getMediaImagesMusicCd1
        '
        Me.getMediaImagesMusicCd1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicCd1.Location = New System.Drawing.Point(17, 94)
        Me.getMediaImagesMusicCd1.Name = "getMediaImagesMusicCd1"
        Me.getMediaImagesMusicCd1.Size = New System.Drawing.Size(113, 21)
        Me.getMediaImagesMusicCd1.TabIndex = 3
        Me.getMediaImagesMusicCd1.Text = "Get CD1 Covers"
        Me.getMediaImagesMusicCd1.Values.ExtraText = ""
        Me.getMediaImagesMusicCd1.Values.Image = Nothing
        Me.getMediaImagesMusicCd1.Values.Text = "Get CD1 Covers"
        '
        'getMediaImagesMusicBack
        '
        Me.getMediaImagesMusicBack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicBack.Location = New System.Drawing.Point(17, 67)
        Me.getMediaImagesMusicBack.Name = "getMediaImagesMusicBack"
        Me.getMediaImagesMusicBack.Size = New System.Drawing.Size(118, 21)
        Me.getMediaImagesMusicBack.TabIndex = 2
        Me.getMediaImagesMusicBack.Text = "Get Back Covers"
        Me.getMediaImagesMusicBack.Values.ExtraText = ""
        Me.getMediaImagesMusicBack.Values.Image = Nothing
        Me.getMediaImagesMusicBack.Values.Text = "Get Back Covers"
        '
        'getMediaImagesMusicFront
        '
        Me.getMediaImagesMusicFront.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.getMediaImagesMusicFront.Location = New System.Drawing.Point(17, 40)
        Me.getMediaImagesMusicFront.Name = "getMediaImagesMusicFront"
        Me.getMediaImagesMusicFront.Size = New System.Drawing.Size(123, 21)
        Me.getMediaImagesMusicFront.TabIndex = 1
        Me.getMediaImagesMusicFront.Text = "Get Front Covers"
        Me.getMediaImagesMusicFront.Values.ExtraText = ""
        Me.getMediaImagesMusicFront.Values.Image = Nothing
        Me.getMediaImagesMusicFront.Values.Text = "Get Front Covers"
        '
        'klblMusicMI
        '
        Me.klblMusicMI.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblMusicMI.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblMusicMI.Location = New System.Drawing.Point(0, 0)
        Me.klblMusicMI.Name = "klblMusicMI"
        Me.klblMusicMI.Size = New System.Drawing.Size(373, 21)
        Me.klblMusicMI.TabIndex = 0
        Me.klblMusicMI.Text = "Media Images"
        Me.klblMusicMI.Values.ExtraText = ""
        Me.klblMusicMI.Values.Image = Nothing
        Me.klblMusicMI.Values.Text = "Media Images"
        '
        'cbmusic_createAlbumNfo
        '
        Me.cbmusic_createAlbumNfo.Enabled = False
        Me.cbmusic_createAlbumNfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbmusic_createAlbumNfo.Location = New System.Drawing.Point(18, 43)
        Me.cbmusic_createAlbumNfo.Name = "cbmusic_createAlbumNfo"
        Me.cbmusic_createAlbumNfo.Size = New System.Drawing.Size(329, 21)
        Me.cbmusic_createAlbumNfo.TabIndex = 91
        Me.cbmusic_createAlbumNfo.Text = "Create Album Information file for XBMC (album.nfo)"
        Me.cbmusic_createAlbumNfo.Values.ExtraText = ""
        Me.cbmusic_createAlbumNfo.Values.Image = Nothing
        Me.cbmusic_createAlbumNfo.Values.Text = "Create Album Information file for XBMC (album.nfo)"
        Me.cbmusic_createAlbumNfo.Visible = False
        '
        'cbmusic_createArtistnfo
        '
        Me.cbmusic_createArtistnfo.Enabled = False
        Me.cbmusic_createArtistnfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.cbmusic_createArtistnfo.Location = New System.Drawing.Point(18, 21)
        Me.cbmusic_createArtistnfo.Name = "cbmusic_createArtistnfo"
        Me.cbmusic_createArtistnfo.Size = New System.Drawing.Size(329, 21)
        Me.cbmusic_createArtistnfo.TabIndex = 90
        Me.cbmusic_createArtistnfo.Text = "Create Artist Information file for XBMC (artist.nfo)"
        Me.cbmusic_createArtistnfo.Values.ExtraText = ""
        Me.cbmusic_createArtistnfo.Values.Image = Nothing
        Me.cbmusic_createArtistnfo.Values.Text = "Create Artist Information file for XBMC (artist.nfo)"
        Me.cbmusic_createArtistnfo.Visible = False
        '
        'kgTunesTunes
        '
        Me.kgTunesTunes.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgTunesTunes.Location = New System.Drawing.Point(6, 236)
        Me.kgTunesTunes.Name = "kgTunesTunes"
        '
        'kgTunesTunes.Panel
        '
        Me.kgTunesTunes.Panel.Controls.Add(Me.btnMusicBrowseForFolder)
        Me.kgTunesTunes.Panel.Controls.Add(Me.tbFolderMusic)
        Me.kgTunesTunes.Panel.Controls.Add(Me.btnMusicClearFolderList)
        Me.kgTunesTunes.Panel.Controls.Add(Me.btnMusicAddFolderByPath)
        Me.kgTunesTunes.Panel.Controls.Add(Me.clbPathsMusic)
        Me.kgTunesTunes.Panel.Controls.Add(Me.KryptonLabel1)
        Me.kgTunesTunes.Size = New System.Drawing.Size(799, 319)
        Me.kgTunesTunes.TabIndex = 89
        '
        'btnMusicBrowseForFolder
        '
        Me.btnMusicBrowseForFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMusicBrowseForFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicBrowseForFolder.ForeColor = System.Drawing.Color.Black
        Me.btnMusicBrowseForFolder.Location = New System.Drawing.Point(571, 38)
        Me.btnMusicBrowseForFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMusicBrowseForFolder.Name = "btnMusicBrowseForFolder"
        Me.btnMusicBrowseForFolder.Size = New System.Drawing.Size(104, 38)
        Me.btnMusicBrowseForFolder.TabIndex = 7
        Me.btnMusicBrowseForFolder.Text = "Browse"
        Me.btnMusicBrowseForFolder.Values.ExtraText = ""
        Me.btnMusicBrowseForFolder.Values.Image = Nothing
        Me.btnMusicBrowseForFolder.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicBrowseForFolder.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicBrowseForFolder.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicBrowseForFolder.Values.Text = "Browse"
        '
        'tbFolderMusic
        '
        Me.tbFolderMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolderMusic.Location = New System.Drawing.Point(5, 52)
        Me.tbFolderMusic.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolderMusic.Name = "tbFolderMusic"
        Me.tbFolderMusic.Size = New System.Drawing.Size(445, 22)
        Me.tbFolderMusic.TabIndex = 8
        Me.tbFolderMusic.Text = "Enter the path and click add or click browse to select"
        '
        'btnMusicClearFolderList
        '
        Me.btnMusicClearFolderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicClearFolderList.ForeColor = System.Drawing.Color.Black
        Me.btnMusicClearFolderList.Location = New System.Drawing.Point(678, 38)
        Me.btnMusicClearFolderList.Name = "btnMusicClearFolderList"
        Me.btnMusicClearFolderList.Size = New System.Drawing.Size(111, 38)
        Me.btnMusicClearFolderList.TabIndex = 45
        Me.btnMusicClearFolderList.Text = "Clear List"
        Me.btnMusicClearFolderList.Values.ExtraText = ""
        Me.btnMusicClearFolderList.Values.Image = Nothing
        Me.btnMusicClearFolderList.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicClearFolderList.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicClearFolderList.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicClearFolderList.Values.Text = "Clear List"
        '
        'btnMusicAddFolderByPath
        '
        Me.btnMusicAddFolderByPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicAddFolderByPath.ForeColor = System.Drawing.Color.Black
        Me.btnMusicAddFolderByPath.Location = New System.Drawing.Point(452, 38)
        Me.btnMusicAddFolderByPath.Name = "btnMusicAddFolderByPath"
        Me.btnMusicAddFolderByPath.Size = New System.Drawing.Size(116, 38)
        Me.btnMusicAddFolderByPath.TabIndex = 44
        Me.btnMusicAddFolderByPath.Text = "Add Path"
        Me.btnMusicAddFolderByPath.Values.ExtraText = ""
        Me.btnMusicAddFolderByPath.Values.Image = Nothing
        Me.btnMusicAddFolderByPath.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicAddFolderByPath.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicAddFolderByPath.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicAddFolderByPath.Values.Text = "Add Path"
        '
        'clbPathsMusic
        '
        Me.clbPathsMusic.FormattingEnabled = True
        Me.clbPathsMusic.Location = New System.Drawing.Point(5, 83)
        Me.clbPathsMusic.Name = "clbPathsMusic"
        Me.clbPathsMusic.Size = New System.Drawing.Size(731, 214)
        Me.clbPathsMusic.TabIndex = 47
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(1, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(345, 21)
        Me.KryptonLabel1.TabIndex = 46
        Me.KryptonLabel1.Text = "Tunes - Select the folder(s) where you have your tunes at"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tunes - Select the folder(s) where you have your tunes at"
        '
        'tpSettingsHV
        '
        Me.tpSettingsHV.Controls.Add(Me.kgSettingsTVActive)
        Me.tpSettingsHV.Controls.Add(Me.kbtnRemoveAllTempTVFiles)
        Me.tpSettingsHV.Controls.Add(Me.kbtnRemoveAllCachedMovieData)
        Me.tpSettingsHV.Location = New System.Drawing.Point(4, 25)
        Me.tpSettingsHV.Name = "tpSettingsHV"
        Me.tpSettingsHV.Size = New System.Drawing.Size(813, 589)
        Me.tpSettingsHV.TabIndex = 4
        Me.tpSettingsHV.Text = "Home Videos"
        Me.tpSettingsHV.UseVisualStyleBackColor = True
        '
        'kgSettingsTVActive
        '
        Me.kgSettingsTVActive.Location = New System.Drawing.Point(517, 302)
        Me.kgSettingsTVActive.Name = "kgSettingsTVActive"
        '
        'kgSettingsTVActive.Panel
        '
        Me.kgSettingsTVActive.Panel.Controls.Add(Me.Button8)
        Me.kgSettingsTVActive.Panel.Controls.Add(Me.btnRGF)
        Me.kgSettingsTVActive.Size = New System.Drawing.Size(146, 69)
        Me.kgSettingsTVActive.TabIndex = 80
        Me.kgSettingsTVActive.Visible = False
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(16, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(94, 25)
        Me.Button8.TabIndex = 49
        Me.Button8.Text = "XML TEST"
        Me.Button8.Values.ExtraText = ""
        Me.Button8.Values.Image = Nothing
        Me.Button8.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.Button8.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.Button8.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.Button8.Values.Text = "XML TEST"
        Me.Button8.Visible = False
        '
        'btnRGF
        '
        Me.btnRGF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRGF.Location = New System.Drawing.Point(-1, 39)
        Me.btnRGF.Name = "btnRGF"
        Me.btnRGF.Size = New System.Drawing.Size(191, 25)
        Me.btnRGF.TabIndex = 74
        Me.btnRGF.Text = "Reduce GUI feedback (temp setting)"
        Me.btnRGF.Values.ExtraText = ""
        Me.btnRGF.Values.Image = Nothing
        Me.btnRGF.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnRGF.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnRGF.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnRGF.Values.Text = "Reduce GUI feedback (temp setting)"
        Me.btnRGF.Visible = False
        '
        'kbtnRemoveAllTempTVFiles
        '
        Me.kbtnRemoveAllTempTVFiles.Location = New System.Drawing.Point(315, 302)
        Me.kbtnRemoveAllTempTVFiles.Name = "kbtnRemoveAllTempTVFiles"
        Me.kbtnRemoveAllTempTVFiles.Size = New System.Drawing.Size(188, 25)
        Me.kbtnRemoveAllTempTVFiles.TabIndex = 79
        Me.kbtnRemoveAllTempTVFiles.Text = "Remove ALL TV Temp Files"
        Me.kbtnRemoveAllTempTVFiles.Values.ExtraText = ""
        Me.kbtnRemoveAllTempTVFiles.Values.Image = Nothing
        Me.kbtnRemoveAllTempTVFiles.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbtnRemoveAllTempTVFiles.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbtnRemoveAllTempTVFiles.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbtnRemoveAllTempTVFiles.Values.Text = "Remove ALL TV Temp Files"
        Me.kbtnRemoveAllTempTVFiles.Visible = False
        '
        'kbtnRemoveAllCachedMovieData
        '
        Me.kbtnRemoveAllCachedMovieData.Location = New System.Drawing.Point(315, 336)
        Me.kbtnRemoveAllCachedMovieData.Name = "kbtnRemoveAllCachedMovieData"
        Me.kbtnRemoveAllCachedMovieData.Size = New System.Drawing.Size(188, 25)
        Me.kbtnRemoveAllCachedMovieData.TabIndex = 78
        Me.kbtnRemoveAllCachedMovieData.Text = "Remove ALL TV Cached Data"
        Me.kbtnRemoveAllCachedMovieData.Values.ExtraText = ""
        Me.kbtnRemoveAllCachedMovieData.Values.Image = Nothing
        Me.kbtnRemoveAllCachedMovieData.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbtnRemoveAllCachedMovieData.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbtnRemoveAllCachedMovieData.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbtnRemoveAllCachedMovieData.Values.Text = "Remove ALL TV Cached Data"
        Me.kbtnRemoveAllCachedMovieData.Visible = False
        '
        'kscMainSettings
        '
        Me.kscMainSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscMainSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscMainSettings.Location = New System.Drawing.Point(0, 0)
        Me.kscMainSettings.Name = "kscMainSettings"
        Me.kscMainSettings.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscMainSettings.Panel1
        '
        Me.kscMainSettings.Panel1.Controls.Add(Me.tcSettings)
        '
        'kscMainSettings.Panel2
        '
        Me.kscMainSettings.Panel2.Controls.Add(Me.btnsaveconfig)
        Me.kscMainSettings.Size = New System.Drawing.Size(821, 667)
        Me.kscMainSettings.SplitterDistance = 618
        Me.kscMainSettings.TabIndex = 89
        '
        'dlgConfiguration
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(821, 667)
        Me.Controls.Add(Me.kscMainSettings)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConfiguration"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MIP - Setup and Configuration Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.kgMovieSettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieSettings.Panel.ResumeLayout(False)
        Me.kgMovieSettings.Panel.PerformLayout()
        CType(Me.kgMovieSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieSettings.ResumeLayout(False)
        CType(Me.kgAutomaticGenerationSettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgAutomaticGenerationSettings.Panel.ResumeLayout(False)
        Me.kgAutomaticGenerationSettings.Panel.PerformLayout()
        CType(Me.kgAutomaticGenerationSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgAutomaticGenerationSettings.ResumeLayout(False)
        CType(Me.kgNFOFANARTsettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgNFOFANARTsettings.Panel.ResumeLayout(False)
        Me.kgNFOFANARTsettings.Panel.PerformLayout()
        CType(Me.kgNFOFANARTsettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgNFOFANARTsettings.ResumeLayout(False)
        CType(Me.kgMovieDownloadOptions.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieDownloadOptions.Panel.ResumeLayout(False)
        Me.kgMovieDownloadOptions.Panel.PerformLayout()
        CType(Me.kgMovieDownloadOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieDownloadOptions.ResumeLayout(False)
        CType(Me.kgMoviesMI.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesMI.Panel.ResumeLayout(False)
        Me.kgMoviesMI.Panel.PerformLayout()
        CType(Me.kgMoviesMI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesMI.ResumeLayout(False)
        CType(Me.kgMoviesDownloadGeneral.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesDownloadGeneral.Panel.ResumeLayout(False)
        Me.kgMoviesDownloadGeneral.Panel.PerformLayout()
        CType(Me.kgMoviesDownloadGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesDownloadGeneral.ResumeLayout(False)
        CType(Me.kgMovieBackgrounds.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieBackgrounds.Panel.ResumeLayout(False)
        Me.kgMovieBackgrounds.Panel.PerformLayout()
        CType(Me.kgMovieBackgrounds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieBackgrounds.ResumeLayout(False)
        CType(Me.kgMoviesDownloadPosters.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesDownloadPosters.Panel.ResumeLayout(False)
        Me.kgMoviesDownloadPosters.Panel.PerformLayout()
        CType(Me.kgMoviesDownloadPosters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesDownloadPosters.ResumeLayout(False)
        CType(Me.kgNameFilter.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgNameFilter.Panel.ResumeLayout(False)
        Me.kgNameFilter.Panel.PerformLayout()
        CType(Me.kgNameFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgNameFilter.ResumeLayout(False)
        CType(Me.kgTQQIconsGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTQQIconsGroup.Panel.ResumeLayout(False)
        Me.kgTQQIconsGroup.Panel.PerformLayout()
        CType(Me.kgTQQIconsGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTQQIconsGroup.ResumeLayout(False)
        CType(Me.kgColorSelect.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgColorSelect.Panel.ResumeLayout(False)
        Me.kgColorSelect.Panel.PerformLayout()
        CType(Me.kgColorSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgColorSelect.ResumeLayout(False)
        CType(Me.kgTVShowSettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTVShowSettings.Panel.ResumeLayout(False)
        CType(Me.kgTVShowSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTVShowSettings.ResumeLayout(False)
        CType(Me.kgTVGlobalSettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTVGlobalSettings.Panel.ResumeLayout(False)
        Me.kgTVGlobalSettings.Panel.PerformLayout()
        CType(Me.kgTVGlobalSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTVGlobalSettings.ResumeLayout(False)
        CType(Me.kgSettingsTvEpisode.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvEpisode.Panel.ResumeLayout(False)
        Me.kgSettingsTvEpisode.Panel.PerformLayout()
        CType(Me.kgSettingsTvEpisode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvEpisode.ResumeLayout(False)
        CType(Me.kgSettingsTvSeasonBanners.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvSeasonBanners.Panel.ResumeLayout(False)
        Me.kgSettingsTvSeasonBanners.Panel.PerformLayout()
        CType(Me.kgSettingsTvSeasonBanners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvSeasonBanners.ResumeLayout(False)
        CType(Me.kgSettingsTvShow.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvShow.Panel.ResumeLayout(False)
        Me.kgSettingsTvShow.Panel.PerformLayout()
        CType(Me.kgSettingsTvShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTvShow.ResumeLayout(False)
        CType(Me.kgTvShowsShowWidePoster.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvShowsShowWidePoster.Panel.ResumeLayout(False)
        Me.kgTvShowsShowWidePoster.Panel.PerformLayout()
        CType(Me.kgTvShowsShowWidePoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvShowsShowWidePoster.ResumeLayout(False)
        CType(Me.kgShowsMI.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgShowsMI.Panel.ResumeLayout(False)
        Me.kgShowsMI.Panel.PerformLayout()
        CType(Me.kgShowsMI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgShowsMI.ResumeLayout(False)
        Me.tcSettings.ResumeLayout(False)
        Me.tpSettingsGeneral.ResumeLayout(False)
        CType(Me.kgGeneralMisc.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgGeneralMisc.Panel.ResumeLayout(False)
        Me.kgGeneralMisc.Panel.PerformLayout()
        CType(Me.kgGeneralMisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgGeneralMisc.ResumeLayout(False)
        CType(Me.kgGeneralProxy.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgGeneralProxy.Panel.ResumeLayout(False)
        Me.kgGeneralProxy.Panel.PerformLayout()
        CType(Me.kgGeneralProxy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgGeneralProxy.ResumeLayout(False)
        Me.tpSettingsMovies.ResumeLayout(False)
        CType(Me.kgOfdbSettings.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgOfdbSettings.Panel.ResumeLayout(False)
        Me.kgOfdbSettings.Panel.PerformLayout()
        CType(Me.kgOfdbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgOfdbSettings.ResumeLayout(False)
        CType(Me.kgMoviesNameFilters.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesNameFilters.Panel.ResumeLayout(False)
        Me.kgMoviesNameFilters.Panel.PerformLayout()
        CType(Me.kgMoviesNameFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMoviesNameFilters.ResumeLayout(False)
        CType(Me.kgFileLevelFilterOptions.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgFileLevelFilterOptions.Panel.ResumeLayout(False)
        Me.kgFileLevelFilterOptions.Panel.PerformLayout()
        CType(Me.kgFileLevelFilterOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgFileLevelFilterOptions.ResumeLayout(False)
        CType(Me.kgMovieFileOptions.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFileOptions.Panel.ResumeLayout(False)
        Me.kgMovieFileOptions.Panel.PerformLayout()
        CType(Me.kgMovieFileOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFileOptions.ResumeLayout(False)
        CType(Me.kgMovieFolderSelect.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFolderSelect.Panel.ResumeLayout(False)
        Me.kgMovieFolderSelect.Panel.PerformLayout()
        CType(Me.kgMovieFolderSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFolderSelect.ResumeLayout(False)
        Me.tpSettingsTvShows.ResumeLayout(False)
        CType(Me.kgTvshowpaths.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvshowpaths.Panel.ResumeLayout(False)
        Me.kgTvshowpaths.Panel.PerformLayout()
        CType(Me.kgTvshowpaths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvshowpaths.ResumeLayout(False)
        Me.tpSettingsMusic.ResumeLayout(False)
        Me.tpSettingsMusic.PerformLayout()
        CType(Me.kgMusicAlbumArt.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMusicAlbumArt.Panel.ResumeLayout(False)
        Me.kgMusicAlbumArt.Panel.PerformLayout()
        CType(Me.kgMusicAlbumArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMusicAlbumArt.ResumeLayout(False)
        CType(Me.kgMusicMI.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMusicMI.Panel.ResumeLayout(False)
        Me.kgMusicMI.Panel.PerformLayout()
        CType(Me.kgMusicMI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMusicMI.ResumeLayout(False)
        CType(Me.kgTunesTunes.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTunesTunes.Panel.ResumeLayout(False)
        Me.kgTunesTunes.Panel.PerformLayout()
        CType(Me.kgTunesTunes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTunesTunes.ResumeLayout(False)
        Me.tpSettingsHV.ResumeLayout(False)
        CType(Me.kgSettingsTVActive.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTVActive.Panel.ResumeLayout(False)
        CType(Me.kgSettingsTVActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSettingsTVActive.ResumeLayout(False)
        CType(Me.kscMainSettings.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMainSettings.Panel1.ResumeLayout(False)
        CType(Me.kscMainSettings.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMainSettings.Panel2.ResumeLayout(False)
        CType(Me.kscMainSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMainSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents kgMovieSettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents kgAutomaticGenerationSettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cbcopyplotsummaryifnoplot As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbscanformoviemediainformation As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbnopromptfornewposters As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbautocreatemovienametbn As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbautocreatemovietbn As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbautocreatefolderjpg As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgTQQIconsGroup As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cbf3s0 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblTQQIconsLbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbf1s9 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbf1s0 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbf2s0 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents Label1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbf1s3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbf2s10 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbMaxIconsToDisplay As System.Windows.Forms.ComboBox
    Friend WithEvents cbMaxIconPerStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cbf2s8 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbDlFormat As System.Windows.Forms.ComboBox
    Friend WithEvents cbf2s2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgNFOFANARTsettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cbcreatemovienamedotnfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblPosterSizeMovieTBN As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbSaveNFO As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblPosterSizefolderjpg As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbOverwriteNFO As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbcreatemovienamedottbn As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents knudPosterHeightTBN As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents cbShowFanart As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents knudPosterHeightfolderjpg As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents cbCreateMovieNFO As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbUsefolderjpgfortbn As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbSaveSageTVBackgrounds As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbShowTBN As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbCreateMovieTbnFile As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbCreateMovieNameFanartjpg As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbCreateFolderjpg As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbCreateFanartjpgfile As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbNoNfoChangePrompt As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgMovieDownloadOptions As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cbgetncposters As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetTMDBInfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbDownloadPoster As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetTMDBPosters As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetFanart As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetIMDBInfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgColorSelect As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblGUILOOK As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents krbColorBling As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorSilver As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorBlue As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorBlack As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents cbGoogleImageSearchPop As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnsaveconfig As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kgNameFilter As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cbIgnoreparans As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterYears As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilter1080i As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tbCustomFilter1 As System.Windows.Forms.TextBox
    Friend WithEvents knudframeratio As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents Label5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbFilterH264 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterLq As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterHidef As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterDVD As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilter1080p As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterDivx As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilter720p As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterXvid As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterCustom4 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterAvi As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterCustom3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterBluRay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterCustom5 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tbCustomFilter2 As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterCustom2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tbCustomFilter3 As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomFilter5 As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomFilter4 As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterCustom1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnProcessAll As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cbAllowAutoMovienameRename As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgTVShowSettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblCustomRegX As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tbTvRegex1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbltv_curlang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbtv_lang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kgTVGlobalSettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblTVGSnoteslbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblGlobalSettingslbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblTVCheckForNewTVShowDatalbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents combolTVCheckForNewTVShowData As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kgSettingsTvEpisode As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents tvgs_episode_overwrite_tbn As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tvgs_episode_overwrite_nfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblTVEpisodesSection As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_cb_episode_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgSettingsTvSeasonBanners As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klbltvseasonwhatstylelbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_combobox_season_banners_download_type As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents tvgs_knud_season_posters_download_maxnumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents krbTVSeasonUsePoster As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbTVSeasonUseWide As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_cb_season_posters_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klbltvMaxNumberOfPosters As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_knud_season_banners_download_maxnumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblTVBannersSection As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_cb_season_banners_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgSettingsTvShow As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents tvgs_cb_tvshow_nfo_overwrite As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tvgs_cb_tvshow_fanart_display As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblFanartToApplylbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblTvShowSettingsLbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_knud_tvshow_wideicon_download_maxnumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblTVFanartSection As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_combobox_tvshow_fanart_download_size As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents tvgs_knud_tvshow_posters_download_maxnumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents tvgs_cb_tvshow_wideicon_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblTVPostersSection As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_cb_tvshow_fanart_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tvgs_combobox_tvshow_fanart_toapply_whatsize As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents klbltvmaxtvfanarttodownload As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tvgs_cb_tvshow_posters_download As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tvgs_knud_tvshow_fanart_download_maxnumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klbltvMaxNumberOfPostersToDownload As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tcSettings As Dotnetrix.Controls.TabControlEX
    Friend WithEvents tpSettingsGeneral As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tpSettingsMovies As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tpSettingsTvShows As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tpSettingsMusic As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tpSettingsHV As Dotnetrix.Controls.TabPageEX
    Friend WithEvents kscMainSettings As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kgMovieFolderSelect As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblFolderNameForMovieName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblVfoldermode As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblVFileMode As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFolderMode As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFileMode As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnMoviesBrowseForFolderFileMode As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMoviesClearFolderListFileMode As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbFolderFileMode As System.Windows.Forms.TextBox
    Friend WithEvents btnMoviesAddFolderByPathFileMode As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clbPathsFileMode As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnMoviesBrowseForFolder As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMoviesClearFolderList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnMoviesAddFolderByPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clbPaths As System.Windows.Forms.CheckedListBox
    Friend WithEvents klMovieFolderGroup As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgSettingsTVActive As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents Button8 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnRGF As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnRemoveAllTempTVFiles As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnRemoveAllCachedMovieData As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kgTvshowpaths As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnTVBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbTVPath As System.Windows.Forms.TextBox
    Friend WithEvents btnTVClearList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnTVAddPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lbTVShows As System.Windows.Forms.CheckedListBox
    Friend WithEvents klbTVShowFolders As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents kgTunesTunes As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnMusicBrowseForFolder As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbFolderMusic As System.Windows.Forms.TextBox
    Friend WithEvents btnMusicClearFolderList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMusicAddFolderByPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clbPathsMusic As System.Windows.Forms.CheckedListBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbmusic_createAlbumNfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbmusic_createArtistnfo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetcaldnPosters As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents krbColorPink As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorGreen As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents klblRemoveamoivefolder As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblRemoveatvshow1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMusicMI As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents getMediaImagesMusicInsert As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicInlay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicCd4 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicCd3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicCd2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicCd1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicBack As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMusicFront As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents klblMusicMI As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMoviesMI As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents getMediaImagesMoviesInsert As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesInlay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesCD4 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesCD3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesCD2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesCD1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesBack As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesMoviesFront As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMovieBackgrounds As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblFanart As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMoviesDownloadPosters As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblGetPostersFrom As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMoviesDownloadGeneral As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMoviesDownloadGeneral As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieFileCreate As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieDLO As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMovieFileOptions As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMovieScanningOptions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMoviesNameFilters As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMoviesNameFilterl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFCASOMovies As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFolderLevelNameFilters As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMoviesMisc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgFileLevelFilterOptions As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMoviesFileLevelFilterOptions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgShowsMI As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents getMediaImagesShowsInsert As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsInlay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsCD4 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsCD3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsCD2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsCD1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsBack As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents getMediaImagesShowsFront As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgGeneralProxy As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblGeneralProxy As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblIPv4Only As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProxyPort As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProxyIP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tbProxyPort As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbProxyIP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cbUseProxyServer As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents krbColorPro As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kgMusicAlbumArt As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblMusicAlbumArt As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbMusicGetAlbumArt As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblTunesWHat As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblGMaxCached As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblGQuality As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgGeneralMisc As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblGeneralMisc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbFilterUnderscoreDot As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbtvlangoverridebanners As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBeforeYear As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblMovieFileLevelFiltersWhatTheyDo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbFilterNameFileModeEverythingBefore1080p As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBefore1080i As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBefore720p As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBeforex264 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBeforeh264 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFileLevelFilterUnderscoreDot As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterNameFileModeEverythingBeforeDash As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbShowsStripEverythinginParan As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents krbColorSkyBlueLarge As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorBlingLarge As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents cbtv_showwgetwindows As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbGetMusicFanartFromHTBackdrops As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbMusicResizeMusicFanart As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbshows_UseStudioasRating As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents krbColorFire As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbColorBubbles As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents cbGeneralSupportSkinBasedFlagging As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbmovie_use_certification_for_mpaa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbMoviesCertificationLang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents rbtvshow_show_usePosterImageForShow As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtvshow_show_useWideImageForShow As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kgTvShowsShowWidePoster As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblCertLang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbcreateImdbIDtxt As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFilterFolderFileLevel As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgOfdbSettings As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblODFBSettingsLabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbofdb_UpdateVotes As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbofdb_UpdateRating As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbofdb_UpdateGenre As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbofdb_UpdatePlot As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbofdb_UpdateOutline As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbofdb_UpdateTitle As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents rbofdb_englishtagline As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbofdb_BlankTagline As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbofdb_usePlotOutline As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents tbFilterNameFileModeEverythingBeforeUserDefined1 As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterNameFileModeEverythingBeforeUserDefined1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbmoviesnonforename As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbscanforepisodemediainformation As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblUsingCustomExpression As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
