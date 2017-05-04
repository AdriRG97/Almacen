Public Class Pedido
    Public Property NPedido As Integer
    Public Property ProductosPedidos As List(Of Producto)
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
End Class
