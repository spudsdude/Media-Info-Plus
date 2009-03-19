<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autopilotdialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(autopilotdialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.rbp1 = New System.Windows.Forms.RadioButton
        Me.btnStartProcessing = New System.Windows.Forms.Button
        Me.rbp2 = New System.Windows.Forms.RadioButton
        Me.rbp3 = New System.Windows.Forms.RadioButton
        Me.rbp4 = New System.Windows.Forms.RadioButton
        Me.rbp5 = New System.Windows.Forms.RadioButton
        Me.rbp6 = New System.Windows.Forms.RadioButton
        Me.rbp7 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbs9 = New System.Windows.Forms.RadioButton
        Me.rbs8 = New System.Windows.Forms.RadioButton
        Me.rbs6 = New System.Windows.Forms.RadioButton
        Me.rbs7 = New System.Windows.Forms.RadioButton
        Me.rbs1 = New System.Windows.Forms.RadioButton
        Me.rbs2 = New System.Windows.Forms.RadioButton
        Me.rbs3 = New System.Windows.Forms.RadioButton
        Me.rbs5 = New System.Windows.Forms.RadioButton
        Me.rbs4 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbp9 = New System.Windows.Forms.RadioButton
        Me.rbp8 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboverwriteexistingicons = New System.Windows.Forms.CheckBox
        Me.cboverwritenfo = New System.Windows.Forms.CheckBox
        Me.cbcreatenfo = New System.Windows.Forms.CheckBox
        Me.cbimpaposter = New System.Windows.Forms.CheckBox
        Me.cbmeligrovefanart = New System.Windows.Forms.CheckBox
        Me.cbcreatetbn = New System.Windows.Forms.CheckBox
        Me.pbprimaryiconsquare = New System.Windows.Forms.PictureBox
        Me.pbprimaryposter = New System.Windows.Forms.PictureBox
        Me.pbprimaryiconwide = New System.Windows.Forms.PictureBox
        Me.pbsecondaryiconwide = New System.Windows.Forms.PictureBox
        Me.pbsecondaryposter = New System.Windows.Forms.PictureBox
        Me.pbsecondaryiconsquare = New System.Windows.Forms.PictureBox
        Me.btnMediaDataOnly = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbprimaryiconsquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbprimaryposter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbprimaryiconwide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsecondaryiconwide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsecondaryposter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsecondaryiconsquare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(580, 409)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.TableLayoutPanel1.Visible = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.Visible = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(684, 320)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'rbp1
        '
        Me.rbp1.AutoSize = True
        Me.rbp1.Location = New System.Drawing.Point(6, 19)
        Me.rbp1.Name = "rbp1"
        Me.rbp1.Size = New System.Drawing.Size(80, 17)
        Me.rbp1.TabIndex = 2
        Me.rbp1.TabStop = True
        Me.rbp1.Text = "Square Box"
        Me.rbp1.UseVisualStyleBackColor = True
        '
        'btnStartProcessing
        '
        Me.btnStartProcessing.Location = New System.Drawing.Point(542, 321)
        Me.btnStartProcessing.Name = "btnStartProcessing"
        Me.btnStartProcessing.Size = New System.Drawing.Size(133, 23)
        Me.btnStartProcessing.TabIndex = 3
        Me.btnStartProcessing.Text = "Start Processing"
        Me.btnStartProcessing.UseVisualStyleBackColor = True
        '
        'rbp2
        '
        Me.rbp2.AutoSize = True
        Me.rbp2.Location = New System.Drawing.Point(6, 42)
        Me.rbp2.Name = "rbp2"
        Me.rbp2.Size = New System.Drawing.Size(55, 17)
        Me.rbp2.TabIndex = 4
        Me.rbp2.TabStop = True
        Me.rbp2.Text = "Poster"
        Me.rbp2.UseVisualStyleBackColor = True
        '
        'rbp3
        '
        Me.rbp3.AutoSize = True
        Me.rbp3.Location = New System.Drawing.Point(6, 65)
        Me.rbp3.Name = "rbp3"
        Me.rbp3.Size = New System.Drawing.Size(83, 17)
        Me.rbp3.TabIndex = 14
        Me.rbp3.TabStop = True
        Me.rbp3.Text = "3d Box Shot"
        Me.rbp3.UseVisualStyleBackColor = True
        '
        'rbp4
        '
        Me.rbp4.AutoSize = True
        Me.rbp4.Location = New System.Drawing.Point(6, 88)
        Me.rbp4.Name = "rbp4"
        Me.rbp4.Size = New System.Drawing.Size(123, 17)
        Me.rbp4.TabIndex = 15
        Me.rbp4.TabStop = True
        Me.rbp4.Text = "Wide Icon - No Sytle"
        Me.rbp4.UseVisualStyleBackColor = True
        '
        'rbp5
        '
        Me.rbp5.AutoSize = True
        Me.rbp5.Location = New System.Drawing.Point(6, 111)
        Me.rbp5.Name = "rbp5"
        Me.rbp5.Size = New System.Drawing.Size(181, 17)
        Me.rbp5.TabIndex = 16
        Me.rbp5.TabStop = True
        Me.rbp5.Text = "Wide Icon - Rounded Shadowed"
        Me.rbp5.UseVisualStyleBackColor = True
        '
        'rbp6
        '
        Me.rbp6.AutoSize = True
        Me.rbp6.Location = New System.Drawing.Point(6, 134)
        Me.rbp6.Name = "rbp6"
        Me.rbp6.Size = New System.Drawing.Size(234, 17)
        Me.rbp6.TabIndex = 17
        Me.rbp6.TabStop = True
        Me.rbp6.Text = "Wide Icon - Rounded Shadow w/ Scanlines"
        Me.rbp6.UseVisualStyleBackColor = True
        '
        'rbp7
        '
        Me.rbp7.AutoSize = True
        Me.rbp7.Location = New System.Drawing.Point(6, 157)
        Me.rbp7.Name = "rbp7"
        Me.rbp7.Size = New System.Drawing.Size(253, 17)
        Me.rbp7.TabIndex = 19
        Me.rbp7.TabStop = True
        Me.rbp7.Text = "Wide Icon - Rounded Shadow w/ Glass Overlay"
        Me.rbp7.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbs9)
        Me.GroupBox1.Controls.Add(Me.rbs8)
        Me.GroupBox1.Controls.Add(Me.rbs6)
        Me.GroupBox1.Controls.Add(Me.rbs7)
        Me.GroupBox1.Controls.Add(Me.rbs1)
        Me.GroupBox1.Controls.Add(Me.rbs2)
        Me.GroupBox1.Controls.Add(Me.rbs3)
        Me.GroupBox1.Controls.Add(Me.rbs5)
        Me.GroupBox1.Controls.Add(Me.rbs4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 233)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Secondary Image Choice"
        '
        'rbs9
        '
        Me.rbs9.AutoSize = True
        Me.rbs9.Location = New System.Drawing.Point(6, 201)
        Me.rbs9.Name = "rbs9"
        Me.rbs9.Size = New System.Drawing.Size(51, 17)
        Me.rbs9.TabIndex = 29
        Me.rbs9.TabStop = True
        Me.rbs9.Text = "None"
        Me.rbs9.UseVisualStyleBackColor = True
        '
        'rbs8
        '
        Me.rbs8.AutoSize = True
        Me.rbs8.Enabled = False
        Me.rbs8.Location = New System.Drawing.Point(6, 179)
        Me.rbs8.Name = "rbs8"
        Me.rbs8.Size = New System.Drawing.Size(63, 17)
        Me.rbs8.TabIndex = 28
        Me.rbs8.TabStop = True
        Me.rbs8.Text = "Tall Box"
        Me.rbs8.UseVisualStyleBackColor = True
        Me.rbs8.Visible = False
        '
        'rbs6
        '
        Me.rbs6.AutoSize = True
        Me.rbs6.Location = New System.Drawing.Point(6, 133)
        Me.rbs6.Name = "rbs6"
        Me.rbs6.Size = New System.Drawing.Size(234, 17)
        Me.rbs6.TabIndex = 26
        Me.rbs6.TabStop = True
        Me.rbs6.Text = "Wide Icon - Rounded Shadow w/ Scanlines"
        Me.rbs6.UseVisualStyleBackColor = True
        '
        'rbs7
        '
        Me.rbs7.AutoSize = True
        Me.rbs7.Location = New System.Drawing.Point(6, 156)
        Me.rbs7.Name = "rbs7"
        Me.rbs7.Size = New System.Drawing.Size(253, 17)
        Me.rbs7.TabIndex = 27
        Me.rbs7.TabStop = True
        Me.rbs7.Text = "Wide Icon - Rounded Shadow w/ Glass Overlay"
        Me.rbs7.UseVisualStyleBackColor = True
        '
        'rbs1
        '
        Me.rbs1.AutoSize = True
        Me.rbs1.Location = New System.Drawing.Point(6, 18)
        Me.rbs1.Name = "rbs1"
        Me.rbs1.Size = New System.Drawing.Size(80, 17)
        Me.rbs1.TabIndex = 21
        Me.rbs1.TabStop = True
        Me.rbs1.Text = "Square Box"
        Me.rbs1.UseVisualStyleBackColor = True
        '
        'rbs2
        '
        Me.rbs2.AutoSize = True
        Me.rbs2.Location = New System.Drawing.Point(6, 41)
        Me.rbs2.Name = "rbs2"
        Me.rbs2.Size = New System.Drawing.Size(55, 17)
        Me.rbs2.TabIndex = 22
        Me.rbs2.TabStop = True
        Me.rbs2.Text = "Poster"
        Me.rbs2.UseVisualStyleBackColor = True
        '
        'rbs3
        '
        Me.rbs3.AutoSize = True
        Me.rbs3.Location = New System.Drawing.Point(6, 64)
        Me.rbs3.Name = "rbs3"
        Me.rbs3.Size = New System.Drawing.Size(83, 17)
        Me.rbs3.TabIndex = 23
        Me.rbs3.TabStop = True
        Me.rbs3.Text = "3d Box Shot"
        Me.rbs3.UseVisualStyleBackColor = True
        '
        'rbs5
        '
        Me.rbs5.AutoSize = True
        Me.rbs5.Location = New System.Drawing.Point(6, 110)
        Me.rbs5.Name = "rbs5"
        Me.rbs5.Size = New System.Drawing.Size(181, 17)
        Me.rbs5.TabIndex = 25
        Me.rbs5.TabStop = True
        Me.rbs5.Text = "Wide Icon - Rounded Shadowed"
        Me.rbs5.UseVisualStyleBackColor = True
        '
        'rbs4
        '
        Me.rbs4.AutoSize = True
        Me.rbs4.Location = New System.Drawing.Point(6, 87)
        Me.rbs4.Name = "rbs4"
        Me.rbs4.Size = New System.Drawing.Size(123, 17)
        Me.rbs4.TabIndex = 24
        Me.rbs4.TabStop = True
        Me.rbs4.Text = "Wide Icon - No Sytle"
        Me.rbs4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbp9)
        Me.GroupBox2.Controls.Add(Me.rbp8)
        Me.GroupBox2.Controls.Add(Me.rbp6)
        Me.GroupBox2.Controls.Add(Me.rbp7)
        Me.GroupBox2.Controls.Add(Me.rbp1)
        Me.GroupBox2.Controls.Add(Me.rbp2)
        Me.GroupBox2.Controls.Add(Me.rbp3)
        Me.GroupBox2.Controls.Add(Me.rbp5)
        Me.GroupBox2.Controls.Add(Me.rbp4)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 241)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Primary Image Choice"
        '
        'rbp9
        '
        Me.rbp9.AutoSize = True
        Me.rbp9.Location = New System.Drawing.Point(6, 203)
        Me.rbp9.Name = "rbp9"
        Me.rbp9.Size = New System.Drawing.Size(155, 17)
        Me.rbp9.TabIndex = 21
        Me.rbp9.TabStop = True
        Me.rbp9.Text = "Do Not Assign New Images"
        Me.rbp9.UseVisualStyleBackColor = True
        '
        'rbp8
        '
        Me.rbp8.AutoSize = True
        Me.rbp8.Enabled = False
        Me.rbp8.Location = New System.Drawing.Point(6, 180)
        Me.rbp8.Name = "rbp8"
        Me.rbp8.Size = New System.Drawing.Size(63, 17)
        Me.rbp8.TabIndex = 20
        Me.rbp8.TabStop = True
        Me.rbp8.Text = "Tall Box"
        Me.rbp8.UseVisualStyleBackColor = True
        Me.rbp8.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cboverwriteexistingicons)
        Me.GroupBox3.Controls.Add(Me.cboverwritenfo)
        Me.GroupBox3.Controls.Add(Me.cbcreatenfo)
        Me.GroupBox3.Controls.Add(Me.cbimpaposter)
        Me.GroupBox3.Controls.Add(Me.cbmeligrovefanart)
        Me.GroupBox3.Location = New System.Drawing.Point(539, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 140)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Settings"
        '
        'cboverwriteexistingicons
        '
        Me.cboverwriteexistingicons.AutoSize = True
        Me.cboverwriteexistingicons.Location = New System.Drawing.Point(7, 105)
        Me.cboverwriteexistingicons.Name = "cboverwriteexistingicons"
        Me.cboverwriteexistingicons.Size = New System.Drawing.Size(211, 30)
        Me.cboverwriteexistingicons.TabIndex = 3
        Me.cboverwriteexistingicons.Text = "Overwrite Movie Image if it exsists" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(folder.jpg movie.tbn <moviename>.tbn)"
        Me.cboverwriteexistingicons.UseVisualStyleBackColor = True
        '
        'cboverwritenfo
        '
        Me.cboverwritenfo.AutoSize = True
        Me.cboverwritenfo.Location = New System.Drawing.Point(7, 82)
        Me.cboverwritenfo.Name = "cboverwritenfo"
        Me.cboverwritenfo.Size = New System.Drawing.Size(142, 17)
        Me.cboverwritenfo.TabIndex = 1
        Me.cboverwritenfo.Text = "Overwrite .nfo if it exsists"
        Me.cboverwritenfo.UseVisualStyleBackColor = True
        '
        'cbcreatenfo
        '
        Me.cbcreatenfo.AutoSize = True
        Me.cbcreatenfo.Checked = True
        Me.cbcreatenfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcreatenfo.Location = New System.Drawing.Point(7, 60)
        Me.cbcreatenfo.Name = "cbcreatenfo"
        Me.cbcreatenfo.Size = New System.Drawing.Size(94, 17)
        Me.cbcreatenfo.TabIndex = 0
        Me.cbcreatenfo.Text = "Create .nfo file"
        Me.cbcreatenfo.UseVisualStyleBackColor = True
        '
        'cbimpaposter
        '
        Me.cbimpaposter.AutoSize = True
        Me.cbimpaposter.Checked = True
        Me.cbimpaposter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbimpaposter.Location = New System.Drawing.Point(7, 16)
        Me.cbimpaposter.Name = "cbimpaposter"
        Me.cbimpaposter.Size = New System.Drawing.Size(177, 17)
        Me.cbimpaposter.TabIndex = 0
        Me.cbimpaposter.Text = "Use Poster from impawards.com"
        Me.cbimpaposter.UseVisualStyleBackColor = True
        '
        'cbmeligrovefanart
        '
        Me.cbmeligrovefanart.AutoSize = True
        Me.cbmeligrovefanart.Checked = True
        Me.cbmeligrovefanart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbmeligrovefanart.Location = New System.Drawing.Point(7, 37)
        Me.cbmeligrovefanart.Name = "cbmeligrovefanart"
        Me.cbmeligrovefanart.Size = New System.Drawing.Size(110, 17)
        Me.cbmeligrovefanart.TabIndex = 1
        Me.cbmeligrovefanart.Text = "Get TMDB Fanart"
        Me.cbmeligrovefanart.UseVisualStyleBackColor = True
        '
        'cbcreatetbn
        '
        Me.cbcreatetbn.AutoSize = True
        Me.cbcreatetbn.Checked = True
        Me.cbcreatetbn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbcreatetbn.Location = New System.Drawing.Point(600, 4)
        Me.cbcreatetbn.Name = "cbcreatetbn"
        Me.cbcreatetbn.Size = New System.Drawing.Size(94, 17)
        Me.cbcreatetbn.TabIndex = 2
        Me.cbcreatetbn.Text = "Create .tbn file"
        Me.cbcreatetbn.UseVisualStyleBackColor = True
        Me.cbcreatetbn.Visible = False
        '
        'pbprimaryiconsquare
        '
        Me.pbprimaryiconsquare.BackColor = System.Drawing.Color.Transparent
        Me.pbprimaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.bspb1
        Me.pbprimaryiconsquare.Location = New System.Drawing.Point(280, 2)
        Me.pbprimaryiconsquare.MaximumSize = New System.Drawing.Size(256, 240)
        Me.pbprimaryiconsquare.Name = "pbprimaryiconsquare"
        Me.pbprimaryiconsquare.Size = New System.Drawing.Size(256, 240)
        Me.pbprimaryiconsquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbprimaryiconsquare.TabIndex = 25
        Me.pbprimaryiconsquare.TabStop = False
        Me.pbprimaryiconsquare.Visible = False
        '
        'pbprimaryposter
        '
        Me.pbprimaryposter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbprimaryposter.Image = Global.movieinfoplus.My.Resources.Resources.poster
        Me.pbprimaryposter.Location = New System.Drawing.Point(314, 1)
        Me.pbprimaryposter.Name = "pbprimaryposter"
        Me.pbprimaryposter.Size = New System.Drawing.Size(190, 240)
        Me.pbprimaryposter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbprimaryposter.TabIndex = 27
        Me.pbprimaryposter.TabStop = False
        Me.pbprimaryposter.Visible = False
        '
        'pbprimaryiconwide
        '
        Me.pbprimaryiconwide.BackColor = System.Drawing.Color.Transparent
        Me.pbprimaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s0
        Me.pbprimaryiconwide.InitialImage = Nothing
        Me.pbprimaryiconwide.Location = New System.Drawing.Point(293, 70)
        Me.pbprimaryiconwide.Name = "pbprimaryiconwide"
        Me.pbprimaryiconwide.Size = New System.Drawing.Size(458, 98)
        Me.pbprimaryiconwide.TabIndex = 28
        Me.pbprimaryiconwide.TabStop = False
        Me.pbprimaryiconwide.Visible = False
        '
        'pbsecondaryiconwide
        '
        Me.pbsecondaryiconwide.BackColor = System.Drawing.Color.Transparent
        Me.pbsecondaryiconwide.Image = Global.movieinfoplus.My.Resources.Resources.f2s0
        Me.pbsecondaryiconwide.InitialImage = Nothing
        Me.pbsecondaryiconwide.Location = New System.Drawing.Point(293, 351)
        Me.pbsecondaryiconwide.Name = "pbsecondaryiconwide"
        Me.pbsecondaryiconwide.Size = New System.Drawing.Size(458, 98)
        Me.pbsecondaryiconwide.TabIndex = 31
        Me.pbsecondaryiconwide.TabStop = False
        Me.pbsecondaryiconwide.Visible = False
        '
        'pbsecondaryposter
        '
        Me.pbsecondaryposter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbsecondaryposter.Image = Global.movieinfoplus.My.Resources.Resources.poster
        Me.pbsecondaryposter.Location = New System.Drawing.Point(314, 244)
        Me.pbsecondaryposter.Name = "pbsecondaryposter"
        Me.pbsecondaryposter.Size = New System.Drawing.Size(190, 230)
        Me.pbsecondaryposter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbsecondaryposter.TabIndex = 30
        Me.pbsecondaryposter.TabStop = False
        Me.pbsecondaryposter.Visible = False
        '
        'pbsecondaryiconsquare
        '
        Me.pbsecondaryiconsquare.BackColor = System.Drawing.Color.Transparent
        Me.pbsecondaryiconsquare.Image = Global.movieinfoplus.My.Resources.Resources.bspb1
        Me.pbsecondaryiconsquare.Location = New System.Drawing.Point(280, 245)
        Me.pbsecondaryiconsquare.MaximumSize = New System.Drawing.Size(256, 240)
        Me.pbsecondaryiconsquare.Name = "pbsecondaryiconsquare"
        Me.pbsecondaryiconsquare.Size = New System.Drawing.Size(256, 230)
        Me.pbsecondaryiconsquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbsecondaryiconsquare.TabIndex = 29
        Me.pbsecondaryiconsquare.TabStop = False
        Me.pbsecondaryiconsquare.Visible = False
        '
        'btnMediaDataOnly
        '
        Me.btnMediaDataOnly.Location = New System.Drawing.Point(546, 20)
        Me.btnMediaDataOnly.Name = "btnMediaDataOnly"
        Me.btnMediaDataOnly.Size = New System.Drawing.Size(218, 45)
        Me.btnMediaDataOnly.TabIndex = 32
        Me.btnMediaDataOnly.Text = "Update Media Information Only!"
        Me.btnMediaDataOnly.Values.ExtraText = ""
        Me.btnMediaDataOnly.Values.Image = Nothing
        Me.btnMediaDataOnly.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnMediaDataOnly.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnMediaDataOnly.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnMediaDataOnly.Values.Text = "Update Media Information Only!"
        '
        'autopilotdialog
        '
        Me.AcceptButton = Me.btnStartProcessing
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(776, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMediaDataOnly)
        Me.Controls.Add(Me.pbsecondaryiconwide)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.cbcreatetbn)
        Me.Controls.Add(Me.pbsecondaryposter)
        Me.Controls.Add(Me.pbsecondaryiconsquare)
        Me.Controls.Add(Me.pbprimaryiconwide)
        Me.Controls.Add(Me.pbprimaryposter)
        Me.Controls.Add(Me.pbprimaryiconsquare)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStartProcessing)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "autopilotdialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auto Pilot Wizard - Automatically Process Movies and apply the following to those" & _
            " Movies"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbprimaryiconsquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbprimaryposter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbprimaryiconwide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsecondaryiconwide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsecondaryposter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsecondaryiconsquare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rbp1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnStartProcessing As System.Windows.Forms.Button
    Friend WithEvents rbp2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp7 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbimpaposter As System.Windows.Forms.CheckBox
    Friend WithEvents cbmeligrovefanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbcreatetbn As System.Windows.Forms.CheckBox
    Friend WithEvents cboverwritenfo As System.Windows.Forms.CheckBox
    Friend WithEvents cbcreatenfo As System.Windows.Forms.CheckBox
    Friend WithEvents rbs8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs7 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbs4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbp8 As System.Windows.Forms.RadioButton
    Friend WithEvents pbprimaryiconsquare As System.Windows.Forms.PictureBox
    Friend WithEvents pbprimaryposter As System.Windows.Forms.PictureBox
    Friend WithEvents pbprimaryiconwide As System.Windows.Forms.PictureBox
    Friend WithEvents pbsecondaryiconwide As System.Windows.Forms.PictureBox
    Friend WithEvents pbsecondaryposter As System.Windows.Forms.PictureBox
    Friend WithEvents pbsecondaryiconsquare As System.Windows.Forms.PictureBox
    Friend WithEvents rbs9 As System.Windows.Forms.RadioButton
    Friend WithEvents cboverwriteexistingicons As System.Windows.Forms.CheckBox
    Friend WithEvents rbp9 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMediaDataOnly As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
