Imports System.IO
Imports CapaDatos

Public Class frmAdministrador

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ruta = "Ficheros/Productos.txt"
        Dim sline As String = ""
        Dim pedidos As New List(Of String)
        If Not File.Exists(ruta) Then
            Dim fic As New StreamWriter(ruta)
            fic.Close()
        End If
        Dim objReader As New StreamReader(ruta)
        Dim arrayDatos() As String
        sline = objReader.ReadLine
        objReader.Close()

        If String.IsNullOrWhiteSpace(sline) Then
            'Añadir los que faltan
            My.Computer.FileSystem.WriteAllText(ruta, "Lapices;", True)
            My.Computer.FileSystem.WriteAllText(ruta, "bolis;", True)
            My.Computer.FileSystem.WriteAllText(ruta, "cuadernos;", True)
            My.Computer.FileSystem.WriteAllText(ruta, "hojas;", True)
            objReader = New StreamReader(ruta)
            sline = objReader.ReadLine
            objReader.Close()
        End If
        If sline.Contains(";") Then
            arrayDatos = sline.Split(";")
            For i = 0 To arrayDatos.Length - 1
                lstProductos.Items.Add(arrayDatos(i))
            Next
            lstProductos.Items.RemoveAt(lstProductos.Items.Count - 1)
        End If
    End Sub

    Private Sub ptbAñadir_Click(sender As Object, e As EventArgs) Handles ptbAñadir.Click
        Dim ruta = "Ficheros/Productos.txt"
        Dim sline As String = ""
        Dim objeto As String
        objeto = InputBox("Introduce objeto")
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & objeto & ";", True)


        lstProductos.Items.Add(objeto)

    End Sub

    Private Sub btnMostrarUsuarios_Click(sender As Object, e As EventArgs) Handles btnMostrarUsuarios.Click
        Dim ruta = "Ficheros/Usuarios.txt"
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

    'Private Sub btnMostrarPedido_Click(sender As Object, e As EventArgs) Handles btnMostrarPedido.Click
    '    Dim ruta = "Ficheros/Pedidos.txt"
    '    Dim sline As String = ""
    '    Dim pedidos As New List(Of String)
    '    If Not File.Exists(ruta) Then
    '        Dim fic As New StreamWriter(ruta)
    '        fic.Close()
    '    End If
    '    Dim objReader As New StreamReader(ruta)
    '    Dim arrayDatos() As String
    '    'Completar para que lea los pedidos de el fichero

    '    sline = objReader.ReadLine
    '    objReader.Close()
    '    If sline = "" Then
    '        My.Computer.FileSystem.WriteAllText(ruta, NuevoPedido, True)
    '    End If



    '    lstPedidos.Items.Add(NuevoPedido)

    'End Sub
    Dim productos() As String = {"Lapices", "bolis", "cuadernos", "hojas", "grapadora", "cintas", "tijeras", "Telefono", "calculadoras"}
    Dim Variacion() As Boolean = {False, False, False, False, False, False, False, False, False}
    Dim cantPed As Integer
    Dim ped As New Pedido
    'Public Function NuevoPedido() As String
    '    Dim titulo As String = "Te han pedido: "
    '    Dim nuevalineas As String
    '    Dim numAlea As Integer
    '    Dim rnd = New Random
    '    Dim debeRenovar As Boolean
    '    Dim YaRenovado As Boolean = False
    '    For i = 0 To 8
    '        numAlea = rnd.Next(2)
    '        If numAlea = 0 Then
    '            Variacion(i) = False
    '        Else
    '            cantPed = rnd.Next(51)
    '            Variacion(i) = True
    '            Dim prod As New Producto(productos(i), 50)
    '            debeRenovar = prod.ComprobarAlmacen(prod, cantPed)

    '            ped.AñadirProducto(prod, cantPed)
    '            prod.CambiarStock(prod, cantPed)
    '            nuevalineas = ControlChars.NewLine & cantPed & " " & productos(i)
    '            titulo = titulo & nuevalineas
    '        End If
    '    Next
    '    Return titulo
    'End Function

End Class