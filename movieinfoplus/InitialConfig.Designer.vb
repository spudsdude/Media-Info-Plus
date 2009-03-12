<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialConfig
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
        Me.cbMaxIconsToDisplay = New System.Windows.Forms.ComboBox
        Me.rbem = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbGetIMDBInfo = New System.Windows.Forms.CheckBox
        Me.cbDownloadPoster = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.cbf2s10 = New System.Windows.Forms.CheckBox
        Me.cbf2s8 = New System.Windows.Forms.CheckBox
        Me.cbf2s2 = New System.Windows.Forms.CheckBox
        Me.cboxType = New System.Windows.Forms.ComboBox
        Me.cbMaxIconPerStyle = New System.Windows.Forms.ComboBox
        Me.cbf3s0 = New System.Windows.Forms.CheckBox
        Me.cbf1s9 = New System.Windows.Forms.CheckBox
        Me.cbf1s0 = New System.Windows.Forms.CheckBox
        Me.cbf1s3 = New System.Windows.Forms.CheckBox
        Me.cbf2s0 = New System.Windows.Forms.CheckBox
        Me.cbFilterH264 = New System.Windows.Forms.CheckBox
        Me.cbFilterLq = New System.Windows.Forms.CheckBox
        Me.cbFilterCustom4 = New System.Windows.Forms.CheckBox
        Me.cbFilterCustom3 = New System.Windows.Forms.CheckBox
        Me.cbFilterCustom2 = New System.Windows.Forms.CheckBox
        Me.cbFilterCustom1 = New System.Windows.Forms.CheckBox
        Me.tbCustomFilter1 = New System.Windows.Forms.TextBox
        Me.tbCustomFilter4 = New System.Windows.Forms.TextBox
        Me.tbCustomFilter3 = New System.Windows.Forms.TextBox
        Me.tbCustomFilter2 = New System.Windows.Forms.TextBox
        Me.cbFilterHidef = New System.Windows.Forms.CheckBox
        Me.cbFilter1080p = New System.Windows.Forms.CheckBox
        Me.cbFilter720p = New System.Windows.Forms.CheckBox
        Me.cbFilterBluRay = New System.Windows.Forms.CheckBox
        Me.cbFilterAvi = New System.Windows.Forms.CheckBox
        Me.cbFilterXvid = New System.Windows.Forms.CheckBox
        Me.cbFilterDivx = New System.Windows.Forms.CheckBox
        Me.cbFilterDVD = New System.Windows.Forms.CheckBox
        Me.tbFolder = New System.Windows.Forms.TextBox
        Me.btnAddtoclb = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.clbPaths = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbIgnoreYears = New System.Windows.Forms.CheckBox
        Me.cbIgnore1080i = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbFanForBack = New System.Windows.Forms.CheckBox
        Me.cbGenTBN = New System.Windows.Forms.CheckBox
        Me.cbOverwriteNFO = New System.Windows.Forms.CheckBox
        Me.cbSaveNFO = New System.Windows.Forms.CheckBox
        Me.cbGetFanart = New System.Windows.Forms.CheckBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.lblMFL = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMaxIconsToDisplay
        '
        Me.cbMaxIconsToDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaxIconsToDisplay.FormattingEnabled = True
        Me.cbMaxIconsToDisplay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbMaxIconsToDisplay.Location = New System.Drawing.Point(295, 69)
        Me.cbMaxIconsToDisplay.Name = "cbMaxIconsToDisplay"
        Me.cbMaxIconsToDisplay.Size = New System.Drawing.Size(39, 21)
        Me.cbMaxIconsToDisplay.TabIndex = 89
        Me.cbMaxIconsToDisplay.Text = "8"
        '
        'rbem
        '
        Me.rbem.AutoSize = True
        Me.rbem.BackColor = System.Drawing.Color.White
        Me.rbem.Checked = True
        Me.rbem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbem.Location = New System.Drawing.Point(160, 16)
        Me.rbem.Name = "rbem"
        Me.rbem.Size = New System.Drawing.Size(85, 17)
        Me.rbem.TabIndex = 93
        Me.rbem.TabStop = True
        Me.rbem.Text = "Online Mode"
        Me.rbem.UseVisualStyleBackColor = False
        Me.rbem.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Note there is a space before the (DVD) and all other defaults."
        '
        'cbGetIMDBInfo
        '
        Me.cbGetIMDBInfo.AutoSize = True
        Me.cbGetIMDBInfo.Checked = True
        Me.cbGetIMDBInfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetIMDBInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGetIMDBInfo.ForeColor = System.Drawing.Color.Black
        Me.cbGetIMDBInfo.Location = New System.Drawing.Point(10, 16)
        Me.cbGetIMDBInfo.Name = "cbGetIMDBInfo"
        Me.cbGetIMDBInfo.Size = New System.Drawing.Size(94, 17)
        Me.cbGetIMDBInfo.TabIndex = 92
        Me.cbGetIMDBInfo.Text = "Get IMDB Info"
        Me.cbGetIMDBInfo.UseVisualStyleBackColor = True
        '
        'cbDownloadPoster
        '
        Me.cbDownloadPoster.AutoSize = True
        Me.cbDownloadPoster.Checked = True
        Me.cbDownloadPoster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDownloadPoster.Enabled = False
        Me.cbDownloadPoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDownloadPoster.ForeColor = System.Drawing.Color.Black
        Me.cbDownloadPoster.Location = New System.Drawing.Point(10, 32)
        Me.cbDownloadPoster.Name = "cbDownloadPoster"
        Me.cbDownloadPoster.Size = New System.Drawing.Size(81, 17)
        Me.cbDownloadPoster.TabIndex = 91
        Me.cbDownloadPoster.Text = "Get Posters"
        Me.cbDownloadPoster.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(569, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Example: Folder name is ""300 (DVD)"" .. with the Ignore (DVD) option checked, it w" & _
            "ill process the moviename as ""300"". "
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(198, 438)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(191, 23)
        Me.Button6.TabIndex = 105
        Me.Button6.Text = "Save Config and Generate XMLS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cbf2s10
        '
        Me.cbf2s10.AutoSize = True
        Me.cbf2s10.Checked = True
        Me.cbf2s10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf2s10.ForeColor = System.Drawing.Color.Black
        Me.cbf2s10.Location = New System.Drawing.Point(147, 51)
        Me.cbf2s10.Name = "cbf2s10"
        Me.cbf2s10.Size = New System.Drawing.Size(169, 17)
        Me.cbf2s10.TabIndex = 104
        Me.cbf2s10.Text = "Wide Rounded Shadow Glass"
        Me.cbf2s10.UseVisualStyleBackColor = True
        '
        'cbf2s8
        '
        Me.cbf2s8.AutoSize = True
        Me.cbf2s8.Checked = True
        Me.cbf2s8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf2s8.ForeColor = System.Drawing.Color.Black
        Me.cbf2s8.Location = New System.Drawing.Point(7, 51)
        Me.cbf2s8.Name = "cbf2s8"
        Me.cbf2s8.Size = New System.Drawing.Size(140, 17)
        Me.cbf2s8.TabIndex = 103
        Me.cbf2s8.Text = "Wide Rounded Shadow"
        Me.cbf2s8.UseVisualStyleBackColor = True
        '
        'cbf2s2
        '
        Me.cbf2s2.AutoSize = True
        Me.cbf2s2.Checked = True
        Me.cbf2s2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf2s2.ForeColor = System.Drawing.Color.Black
        Me.cbf2s2.Location = New System.Drawing.Point(60, 33)
        Me.cbf2s2.Name = "cbf2s2"
        Me.cbf2s2.Size = New System.Drawing.Size(189, 17)
        Me.cbf2s2.TabIndex = 102
        Me.cbf2s2.Text = "Wide Rounded Shadow Scanlines"
        Me.cbf2s2.UseVisualStyleBackColor = True
        '
        'cboxType
        '
        Me.cboxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxType.FormattingEnabled = True
        Me.cboxType.Items.AddRange(New Object() {"Low Quality", "Medium Quality", "Highest Quality"})
        Me.cboxType.Location = New System.Drawing.Point(69, 69)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(102, 21)
        Me.cboxType.TabIndex = 101
        Me.cboxType.Text = "Highest Quality"
        '
        'cbMaxIconPerStyle
        '
        Me.cbMaxIconPerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaxIconPerStyle.FormattingEnabled = True
        Me.cbMaxIconPerStyle.Items.AddRange(New Object() {"Cache 1 Icon Per Type", "Cache 2 Icons Per Type", "Cache 3 Icons Per Type", "Cache 4 Icons Per Type", "Cache 5 Icons Per Type", "Cache 6 Icons Per Type", "Cache 7 Icons Per Type", "Cache 8 Icons Per Type", "Cache 9 Icons Per Type", "Cache 10 Icons Per Type", "Cache 11 Icons Per Type", "Cache 12 Icons Per Type", "Cache 13 Icons Per Type", "Cache 14 Icons Per Type", "Cache 15 Icons Per Type", "Cache 16 Icons Per Type", "Cache 17 Icons Per Type", "Cache 18 Icons Per Type", "Cache 19 Icons Per Type", "Cache 20 Icons Per Type", "Cache 21 Icons Per Type", "Cache 22 Icons Per Type", "Cache 23 Icons Per Type", "Cache 24 Icons Per Type"})
        Me.cbMaxIconPerStyle.Location = New System.Drawing.Point(126, 95)
        Me.cbMaxIconPerStyle.Name = "cbMaxIconPerStyle"
        Me.cbMaxIconPerStyle.Size = New System.Drawing.Size(160, 21)
        Me.cbMaxIconPerStyle.TabIndex = 100
        Me.cbMaxIconPerStyle.Text = "Cache 8 Icons Per Type"
        '
        'cbf3s0
        '
        Me.cbf3s0.AutoSize = True
        Me.cbf3s0.Enabled = False
        Me.cbf3s0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf3s0.ForeColor = System.Drawing.Color.Black
        Me.cbf3s0.Location = New System.Drawing.Point(253, 15)
        Me.cbf3s0.Name = "cbf3s0"
        Me.cbf3s0.Size = New System.Drawing.Size(72, 17)
        Me.cbf3s0.TabIndex = 96
        Me.cbf3s0.Text = "Tall Icons"
        Me.cbf3s0.UseVisualStyleBackColor = True
        Me.cbf3s0.Visible = False
        '
        'cbf1s9
        '
        Me.cbf1s9.AutoSize = True
        Me.cbf1s9.Checked = True
        Me.cbf1s9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf1s9.ForeColor = System.Drawing.Color.Black
        Me.cbf1s9.Location = New System.Drawing.Point(169, 15)
        Me.cbf1s9.Name = "cbf1s9"
        Me.cbf1s9.Size = New System.Drawing.Size(83, 17)
        Me.cbf1s9.TabIndex = 99
        Me.cbf1s9.Text = "Token Style"
        Me.cbf1s9.UseVisualStyleBackColor = True
        '
        'cbf1s0
        '
        Me.cbf1s0.AutoSize = True
        Me.cbf1s0.Checked = True
        Me.cbf1s0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf1s0.ForeColor = System.Drawing.Color.Black
        Me.cbf1s0.Location = New System.Drawing.Point(7, 16)
        Me.cbf1s0.Name = "cbf1s0"
        Me.cbf1s0.Size = New System.Drawing.Size(89, 17)
        Me.cbf1s0.TabIndex = 97
        Me.cbf1s0.Text = "Square Icons"
        Me.cbf1s0.UseVisualStyleBackColor = True
        '
        'cbf1s3
        '
        Me.cbf1s3.AutoSize = True
        Me.cbf1s3.Checked = True
        Me.cbf1s3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf1s3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf1s3.ForeColor = System.Drawing.Color.Black
        Me.cbf1s3.Location = New System.Drawing.Point(94, 16)
        Me.cbf1s3.Name = "cbf1s3"
        Me.cbf1s3.Size = New System.Drawing.Size(69, 17)
        Me.cbf1s3.TabIndex = 98
        Me.cbf1s3.Text = "Box Shot"
        Me.cbf1s3.UseVisualStyleBackColor = True
        '
        'cbf2s0
        '
        Me.cbf2s0.AutoSize = True
        Me.cbf2s0.Checked = True
        Me.cbf2s0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbf2s0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbf2s0.ForeColor = System.Drawing.Color.Black
        Me.cbf2s0.Location = New System.Drawing.Point(7, 33)
        Me.cbf2s0.Name = "cbf2s0"
        Me.cbf2s0.Size = New System.Drawing.Size(51, 17)
        Me.cbf2s0.TabIndex = 95
        Me.cbf2s0.Text = "Wide"
        Me.cbf2s0.UseVisualStyleBackColor = True
        '
        'cbFilterH264
        '
        Me.cbFilterH264.AutoSize = True
        Me.cbFilterH264.Checked = True
        Me.cbFilterH264.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterH264.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterH264.Location = New System.Drawing.Point(107, 130)
        Me.cbFilterH264.Name = "cbFilterH264"
        Me.cbFilterH264.Size = New System.Drawing.Size(91, 17)
        Me.cbFilterH264.TabIndex = 90
        Me.cbFilterH264.Text = "Ignore (H264)"
        Me.cbFilterH264.UseVisualStyleBackColor = True
        '
        'cbFilterLq
        '
        Me.cbFilterLq.AutoSize = True
        Me.cbFilterLq.Checked = True
        Me.cbFilterLq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterLq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterLq.Location = New System.Drawing.Point(107, 112)
        Me.cbFilterLq.Name = "cbFilterLq"
        Me.cbFilterLq.Size = New System.Drawing.Size(73, 17)
        Me.cbFilterLq.TabIndex = 88
        Me.cbFilterLq.Text = "Ignore (lq)"
        Me.cbFilterLq.UseVisualStyleBackColor = True
        '
        'cbFilterCustom4
        '
        Me.cbFilterCustom4.AutoSize = True
        Me.cbFilterCustom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterCustom4.Location = New System.Drawing.Point(324, 124)
        Me.cbFilterCustom4.Name = "cbFilterCustom4"
        Me.cbFilterCustom4.Size = New System.Drawing.Size(127, 17)
        Me.cbFilterCustom4.TabIndex = 87
        Me.cbFilterCustom4.Text = "Ignore Custom Text 4"
        Me.cbFilterCustom4.UseVisualStyleBackColor = True
        '
        'cbFilterCustom3
        '
        Me.cbFilterCustom3.AutoSize = True
        Me.cbFilterCustom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterCustom3.Location = New System.Drawing.Point(324, 103)
        Me.cbFilterCustom3.Name = "cbFilterCustom3"
        Me.cbFilterCustom3.Size = New System.Drawing.Size(127, 17)
        Me.cbFilterCustom3.TabIndex = 86
        Me.cbFilterCustom3.Text = "Ignore Custom Text 3"
        Me.cbFilterCustom3.UseVisualStyleBackColor = True
        '
        'cbFilterCustom2
        '
        Me.cbFilterCustom2.AutoSize = True
        Me.cbFilterCustom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterCustom2.Location = New System.Drawing.Point(324, 81)
        Me.cbFilterCustom2.Name = "cbFilterCustom2"
        Me.cbFilterCustom2.Size = New System.Drawing.Size(127, 17)
        Me.cbFilterCustom2.TabIndex = 85
        Me.cbFilterCustom2.Text = "Ignore Custom Text 2"
        Me.cbFilterCustom2.UseVisualStyleBackColor = True
        '
        'cbFilterCustom1
        '
        Me.cbFilterCustom1.AutoSize = True
        Me.cbFilterCustom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterCustom1.Location = New System.Drawing.Point(324, 58)
        Me.cbFilterCustom1.Name = "cbFilterCustom1"
        Me.cbFilterCustom1.Size = New System.Drawing.Size(127, 17)
        Me.cbFilterCustom1.TabIndex = 84
        Me.cbFilterCustom1.Text = "Ignore Custom Text 1"
        Me.cbFilterCustom1.UseVisualStyleBackColor = True
        '
        'tbCustomFilter1
        '
        Me.tbCustomFilter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter1.Location = New System.Drawing.Point(217, 56)
        Me.tbCustomFilter1.Name = "tbCustomFilter1"
        Me.tbCustomFilter1.Size = New System.Drawing.Size(100, 20)
        Me.tbCustomFilter1.TabIndex = 82
        '
        'tbCustomFilter4
        '
        Me.tbCustomFilter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter4.Location = New System.Drawing.Point(217, 122)
        Me.tbCustomFilter4.Name = "tbCustomFilter4"
        Me.tbCustomFilter4.Size = New System.Drawing.Size(100, 20)
        Me.tbCustomFilter4.TabIndex = 81
        '
        'tbCustomFilter3
        '
        Me.tbCustomFilter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter3.Location = New System.Drawing.Point(217, 100)
        Me.tbCustomFilter3.Name = "tbCustomFilter3"
        Me.tbCustomFilter3.Size = New System.Drawing.Size(100, 20)
        Me.tbCustomFilter3.TabIndex = 80
        '
        'tbCustomFilter2
        '
        Me.tbCustomFilter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomFilter2.Location = New System.Drawing.Point(217, 78)
        Me.tbCustomFilter2.Name = "tbCustomFilter2"
        Me.tbCustomFilter2.Size = New System.Drawing.Size(100, 20)
        Me.tbCustomFilter2.TabIndex = 79
        '
        'cbFilterHidef
        '
        Me.cbFilterHidef.AutoSize = True
        Me.cbFilterHidef.Checked = True
        Me.cbFilterHidef.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterHidef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterHidef.Location = New System.Drawing.Point(107, 94)
        Me.cbFilterHidef.Name = "cbFilterHidef"
        Me.cbFilterHidef.Size = New System.Drawing.Size(88, 17)
        Me.cbFilterHidef.TabIndex = 78
        Me.cbFilterHidef.Text = "Ignore (hidef)"
        Me.cbFilterHidef.UseVisualStyleBackColor = True
        '
        'cbFilter1080p
        '
        Me.cbFilter1080p.AutoSize = True
        Me.cbFilter1080p.Checked = True
        Me.cbFilter1080p.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilter1080p.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter1080p.Location = New System.Drawing.Point(107, 76)
        Me.cbFilter1080p.Name = "cbFilter1080p"
        Me.cbFilter1080p.Size = New System.Drawing.Size(95, 17)
        Me.cbFilter1080p.TabIndex = 76
        Me.cbFilter1080p.Text = "Ignore (1080p)"
        Me.cbFilter1080p.UseVisualStyleBackColor = True
        '
        'cbFilter720p
        '
        Me.cbFilter720p.AutoSize = True
        Me.cbFilter720p.Checked = True
        Me.cbFilter720p.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilter720p.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter720p.Location = New System.Drawing.Point(107, 58)
        Me.cbFilter720p.Name = "cbFilter720p"
        Me.cbFilter720p.Size = New System.Drawing.Size(89, 17)
        Me.cbFilter720p.TabIndex = 75
        Me.cbFilter720p.Text = "Ignore (720p)"
        Me.cbFilter720p.UseVisualStyleBackColor = True
        '
        'cbFilterBluRay
        '
        Me.cbFilterBluRay.AutoSize = True
        Me.cbFilterBluRay.Checked = True
        Me.cbFilterBluRay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterBluRay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterBluRay.Location = New System.Drawing.Point(9, 128)
        Me.cbFilterBluRay.Name = "cbFilterBluRay"
        Me.cbFilterBluRay.Size = New System.Drawing.Size(97, 17)
        Me.cbFilterBluRay.TabIndex = 74
        Me.cbFilterBluRay.Text = "Ignore (Blu-ray)"
        Me.cbFilterBluRay.UseVisualStyleBackColor = True
        '
        'cbFilterAvi
        '
        Me.cbFilterAvi.AutoSize = True
        Me.cbFilterAvi.Checked = True
        Me.cbFilterAvi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterAvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterAvi.Location = New System.Drawing.Point(9, 92)
        Me.cbFilterAvi.Name = "cbFilterAvi"
        Me.cbFilterAvi.Size = New System.Drawing.Size(79, 17)
        Me.cbFilterAvi.TabIndex = 73
        Me.cbFilterAvi.Text = "Ignore (avi)"
        Me.cbFilterAvi.UseVisualStyleBackColor = True
        '
        'cbFilterXvid
        '
        Me.cbFilterXvid.AutoSize = True
        Me.cbFilterXvid.Checked = True
        Me.cbFilterXvid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterXvid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterXvid.Location = New System.Drawing.Point(9, 75)
        Me.cbFilterXvid.Name = "cbFilterXvid"
        Me.cbFilterXvid.Size = New System.Drawing.Size(84, 17)
        Me.cbFilterXvid.TabIndex = 72
        Me.cbFilterXvid.Text = "Ignore (xvid)"
        Me.cbFilterXvid.UseVisualStyleBackColor = True
        '
        'cbFilterDivx
        '
        Me.cbFilterDivx.AutoSize = True
        Me.cbFilterDivx.Checked = True
        Me.cbFilterDivx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterDivx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterDivx.Location = New System.Drawing.Point(9, 58)
        Me.cbFilterDivx.Name = "cbFilterDivx"
        Me.cbFilterDivx.Size = New System.Drawing.Size(86, 17)
        Me.cbFilterDivx.TabIndex = 71
        Me.cbFilterDivx.Text = "Ignore (Divx)"
        Me.cbFilterDivx.UseVisualStyleBackColor = True
        '
        'cbFilterDVD
        '
        Me.cbFilterDVD.AutoSize = True
        Me.cbFilterDVD.Checked = True
        Me.cbFilterDVD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilterDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterDVD.Location = New System.Drawing.Point(9, 110)
        Me.cbFilterDVD.Name = "cbFilterDVD"
        Me.cbFilterDVD.Size = New System.Drawing.Size(88, 17)
        Me.cbFilterDVD.TabIndex = 70
        Me.cbFilterDVD.Text = "Ignore (DVD)"
        Me.cbFilterDVD.UseVisualStyleBackColor = True
        '
        'tbFolder
        '
        Me.tbFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolder.Location = New System.Drawing.Point(7, 337)
        Me.tbFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Size = New System.Drawing.Size(317, 22)
        Me.tbFolder.TabIndex = 112
        Me.tbFolder.Text = "Enter the path and click add or click browse to select"
        '
        'btnAddtoclb
        '
        Me.btnAddtoclb.Enabled = False
        Me.btnAddtoclb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoclb.ForeColor = System.Drawing.Color.Black
        Me.btnAddtoclb.Location = New System.Drawing.Point(329, 336)
        Me.btnAddtoclb.Name = "btnAddtoclb"
        Me.btnAddtoclb.Size = New System.Drawing.Size(74, 23)
        Me.btnAddtoclb.TabIndex = 114
        Me.btnAddtoclb.Text = "Add Path"
        Me.btnAddtoclb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(408, 336)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clbPaths
        '
        Me.clbPaths.CheckOnClick = True
        Me.clbPaths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbPaths.FormattingEnabled = True
        Me.clbPaths.Location = New System.Drawing.Point(7, 363)
        Me.clbPaths.Name = "clbPaths"
        Me.clbPaths.Size = New System.Drawing.Size(578, 72)
        Me.clbPaths.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Cache Number of Icons"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Display Number of Icons"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Icon Quality"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(439, 444)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 14)
        Me.CheckBox1.TabIndex = 118
        Me.CheckBox1.Text = "Max Procs 128 Max Cons 64"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbIgnoreYears)
        Me.GroupBox1.Controls.Add(Me.cbIgnore1080i)
        Me.GroupBox1.Controls.Add(Me.cbFilter1080p)
        Me.GroupBox1.Controls.Add(Me.cbFilterDVD)
        Me.GroupBox1.Controls.Add(Me.cbFilterDivx)
        Me.GroupBox1.Controls.Add(Me.cbFilterXvid)
        Me.GroupBox1.Controls.Add(Me.cbFilterAvi)
        Me.GroupBox1.Controls.Add(Me.cbFilterBluRay)
        Me.GroupBox1.Controls.Add(Me.cbFilter720p)
        Me.GroupBox1.Controls.Add(Me.cbFilterHidef)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbCustomFilter2)
        Me.GroupBox1.Controls.Add(Me.tbCustomFilter3)
        Me.GroupBox1.Controls.Add(Me.tbCustomFilter4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbCustomFilter1)
        Me.GroupBox1.Controls.Add(Me.cbFilterCustom1)
        Me.GroupBox1.Controls.Add(Me.cbFilterCustom2)
        Me.GroupBox1.Controls.Add(Me.cbFilterCustom3)
        Me.GroupBox1.Controls.Add(Me.cbFilterCustom4)
        Me.GroupBox1.Controls.Add(Me.cbFilterLq)
        Me.GroupBox1.Controls.Add(Me.cbFilterH264)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 169)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name Filter - If checked it will ignore this from the folder name"
        '
        'cbIgnoreYears
        '
        Me.cbIgnoreYears.AutoSize = True
        Me.cbIgnoreYears.Checked = True
        Me.cbIgnoreYears.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIgnoreYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIgnoreYears.Location = New System.Drawing.Point(107, 148)
        Me.cbIgnoreYears.Name = "cbIgnoreYears"
        Me.cbIgnoreYears.Size = New System.Drawing.Size(242, 17)
        Me.cbIgnoreYears.TabIndex = 112
        Me.cbIgnoreYears.Text = "Ignore (%YEAR%) - where %YEAR% is 4 digits"
        Me.cbIgnoreYears.UseVisualStyleBackColor = True
        '
        'cbIgnore1080i
        '
        Me.cbIgnore1080i.AutoSize = True
        Me.cbIgnore1080i.Checked = True
        Me.cbIgnore1080i.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIgnore1080i.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIgnore1080i.Location = New System.Drawing.Point(9, 147)
        Me.cbIgnore1080i.Name = "cbIgnore1080i"
        Me.cbIgnore1080i.Size = New System.Drawing.Size(91, 17)
        Me.cbIgnore1080i.TabIndex = 111
        Me.cbIgnore1080i.Text = "Ignore (1080i)"
        Me.cbIgnore1080i.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbf2s8)
        Me.GroupBox2.Controls.Add(Me.cbf2s0)
        Me.GroupBox2.Controls.Add(Me.cbf1s3)
        Me.GroupBox2.Controls.Add(Me.cbMaxIconsToDisplay)
        Me.GroupBox2.Controls.Add(Me.cbf1s0)
        Me.GroupBox2.Controls.Add(Me.cbf1s9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbf3s0)
        Me.GroupBox2.Controls.Add(Me.cbMaxIconPerStyle)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboxType)
        Me.GroupBox2.Controls.Add(Me.cbf2s2)
        Me.GroupBox2.Controls.Add(Me.cbf2s10)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 124)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type Size and Quality of Icons"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbFanForBack)
        Me.GroupBox3.Controls.Add(Me.cbGenTBN)
        Me.GroupBox3.Controls.Add(Me.cbGetIMDBInfo)
        Me.GroupBox3.Controls.Add(Me.cbOverwriteNFO)
        Me.GroupBox3.Controls.Add(Me.cbDownloadPoster)
        Me.GroupBox3.Controls.Add(Me.cbSaveNFO)
        Me.GroupBox3.Controls.Add(Me.cbGetFanart)
        Me.GroupBox3.Controls.Add(Me.rbem)
        Me.GroupBox3.Location = New System.Drawing.Point(350, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 124)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IMDB and Poster Settings"
        '
        'cbFanForBack
        '
        Me.cbFanForBack.AutoSize = True
        Me.cbFanForBack.Checked = True
        Me.cbFanForBack.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFanForBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFanForBack.ForeColor = System.Drawing.Color.Black
        Me.cbFanForBack.Location = New System.Drawing.Point(92, 48)
        Me.cbFanForBack.Name = "cbFanForBack"
        Me.cbFanForBack.Size = New System.Drawing.Size(154, 17)
        Me.cbFanForBack.TabIndex = 126
        Me.cbFanForBack.Text = "Use Fanart for Background"
        Me.cbFanForBack.UseVisualStyleBackColor = True
        '
        'cbGenTBN
        '
        Me.cbGenTBN.AutoSize = True
        Me.cbGenTBN.Checked = True
        Me.cbGenTBN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGenTBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGenTBN.ForeColor = System.Drawing.Color.Black
        Me.cbGenTBN.Location = New System.Drawing.Point(10, 65)
        Me.cbGenTBN.Name = "cbGenTBN"
        Me.cbGenTBN.Size = New System.Drawing.Size(98, 17)
        Me.cbGenTBN.TabIndex = 125
        Me.cbGenTBN.Text = "Create TBN file"
        Me.cbGenTBN.UseVisualStyleBackColor = True
        '
        'cbOverwriteNFO
        '
        Me.cbOverwriteNFO.AutoSize = True
        Me.cbOverwriteNFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOverwriteNFO.ForeColor = System.Drawing.Color.Black
        Me.cbOverwriteNFO.Location = New System.Drawing.Point(10, 97)
        Me.cbOverwriteNFO.Name = "cbOverwriteNFO"
        Me.cbOverwriteNFO.Size = New System.Drawing.Size(146, 17)
        Me.cbOverwriteNFO.TabIndex = 124
        Me.cbOverwriteNFO.Text = "Overwrite NFO that exists"
        Me.cbOverwriteNFO.UseVisualStyleBackColor = True
        '
        'cbSaveNFO
        '
        Me.cbSaveNFO.AutoSize = True
        Me.cbSaveNFO.Checked = True
        Me.cbSaveNFO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSaveNFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSaveNFO.ForeColor = System.Drawing.Color.Black
        Me.cbSaveNFO.Location = New System.Drawing.Point(10, 81)
        Me.cbSaveNFO.Name = "cbSaveNFO"
        Me.cbSaveNFO.Size = New System.Drawing.Size(95, 17)
        Me.cbSaveNFO.TabIndex = 123
        Me.cbSaveNFO.Text = "Save NFO File"
        Me.cbSaveNFO.UseVisualStyleBackColor = True
        '
        'cbGetFanart
        '
        Me.cbGetFanart.AutoSize = True
        Me.cbGetFanart.Checked = True
        Me.cbGetFanart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGetFanart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGetFanart.ForeColor = System.Drawing.Color.Black
        Me.cbGetFanart.Location = New System.Drawing.Point(10, 48)
        Me.cbGetFanart.Name = "cbGetFanart"
        Me.cbGetFanart.Size = New System.Drawing.Size(76, 17)
        Me.cbGetFanart.TabIndex = 122
        Me.cbGetFanart.Text = "Get Fanart"
        Me.cbGetFanart.UseVisualStyleBackColor = True
        '
        'lblMFL
        '
        Me.lblMFL.AutoSize = True
        Me.lblMFL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFL.Location = New System.Drawing.Point(6, 322)
        Me.lblMFL.Name = "lblMFL"
        Me.lblMFL.Size = New System.Drawing.Size(133, 13)
        Me.lblMFL.TabIndex = 122
        Me.lblMFL.Text = "Movie Folder Location"
        '
        'InitialConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 466)
        Me.Controls.Add(Me.lblMFL)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAddtoclb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.tbFolder)
        Me.Controls.Add(Me.clbPaths)
        Me.Controls.Add(Me.Button6)
        Me.Name = "InitialConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InitialConfig"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbMaxIconsToDisplay As System.Windows.Forms.ComboBox
    Friend WithEvents rbem As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbGetIMDBInfo As System.Windows.Forms.CheckBox
    Friend WithEvents cbDownloadPoster As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cbf2s10 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf2s8 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf2s2 As System.Windows.Forms.CheckBox
    Friend WithEvents cboxType As System.Windows.Forms.ComboBox
    Friend WithEvents cbMaxIconPerStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cbf3s0 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf1s9 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf1s0 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf1s3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbf2s0 As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterH264 As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterLq As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterCustom4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterCustom3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterCustom2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterCustom1 As System.Windows.Forms.CheckBox
    Friend WithEvents tbCustomFilter1 As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomFilter4 As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomFilter3 As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomFilter2 As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterHidef As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilter1080p As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilter720p As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterBluRay As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterAvi As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterXvid As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterDivx As System.Windows.Forms.CheckBox
    Friend WithEvents cbFilterDVD As System.Windows.Forms.CheckBox
    Friend WithEvents tbFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnAddtoclb As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents clbPaths As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbGenTBN As System.Windows.Forms.CheckBox
    Friend WithEvents cbOverwriteNFO As System.Windows.Forms.CheckBox
    Friend WithEvents cbSaveNFO As System.Windows.Forms.CheckBox
    Friend WithEvents cbGetFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbIgnoreYears As System.Windows.Forms.CheckBox
    Friend WithEvents cbIgnore1080i As System.Windows.Forms.CheckBox
    Friend WithEvents cbFanForBack As System.Windows.Forms.CheckBox
    Friend WithEvents lblMFL As System.Windows.Forms.Label
End Class
