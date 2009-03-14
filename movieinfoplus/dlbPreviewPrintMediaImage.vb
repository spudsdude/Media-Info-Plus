Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class dlgPreviewPrintMediaImage

    Dim tempCnt As Boolean         'check weather the roller is used or not

    Dim bm_dest As Bitmap
    Dim bm_source As Bitmap
    Dim i As Int16 = CShort(0.5)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.pbNewImage.Image = Nothing
    End Sub

#Region "Image Resizing"
    'Private Sub resizingTrackBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resizingTrackBar.ValueChanged
    '    Try

    '        Dim scale_factor As Integer
    '        Dim img1 As New PictureBox

    '        scale_factor = Integer.Parse(CStr(resizingTrackBar.Value))
    '        img1.Image = cropBitmap
    '        bm_source = New Bitmap(img1.Image)
    '        bm_dest = New Bitmap( _
    '            CInt(bm_source.Width * scale_factor), _
    '            CInt(bm_source.Height * scale_factor))

    '        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

    '        gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + i, bm_dest.Height + i)

    '        pbNewImage.Image = bm_dest

    '        tempCnt = True
    '    Catch ex As Exception

    '    End Try
    'End Sub
#End Region

#Region "Image Cropping"
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Yellow

    Private Sub pbMainImage_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) ' Handles pbMainImage.MouseDown
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            pbMainImage.Refresh()
        Catch exc As Exception
        End Try
    End Sub
    Dim tmppoint As Point
    Private Sub pbMainImage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'Handles pbMainImage.MouseMove
        Try

            If pbMainImage.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                pbMainImage.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                pbMainImage.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try

    End Sub

    Private Sub pbMainImage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) ' Handles pbMainImage.MouseUp
        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(pbMainImage.Image, pbMainImage.Width, pbMainImage.Height)

                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                pbNewImage.Image = cropBitmap

            Catch exc As Exception
            End Try
        Catch exc As Exception
        End Try
    End Sub
#End Region


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
