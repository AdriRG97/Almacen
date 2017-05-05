﻿Imports System.IO
Imports CapaDatos

Public Class frmAñadirUsuario
    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        If txtUsuario.text = "" Then
            MsgBox("Error, debes introducir un usuario")
        End If
        If txtContraseña.text = "" Then
            MsgBox("Error, debes introducir una contraseña")
        End If

        Dim ruta = ".\usuarios.txt"
        Dim sline As String = ""
        Dim objReader As New StreamReader(".\usuarios.txt")
        Dim arrayDatos() As String
        Dim compro As Boolean = False



        Do
            Dim usu As New ClUsuario
            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains("-") Then
                    arrayDatos = sline.Split("-")
                    usu.Usuario = arrayDatos(1)
                End If
            End If

            If txtUsuario.text = usu.Usuario Then

                compro = True
            End If



        Loop Until sline = "" OrElse IsNothing(sline)
        objReader.Close()
        If compro = False Then
            My.Computer.FileSystem.WriteAllText(ruta, "usuario-" & txtUsuario.text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "contraseña_" & txtContraseña.text & vbCrLf, True)
            MsgBox("Usuario añadido correctamente")
            Me.Close()
        End If




        If compro = True Then
            MsgBox("Error, el usuario ya existe")
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtContraseña_OnTextChange(sender As Object, e As EventArgs) Handles txtContraseña.OnTextChange
        txtContraseña.Tag = txtContraseña.Tag & "*"
    End Sub
End Class