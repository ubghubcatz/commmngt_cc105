Public Class ImageViewer
    Private originalImage As Image
    Private currentZoomRect As Rectangle
    Private zoomFactor As Single = 2.0F

    Private isDragging As Boolean = False
    Private dragStartPoint As Point

    Public Property caseID As String
    ' Form Load - sets up basic layout
    Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' Public method to load image and description
    Public Sub LoadImageAndDescription(img As Image, desc As String)
        If img Is Nothing Then Exit Sub

        ' Save original image
        originalImage = img

        ' Initialize zoom rectangle
        currentZoomRect = New Rectangle(0, 0, originalImage.Width, originalImage.Height)

        ' Set PictureBox settings
        FullImage_PictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        FullImage_PictureBox.Image = New Bitmap(originalImage)

        ' Set description label
        desc_Label.Text = desc

        ' Add event handlers
        AddHandler FullImage_PictureBox.MouseClick, AddressOf FullImage_Click
        AddHandler FullImage_PictureBox.MouseDoubleClick, AddressOf FullImage_DoubleClick
    End Sub

    ' Zoom in on click
    Private Sub FullImage_Click(sender As Object, e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then Exit Sub

        Dim clickX As Integer = currentZoomRect.X + e.X * currentZoomRect.Width \ FullImage_PictureBox.Width
        Dim clickY As Integer = currentZoomRect.Y + e.Y * currentZoomRect.Height \ FullImage_PictureBox.Height

        Dim newWidth As Integer = CInt(currentZoomRect.Width / zoomFactor)
        Dim newHeight As Integer = CInt(currentZoomRect.Height / zoomFactor)
        Dim newX As Integer = clickX - newWidth \ 2
        Dim newY As Integer = clickY - newHeight \ 2

        ' Clamp
        If newX < 0 Then newX = 0
        If newY < 0 Then newY = 0
        If newX + newWidth > originalImage.Width Then newX = originalImage.Width - newWidth
        If newY + newHeight > originalImage.Height Then newY = originalImage.Height - newHeight

        currentZoomRect = New Rectangle(newX, newY, newWidth, newHeight)
        RefreshZoomedImage()
    End Sub

    ' Reset zoom
    Private Sub FullImage_DoubleClick(sender As Object, e As MouseEventArgs)
        currentZoomRect = New Rectangle(0, 0, originalImage.Width, originalImage.Height)
        FullImage_PictureBox.Image = New Bitmap(originalImage)
    End Sub

    ' Redraw zoomed image
    Private Sub RefreshZoomedImage()
        Dim bmp As New Bitmap(FullImage_PictureBox.Width, FullImage_PictureBox.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(originalImage, New Rectangle(0, 0, bmp.Width, bmp.Height), currentZoomRect, GraphicsUnit.Pixel)
        End Using
        FullImage_PictureBox.Image = bmp
    End Sub
End Class
