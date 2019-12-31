Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form15.PictureBox1.Image = Me.PictureBox1.Image
        Form15.Show()
        Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form16.PictureBox1.Image = Me.PictureBox1.Image
        Form16.Show()
        Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form9.PictureBox1.Image = Me.PictureBox1.Image
        Form9.Show()
        Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form1.PictureBox1.Image = Me.PictureBox1.Image
        Form1.Show()
        Hide()
    End Sub
End Class