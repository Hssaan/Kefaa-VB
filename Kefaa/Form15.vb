Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class