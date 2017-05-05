Imports CapaDatos
Module Module1
    Public nuestroAlmacen As New List(Of Producto)
End Module
Public Class frmAlmacen
    Dim nombresProductos As String() = {"Cinta", "Grapadora", "Lapices", "Libros", "Lupa", "Maletin", "Maquina", "Reloj", "Telefono"}

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Creamos los productos predeterminados
        For x = 0 To nombresProductos.Length - 1
            Dim nuevoProducto As New Producto(nombresProductos(x), 50)
            nuestroAlmacen.Add(nuevoProducto)
        Next
    End Sub
    Private Sub frmAlmacen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class
