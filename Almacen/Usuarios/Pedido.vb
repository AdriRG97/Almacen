Imports System.IO

Public Class Pedido
    Public Property NPedido As Integer
    Public Property ProductosPedidos As New List(Of Producto)


    Public Function AñadirProducto(ByVal producto As Producto, ByVal cantidad As Integer) As String
        If Not ProductosPedidos.Contains(producto) Then
            producto.CantPedida = cantidad
            producto.Stock -= cantidad
            ProductosPedidos.Add(producto)
            Return "Producto añadido correctamente"
        Else
            ProductosPedidos.Item(ProductosPedidos.IndexOf(producto)).CantPedida += cantidad
            ProductosPedidos.Item(ProductosPedidos.IndexOf(producto)).Stock -= cantidad
            Return "Cantidad del producto pedido actualizada"
        End If
    End Function
    Public Function EliminarProducto(ByVal producto As Producto, ByVal cantidad As Integer) As String
        If ProductosPedidos.Contains(producto) Then
            If cantidad >= ProductosPedidos.Item(ProductosPedidos.IndexOf(producto)).CantPedida Then
                ProductosPedidos.Remove(producto)
                producto.Stock += producto.CantPedida
                Return "Producto eliminado del pedido"
            Else
                ProductosPedidos.Item(ProductosPedidos.IndexOf(producto)).CantPedida -= cantidad
                ProductosPedidos.Item(ProductosPedidos.IndexOf(producto)).Stock += cantidad
                Return "Cantidad del producto pedido actualizada"
            End If
        Else
            Return "El producto " & producto.Nombre & " no se encuentra en el pedido"
        End If
    End Function

    Public Sub ReiniciarPedido()
        For i = 0 To ProductosPedidos.Count - 1
            ProductosPedidos.Item(i).Stock += ProductosPedidos.Item(i).CantPedida
            ProductosPedidos.Item(i).CantPedida = 0
            ProductosPedidos.RemoveAt(i)
        Next
    End Sub



    'Private Sub btnMostrarPedido_Click(sender As Object, e As EventArgs) As 
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

    '            AñadirProducto(prod, cantPed)
    '            prod.CambiarStock(prod, cantPed)
    '            nuevalineas = ControlChars.NewLine & cantPed & " " & productos(i)
    '            titulo = titulo & nuevalineas
    '        End If
    '    Next
    '    Return titulo
    'End Function
End Class
