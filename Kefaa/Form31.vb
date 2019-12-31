Imports System.Data.OleDb

Public Class Form31
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form31_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Form30.Label2.Text
        'جلب البيانات من قاعدة البيانات

        Dim sqlconnON As New OleDbConnection
        Dim VOName As New OleDbCommand
        Dim VOLName As New OleDbCommand
        Dim VOMobile As New OleDbCommand
        Dim connStringON As String


        'بداية الاتصال بقاعدة البيانات

        connStringON = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Halma\Desktop\Kefaa V2\Kefaa in VB\DB\Kefaa.mdb"
        sqlconnON.ConnectionString = connStringON
        VOName.Connection = sqlconnON
        VOMobile.Connection = sqlconnON
        VOLName.Connection = sqlconnON

        'أوامر استدعاء البيانات

        sqlconnON.Open()
        VOName.CommandText = "SELECT [VolunteerFName] FROM Volunteers WHERE [VolunteerUsername] = '" & Form3.TextBox1.Text & "';"
        VOLName.CommandText = "SELECT [VolunteerLName] FROM Volunteers WHERE [VolunteerUsername] = '" & Form3.TextBox1.Text & "';"
        VOMobile.CommandText = "SELECT [VolunteerMobile] FROM Volunteers WHERE [VolunteerUsername] = '" & Form3.TextBox1.Text & "';"

        'تطبيق وظائف التعامل مع البيانات

        VOName.ExecuteScalar()
        TextBox1.Text = VOName.ExecuteScalar + " " + VOLName.ExecuteScalar
        TextBox2.Text = VOMobile.ExecuteScalar

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            'جلب البيانات من قاعدة البيانات

            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String

            'بداية الاتصال بقاعدة البيانات

            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Halma\Desktop\Kefaa V2\Kefaa in VB\DB\Kefaa.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()

            'أوامر استدعاء البيانات

            sqlquery.CommandText = "INSERT INTO JoinEvent ([EventName], [VName], [VMobile])VALUES(@EventName, @VName, @VMobile)"
            sqlquery.Parameters.AddWithValue("@EventName", Form30.Label2.Text)
            sqlquery.Parameters.AddWithValue("@VName", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@VMobile", TextBox2.Text)



            'تطبيق وظائف التعامل مع البيانات

            sqlquery.ExecuteNonQuery()

            MsgBox("تم التسجيل في الفعالية بنجاح. سيتم التواصل معك من قبل أحد أعضاء المنظمة")
            Me.Close()
            sqlconn.Close()

            'عرض الأخطاء في حال فشل جلب البيانات من قاعدة البيانات

        Catch ex As Exception
            MsgBox("خطأ في التسجيل")

        End Try
    End Sub
End Class