Public Class Form9
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("خطأ في الدخول")
        ComboBox1.Items.Add("خطأ في الانضمام")
        ComboBox1.Items.Add("خطأ في إضافة فعالية")
        ComboBox1.Items.Add("خطأ في استعادة كلمة المرور")
        ComboBox1.Items.Add("غير ذلك")
    End Sub
End Class