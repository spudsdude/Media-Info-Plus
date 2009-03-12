<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mymovies
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
        Me.lbMyMovies = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbMoviesWithIssues = New System.Windows.Forms.ListBox
        Me.cbMyMoves = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lbMyMovies
        '
        Me.lbMyMovies.FormattingEnabled = True
        Me.lbMyMovies.Location = New System.Drawing.Point(12, 12)
        Me.lbMyMovies.Name = "lbMyMovies"
        Me.lbMyMovies.Size = New System.Drawing.Size(272, 485)
        Me.lbMyMovies.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(290, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbMoviesWithIssues
        '
        Me.lbMoviesWithIssues.FormattingEnabled = True
        Me.lbMoviesWithIssues.Location = New System.Drawing.Point(397, 13)
        Me.lbMoviesWithIssues.Name = "lbMoviesWithIssues"
        Me.lbMoviesWithIssues.Size = New System.Drawing.Size(276, 485)
        Me.lbMoviesWithIssues.TabIndex = 5
        '
        'cbMyMoves
        '
        Me.cbMyMoves.FormattingEnabled = True
        Me.cbMyMoves.Location = New System.Drawing.Point(308, 135)
        Me.cbMyMoves.Name = "cbMyMoves"
        Me.cbMyMoves.Size = New System.Drawing.Size(259, 21)
        Me.cbMyMoves.TabIndex = 6
        '
        'mymovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 626)
        Me.Controls.Add(Me.cbMyMoves)
        Me.Controls.Add(Me.lbMoviesWithIssues)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbMyMovies)
        Me.Name = "mymovies"
        Me.Text = "mymovies"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbMyMovies As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbMoviesWithIssues As System.Windows.Forms.ListBox
    Friend WithEvents cbMyMoves As System.Windows.Forms.ComboBox
End Class
