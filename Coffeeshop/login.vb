Public Class login
    Public username As String

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If txtuser.Text = "admin" Then
            If txtpass.Text = "1234" Then
                username = txtuser.Text
                MainUI.Show()
                Me.Hide()
                txtuser.Text = ""
                txtpass.Text = ""
            End If

        Else
            MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub
End Class
