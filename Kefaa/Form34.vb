Imports System.Data.OleDb

Public Class Form34


    Private Sub Form34_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KefaaDataSet.JoinEvent' table. You can move, or remove it, as needed.
        Me.JoinEventTableAdapter.Fill(Me.KefaaDataSet.JoinEvent)



        Me.Text = Form30.Label2.Text
        Label3.Text = Form30.Label2.Text
        Me.JoinEventBindingSource.Filter = "EventName = '" & Label3.Text & "' "

    End Sub



    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class