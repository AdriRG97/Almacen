Imports System.IO
Imports CapaDatos

Public Class frmUsuarios

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usu As New frmUsuarios
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usu As New Usus
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim anadir As New frmAñadirUsuario

        anadir.ShowDialog()
    End Sub
End Class