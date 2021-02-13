Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        oUsers.Login(txtUsername.Text, txtPassword.Text)
        If (login_valid = True) Then
            If (oUsers.Rolename = "admin") Then
                Form1.Show()
                Me.Hide()
            ElseIf (oUsers.Rolename = "dosen") Then
                Form2.Show()
                Me.Hide()

            ElseIf (oUsers.Rolename = "mahasiswa") Then
                Form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("User tidak dikenal")
            End If
        Else
            MessageBox.Show("Login not valid")
        End If
    End Sub
End Class