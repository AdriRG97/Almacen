Public Class Usuarios

    Private ruta = ".\usuarios.txt"



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.WriteAllText(ruta, "usuario: usu" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(ruta, "contraseña: contra" & vbCrLf, True)
    End Sub
End Class