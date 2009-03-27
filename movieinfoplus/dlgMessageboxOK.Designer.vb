<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMessageboxOK
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kgdlgMain = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.message = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.kscmain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.kscTop = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.kgFiles = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgFiles = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TVShow = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.FileLocation = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.curfilename = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.newFileName = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.changeFileName = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn
        Me.season = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.Episode = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.Multipart = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
        Me.lblrescanrequired = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.kgdlgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgdlgMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgdlgMain.Panel.SuspendLayout()
        Me.kgdlgMain.SuspendLayout()
        CType(Me.kscmain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscmain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscmain.Panel1.SuspendLayout()
        CType(Me.kscmain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscmain.Panel2.SuspendLayout()
        Me.kscmain.SuspendLayout()
        CType(Me.kscTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscTop.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscTop.Panel1.SuspendLayout()
        CType(Me.kscTop.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscTop.Panel2.SuspendLayout()
        Me.kscTop.SuspendLayout()
        CType(Me.kgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgFiles.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgFiles.Panel.SuspendLayout()
        Me.kgFiles.SuspendLayout()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(397, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 41)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.Values.ExtraText = ""
        Me.btnOk.Values.Image = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOk.Values.Text = "OK"
        '
        'kgdlgMain
        '
        Me.kgdlgMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgdlgMain.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgdlgMain.Location = New System.Drawing.Point(0, 0)
        Me.kgdlgMain.Name = "kgdlgMain"
        '
        'kgdlgMain.Panel
        '
        Me.kgdlgMain.Panel.Controls.Add(Me.message)
        Me.kgdlgMain.Size = New System.Drawing.Size(942, 153)
        Me.kgdlgMain.TabIndex = 2
        '
        'message
        '
        Me.message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.message.Location = New System.Drawing.Point(0, 0)
        Me.message.Name = "message"
        Me.message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.message.Size = New System.Drawing.Size(930, 141)
        Me.message.TabIndex = 2
        '
        'kscmain
        '
        Me.kscmain.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kscmain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscmain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.kscmain.Location = New System.Drawing.Point(0, 0)
        Me.kscmain.Name = "kscmain"
        Me.kscmain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscmain.Panel1
        '
        Me.kscmain.Panel1.Controls.Add(Me.kscTop)
        '
        'kscmain.Panel2
        '
        Me.kscmain.Panel2.Controls.Add(Me.btnOk)
        Me.kscmain.Panel2.Controls.Add(Me.lblrescanrequired)
        Me.kscmain.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kscmain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kscmain.Size = New System.Drawing.Size(942, 538)
        Me.kscmain.SplitterDistance = 485
        Me.kscmain.TabIndex = 3
        '
        'kscTop
        '
        Me.kscTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.kscTop.Location = New System.Drawing.Point(0, 0)
        Me.kscTop.Name = "kscTop"
        Me.kscTop.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscTop.Panel1
        '
        Me.kscTop.Panel1.Controls.Add(Me.kgdlgMain)
        '
        'kscTop.Panel2
        '
        Me.kscTop.Panel2.Controls.Add(Me.kgFiles)
        Me.kscTop.Size = New System.Drawing.Size(942, 485)
        Me.kscTop.SplitterDistance = 153
        Me.kscTop.TabIndex = 5
        '
        'kgFiles
        '
        Me.kgFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgFiles.Location = New System.Drawing.Point(0, 0)
        Me.kgFiles.Name = "kgFiles"
        Me.kgFiles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        '
        'kgFiles.Panel
        '
        Me.kgFiles.Panel.Controls.Add(Me.dgFiles)
        Me.kgFiles.Size = New System.Drawing.Size(942, 327)
        Me.kgFiles.TabIndex = 4
        '
        'dgFiles
        '
        Me.dgFiles.AllowUserToAddRows = False
        Me.dgFiles.AllowUserToDeleteRows = False
        Me.dgFiles.AllowUserToResizeRows = False
        Me.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TVShow, Me.FileLocation, Me.curfilename, Me.newFileName, Me.changeFileName, Me.season, Me.Episode, Me.Multipart})
        Me.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFiles.Location = New System.Drawing.Point(0, 0)
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black
        Me.dgFiles.RowTemplate.Height = 30
        Me.dgFiles.Size = New System.Drawing.Size(940, 325)
        Me.dgFiles.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgFiles.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dgFiles.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.dgFiles.StateCommon.HeaderColumn.Border.Width = 0
        Me.dgFiles.StateCommon.HeaderRow.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dgFiles.StateCommon.HeaderRow.Border.Rounding = 0
        Me.dgFiles.StateCommon.HeaderRow.Border.Width = 0
        Me.dgFiles.TabIndex = 3
        '
        'TVShow
        '
        Me.TVShow.DividerWidth = 1
        Me.TVShow.FillWeight = 91.31092!
        Me.TVShow.HeaderText = "TV Show"
        Me.TVShow.Name = "TVShow"
        Me.TVShow.ReadOnly = True
        Me.TVShow.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FileLocation
        '
        Me.FileLocation.DividerWidth = 1
        Me.FileLocation.FillWeight = 82.18551!
        Me.FileLocation.HeaderText = "File Location"
        Me.FileLocation.Name = "FileLocation"
        Me.FileLocation.ReadOnly = True
        Me.FileLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FileLocation.ToolTipText = "Location"
        '
        'curfilename
        '
        Me.curfilename.DividerWidth = 1
        Me.curfilename.FillWeight = 91.31092!
        Me.curfilename.HeaderText = "Current File Name"
        Me.curfilename.Name = "curfilename"
        Me.curfilename.ReadOnly = True
        Me.curfilename.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'newFileName
        '
        Me.newFileName.DividerWidth = 1
        Me.newFileName.FillWeight = 91.31092!
        Me.newFileName.HeaderText = "New File Name"
        Me.newFileName.Name = "newFileName"
        Me.newFileName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'changeFileName
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.changeFileName.DefaultCellStyle = DataGridViewCellStyle1
        Me.changeFileName.DividerWidth = 1
        Me.changeFileName.FillWeight = 63.84085!
        Me.changeFileName.HeaderText = "Change"
        Me.changeFileName.MinimumWidth = 15
        Me.changeFileName.Name = "changeFileName"
        Me.changeFileName.Text = "Change"
        Me.changeFileName.UseColumnTextForButtonValue = True
        '
        'season
        '
        Me.season.DividerWidth = 1
        Me.season.FillWeight = 60.50197!
        Me.season.HeaderText = "Season"
        Me.season.MinimumWidth = 20
        Me.season.Name = "season"
        Me.season.ReadOnly = True
        Me.season.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Episode
        '
        Me.Episode.DividerWidth = 1
        Me.Episode.FillWeight = 71.1539!
        Me.Episode.HeaderText = "Episode(s)"
        Me.Episode.MinimumWidth = 25
        Me.Episode.Name = "Episode"
        Me.Episode.ReadOnly = True
        Me.Episode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Multipart
        '
        Me.Multipart.DividerWidth = 1
        Me.Multipart.FillWeight = 77.2174!
        Me.Multipart.HeaderText = "Multipart"
        Me.Multipart.MinimumWidth = 35
        Me.Multipart.Name = "Multipart"
        Me.Multipart.ReadOnly = True
        Me.Multipart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'lblrescanrequired
        '
        Me.lblrescanrequired.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblrescanrequired.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblrescanrequired.Location = New System.Drawing.Point(0, 0)
        Me.lblrescanrequired.Name = "lblrescanrequired"
        Me.lblrescanrequired.Size = New System.Drawing.Size(942, 48)
        Me.lblrescanrequired.TabIndex = 2
        Me.lblrescanrequired.Values.ExtraText = ""
        Me.lblrescanrequired.Values.Image = Nothing
        Me.lblrescanrequired.Values.Text = ""
        '
        'dlgMessageboxOK
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(942, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.kscmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgMessageboxOK"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TV Shows / Episodes that failed to be loaded"
        CType(Me.kgdlgMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgdlgMain.Panel.ResumeLayout(False)
        CType(Me.kgdlgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgdlgMain.ResumeLayout(False)
        CType(Me.kscmain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscmain.Panel1.ResumeLayout(False)
        CType(Me.kscmain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscmain.Panel2.ResumeLayout(False)
        Me.kscmain.Panel2.PerformLayout()
        CType(Me.kscmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscmain.ResumeLayout(False)
        CType(Me.kscTop.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscTop.Panel1.ResumeLayout(False)
        CType(Me.kscTop.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscTop.Panel2.ResumeLayout(False)
        CType(Me.kscTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscTop.ResumeLayout(False)
        CType(Me.kgFiles.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgFiles.Panel.ResumeLayout(False)
        CType(Me.kgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgFiles.ResumeLayout(False)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kgdlgMain As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents message As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents kscmain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kgFiles As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgFiles As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents kscTop As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents lblrescanrequired As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TVShow As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents FileLocation As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents curfilename As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents newFileName As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents changeFileName As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Friend WithEvents season As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents Episode As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents Multipart As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
