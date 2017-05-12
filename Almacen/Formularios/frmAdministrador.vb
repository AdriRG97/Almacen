Imports System.IO

Public Class frmAdministrador
    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ruta = My.Application.Info.DirectoryPath & "/Pedidos.txt"
        Dim sline As String = ""
        Dim pedidos As New List(Of String)
        If Not File.Exists(ruta) Then
            'File.Create(ruta)
            Dim fic As New StreamWriter(ruta)
            fic.Close()
        End If
        Dim fich As New StreamReader(ruta)
        fich.Close()
        Dim objReader As New StreamReader(ruta)
        Dim arrayDatos() As String
        sline = objReader.ReadLine
        If sline = "" Then
            My.Computer.FileSystem.WriteAllText(ruta, "Lapices;" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "bolis;" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "cuadernos;" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "hojas;" & vbCrLf, True)
        End If
        Do
            If Not sline = "" Then
                If sline.Contains(";") Then
                    arrayDatos = sline.Split(";")
                    lstProductos.Items.Add(arrayDatos(0))
                End If
            End If
            sline = objReader.ReadLine
        Loop Until sline = "" OrElse IsNothing(sline)
        objReader.Close()
    End Sub

    Private Sub ptbAñadir_Click(sender As Object, e As EventArgs) Handles ptbAñadir.Click
        Dim objeto As String
        objeto = InputBox("Introduce objeto")





        lstProductos.Items.Add(objeto)

    End Sub
End Class