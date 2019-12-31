Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm2 As New Form2
        Me.Hide()
        frm2.Show()
    End Sub
End Class