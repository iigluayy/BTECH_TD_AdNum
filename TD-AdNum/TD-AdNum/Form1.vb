Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, lbSum.Click

    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        tbNum1.Text = ""
        tbNum2.Text = ""
        lbSum.ForeColor = Color.White
        lbSum.BackColor = Color.Gray

    End Sub
End Class
