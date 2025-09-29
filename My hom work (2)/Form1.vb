Public Class Form1
    Dim x, y, w, k As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = InputBox("الرجاء ادخال العدد بين الصفر15 ", "صندوق الادخال")
        If i >= 0 And i <= 15 Then
            Me.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(Val(i)))
        Else
            MsgBox("الادخال خاطئ", , "تنبـيـه")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Randomize()
        Me.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(Rnd)) 

    End Sub

    Private Function RGB(rnd As Single) As Integer

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        w = Chr(13) + Chr(10)
        TextBox1.Text = "الحمد لله" + w + "رب العالمين"
        Label1.Text = "الحمدلله" + w + "رب العالمين"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        w = Chr(13) + Chr(10)
        x = "هل تريد الخروج من المشروع؟"
        y = "تحذير"
        k = MsgBox(x, MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, y)
        If k = 6 Then

        End If
    End Sub

    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Chr(13) + Chr(10)
        x = "جامعه الملك سعود" + w
        x = x + "مركز التدريب وخدمه المجتمع" + w
        x = x + "دبلوم الحاسوب الالي" + w
        x = x + "اعداد الاستاذ حذيفه عبدالرحمن" + w
        x = x + "للعام الدراسي 1442هــ"
        y = "حول المشروع"
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.OkCancel, y)
    End Sub
End Class
