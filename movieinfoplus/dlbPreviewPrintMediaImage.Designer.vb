<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPreviewPrintMediaImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPreviewPrintMediaImage))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.kbPbGroup = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.pbMainImage = New System.Windows.Forms.PictureBox
        Me.kscMain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kgBtnGroup = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.ToolStrip1.SuspendLayout()
        CType(Me.kbPbGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kbPbGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kbPbGroup.Panel.SuspendLayout()
        Me.kbPbGroup.SuspendLayout()
        CType(Me.pbMainImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMain.Panel1.SuspendLayout()
        CType(Me.kscMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscMain.Panel2.SuspendLayout()
        Me.kscMain.SuspendLayout()
        CType(Me.kgBtnGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgBtnGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgBtnGroup.Panel.SuspendLayout()
        Me.kgBtnGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'kbPbGroup
        '
        Me.kbPbGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kbPbGroup.Location = New System.Drawing.Point(0, 0)
        Me.kbPbGroup.Name = "kbPbGroup"
        '
        'kbPbGroup.Panel
        '
        Me.kbPbGroup.Panel.Controls.Add(Me.pbMainImage)
        Me.kbPbGroup.Size = New System.Drawing.Size(833, 568)
        Me.kbPbGroup.TabIndex = 2
        '
        'pbMainImage
        '
        Me.pbMainImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbMainImage.Location = New System.Drawing.Point(0, 0)
        Me.pbMainImage.Name = "pbMainImage"
        Me.pbMainImage.Size = New System.Drawing.Size(823, 558)
        Me.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMainImage.TabIndex = 0
        Me.pbMainImage.TabStop = False
        '
        'kscMain
        '
        Me.kscMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.kscMain.Location = New System.Drawing.Point(0, 25)
        Me.kscMain.Name = "kscMain"
        Me.kscMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscMain.Panel1
        '
        Me.kscMain.Panel1.Controls.Add(Me.kbPbGroup)
        '
        'kscMain.Panel2
        '
        Me.kscMain.Panel2.Controls.Add(Me.kgBtnGroup)
        Me.kscMain.Size = New System.Drawing.Size(833, 623)
        Me.kscMain.SplitterDistance = 568
        Me.kscMain.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(313, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(164, 37)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Close"
        Me.btnOK.Values.ExtraText = ""
        Me.btnOK.Values.Image = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOK.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOK.Values.Text = "Close"
        '
        'kgBtnGroup
        '
        Me.kgBtnGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgBtnGroup.Location = New System.Drawing.Point(0, 0)
        Me.kgBtnGroup.Name = "kgBtnGroup"
        '
        'kgBtnGroup.Panel
        '
        Me.kgBtnGroup.Panel.Controls.Add(Me.btnOK)
        Me.kgBtnGroup.Size = New System.Drawing.Size(833, 50)
        Me.kgBtnGroup.TabIndex = 0
        '
        'dlgPreviewPrintMediaImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 648)
        Me.Controls.Add(Me.kscMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "dlgPreviewPrintMediaImage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlbPreviewPrintMediaImage"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.kbPbGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kbPbGroup.Panel.ResumeLayout(False)
        CType(Me.kbPbGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kbPbGroup.ResumeLayout(False)
        CType(Me.pbMainImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kscMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.Panel1.ResumeLayout(False)
        CType(Me.kscMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.Panel2.ResumeLayout(False)
        CType(Me.kscMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscMain.ResumeLayout(False)
        CType(Me.kgBtnGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgBtnGroup.Panel.ResumeLayout(False)
        CType(Me.kgBtnGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgBtnGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents kbPbGroup As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents pbMainImage As System.Windows.Forms.PictureBox
    Friend WithEvents kscMain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kgBtnGroup As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
