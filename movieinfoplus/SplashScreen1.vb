Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    'Const WINK_TIMER_INTERVAL As Integer = 150 ' In milliseconds
    'Protected arrImages(4) As Image
    'Protected intCurrentImage As Integer = 0
    'Protected j As Integer = 1

    'Const BALL_TIMER_INTERVAL As Integer = 25 ' In milliseconds
    'Private intBallSize As Integer = 16 ' As fraction of client area
    'Private intMoveSize As Integer = 4 ' As fraction of ball size
    'Private bitmap As Bitmap
    'Private intBallPositionX, intBallPositionY As Integer
    'Private intBallRadiusX, intBallRadiusY, intBallMoveX, intBallMoveY, _
    '    intBallBitmapWidth, intBallBitmapHeight As Integer
    'Private intBitmapWidthMargin, intBitmapHeightMargin As Integer

    'Const TEXT_TIMER_INTERVAL As Integer = 15 ' In milliseconds
    'Protected intCurrentGradientShift As Integer = 10
    'Protected intGradiantStep As Integer = 5


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'If the application title is missing, use the application name, without the extension
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        'Copyright.Text = My.Application.Info.Copyright

        '' Obtain the Graphics object exposed by the Form.
        'Dim grfx As Graphics = CreateGraphics()

        '' Set the font type, text, and determine its size.
        'Dim font As New Font("Microsoft Sans Serif", 32, _
        '    FontStyle.Bold, GraphicsUnit.Point)
        'Dim strText As String = "Media Info Plus"
        'Dim sizfText As New SizeF(grfx.MeasureString(strText, font))

        '' Set the point at which the text will be drawn: centered
        '' in the client area.
        'Dim ptfTextStart As New PointF( _
        '    CSng(ClientSize.Width - sizfText.Width) / 2, _
        '    CSng(ClientSize.Height - sizfText.Height) / 2)

        '' Set the gradient start and end point, the latter being adjusted
        '' by a changing value to give the animation affect.
        'Dim ptfGradientStart As New PointF(0, 0)
        'Dim ptfGradientEnd As New PointF(intCurrentGradientShift, 200)

        '' Instantiate the brush used for drawing the text.
        'Dim grBrush As New LinearGradientBrush(ptfGradientStart, _
        '    ptfGradientEnd, Color.Blue, BackColor)

        '' Draw the text centered on the client area.
        'grfx.DrawString(strText, font, grBrush, ptfTextStart)

        'grfx.Dispose()

        '' Shift the gradient, reversing it when it gets to a certain value.
        'intCurrentGradientShift += intGradiantStep
        'If intCurrentGradientShift = 500 Then
        '    intGradiantStep = -5
        'ElseIf intCurrentGradientShift = -50 Then
        '    intGradiantStep = 5
        'End If
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
