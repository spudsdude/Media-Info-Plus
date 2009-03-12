Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class linkedimage
    Inherits System.Windows.Forms.PictureBox 'ComponentFactory.Krypton.Toolkit.KryptonGroup 'CheckBox

    Dim m_hover As Boolean = False

    Public Sub New()
        'Me.Appearance = Appearance.Button
    End Sub
    Public Event SomethingHappened(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub Button1_Click(ByVal sender As Object, ByVal eventargs As System.EventArgs) Handles MyClass.Click

        RaiseEvent SomethingHappened(Me, eventargs.Empty)
    End Sub
    'End Class
    'OnPaintBackground(PaintEventArgs 

    ''/#
    'Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
    '    Get
    '        'Dim SecPerm As New SecurityPermission(SecurityPermissionFlag.UnmanagedCode)
    '        'SecPerm.Demand()

    '        ' Extend the CreateParams property of the Button class.
    '        Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
    '        ' Update the button Style.
    '        'cp.ExStyle = 'CInt("0x00000020") 'Style = cp.Style Or &H40 ' BS_ICON value

    '        Return cp
    '    End Get
    'End Property


    'Protected Overrides Sub CreateParams(ByVal CreateParams As )
    '    '#
    '    ' {
    '    '#
    '        get
    '    '#
    '    '  {
    '    '#
    '    CreateParams(CreateParams = base.CreateParams)
    '    '#
    '            createParams.ExStyle |= 0x00000020; '// WS_EX_TRANSPARENT
    '    '#
    '    Return CreateParams
    '    '#
    '    '            }
    '    '#
    '    '       }
    'End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        '    If (Me.Checked) Then

        '        Using lgb As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(223, 236, 250), Color.FromArgb(178, 214, 252), LinearGradientMode.Vertical)
        '            pevent.Graphics.FillRectangle(lgb, Me.ClientRectangle)
        '        End Using
        '        Using p As New Pen(Color.FromArgb(97, 175, 254))
        '            Dim r As New Rectangle(0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
        '            pevent.Graphics.DrawRectangle(p, r)
        '        End Using
        '    Else
        '        If (m_hover) Then
        '            Using lgb As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(238, 245, 253), Color.FromArgb(208, 229, 251), LinearGradientMode.Vertical)
        '                pevent.Graphics.FillRectangle(lgb, Me.ClientRectangle)
        '            End Using
        '            Using p As New Pen(Color.FromArgb(170, 212, 252))
        '                Dim r As New Rectangle(0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
        '                pevent.Graphics.DrawRectangle(p, r)
        '            End Using
        '        Else
        '            pevent.Graphics.Clear(Me.BackColor)
        '        End If
        '    End If

        '    'Center image
        '    Dim x As Integer = CInt((Me.ClientRectangle.Width - Me.StateCommon.Back.Image.Width) / 2)
        '    Dim y As Integer = CInt((Me.ClientRectangle.Height - Me.StateCommon.Back.Image.Height) / 2)

        '    pevent.Graphics.DrawImage(Me.StateCommon.Back.Image, New Rectangle(x, y, Me.StateCommon.Back.Image.Width, Me.StateCommon.Back.Image.Height), New Rectangle(0, 0, Me.StateCommon.Back.Image.Width, Me.StateCommon.Back.Image.Height), GraphicsUnit.Pixel)
    End Sub


    Protected Overrides Sub OnMouseEnter(ByVal eventargs As System.EventArgs)

        'If MouseEventArgs.Button = MouseButtons.Right Then
        'MsgBox("hi" + Me.Tag.ToString)
        'If Not clbPaths.SelectedIndex = -1 Then
        '    If MsgBox("Folder Removal Confirmation: Are you sure you want to remove the following folder?" + vbNewLine + vbNewLine + clbPaths.SelectedItem.ToString, MsgBoxStyle.YesNo, "Confirm Removal of Movie folder") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    clbPaths.Items.RemoveAt(clbPaths.SelectedIndex)
        'End If
        'End If  'OnMouseClick()

        '    MyBase.OnMouseEnter(eventargs)
        '    Debug.Print("hovered")
        '    m_hover = True
        '    Debug.Print(Me.Tag.ToString)
        '    Me.Text = "hey!:"
        '    Me.BackColor = Color.CornflowerBlue
        Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D 'Border.Width = 8
        '    'Me.StateCommon.Border.Color1 = Color.Gold
        '    Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal eventargs As System.EventArgs)
        '    '    MyBase.OnMouseLeave(eventargs)
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        '    '    m_hover = False
        '    '    Me.BackColor = Nothing
        '    '    Me.StateCommon.Border.Width = Nothing
        '    '    Me.Invalidate()
    End Sub
    'Protected Overrides Sub OnMouseDown(ByVal eventargs As System.EventArgs)
    '    '    MyBase.OnMouseLeave(eventargs)
    '    MsgBox("hi" + Me.Tag.ToString)
    '    '    m_hover = False
    '    '    Me.BackColor = Nothing
    '    '    Me.StateCommon.Border.Width = Nothing
    '    '    Me.Invalidate()
    'End Sub


End Class

