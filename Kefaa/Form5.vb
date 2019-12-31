Public Class Form5
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm1 As New Form1
        Me.Hide()
        frm1.Show()
    End Sub
End Class