Public Class Form10
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form9.PictureBox1.Image = Me.PictureBox1.Image
        Form9.Show()
        Hide()
    End Sub
End Class