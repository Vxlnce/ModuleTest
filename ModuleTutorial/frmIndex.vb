Public Class frmIndex
    Private Sub btnNextForm_Click(sender As Object, e As EventArgs) Handles btnNextForm.Click
        UserName = txtName.Text
        num1 = numRandom1.Value
        num2 = numRandom2.Value
        frmPassThrough.Show()
        Me.Close()
    End Sub
End Class
