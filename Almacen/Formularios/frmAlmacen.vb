Imports CapaDatos
Module Module1
    Public nuestroAlmacen As New List(Of Producto)

End Module
Public Class frmAlmacen

    Private localizacionIni As New List(Of Point)
    Private errores As Integer = 0
    Private frmacantidad As New frmCantidadPedida

    Dim nombresProductos As String() = {"Cuadernos", "Subrayadores", "Bolis", "Lapices", "Perforadora", "Grapadoras", "Carpetas", "Calculadoras", "Telefono"}


    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.pedidoCompletado, AudioPlayMode.BackgroundLoop)


        Dim classResize As New clsResizeForm
        classResize.ResizeForm(Me, 1920, 1080)


        Dim AnchoPantallaInicial As Integer = 1920
        Dim AltoPantallaInicial As Integer = 1080
        Dim ResolucionDestino As Size
        ResolucionDestino = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim AnchoPantallaDestino As Integer = ResolucionDestino.Width
        Dim AltoPantallaDestino As Integer = ResolucionDestino.Height
        Dim AnchoFormularioInicial As Double = 900
        Dim AltoformularioInicial As Double = 900
        Dim AnchoFormularioDestino = CDbl((AnchoFormularioInicial / AnchoPantallaInicial) * AnchoPantallaDestino)
        Dim AltoFormularioDestino = CDbl((AltoformularioInicial / AltoPantallaInicial) * AltoPantallaDestino)
        Me.Width = AnchoFormularioDestino
        Me.Height = AltoFormularioDestino


        localizacionIni.Add(pbCuadernos.Location)
        localizacionIni.Add(pbSubrayadores.Location)
        localizacionIni.Add(pbBolis.Location)
        localizacionIni.Add(pbLapices.Location)
        localizacionIni.Add(pbPerforadora.Location)
        localizacionIni.Add(pbGrapadoras.Location)
        localizacionIni.Add(pbCarpetas.Location)
        localizacionIni.Add(pbCalculadoras.Location)
        localizacionIni.Add(pbTelefono.Location)



        lblTitulo.SendToBack()
        PictureBox2.SendToBack()
        'Creamos los productos predeterminados
        For x = 0 To nombresProductos.Length - 1
            Dim nuevoProducto As New Producto(nombresProductos(x)) 'Stock si eso
            nuestroAlmacen.Add(nuevoProducto)
        Next

        'Dim pedi As String
        'Dim ped As New Pedido
        'pedi = ped.NuevoPedido()
        actualizarEtiquetas()
    End Sub


    Private Sub frmAlmacen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub


    'Movimiento de las imágenes
    Private Sub PictureBox_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbTelefono.MouseMove, pbSubrayadores.MouseMove, pbPerforadora.MouseMove, pbLapices.MouseMove, pbGrapadoras.MouseMove, pbCuadernos.MouseMove, pbCarpetas.MouseMove, pbCalculadoras.MouseMove, pbBolis.MouseMove ', MyBase.MouseMove

        Dim pictureEnMovimiento As PictureBox = TryCast(sender, PictureBox)

        pictureEnMovimiento.BringToFront()
        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If


        If pictureEnMovimiento.Location.X >= PictureBox2.Location.X AndAlso pictureEnMovimiento.Location.X <= PictureBox2.Location.X + PictureBox2.Width - pictureEnMovimiento.Width AndAlso pictureEnMovimiento.Location.Y >= PictureBox2.Location.Y AndAlso pictureEnMovimiento.Location.Y <= PictureBox2.Location.Y + PictureBox2.Height - pictureEnMovimiento.Width Then


            If sender.Equals(pbCuadernos) Then
                pbCuadernos.Location = localizacionIni(0)
                pedirCantidad("Cuadernos")
            End If

            If sender.Equals(pbSubrayadores) Then
                pbSubrayadores.Location = localizacionIni(1)
                pedirCantidad("Subrayadores")
            End If

            If sender.Equals(pbBolis) Then
                pbBolis.Location = localizacionIni(2)
                pedirCantidad("Bolis")
            End If

            If sender.Equals(pbLapices) Then
                pbLapices.Location = localizacionIni(3)
                pedirCantidad("Lapices")
            End If

            If sender.Equals(pbPerforadora) Then
                pbPerforadora.Location = localizacionIni(4)
                pedirCantidad("Perforadora")
            End If

            If sender.Equals(pbGrapadoras) Then
                pbGrapadoras.Location = localizacionIni(5)
                pedirCantidad("Grapadoras")
            End If

            If sender.Equals(pbCarpetas) Then
                pbCarpetas.Location = localizacionIni(6)
                pedirCantidad("Carpetas")
            End If

            If sender.Equals(pbCalculadoras) Then
                pbCalculadoras.Location = localizacionIni(7)
                pedirCantidad("Calculadoras")
            End If

            If sender.Equals(pbTelefono) Then
                pbTelefono.Location = localizacionIni(8)
                pedirCantidad("Telefono")
            End If



        End If

    End Sub
    Private Function pedirCantidad(ByVal nombreProducto As String) As String
        Dim producto As New Producto(nombreProducto)
        Dim cantidad As Integer = 0
        Do
        Loop Until Integer.TryParse(InputBox("¿Cuantos quieres?"), cantidad)
        If nuestroAlmacen.Contains(producto) Then
            If cantidad < nuestroAlmacen.Item(nuestroAlmacen.IndexOf(producto)).Stock Then
                nuestroAlmacen.Item(nuestroAlmacen.IndexOf(producto)).Stock -= cantidad
                actualizarEtiquetas()
            Else
                Return MsgBox("No hay suficiente stock")
                errores += 1
            End If
        End If
        Return "Pedido correctamente"
    End Function
    Private Sub actualizarEtiquetas()
        lblCuadernosQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " cuadernos."
        lblSubrayadoresQ.Text = "Quedan " & nuestroAlmacen(1).Stock & " subrayadores."
        lblBolisQ.Text = "Quedan " & nuestroAlmacen(2).Stock & " bolis."
        lblLapicesQ.Text = "Quedan " & nuestroAlmacen(3).Stock & " lapices."
        lblPerforadoraQ.Text = "Quedan " & nuestroAlmacen(4).Stock & " perforadoras."
        lblGrapadorasQ.Text = "Quedan " & nuestroAlmacen(5).Stock & " grapadoras."
        lblCarpetasQ.Text = "Quedan " & nuestroAlmacen(6).Stock & " carpetas."
        lblCalculadorasQ.Text = "Quedan " & nuestroAlmacen(7).Stock & " calculadoras."
        lblTelefonoQ.Text = "Quedan " & nuestroAlmacen(8).Stock & " teléfonos."
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Que las imágenes vuelvan a al inicio (cuando se suelte el ratón).
    Private Sub pbCuadernos_MouseUp_1(sender As Object, e As MouseEventArgs) Handles pbTelefono.MouseUp, pbSubrayadores.MouseUp, pbPerforadora.MouseUp, pbLapices.MouseUp, pbGrapadoras.MouseUp, pbCuadernos.MouseUp, pbCarpetas.MouseUp, pbCalculadoras.MouseUp, pbBolis.MouseUp

        If sender.Equals(pbCuadernos) Then
            pbCuadernos.Location = localizacionIni(0)
        End If

        If sender.Equals(pbSubrayadores) Then
            pbSubrayadores.Location = localizacionIni(1)
        End If

        If sender.Equals(pbBolis) Then
            pbBolis.Location = localizacionIni(2)
        End If

        If sender.Equals(pbLapices) Then
            pbLapices.Location = localizacionIni(3)
        End If

        If sender.Equals(pbPerforadora) Then
            pbPerforadora.Location = localizacionIni(4)
        End If

        If sender.Equals(pbGrapadoras) Then
            pbGrapadoras.Location = localizacionIni(5)
        End If

        If sender.Equals(pbCarpetas) Then
            pbCarpetas.Location = localizacionIni(6)
        End If

        If sender.Equals(pbCalculadoras) Then
            pbCalculadoras.Location = localizacionIni(7)
        End If

        If sender.Equals(pbTelefono) Then
            pbTelefono.Location = localizacionIni(8)
        End If

    End Sub

    Private Sub btnVerPedido_Click(sender As Object, e As EventArgs) Handles btnVerPedido.Click
        Dim pedido As New frmCantidadPedida
        pedido.ShowDialog()
    End Sub
End Class
