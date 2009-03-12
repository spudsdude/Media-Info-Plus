<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectMovie
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
        Me.dgMoviePicker = New System.Windows.Forms.DataGridView
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        CType(Me.dgMoviePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMoviePicker
        '
        Me.dgMoviePicker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMoviePicker.Location = New System.Drawing.Point(12, 56)
        Me.dgMoviePicker.Name = "dgMoviePicker"
        Me.dgMoviePicker.Size = New System.Drawing.Size(479, 198)
        Me.dgMoviePicker.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(479, 49)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "More then one movie was found with that name, please select it from the list. If " & _
            "you want to use strict matching, please enable strict movie names in the configu" & _
            "ration."
        '
        'selectMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 266)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.dgMoviePicker)
        Me.Name = "selectMovie"
        Me.Text = "selectMovie"
        CType(Me.dgMoviePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMoviePicker As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
