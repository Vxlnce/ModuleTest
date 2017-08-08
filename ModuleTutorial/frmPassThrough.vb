Public Class frmPassThrough
    Private Sub frmPassThrough_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label1.Text = "Hello, " + UserName + ", your numbers were: " + num1.ToString + " and " + num2.ToString + ". The product of the two are: " + Multiply(num1, num2).ToString
        Catch ex As Exception
            MsgBox("An unexpected error has occurred")
        End Try

    End Sub
End Class