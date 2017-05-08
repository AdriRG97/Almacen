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

    Dim coordenadas As Point


    Private Sub contruirPicture()

        PictureBox1.Cursor = Cursors.SizeAll
        AddHandler PictureBox1.MouseDown, AddressOf PictureBox1MouseDown
        AddHandler PictureBox1.MouseMove, AddressOf PictureBox1_MouseMove
        AddHandler PictureBox1.MouseUp, AddressOf PictureBox1_MouseUp
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
      
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 125
            sender.left = MousePosition.X - 450
        End If


    End Sub


    Private Sub PictureBox1MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub
End Class
