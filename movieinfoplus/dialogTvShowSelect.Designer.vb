<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogTvShowSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialogTvShowSelect))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.klbPickTheTvShow = New System.Windows.Forms.ListBox
        Me.klboverview = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.klblInformationlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klFirstAiredlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblImdbid = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirDaylbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbllang = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirTimelbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblRunTime = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblRunTimelbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirTime = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbllanglbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirDay = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblImdbidlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblFirstAired = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.klbltvCurShow = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbltvCurShowPath = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblgenerictext1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgPickCorrectShow = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblPickTheRightShow = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgPickCorrectShow.Panel.SuspendLayout()
        Me.kgPickCorrectShow.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(285, 389)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.White
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'klbPickTheTvShow
        '
        Me.klbPickTheTvShow.Location = New System.Drawing.Point(1, 28)
        Me.klbPickTheTvShow.Name = "klbPickTheTvShow"
        Me.klbPickTheTvShow.Size = New System.Drawing.Size(243, 368)
        Me.klbPickTheTvShow.TabIndex = 1
        '
        'klboverview
        '
        Me.klboverview.Location = New System.Drawing.Point(454, 243)
        Me.klboverview.Name = "klboverview"
        Me.klboverview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.klboverview.Size = New System.Drawing.Size(375, 174)
        Me.klboverview.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue
        Me.klboverview.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.klboverview.StateCommon.Border.ColorAngle = 220.0!
        Me.klboverview.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25
        Me.klboverview.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.klboverview.StateCommon.Border.Rounding = 10
        Me.klboverview.StateCommon.Border.Width = 3
        Me.klboverview.TabIndex = 2
        '
        'klblInformationlbl
        '
        Me.klblInformationlbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblInformationlbl.Location = New System.Drawing.Point(3, 3)
        Me.klblInformationlbl.Name = "klblInformationlbl"
        Me.klblInformationlbl.Size = New System.Drawing.Size(115, 21)
        Me.klblInformationlbl.TabIndex = 13
        Me.klblInformationlbl.Text = "Show Information"
        Me.klblInformationlbl.Values.ExtraText = ""
        Me.klblInformationlbl.Values.Image = Nothing
        Me.klblInformationlbl.Values.Text = "Show Information"
        '
        'klFirstAiredlbl
        '
        Me.klFirstAiredlbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klFirstAiredlbl.Location = New System.Drawing.Point(6, 24)
        Me.klFirstAiredlbl.Name = "klFirstAiredlbl"
        Me.klFirstAiredlbl.Size = New System.Drawing.Size(79, 21)
        Me.klFirstAiredlbl.TabIndex = 14
        Me.klFirstAiredlbl.Text = "First Aired:"
        Me.klFirstAiredlbl.Values.ExtraText = ""
        Me.klFirstAiredlbl.Values.Image = Nothing
        Me.klFirstAiredlbl.Values.Text = "First Aired:"
        '
        'klblImdbid
        '
        Me.klblImdbid.Location = New System.Drawing.Point(70, 105)
        Me.klblImdbid.Name = "klblImdbid"
        Me.klblImdbid.Size = New System.Drawing.Size(6, 2)
        Me.klblImdbid.TabIndex = 25
        Me.klblImdbid.Values.ExtraText = ""
        Me.klblImdbid.Values.Image = Nothing
        Me.klblImdbid.Values.Text = ""
        '
        'klblAirDaylbl
        '
        Me.klblAirDaylbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblAirDaylbl.Location = New System.Drawing.Point(6, 40)
        Me.klblAirDaylbl.Name = "klblAirDaylbl"
        Me.klblAirDaylbl.Size = New System.Drawing.Size(58, 21)
        Me.klblAirDaylbl.TabIndex = 15
        Me.klblAirDaylbl.Text = "Air Day:"
        Me.klblAirDaylbl.Values.ExtraText = ""
        Me.klblAirDaylbl.Values.Image = Nothing
        Me.klblAirDaylbl.Values.Text = "Air Day:"
        '
        'klbllang
        '
        Me.klbllang.Location = New System.Drawing.Point(70, 89)
        Me.klbllang.Name = "klbllang"
        Me.klbllang.Size = New System.Drawing.Size(6, 2)
        Me.klbllang.TabIndex = 24
        Me.klbllang.Values.ExtraText = ""
        Me.klbllang.Values.Image = Nothing
        Me.klbllang.Values.Text = ""
        '
        'klblAirTimelbl
        '
        Me.klblAirTimelbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblAirTimelbl.Location = New System.Drawing.Point(6, 56)
        Me.klblAirTimelbl.Name = "klblAirTimelbl"
        Me.klblAirTimelbl.Size = New System.Drawing.Size(65, 21)
        Me.klblAirTimelbl.TabIndex = 16
        Me.klblAirTimelbl.Text = "Air Time:"
        Me.klblAirTimelbl.Values.ExtraText = ""
        Me.klblAirTimelbl.Values.Image = Nothing
        Me.klblAirTimelbl.Values.Text = "Air Time:"
        '
        'klblRunTime
        '
        Me.klblRunTime.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblRunTime.Location = New System.Drawing.Point(70, 74)
        Me.klblRunTime.Name = "klblRunTime"
        Me.klblRunTime.Size = New System.Drawing.Size(50, 21)
        Me.klblRunTime.TabIndex = 23
        Me.klblRunTime.Text = "60 Min"
        Me.klblRunTime.Values.ExtraText = ""
        Me.klblRunTime.Values.Image = Nothing
        Me.klblRunTime.Values.Text = "60 Min"
        '
        'klblRunTimelbl
        '
        Me.klblRunTimelbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblRunTimelbl.Location = New System.Drawing.Point(6, 72)
        Me.klblRunTimelbl.Name = "klblRunTimelbl"
        Me.klblRunTimelbl.Size = New System.Drawing.Size(61, 21)
        Me.klblRunTimelbl.TabIndex = 17
        Me.klblRunTimelbl.Text = "Runtime:"
        Me.klblRunTimelbl.Values.ExtraText = ""
        Me.klblRunTimelbl.Values.Image = Nothing
        Me.klblRunTimelbl.Values.Text = "Runtime:"
        '
        'klblAirTime
        '
        Me.klblAirTime.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblAirTime.Location = New System.Drawing.Point(70, 58)
        Me.klblAirTime.Name = "klblAirTime"
        Me.klblAirTime.Size = New System.Drawing.Size(58, 21)
        Me.klblAirTime.TabIndex = 22
        Me.klblAirTime.Text = "9:00 PM"
        Me.klblAirTime.Values.ExtraText = ""
        Me.klblAirTime.Values.Image = Nothing
        Me.klblAirTime.Values.Text = "9:00 PM"
        '
        'klbllanglbl
        '
        Me.klbllanglbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbllanglbl.Location = New System.Drawing.Point(6, 87)
        Me.klbllanglbl.Name = "klbllanglbl"
        Me.klbllanglbl.Size = New System.Drawing.Size(66, 21)
        Me.klbllanglbl.TabIndex = 18
        Me.klbllanglbl.Text = "Language:"
        Me.klbllanglbl.Values.ExtraText = ""
        Me.klbllanglbl.Values.Image = Nothing
        Me.klbllanglbl.Values.Text = "Language:"
        '
        'klblAirDay
        '
        Me.klblAirDay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblAirDay.Location = New System.Drawing.Point(70, 42)
        Me.klblAirDay.Name = "klblAirDay"
        Me.klblAirDay.Size = New System.Drawing.Size(77, 21)
        Me.klblAirDay.TabIndex = 21
        Me.klblAirDay.Text = "Wednesday"
        Me.klblAirDay.Values.ExtraText = ""
        Me.klblAirDay.Values.Image = Nothing
        Me.klblAirDay.Values.Text = "Wednesday"
        '
        'klblImdbidlbl
        '
        Me.klblImdbidlbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblImdbidlbl.Location = New System.Drawing.Point(6, 103)
        Me.klblImdbidlbl.Name = "klblImdbidlbl"
        Me.klblImdbidlbl.Size = New System.Drawing.Size(64, 21)
        Me.klblImdbidlbl.TabIndex = 19
        Me.klblImdbidlbl.Text = "IMDBID:"
        Me.klblImdbidlbl.Values.ExtraText = ""
        Me.klblImdbidlbl.Values.Image = Nothing
        Me.klblImdbidlbl.Values.Text = "IMDBID:"
        '
        'klblFirstAired
        '
        Me.klblFirstAired.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblFirstAired.Location = New System.Drawing.Point(70, 26)
        Me.klblFirstAired.Name = "klblFirstAired"
        Me.klblFirstAired.Size = New System.Drawing.Size(121, 21)
        Me.klblFirstAired.TabIndex = 20
        Me.klblFirstAired.Text = "Month - Day - Year"
        Me.klblFirstAired.Values.ExtraText = ""
        Me.klblFirstAired.Values.Image = Nothing
        Me.klblFirstAired.Values.Text = "Month - Day - Year"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(262, 243)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblInformationlbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblFirstAired)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klFirstAiredlbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblImdbidlbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblImdbid)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblAirDay)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblAirDaylbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klbllanglbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klbllang)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblAirTime)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblAirTimelbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblRunTimelbl)
        Me.KryptonGroup1.Panel.Controls.Add(Me.klblRunTime)
        Me.KryptonGroup1.Size = New System.Drawing.Size(188, 145)
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue
        Me.KryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.KryptonGroup1.StateCommon.Border.ColorAngle = 220.0!
        Me.KryptonGroup1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Rounding = 10
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 26
        '
        'pbBanner
        '
        Me.pbBanner.ErrorImage = CType(resources.GetObject("pbBanner.ErrorImage"), System.Drawing.Image)
        Me.pbBanner.Location = New System.Drawing.Point(270, 113)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(555, 128)
        Me.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBanner.TabIndex = 27
        Me.pbBanner.TabStop = False
        '
        'klbltvCurShow
        '
        Me.klbltvCurShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.klbltvCurShow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.klbltvCurShow.Location = New System.Drawing.Point(0, 0)
        Me.klbltvCurShow.Name = "klbltvCurShow"
        Me.klbltvCurShow.Size = New System.Drawing.Size(545, 92)
        Me.klbltvCurShow.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShow.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShow.StateNormal.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShow.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShow.TabIndex = 28
        Me.klbltvCurShow.Text = "Current Show"
        Me.klbltvCurShow.Values.ExtraText = ""
        Me.klbltvCurShow.Values.Image = Nothing
        Me.klbltvCurShow.Values.Text = "Current Show"
        '
        'klbltvCurShowPath
        '
        Me.klbltvCurShowPath.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.klbltvCurShowPath.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbltvCurShowPath.Location = New System.Drawing.Point(0, 71)
        Me.klbltvCurShowPath.Name = "klbltvCurShowPath"
        Me.klbltvCurShowPath.Size = New System.Drawing.Size(545, 21)
        Me.klbltvCurShowPath.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShowPath.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbltvCurShowPath.TabIndex = 29
        Me.klbltvCurShowPath.Text = "Current Show Path"
        Me.klbltvCurShowPath.Values.ExtraText = ""
        Me.klbltvCurShowPath.Values.Image = Nothing
        Me.klbltvCurShowPath.Values.Text = "Current Show Path"
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Location = New System.Drawing.Point(268, 3)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblgenerictext1)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klbltvCurShowPath)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klbltvCurShow)
        Me.KryptonGroup2.Size = New System.Drawing.Size(557, 104)
        Me.KryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue
        Me.KryptonGroup2.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.KryptonGroup2.StateCommon.Border.ColorAngle = 220.0!
        Me.KryptonGroup2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear
        Me.KryptonGroup2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup2.StateCommon.Border.Rounding = 10
        Me.KryptonGroup2.StateCommon.Border.Width = 3
        Me.KryptonGroup2.TabIndex = 30
        '
        'klblgenerictext1
        '
        Me.klblgenerictext1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblgenerictext1.Location = New System.Drawing.Point(35, -2)
        Me.klblgenerictext1.Name = "klblgenerictext1"
        Me.klblgenerictext1.Size = New System.Drawing.Size(556, 37)
        Me.klblgenerictext1.TabIndex = 30
        Me.klblgenerictext1.Text = "More then 1 TV Show was found, pick the correct one and click OK, or cancel addin" & _
            "g this show." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                             You slected the following TV Show in " & _
            "the folder settings:"
        Me.klblgenerictext1.Values.ExtraText = ""
        Me.klblgenerictext1.Values.Image = Nothing
        Me.klblgenerictext1.Values.Text = "More then 1 TV Show was found, pick the correct one and click OK, or cancel addin" & _
            "g this show." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                             You slected the following TV Show in " & _
            "the folder settings:"
        '
        'kgPickCorrectShow
        '
        Me.kgPickCorrectShow.Location = New System.Drawing.Point(2, 2)
        Me.kgPickCorrectShow.Name = "kgPickCorrectShow"
        '
        'kgPickCorrectShow.Panel
        '
        Me.kgPickCorrectShow.Panel.Controls.Add(Me.klblPickTheRightShow)
        Me.kgPickCorrectShow.Panel.Controls.Add(Me.klbPickTheTvShow)
        Me.kgPickCorrectShow.Size = New System.Drawing.Size(257, 413)
        Me.kgPickCorrectShow.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.kgPickCorrectShow.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue
        Me.kgPickCorrectShow.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.kgPickCorrectShow.StateCommon.Border.ColorAngle = 220.0!
        Me.kgPickCorrectShow.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kgPickCorrectShow.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgPickCorrectShow.StateCommon.Border.Rounding = 10
        Me.kgPickCorrectShow.StateCommon.Border.Width = 3
        Me.kgPickCorrectShow.TabIndex = 31
        '
        'klblPickTheRightShow
        '
        Me.klblPickTheRightShow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblPickTheRightShow.Location = New System.Drawing.Point(11, 4)
        Me.klblPickTheRightShow.Name = "klblPickTheRightShow"
        Me.klblPickTheRightShow.Size = New System.Drawing.Size(160, 21)
        Me.klblPickTheRightShow.TabIndex = 31
        Me.klblPickTheRightShow.Text = "Pick the Correct TV Show"
        Me.klblPickTheRightShow.Values.ExtraText = ""
        Me.klblPickTheRightShow.Values.Image = Nothing
        Me.klblPickTheRightShow.Values.Text = "Pick the Correct TV Show"
        '
        'dialogTvShowSelect
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(832, 418)
        Me.Controls.Add(Me.kgPickCorrectShow)
        Me.Controls.Add(Me.KryptonGroup2)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Controls.Add(Me.klboverview)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialogTvShowSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More then 1 TV Show was found, pick the correct one or cancel adding this show"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.Panel.ResumeLayout(False)
        Me.kgPickCorrectShow.Panel.PerformLayout()
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents klbPickTheTvShow As System.Windows.Forms.ListBox 'ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents klboverview As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents klblInformationlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klFirstAiredlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblImdbid As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirDaylbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbllang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirTimelbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblRunTime As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblRunTimelbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirTime As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbllanglbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirDay As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblImdbidlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblFirstAired As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents klbltvCurShow As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbltvCurShowPath As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblgenerictext1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgPickCorrectShow As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblPickTheRightShow As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
