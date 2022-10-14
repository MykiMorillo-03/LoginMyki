Public Class Form1
    Private Sub login_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Usuario As String
        Dim Password As String

        Usuario = TxtUsuario.Text
        Password = TxtPassword.Text
        If (Usuario = "miguel.morillop03@gmail.com") And (Password = "mykimorillo") Then
            Form2.Show()

        Else
            MsgBox("Correo o contraseña incorrecta")

        End If


    End Sub
End Class
