﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMovieGenreSelect
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
        Me.kgAllGenres = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lbAllGenre = New System.Windows.Forms.ListBox
        Me.kscMain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.kscRightMain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.klbl4dummies = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblSelected = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.klblAllGenres = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.kgButtons = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.kbtnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbtnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbtnRemoveAll = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbMyGenres = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lbSelectedGenre = New System.Windows.Forms.ListBox
        CType(Me.kgAllGenres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgAllGenres.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgAllGenres.Panel.SuspendLayout()
        Me.kgAllGenres.SuspendLayout()
        CType(Me.kscMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMain.Panel1.SuspendLayout()
        CType(Me.kscMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMain.Panel2.SuspendLayout()
        Me.kscMain.SuspendLayout()
        CType(Me.kscRightMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscRightMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscRightMain.Panel1.SuspendLayout()
        CType(Me.kscRightMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscRightMain.Panel2.SuspendLayout()
        Me.kscRightMain.SuspendLayout()
        CType(Me.kgButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgButtons.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgButtons.Panel.SuspendLayout()
        Me.kgButtons.SuspendLayout()
        CType(Me.kbMyGenres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kbMyGenres.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kbMyGenres.Panel.SuspendLayout()
        Me.kbMyGenres.SuspendLayout()
        Me.SuspendLayout()
        '
        'kgAllGenres
        '
        Me.kgAllGenres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgAllGenres.Location = New System.Drawing.Point(0, 0)
        Me.kgAllGenres.Name = "kgAllGenres"
        '
        'kgAllGenres.Panel
        '
        Me.kgAllGenres.Panel.Controls.Add(Me.lbAllGenre)
        Me.kgAllGenres.Size = New System.Drawing.Size(133, 414)
        Me.kgAllGenres.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgAllGenres.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgAllGenres.StateCommon.Border.ColorAngle = 60.0!
        Me.kgAllGenres.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgAllGenres.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgAllGenres.StateCommon.Border.Rounding = 7
        Me.kgAllGenres.StateCommon.Border.Width = 2
        Me.kgAllGenres.TabIndex = 1
        '
        'lbAllGenre
        '
        Me.lbAllGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbAllGenre.FormattingEnabled = True
        Me.lbAllGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Game-Show", "History", "Horror", "Music", "Musical", "Mystery", "News", "Reality-TV", "Romance", "Sci-Fi", "Short", "Sport", "Talk-Show", "Thriller", "War", "Western"})
        Me.lbAllGenre.Location = New System.Drawing.Point(0, 0)
        Me.lbAllGenre.Name = "lbAllGenre"
        Me.lbAllGenre.Size = New System.Drawing.Size(123, 394)
        Me.lbAllGenre.TabIndex = 0
        '
        'kscMain
        '
        Me.kscMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscMain.Location = New System.Drawing.Point(0, 0)
        Me.kscMain.Name = "kscMain"
        '
        'kscMain.Panel1
        '
        Me.kscMain.Panel1.Controls.Add(Me.kgAllGenres)
        '
        'kscMain.Panel2
        '
        Me.kscMain.Panel2.Controls.Add(Me.kscRightMain)
        Me.kscMain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kscMain.Size = New System.Drawing.Size(381, 414)
        Me.kscMain.SplitterDistance = 133
        Me.kscMain.SplitterWidth = 0
        Me.kscMain.TabIndex = 2
        '
        'kscRightMain
        '
        Me.kscRightMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscRightMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscRightMain.Location = New System.Drawing.Point(0, 0)
        Me.kscRightMain.Name = "kscRightMain"
        '
        'kscRightMain.Panel1
        '
        Me.kscRightMain.Panel1.Controls.Add(Me.klbl4dummies)
        Me.kscRightMain.Panel1.Controls.Add(Me.klblSelected)
        Me.kscRightMain.Panel1.Controls.Add(Me.klblAllGenres)
        Me.kscRightMain.Panel1.Controls.Add(Me.kgButtons)
        Me.kscRightMain.Panel1MinSize = 100
        '
        'kscRightMain.Panel2
        '
        Me.kscRightMain.Panel2.Controls.Add(Me.kbMyGenres)
        Me.kscRightMain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kscRightMain.Size = New System.Drawing.Size(248, 414)
        Me.kscRightMain.SplitterDistance = 102
        Me.kscRightMain.SplitterWidth = 0
        Me.kscRightMain.TabIndex = 3
        '
        'klbl4dummies
        '
        Me.klbl4dummies.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl4dummies.Location = New System.Drawing.Point(10, 85)
        Me.klbl4dummies.Name = "klbl4dummies"
        Me.klbl4dummies.Size = New System.Drawing.Size(91, 37)
        Me.klbl4dummies.TabIndex = 1
        Me.klbl4dummies.Text = "     Click To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add / Remove"
        Me.klbl4dummies.Values.ExtraText = ""
        Me.klbl4dummies.Values.Image = Nothing
        Me.klbl4dummies.Values.Text = "     Click To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add / Remove"
        '
        'klblSelected
        '
        Me.klblSelected.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblSelected.Location = New System.Drawing.Point(39, 32)
        Me.klblSelected.Name = "klblSelected"
        Me.klblSelected.Size = New System.Drawing.Size(76, 21)
        Me.klblSelected.TabIndex = 2
        Me.klblSelected.Text = "Selected ->"
        Me.klblSelected.Values.ExtraText = ""
        Me.klblSelected.Values.Image = Nothing
        Me.klblSelected.Values.Text = "Selected ->"
        '
        'klblAllGenres
        '
        Me.klblAllGenres.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klblAllGenres.Location = New System.Drawing.Point(0, 9)
        Me.klblAllGenres.Name = "klblAllGenres"
        Me.klblAllGenres.Size = New System.Drawing.Size(76, 21)
        Me.klblAllGenres.TabIndex = 1
        Me.klblAllGenres.Text = "<- Available"
        Me.klblAllGenres.Values.ExtraText = ""
        Me.klblAllGenres.Values.Image = Nothing
        Me.klblAllGenres.Values.Text = "<- Available"
        '
        'kgButtons
        '
        Me.kgButtons.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm
        Me.kgButtons.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonCustom1
        Me.kgButtons.Location = New System.Drawing.Point(0, 159)
        Me.kgButtons.Name = "kgButtons"
        '
        'kgButtons.Panel
        '
        Me.kgButtons.Panel.Controls.Add(Me.kbtnCancel)
        Me.kgButtons.Panel.Controls.Add(Me.kbtnOK)
        Me.kgButtons.Panel.Controls.Add(Me.kbtnRemoveAll)
        Me.kgButtons.Size = New System.Drawing.Size(100, 140)
        Me.kgButtons.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kgButtons.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kgButtons.StateCommon.Border.ColorAngle = 60.0!
        Me.kgButtons.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kgButtons.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kgButtons.StateCommon.Border.Rounding = 7
        Me.kgButtons.StateCommon.Border.Width = 3
        Me.kgButtons.TabIndex = 1
        '
        'kbtnCancel
        '
        Me.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kbtnCancel.Location = New System.Drawing.Point(1, 91)
        Me.kbtnCancel.Name = "kbtnCancel"
        Me.kbtnCancel.Size = New System.Drawing.Size(90, 41)
        Me.kbtnCancel.TabIndex = 7
        Me.kbtnCancel.Text = "Cancel"
        Me.kbtnCancel.Values.ExtraText = ""
        Me.kbtnCancel.Values.Image = Nothing
        Me.kbtnCancel.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbtnCancel.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbtnCancel.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbtnCancel.Values.Text = "Cancel"
        '
        'kbtnOK
        '
        Me.kbtnOK.Location = New System.Drawing.Point(1, 47)
        Me.kbtnOK.Name = "kbtnOK"
        Me.kbtnOK.Size = New System.Drawing.Size(90, 41)
        Me.kbtnOK.TabIndex = 6
        Me.kbtnOK.Text = "OK"
        Me.kbtnOK.Values.ExtraText = ""
        Me.kbtnOK.Values.Image = Nothing
        Me.kbtnOK.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbtnOK.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbtnOK.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbtnOK.Values.Text = "OK"
        '
        'kbtnRemoveAll
        '
        Me.kbtnRemoveAll.Location = New System.Drawing.Point(1, 3)
        Me.kbtnRemoveAll.Name = "kbtnRemoveAll"
        Me.kbtnRemoveAll.Size = New System.Drawing.Size(90, 41)
        Me.kbtnRemoveAll.TabIndex = 5
        Me.kbtnRemoveAll.Text = "Remove All"
        Me.kbtnRemoveAll.Values.ExtraText = ""
        Me.kbtnRemoveAll.Values.Image = Nothing
        Me.kbtnRemoveAll.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbtnRemoveAll.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbtnRemoveAll.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbtnRemoveAll.Values.Text = "Remove All"
        '
        'kbMyGenres
        '
        Me.kbMyGenres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kbMyGenres.Location = New System.Drawing.Point(0, 0)
        Me.kbMyGenres.Name = "kbMyGenres"
        '
        'kbMyGenres.Panel
        '
        Me.kbMyGenres.Panel.Controls.Add(Me.lbSelectedGenre)
        Me.kbMyGenres.Size = New System.Drawing.Size(146, 414)
        Me.kbMyGenres.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.kbMyGenres.StateCommon.Border.Color2 = System.Drawing.Color.Silver
        Me.kbMyGenres.StateCommon.Border.ColorAngle = 60.0!
        Me.kbMyGenres.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.kbMyGenres.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.kbMyGenres.StateCommon.Border.Rounding = 7
        Me.kbMyGenres.StateCommon.Border.Width = 2
        Me.kbMyGenres.TabIndex = 2
        '
        'lbSelectedGenre
        '
        Me.lbSelectedGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSelectedGenre.FormattingEnabled = True
        Me.lbSelectedGenre.Location = New System.Drawing.Point(0, 0)
        Me.lbSelectedGenre.Name = "lbSelectedGenre"
        Me.lbSelectedGenre.Size = New System.Drawing.Size(136, 394)
        Me.lbSelectedGenre.TabIndex = 0
        '
        'dlgMovieGenreSelect
        '
        Me.AcceptButton = Me.kbtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.kbtnCancel
        Me.ClientSize = New System.Drawing.Size(381, 414)
        Me.Controls.Add(Me.kscMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMovieGenreSelect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movie Genre Selection"
        CType(Me.kgAllGenres.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgAllGenres.Panel.ResumeLayout(False)
        CType(Me.kgAllGenres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgAllGenres.ResumeLayout(False)
        CType(Me.kscMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.Panel1.ResumeLayout(False)
        CType(Me.kscMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.Panel2.ResumeLayout(False)
        CType(Me.kscMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.ResumeLayout(False)
        CType(Me.kscRightMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscRightMain.Panel1.ResumeLayout(False)
        Me.kscRightMain.Panel1.PerformLayout()
        CType(Me.kscRightMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscRightMain.Panel2.ResumeLayout(False)
        CType(Me.kscRightMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscRightMain.ResumeLayout(False)
        CType(Me.kgButtons.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgButtons.Panel.ResumeLayout(False)
        CType(Me.kgButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgButtons.ResumeLayout(False)
        CType(Me.kbMyGenres.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kbMyGenres.Panel.ResumeLayout(False)
        CType(Me.kbMyGenres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kbMyGenres.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kgAllGenres As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lbAllGenre As System.Windows.Forms.ListBox
    Friend WithEvents kscMain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kscRightMain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kgButtons As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents kbMyGenres As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents lbSelectedGenre As System.Windows.Forms.ListBox
    Friend WithEvents kbtnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnRemoveAll As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents klbl4dummies As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblAllGenres As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblSelected As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
