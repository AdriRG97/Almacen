﻿Imports CapaDatos
Module Module1
    Public nuestroAlmacen As New List(Of Producto)
End Module
Public Class frmAlmacen

    Private localizacionIniCuadernos As Point
    Private localizacionIniSubrayadores As Point
    Private localizacionIniGrapadoras As Point
    Private localizacionIniCarpetas As Point
    Private localizacionIniBolis As Point
    Private localizacionIniCalculadoras As Point
    Private localizacionIniLapices As Point
    Private localizacionIniTelefono As Point
    Private localizacionIniPerforadora As Point
    Private frmacantidad As New frmCantidadPedida

    Dim nombresProductos As String() = {"Cuadernos", "Subrayadores", "Bolis", "Lapices", "Perforadoras", "Grapadoras", "Carpetas", "Calculadoras", "Telefono"}

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        localizacionIniCuadernos = pbCuadernos.Location
        localizacionIniSubrayadores = pbSubrayadores.Location
        localizacionIniGrapadoras = pbGrapadoras.Location
        localizacionIniCarpetas = pbCarpetas.Location
        localizacionIniCalculadoras = pbCalculadoras.Location
        localizacionIniLapices = pbLapices.Location
        localizacionIniTelefono = pbTelefono.Location
        localizacionIniPerforadora = pbPerforadora.Location
        localizacionIniBolis = pbBolis.Location




        lblTitulo.SendToBack()
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
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If
        copiaSubrayadores.Width = 68
        copiaSubrayadores.Height = 70

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        If pbSubrayadores.Location.X + pbSubrayadores.Width >= Panel1.Location.X + 50 AndAlso pbSubrayadores.Location.Y <= 380 Then

            copiaSubrayadores.Location = New Point(1320, 765)


            copiaSubrayadores.Enabled = False
            pbSubrayadores.Location = localizacionIniSubrayadores
            lblSubrayadoresF.Visible = True
            copiaSubrayadores.Visible = True
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
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)

        copiaCuaderno.Width = 74
        copiaCuaderno.Height = 70


        If pbCuadernos.Location.X + pbCuadernos.Width >= Panel1.Location.X + 50 AndAlso pbCuadernos.Location.Y <= 380 Then

            copiaCuaderno.Visible = True

            copiaCuaderno.Location = New Point(1175, 765)

            pbCuadernos.Location = localizacionIniCuadernos
            lblCuadernosF.Visible = True
            copiaCuaderno.Enabled = True
            frmacantidad.ShowDialog()
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
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        If pbGrapadoras.Location.X + pbGrapadoras.Width >= Panel1.Location.X + 50 AndAlso pbGrapadoras.Location.Y <= 380 Then
            pbGrapadoras.Location = New Point(810, 666)
            pbGrapadoras.Enabled = False
            frmacantidad.ShowDialog()
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
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point
        If pbCarpetas.Location.X + pbCarpetas.Width >= Panel1.Location.X + 50 AndAlso pbCarpetas.Location.Y <= 380 Then

            loca = pbCarpetas.Location
            pbCarpetas.Location = New Point(1000, 689)
            pbCarpetas.Enabled = False
            frmacantidad.ShowDialog()
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbCarpetasMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub



    'Fin mov. CARPETAS



    'Movimiento de la imagen de BOLIS


    Private Sub Bolis()

        pbCuadernos.Cursor = Cursors.SizeAll
        AddHandler pbCarpetas.MouseDown, AddressOf pbBolisMouseDown
        AddHandler pbCarpetas.MouseMove, AddressOf pbBolis_MouseMove

    End Sub



    Private Sub pbBolis_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbBolis.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point

        If pbBolis.Location.X + pbBolis.Width >= Panel1.Location.X + 50 AndAlso pbBolis.Location.Y <= 380 Then


            copiaBolis.Width = 65
            copiaBolis.Height = 70


            loca = pbCarpetas.Location

            pbBolis.Location = localizacionIniBolis
            copiaBolis.Location = New Point(1465, 765)
            copiaBolis.Visible = True
            lblBolisF.Visible = True
            frmacantidad.ShowDialog()
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbBolisMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub



    'Fin mov. BOLIS



    'Movimiento de la imagen de CALCULADORAS


    Private Sub Calculadoras()

        pbCalculadoras.Cursor = Cursors.SizeAll
        AddHandler pbCalculadoras.MouseDown, AddressOf pbCalculadorasMouseDown
        AddHandler pbCalculadoras.MouseMove, AddressOf pbCalculadoras_MouseMove

    End Sub



    Private Sub pbCalculadoras_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbCalculadoras.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point
        If pbCalculadoras.Location.X + pbCalculadoras.Width >= Panel1.Location.X + 50 AndAlso pbCalculadoras.Location.Y <= 380 Then

            loca = pbCarpetas.Location
            pbCalculadoras.Location = New Point(1000, 689)
            pbCalculadoras.Enabled = False
            frmacantidad.ShowDialog()
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbCalculadorasMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub



    'Fin mov. CALCU


    'Movimiento de la imagen de TELEFONO


    Private Sub Telefono()

        pbTelefono.Cursor = Cursors.SizeAll
        AddHandler pbTelefono.MouseDown, AddressOf pbTelefonosMouseDown
        AddHandler pbTelefono.MouseMove, AddressOf pbTelefonos_MouseMove

    End Sub



    Private Sub pbTelefonos_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbTelefono.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point
        If pbTelefono.Location.X + pbTelefono.Width >= Panel1.Location.X + 50 AndAlso pbTelefono.Location.Y <= 380 Then

            loca = pbTelefono.Location
            pbTelefono.Location = New Point(1000, 689)
            pbTelefono.Enabled = False
            frmacantidad.ShowDialog()
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbTelefonosMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub



    'Fin mov. TELEFONO

    'Movimiento de la imagen de LAPICES


    Private Sub Lapices()

        pbLapices.Cursor = Cursors.SizeAll
        AddHandler pbLapices.MouseDown, AddressOf pbLapicesMouseDown
        AddHandler pbLapices.MouseMove, AddressOf pbLapices_MouseMove

    End Sub


    Private Sub pbLapices_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbLapices.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point
        If pbLapices.Location.X + pbLapices.Width >= Panel1.Location.X + 50 AndAlso pbLapices.Location.Y <= 380 Then


            copiaLapices.Width = 65
            copiaLapices.Height = 70
            loca = pbLapices.Location
            copiaLapices.Location = New Point(1623, 765)
            pbLapices.Location = localizacionIniLapices
            copiaLapices.Enabled = False
            copiaLapices.Visible = True
            lblLapicesF.Visible = True
            frmacantidad.ShowDialog()
            ' Else
            '     pbCarpetas.Location = loca
        End If

    End Sub

    Private Sub pbLapicesMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub



    'Fin mov. LAPICES

    'Movimiento de la imagen de PERFORADORA


    Private Sub Perforadora()

        pbPerforadora.Cursor = Cursors.SizeAll
        AddHandler pbLapices.MouseDown, AddressOf pbPerforadoraMouseDown
        AddHandler pbLapices.MouseMove, AddressOf pbPerforadora_MouseMove

    End Sub



    Private Sub pbPerforadora_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbPerforadora.MouseMove

        If e.Button = MouseButtons.Left Then
            sender.top = MousePosition.Y - 65
            sender.left = MousePosition.X - 50
        End If

        Dim p As PictureBox = DirectCast(sender, PictureBox)
        Dim loca As New Point

        If pbPerforadora.Location.X + pbPerforadora.Width >= Panel1.Location.X + 50 AndAlso pbPerforadora.Location.Y <= 380 Then

            loca = pbPerforadora.Location
            pbPerforadora.Location = New Point(1000, 689)
            pbPerforadora.Enabled = False
            frmacantidad.ShowDialog()

            ' Else
            '     pbCarpetas.Location = loca
        End If


    End Sub

    Private Sub pbPerforadoraMouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = MousePosition.Y - sender.top
        coordenadas.X = MousePosition.X - sender.left
    End Sub

    Private Sub pbPerforadora_MouseUp(sender As Object, e As MouseEventArgs) Handles pbPerforadora.MouseUp
        If pbPerforadora.Location.X + pbPerforadora.Width >= Panel1.Location.X + 50 AndAlso pbPerforadora.Location.Y <= 380 Then
        Else
            pbPerforadora.Location = localizacionIniPerforadora
        End If

    End Sub

    'Fin mov. PERFORADORA











    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub pbLapices_MouseUp(sender As Object, e As MouseEventArgs) Handles pbLapices.MouseUp
        If pbLapices.Location.X + pbLapices.Width >= Panel1.Location.X + 50 AndAlso pbLapices.Location.Y <= 380 Then
        Else
            pbLapices.Location = localizacionIniLapices
        End If

    End Sub

    Private Sub pbTelefono_MouseUp(sender As Object, e As MouseEventArgs) Handles pbTelefono.MouseUp
        If pbTelefono.Location.X + pbTelefono.Width >= Panel1.Location.X + 50 AndAlso pbTelefono.Location.Y <= 380 Then
        Else

            pbTelefono.Location = localizacionIniTelefono
        End If

    End Sub

    Private Sub pbBolis_MouseUp(sender As Object, e As MouseEventArgs) Handles pbBolis.MouseUp
        If pbBolis.Location.X + pbBolis.Width >= Panel1.Location.X + 50 AndAlso pbBolis.Location.Y <= 380 Then
        Else

            pbBolis.Location = localizacionIniBolis
        End If

    End Sub


    Private Sub pbCalculadoras_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCalculadoras.MouseUp
        If pbCalculadoras.Location.X + pbCalculadoras.Width >= Panel1.Location.X + 50 AndAlso pbCalculadoras.Location.Y <= 380 Then
        Else

            pbCalculadoras.Location = localizacionIniCalculadoras
        End If

    End Sub
    Private Sub pbCarpetas_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCarpetas.MouseUp
        If pbCarpetas.Location.X + pbCarpetas.Width >= Panel1.Location.X + 50 AndAlso pbCarpetas.Location.Y <= 380 Then
        Else

            pbCarpetas.Location = localizacionIniCarpetas
        End If

    End Sub



    Private Sub pbGrapadoras_MouseUp(sender As Object, e As MouseEventArgs) Handles pbGrapadoras.MouseUp
        If pbGrapadoras.Location.X + pbGrapadoras.Width >= Panel1.Location.X + 50 AndAlso pbGrapadoras.Location.Y <= 380 Then
        Else

            pbGrapadoras.Location = localizacionIniGrapadoras
        End If

    End Sub

    Private Sub pbSubrayadores_MouseUp(sender As Object, e As MouseEventArgs) Handles pbSubrayadores.MouseUp
        If pbSubrayadores.Location.X + pbSubrayadores.Width >= Panel1.Location.X + 50 AndAlso pbSubrayadores.Location.Y <= 380 Then
        Else

            pbSubrayadores.Location = localizacionIniSubrayadores
        End If

    End Sub

    Private Sub pbCuadernos_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCuadernos.MouseUp
        If pbCuadernos.Location.X + pbCuadernos.Width >= Panel1.Location.X + 50 AndAlso pbCuadernos.Location.Y <= 380 Then
        Else

            pbCuadernos.Location = localizacionIniCuadernos
        End If

    End Sub


End Class
