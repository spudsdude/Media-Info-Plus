<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMusicSortWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMusicSortWizard))
        Me.tbSrcMusicFolder = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbDstMusicFolder = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cbLowerCaseFileNames = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cbRenameMusicFiles = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.kgRenameMusicFileOptions = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbleaveunknownfilesalone = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lbFormatOfNewFileName = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbUseUnderScoreForSpaces = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lbDelimiter = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbDelimiter = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblExampleFormat = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbDelim3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbDelim2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbDelim1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbFourth = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cbThird = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cbSecond = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cbFirst = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.kscMyMain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.btnBrowseForDstFolder = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnBrowseSrc = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnStart = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblPleaseWait = New System.Windows.Forms.Label
        Me.kgCurStatus = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblStatus = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.kgMain = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.bwStartSorting = New System.ComponentModel.BackgroundWorker
        Me.kgCurStats = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnCancelWorker = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblReadingFolderData = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.fbdBrowse = New System.Windows.Forms.FolderBrowserDialog
        Me.cbUse2digitTrackNums = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        CType(Me.kgRenameMusicFileOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgRenameMusicFileOptions.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgRenameMusicFileOptions.Panel.SuspendLayout()
        Me.kgRenameMusicFileOptions.SuspendLayout()
        CType(Me.kscMyMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscMyMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMyMain.Panel1.SuspendLayout()
        CType(Me.kscMyMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMyMain.SuspendLayout()
        CType(Me.kgCurStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgCurStatus.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgCurStatus.Panel.SuspendLayout()
        Me.kgCurStatus.SuspendLayout()
        CType(Me.kgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMain.Panel.SuspendLayout()
        Me.kgMain.SuspendLayout()
        CType(Me.kgCurStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgCurStats.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgCurStats.Panel.SuspendLayout()
        Me.kgCurStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSrcMusicFolder
        '
        Me.tbSrcMusicFolder.Location = New System.Drawing.Point(3, 3)
        Me.tbSrcMusicFolder.Name = "tbSrcMusicFolder"
        Me.tbSrcMusicFolder.Size = New System.Drawing.Size(510, 28)
        Me.tbSrcMusicFolder.TabIndex = 1
        Me.tbSrcMusicFolder.Text = "Music Folder (source)"
        '
        'tbDstMusicFolder
        '
        Me.tbDstMusicFolder.Location = New System.Drawing.Point(3, 32)
        Me.tbDstMusicFolder.Name = "tbDstMusicFolder"
        Me.tbDstMusicFolder.Size = New System.Drawing.Size(509, 28)
        Me.tbDstMusicFolder.TabIndex = 2
        Me.tbDstMusicFolder.Text = "Music Folder (destination)"
        '
        'cbLowerCaseFileNames
        '
        Me.cbLowerCaseFileNames.Location = New System.Drawing.Point(4, 3)
        Me.cbLowerCaseFileNames.Name = "cbLowerCaseFileNames"
        Me.cbLowerCaseFileNames.Size = New System.Drawing.Size(163, 16)
        Me.cbLowerCaseFileNames.TabIndex = 3
        Me.cbLowerCaseFileNames.Text = "Make file names lower case"
        Me.cbLowerCaseFileNames.Values.ExtraText = ""
        Me.cbLowerCaseFileNames.Values.Image = Nothing
        Me.cbLowerCaseFileNames.Values.Text = "Make file names lower case"
        '
        'cbRenameMusicFiles
        '
        Me.cbRenameMusicFiles.Location = New System.Drawing.Point(15, 61)
        Me.cbRenameMusicFiles.Name = "cbRenameMusicFiles"
        Me.cbRenameMusicFiles.Size = New System.Drawing.Size(126, 16)
        Me.cbRenameMusicFiles.TabIndex = 4
        Me.cbRenameMusicFiles.Text = "Rename Music Files"
        Me.cbRenameMusicFiles.Values.ExtraText = ""
        Me.cbRenameMusicFiles.Values.Image = Nothing
        Me.cbRenameMusicFiles.Values.Text = "Rename Music Files"
        '
        'kgRenameMusicFileOptions
        '
        Me.kgRenameMusicFileOptions.Enabled = False
        Me.kgRenameMusicFileOptions.Location = New System.Drawing.Point(29, 81)
        Me.kgRenameMusicFileOptions.Name = "kgRenameMusicFileOptions"
        '
        'kgRenameMusicFileOptions.Panel
        '
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbUse2digitTrackNums)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbleaveunknownfilesalone)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lbFormatOfNewFileName)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbUseUnderScoreForSpaces)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lbDelimiter)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbDelimiter)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lblExampleFormat)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.KryptonLabel5)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lbDelim3)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lbDelim2)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.lbDelim1)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbFourth)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbThird)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbSecond)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbFirst)
        Me.kgRenameMusicFileOptions.Panel.Controls.Add(Me.cbLowerCaseFileNames)
        Me.kgRenameMusicFileOptions.Size = New System.Drawing.Size(670, 145)
        Me.kgRenameMusicFileOptions.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgRenameMusicFileOptions.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgRenameMusicFileOptions.StateCommon.Border.ColorAngle = 60.0!
        Me.kgRenameMusicFileOptions.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgRenameMusicFileOptions.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgRenameMusicFileOptions.StateCommon.Border.Rounding = 7
        Me.kgRenameMusicFileOptions.StateCommon.Border.Width = 2
        Me.kgRenameMusicFileOptions.TabIndex = 5
        '
        'cbleaveunknownfilesalone
        '
        Me.cbleaveunknownfilesalone.Location = New System.Drawing.Point(216, 3)
        Me.cbleaveunknownfilesalone.Name = "cbleaveunknownfilesalone"
        Me.cbleaveunknownfilesalone.Size = New System.Drawing.Size(164, 16)
        Me.cbleaveunknownfilesalone.TabIndex = 19
        Me.cbleaveunknownfilesalone.Text = "Do not copy unknown music"
        Me.cbleaveunknownfilesalone.Values.ExtraText = ""
        Me.cbleaveunknownfilesalone.Values.Image = Nothing
        Me.cbleaveunknownfilesalone.Values.Text = "Do not copy unknown music"
        '
        'lbFormatOfNewFileName
        '
        Me.lbFormatOfNewFileName.Location = New System.Drawing.Point(5, 69)
        Me.lbFormatOfNewFileName.Name = "lbFormatOfNewFileName"
        Me.lbFormatOfNewFileName.Size = New System.Drawing.Size(117, 16)
        Me.lbFormatOfNewFileName.TabIndex = 18
        Me.lbFormatOfNewFileName.Text = "New file name format"
        Me.lbFormatOfNewFileName.Values.ExtraText = ""
        Me.lbFormatOfNewFileName.Values.Image = Nothing
        Me.lbFormatOfNewFileName.Values.Text = "New file name format"
        '
        'cbUseUnderScoreForSpaces
        '
        Me.cbUseUnderScoreForSpaces.Location = New System.Drawing.Point(4, 25)
        Me.cbUseUnderScoreForSpaces.Name = "cbUseUnderScoreForSpaces"
        Me.cbUseUnderScoreForSpaces.Size = New System.Drawing.Size(162, 16)
        Me.cbUseUnderScoreForSpaces.TabIndex = 17
        Me.cbUseUnderScoreForSpaces.Text = "Use Underscore for Spaces"
        Me.cbUseUnderScoreForSpaces.Values.ExtraText = ""
        Me.cbUseUnderScoreForSpaces.Values.Image = Nothing
        Me.cbUseUnderScoreForSpaces.Values.Text = "Use Underscore for Spaces"
        '
        'lbDelimiter
        '
        Me.lbDelimiter.Location = New System.Drawing.Point(5, 47)
        Me.lbDelimiter.Name = "lbDelimiter"
        Me.lbDelimiter.Size = New System.Drawing.Size(158, 16)
        Me.lbDelimiter.TabIndex = 16
        Me.lbDelimiter.Text = "What to put between sections"
        Me.lbDelimiter.Values.ExtraText = ""
        Me.lbDelimiter.Values.Image = Nothing
        Me.lbDelimiter.Values.Text = "What to put between sections"
        '
        'cbDelimiter
        '
        Me.cbDelimiter.DropDownWidth = 150
        Me.cbDelimiter.FormattingEnabled = False
        Me.cbDelimiter.Items.AddRange(New Object() {" - <Space><Hyphen><Space>(Default)", "_ <Underscore>", "   <Space>", "-  <Hyphen>", ".   <Dot>", "=  <Equals>"})
        Me.cbDelimiter.Location = New System.Drawing.Point(164, 43)
        Me.cbDelimiter.Name = "cbDelimiter"
        Me.cbDelimiter.Size = New System.Drawing.Size(192, 28)
        Me.cbDelimiter.TabIndex = 15
        Me.cbDelimiter.Text = " - (Space Dash Space - Default)"
        '
        'lblExampleFormat
        '
        Me.lblExampleFormat.Location = New System.Drawing.Point(157, 116)
        Me.lblExampleFormat.Name = "lblExampleFormat"
        Me.lblExampleFormat.Size = New System.Drawing.Size(358, 16)
        Me.lblExampleFormat.TabIndex = 14
        Me.lblExampleFormat.Text = "Default Example: Green Day - Dookie - 5 - Welcome to Paradise.mp3"
        Me.lblExampleFormat.Values.ExtraText = ""
        Me.lblExampleFormat.Values.Image = Nothing
        Me.lblExampleFormat.Values.Text = "Default Example: Green Day - Dookie - 5 - Welcome to Paradise.mp3"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(578, 91)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel5.TabIndex = 13
        Me.KryptonLabel5.Text = ".extension"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ".extension"
        '
        'lbDelim3
        '
        Me.lbDelim3.Location = New System.Drawing.Point(431, 91)
        Me.lbDelim3.Name = "lbDelim3"
        Me.lbDelim3.Size = New System.Drawing.Size(16, 16)
        Me.lbDelim3.TabIndex = 12
        Me.lbDelim3.Text = "_"
        Me.lbDelim3.Values.ExtraText = ""
        Me.lbDelim3.Values.Image = Nothing
        Me.lbDelim3.Values.Text = "_"
        '
        'lbDelim2
        '
        Me.lbDelim2.Location = New System.Drawing.Point(284, 91)
        Me.lbDelim2.Name = "lbDelim2"
        Me.lbDelim2.Size = New System.Drawing.Size(16, 16)
        Me.lbDelim2.TabIndex = 11
        Me.lbDelim2.Text = "_"
        Me.lbDelim2.Values.ExtraText = ""
        Me.lbDelim2.Values.Image = Nothing
        Me.lbDelim2.Values.Text = "_"
        '
        'lbDelim1
        '
        Me.lbDelim1.Location = New System.Drawing.Point(136, 91)
        Me.lbDelim1.Name = "lbDelim1"
        Me.lbDelim1.Size = New System.Drawing.Size(16, 16)
        Me.lbDelim1.TabIndex = 10
        Me.lbDelim1.Text = "_"
        Me.lbDelim1.Values.ExtraText = ""
        Me.lbDelim1.Values.Image = Nothing
        Me.lbDelim1.Values.Text = "_"
        '
        'cbFourth
        '
        Me.cbFourth.DropDownWidth = 121
        Me.cbFourth.FormattingEnabled = False
        Me.cbFourth.Items.AddRange(New Object() {"Artist", "Album", "Track Number", "Track Name", "<none>"})
        Me.cbFourth.Location = New System.Drawing.Point(451, 87)
        Me.cbFourth.Name = "cbFourth"
        Me.cbFourth.Size = New System.Drawing.Size(121, 28)
        Me.cbFourth.TabIndex = 8
        Me.cbFourth.Text = "Track Name"
        '
        'cbThird
        '
        Me.cbThird.DropDownWidth = 121
        Me.cbThird.FormattingEnabled = False
        Me.cbThird.Items.AddRange(New Object() {"Artist", "Album", "Track Number", "Track Name", "<none>"})
        Me.cbThird.Location = New System.Drawing.Point(304, 87)
        Me.cbThird.Name = "cbThird"
        Me.cbThird.Size = New System.Drawing.Size(121, 28)
        Me.cbThird.TabIndex = 7
        Me.cbThird.Text = "Track Number"
        '
        'cbSecond
        '
        Me.cbSecond.DropDownWidth = 121
        Me.cbSecond.FormattingEnabled = False
        Me.cbSecond.Items.AddRange(New Object() {"Artist", "Album", "Track Number", "Track Name", "<none>"})
        Me.cbSecond.Location = New System.Drawing.Point(157, 87)
        Me.cbSecond.Name = "cbSecond"
        Me.cbSecond.Size = New System.Drawing.Size(121, 28)
        Me.cbSecond.TabIndex = 6
        Me.cbSecond.Text = "Album"
        '
        'cbFirst
        '
        Me.cbFirst.DropDownWidth = 121
        Me.cbFirst.FormattingEnabled = False
        Me.cbFirst.Items.AddRange(New Object() {"Artist", "Album", "Track Number", "Track Name"})
        Me.cbFirst.Location = New System.Drawing.Point(9, 87)
        Me.cbFirst.Name = "cbFirst"
        Me.cbFirst.Size = New System.Drawing.Size(121, 28)
        Me.cbFirst.TabIndex = 5
        Me.cbFirst.Text = "Artist"
        '
        'kscMyMain
        '
        Me.kscMyMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscMyMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.kscMyMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.kscMyMain.Location = New System.Drawing.Point(0, 0)
        Me.kscMyMain.Name = "kscMyMain"
        Me.kscMyMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscMyMain.Panel1
        '
        Me.kscMyMain.Panel1.Controls.Add(Me.btnBrowseForDstFolder)
        Me.kscMyMain.Panel1.Controls.Add(Me.btnBrowseSrc)
        Me.kscMyMain.Panel1.Controls.Add(Me.tbSrcMusicFolder)
        Me.kscMyMain.Panel1.Controls.Add(Me.kgRenameMusicFileOptions)
        Me.kscMyMain.Panel1.Controls.Add(Me.cbRenameMusicFiles)
        Me.kscMyMain.Panel1.Controls.Add(Me.tbDstMusicFolder)
        Me.kscMyMain.Panel2Collapsed = True
        Me.kscMyMain.Size = New System.Drawing.Size(718, 257)
        Me.kscMyMain.SplitterDistance = 150
        Me.kscMyMain.StateCommon.Back.Color1 = System.Drawing.Color.Black
        Me.kscMyMain.StateCommon.Back.Color2 = System.Drawing.Color.Silver
        Me.kscMyMain.StateCommon.Back.ColorAngle = 60.0!
        Me.kscMyMain.TabIndex = 6
        '
        'btnBrowseForDstFolder
        '
        Me.btnBrowseForDstFolder.Location = New System.Drawing.Point(517, 34)
        Me.btnBrowseForDstFolder.Name = "btnBrowseForDstFolder"
        Me.btnBrowseForDstFolder.Size = New System.Drawing.Size(184, 25)
        Me.btnBrowseForDstFolder.TabIndex = 7
        Me.btnBrowseForDstFolder.Text = "Browse for Destination Folder"
        Me.btnBrowseForDstFolder.Values.ExtraText = ""
        Me.btnBrowseForDstFolder.Values.Image = Nothing
        Me.btnBrowseForDstFolder.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBrowseForDstFolder.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBrowseForDstFolder.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBrowseForDstFolder.Values.Text = "Browse for Destination Folder"
        '
        'btnBrowseSrc
        '
        Me.btnBrowseSrc.Location = New System.Drawing.Point(517, 4)
        Me.btnBrowseSrc.Name = "btnBrowseSrc"
        Me.btnBrowseSrc.Size = New System.Drawing.Size(182, 25)
        Me.btnBrowseSrc.TabIndex = 6
        Me.btnBrowseSrc.Text = "Browse for Source Folder"
        Me.btnBrowseSrc.Values.ExtraText = ""
        Me.btnBrowseSrc.Values.Image = Nothing
        Me.btnBrowseSrc.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBrowseSrc.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBrowseSrc.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBrowseSrc.Values.Text = "Browse for Source Folder"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(375, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 25)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Values.ExtraText = ""
        Me.btnCancel.Values.Image = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(194, 244)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(147, 25)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start Processing"
        Me.btnStart.Values.ExtraText = ""
        Me.btnStart.Values.Image = Nothing
        Me.btnStart.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnStart.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnStart.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnStart.Values.Text = "Start Processing"
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Location = New System.Drawing.Point(217, 149)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(264, 13)
        Me.lblPleaseWait.TabIndex = 3
        Me.lblPleaseWait.Text = "Please wait while your music files are being processed."
        Me.lblPleaseWait.Visible = False
        '
        'kgCurStatus
        '
        Me.kgCurStatus.Location = New System.Drawing.Point(4, 16)
        Me.kgCurStatus.Name = "kgCurStatus"
        '
        'kgCurStatus.Panel
        '
        Me.kgCurStatus.Panel.Controls.Add(Me.lblStatus)
        Me.kgCurStatus.Size = New System.Drawing.Size(697, 74)
        Me.kgCurStatus.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgCurStatus.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgCurStatus.StateCommon.Border.ColorAngle = 60.0!
        Me.kgCurStatus.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgCurStatus.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgCurStatus.StateCommon.Border.Rounding = 7
        Me.kgCurStatus.StateCommon.Border.Width = 2
        Me.kgCurStatus.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(687, 64)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Current File:"
        Me.lblStatus.Values.ExtraText = ""
        Me.lblStatus.Values.Image = Nothing
        Me.lblStatus.Values.Text = "Current File:"
        Me.lblStatus.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(5, 103)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 23)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Visible = False
        '
        'kgMain
        '
        Me.kgMain.Location = New System.Drawing.Point(2, 2)
        Me.kgMain.Name = "kgMain"
        '
        'kgMain.Panel
        '
        Me.kgMain.Panel.Controls.Add(Me.kscMyMain)
        Me.kgMain.Size = New System.Drawing.Size(728, 239)
        Me.kgMain.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgMain.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgMain.StateCommon.Border.ColorAngle = 60.0!
        Me.kgMain.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgMain.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgMain.StateCommon.Border.Rounding = 7
        Me.kgMain.StateCommon.Border.Width = 2
        Me.kgMain.TabIndex = 7
        '
        'bwStartSorting
        '
        Me.bwStartSorting.WorkerReportsProgress = True
        Me.bwStartSorting.WorkerSupportsCancellation = True
        '
        'kgCurStats
        '
        Me.kgCurStats.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgCurStats.Location = New System.Drawing.Point(2, 12)
        Me.kgCurStats.Name = "kgCurStats"
        '
        'kgCurStats.Panel
        '
        Me.kgCurStats.Panel.Controls.Add(Me.lblPleaseWait)
        Me.kgCurStats.Panel.Controls.Add(Me.ProgressBar1)
        Me.kgCurStats.Panel.Controls.Add(Me.kgCurStatus)
        Me.kgCurStats.Size = New System.Drawing.Size(724, 198)
        Me.kgCurStats.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgCurStats.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgCurStats.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgCurStats.StateCommon.Border.Rounding = 7
        Me.kgCurStats.StateCommon.Border.Width = 2
        Me.kgCurStats.TabIndex = 8
        Me.kgCurStats.Visible = False
        '
        'btnCancelWorker
        '
        Me.btnCancelWorker.Location = New System.Drawing.Point(260, 225)
        Me.btnCancelWorker.Name = "btnCancelWorker"
        Me.btnCancelWorker.Size = New System.Drawing.Size(206, 33)
        Me.btnCancelWorker.TabIndex = 9
        Me.btnCancelWorker.Text = "Cancel Sorting"
        Me.btnCancelWorker.Values.ExtraText = ""
        Me.btnCancelWorker.Values.Image = Nothing
        Me.btnCancelWorker.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelWorker.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelWorker.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelWorker.Values.Text = "Cancel Sorting"
        Me.btnCancelWorker.Visible = False
        '
        'lblReadingFolderData
        '
        Me.lblReadingFolderData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReadingFolderData.Location = New System.Drawing.Point(0, 0)
        Me.lblReadingFolderData.Name = "lblReadingFolderData"
        Me.lblReadingFolderData.Size = New System.Drawing.Size(728, 270)
        Me.lblReadingFolderData.TabIndex = 10
        Me.lblReadingFolderData.Text = resources.GetString("lblReadingFolderData.Text")
        Me.lblReadingFolderData.Values.ExtraText = ""
        Me.lblReadingFolderData.Values.Image = Nothing
        Me.lblReadingFolderData.Values.Text = resources.GetString("lblReadingFolderData.Values.Text")
        Me.lblReadingFolderData.Visible = False
        '
        'cbUse2digitTrackNums
        '
        Me.cbUse2digitTrackNums.Location = New System.Drawing.Point(216, 24)
        Me.cbUse2digitTrackNums.Name = "cbUse2digitTrackNums"
        Me.cbUse2digitTrackNums.Size = New System.Drawing.Size(302, 16)
        Me.cbUse2digitTrackNums.TabIndex = 20
        Me.cbUse2digitTrackNums.Text = "Use 2 Digit Track Numbers - Track 1 becomes Track 01"
        Me.cbUse2digitTrackNums.Values.ExtraText = ""
        Me.cbUse2digitTrackNums.Values.Image = Nothing
        Me.cbUse2digitTrackNums.Values.Text = "Use 2 Digit Track Numbers - Track 1 becomes Track 01"
        '
        'dlgMusicSortWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(728, 270)
        Me.Controls.Add(Me.btnCancelWorker)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.kgMain)
        Me.Controls.Add(Me.lblReadingFolderData)
        Me.Controls.Add(Me.kgCurStats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dlgMusicSortWizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Music Sorting Wizard"
        CType(Me.kgRenameMusicFileOptions.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgRenameMusicFileOptions.Panel.ResumeLayout(False)
        Me.kgRenameMusicFileOptions.Panel.PerformLayout()
        CType(Me.kgRenameMusicFileOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgRenameMusicFileOptions.ResumeLayout(False)
        CType(Me.kscMyMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMyMain.Panel1.ResumeLayout(False)
        Me.kscMyMain.Panel1.PerformLayout()
        CType(Me.kscMyMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kscMyMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMyMain.ResumeLayout(False)
        CType(Me.kgCurStatus.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgCurStatus.Panel.ResumeLayout(False)
        Me.kgCurStatus.Panel.PerformLayout()
        CType(Me.kgCurStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgCurStatus.ResumeLayout(False)
        CType(Me.kgMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMain.Panel.ResumeLayout(False)
        CType(Me.kgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMain.ResumeLayout(False)
        CType(Me.kgCurStats.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgCurStats.Panel.ResumeLayout(False)
        Me.kgCurStats.Panel.PerformLayout()
        CType(Me.kgCurStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgCurStats.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSrcMusicFolder As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbDstMusicFolder As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cbLowerCaseFileNames As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbRenameMusicFiles As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kgRenameMusicFileOptions As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lbFormatOfNewFileName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbUseUnderScoreForSpaces As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lbDelimiter As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbDelimiter As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblExampleFormat As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbDelim3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbDelim2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbDelim1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbFourth As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cbThird As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cbSecond As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cbFirst As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cbleaveunknownfilesalone As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kscMyMain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kgMain As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblPleaseWait As System.Windows.Forms.Label
    Friend WithEvents kgCurStatus As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lblStatus As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnStart As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents bwStartSorting As System.ComponentModel.BackgroundWorker
    Friend WithEvents kgCurStats As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnCancelWorker As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblReadingFolderData As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBrowseForDstFolder As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnBrowseSrc As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents fbdBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbUse2digitTrackNums As ComponentFactory.Krypton.Toolkit.KryptonCheckBox

End Class
