Public Class Form14
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form9.PictureBox1.Image = Me.PictureBox1.Image
        Form9.Show()
        Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("شكرا لأنضمامك كمتطوع معنا سيتم التواصل معك في أقرب وقت ... فريق كفاء ")
    End Sub
End Class