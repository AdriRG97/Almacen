Imports CapaDatos

Public Class Producto : Implements IEquatable(Of Producto)
    Dim ListaProductos As New List(Of Producto)
    Public Property Nombre As String
    Public Property Stock As Integer
    Public Property CantPedida As Integer


    Public Function Restock(ByVal cantidadPedida As Integer) As String
        Stock += cantidadPedida
        Return "Stock actualizado correctamente"
    End Function
    Public Overloads Function Equals(other As Producto) As Boolean Implements IEquatable(Of Producto).Equals
        Return other IsNot Nothing AndAlso Me.Nombre.ToUpper = other.Nombre.ToUpper
    End Function
    Public Sub New(nombre As String, stock As Integer)
        CantPedida = 0
        Me.Nombre = nombre
        Me.Stock = stock
    End Sub
    Public Function CambiarStock(ProductoPedido As Producto, cantPedida As Integer) As String
        Dim comprobacion As Boolean = False
        Dim PosAlmacen As Integer
        For i = 0 To ListaProductos.Count - 1
            If ListaProductos(i).Equals(ProductoPedido) Then
                comprobacion = True
                PosAlmacen = i
            End If
        Next

        If comprobacion = True Then
            ListaProductos(PosAlmacen).Stock = ListaProductos(PosAlmacen).Stock - cantPedida
        Else
            ListaProductos.Add(ProductoPedido)
            ListaProductos(ListaProductos.Count - 1).Stock = 50 - cantPedida
        End If


    End Function


    Public Function RenovarStock() As String
        For i = 0 To ListaProductos.Count - 1
            ListaProductos(i).Stock = 50
        Next
    End Function



    Public Function ComprobarAlmacen(ByVal producto As Producto, ByVal cantidad As Integer) As Boolean
        For i = 0 To ListaProductos.Count - 1
            If ListaProductos(i).Equals(producto) Then
                If ListaProductos(i).Stock < cantidad Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

End Class
