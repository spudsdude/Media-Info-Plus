<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARD
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnStartARD = New System.Windows.Forms.Button
        Me.btnCancelARD = New System.Windows.Forms.Button
        Me.pbar1ARD = New System.Windows.Forms.ProgressBar
        Me.kpMovieData = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.header2Border = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.header2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.buttonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.header1Border = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.header1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.header1ButtonSpec = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.kryptonButtonPrevious = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.textBoxFind = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.kryptonButtonNext = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.labelFind = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.kpMovieData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpMovieData.SuspendLayout()
        CType(Me.header2Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header2.SuspendLayout()
        CType(Me.header1Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header1.Panel.SuspendLayout()
        Me.header1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnStartARD, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelARD, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(671, 569)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnStartARD
        '
        Me.btnStartARD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStartARD.Location = New System.Drawing.Point(3, 3)
        Me.btnStartARD.Name = "btnStartARD"
        Me.btnStartARD.Size = New System.Drawing.Size(67, 23)
        Me.btnStartARD.TabIndex = 0
        Me.btnStartARD.Text = "Start"
        '
        'btnCancelARD
        '
        Me.btnCancelARD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelARD.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelARD.Location = New System.Drawing.Point(76, 3)
        Me.btnCancelARD.Name = "btnCancelARD"
        Me.btnCancelARD.Size = New System.Drawing.Size(67, 23)
        Me.btnCancelARD.TabIndex = 1
        Me.btnCancelARD.Text = "Cancel"
        '
        'pbar1ARD
        '
        Me.pbar1ARD.Location = New System.Drawing.Point(12, 244)
        Me.pbar1ARD.Name = "pbar1ARD"
        Me.pbar1ARD.Size = New System.Drawing.Size(407, 24)
        Me.pbar1ARD.TabIndex = 1
        '
        'kpMovieData
        '
        Me.kpMovieData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.kpMovieData.AutoSize = True
        Me.kpMovieData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kpMovieData.Controls.Add(Me.header2Border)
        Me.kpMovieData.Controls.Add(Me.header2)
        Me.kpMovieData.Controls.Add(Me.header1Border)
        Me.kpMovieData.Controls.Add(Me.header1)
        Me.kpMovieData.Location = New System.Drawing.Point(255, 70)
        Me.kpMovieData.MinimumSize = New System.Drawing.Size(300, 60)
        Me.kpMovieData.Name = "kpMovieData"
        Me.kpMovieData.Padding = New System.Windows.Forms.Padding(5)
        Me.kpMovieData.Size = New System.Drawing.Size(300, 141)
        Me.kpMovieData.TabIndex = 2
        '
        'header2Border
        '
        Me.header2Border.Dock = System.Windows.Forms.DockStyle.Top
        Me.header2Border.Location = New System.Drawing.Point(5, 126)
        Me.header2Border.Name = "header2Border"
        Me.header2Border.Size = New System.Drawing.Size(290, 10)
        Me.header2Border.TabIndex = 3
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.buttonSpecHeaderGroup1})
        Me.header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.header2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.header2.HeaderVisibleSecondary = False
        Me.header2.Location = New System.Drawing.Point(5, 80)
        Me.header2.Name = "header2"
        '
        'header2.Panel
        '
        Me.header2.Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.header2.Size = New System.Drawing.Size(290, 46)
        Me.header2.TabIndex = 1
        Me.header2.Text = "User Details"
        Me.header2.ValuesPrimary.Description = ""
        Me.header2.ValuesPrimary.Heading = "User Details"
        Me.header2.ValuesPrimary.Image = Nothing
        Me.header2.ValuesSecondary.Description = ""
        Me.header2.ValuesSecondary.Heading = "Description"
        Me.header2.ValuesSecondary.Image = Nothing
        '
        'buttonSpecHeaderGroup1
        '
        Me.buttonSpecHeaderGroup1.ExtraText = ""
        Me.buttonSpecHeaderGroup1.Image = Nothing
        Me.buttonSpecHeaderGroup1.Text = ""
        Me.buttonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.buttonSpecHeaderGroup1.UniqueName = "4A14906157B94C7D4A14906157B94C7D"
        '
        'header1Border
        '
        Me.header1Border.Dock = System.Windows.Forms.DockStyle.Top
        Me.header1Border.Location = New System.Drawing.Point(5, 75)
        Me.header1Border.Name = "header1Border"
        Me.header1Border.Size = New System.Drawing.Size(290, 5)
        Me.header1Border.TabIndex = 1
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.header1ButtonSpec})
        Me.header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.header1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.header1.HeaderVisibleSecondary = False
        Me.header1.Location = New System.Drawing.Point(5, 5)
        Me.header1.Name = "header1"
        '
        'header1.Panel
        '
        Me.header1.Panel.Controls.Add(Me.kryptonButtonPrevious)
        Me.header1.Panel.Controls.Add(Me.textBoxFind)
        Me.header1.Panel.Controls.Add(Me.kryptonButtonNext)
        Me.header1.Panel.Controls.Add(Me.labelFind)
        Me.header1.Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.header1.Size = New System.Drawing.Size(290, 70)
        Me.header1.TabIndex = 0
        Me.header1.Text = "Find"
        Me.header1.ValuesPrimary.Description = ""
        Me.header1.ValuesPrimary.Heading = "Find"
        Me.header1.ValuesPrimary.Image = Nothing
        Me.header1.ValuesSecondary.Description = ""
        Me.header1.ValuesSecondary.Heading = "Description"
        Me.header1.ValuesSecondary.Image = Nothing
        '
        'header1ButtonSpec
        '
        Me.header1ButtonSpec.ExtraText = ""
        Me.header1ButtonSpec.Image = Nothing
        Me.header1ButtonSpec.Text = ""
        Me.header1ButtonSpec.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.header1ButtonSpec.UniqueName = "3F21FD013FD447823F21FD013FD44782"
        '
        'kryptonButtonPrevious
        '
        Me.kryptonButtonPrevious.AutoSize = True
        Me.kryptonButtonPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonPrevious.Location = New System.Drawing.Point(232, 11)
        Me.kryptonButtonPrevious.Name = "kryptonButtonPrevious"
        Me.kryptonButtonPrevious.Size = New System.Drawing.Size(43, 20)
        Me.kryptonButtonPrevious.TabIndex = 1
        Me.kryptonButtonPrevious.Text = "< Prev"
        Me.kryptonButtonPrevious.Values.ExtraText = ""
        Me.kryptonButtonPrevious.Values.Image = Nothing
        Me.kryptonButtonPrevious.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kryptonButtonPrevious.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kryptonButtonPrevious.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kryptonButtonPrevious.Values.Text = "< Prev"
        '
        'textBoxFind
        '
        Me.textBoxFind.Location = New System.Drawing.Point(47, 11)
        Me.textBoxFind.Name = "textBoxFind"
        Me.textBoxFind.Size = New System.Drawing.Size(171, 20)
        Me.textBoxFind.TabIndex = 0
        Me.textBoxFind.Text = "example string"
        '
        'kryptonButtonNext
        '
        Me.kryptonButtonNext.AutoSize = True
        Me.kryptonButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonNext.Location = New System.Drawing.Point(287, 11)
        Me.kryptonButtonNext.Name = "kryptonButtonNext"
        Me.kryptonButtonNext.Size = New System.Drawing.Size(47, 21)
        Me.kryptonButtonNext.TabIndex = 2
        Me.kryptonButtonNext.Text = "Next >"
        Me.kryptonButtonNext.Values.ExtraText = ""
        Me.kryptonButtonNext.Values.Image = Nothing
        Me.kryptonButtonNext.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kryptonButtonNext.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kryptonButtonNext.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kryptonButtonNext.Values.Text = "Next >"
        '
        'labelFind
        '
        Me.labelFind.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.labelFind.Location = New System.Drawing.Point(10, 12)
        Me.labelFind.Name = "labelFind"
        Me.labelFind.Size = New System.Drawing.Size(32, 19)
        Me.labelFind.TabIndex = 0
        Me.labelFind.Text = "Text"
        Me.labelFind.Values.ExtraText = ""
        Me.labelFind.Values.Image = Nothing
        Me.labelFind.Values.Text = "Text"
        '
        'ARD
        '
        Me.AcceptButton = Me.btnStartARD
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelARD
        Me.ClientSize = New System.Drawing.Size(829, 610)
        Me.Controls.Add(Me.kpMovieData)
        Me.Controls.Add(Me.pbar1ARD)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ARD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Automagic Mode"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.kpMovieData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpMovieData.ResumeLayout(False)
        Me.kpMovieData.PerformLayout()
        CType(Me.header2Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header2.ResumeLayout(False)
        CType(Me.header1Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header1.Panel.ResumeLayout(False)
        Me.header1.Panel.PerformLayout()
        CType(Me.header1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStartARD As System.Windows.Forms.Button
    Friend WithEvents btnCancelARD As System.Windows.Forms.Button
    Friend WithEvents pbar1ARD As System.Windows.Forms.ProgressBar
    Private WithEvents kpMovieData As ComponentFactory.Krypton.Toolkit.KryptonPanel
    'Private WithEvents groupFiller As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Private WithEvents header2Border As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents header2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents buttonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents header1Border As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents header1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents header1ButtonSpec As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents kryptonButtonPrevious As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents textBoxFind As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents kryptonButtonNext As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents labelFind As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
