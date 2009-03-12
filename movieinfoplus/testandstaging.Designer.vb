<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testandstaging
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
        Me.khbTVShowEPMediaGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.buttonSpecHeaderGroupTVShow = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.kpMovieMediaInfoPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.pbarLoadingTVShowMediaInfo = New System.Windows.Forms.ProgressBar
        Me.lblpbarLoadingTVShowMediaInfo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.krtbTVShowMediaInfo = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        CType(Me.khbTVShowEPMediaGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khbTVShowEPMediaGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khbTVShowEPMediaGroup.Panel.SuspendLayout()
        Me.khbTVShowEPMediaGroup.SuspendLayout()
        CType(Me.kpMovieMediaInfoPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpMovieMediaInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'khbTVShowEPMediaGroup
        '
        Me.khbTVShowEPMediaGroup.AutoSize = True
        Me.khbTVShowEPMediaGroup.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.buttonSpecHeaderGroupTVShow})
        Me.khbTVShowEPMediaGroup.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.khbTVShowEPMediaGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Custom1
        Me.khbTVShowEPMediaGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Custom1
        Me.khbTVShowEPMediaGroup.Location = New System.Drawing.Point(548, 123)
        Me.khbTVShowEPMediaGroup.Name = "khbTVShowEPMediaGroup"
        '
        'khbTVShowEPMediaGroup.Panel
        '
        Me.khbTVShowEPMediaGroup.Panel.Controls.Add(Me.kpMovieMediaInfoPanel)
        Me.khbTVShowEPMediaGroup.Panel.Padding = New System.Windows.Forms.Padding(2)
        Me.khbTVShowEPMediaGroup.Size = New System.Drawing.Size(284, 307)
        Me.khbTVShowEPMediaGroup.TabIndex = 113
        Me.khbTVShowEPMediaGroup.Text = "Episode Media Information"
        Me.khbTVShowEPMediaGroup.ValuesPrimary.Description = ""
        Me.khbTVShowEPMediaGroup.ValuesPrimary.Heading = "Episode Media Information"
        Me.khbTVShowEPMediaGroup.ValuesPrimary.Image = Nothing
        Me.khbTVShowEPMediaGroup.ValuesSecondary.Description = ""
        Me.khbTVShowEPMediaGroup.ValuesSecondary.Heading = "Description"
        Me.khbTVShowEPMediaGroup.ValuesSecondary.Image = Nothing
        '
        'buttonSpecHeaderGroupTVShow
        '
        Me.buttonSpecHeaderGroupTVShow.ExtraText = ""
        Me.buttonSpecHeaderGroupTVShow.Image = Nothing
        Me.buttonSpecHeaderGroupTVShow.Text = ""
        Me.buttonSpecHeaderGroupTVShow.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.buttonSpecHeaderGroupTVShow.UniqueName = "4A14906157B94C7D4A14906157B94C7D"
        '
        'kpMovieMediaInfoPanel
        '
        Me.kpMovieMediaInfoPanel.Controls.Add(Me.pbarLoadingTVShowMediaInfo)
        Me.kpMovieMediaInfoPanel.Controls.Add(Me.lblpbarLoadingTVShowMediaInfo)
        Me.kpMovieMediaInfoPanel.Controls.Add(Me.krtbTVShowMediaInfo)
        Me.kpMovieMediaInfoPanel.Location = New System.Drawing.Point(5, 2)
        Me.kpMovieMediaInfoPanel.Name = "kpMovieMediaInfoPanel"
        Me.kpMovieMediaInfoPanel.Size = New System.Drawing.Size(274, 240)
        Me.kpMovieMediaInfoPanel.TabIndex = 114
        '
        'pbarLoadingTVShowMediaInfo
        '
        Me.pbarLoadingTVShowMediaInfo.Location = New System.Drawing.Point(1, 115)
        Me.pbarLoadingTVShowMediaInfo.MarqueeAnimationSpeed = 50
        Me.pbarLoadingTVShowMediaInfo.Name = "pbarLoadingTVShowMediaInfo"
        Me.pbarLoadingTVShowMediaInfo.Size = New System.Drawing.Size(270, 18)
        Me.pbarLoadingTVShowMediaInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbarLoadingTVShowMediaInfo.TabIndex = 1
        Me.pbarLoadingTVShowMediaInfo.Visible = False
        '
        'lblpbarLoadingTVShowMediaInfo
        '
        Me.lblpbarLoadingTVShowMediaInfo.Location = New System.Drawing.Point(57, 91)
        Me.lblpbarLoadingTVShowMediaInfo.Name = "lblpbarLoadingTVShowMediaInfo"
        Me.lblpbarLoadingTVShowMediaInfo.Size = New System.Drawing.Size(160, 16)
        Me.lblpbarLoadingTVShowMediaInfo.TabIndex = 2
        Me.lblpbarLoadingTVShowMediaInfo.Text = "Loading Media Information .... "
        Me.lblpbarLoadingTVShowMediaInfo.Values.ExtraText = ""
        Me.lblpbarLoadingTVShowMediaInfo.Values.Image = Nothing
        Me.lblpbarLoadingTVShowMediaInfo.Values.Text = "Loading Media Information .... "
        Me.lblpbarLoadingTVShowMediaInfo.Visible = False
        '
        'krtbTVShowMediaInfo
        '
        Me.krtbTVShowMediaInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.krtbTVShowMediaInfo.Location = New System.Drawing.Point(0, 0)
        Me.krtbTVShowMediaInfo.Name = "krtbTVShowMediaInfo"
        Me.krtbTVShowMediaInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.krtbTVShowMediaInfo.Size = New System.Drawing.Size(274, 240)
        Me.krtbTVShowMediaInfo.TabIndex = 0
        '
        'testandstaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 616)
        Me.Controls.Add(Me.khbTVShowEPMediaGroup)
        Me.Name = "testandstaging"
        Me.Text = "testandstaging"
        CType(Me.khbTVShowEPMediaGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khbTVShowEPMediaGroup.Panel.ResumeLayout(False)
        CType(Me.khbTVShowEPMediaGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khbTVShowEPMediaGroup.ResumeLayout(False)
        CType(Me.kpMovieMediaInfoPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpMovieMediaInfoPanel.ResumeLayout(False)
        Me.kpMovieMediaInfoPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents khbTVShowEPMediaGroup As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents buttonSpecHeaderGroupTVShow As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents kpMovieMediaInfoPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents pbarLoadingTVShowMediaInfo As System.Windows.Forms.ProgressBar
    Friend WithEvents lblpbarLoadingTVShowMediaInfo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents krtbTVShowMediaInfo As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
End Class
