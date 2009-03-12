<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parseimdb
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbimdblistfile = New System.Windows.Forms.TextBox
        Me.btnParseIMDB = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnClearTMB = New System.Windows.Forms.Button
        Me.tbSqlQuery = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRunQuery = New System.Windows.Forms.Button
        Me.lblTaglineList = New System.Windows.Forms.Label
        Me.tbTaglineList = New System.Windows.Forms.TextBox
        Me.btnParseTaglineList = New System.Windows.Forms.Button
        Me.btnClearTaglines = New System.Windows.Forms.Button
        Me.btnShowTaglineData = New System.Windows.Forms.Button
        Me.btncreatemtgtables = New System.Windows.Forms.Button
        Me.btnTestArrayFill = New System.Windows.Forms.Button
        Me.tbMovieName = New System.Windows.Forms.TextBox
        Me.btnfindyear = New System.Windows.Forms.Button
        Me.cbLooseName = New System.Windows.Forms.CheckBox
        Me.btnDownloadLists = New System.Windows.Forms.Button
        Me.btnExtractIMDBLists = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnParseHashedFolderIntoIMDBXMLS = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IMDB movie.list File"
        '
        'tbimdblistfile
        '
        Me.tbimdblistfile.Location = New System.Drawing.Point(112, 21)
        Me.tbimdblistfile.Name = "tbimdblistfile"
        Me.tbimdblistfile.Size = New System.Drawing.Size(214, 20)
        Me.tbimdblistfile.TabIndex = 1
        Me.tbimdblistfile.Text = "c:\movieinfoplus\3rdparty\lists\movies.list"
        '
        'btnParseIMDB
        '
        Me.btnParseIMDB.Location = New System.Drawing.Point(327, 19)
        Me.btnParseIMDB.Name = "btnParseIMDB"
        Me.btnParseIMDB.Size = New System.Drawing.Size(80, 23)
        Me.btnParseIMDB.TabIndex = 2
        Me.btnParseIMDB.Text = "Parse Movie"
        Me.btnParseIMDB.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.Location = New System.Drawing.Point(17, 124)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.Size = New System.Drawing.Size(501, 251)
        Me.DataGridView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Show Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClearTMB
        '
        Me.btnClearTMB.Location = New System.Drawing.Point(406, 19)
        Me.btnClearTMB.Name = "btnClearTMB"
        Me.btnClearTMB.Size = New System.Drawing.Size(44, 23)
        Me.btnClearTMB.TabIndex = 5
        Me.btnClearTMB.Text = "Clear the Database"
        Me.btnClearTMB.UseVisualStyleBackColor = True
        '
        'tbSqlQuery
        '
        Me.tbSqlQuery.Location = New System.Drawing.Point(77, 98)
        Me.tbSqlQuery.Name = "tbSqlQuery"
        Me.tbSqlQuery.Size = New System.Drawing.Size(364, 20)
        Me.tbSqlQuery.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SQL Query"
        '
        'btnRunQuery
        '
        Me.btnRunQuery.Location = New System.Drawing.Point(447, 95)
        Me.btnRunQuery.Name = "btnRunQuery"
        Me.btnRunQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnRunQuery.TabIndex = 8
        Me.btnRunQuery.Text = "Run Query"
        Me.btnRunQuery.UseVisualStyleBackColor = True
        '
        'lblTaglineList
        '
        Me.lblTaglineList.AutoSize = True
        Me.lblTaglineList.Location = New System.Drawing.Point(7, 48)
        Me.lblTaglineList.Name = "lblTaglineList"
        Me.lblTaglineList.Size = New System.Drawing.Size(83, 13)
        Me.lblTaglineList.TabIndex = 9
        Me.lblTaglineList.Text = "IMDB tagline.list"
        '
        'tbTaglineList
        '
        Me.tbTaglineList.Location = New System.Drawing.Point(112, 45)
        Me.tbTaglineList.Name = "tbTaglineList"
        Me.tbTaglineList.Size = New System.Drawing.Size(214, 20)
        Me.tbTaglineList.TabIndex = 10
        Me.tbTaglineList.Text = "c:\movieinfoplus\3rdparty\lists\taglines.list"
        '
        'btnParseTaglineList
        '
        Me.btnParseTaglineList.Location = New System.Drawing.Point(327, 43)
        Me.btnParseTaglineList.Name = "btnParseTaglineList"
        Me.btnParseTaglineList.Size = New System.Drawing.Size(80, 23)
        Me.btnParseTaglineList.TabIndex = 11
        Me.btnParseTaglineList.Text = "Parse Tagline"
        Me.btnParseTaglineList.UseVisualStyleBackColor = True
        '
        'btnClearTaglines
        '
        Me.btnClearTaglines.Location = New System.Drawing.Point(407, 43)
        Me.btnClearTaglines.Name = "btnClearTaglines"
        Me.btnClearTaglines.Size = New System.Drawing.Size(43, 23)
        Me.btnClearTaglines.TabIndex = 12
        Me.btnClearTaglines.Text = "Clear"
        Me.btnClearTaglines.UseVisualStyleBackColor = True
        '
        'btnShowTaglineData
        '
        Me.btnShowTaglineData.Location = New System.Drawing.Point(451, 43)
        Me.btnShowTaglineData.Name = "btnShowTaglineData"
        Me.btnShowTaglineData.Size = New System.Drawing.Size(75, 23)
        Me.btnShowTaglineData.TabIndex = 13
        Me.btnShowTaglineData.Text = "Show Data"
        Me.btnShowTaglineData.UseVisualStyleBackColor = True
        '
        'btncreatemtgtables
        '
        Me.btncreatemtgtables.Location = New System.Drawing.Point(4, 81)
        Me.btncreatemtgtables.Name = "btncreatemtgtables"
        Me.btncreatemtgtables.Size = New System.Drawing.Size(144, 21)
        Me.btncreatemtgtables.TabIndex = 14
        Me.btncreatemtgtables.Text = "Step 3) Update database"
        Me.btncreatemtgtables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncreatemtgtables.UseVisualStyleBackColor = True
        '
        'btnTestArrayFill
        '
        Me.btnTestArrayFill.Location = New System.Drawing.Point(394, 72)
        Me.btnTestArrayFill.Name = "btnTestArrayFill"
        Me.btnTestArrayFill.Size = New System.Drawing.Size(128, 22)
        Me.btnTestArrayFill.TabIndex = 15
        Me.btnTestArrayFill.Text = "TestArrayFill"
        Me.btnTestArrayFill.UseVisualStyleBackColor = True
        '
        'tbMovieName
        '
        Me.tbMovieName.Location = New System.Drawing.Point(12, 72)
        Me.tbMovieName.Name = "tbMovieName"
        Me.tbMovieName.Size = New System.Drawing.Size(100, 20)
        Me.tbMovieName.TabIndex = 16
        '
        'btnfindyear
        '
        Me.btnfindyear.Location = New System.Drawing.Point(116, 72)
        Me.btnfindyear.Name = "btnfindyear"
        Me.btnfindyear.Size = New System.Drawing.Size(75, 23)
        Me.btnfindyear.TabIndex = 17
        Me.btnfindyear.Text = "FindYear"
        Me.btnfindyear.UseVisualStyleBackColor = True
        '
        'cbLooseName
        '
        Me.cbLooseName.AutoSize = True
        Me.cbLooseName.Checked = True
        Me.cbLooseName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLooseName.Location = New System.Drawing.Point(197, 76)
        Me.cbLooseName.Name = "cbLooseName"
        Me.cbLooseName.Size = New System.Drawing.Size(114, 17)
        Me.cbLooseName.TabIndex = 18
        Me.cbLooseName.Text = "LooseNameCheck"
        Me.cbLooseName.UseVisualStyleBackColor = True
        '
        'btnDownloadLists
        '
        Me.btnDownloadLists.Location = New System.Drawing.Point(4, 27)
        Me.btnDownloadLists.Name = "btnDownloadLists"
        Me.btnDownloadLists.Size = New System.Drawing.Size(144, 21)
        Me.btnDownloadLists.TabIndex = 19
        Me.btnDownloadLists.Text = "Step 1) Download Lists"
        Me.btnDownloadLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDownloadLists.UseVisualStyleBackColor = True
        '
        'btnExtractIMDBLists
        '
        Me.btnExtractIMDBLists.Location = New System.Drawing.Point(4, 54)
        Me.btnExtractIMDBLists.Name = "btnExtractIMDBLists"
        Me.btnExtractIMDBLists.Size = New System.Drawing.Size(144, 21)
        Me.btnExtractIMDBLists.TabIndex = 20
        Me.btnExtractIMDBLists.Text = "Step 2) Extract Lists"
        Me.btnExtractIMDBLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtractIMDBLists.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExtractIMDBLists)
        Me.GroupBox1.Controls.Add(Me.btncreatemtgtables)
        Me.GroupBox1.Controls.Add(Me.btnDownloadLists)
        Me.GroupBox1.Location = New System.Drawing.Point(524, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 109)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update IMDB Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(566, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(565, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnParseHashedFolderIntoIMDBXMLS
        '
        Me.btnParseHashedFolderIntoIMDBXMLS.Enabled = False
        Me.btnParseHashedFolderIntoIMDBXMLS.Location = New System.Drawing.Point(545, 312)
        Me.btnParseHashedFolderIntoIMDBXMLS.Name = "btnParseHashedFolderIntoIMDBXMLS"
        Me.btnParseHashedFolderIntoIMDBXMLS.Size = New System.Drawing.Size(108, 50)
        Me.btnParseHashedFolderIntoIMDBXMLS.TabIndex = 24
        Me.btnParseHashedFolderIntoIMDBXMLS.Text = "Parse Hashed Folder into imdb xmls"
        Me.btnParseHashedFolderIntoIMDBXMLS.UseVisualStyleBackColor = True
        '
        'parseimdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 387)
        Me.Controls.Add(Me.btnParseHashedFolderIntoIMDBXMLS)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbLooseName)
        Me.Controls.Add(Me.btnfindyear)
        Me.Controls.Add(Me.tbMovieName)
        Me.Controls.Add(Me.btnTestArrayFill)
        Me.Controls.Add(Me.btnShowTaglineData)
        Me.Controls.Add(Me.btnClearTaglines)
        Me.Controls.Add(Me.btnParseTaglineList)
        Me.Controls.Add(Me.tbTaglineList)
        Me.Controls.Add(Me.lblTaglineList)
        Me.Controls.Add(Me.btnRunQuery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSqlQuery)
        Me.Controls.Add(Me.btnClearTMB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnParseIMDB)
        Me.Controls.Add(Me.tbimdblistfile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "parseimdb"
        Me.Text = "parseimdb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbimdblistfile As System.Windows.Forms.TextBox
    Friend WithEvents btnParseIMDB As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClearTMB As System.Windows.Forms.Button
    Friend WithEvents tbSqlQuery As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRunQuery As System.Windows.Forms.Button
    Friend WithEvents lblTaglineList As System.Windows.Forms.Label
    Friend WithEvents tbTaglineList As System.Windows.Forms.TextBox
    Friend WithEvents btnParseTaglineList As System.Windows.Forms.Button
    Friend WithEvents btnClearTaglines As System.Windows.Forms.Button
    Friend WithEvents btnShowTaglineData As System.Windows.Forms.Button
    Friend WithEvents btncreatemtgtables As System.Windows.Forms.Button
    Friend WithEvents btnTestArrayFill As System.Windows.Forms.Button
    Friend WithEvents tbMovieName As System.Windows.Forms.TextBox
    Friend WithEvents btnfindyear As System.Windows.Forms.Button
    Friend WithEvents cbLooseName As System.Windows.Forms.CheckBox
    Friend WithEvents btnDownloadLists As System.Windows.Forms.Button
    Friend WithEvents btnExtractIMDBLists As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnParseHashedFolderIntoIMDBXMLS As System.Windows.Forms.Button
End Class
