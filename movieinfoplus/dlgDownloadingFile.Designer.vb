<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDownloadingFile
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
    'disables close
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDownloadingFile))
        Me.downloaderpbar = New System.Windows.Forms.ProgressBar
        Me.downloadertxtFileName = New System.Windows.Forms.TextBox
        Me.rtbLog = New System.Windows.Forms.RichTextBox
        Me.downloaderLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderbtngo = New System.Windows.Forms.Button
        Me.downloaderbtnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.downloaderlblSavingFileTo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSpeed = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileDownloading = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileSize = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblAmountDownloaded = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.bwDownloader = New System.ComponentModel.BackgroundWorker
        Me.bwmutlidownload = New System.ComponentModel.BackgroundWorker
        Me.downloaderlblFileDownloading2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSavingFileTo2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSpeed2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileSize2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloadertxtFileName2 = New System.Windows.Forms.TextBox
        Me.rtbLog2 = New System.Windows.Forms.RichTextBox
        Me.downloaderpbar2 = New System.Windows.Forms.ProgressBar
        Me.bwmutlidownload2 = New System.ComponentModel.BackgroundWorker
        Me.downloaderpbar3 = New System.Windows.Forms.ProgressBar
        Me.rtbLog3 = New System.Windows.Forms.RichTextBox
        Me.downloaderlblFileSize3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSpeed3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSavingFileTo3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileDownloading3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloadertxtFileName3 = New System.Windows.Forms.TextBox
        Me.downloaderpbar4 = New System.Windows.Forms.ProgressBar
        Me.rtbLog4 = New System.Windows.Forms.RichTextBox
        Me.downloaderlblFileSize4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSpeed4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSavingFileTo4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileDownloading4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloadertxtFileName4 = New System.Windows.Forms.TextBox
        Me.downloaderpbar5 = New System.Windows.Forms.ProgressBar
        Me.rtbLog5 = New System.Windows.Forms.RichTextBox
        Me.downloaderlblFileSize5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSpeed5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblSavingFileTo5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloaderlblFileDownloading5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.downloadertxtFileName5 = New System.Windows.Forms.TextBox
        Me.bwmutlidownload3 = New System.ComponentModel.BackgroundWorker
        Me.bwmutlidownload4 = New System.ComponentModel.BackgroundWorker
        Me.bwmutlidownload5 = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'downloaderpbar
        '
        Me.downloaderpbar.BackColor = System.Drawing.Color.MidnightBlue
        Me.downloaderpbar.ForeColor = System.Drawing.Color.Silver
        Me.downloaderpbar.Location = New System.Drawing.Point(51, 5)
        Me.downloaderpbar.MarqueeAnimationSpeed = 20
        Me.downloaderpbar.Name = "downloaderpbar"
        Me.downloaderpbar.Size = New System.Drawing.Size(604, 19)
        Me.downloaderpbar.TabIndex = 0
        '
        'downloadertxtFileName
        '
        Me.downloadertxtFileName.Location = New System.Drawing.Point(29, 32)
        Me.downloadertxtFileName.Name = "downloadertxtFileName"
        Me.downloadertxtFileName.Size = New System.Drawing.Size(626, 20)
        Me.downloadertxtFileName.TabIndex = 1
        Me.downloadertxtFileName.Visible = False
        '
        'rtbLog
        '
        Me.rtbLog.HideSelection = False
        Me.rtbLog.Location = New System.Drawing.Point(211, 615)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(652, 23)
        Me.rtbLog.TabIndex = 11
        Me.rtbLog.Text = ""
        Me.rtbLog.Visible = False
        '
        'downloaderLabel1
        '
        Me.downloaderLabel1.Location = New System.Drawing.Point(405, 61)
        Me.downloaderLabel1.Name = "downloaderLabel1"
        Me.downloaderLabel1.Size = New System.Drawing.Size(83, 16)
        Me.downloaderLabel1.TabIndex = 3
        Me.downloaderLabel1.Text = "KryptonLabel1"
        Me.downloaderLabel1.Values.ExtraText = ""
        Me.downloaderLabel1.Values.Image = Nothing
        Me.downloaderLabel1.Values.Text = "KryptonLabel1"
        Me.downloaderLabel1.Visible = False
        '
        'downloaderbtngo
        '
        Me.downloaderbtngo.Location = New System.Drawing.Point(494, 57)
        Me.downloaderbtngo.Name = "downloaderbtngo"
        Me.downloaderbtngo.Size = New System.Drawing.Size(75, 23)
        Me.downloaderbtngo.TabIndex = 9
        Me.downloaderbtngo.Text = "go"
        Me.downloaderbtngo.UseVisualStyleBackColor = True
        Me.downloaderbtngo.Visible = False
        '
        'downloaderbtnCancel
        '
        Me.downloaderbtnCancel.Location = New System.Drawing.Point(565, 57)
        Me.downloaderbtnCancel.Name = "downloaderbtnCancel"
        Me.downloaderbtnCancel.Size = New System.Drawing.Size(90, 25)
        Me.downloaderbtnCancel.TabIndex = 2
        Me.downloaderbtnCancel.Text = "Cancel"
        Me.downloaderbtnCancel.Values.ExtraText = ""
        Me.downloaderbtnCancel.Values.Image = Nothing
        Me.downloaderbtnCancel.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.downloaderbtnCancel.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.downloaderbtnCancel.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.downloaderbtnCancel.Values.Text = "Cancel"
        '
        'downloaderlblSavingFileTo
        '
        Me.downloaderlblSavingFileTo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSavingFileTo.Location = New System.Drawing.Point(29, 54)
        Me.downloaderlblSavingFileTo.Name = "downloaderlblSavingFileTo"
        Me.downloaderlblSavingFileTo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSavingFileTo.Size = New System.Drawing.Size(52, 16)
        Me.downloaderlblSavingFileTo.TabIndex = 8
        Me.downloaderlblSavingFileTo.Text = "Save to:"
        Me.downloaderlblSavingFileTo.Values.ExtraText = ""
        Me.downloaderlblSavingFileTo.Values.Image = Nothing
        Me.downloaderlblSavingFileTo.Values.Text = "Save to:"
        '
        'downloaderlblSpeed
        '
        Me.downloaderlblSpeed.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSpeed.Location = New System.Drawing.Point(29, 73)
        Me.downloaderlblSpeed.Name = "downloaderlblSpeed"
        Me.downloaderlblSpeed.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSpeed.Size = New System.Drawing.Size(43, 16)
        Me.downloaderlblSpeed.TabIndex = 4
        Me.downloaderlblSpeed.Text = "Speed"
        Me.downloaderlblSpeed.Values.ExtraText = ""
        Me.downloaderlblSpeed.Values.Image = Nothing
        Me.downloaderlblSpeed.Values.Text = "Speed"
        '
        'downloaderlblFileDownloading
        '
        Me.downloaderlblFileDownloading.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileDownloading.Location = New System.Drawing.Point(29, 35)
        Me.downloaderlblFileDownloading.Name = "downloaderlblFileDownloading"
        Me.downloaderlblFileDownloading.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileDownloading.Size = New System.Drawing.Size(79, 16)
        Me.downloaderlblFileDownloading.TabIndex = 7
        Me.downloaderlblFileDownloading.Text = "Downloading:"
        Me.downloaderlblFileDownloading.Values.ExtraText = ""
        Me.downloaderlblFileDownloading.Values.Image = Nothing
        Me.downloaderlblFileDownloading.Values.Text = "Downloading:"
        '
        'downloaderlblFileSize
        '
        Me.downloaderlblFileSize.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileSize.Location = New System.Drawing.Point(29, 77)
        Me.downloaderlblFileSize.Name = "downloaderlblFileSize"
        Me.downloaderlblFileSize.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileSize.Size = New System.Drawing.Size(57, 16)
        Me.downloaderlblFileSize.TabIndex = 5
        Me.downloaderlblFileSize.Text = "File Size:"
        Me.downloaderlblFileSize.Values.ExtraText = ""
        Me.downloaderlblFileSize.Values.Image = Nothing
        Me.downloaderlblFileSize.Values.Text = "File Size:"
        Me.downloaderlblFileSize.Visible = False
        '
        'downloaderlblAmountDownloaded
        '
        Me.downloaderlblAmountDownloaded.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblAmountDownloaded.Location = New System.Drawing.Point(12, 586)
        Me.downloaderlblAmountDownloaded.Name = "downloaderlblAmountDownloaded"
        Me.downloaderlblAmountDownloaded.Size = New System.Drawing.Size(84, 16)
        Me.downloaderlblAmountDownloaded.TabIndex = 6
        Me.downloaderlblAmountDownloaded.Text = "Downloaded --"
        Me.downloaderlblAmountDownloaded.Values.ExtraText = ""
        Me.downloaderlblAmountDownloaded.Values.Image = Nothing
        Me.downloaderlblAmountDownloaded.Values.Text = "Downloaded --"
        '
        'bwDownloader
        '
        Me.bwDownloader.WorkerReportsProgress = True
        Me.bwDownloader.WorkerSupportsCancellation = True
        '
        'bwmutlidownload
        '
        Me.bwmutlidownload.WorkerReportsProgress = True
        Me.bwmutlidownload.WorkerSupportsCancellation = True
        '
        'downloaderlblFileDownloading2
        '
        Me.downloaderlblFileDownloading2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileDownloading2.Location = New System.Drawing.Point(31, 132)
        Me.downloaderlblFileDownloading2.Name = "downloaderlblFileDownloading2"
        Me.downloaderlblFileDownloading2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileDownloading2.Size = New System.Drawing.Size(79, 16)
        Me.downloaderlblFileDownloading2.TabIndex = 12
        Me.downloaderlblFileDownloading2.Text = "Downloading:"
        Me.downloaderlblFileDownloading2.Values.ExtraText = ""
        Me.downloaderlblFileDownloading2.Values.Image = Nothing
        Me.downloaderlblFileDownloading2.Values.Text = "Downloading:"
        '
        'downloaderlblSavingFileTo2
        '
        Me.downloaderlblSavingFileTo2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSavingFileTo2.Location = New System.Drawing.Point(31, 149)
        Me.downloaderlblSavingFileTo2.Name = "downloaderlblSavingFileTo2"
        Me.downloaderlblSavingFileTo2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSavingFileTo2.Size = New System.Drawing.Size(52, 16)
        Me.downloaderlblSavingFileTo2.TabIndex = 13
        Me.downloaderlblSavingFileTo2.Text = "Save to:"
        Me.downloaderlblSavingFileTo2.Values.ExtraText = ""
        Me.downloaderlblSavingFileTo2.Values.Image = Nothing
        Me.downloaderlblSavingFileTo2.Values.Text = "Save to:"
        '
        'downloaderlblSpeed2
        '
        Me.downloaderlblSpeed2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSpeed2.Location = New System.Drawing.Point(31, 170)
        Me.downloaderlblSpeed2.Name = "downloaderlblSpeed2"
        Me.downloaderlblSpeed2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSpeed2.Size = New System.Drawing.Size(43, 16)
        Me.downloaderlblSpeed2.TabIndex = 14
        Me.downloaderlblSpeed2.Text = "Speed"
        Me.downloaderlblSpeed2.Values.ExtraText = ""
        Me.downloaderlblSpeed2.Values.Image = Nothing
        Me.downloaderlblSpeed2.Values.Text = "Speed"
        '
        'downloaderlblFileSize2
        '
        Me.downloaderlblFileSize2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileSize2.Location = New System.Drawing.Point(31, 171)
        Me.downloaderlblFileSize2.Name = "downloaderlblFileSize2"
        Me.downloaderlblFileSize2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileSize2.Size = New System.Drawing.Size(57, 16)
        Me.downloaderlblFileSize2.TabIndex = 15
        Me.downloaderlblFileSize2.Text = "File Size:"
        Me.downloaderlblFileSize2.Values.ExtraText = ""
        Me.downloaderlblFileSize2.Values.Image = Nothing
        Me.downloaderlblFileSize2.Values.Text = "File Size:"
        Me.downloaderlblFileSize2.Visible = False
        '
        'downloadertxtFileName2
        '
        Me.downloadertxtFileName2.Location = New System.Drawing.Point(36, 131)
        Me.downloadertxtFileName2.Name = "downloadertxtFileName2"
        Me.downloadertxtFileName2.Size = New System.Drawing.Size(626, 20)
        Me.downloadertxtFileName2.TabIndex = 16
        Me.downloadertxtFileName2.Visible = False
        '
        'rtbLog2
        '
        Me.rtbLog2.HideSelection = False
        Me.rtbLog2.Location = New System.Drawing.Point(299, 629)
        Me.rtbLog2.Name = "rtbLog2"
        Me.rtbLog2.Size = New System.Drawing.Size(652, 23)
        Me.rtbLog2.TabIndex = 17
        Me.rtbLog2.Text = ""
        Me.rtbLog2.Visible = False
        '
        'downloaderpbar2
        '
        Me.downloaderpbar2.BackColor = System.Drawing.Color.MidnightBlue
        Me.downloaderpbar2.ForeColor = System.Drawing.Color.Silver
        Me.downloaderpbar2.Location = New System.Drawing.Point(49, 104)
        Me.downloaderpbar2.MarqueeAnimationSpeed = 20
        Me.downloaderpbar2.Name = "downloaderpbar2"
        Me.downloaderpbar2.Size = New System.Drawing.Size(604, 17)
        Me.downloaderpbar2.TabIndex = 18
        '
        'bwmutlidownload2
        '
        Me.bwmutlidownload2.WorkerReportsProgress = True
        Me.bwmutlidownload2.WorkerSupportsCancellation = True
        '
        'downloaderpbar3
        '
        Me.downloaderpbar3.BackColor = System.Drawing.Color.MidnightBlue
        Me.downloaderpbar3.ForeColor = System.Drawing.Color.Silver
        Me.downloaderpbar3.Location = New System.Drawing.Point(49, 207)
        Me.downloaderpbar3.MarqueeAnimationSpeed = 20
        Me.downloaderpbar3.Name = "downloaderpbar3"
        Me.downloaderpbar3.Size = New System.Drawing.Size(604, 17)
        Me.downloaderpbar3.TabIndex = 25
        '
        'rtbLog3
        '
        Me.rtbLog3.HideSelection = False
        Me.rtbLog3.Location = New System.Drawing.Point(211, 586)
        Me.rtbLog3.Name = "rtbLog3"
        Me.rtbLog3.Size = New System.Drawing.Size(652, 23)
        Me.rtbLog3.TabIndex = 24
        Me.rtbLog3.Text = ""
        Me.rtbLog3.Visible = False
        '
        'downloaderlblFileSize3
        '
        Me.downloaderlblFileSize3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileSize3.Location = New System.Drawing.Point(28, 273)
        Me.downloaderlblFileSize3.Name = "downloaderlblFileSize3"
        Me.downloaderlblFileSize3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileSize3.Size = New System.Drawing.Size(57, 16)
        Me.downloaderlblFileSize3.TabIndex = 22
        Me.downloaderlblFileSize3.Text = "File Size:"
        Me.downloaderlblFileSize3.Values.ExtraText = ""
        Me.downloaderlblFileSize3.Values.Image = Nothing
        Me.downloaderlblFileSize3.Values.Text = "File Size:"
        Me.downloaderlblFileSize3.Visible = False
        '
        'downloaderlblSpeed3
        '
        Me.downloaderlblSpeed3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSpeed3.Location = New System.Drawing.Point(28, 271)
        Me.downloaderlblSpeed3.Name = "downloaderlblSpeed3"
        Me.downloaderlblSpeed3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSpeed3.Size = New System.Drawing.Size(43, 16)
        Me.downloaderlblSpeed3.TabIndex = 21
        Me.downloaderlblSpeed3.Text = "Speed"
        Me.downloaderlblSpeed3.Values.ExtraText = ""
        Me.downloaderlblSpeed3.Values.Image = Nothing
        Me.downloaderlblSpeed3.Values.Text = "Speed"
        '
        'downloaderlblSavingFileTo3
        '
        Me.downloaderlblSavingFileTo3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSavingFileTo3.Location = New System.Drawing.Point(28, 252)
        Me.downloaderlblSavingFileTo3.Name = "downloaderlblSavingFileTo3"
        Me.downloaderlblSavingFileTo3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSavingFileTo3.Size = New System.Drawing.Size(52, 16)
        Me.downloaderlblSavingFileTo3.TabIndex = 20
        Me.downloaderlblSavingFileTo3.Text = "Save to:"
        Me.downloaderlblSavingFileTo3.Values.ExtraText = ""
        Me.downloaderlblSavingFileTo3.Values.Image = Nothing
        Me.downloaderlblSavingFileTo3.Values.Text = "Save to:"
        '
        'downloaderlblFileDownloading3
        '
        Me.downloaderlblFileDownloading3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileDownloading3.Location = New System.Drawing.Point(28, 234)
        Me.downloaderlblFileDownloading3.Name = "downloaderlblFileDownloading3"
        Me.downloaderlblFileDownloading3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileDownloading3.Size = New System.Drawing.Size(79, 16)
        Me.downloaderlblFileDownloading3.TabIndex = 19
        Me.downloaderlblFileDownloading3.Text = "Downloading:"
        Me.downloaderlblFileDownloading3.Values.ExtraText = ""
        Me.downloaderlblFileDownloading3.Values.Image = Nothing
        Me.downloaderlblFileDownloading3.Values.Text = "Downloading:"
        '
        'downloadertxtFileName3
        '
        Me.downloadertxtFileName3.Location = New System.Drawing.Point(33, 234)
        Me.downloadertxtFileName3.Name = "downloadertxtFileName3"
        Me.downloadertxtFileName3.Size = New System.Drawing.Size(626, 20)
        Me.downloadertxtFileName3.TabIndex = 23
        Me.downloadertxtFileName3.Visible = False
        '
        'downloaderpbar4
        '
        Me.downloaderpbar4.BackColor = System.Drawing.Color.MidnightBlue
        Me.downloaderpbar4.ForeColor = System.Drawing.Color.Silver
        Me.downloaderpbar4.Location = New System.Drawing.Point(50, 310)
        Me.downloaderpbar4.MarqueeAnimationSpeed = 20
        Me.downloaderpbar4.Name = "downloaderpbar4"
        Me.downloaderpbar4.Size = New System.Drawing.Size(604, 17)
        Me.downloaderpbar4.TabIndex = 32
        '
        'rtbLog4
        '
        Me.rtbLog4.HideSelection = False
        Me.rtbLog4.Location = New System.Drawing.Point(17, 600)
        Me.rtbLog4.Name = "rtbLog4"
        Me.rtbLog4.Size = New System.Drawing.Size(652, 23)
        Me.rtbLog4.TabIndex = 31
        Me.rtbLog4.Text = ""
        Me.rtbLog4.Visible = False
        '
        'downloaderlblFileSize4
        '
        Me.downloaderlblFileSize4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileSize4.Location = New System.Drawing.Point(29, 377)
        Me.downloaderlblFileSize4.Name = "downloaderlblFileSize4"
        Me.downloaderlblFileSize4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileSize4.Size = New System.Drawing.Size(57, 16)
        Me.downloaderlblFileSize4.TabIndex = 29
        Me.downloaderlblFileSize4.Text = "File Size:"
        Me.downloaderlblFileSize4.Values.ExtraText = ""
        Me.downloaderlblFileSize4.Values.Image = Nothing
        Me.downloaderlblFileSize4.Values.Text = "File Size:"
        Me.downloaderlblFileSize4.Visible = False
        '
        'downloaderlblSpeed4
        '
        Me.downloaderlblSpeed4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSpeed4.Location = New System.Drawing.Point(29, 374)
        Me.downloaderlblSpeed4.Name = "downloaderlblSpeed4"
        Me.downloaderlblSpeed4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSpeed4.Size = New System.Drawing.Size(43, 16)
        Me.downloaderlblSpeed4.TabIndex = 28
        Me.downloaderlblSpeed4.Text = "Speed"
        Me.downloaderlblSpeed4.Values.ExtraText = ""
        Me.downloaderlblSpeed4.Values.Image = Nothing
        Me.downloaderlblSpeed4.Values.Text = "Speed"
        '
        'downloaderlblSavingFileTo4
        '
        Me.downloaderlblSavingFileTo4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSavingFileTo4.Location = New System.Drawing.Point(29, 356)
        Me.downloaderlblSavingFileTo4.Name = "downloaderlblSavingFileTo4"
        Me.downloaderlblSavingFileTo4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSavingFileTo4.Size = New System.Drawing.Size(52, 16)
        Me.downloaderlblSavingFileTo4.TabIndex = 27
        Me.downloaderlblSavingFileTo4.Text = "Save to:"
        Me.downloaderlblSavingFileTo4.Values.ExtraText = ""
        Me.downloaderlblSavingFileTo4.Values.Image = Nothing
        Me.downloaderlblSavingFileTo4.Values.Text = "Save to:"
        '
        'downloaderlblFileDownloading4
        '
        Me.downloaderlblFileDownloading4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileDownloading4.Location = New System.Drawing.Point(29, 337)
        Me.downloaderlblFileDownloading4.Name = "downloaderlblFileDownloading4"
        Me.downloaderlblFileDownloading4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileDownloading4.Size = New System.Drawing.Size(79, 16)
        Me.downloaderlblFileDownloading4.TabIndex = 26
        Me.downloaderlblFileDownloading4.Text = "Downloading:"
        Me.downloaderlblFileDownloading4.Values.ExtraText = ""
        Me.downloaderlblFileDownloading4.Values.Image = Nothing
        Me.downloaderlblFileDownloading4.Values.Text = "Downloading:"
        '
        'downloadertxtFileName4
        '
        Me.downloadertxtFileName4.Location = New System.Drawing.Point(34, 337)
        Me.downloadertxtFileName4.Name = "downloadertxtFileName4"
        Me.downloadertxtFileName4.Size = New System.Drawing.Size(626, 20)
        Me.downloadertxtFileName4.TabIndex = 30
        Me.downloadertxtFileName4.Visible = False
        '
        'downloaderpbar5
        '
        Me.downloaderpbar5.BackColor = System.Drawing.Color.MidnightBlue
        Me.downloaderpbar5.ForeColor = System.Drawing.Color.Silver
        Me.downloaderpbar5.Location = New System.Drawing.Point(49, 410)
        Me.downloaderpbar5.MarqueeAnimationSpeed = 20
        Me.downloaderpbar5.Name = "downloaderpbar5"
        Me.downloaderpbar5.Size = New System.Drawing.Size(604, 17)
        Me.downloaderpbar5.TabIndex = 39
        '
        'rtbLog5
        '
        Me.rtbLog5.HideSelection = False
        Me.rtbLog5.Location = New System.Drawing.Point(16, 629)
        Me.rtbLog5.Name = "rtbLog5"
        Me.rtbLog5.Size = New System.Drawing.Size(652, 23)
        Me.rtbLog5.TabIndex = 38
        Me.rtbLog5.Text = ""
        Me.rtbLog5.Visible = False
        '
        'downloaderlblFileSize5
        '
        Me.downloaderlblFileSize5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileSize5.Location = New System.Drawing.Point(31, 477)
        Me.downloaderlblFileSize5.Name = "downloaderlblFileSize5"
        Me.downloaderlblFileSize5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileSize5.Size = New System.Drawing.Size(57, 16)
        Me.downloaderlblFileSize5.TabIndex = 36
        Me.downloaderlblFileSize5.Text = "File Size:"
        Me.downloaderlblFileSize5.Values.ExtraText = ""
        Me.downloaderlblFileSize5.Values.Image = Nothing
        Me.downloaderlblFileSize5.Values.Text = "File Size:"
        Me.downloaderlblFileSize5.Visible = False
        '
        'downloaderlblSpeed5
        '
        Me.downloaderlblSpeed5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSpeed5.Location = New System.Drawing.Point(31, 474)
        Me.downloaderlblSpeed5.Name = "downloaderlblSpeed5"
        Me.downloaderlblSpeed5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSpeed5.Size = New System.Drawing.Size(43, 16)
        Me.downloaderlblSpeed5.TabIndex = 35
        Me.downloaderlblSpeed5.Text = "Speed"
        Me.downloaderlblSpeed5.Values.ExtraText = ""
        Me.downloaderlblSpeed5.Values.Image = Nothing
        Me.downloaderlblSpeed5.Values.Text = "Speed"
        '
        'downloaderlblSavingFileTo5
        '
        Me.downloaderlblSavingFileTo5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblSavingFileTo5.Location = New System.Drawing.Point(31, 456)
        Me.downloaderlblSavingFileTo5.Name = "downloaderlblSavingFileTo5"
        Me.downloaderlblSavingFileTo5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblSavingFileTo5.Size = New System.Drawing.Size(52, 16)
        Me.downloaderlblSavingFileTo5.TabIndex = 34
        Me.downloaderlblSavingFileTo5.Text = "Save to:"
        Me.downloaderlblSavingFileTo5.Values.ExtraText = ""
        Me.downloaderlblSavingFileTo5.Values.Image = Nothing
        Me.downloaderlblSavingFileTo5.Values.Text = "Save to:"
        '
        'downloaderlblFileDownloading5
        '
        Me.downloaderlblFileDownloading5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.downloaderlblFileDownloading5.Location = New System.Drawing.Point(31, 437)
        Me.downloaderlblFileDownloading5.Name = "downloaderlblFileDownloading5"
        Me.downloaderlblFileDownloading5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.downloaderlblFileDownloading5.Size = New System.Drawing.Size(79, 16)
        Me.downloaderlblFileDownloading5.TabIndex = 33
        Me.downloaderlblFileDownloading5.Text = "Downloading:"
        Me.downloaderlblFileDownloading5.Values.ExtraText = ""
        Me.downloaderlblFileDownloading5.Values.Image = Nothing
        Me.downloaderlblFileDownloading5.Values.Text = "Downloading:"
        '
        'downloadertxtFileName5
        '
        Me.downloadertxtFileName5.Location = New System.Drawing.Point(36, 437)
        Me.downloadertxtFileName5.Name = "downloadertxtFileName5"
        Me.downloadertxtFileName5.Size = New System.Drawing.Size(626, 20)
        Me.downloadertxtFileName5.TabIndex = 37
        Me.downloadertxtFileName5.Visible = False
        '
        'bwmutlidownload3
        '
        Me.bwmutlidownload3.WorkerReportsProgress = True
        Me.bwmutlidownload3.WorkerSupportsCancellation = True
        '
        'bwmutlidownload4
        '
        Me.bwmutlidownload4.WorkerReportsProgress = True
        Me.bwmutlidownload4.WorkerSupportsCancellation = True
        '
        'bwmutlidownload5
        '
        Me.bwmutlidownload5.WorkerReportsProgress = True
        Me.bwmutlidownload5.WorkerSupportsCancellation = True
        '
        'dlgDownloadingFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(690, 501)
        Me.Controls.Add(Me.downloaderpbar5)
        Me.Controls.Add(Me.rtbLog5)
        Me.Controls.Add(Me.downloaderlblSpeed5)
        Me.Controls.Add(Me.downloaderlblSavingFileTo5)
        Me.Controls.Add(Me.downloaderlblFileDownloading5)
        Me.Controls.Add(Me.downloadertxtFileName5)
        Me.Controls.Add(Me.downloaderpbar4)
        Me.Controls.Add(Me.rtbLog4)
        Me.Controls.Add(Me.downloaderlblSpeed4)
        Me.Controls.Add(Me.downloaderlblSavingFileTo4)
        Me.Controls.Add(Me.downloaderlblFileDownloading4)
        Me.Controls.Add(Me.downloadertxtFileName4)
        Me.Controls.Add(Me.downloaderpbar3)
        Me.Controls.Add(Me.rtbLog3)
        Me.Controls.Add(Me.downloaderlblSpeed3)
        Me.Controls.Add(Me.downloaderlblSavingFileTo3)
        Me.Controls.Add(Me.downloaderlblFileDownloading3)
        Me.Controls.Add(Me.downloadertxtFileName3)
        Me.Controls.Add(Me.downloaderpbar2)
        Me.Controls.Add(Me.rtbLog2)
        Me.Controls.Add(Me.downloaderlblSpeed2)
        Me.Controls.Add(Me.downloaderlblSavingFileTo2)
        Me.Controls.Add(Me.downloaderlblFileDownloading2)
        Me.Controls.Add(Me.downloaderLabel1)
        Me.Controls.Add(Me.downloaderbtngo)
        Me.Controls.Add(Me.rtbLog)
        Me.Controls.Add(Me.downloaderbtnCancel)
        Me.Controls.Add(Me.downloaderpbar)
        Me.Controls.Add(Me.downloaderlblFileDownloading)
        Me.Controls.Add(Me.downloaderlblAmountDownloaded)
        Me.Controls.Add(Me.downloadertxtFileName)
        Me.Controls.Add(Me.downloaderlblSpeed)
        Me.Controls.Add(Me.downloaderlblSavingFileTo)
        Me.Controls.Add(Me.downloadertxtFileName2)
        Me.Controls.Add(Me.downloaderlblFileSize5)
        Me.Controls.Add(Me.downloaderlblFileSize4)
        Me.Controls.Add(Me.downloaderlblFileSize3)
        Me.Controls.Add(Me.downloaderlblFileSize2)
        Me.Controls.Add(Me.downloaderlblFileSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "dlgDownloadingFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "File Download(s) In Progress (dl rev 36)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents downloaderpbar As System.Windows.Forms.ProgressBar
    Friend WithEvents downloadertxtFileName As System.Windows.Forms.TextBox
    Friend WithEvents downloaderlblSavingFileTo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileDownloading As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblAmountDownloaded As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileSize As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSpeed As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderbtnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents bwDownloader As System.ComponentModel.BackgroundWorker
    Friend WithEvents downloaderbtngo As System.Windows.Forms.Button
    Friend WithEvents bwmutlidownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents rtbLog As System.Windows.Forms.RichTextBox
    Friend WithEvents downloaderlblFileDownloading2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSavingFileTo2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSpeed2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileSize2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloadertxtFileName2 As System.Windows.Forms.TextBox
    Friend WithEvents rtbLog2 As System.Windows.Forms.RichTextBox
    Friend WithEvents downloaderpbar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents bwmutlidownload2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents downloaderpbar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents rtbLog3 As System.Windows.Forms.RichTextBox
    Friend WithEvents downloaderlblFileSize3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSpeed3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSavingFileTo3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileDownloading3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloadertxtFileName3 As System.Windows.Forms.TextBox
    Friend WithEvents downloaderpbar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents rtbLog4 As System.Windows.Forms.RichTextBox
    Friend WithEvents downloaderlblFileSize4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSpeed4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSavingFileTo4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileDownloading4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloadertxtFileName4 As System.Windows.Forms.TextBox
    Friend WithEvents downloaderpbar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents rtbLog5 As System.Windows.Forms.RichTextBox
    Friend WithEvents downloaderlblFileSize5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSpeed5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblSavingFileTo5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloaderlblFileDownloading5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents downloadertxtFileName5 As System.Windows.Forms.TextBox
    Friend WithEvents bwmutlidownload3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwmutlidownload4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwmutlidownload5 As System.ComponentModel.BackgroundWorker

End Class
