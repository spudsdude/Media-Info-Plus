<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMusicSortingWizard
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
        Me.kgSource = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnBrowseForSrcFolder = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.tbSrcFolder = New System.Windows.Forms.TextBox
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.cbAllLower = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        CType(Me.kgSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgSource.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgSource.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kgSource
        '
        Me.kgSource.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kgSource.Location = New System.Drawing.Point(406, 12)
        Me.kgSource.Name = "kgSource"
        Me.kgSource.Size = New System.Drawing.Size(204, 256)
        Me.kgSource.TabIndex = 1
        '
        'btnBrowseForSrcFolder
        '
        Me.btnBrowseForSrcFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBrowseForSrcFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseForSrcFolder.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseForSrcFolder.Location = New System.Drawing.Point(420, 31)
        Me.btnBrowseForSrcFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseForSrcFolder.Name = "btnBrowseForSrcFolder"
        Me.btnBrowseForSrcFolder.Size = New System.Drawing.Size(71, 25)
        Me.btnBrowseForSrcFolder.TabIndex = 45
        Me.btnBrowseForSrcFolder.Text = "Browse"
        Me.btnBrowseForSrcFolder.Values.ExtraText = ""
        Me.btnBrowseForSrcFolder.Values.Image = Nothing
        Me.btnBrowseForSrcFolder.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBrowseForSrcFolder.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBrowseForSrcFolder.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBrowseForSrcFolder.Values.Text = "Browse"
        '
        'tbSrcFolder
        '
        Me.tbSrcFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSrcFolder.Location = New System.Drawing.Point(29, 31)
        Me.tbSrcFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSrcFolder.Name = "tbSrcFolder"
        Me.tbSrcFolder.Size = New System.Drawing.Size(387, 22)
        Me.tbSrcFolder.TabIndex = 46
        Me.tbSrcFolder.Text = "Enter the path and click add or click browse to select"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KryptonButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.ForeColor = System.Drawing.Color.Black
        Me.KryptonButton1.Location = New System.Drawing.Point(420, 95)
        Me.KryptonButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(71, 25)
        Me.KryptonButton1.TabIndex = 47
        Me.KryptonButton1.Text = "Browse"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Browse"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(29, 95)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(387, 22)
        Me.TextBox1.TabIndex = 48
        Me.TextBox1.Text = "Enter the path and click add or click browse to select"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(208, 122)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.cbAllLower)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.TextBox1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnBrowseForSrcFolder)
        Me.KryptonGroup1.Panel.Controls.Add(Me.tbSrcFolder)
        Me.KryptonGroup1.Size = New System.Drawing.Size(186, 107)
        Me.KryptonGroup1.TabIndex = 49
        '
        'cbAllLower
        '
        Me.cbAllLower.Location = New System.Drawing.Point(335, 235)
        Me.cbAllLower.Name = "cbAllLower"
        Me.cbAllLower.Size = New System.Drawing.Size(227, 16)
        Me.cbAllLower.TabIndex = 50
        Me.cbAllLower.Text = "Convert all new music files to lower case"
        Me.cbAllLower.Values.ExtraText = ""
        Me.cbAllLower.Values.Image = Nothing
        Me.cbAllLower.Values.Text = "Convert all new music files to lower case"
        '
        'dlgMusicSortingWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(622, 315)
        Me.Controls.Add(Me.kgSource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMusicSortingWizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Music Sorting Wizard"
        CType(Me.kgSource.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kgSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgSource.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kgSource As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseForSrcFolder As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tbSrcFolder As System.Windows.Forms.TextBox
    Friend WithEvents cbAllLower As ComponentFactory.Krypton.Toolkit.KryptonCheckBox

End Class
