Imports System.IO
Imports CapaDatos

Public Class frmUsuarios
    'TODO Al finalizar poner este como  Primero
    Public Property Usuarios As New List(Of Usuario)
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        lblErrorAdmin.Text = ""
        lblError.Text = ""
        lblError.Visible = True

        Dim ruta = "Ficheros\Usuarios.txt"
        Dim sline As String = ""
        Dim objReader As New StreamReader(ruta)
        Dim arrayDatos() As String
        Dim arraydatos2() As String


        Do
            Dim usu As New Usuario
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
                If usu.Usuario = txtUsuario.Text AndAlso usu.Contraseña = txtContraseña.Text Then
                    lblErrorAdmin.Visible = True
                    lblError.Visible = False
                    lblErrorAdmin.Text = "Bienvenida Miriam"
                    My.Computer.Audio.Play(My.Resources.acierto, AudioPlayMode.Background)
                    Dim frmAdmin As New frmAdministrador
                    objReader.Close()
                    frmAdmin.ShowDialog()
                    Exit Sub
                End If
            End If
        Loop Until sline = "" OrElse IsNothing(sline)
        objReader.Close()

        Dim sline3 As String = ""
        Dim boolError As Boolean = False
        Dim boolError2 As Boolean = False
        Dim objReader2 As New StreamReader(ruta)
        Dim usu2 As New Usuario

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
            If usu2.Usuario = txtUsuario.Text AndAlso usu2.Contraseña = txtContraseña.Text AndAlso Not String.IsNullOrWhiteSpace(txtUsuario.Text) Then
                lblError.Visible = True
                lblError.Text = "Bienvenido " & usu2.Usuario
                My.Computer.Audio.Play(My.Resources.acierto, AudioPlayMode.Background)
                Dim frmAlmacen As New frmAlmacen
                frmAlmacen.Show()
                Hide()
                Exit Sub
            End If
            If usu2.Usuario = txtUsuario.text Then
                boolError = True
            End If
            If usu2.Usuario = txtUsuario.text AndAlso Not usu2.Contraseña = txtContraseña.text Then
                boolError2 = True
            End If
        Loop Until sline = "" OrElse IsNothing(sline)

        If boolError = False OrElse String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            lblError.Visible = True
            lblError.Text = "Error, el usuario es incorrecto."
            My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
        End If
        If boolError2 = True OrElse String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            lblError.Visible = True
            lblError.Text = "Error, la contraseña no es correcta."
            My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
        End If

        If (String.IsNullOrWhiteSpace(txtUsuario.Text) AndAlso String.IsNullOrWhiteSpace(txtContraseña.Text)) Then
            lblError.Text = "Error, usuario y contraseña incorrectos."
            My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
        End If
        objReader2.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim anadir As New frmAñadirUsuario
        anadir.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ruta = "Ficheros/Usuarios.txt"
        If Not System.IO.File.Exists(ruta) Then
            Dim fic As New StreamWriter(ruta)
            fic.Close()
        End If

        Dim objReaderInicial As New StreamReader(ruta)
        Dim sline2 As String = ""
        sline2 = objReaderInicial.ReadLine
        objReaderInicial.Close()
        If sline2 = "" Then
            My.Computer.FileSystem.WriteAllText(ruta, "usuario:miriam" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "contraseña;miriam" & vbCrLf, True)
        End If
    End Sub


End Class