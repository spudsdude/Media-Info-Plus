<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPickThumbs
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.scMain = New System.Windows.Forms.SplitContainer
        Me.pbThumbSelected = New System.Windows.Forms.PictureBox
        Me.pbThumb5 = New System.Windows.Forms.PictureBox
        Me.pbThumb4 = New System.Windows.Forms.PictureBox
        Me.pbThumb3 = New System.Windows.Forms.PictureBox
        Me.pbThumb2 = New System.Windows.Forms.PictureBox
        Me.pbThumb1 = New System.Windows.Forms.PictureBox
        Me.pbThumbSelectedFanart = New System.Windows.Forms.PictureBox
        Me.pbThumb5f = New System.Windows.Forms.PictureBox
        Me.pbThumb4f = New System.Windows.Forms.PictureBox
        Me.pbThumb3f = New System.Windows.Forms.PictureBox
        Me.pbThumb2f = New System.Windows.Forms.PictureBox
        Me.pbThumb1f = New System.Windows.Forms.PictureBox
        Me.kgDlgMain = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TableLayoutPanel1.SuspendLayout()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        CType(Me.pbThumbSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumbSelectedFanart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb5f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb4f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb3f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb2f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb1f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgDlgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgDlgMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgDlgMain.Panel.SuspendLayout()
        Me.kgDlgMain.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(642, 723)
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
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.scMain.Panel1.Controls.Add(Me.pbThumbSelected)
        Me.scMain.Panel1.Controls.Add(Me.pbThumb5)
        Me.scMain.Panel1.Controls.Add(Me.pbThumb4)
        Me.scMain.Panel1.Controls.Add(Me.pbThumb3)
        Me.scMain.Panel1.Controls.Add(Me.pbThumb2)
        Me.scMain.Panel1.Controls.Add(Me.pbThumb1)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.scMain.Panel2.Controls.Add(Me.pbThumbSelectedFanart)
        Me.scMain.Panel2.Controls.Add(Me.pbThumb5f)
        Me.scMain.Panel2.Controls.Add(Me.pbThumb4f)
        Me.scMain.Panel2.Controls.Add(Me.pbThumb3f)
        Me.scMain.Panel2.Controls.Add(Me.pbThumb2f)
        Me.scMain.Panel2.Controls.Add(Me.pbThumb1f)
        Me.scMain.Size = New System.Drawing.Size(795, 719)
        Me.scMain.SplitterDistance = 358
        Me.scMain.TabIndex = 1
        '
        'pbThumbSelected
        '
        Me.pbThumbSelected.Location = New System.Drawing.Point(253, 3)
        Me.pbThumbSelected.Name = "pbThumbSelected"
        Me.pbThumbSelected.Size = New System.Drawing.Size(535, 352)
        Me.pbThumbSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbSelected.TabIndex = 5
        Me.pbThumbSelected.TabStop = False
        '
        'pbThumb5
        '
        Me.pbThumb5.Location = New System.Drawing.Point(3, 81)
        Me.pbThumb5.Name = "pbThumb5"
        Me.pbThumb5.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb5.TabIndex = 4
        Me.pbThumb5.TabStop = False
        '
        'pbThumb4
        '
        Me.pbThumb4.Location = New System.Drawing.Point(125, 3)
        Me.pbThumb4.Name = "pbThumb4"
        Me.pbThumb4.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb4.TabIndex = 3
        Me.pbThumb4.TabStop = False
        '
        'pbThumb3
        '
        Me.pbThumb3.Location = New System.Drawing.Point(3, 239)
        Me.pbThumb3.Name = "pbThumb3"
        Me.pbThumb3.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb3.TabIndex = 2
        Me.pbThumb3.TabStop = False
        '
        'pbThumb2
        '
        Me.pbThumb2.Location = New System.Drawing.Point(3, 160)
        Me.pbThumb2.Name = "pbThumb2"
        Me.pbThumb2.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb2.TabIndex = 1
        Me.pbThumb2.TabStop = False
        '
        'pbThumb1
        '
        Me.pbThumb1.Location = New System.Drawing.Point(3, 3)
        Me.pbThumb1.Name = "pbThumb1"
        Me.pbThumb1.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb1.TabIndex = 0
        Me.pbThumb1.TabStop = False
        '
        'pbThumbSelectedFanart
        '
        Me.pbThumbSelectedFanart.Location = New System.Drawing.Point(253, 3)
        Me.pbThumbSelectedFanart.Name = "pbThumbSelectedFanart"
        Me.pbThumbSelectedFanart.Size = New System.Drawing.Size(535, 352)
        Me.pbThumbSelectedFanart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbSelectedFanart.TabIndex = 10
        Me.pbThumbSelectedFanart.TabStop = False
        '
        'pbThumb5f
        '
        Me.pbThumb5f.Location = New System.Drawing.Point(3, 161)
        Me.pbThumb5f.Name = "pbThumb5f"
        Me.pbThumb5f.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb5f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb5f.TabIndex = 9
        Me.pbThumb5f.TabStop = False
        '
        'pbThumb4f
        '
        Me.pbThumb4f.Location = New System.Drawing.Point(3, 237)
        Me.pbThumb4f.Name = "pbThumb4f"
        Me.pbThumb4f.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb4f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb4f.TabIndex = 8
        Me.pbThumb4f.TabStop = False
        '
        'pbThumb3f
        '
        Me.pbThumb3f.Location = New System.Drawing.Point(125, 5)
        Me.pbThumb3f.Name = "pbThumb3f"
        Me.pbThumb3f.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb3f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb3f.TabIndex = 7
        Me.pbThumb3f.TabStop = False
        '
        'pbThumb2f
        '
        Me.pbThumb2f.Location = New System.Drawing.Point(3, 83)
        Me.pbThumb2f.Name = "pbThumb2f"
        Me.pbThumb2f.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb2f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb2f.TabIndex = 6
        Me.pbThumb2f.TabStop = False
        '
        'pbThumb1f
        '
        Me.pbThumb1f.Location = New System.Drawing.Point(3, 5)
        Me.pbThumb1f.Name = "pbThumb1f"
        Me.pbThumb1f.Size = New System.Drawing.Size(116, 76)
        Me.pbThumb1f.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumb1f.TabIndex = 5
        Me.pbThumb1f.TabStop = False
        '
        'kgDlgMain
        '
        Me.kgDlgMain.Location = New System.Drawing.Point(-1, -1)
        Me.kgDlgMain.Name = "kgDlgMain"
        '
        'kgDlgMain.Panel
        '
        Me.kgDlgMain.Panel.Controls.Add(Me.scMain)
        Me.kgDlgMain.Size = New System.Drawing.Size(797, 721)
        Me.kgDlgMain.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 321)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(254, 24)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Episode Thumbnail - 720x480"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Episode Thumbnail - 720x480"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 330)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(276, 24)
        Me.KryptonLabel2.TabIndex = 11
        Me.KryptonLabel2.Text = "Episode Background - 1280x720"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Episode Background - 1280x720"
        '
        'dlgPickThumbs
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(800, 764)
        Me.Controls.Add(Me.kgDlgMain)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPickThumbs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Episode Thumbnail and Fanart Selection"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel1.PerformLayout()
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        Me.scMain.ResumeLayout(False)
        CType(Me.pbThumbSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumbSelectedFanart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb5f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb4f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb3f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb2f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb1f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kgDlgMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgDlgMain.Panel.ResumeLayout(False)
        CType(Me.kgDlgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgDlgMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents pbThumb5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb5f As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb4f As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb3f As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb2f As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumb1f As System.Windows.Forms.PictureBox
    Friend WithEvents kgDlgMain As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents pbThumbSelected As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumbSelectedFanart As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
