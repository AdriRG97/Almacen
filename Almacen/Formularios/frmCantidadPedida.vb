Imports CapaDatos
Public Class frmCantidadPedida
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) 
        Dim almacen = frmAlmacen

        almacen.lblBolisQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " bolis."
        almacen.lblCalculadorasQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " calculadoras."
        almacen.lblSubrayadoresQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " subrayadores."
        almacen.lblCarpetasQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " carpetas."
        almacen.lblCuadernosQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " cuadernos."
        almacen.lblGrapadorasQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " grapadoras."
        almacen.lblLapicesQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " lapices."
        almacen.lblPerforadoraQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " perforadoras."
        almacen.lblTelefonoQ.Text = "Quedan " & nuestroAlmacen(0).Stock & " teléfonos."





        Me.Close()
    End Sub
End Class