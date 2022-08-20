Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Dim num As Integer
        If tbDayweek.Text = "" Then
            MsgBox("ใส่ข้อมูลตัวเลขก่อน", MsgBoxStyle.Information, "ข้อมูลผิดพลาด")
            tbDayweek.Focus()
        Else
            If IsNumeric(tbDayweek.Text) Then
                num = Val(tbDayweek.Text)
                If 'เช็คเลข 1-7
                Else

                    Select Case num
                        'เงื่อนไข case

                    End Select
                End If 'Check Dayweek
            Else
                MsgBox("ใส่ข้อมูลเป็นตัวเลขเท่านั้น", MsgBoxStyle.Information, "ข้อมูลผิดพลาด")
                tbDayweek.Focus()
                tbDayweek.SelectAll()
            End If 'End Check numeric data

        End If 'Check End blank data
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim bt_Exit As MsgBoxResult
        bt_Exit = MsgBox("จบการทำงานใช่หรือไม่ ?", MsgBoxStyle.YesNo, "จบการทำงาน")
        If bt_Exit = MsgBoxResult.Yes Then
            MsgBox("เลิกการทำงาน.....", MsgBoxStyle.Exclamation, "จบการทำงาน")
            Application.Exit()
        Else
            bt_Exit = MsgBoxResult.No
            tbDayweek.Focus()
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbDayweek.Text = ""
        lbOutput.Text = ""
        tbDayweek.Focus()
        lbOutput.BackColor = Color.LightGray
    End Sub
End Class
