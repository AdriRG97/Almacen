Imports CapaDatos
Public Class frmCantidadPedida

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmCantidadPedida_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top)



        Dim almacen As New frmAlmacen
        lblNuestroPedido.Text = nuestroAlmacen(0).Nombre
    End Sub
End Class