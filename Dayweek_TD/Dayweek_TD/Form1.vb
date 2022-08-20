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
                If num > 7 Or num < 1 Then
                    MsgBox("ใส่ข้อมูลตัวเลข 1 2 3 4 5 6 7 เท่านั้น", MsgBoxStyle.Information, "ข้อมูลผิดพลาด")
                    tbDayweek.Focus()
                    tbDayweek.Text = ""
                Else

                    Select Case num
                        Case 1
                            lbOutput.Text = "Sunday"
                            lbOutput.BackColor = Color.Red
                            lbOutput.ForeColor = Color.White
                        Case 2
                            lbOutput.Text = "Monday"
                            lbOutput.BackColor = Color.Yellow
                            lbOutput.ForeColor = Color.DarkSlateBlue
                        Case 3
                            lbOutput.Text = "Tuesday"
                            lbOutput.BackColor = Color.Pink
                            lbOutput.ForeColor = Color.DarkSlateBlue
                        Case 4
                            lbOutput.Text = "Wednesday"
                            lbOutput.BackColor = Color.Green
                            lbOutput.ForeColor = Color.White
                        Case 5
                            lbOutput.Text = "Thursday"
                            lbOutput.BackColor = Color.Orange
                            lbOutput.ForeColor = Color.DarkSlateBlue
                        Case 6
                            lbOutput.Text = "Friday"
                            lbOutput.BackColor = Color.Blue
                            lbOutput.ForeColor = Color.White
                        Case 7
                            lbOutput.Text = "Saturday"
                            lbOutput.BackColor = Color.Violet
                            lbOutput.ForeColor = Color.DarkSlateBlue

                    End Select
                End If 'Check Dayweek
            Else
                MsgBox("ใส่ข้อมูลเป็นตัวเลขเท่านั้น", MsgBoxStyle.Information, "ข้อมูลผิดพลาด")
                tbDayweek.Focus()
                tbDayweek.Text = ""
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
        lbOutput.BackColor = Color.Salmon

    End Sub
End Class
