<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saveaswhaticontype
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
        Me.rbsaveasfolderjpg = New System.Windows.Forms.RadioButton
        Me.rbsaveastbn = New System.Windows.Forms.RadioButton
        Me.rbsaveasboth = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 87)
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
        'rbsaveasfolderjpg
        '
        Me.rbsaveasfolderjpg.AutoSize = True
        Me.rbsaveasfolderjpg.Location = New System.Drawing.Point(12, 12)
        Me.rbsaveasfolderjpg.Name = "rbsaveasfolderjpg"
        Me.rbsaveasfolderjpg.Size = New System.Drawing.Size(68, 17)
        Me.rbsaveasfolderjpg.TabIndex = 1
        Me.rbsaveasfolderjpg.TabStop = True
        Me.rbsaveasfolderjpg.Text = "folder.jpg"
        Me.rbsaveasfolderjpg.UseVisualStyleBackColor = True
        '
        'rbsaveastbn
        '
        Me.rbsaveastbn.AutoSize = True
        Me.rbsaveastbn.Location = New System.Drawing.Point(12, 35)
        Me.rbsaveastbn.Name = "rbsaveastbn"
        Me.rbsaveastbn.Size = New System.Drawing.Size(179, 17)
        Me.rbsaveastbn.TabIndex = 2
        Me.rbsaveastbn.TabStop = True
        Me.rbsaveastbn.Text = "movie.tbn and <moviename>.tbn"
        Me.rbsaveastbn.UseVisualStyleBackColor = True
        '
        'rbsaveasboth
        '
        Me.rbsaveasboth.AutoSize = True
        Me.rbsaveasboth.Location = New System.Drawing.Point(12, 58)
        Me.rbsaveasboth.Name = "rbsaveasboth"
        Me.rbsaveasboth.Size = New System.Drawing.Size(47, 17)
        Me.rbsaveasboth.TabIndex = 3
        Me.rbsaveasboth.TabStop = True
        Me.rbsaveasboth.Text = "Both"
        Me.rbsaveasboth.UseVisualStyleBackColor = True
        '
        'saveaswhaticontype
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(208, 124)
        Me.Controls.Add(Me.rbsaveasboth)
        Me.Controls.Add(Me.rbsaveastbn)
        Me.Controls.Add(Me.rbsaveasfolderjpg)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "saveaswhaticontype"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "What image are we saving?"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rbsaveasfolderjpg As System.Windows.Forms.RadioButton
    Friend WithEvents rbsaveastbn As System.Windows.Forms.RadioButton
    Friend WithEvents rbsaveasboth As System.Windows.Forms.RadioButton

End Class
