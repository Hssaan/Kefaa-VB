Public Class Form16
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Form15.PictureBox1.Image = Me.PictureBox1.Image
        Form15.Show()
        Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form14.PictureBox1.Image = Me.PictureBox1.Image
        Form14.Show()
        Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form9.PictureBox1.Image = Me.PictureBox1.Image
        Form9.Show()
        Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.PictureBox1.Image = Me.PictureBox1.Image
        Form1.Show()
        Hide()
    End Sub
End Class