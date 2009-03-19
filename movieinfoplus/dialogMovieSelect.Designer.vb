<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogMovieSelect
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
        Me.kgPickCorrectShow = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klbPickTheMovie = New System.Windows.Forms.ListBox
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblgenerictext1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblCurMoviePath = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblCurMovie = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgMovieInfo = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.rtbplot = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.lblMovieInfoMpaa = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klboverview = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.lblMovieInfoYear = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoTrailerURL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoGenre = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoDirector = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoRating = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoVotes = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoTop250 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoRuntime = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoImdbID = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMovieInfoAltTitle = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.llIMDBIDStudio = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
        Me.tbStudio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.rtbTagline = New System.Windows.Forms.RichTextBox
        Me.tbOriginalTitle = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbVotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbTop250 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbMpaa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbyear = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbIMDBID = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbRuntime = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbRating = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbTrailer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbGenre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tbDirector = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.Label18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblInformationlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgImage = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblpbarLoadingInfo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.pbarLoadingInfo = New System.Windows.Forms.ProgressBar
        Me.pbPreviewImage = New System.Windows.Forms.PictureBox
        Me.KryptonGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.bwloadimage = New System.ComponentModel.BackgroundWorker
        Me.btnCancelLoad = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgPickCorrectShow.Panel.SuspendLayout()
        Me.kgPickCorrectShow.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.kgMovieInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgMovieInfo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgMovieInfo.Panel.SuspendLayout()
        Me.kgMovieInfo.SuspendLayout()
        CType(Me.kgImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgImage.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgImage.Panel.SuspendLayout()
        Me.kgImage.SuspendLayout()
        CType(Me.pbPreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup4.Panel.SuspendLayout()
        Me.KryptonGroup4.SuspendLayout()
        Me.SuspendLayout()
        '
        'kgPickCorrectShow
        '
        Me.kgPickCorrectShow.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgPickCorrectShow.Location = New System.Drawing.Point(12, 72)
        Me.kgPickCorrectShow.Name = "kgPickCorrectShow"
        '
        'kgPickCorrectShow.Panel
        '
        Me.kgPickCorrectShow.Panel.Controls.Add(Me.klbPickTheMovie)
        Me.kgPickCorrectShow.Size = New System.Drawing.Size(326, 461)
        Me.kgPickCorrectShow.TabIndex = 36
        '
        'klbPickTheMovie
        '
        Me.klbPickTheMovie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.klbPickTheMovie.Location = New System.Drawing.Point(0, 0)
        Me.klbPickTheMovie.Name = "klbPickTheMovie"
        Me.klbPickTheMovie.Size = New System.Drawing.Size(314, 446)
        Me.klbPickTheMovie.TabIndex = 1
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.KryptonGroup2.Location = New System.Drawing.Point(12, 0)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblgenerictext1)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblCurMoviePath)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblCurMovie)
        Me.KryptonGroup2.Size = New System.Drawing.Size(574, 72)
        Me.KryptonGroup2.TabIndex = 35
        '
        'klblgenerictext1
        '
        Me.klblgenerictext1.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblgenerictext1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblgenerictext1.Location = New System.Drawing.Point(0, 0)
        Me.klblgenerictext1.Name = "klblgenerictext1"
        Me.klblgenerictext1.Size = New System.Drawing.Size(562, 18)
        Me.klblgenerictext1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.klblgenerictext1.TabIndex = 30
        Me.klblgenerictext1.Text = "More then 1 Movie was found with that name, pick the correct one and click OK."
        Me.klblgenerictext1.Values.ExtraText = ""
        Me.klblgenerictext1.Values.Image = Nothing
        Me.klblgenerictext1.Values.Text = "More then 1 Movie was found with that name, pick the correct one and click OK."
        '
        'klblCurMoviePath
        '
        Me.klblCurMoviePath.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.klblCurMoviePath.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblCurMoviePath.Location = New System.Drawing.Point(0, 39)
        Me.klblCurMoviePath.Name = "klblCurMoviePath"
        Me.klblCurMoviePath.Size = New System.Drawing.Size(562, 21)
        Me.klblCurMoviePath.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMoviePath.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMoviePath.TabIndex = 29
        Me.klblCurMoviePath.Text = "Current Movie Path"
        Me.klblCurMoviePath.Values.ExtraText = ""
        Me.klblCurMoviePath.Values.Image = Nothing
        Me.klblCurMoviePath.Values.Text = "Current Movie Path"
        '
        'klblCurMovie
        '
        Me.klblCurMovie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.klblCurMovie.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblCurMovie.Location = New System.Drawing.Point(0, 0)
        Me.klblCurMovie.Name = "klblCurMovie"
        Me.klblCurMovie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klblCurMovie.Size = New System.Drawing.Size(562, 60)
        Me.klblCurMovie.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.klblCurMovie.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateNormal.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.TabIndex = 28
        Me.klblCurMovie.Text = "Current Movie"
        Me.klblCurMovie.Values.ExtraText = ""
        Me.klblCurMovie.Values.Image = Nothing
        Me.klblCurMovie.Values.Text = "Current Movie"
        '
        'kgMovieInfo
        '
        Me.kgMovieInfo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgMovieInfo.Location = New System.Drawing.Point(586, 3)
        Me.kgMovieInfo.Name = "kgMovieInfo"
        '
        'kgMovieInfo.Panel
        '
        Me.kgMovieInfo.Panel.Controls.Add(Me.rtbplot)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoMpaa)
        Me.kgMovieInfo.Panel.Controls.Add(Me.klboverview)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoYear)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoTrailerURL)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoGenre)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoDirector)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoRating)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoVotes)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoTop250)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoRuntime)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoImdbID)
        Me.kgMovieInfo.Panel.Controls.Add(Me.lblMovieInfoAltTitle)
        Me.kgMovieInfo.Panel.Controls.Add(Me.llIMDBIDStudio)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbStudio)
        Me.kgMovieInfo.Panel.Controls.Add(Me.rtbTagline)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbOriginalTitle)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbVotes)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbTop250)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbMpaa)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbyear)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbIMDBID)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbRuntime)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbRating)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbTrailer)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbGenre)
        Me.kgMovieInfo.Panel.Controls.Add(Me.tbDirector)
        Me.kgMovieInfo.Panel.Controls.Add(Me.Label18)
        Me.kgMovieInfo.Panel.Controls.Add(Me.klblInformationlbl)
        Me.kgMovieInfo.Size = New System.Drawing.Size(315, 533)
        Me.kgMovieInfo.TabIndex = 33
        '
        'rtbplot
        '
        Me.rtbplot.Location = New System.Drawing.Point(1, 351)
        Me.rtbplot.Name = "rtbplot"
        Me.rtbplot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.rtbplot.Size = New System.Drawing.Size(299, 167)
        Me.rtbplot.TabIndex = 0
        Me.rtbplot.Text = "Plot"
        '
        'lblMovieInfoMpaa
        '
        Me.lblMovieInfoMpaa.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoMpaa.Location = New System.Drawing.Point(96, 97)
        Me.lblMovieInfoMpaa.Name = "lblMovieInfoMpaa"
        Me.lblMovieInfoMpaa.Size = New System.Drawing.Size(45, 18)
        Me.lblMovieInfoMpaa.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoMpaa.TabIndex = 168
        Me.lblMovieInfoMpaa.Text = "Mpaa:"
        Me.lblMovieInfoMpaa.Values.ExtraText = ""
        Me.lblMovieInfoMpaa.Values.Image = Nothing
        Me.lblMovieInfoMpaa.Values.Text = "Mpaa:"
        '
        'klboverview
        '
        Me.klboverview.Location = New System.Drawing.Point(1, 286)
        Me.klboverview.Name = "klboverview"
        Me.klboverview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.klboverview.Size = New System.Drawing.Size(299, 63)
        Me.klboverview.TabIndex = 32
        '
        'lblMovieInfoYear
        '
        Me.lblMovieInfoYear.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoYear.Location = New System.Drawing.Point(3, 97)
        Me.lblMovieInfoYear.Name = "lblMovieInfoYear"
        Me.lblMovieInfoYear.Size = New System.Drawing.Size(40, 18)
        Me.lblMovieInfoYear.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoYear.TabIndex = 167
        Me.lblMovieInfoYear.Text = "Year:"
        Me.lblMovieInfoYear.Values.ExtraText = ""
        Me.lblMovieInfoYear.Values.Image = Nothing
        Me.lblMovieInfoYear.Values.Text = "Year:"
        '
        'lblMovieInfoTrailerURL
        '
        Me.lblMovieInfoTrailerURL.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoTrailerURL.Location = New System.Drawing.Point(3, 198)
        Me.lblMovieInfoTrailerURL.Name = "lblMovieInfoTrailerURL"
        Me.lblMovieInfoTrailerURL.Size = New System.Drawing.Size(77, 18)
        Me.lblMovieInfoTrailerURL.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoTrailerURL.TabIndex = 166
        Me.lblMovieInfoTrailerURL.Text = "Trailer URL:"
        Me.lblMovieInfoTrailerURL.Values.ExtraText = ""
        Me.lblMovieInfoTrailerURL.Values.Image = Nothing
        Me.lblMovieInfoTrailerURL.Values.Text = "Trailer URL:"
        '
        'lblMovieInfoGenre
        '
        Me.lblMovieInfoGenre.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoGenre.Location = New System.Drawing.Point(3, 173)
        Me.lblMovieInfoGenre.Name = "lblMovieInfoGenre"
        Me.lblMovieInfoGenre.Size = New System.Drawing.Size(48, 18)
        Me.lblMovieInfoGenre.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoGenre.TabIndex = 165
        Me.lblMovieInfoGenre.Text = "Genre:"
        Me.lblMovieInfoGenre.Values.ExtraText = ""
        Me.lblMovieInfoGenre.Values.Image = Nothing
        Me.lblMovieInfoGenre.Values.Text = "Genre:"
        '
        'lblMovieInfoDirector
        '
        Me.lblMovieInfoDirector.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoDirector.Location = New System.Drawing.Point(3, 148)
        Me.lblMovieInfoDirector.Name = "lblMovieInfoDirector"
        Me.lblMovieInfoDirector.Size = New System.Drawing.Size(57, 18)
        Me.lblMovieInfoDirector.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoDirector.TabIndex = 164
        Me.lblMovieInfoDirector.Text = "Director:"
        Me.lblMovieInfoDirector.Values.ExtraText = ""
        Me.lblMovieInfoDirector.Values.Image = Nothing
        Me.lblMovieInfoDirector.Values.Text = "Director:"
        '
        'lblMovieInfoRating
        '
        Me.lblMovieInfoRating.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoRating.Location = New System.Drawing.Point(215, 72)
        Me.lblMovieInfoRating.Name = "lblMovieInfoRating"
        Me.lblMovieInfoRating.Size = New System.Drawing.Size(46, 18)
        Me.lblMovieInfoRating.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoRating.TabIndex = 163
        Me.lblMovieInfoRating.Text = "Rating"
        Me.lblMovieInfoRating.Values.ExtraText = ""
        Me.lblMovieInfoRating.Values.Image = Nothing
        Me.lblMovieInfoRating.Values.Text = "Rating"
        '
        'lblMovieInfoVotes
        '
        Me.lblMovieInfoVotes.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoVotes.Location = New System.Drawing.Point(107, 72)
        Me.lblMovieInfoVotes.Name = "lblMovieInfoVotes"
        Me.lblMovieInfoVotes.Size = New System.Drawing.Size(46, 18)
        Me.lblMovieInfoVotes.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoVotes.TabIndex = 162
        Me.lblMovieInfoVotes.Text = "Votes:"
        Me.lblMovieInfoVotes.Values.ExtraText = ""
        Me.lblMovieInfoVotes.Values.Image = Nothing
        Me.lblMovieInfoVotes.Values.Text = "Votes:"
        '
        'lblMovieInfoTop250
        '
        Me.lblMovieInfoTop250.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoTop250.Location = New System.Drawing.Point(3, 72)
        Me.lblMovieInfoTop250.Name = "lblMovieInfoTop250"
        Me.lblMovieInfoTop250.Size = New System.Drawing.Size(56, 18)
        Me.lblMovieInfoTop250.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoTop250.TabIndex = 161
        Me.lblMovieInfoTop250.Text = "Top 250"
        Me.lblMovieInfoTop250.Values.ExtraText = ""
        Me.lblMovieInfoTop250.Values.Image = Nothing
        Me.lblMovieInfoTop250.Values.Text = "Top 250"
        '
        'lblMovieInfoRuntime
        '
        Me.lblMovieInfoRuntime.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoRuntime.Location = New System.Drawing.Point(160, 46)
        Me.lblMovieInfoRuntime.Name = "lblMovieInfoRuntime"
        Me.lblMovieInfoRuntime.Size = New System.Drawing.Size(60, 18)
        Me.lblMovieInfoRuntime.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoRuntime.TabIndex = 160
        Me.lblMovieInfoRuntime.Text = "Runtime:"
        Me.lblMovieInfoRuntime.Values.ExtraText = ""
        Me.lblMovieInfoRuntime.Values.Image = Nothing
        Me.lblMovieInfoRuntime.Values.Text = "Runtime:"
        '
        'lblMovieInfoImdbID
        '
        Me.lblMovieInfoImdbID.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoImdbID.Location = New System.Drawing.Point(3, 46)
        Me.lblMovieInfoImdbID.Name = "lblMovieInfoImdbID"
        Me.lblMovieInfoImdbID.Size = New System.Drawing.Size(60, 18)
        Me.lblMovieInfoImdbID.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoImdbID.TabIndex = 159
        Me.lblMovieInfoImdbID.Text = "IMDB ID:"
        Me.lblMovieInfoImdbID.Values.ExtraText = ""
        Me.lblMovieInfoImdbID.Values.Image = Nothing
        Me.lblMovieInfoImdbID.Values.Text = "IMDB ID:"
        '
        'lblMovieInfoAltTitle
        '
        Me.lblMovieInfoAltTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblMovieInfoAltTitle.Location = New System.Drawing.Point(3, 20)
        Me.lblMovieInfoAltTitle.Name = "lblMovieInfoAltTitle"
        Me.lblMovieInfoAltTitle.Size = New System.Drawing.Size(55, 18)
        Me.lblMovieInfoAltTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMovieInfoAltTitle.TabIndex = 158
        Me.lblMovieInfoAltTitle.Text = "Alt Title:"
        Me.lblMovieInfoAltTitle.Values.ExtraText = ""
        Me.lblMovieInfoAltTitle.Values.Image = Nothing
        Me.lblMovieInfoAltTitle.Values.Text = "Alt Title:"
        '
        'llIMDBIDStudio
        '
        Me.llIMDBIDStudio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llIMDBIDStudio.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.llIMDBIDStudio.Location = New System.Drawing.Point(3, 123)
        Me.llIMDBIDStudio.Name = "llIMDBIDStudio"
        Me.llIMDBIDStudio.Size = New System.Drawing.Size(52, 21)
        Me.llIMDBIDStudio.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.llIMDBIDStudio.TabIndex = 157
        Me.llIMDBIDStudio.Text = "Studio:"
        Me.llIMDBIDStudio.Values.ExtraText = ""
        Me.llIMDBIDStudio.Values.Image = Nothing
        Me.llIMDBIDStudio.Values.Text = "Studio:"
        '
        'tbStudio
        '
        Me.tbStudio.BackColor = System.Drawing.Color.Gainsboro
        Me.tbStudio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStudio.Location = New System.Drawing.Point(61, 123)
        Me.tbStudio.Name = "tbStudio"
        Me.tbStudio.Size = New System.Drawing.Size(234, 24)
        Me.tbStudio.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbStudio.StateCommon.Border.Rounding = 0
        Me.tbStudio.TabIndex = 151
        '
        'rtbTagline
        '
        Me.rtbTagline.BackColor = System.Drawing.Color.Gainsboro
        Me.rtbTagline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbTagline.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTagline.Location = New System.Drawing.Point(29, 224)
        Me.rtbTagline.Name = "rtbTagline"
        Me.rtbTagline.Size = New System.Drawing.Size(266, 60)
        Me.rtbTagline.TabIndex = 155
        Me.rtbTagline.Text = ""
        '
        'tbOriginalTitle
        '
        Me.tbOriginalTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.tbOriginalTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOriginalTitle.Location = New System.Drawing.Point(69, 21)
        Me.tbOriginalTitle.Name = "tbOriginalTitle"
        Me.tbOriginalTitle.Size = New System.Drawing.Size(226, 24)
        Me.tbOriginalTitle.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbOriginalTitle.StateCommon.Border.Rounding = 0
        Me.tbOriginalTitle.TabIndex = 143
        '
        'tbVotes
        '
        Me.tbVotes.BackColor = System.Drawing.Color.Gainsboro
        Me.tbVotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVotes.Location = New System.Drawing.Point(156, 72)
        Me.tbVotes.Name = "tbVotes"
        Me.tbVotes.Size = New System.Drawing.Size(56, 24)
        Me.tbVotes.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbVotes.StateCommon.Border.Rounding = 0
        Me.tbVotes.TabIndex = 147
        '
        'tbTop250
        '
        Me.tbTop250.BackColor = System.Drawing.Color.Gainsboro
        Me.tbTop250.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTop250.Location = New System.Drawing.Point(71, 72)
        Me.tbTop250.Name = "tbTop250"
        Me.tbTop250.Size = New System.Drawing.Size(29, 24)
        Me.tbTop250.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbTop250.StateCommon.Border.Rounding = 0
        Me.tbTop250.TabIndex = 146
        '
        'tbMpaa
        '
        Me.tbMpaa.BackColor = System.Drawing.Color.Gainsboro
        Me.tbMpaa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMpaa.Location = New System.Drawing.Point(143, 97)
        Me.tbMpaa.Name = "tbMpaa"
        Me.tbMpaa.Size = New System.Drawing.Size(152, 24)
        Me.tbMpaa.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbMpaa.StateCommon.Border.Rounding = 0
        Me.tbMpaa.TabIndex = 150
        '
        'tbyear
        '
        Me.tbyear.BackColor = System.Drawing.Color.Gainsboro
        Me.tbyear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbyear.Location = New System.Drawing.Point(47, 96)
        Me.tbyear.Name = "tbyear"
        Me.tbyear.Size = New System.Drawing.Size(46, 24)
        Me.tbyear.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbyear.StateCommon.Border.Rounding = 0
        Me.tbyear.TabIndex = 149
        '
        'tbIMDBID
        '
        Me.tbIMDBID.BackColor = System.Drawing.Color.Gainsboro
        Me.tbIMDBID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIMDBID.Location = New System.Drawing.Point(71, 46)
        Me.tbIMDBID.Name = "tbIMDBID"
        Me.tbIMDBID.Size = New System.Drawing.Size(83, 24)
        Me.tbIMDBID.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbIMDBID.StateCommon.Border.Rounding = 0
        Me.tbIMDBID.TabIndex = 144
        '
        'tbRuntime
        '
        Me.tbRuntime.BackColor = System.Drawing.Color.Gainsboro
        Me.tbRuntime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRuntime.Location = New System.Drawing.Point(221, 46)
        Me.tbRuntime.Name = "tbRuntime"
        Me.tbRuntime.Size = New System.Drawing.Size(74, 24)
        Me.tbRuntime.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbRuntime.StateCommon.Border.Rounding = 0
        Me.tbRuntime.TabIndex = 145
        '
        'tbRating
        '
        Me.tbRating.BackColor = System.Drawing.Color.Gainsboro
        Me.tbRating.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRating.Location = New System.Drawing.Point(268, 72)
        Me.tbRating.Name = "tbRating"
        Me.tbRating.Size = New System.Drawing.Size(26, 24)
        Me.tbRating.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbRating.StateCommon.Border.Rounding = 0
        Me.tbRating.TabIndex = 148
        '
        'tbTrailer
        '
        Me.tbTrailer.BackColor = System.Drawing.Color.Gainsboro
        Me.tbTrailer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTrailer.Location = New System.Drawing.Point(85, 198)
        Me.tbTrailer.Name = "tbTrailer"
        Me.tbTrailer.Size = New System.Drawing.Size(209, 24)
        Me.tbTrailer.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbTrailer.StateCommon.Border.Rounding = 0
        Me.tbTrailer.TabIndex = 154
        '
        'tbGenre
        '
        Me.tbGenre.BackColor = System.Drawing.Color.Gainsboro
        Me.tbGenre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGenre.Location = New System.Drawing.Point(64, 173)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(230, 24)
        Me.tbGenre.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbGenre.StateCommon.Border.Rounding = 0
        Me.tbGenre.TabIndex = 153
        '
        'tbDirector
        '
        Me.tbDirector.BackColor = System.Drawing.Color.Gainsboro
        Me.tbDirector.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDirector.Location = New System.Drawing.Point(71, 148)
        Me.tbDirector.Name = "tbDirector"
        Me.tbDirector.Size = New System.Drawing.Size(224, 24)
        Me.tbDirector.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.tbDirector.StateCommon.Border.Rounding = 0
        Me.tbDirector.TabIndex = 152
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.Label18.Location = New System.Drawing.Point(7, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.Label18.Size = New System.Drawing.Size(21, 56)
        Me.Label18.TabIndex = 156
        Me.Label18.Text = "Tagline:"
        Me.Label18.Values.ExtraText = ""
        Me.Label18.Values.Image = Nothing
        Me.Label18.Values.Text = "Tagline:"
        '
        'klblInformationlbl
        '
        Me.klblInformationlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.klblInformationlbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblInformationlbl.Location = New System.Drawing.Point(0, 0)
        Me.klblInformationlbl.Name = "klblInformationlbl"
        Me.klblInformationlbl.Size = New System.Drawing.Size(303, 21)
        Me.klblInformationlbl.TabIndex = 13
        Me.klblInformationlbl.Text = "Movie Information"
        Me.klblInformationlbl.Values.ExtraText = ""
        Me.klblInformationlbl.Values.Image = Nothing
        Me.klblInformationlbl.Values.Text = "Movie Information"
        '
        'kgImage
        '
        Me.kgImage.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgImage.Location = New System.Drawing.Point(338, 72)
        Me.kgImage.Name = "kgImage"
        '
        'kgImage.Panel
        '
        Me.kgImage.Panel.Controls.Add(Me.lblpbarLoadingInfo)
        Me.kgImage.Panel.Controls.Add(Me.pbPreviewImage)
        Me.kgImage.Size = New System.Drawing.Size(248, 354)
        Me.kgImage.TabIndex = 37
        '
        'lblpbarLoadingInfo
        '
        Me.lblpbarLoadingInfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblpbarLoadingInfo.Location = New System.Drawing.Point(26, 179)
        Me.lblpbarLoadingInfo.Name = "lblpbarLoadingInfo"
        Me.lblpbarLoadingInfo.Size = New System.Drawing.Size(176, 32)
        Me.lblpbarLoadingInfo.StateCommon.ShortText.Font = New System.Drawing.Font("Verdana", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblpbarLoadingInfo.TabIndex = 2
        Me.lblpbarLoadingInfo.Text = "Loading Info"
        Me.lblpbarLoadingInfo.Values.ExtraText = ""
        Me.lblpbarLoadingInfo.Values.Image = Nothing
        Me.lblpbarLoadingInfo.Values.Text = "Loading Info"
        Me.lblpbarLoadingInfo.Visible = False
        '
        'pbarLoadingInfo
        '
        Me.pbarLoadingInfo.Location = New System.Drawing.Point(3, 295)
        Me.pbarLoadingInfo.MarqueeAnimationSpeed = 40
        Me.pbarLoadingInfo.Name = "pbarLoadingInfo"
        Me.pbarLoadingInfo.Size = New System.Drawing.Size(898, 23)
        Me.pbarLoadingInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbarLoadingInfo.TabIndex = 1
        Me.pbarLoadingInfo.Visible = False
        '
        'pbPreviewImage
        '
        Me.pbPreviewImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPreviewImage.Location = New System.Drawing.Point(0, 0)
        Me.pbPreviewImage.Name = "pbPreviewImage"
        Me.pbPreviewImage.Size = New System.Drawing.Size(236, 342)
        Me.pbPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPreviewImage.TabIndex = 0
        Me.pbPreviewImage.TabStop = False
        '
        'KryptonGroup4
        '
        Me.KryptonGroup4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup4.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.KryptonGroup4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup4.Name = "KryptonGroup4"
        '
        'KryptonGroup4.Panel
        '
        Me.KryptonGroup4.Panel.Controls.Add(Me.btnCancelLoad)
        Me.KryptonGroup4.Panel.Controls.Add(Me.pbarLoadingInfo)
        Me.KryptonGroup4.Panel.Controls.Add(Me.btnCancel)
        Me.KryptonGroup4.Panel.Controls.Add(Me.btnOK)
        Me.KryptonGroup4.Panel.Controls.Add(Me.kgImage)
        Me.KryptonGroup4.Panel.Controls.Add(Me.kgMovieInfo)
        Me.KryptonGroup4.Panel.Controls.Add(Me.kgPickCorrectShow)
        Me.KryptonGroup4.Panel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonGroup4.Size = New System.Drawing.Size(914, 551)
        Me.KryptonGroup4.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(464, 448)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 55)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Values.ExtraText = ""
        Me.btnCancel.Values.Image = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(338, 449)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(123, 55)
        Me.btnOK.TabIndex = 38
        Me.btnOK.Text = "OK"
        Me.btnOK.Values.ExtraText = ""
        Me.btnOK.Values.Image = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOK.Values.Text = "OK"
        '
        'bwloadimage
        '
        '
        'btnCancelLoad
        '
        Me.btnCancelLoad.Location = New System.Drawing.Point(355, 446)
        Me.btnCancelLoad.Name = "btnCancelLoad"
        Me.btnCancelLoad.Size = New System.Drawing.Size(213, 57)
        Me.btnCancelLoad.TabIndex = 40
        Me.btnCancelLoad.Text = "Cancel Loading"
        Me.btnCancelLoad.Values.ExtraText = ""
        Me.btnCancelLoad.Values.Image = Nothing
        Me.btnCancelLoad.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelLoad.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelLoad.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelLoad.Values.Text = "Cancel Loading"
        Me.btnCancelLoad.Visible = False
        '
        'dialogMovieSelect
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 551)
        Me.Controls.Add(Me.KryptonGroup4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialogMovieSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More then movie was found in the search, pick the correct one or cancel adding th" & _
            "is Movie"
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.Panel.ResumeLayout(False)
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.kgMovieInfo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieInfo.Panel.ResumeLayout(False)
        Me.kgMovieInfo.Panel.PerformLayout()
        CType(Me.kgMovieInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgMovieInfo.ResumeLayout(False)
        CType(Me.kgImage.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgImage.Panel.ResumeLayout(False)
        Me.kgImage.Panel.PerformLayout()
        CType(Me.kgImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgImage.ResumeLayout(False)
        CType(Me.pbPreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kgPickCorrectShow As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klbPickTheMovie As System.Windows.Forms.ListBox
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblgenerictext1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblCurMoviePath As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblCurMovie As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgMovieInfo As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblInformationlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klboverview As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents lblMovieInfoMpaa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoYear As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoTrailerURL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoGenre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoDirector As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoRating As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoVotes As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoTop250 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoRuntime As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoImdbID As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMovieInfoAltTitle As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llIMDBIDStudio As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tbStudio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents rtbTagline As System.Windows.Forms.RichTextBox
    Friend WithEvents tbOriginalTitle As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbVotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbTop250 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbMpaa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbyear As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbIMDBID As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbRuntime As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbRating As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbTrailer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbGenre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tbDirector As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgImage As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rtbplot As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents KryptonGroup4 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents pbPreviewImage As System.Windows.Forms.PictureBox
    Friend WithEvents bwloadimage As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbarLoadingInfo As System.Windows.Forms.ProgressBar
    Friend WithEvents lblpbarLoadingInfo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelLoad As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
