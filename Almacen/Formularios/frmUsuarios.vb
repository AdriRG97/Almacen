﻿Imports System.IO
Imports CapaDatos

Public Class frmUsuarios

    Public Property Usuarios As New List(Of ClUsuario)

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        lblErrorAdmin.Text = ""
        lblError.Text = ""
        lblError.Visible = True

        Dim ruta = ".\usuarios.txt"

        Dim sline2 As String = ""
        If Not System.IO.File.Exists("usuarios.txt") Then
            System.IO.File.Create("usuarios.txt")
        End If
        Dim objReaderInicial As New StreamReader(".\usuarios.txt")
        sline2 = objReaderInicial.ReadLine

        If sline2 = "" Then
            My.Computer.FileSystem.WriteAllText(ruta, "usuario:miriam" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "contraseña;miriam" & vbCrLf, True)
        End If


        objReaderInicial.Close()

        Dim sline As String = ""
        Dim objReader As New StreamReader(".\usuarios.txt")
        Dim arrayDatos() As String
        Dim arraydatos2() As String


        Do
            Dim usu As New ClUsuario
            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains(":") Then
                    arrayDatos = sline.Split(":")
                    usu.Usuario = arrayDatos(1)
                End If
            End If

            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains(";") Then
                    arraydatos2 = sline.Split(";")
                    usu.Contraseña = arraydatos2(1)

                End If
            End If
            If usu.Usuario <> "" OrElse usu.Contraseña <> "" Then

                If usu.Usuario = txtUsuario.text AndAlso usu.Contraseña = txtContraseña.text Then
                    lblErrorAdmin.Visible = True
                    lblError.Visible = False
                    lblErrorAdmin.Text = "Bienvenida Miriam"

                    Exit Sub
                End If
            End If


        Loop Until sline = "" OrElse IsNothing(sline)



        objReader.Close()



        Dim sline3 As String = ""
        Dim boolError As Boolean = False
        Dim boolError2 As Boolean = False
        Dim objReader2 As New StreamReader(".\usuarios.txt")

        Dim usu2 As New ClUsuario

        Do

            sline = objReader2.ReadLine
            If Not sline = "" Then
                If sline.Contains("-") Then
                    arrayDatos = sline.Split("-")
                    usu2.Usuario = arrayDatos(1)
                End If
            End If

            sline = objReader2.ReadLine
            If Not sline = "" Then
                If sline.Contains("_") Then
                    arraydatos2 = sline.Split("_")
                    usu2.Contraseña = arraydatos2(1)

                End If
            End If


            If usu2.Usuario = txtUsuario.text AndAlso usu2.Contraseña = txtContraseña.text Then
                lblError.Visible = True
                lblError.Text = "Bienvenido " & usu2.Usuario

            End If
            If usu2.Usuario = txtUsuario.text Then
                boolError = True
            End If

            If usu2.Usuario = txtUsuario.text AndAlso Not usu2.Contraseña = txtContraseña.text Then
                boolError2 = True
            End If


        Loop Until sline = "" OrElse IsNothing(sline)

        If boolError = False Then
            lblError.Visible = True
            lblError.Text = "Error, el usuario es incorrecto."
        End If

        If boolError2 = True Then
            lblError.Visible = True
            lblError.Text = "Error, la contraseña no es correcta."
        End If



        objReader2.Close()


    End Sub


    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usu As New Usus
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim anadir As New frmAñadirUsuario

        anadir.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class