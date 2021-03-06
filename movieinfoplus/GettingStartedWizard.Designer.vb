﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GettingStartedWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GettingStartedWizard))
        Me.OK_Button = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.Cancel_Button = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.klblWelcomeText = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMovieFolderSelect = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnMoviesBrowseForFolder = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMoviesClearFolderList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbFolder = New System.Windows.Forms.TextBox
        Me.btnMoviesAddFolderByPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.clbPaths = New System.Windows.Forms.CheckedListBox
        Me.klMovieFolderGroup = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblDirectoryExampleText = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblMovieExampleText = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblTVShowExampleText = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgTvshowpaths = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnTVBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbTVPath = New System.Windows.Forms.TextBox
        Me.btnTVClearList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnTVAddPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lbTVShows = New System.Windows.Forms.ListBox
        Me.klbTVShowFolders = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kpBackGround = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnMoviesBrowseForFolderFile = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMoviesClearFolderListFile = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbFolderFile = New System.Windows.Forms.TextBox
        Me.btnMoviesAddFolderByPathFile = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.clbPathsFile = New System.Windows.Forms.CheckedListBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnMusicBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbMusicPath = New System.Windows.Forms.TextBox
        Me.btnMusicClearList = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMusicAddPath = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lbMusic = New System.Windows.Forms.ListBox
        Me.lblMusic = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblLetsGetStartedText = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.kgMainPanel = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        CType(Me.kgMovieFolderSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieFolderSelect.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieFolderSelect.Panel.SuspendLayout()
        Me.kgMovieFolderSelect.SuspendLayout()
        CType(Me.kgTvshowpaths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgTvshowpaths.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgTvshowpaths.Panel.SuspendLayout()
        Me.kgTvshowpaths.SuspendLayout()
        CType(Me.kpBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpBackGround.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.kgMainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMainPanel.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMainPanel.Panel.SuspendLayout()
        Me.kgMainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(234, 606)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(303, 39)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save my settings and continue"
        Me.OK_Button.Values.ExtraText = ""
        Me.OK_Button.Values.Image = Nothing
        Me.OK_Button.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.OK_Button.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.OK_Button.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.OK_Button.Values.Text = "Save my settings and continue"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(543, 606)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(84, 40)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.Values.ExtraText = ""
        Me.Cancel_Button.Values.Image = Nothing
        Me.Cancel_Button.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.Cancel_Button.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.Cancel_Button.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.Cancel_Button.Values.Text = "Cancel"
        '
        'klblWelcomeText
        '
        Me.klblWelcomeText.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblWelcomeText.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klblWelcomeText.Location = New System.Drawing.Point(0, 0)
        Me.klblWelcomeText.Name = "klblWelcomeText"
        Me.klblWelcomeText.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klblWelcomeText.Size = New System.Drawing.Size(885, 24)
        Me.klblWelcomeText.TabIndex = 1
        Me.klblWelcomeText.Text = "Welcome To Media Info Plus - Your Movie, Music, and TV Show manager!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.klblWelcomeText.Values.ExtraText = ""
        Me.klblWelcomeText.Values.Image = Nothing
        Me.klblWelcomeText.Values.Text = "Welcome To Media Info Plus - Your Movie, Music, and TV Show manager!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'kgMovieFolderSelect
        '
        Me.kgMovieFolderSelect.Location = New System.Drawing.Point(6, 57)
        Me.kgMovieFolderSelect.Name = "kgMovieFolderSelect"
        '
        'kgMovieFolderSelect.Panel
        '
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesBrowseForFolder)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesClearFolderList)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.tbFolder)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.btnMoviesAddFolderByPath)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.clbPaths)
        Me.kgMovieFolderSelect.Panel.Controls.Add(Me.klMovieFolderGroup)
        Me.kgMovieFolderSelect.Size = New System.Drawing.Size(574, 135)
        Me.kgMovieFolderSelect.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgMovieFolderSelect.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgMovieFolderSelect.StateCommon.Border.ColorAngle = 60.0!
        Me.kgMovieFolderSelect.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgMovieFolderSelect.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgMovieFolderSelect.StateCommon.Border.Rounding = 7
        Me.kgMovieFolderSelect.StateCommon.Border.Width = 2
        Me.kgMovieFolderSelect.TabIndex = 48
        '
        'btnMoviesBrowseForFolder
        '
        Me.btnMoviesBrowseForFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMoviesBrowseForFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesBrowseForFolder.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesBrowseForFolder.Location = New System.Drawing.Point(407, 27)
        Me.btnMoviesBrowseForFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoviesBrowseForFolder.Name = "btnMoviesBrowseForFolder"
        Me.btnMoviesBrowseForFolder.Size = New System.Drawing.Size(71, 36)
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
        Me.btnMoviesClearFolderList.Location = New System.Drawing.Point(480, 27)
        Me.btnMoviesClearFolderList.Name = "btnMoviesClearFolderList"
        Me.btnMoviesClearFolderList.Size = New System.Drawing.Size(79, 36)
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
        Me.tbFolder.Location = New System.Drawing.Point(1, 38)
        Me.tbFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Size = New System.Drawing.Size(319, 22)
        Me.tbFolder.TabIndex = 8
        Me.tbFolder.Text = "Enter the path and click add or click browse to select"
        '
        'btnMoviesAddFolderByPath
        '
        Me.btnMoviesAddFolderByPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesAddFolderByPath.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesAddFolderByPath.Location = New System.Drawing.Point(322, 27)
        Me.btnMoviesAddFolderByPath.Name = "btnMoviesAddFolderByPath"
        Me.btnMoviesAddFolderByPath.Size = New System.Drawing.Size(83, 36)
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
        Me.clbPaths.Location = New System.Drawing.Point(0, 66)
        Me.clbPaths.Name = "clbPaths"
        Me.clbPaths.Size = New System.Drawing.Size(559, 55)
        Me.clbPaths.TabIndex = 43
        '
        'klMovieFolderGroup
        '
        Me.klMovieFolderGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.klMovieFolderGroup.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klMovieFolderGroup.Location = New System.Drawing.Point(0, 0)
        Me.klMovieFolderGroup.Name = "klMovieFolderGroup"
        Me.klMovieFolderGroup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klMovieFolderGroup.Size = New System.Drawing.Size(564, 24)
        Me.klMovieFolderGroup.TabIndex = 46
        Me.klMovieFolderGroup.Text = "Movies - Folder Level"
        Me.klMovieFolderGroup.Values.ExtraText = "Each Movie in it's own folder, add the top level folder here."
        Me.klMovieFolderGroup.Values.Image = Nothing
        Me.klMovieFolderGroup.Values.Text = "Movies - Folder Level"
        '
        'klblDirectoryExampleText
        '
        Me.klblDirectoryExampleText.Location = New System.Drawing.Point(576, 62)
        Me.klblDirectoryExampleText.Name = "klblDirectoryExampleText"
        Me.klblDirectoryExampleText.Size = New System.Drawing.Size(312, 574)
        Me.klblDirectoryExampleText.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.klblDirectoryExampleText.TabIndex = 49
        Me.klblDirectoryExampleText.Text = resources.GetString("klblDirectoryExampleText.Text")
        Me.klblDirectoryExampleText.Values.ExtraText = ""
        Me.klblDirectoryExampleText.Values.Image = Nothing
        Me.klblDirectoryExampleText.Values.Text = resources.GetString("klblDirectoryExampleText.Values.Text")
        '
        'klblMovieExampleText
        '
        Me.klblMovieExampleText.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblMovieExampleText.Location = New System.Drawing.Point(687, 79)
        Me.klblMovieExampleText.Name = "klblMovieExampleText"
        Me.klblMovieExampleText.Size = New System.Drawing.Size(177, 54)
        Me.klblMovieExampleText.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.klblMovieExampleText.TabIndex = 50
        Me.klblMovieExampleText.Text = "Folder Level Movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Movies in Seperate Folders)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add ""c:\media\Movies\"""
        Me.klblMovieExampleText.Values.ExtraText = ""
        Me.klblMovieExampleText.Values.Image = Nothing
        Me.klblMovieExampleText.Values.Text = "Folder Level Movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Movies in Seperate Folders)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add ""c:\media\Movies\"""
        '
        'klblTVShowExampleText
        '
        Me.klblTVShowExampleText.Location = New System.Drawing.Point(687, 302)
        Me.klblTVShowExampleText.Name = "klblTVShowExampleText"
        Me.klblTVShowExampleText.Size = New System.Drawing.Size(174, 37)
        Me.klblTVShowExampleText.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.klblTVShowExampleText.TabIndex = 51
        Me.klblTVShowExampleText.Text = "For TV Shows you would add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      c:\media\TVShows"
        Me.klblTVShowExampleText.Values.ExtraText = ""
        Me.klblTVShowExampleText.Values.Image = Nothing
        Me.klblTVShowExampleText.Values.Text = "For TV Shows you would add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      c:\media\TVShows"
        '
        'kgTvshowpaths
        '
        Me.kgTvshowpaths.Location = New System.Drawing.Point(6, 342)
        Me.kgTvshowpaths.Name = "kgTvshowpaths"
        '
        'kgTvshowpaths.Panel
        '
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVBrowse)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.tbTVPath)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVClearList)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.btnTVAddPath)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.lbTVShows)
        Me.kgTvshowpaths.Panel.Controls.Add(Me.klbTVShowFolders)
        Me.kgTvshowpaths.Size = New System.Drawing.Size(574, 128)
        Me.kgTvshowpaths.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgTvshowpaths.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgTvshowpaths.StateCommon.Border.ColorAngle = 60.0!
        Me.kgTvshowpaths.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgTvshowpaths.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgTvshowpaths.StateCommon.Border.Rounding = 7
        Me.kgTvshowpaths.StateCommon.Border.Width = 2
        Me.kgTvshowpaths.TabIndex = 52
        '
        'btnTVBrowse
        '
        Me.btnTVBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTVBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnTVBrowse.Location = New System.Drawing.Point(409, 20)
        Me.btnTVBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTVBrowse.Name = "btnTVBrowse"
        Me.btnTVBrowse.Size = New System.Drawing.Size(71, 35)
        Me.btnTVBrowse.TabIndex = 7
        Me.btnTVBrowse.Text = "Browse"
        Me.btnTVBrowse.Values.ExtraText = ""
        Me.btnTVBrowse.Values.Image = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnTVBrowse.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnTVBrowse.Values.Text = "Browse"
        '
        'tbTVPath
        '
        Me.tbTVPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTVPath.Location = New System.Drawing.Point(2, 30)
        Me.tbTVPath.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTVPath.Name = "tbTVPath"
        Me.tbTVPath.Size = New System.Drawing.Size(321, 22)
        Me.tbTVPath.TabIndex = 8
        Me.tbTVPath.Text = "Enter the path and click add or click browse to select"
        '
        'btnTVClearList
        '
        Me.btnTVClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVClearList.ForeColor = System.Drawing.Color.Black
        Me.btnTVClearList.Location = New System.Drawing.Point(483, 20)
        Me.btnTVClearList.Name = "btnTVClearList"
        Me.btnTVClearList.Size = New System.Drawing.Size(78, 35)
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
        Me.btnTVAddPath.Enabled = False
        Me.btnTVAddPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTVAddPath.ForeColor = System.Drawing.Color.Black
        Me.btnTVAddPath.Location = New System.Drawing.Point(324, 20)
        Me.btnTVAddPath.Name = "btnTVAddPath"
        Me.btnTVAddPath.Size = New System.Drawing.Size(83, 35)
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
        Me.lbTVShows.Location = New System.Drawing.Point(2, 57)
        Me.lbTVShows.Name = "lbTVShows"
        Me.lbTVShows.Size = New System.Drawing.Size(558, 56)
        Me.lbTVShows.TabIndex = 47
        '
        'klbTVShowFolders
        '
        Me.klbTVShowFolders.Dock = System.Windows.Forms.DockStyle.Top
        Me.klbTVShowFolders.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klbTVShowFolders.Location = New System.Drawing.Point(0, 0)
        Me.klbTVShowFolders.Name = "klbTVShowFolders"
        Me.klbTVShowFolders.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klbTVShowFolders.Size = New System.Drawing.Size(564, 24)
        Me.klbTVShowFolders.TabIndex = 46
        Me.klbTVShowFolders.Text = "TV Shows"
        Me.klbTVShowFolders.Values.ExtraText = "Select the root TV Show Folder"
        Me.klbTVShowFolders.Values.Image = Nothing
        Me.klbTVShowFolders.Values.Text = "TV Shows"
        '
        'kpBackGround
        '
        Me.kpBackGround.Controls.Add(Me.KryptonGroup2)
        Me.kpBackGround.Controls.Add(Me.KryptonGroup1)
        Me.kpBackGround.Controls.Add(Me.Cancel_Button)
        Me.kpBackGround.Controls.Add(Me.OK_Button)
        Me.kpBackGround.Controls.Add(Me.klblLetsGetStartedText)
        Me.kpBackGround.Controls.Add(Me.klblWelcomeText)
        Me.kpBackGround.Controls.Add(Me.klblTVShowExampleText)
        Me.kpBackGround.Controls.Add(Me.klblMovieExampleText)
        Me.kpBackGround.Controls.Add(Me.kgTvshowpaths)
        Me.kpBackGround.Controls.Add(Me.kgMovieFolderSelect)
        Me.kpBackGround.Controls.Add(Me.klblDirectoryExampleText)
        Me.kpBackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kpBackGround.Location = New System.Drawing.Point(0, 0)
        Me.kpBackGround.Margin = New System.Windows.Forms.Padding(0)
        Me.kpBackGround.Name = "kpBackGround"
        Me.kpBackGround.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kpBackGround.Size = New System.Drawing.Size(885, 647)
        Me.kpBackGround.TabIndex = 53
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Location = New System.Drawing.Point(6, 197)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.btnMoviesBrowseForFolderFile)
        Me.KryptonGroup2.Panel.Controls.Add(Me.btnMoviesClearFolderListFile)
        Me.KryptonGroup2.Panel.Controls.Add(Me.tbFolderFile)
        Me.KryptonGroup2.Panel.Controls.Add(Me.btnMoviesAddFolderByPathFile)
        Me.KryptonGroup2.Panel.Controls.Add(Me.clbPathsFile)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(574, 140)
        Me.KryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.KryptonGroup2.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.KryptonGroup2.StateCommon.Border.ColorAngle = 60.0!
        Me.KryptonGroup2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.KryptonGroup2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup2.StateCommon.Border.Rounding = 7
        Me.KryptonGroup2.StateCommon.Border.Width = 2
        Me.KryptonGroup2.TabIndex = 55
        '
        'btnMoviesBrowseForFolderFile
        '
        Me.btnMoviesBrowseForFolderFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMoviesBrowseForFolderFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesBrowseForFolderFile.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesBrowseForFolderFile.Location = New System.Drawing.Point(407, 26)
        Me.btnMoviesBrowseForFolderFile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoviesBrowseForFolderFile.Name = "btnMoviesBrowseForFolderFile"
        Me.btnMoviesBrowseForFolderFile.Size = New System.Drawing.Size(71, 36)
        Me.btnMoviesBrowseForFolderFile.TabIndex = 7
        Me.btnMoviesBrowseForFolderFile.Text = "Browse"
        Me.btnMoviesBrowseForFolderFile.Values.ExtraText = ""
        Me.btnMoviesBrowseForFolderFile.Values.Image = Nothing
        Me.btnMoviesBrowseForFolderFile.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesBrowseForFolderFile.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesBrowseForFolderFile.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesBrowseForFolderFile.Values.Text = "Browse"
        '
        'btnMoviesClearFolderListFile
        '
        Me.btnMoviesClearFolderListFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesClearFolderListFile.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesClearFolderListFile.Location = New System.Drawing.Point(480, 26)
        Me.btnMoviesClearFolderListFile.Name = "btnMoviesClearFolderListFile"
        Me.btnMoviesClearFolderListFile.Size = New System.Drawing.Size(79, 36)
        Me.btnMoviesClearFolderListFile.TabIndex = 45
        Me.btnMoviesClearFolderListFile.Text = "Clear List"
        Me.btnMoviesClearFolderListFile.Values.ExtraText = ""
        Me.btnMoviesClearFolderListFile.Values.Image = Nothing
        Me.btnMoviesClearFolderListFile.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesClearFolderListFile.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesClearFolderListFile.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesClearFolderListFile.Values.Text = "Clear List"
        '
        'tbFolderFile
        '
        Me.tbFolderFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolderFile.Location = New System.Drawing.Point(1, 37)
        Me.tbFolderFile.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolderFile.Name = "tbFolderFile"
        Me.tbFolderFile.Size = New System.Drawing.Size(319, 22)
        Me.tbFolderFile.TabIndex = 8
        Me.tbFolderFile.Text = "Enter the path and click add or click browse to select"
        '
        'btnMoviesAddFolderByPathFile
        '
        Me.btnMoviesAddFolderByPathFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviesAddFolderByPathFile.ForeColor = System.Drawing.Color.Black
        Me.btnMoviesAddFolderByPathFile.Location = New System.Drawing.Point(322, 26)
        Me.btnMoviesAddFolderByPathFile.Name = "btnMoviesAddFolderByPathFile"
        Me.btnMoviesAddFolderByPathFile.Size = New System.Drawing.Size(83, 36)
        Me.btnMoviesAddFolderByPathFile.TabIndex = 44
        Me.btnMoviesAddFolderByPathFile.Text = "Add Path"
        Me.btnMoviesAddFolderByPathFile.Values.ExtraText = ""
        Me.btnMoviesAddFolderByPathFile.Values.Image = Nothing
        Me.btnMoviesAddFolderByPathFile.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMoviesAddFolderByPathFile.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMoviesAddFolderByPathFile.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMoviesAddFolderByPathFile.Values.Text = "Add Path"
        '
        'clbPathsFile
        '
        Me.clbPathsFile.CheckOnClick = True
        Me.clbPathsFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbPathsFile.FormattingEnabled = True
        Me.clbPathsFile.Location = New System.Drawing.Point(0, 66)
        Me.clbPathsFile.Name = "clbPathsFile"
        Me.clbPathsFile.Size = New System.Drawing.Size(559, 55)
        Me.clbPathsFile.TabIndex = 43
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.KryptonLabel1.Size = New System.Drawing.Size(564, 24)
        Me.KryptonLabel1.TabIndex = 46
        Me.KryptonLabel1.Text = "Movies - File Level"
        Me.KryptonLabel1.Values.ExtraText = "Got a bunch of movies in one folder, add that top level folder"
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Movies - File Level"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(6, 475)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnMusicBrowse)
        Me.KryptonGroup1.Panel.Controls.Add(Me.tbMusicPath)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnMusicClearList)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnMusicAddPath)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lbMusic)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblMusic)
        Me.KryptonGroup1.Size = New System.Drawing.Size(574, 129)
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.KryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.KryptonGroup1.StateCommon.Border.ColorAngle = 60.0!
        Me.KryptonGroup1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Rounding = 7
        Me.KryptonGroup1.StateCommon.Border.Width = 2
        Me.KryptonGroup1.TabIndex = 54
        '
        'btnMusicBrowse
        '
        Me.btnMusicBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMusicBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnMusicBrowse.Location = New System.Drawing.Point(409, 19)
        Me.btnMusicBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMusicBrowse.Name = "btnMusicBrowse"
        Me.btnMusicBrowse.Size = New System.Drawing.Size(71, 36)
        Me.btnMusicBrowse.TabIndex = 7
        Me.btnMusicBrowse.Text = "Browse"
        Me.btnMusicBrowse.Values.ExtraText = ""
        Me.btnMusicBrowse.Values.Image = Nothing
        Me.btnMusicBrowse.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicBrowse.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicBrowse.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicBrowse.Values.Text = "Browse"
        '
        'tbMusicPath
        '
        Me.tbMusicPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMusicPath.Location = New System.Drawing.Point(2, 30)
        Me.tbMusicPath.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMusicPath.Name = "tbMusicPath"
        Me.tbMusicPath.Size = New System.Drawing.Size(321, 22)
        Me.tbMusicPath.TabIndex = 8
        Me.tbMusicPath.Text = "Enter the path and click add or click browse to select"
        '
        'btnMusicClearList
        '
        Me.btnMusicClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicClearList.ForeColor = System.Drawing.Color.Black
        Me.btnMusicClearList.Location = New System.Drawing.Point(483, 19)
        Me.btnMusicClearList.Name = "btnMusicClearList"
        Me.btnMusicClearList.Size = New System.Drawing.Size(78, 36)
        Me.btnMusicClearList.TabIndex = 45
        Me.btnMusicClearList.Text = "Clear List"
        Me.btnMusicClearList.Values.ExtraText = ""
        Me.btnMusicClearList.Values.Image = Nothing
        Me.btnMusicClearList.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicClearList.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicClearList.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicClearList.Values.Text = "Clear List"
        '
        'btnMusicAddPath
        '
        Me.btnMusicAddPath.Enabled = False
        Me.btnMusicAddPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicAddPath.ForeColor = System.Drawing.Color.Black
        Me.btnMusicAddPath.Location = New System.Drawing.Point(324, 19)
        Me.btnMusicAddPath.Name = "btnMusicAddPath"
        Me.btnMusicAddPath.Size = New System.Drawing.Size(83, 36)
        Me.btnMusicAddPath.TabIndex = 44
        Me.btnMusicAddPath.Text = "Add Path"
        Me.btnMusicAddPath.Values.ExtraText = ""
        Me.btnMusicAddPath.Values.Image = Nothing
        Me.btnMusicAddPath.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMusicAddPath.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMusicAddPath.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMusicAddPath.Values.Text = "Add Path"
        '
        'lbMusic
        '
        Me.lbMusic.FormattingEnabled = True
        Me.lbMusic.Location = New System.Drawing.Point(2, 57)
        Me.lbMusic.Name = "lbMusic"
        Me.lbMusic.Size = New System.Drawing.Size(558, 56)
        Me.lbMusic.TabIndex = 47
        '
        'lblMusic
        '
        Me.lblMusic.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMusic.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblMusic.Location = New System.Drawing.Point(0, 0)
        Me.lblMusic.Name = "lblMusic"
        Me.lblMusic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblMusic.Size = New System.Drawing.Size(564, 24)
        Me.lblMusic.TabIndex = 46
        Me.lblMusic.Text = "Music"
        Me.lblMusic.Values.ExtraText = "Select the root Music Folder"
        Me.lblMusic.Values.Image = Nothing
        Me.lblMusic.Values.Text = "Music"
        '
        'klblLetsGetStartedText
        '
        Me.klblLetsGetStartedText.Location = New System.Drawing.Point(28, 30)
        Me.klblLetsGetStartedText.Name = "klblLetsGetStartedText"
        Me.klblLetsGetStartedText.Size = New System.Drawing.Size(509, 21)
        Me.klblLetsGetStartedText.TabIndex = 53
        Me.klblLetsGetStartedText.Text = " To get started, select the folder(s) that contain your Movies and/or TV Shows be" & _
            "low."
        Me.klblLetsGetStartedText.Values.ExtraText = ""
        Me.klblLetsGetStartedText.Values.Image = Nothing
        Me.klblLetsGetStartedText.Values.Text = " To get started, select the folder(s) that contain your Movies and/or TV Shows be" & _
            "low."
        '
        'kgMainPanel
        '
        Me.kgMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgMainPanel.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.kgMainPanel.Name = "kgMainPanel"
        '
        'kgMainPanel.Panel
        '
        Me.kgMainPanel.Panel.Controls.Add(Me.kpBackGround)
        Me.kgMainPanel.Size = New System.Drawing.Size(899, 661)
        Me.kgMainPanel.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgMainPanel.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgMainPanel.StateCommon.Border.ColorAngle = 60.0!
        Me.kgMainPanel.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgMainPanel.StateCommon.Border.Rounding = 10
        Me.kgMainPanel.StateCommon.Border.Width = 4
        Me.kgMainPanel.TabIndex = 54
        '
        'GettingStartedWizard
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(899, 661)
        Me.Controls.Add(Me.kgMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GettingStartedWizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Info Plus - Getting Started Wizard"
        CType(Me.kgMovieFolderSelect.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFolderSelect.Panel.ResumeLayout(False)
        Me.kgMovieFolderSelect.Panel.PerformLayout()
        CType(Me.kgMovieFolderSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieFolderSelect.ResumeLayout(False)
        CType(Me.kgTvshowpaths.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvshowpaths.Panel.ResumeLayout(False)
        Me.kgTvshowpaths.Panel.PerformLayout()
        CType(Me.kgTvshowpaths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgTvshowpaths.ResumeLayout(False)
        CType(Me.kpBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpBackGround.ResumeLayout(False)
        Me.kpBackGround.PerformLayout()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.kgMainPanel.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMainPanel.Panel.ResumeLayout(False)
        CType(Me.kgMainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Cancel_Button As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents klblWelcomeText As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMovieFolderSelect As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnMoviesBrowseForFolder As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMoviesClearFolderList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnMoviesAddFolderByPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clbPaths As System.Windows.Forms.CheckedListBox
    Friend WithEvents klMovieFolderGroup As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblDirectoryExampleText As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblMovieExampleText As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblTVShowExampleText As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgTvshowpaths As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnTVBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbTVPath As System.Windows.Forms.TextBox
    Friend WithEvents btnTVClearList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnTVAddPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lbTVShows As System.Windows.Forms.ListBox
    Friend WithEvents klbTVShowFolders As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kpBackGround As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents klblLetsGetStartedText As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents kgMainPanel As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnMusicBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbMusicPath As System.Windows.Forms.TextBox
    Friend WithEvents btnMusicClearList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMusicAddPath As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lbMusic As System.Windows.Forms.ListBox
    Friend WithEvents lblMusic As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnMoviesBrowseForFolderFile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMoviesClearFolderListFile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbFolderFile As System.Windows.Forms.TextBox
    Friend WithEvents btnMoviesAddFolderByPathFile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clbPathsFile As System.Windows.Forms.CheckedListBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
