Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, lbSum.Click

    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        tbNum1.Text = ""
        tbNum2.Text = ""
        lbSum.ForeColor = Color.White
        lbSum.BackColor = Color.Gray
        lbSum.Text = "ผลลัพธ์"

    End Sub

    Private Sub btSum_Click(sender As Object, e As EventArgs) Handles btSum.Click

        If String.IsNullOrEmpty(tbNum1.Text) Or String.IsNullOrEmpty(tbNum2.Text) Then
            MsgBox("กรุณาใส่ข้อมูล", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
        Else
            If IsNumeric(tbNum1.Text) And IsNumeric(tbNum2.Text) Then
                Dim num1, num2, sum As Integer
                num1 = Val(tbNum1.Text)
                num2 = Val(tbNum2.Text)
                sum = num1 + num2
                lbSum.Text = sum.ToString

                lbSum.ForeColor = Color.White
                lbSum.BackColor = Color.ForestGreen
            Else
                MsgBox("กรุณาใส่ข้อมูลเป็นตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
            End If 'End Check numeric
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click

    End Sub
End Class
