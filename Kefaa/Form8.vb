Public Class Form8
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm3 As New Form3
        Me.Hide()
        frm3.Show()
    End Sub
End Class