Imports CapaDatos
Module Module1
    Public nuestroAlmacen As New List(Of Producto) 'Existencias
    Public paquetesProductos As Integer() = {5, 3, 10, 5, 1, 2, 10, 3, 1}
    Public nombresProductos As String() = {"Cuadernos", "Subrayadores", "Bolis", "Lápices", "Perforadoras", "Grapadoras", "Carpetas", "Calculadoras", "Teléfonos"}
    Public enunciado As String

    Public erroresPorStock As Integer = 0 'Sobrepasar al recargar el stock
    Public enunciadoProductosRes As New List(Of Producto) 'Lo que falta para completar el enunciado
End Module
Public Class frmAlmacen

    Private localizacionIni As New List(Of Point)
    Private erroresPorExistencia As Integer = 0
    Private erroresPorEnunciado As Integer = 0
    Private erroresPorFinalizar As Integer = 0
    Private enunciadoCumplido As Boolean = False
    Private frmacantidad As New frmCantidadPedida
    Private arrEnunciado1() As String = {}
    Private arrEnunciadoCantidad() As String = {}
    Private aux As String
    Private productosRestEn() As Integer = {} ' Productos que quedan para completar el enunciado. {"Cuadernos", "Subrayadores", "Bolis", "Lapices", "Perforadora", "Grapadoras", "Carpetas", "Calculadoras", "Telefono"} (Posiciones iguales que en nuestroAlmacén, aunque no haya en el enunciado tal producto.)  



    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contador As Integer = 0

        lblEnunciado.Text = "Consigue que tu pedido contenga: " & enunciado
        arrEnunciado1 = enunciado.Split(";") ' Añade a 'arrEnunciado1' los diferentes productos del enunciado y sus cantidades separados por ':'. EJEMPLO: CUADERNOS:2 


        For i As Integer = 0 To arrEnunciado1.Length - 1

            aux = arrEnunciado1(i) ' Para poder hacer .Contains, ya que no se puede Array(x).Contains
            Dim product As New Producto

            If aux.Contains("CUADERNOS") Then
                arrEnunciadoCantidad = arrEnunciado1(i).Split(":") ' Guarda en arrEnunciadosCantidad: (0)-> Nombre del producto. (1) -> Cantidad que te pide el enunciado.
                '  contador = contador + 1 ' INNECESARIO Para que, en caso de no incluir cuadernos en el enunciado, la posición (0) de 'productosRestEn' corresponda al 1er producto que sí esté.
                '  productosRestEn(0)

                product.Nombre = "Cuadernos"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer) 'Añadimos al array la cantidad de producto del Enunciado y lo convertimos a integer para poder operarlo a posteriori

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("SUBRAYADORES") Then
                arrEnunciadoCantidad = arrEnunciado1(i).Split(":")
                product.Nombre = "Subrayadores"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)


            ElseIf aux.Contains("BOLIS") Then
                arrEnunciadoCantidad = arrEnunciado1(i).Split(":")
                product.Nombre = "Bolígrafos"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("LÁPICES") Then
                product.Nombre = "Lápices"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)


            ElseIf aux.Contains("PERFORADORAS") Then
                product.Nombre = "Perforadoras"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("GRAPADORAS") Then
                product.Nombre = "Grapadoras"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("CARPETAS") Then
                product.Nombre = "Carpetas"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("CALCULADORAS") Then
                product.Nombre = "Calculadoras"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)

            ElseIf aux.Contains("TELÉFONOS") Then
                product.Nombre = "Teléfonos"


                product.Stock = CType(arrEnunciadoCantidad(1), Integer)

                enunciadoProductosRes.Add(product)
            End If

        Next

        'Optimizando la resolución de pantalla para cualquier densidad de píxel por pulgada
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
    'Función que pide a los usuarios que introduzcan la cantidad de paquetes que desean
    Private Function pedirCantidad(ByVal nombreProducto As String) As String
        Dim producto As New Producto(nombreProducto)
        Dim cantidad As Integer = 0
        Do
        Loop Until Integer.TryParse(InputBox("¿Cuántos paquetes quieres?"), cantidad) AndAlso cantidad > 0
        If nuestroAlmacen.Contains(producto) Then
            For j As Integer = 0 To enunciadoProductosRes.Count - 1
                If cantidad <= nuestroAlmacen.Item(nuestroAlmacen.IndexOf(producto)).Stock / paquetesProductos(nuestroAlmacen.IndexOf(producto)) Then

                    nuestroAlmacen.Item(nuestroAlmacen.IndexOf(producto)).Stock -= cantidad * paquetesProductos(nuestroAlmacen.IndexOf(producto)) 'Resta los productos introducidos A LAS EXISTENCIAS
                    enunciadoProductosRes.Item(enunciadoProductosRes.IndexOf(producto)).Stock -= cantidad * paquetesProductos(nuestroAlmacen.IndexOf(producto)) ' Resta los ''  ''         AL ENUNCIADO
                    nuestroAlmacen.Item(nuestroAlmacen.IndexOf(producto)).CantPedida += cantidad * paquetesProductos(nuestroAlmacen.IndexOf(producto)) 'Suma los productos introducidos AL PEDIDO DEL USUARIO
                    actualizarEtiquetas()
                    My.Computer.Audio.Play(My.Resources.correcto, AudioPlayMode.Background)

                ElseIf enunciadoProductosRes(j).Stock < cantidad * paquetesProductos(nuestroAlmacen.IndexOf(producto)) Then
                    My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
                    erroresPorEnunciado += 1
                    Return MsgBox("Error, has superado lo que pide el enunciado.", MsgBoxStyle.Critical, Title:="FALLO")
                Else
                    My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
                    erroresPorExistencia += 1
                    Return MsgBox("No hay suficientes existencias.", MsgBoxStyle.Critical, Title:="FALLO")
                End If

            Next
        End If
        Return "Pedido correctamente"
    End Function
    ' Procedimiento que actualiza el stock en tiempo real
    Private Sub actualizarEtiquetas()
        lblCuadernosQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " cuadernos."
        lblSubrayadoresQ.Text = "Quedan " & nuestroAlmacen(1).Stock & " subrayadores."
        lblBolisQ.Text = "Quedan " & nuestroAlmacen(2).Stock & " bolis."
        lblLapicesQ.Text = "Quedan " & nuestroAlmacen(3).Stock & " lápices."
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

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Dim stock As New frmStock
        stock.ShowDialog()
        actualizarEtiquetas()
    End Sub

    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        Dim tuto As New frmInstrucciones
        tuto.ShowDialog()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        For i As Integer = 0 To enunciadoProductosRes.Count - 1
            If enunciadoProductosRes(i).Stock = 0 Then
                enunciadoCumplido = True
            Else
                enunciadoCumplido = False
                Exit For
            End If

        Next


        If enunciadoCumplido = True Then

            Dim erroresTotales As Integer = erroresPorEnunciado + erroresPorExistencia + erroresPorFinalizar + erroresPorStock


            My.Computer.Audio.Play(My.Resources.pedidoCompletado, AudioPlayMode.Background)

            MsgBox("Has terminado tu pedido." & vbCrLf & vbCrLf & "○ Errores por sobrepasar las existencias: " & erroresPorExistencia & vbCrLf & "○ Errores por sobrepasar lo que manda el enunciado: " & erroresPorEnunciado & vbCrLf & "○ Errores por finalizar sin haber terminado el pedido: " & erroresPorFinalizar & vbCrLf & "○ Errores al recargar Stock: " & erroresPorStock & vbCrLf & "____________________________" & vbCrLf & vbCrLf & "○ Errores totales: " & erroresTotales, Buttons:=MsgBoxStyle.Information, Title:="Fin del juego")
            Me.Close()

        Else
            erroresPorFinalizar += 1
            MsgBox("Error, todavía no has completado tu pedido, ¡Revísalo y ánimo!", MsgBoxStyle.Critical)
        End If
    End Sub


End Class
