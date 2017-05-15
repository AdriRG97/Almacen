Imports System.IO
Imports CapaDatos

Public Class frmAdministrador

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ruta = My.Application.Info.DirectoryPath & "/Productos.txt"
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
        Dim ruta = My.Application.Info.DirectoryPath & "/Productos.txt"
        Dim sline As String = ""
        Dim objeto As String
        objeto = InputBox("Introduce objeto")
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & objeto & ";", True)


        lstProductos.Items.Add(objeto)

    End Sub

    Private Sub btnMostrarUsuarios_Click(sender As Object, e As EventArgs) Handles btnMostrarUsuarios.Click
        Dim ruta = My.Application.Info.DirectoryPath & "/usuarios.txt"
        Dim sline As String = ""
        Dim objReader As New StreamReader(ruta)
        Dim arrayDatos() As String
        Do
            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains("-") Then
                    arrayDatos = sline.Split("-")
                    lstUsuarios.Items.Add(arrayDatos(1))
                End If
            End If
        Loop Until sline = "" OrElse IsNothing(sline)
        objReader.Close()
        btnMostrarUsuarios.Enabled = False
    End Sub

    Private Sub btnMostrarPedido_Click(sender As Object, e As EventArgs) Handles btnMostrarPedido.Click
        File.Delete("/Pedidos.txt")
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
        objReader.Close()
        If sline = "" Then
            My.Computer.FileSystem.WriteAllText(ruta, NuevoPedido, True)
        End If



        lstPedidos.Items.Add(NuevoPedido)

    End Sub
    Dim productos() As String = {"Lapices", "bolis", "cuadernos", "hojas", "grapadora", "cintas", "tijeras", "Telefono", "calculadoras"}
    Dim Variacion() As Boolean = {False, False, False, False, False, False, False, False, False}
    Dim cantPed As Integer
    Dim ped As New Pedido
    Public Function NuevoPedido() As String

        Dim titulo As String = "Te han pedido: "
        Dim nuevalineas As String
        Dim numAlea As Integer
        Dim rnd = New Random
        For i = 0 To 8
            numAlea = rnd.Next(2)
            If numAlea = 0 Then
                Variacion(i) = False
            Else
                cantPed = rnd.Next(51)
                Variacion(i) = True
                ped.AñadirProducto(New Producto(productos(i), 50), cantPed)
                nuevalineas = ControlChars.NewLine & cantPed & " " & productos(i)
                titulo = titulo & nuevalineas
            End If
        Next
        Return titulo










    End Function
End Class