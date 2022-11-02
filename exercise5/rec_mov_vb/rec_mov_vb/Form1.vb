Public Class Form1
    Dim rect As Rectangle = New Rectangle(125, 125, 50, 50)
    Dim isMouseDown As Boolean = False
    Private Sub pictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.FillRectangle(New SolidBrush(Color.RoyalBlue), rect)
    End Sub
    Private Sub pictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        isMouseDown = True
    End Sub
    Private Sub pictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        If isMouseDown = True Then
            rect.Location = e.Location

            If rect.Right > PictureBox1.Width Then
                rect.X = PictureBox1.Width - rect.Width
            End If

            If rect.Top < 0 Then
                rect.Y = 0
            End If

            If rect.Left < 0 Then
                rect.X = 0
            End If

            If rect.Bottom > PictureBox1.Height Then
                rect.Y = PictureBox1.Height - rect.Height
            End If

            Refresh()
        End If
    End Sub
    Private Sub pictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseUp
        isMouseDown = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
