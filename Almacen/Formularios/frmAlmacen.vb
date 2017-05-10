Imports CapaDatos
Module Module1
    Public nuestroAlmacen As New List(Of Producto)
End Module
Public Class frmAlmacen
    Dim nombresProductos As String() = {"Cuadernos", "Subrayadores", "Grapadoras", "Carpetas", "Lupa", "Maletin", "Maquina", "Reloj", "Telefono"}

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PictureBox2.SendToBack()
        Panel1.SendToBack()
        'Creamos los productos predeterminados
        For x = 0 To nombresProductos.Length - 1
            Dim nuevoProducto As New Producto(nombresProductos(x), 50)
            nuestroAlmacen.Add(nuevoProducto)
        Next
    End Sub
    Private Sub frmAlmacen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub


    'Movimiento de la imagen de subrayadores
    Dim coordenadas As Point


    Private Sub Subrayadores()

        pbSubrayadores.Cursor = Cursors.SizeAll
        AddHandler pbSubrayadores.MouseDown, AddressOf PictureBox1MouseDown
        AddHandler pbSubrayadores.MouseMove, AddressOf PictureBox1_MouseMove
        AddHandler pbSubrayadores.MouseUp, AddressOf PictureBox1_MouseUp
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbSubrayadores.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 165
            sender.left = MousePosition.X - 400
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        If pbSubrayadores.Location.X + pbSubrayadores.Width >= Panel1.Location.X + 50 AndAlso pbSubrayadores.Location.Y <= 380 Then
            pbSubrayadores.Location = New Point(810, 466)
            pbSubrayadores.Enabled = False
            Dim frmacantidad As New frmCantidadPedida
            frmacantidad.ShowDialog()

        End If

    End Sub

    Private Sub PictureBox1MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub


    'Fin mov. subrayadores



    'Movimiento de la imagen de CUADERNOS


    Private Sub Cuadernos()

        pbCuadernos.Cursor = Cursors.SizeAll
        AddHandler pbSubrayadores.MouseDown, AddressOf pbCuadernosMouseDown
        AddHandler pbSubrayadores.MouseMove, AddressOf pbCuadernos_MouseMove
        AddHandler pbSubrayadores.MouseUp, AddressOf pbCuadernosMouseUp
    End Sub

    Private Sub pbCuadernosMouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub pbCuadernos_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbCuadernos.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 165
            sender.left = MousePosition.X - 400
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        If pbCuadernos.Location.X + pbCuadernos.Width >= Panel1.Location.X + 50 AndAlso pbCuadernos.Location.Y <= 380 Then
            pbCuadernos.Location = New Point(1000, 466)
            pbCuadernos.Enabled = False
        End If

    End Sub

    Private Sub pbCuadernosMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub




    'Fin mov. CUADERNOS


    'Movimiento de la imagen de GRAPADORAS


    Private Sub Grapadoras()

        pbCuadernos.Cursor = Cursors.SizeAll
        AddHandler pbGrapadoras.MouseDown, AddressOf pbGrapadorasMouseDown
        AddHandler pbGrapadoras.MouseMove, AddressOf pbGrapadoras_MouseMove

    End Sub

    Private Sub pbGrapadoraMouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub pbGrapadoras_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbGrapadoras.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 165
            sender.left = MousePosition.X - 400
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        If pbGrapadoras.Location.X + pbGrapadoras.Width >= Panel1.Location.X + 50 AndAlso pbGrapadoras.Location.Y <= 380 Then
            pbGrapadoras.Location = New Point(810, 666)
            pbGrapadoras.Enabled = False
        End If

    End Sub

    Private Sub pbGrapadorasMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub




    'Fin mov. GRAPADORAS

    'Movimiento de la imagen de CARPETAS


    Private Sub Carpetas()

        pbCuadernos.Cursor = Cursors.SizeAll
        AddHandler pbCarpetas.MouseDown, AddressOf pbCarpetasMouseDown
        AddHandler pbCarpetas.MouseMove, AddressOf pbCarpetas_MouseMove

    End Sub



    Private Sub pbCarpetas_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbCarpetas.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 165
            sender.left = MousePosition.X - 400
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point
        If pbCarpetas.Location.X + pbCarpetas.Width >= Panel1.Location.X + 50 AndAlso pbCarpetas.Location.Y <= 380 Then

            loca = pbCarpetas.Location
            pbCarpetas.Location = New Point(1000, 689)
            pbCarpetas.Enabled = False
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbCarpetasMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub




    'Fin mov. CARPETAS


End Class
