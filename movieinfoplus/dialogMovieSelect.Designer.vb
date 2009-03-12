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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialogMovieSelect))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.kgPickCorrectShow = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblPickTheRightMovie = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbPickTheMovie = New System.Windows.Forms.ListBox
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblgenerictext1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblCurMoviePath = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblCurMovie = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.klblInformationlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblFirstAired = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klFirstAiredlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblImdbidlbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblImdbid = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirDay = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirDaylbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbllanglbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klbllang = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirTime = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAirTimelbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblRunTimelbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblRunTime = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klboverview = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgPickCorrectShow.Panel.SuspendLayout()
        Me.kgPickCorrectShow.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(674, 377)
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
        'kgPickCorrectShow
        '
        Me.kgPickCorrectShow.Location = New System.Drawing.Point(3, 2)
        Me.kgPickCorrectShow.Name = "kgPickCorrectShow"
        '
        'kgPickCorrectShow.Panel
        '
        Me.kgPickCorrectShow.Panel.Controls.Add(Me.klblPickTheRightMovie)
        Me.kgPickCorrectShow.Panel.Controls.Add(Me.klbPickTheMovie)
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
        Me.kgPickCorrectShow.TabIndex = 36
        '
        'klblPickTheRightMovie
        '
        Me.klblPickTheRightMovie.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.klblPickTheRightMovie.Location = New System.Drawing.Point(11, 4)
        Me.klblPickTheRightMovie.Name = "klblPickTheRightMovie"
        Me.klblPickTheRightMovie.Size = New System.Drawing.Size(220, 24)
        Me.klblPickTheRightMovie.TabIndex = 31
        Me.klblPickTheRightMovie.Text = "Pick the Correct TV Show"
        Me.klblPickTheRightMovie.Values.ExtraText = ""
        Me.klblPickTheRightMovie.Values.Image = Nothing
        Me.klblPickTheRightMovie.Values.Text = "Pick the Correct TV Show"
        '
        'klbPickTheMovie
        '
        Me.klbPickTheMovie.Location = New System.Drawing.Point(1, 28)
        Me.klbPickTheMovie.Name = "klbPickTheMovie"
        Me.klbPickTheMovie.Size = New System.Drawing.Size(243, 368)
        Me.klbPickTheMovie.TabIndex = 1
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Location = New System.Drawing.Point(269, 3)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblgenerictext1)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblCurMoviePath)
        Me.KryptonGroup2.Panel.Controls.Add(Me.klblCurMovie)
        Me.KryptonGroup2.Size = New System.Drawing.Size(557, 88)
        Me.KryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue
        Me.KryptonGroup2.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.KryptonGroup2.StateCommon.Border.ColorAngle = 220.0!
        Me.KryptonGroup2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear
        Me.KryptonGroup2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup2.StateCommon.Border.Rounding = 10
        Me.KryptonGroup2.StateCommon.Border.Width = 3
        Me.KryptonGroup2.TabIndex = 35
        '
        'klblgenerictext1
        '
        Me.klblgenerictext1.Location = New System.Drawing.Point(35, -2)
        Me.klblgenerictext1.Name = "klblgenerictext1"
        Me.klblgenerictext1.Size = New System.Drawing.Size(409, 29)
        Me.klblgenerictext1.TabIndex = 30
        Me.klblgenerictext1.Text = "More then 1 Movie was found with that name, pick the correct one and click OK." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & _
            "                            You slected the following Movie in the folder settin" & _
            "gs:"
        Me.klblgenerictext1.Values.ExtraText = ""
        Me.klblgenerictext1.Values.Image = Nothing
        Me.klblgenerictext1.Values.Text = "More then 1 Movie was found with that name, pick the correct one and click OK." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & _
            "                            You slected the following Movie in the folder settin" & _
            "gs:"
        '
        'klblCurMoviePath
        '
        Me.klblCurMoviePath.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.klblCurMoviePath.Location = New System.Drawing.Point(0, 60)
        Me.klblCurMoviePath.Name = "klblCurMoviePath"
        Me.klblCurMoviePath.Size = New System.Drawing.Size(545, 16)
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
        Me.klblCurMovie.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.klblCurMovie.Location = New System.Drawing.Point(0, 0)
        Me.klblCurMovie.Name = "klblCurMovie"
        Me.klblCurMovie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klblCurMovie.Size = New System.Drawing.Size(545, 76)
        Me.klblCurMovie.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateNormal.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klblCurMovie.TabIndex = 28
        Me.klblCurMovie.Text = "Current Movie"
        Me.klblCurMovie.Values.ExtraText = ""
        Me.klblCurMovie.Values.Image = Nothing
        Me.klblCurMovie.Values.Text = "Current Movie"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(263, 243)
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
        Me.KryptonGroup1.TabIndex = 33
        '
        'klblInformationlbl
        '
        Me.klblInformationlbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.klblInformationlbl.Location = New System.Drawing.Point(3, 3)
        Me.klblInformationlbl.Name = "klblInformationlbl"
        Me.klblInformationlbl.Size = New System.Drawing.Size(157, 24)
        Me.klblInformationlbl.TabIndex = 13
        Me.klblInformationlbl.Text = "Movie Information"
        Me.klblInformationlbl.Values.ExtraText = ""
        Me.klblInformationlbl.Values.Image = Nothing
        Me.klblInformationlbl.Values.Text = "Movie Information"
        '
        'klblFirstAired
        '
        Me.klblFirstAired.Location = New System.Drawing.Point(70, 26)
        Me.klblFirstAired.Name = "klblFirstAired"
        Me.klblFirstAired.Size = New System.Drawing.Size(105, 16)
        Me.klblFirstAired.TabIndex = 20
        Me.klblFirstAired.Text = "Month - Day - Year"
        Me.klblFirstAired.Values.ExtraText = ""
        Me.klblFirstAired.Values.Image = Nothing
        Me.klblFirstAired.Values.Text = "Month - Day - Year"
        '
        'klFirstAiredlbl
        '
        Me.klFirstAiredlbl.Location = New System.Drawing.Point(6, 24)
        Me.klFirstAiredlbl.Name = "klFirstAiredlbl"
        Me.klFirstAiredlbl.Size = New System.Drawing.Size(65, 16)
        Me.klFirstAiredlbl.TabIndex = 14
        Me.klFirstAiredlbl.Text = "First Aired:"
        Me.klFirstAiredlbl.Values.ExtraText = ""
        Me.klFirstAiredlbl.Values.Image = Nothing
        Me.klFirstAiredlbl.Values.Text = "First Aired:"
        '
        'klblImdbidlbl
        '
        Me.klblImdbidlbl.Location = New System.Drawing.Point(6, 103)
        Me.klblImdbidlbl.Name = "klblImdbidlbl"
        Me.klblImdbidlbl.Size = New System.Drawing.Size(53, 16)
        Me.klblImdbidlbl.TabIndex = 19
        Me.klblImdbidlbl.Text = "IMDBID:"
        Me.klblImdbidlbl.Values.ExtraText = ""
        Me.klblImdbidlbl.Values.Image = Nothing
        Me.klblImdbidlbl.Values.Text = "IMDBID:"
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
        'klblAirDay
        '
        Me.klblAirDay.Location = New System.Drawing.Point(70, 42)
        Me.klblAirDay.Name = "klblAirDay"
        Me.klblAirDay.Size = New System.Drawing.Size(70, 16)
        Me.klblAirDay.TabIndex = 21
        Me.klblAirDay.Text = "Wednesday"
        Me.klblAirDay.Values.ExtraText = ""
        Me.klblAirDay.Values.Image = Nothing
        Me.klblAirDay.Values.Text = "Wednesday"
        '
        'klblAirDaylbl
        '
        Me.klblAirDaylbl.Location = New System.Drawing.Point(6, 40)
        Me.klblAirDaylbl.Name = "klblAirDaylbl"
        Me.klblAirDaylbl.Size = New System.Drawing.Size(50, 16)
        Me.klblAirDaylbl.TabIndex = 15
        Me.klblAirDaylbl.Text = "Air Day:"
        Me.klblAirDaylbl.Values.ExtraText = ""
        Me.klblAirDaylbl.Values.Image = Nothing
        Me.klblAirDaylbl.Values.Text = "Air Day:"
        '
        'klbllanglbl
        '
        Me.klbllanglbl.Location = New System.Drawing.Point(6, 87)
        Me.klbllanglbl.Name = "klbllanglbl"
        Me.klbllanglbl.Size = New System.Drawing.Size(64, 16)
        Me.klbllanglbl.TabIndex = 18
        Me.klbllanglbl.Text = "Language:"
        Me.klbllanglbl.Values.ExtraText = ""
        Me.klbllanglbl.Values.Image = Nothing
        Me.klbllanglbl.Values.Text = "Language:"
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
        'klblAirTime
        '
        Me.klblAirTime.Location = New System.Drawing.Point(70, 58)
        Me.klblAirTime.Name = "klblAirTime"
        Me.klblAirTime.Size = New System.Drawing.Size(52, 16)
        Me.klblAirTime.TabIndex = 22
        Me.klblAirTime.Text = "9:00 PM"
        Me.klblAirTime.Values.ExtraText = ""
        Me.klblAirTime.Values.Image = Nothing
        Me.klblAirTime.Values.Text = "9:00 PM"
        '
        'klblAirTimelbl
        '
        Me.klblAirTimelbl.Location = New System.Drawing.Point(6, 56)
        Me.klblAirTimelbl.Name = "klblAirTimelbl"
        Me.klblAirTimelbl.Size = New System.Drawing.Size(55, 16)
        Me.klblAirTimelbl.TabIndex = 16
        Me.klblAirTimelbl.Text = "Air Time:"
        Me.klblAirTimelbl.Values.ExtraText = ""
        Me.klblAirTimelbl.Values.Image = Nothing
        Me.klblAirTimelbl.Values.Text = "Air Time:"
        '
        'klblRunTimelbl
        '
        Me.klblRunTimelbl.Location = New System.Drawing.Point(6, 72)
        Me.klblRunTimelbl.Name = "klblRunTimelbl"
        Me.klblRunTimelbl.Size = New System.Drawing.Size(56, 16)
        Me.klblRunTimelbl.TabIndex = 17
        Me.klblRunTimelbl.Text = "Runtime:"
        Me.klblRunTimelbl.Values.ExtraText = ""
        Me.klblRunTimelbl.Values.Image = Nothing
        Me.klblRunTimelbl.Values.Text = "Runtime:"
        '
        'klblRunTime
        '
        Me.klblRunTime.Location = New System.Drawing.Point(70, 74)
        Me.klblRunTime.Name = "klblRunTime"
        Me.klblRunTime.Size = New System.Drawing.Size(44, 16)
        Me.klblRunTime.TabIndex = 23
        Me.klblRunTime.Text = "60 Min"
        Me.klblRunTime.Values.ExtraText = ""
        Me.klblRunTime.Values.Image = Nothing
        Me.klblRunTime.Values.Text = "60 Min"
        '
        'klboverview
        '
        Me.klboverview.Location = New System.Drawing.Point(455, 243)
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
        Me.klboverview.TabIndex = 32
        '
        'pbBanner
        '
        Me.pbBanner.ErrorImage = CType(resources.GetObject("pbBanner.ErrorImage"), System.Drawing.Image)
        Me.pbBanner.Location = New System.Drawing.Point(271, 89)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(555, 152)
        Me.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBanner.TabIndex = 34
        Me.pbBanner.TabStop = False
        '
        'dialogMovieSelect
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "dialogMovieSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More then movie was found in the search, pick the correct one or cancel adding th" & _
            "is Movie"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.kgPickCorrectShow.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.Panel.ResumeLayout(False)
        Me.kgPickCorrectShow.Panel.PerformLayout()
        CType(Me.kgPickCorrectShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgPickCorrectShow.ResumeLayout(False)
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
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents kgPickCorrectShow As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblPickTheRightMovie As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbPickTheMovie As System.Windows.Forms.ListBox
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblgenerictext1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblCurMoviePath As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblCurMovie As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents klblInformationlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblFirstAired As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klFirstAiredlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblImdbidlbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblImdbid As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirDay As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirDaylbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbllanglbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbllang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirTime As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAirTimelbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblRunTimelbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblRunTime As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klboverview As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox

End Class
