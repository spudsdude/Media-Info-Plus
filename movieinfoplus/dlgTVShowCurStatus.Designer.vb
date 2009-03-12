<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTVShowCurStatus
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
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.krbStatus = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
        Me.bwtvshowstatus = New System.ComponentModel.BackgroundWorker
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(415, 274)
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
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.krbStatus)
        Me.KryptonGroup1.Size = New System.Drawing.Size(573, 315)
        Me.KryptonGroup1.TabIndex = 1
        '
        'krbStatus
        '
        Me.krbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.krbStatus.Location = New System.Drawing.Point(0, 0)
        Me.krbStatus.Name = "krbStatus"
        Me.krbStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
        Me.krbStatus.Size = New System.Drawing.Size(571, 313)
        Me.krbStatus.TabIndex = 0
        Me.krbStatus.Text = "TV Show Loading / Status Logging..."
        '
        'bwtvshowstatus
        '
        Me.bwtvshowstatus.WorkerReportsProgress = True
        '
        'dlgTVShowCurStatus
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(573, 315)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTVShowCurStatus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TV Show Loading Status"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents krbStatus As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents bwtvshowstatus As System.ComponentModel.BackgroundWorker

End Class
