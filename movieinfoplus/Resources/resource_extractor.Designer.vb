<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resource_extractor
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
        Me.btnGo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(126, 61)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'resource_extractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "resource_extractor"
        Me.Text = "resource_extractor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
End Class
