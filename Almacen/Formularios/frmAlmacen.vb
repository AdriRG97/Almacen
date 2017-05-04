Imports CapaDatos

Public Class frmAlmacen
    Dim nombresProductos As String() = {"Cinta", "Grapadora", "Lapices", "Libros", "Lupa", "Maletin", "Maquina", "Reloj", "Telefono"}
    Public Property nuestroAlmacen As List(Of Producto)
    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos los productos predeterminados
        For x = 0 To 9
            Dim nuevoPorducto As New Producto(nombresProductos(x), 50)
            nuestroAlmacen.Add(nuevoPorducto)
        Next
    End Sub
End Class
