Public Class frmInstrucciones
    Private Sub Btn_Entendido_Click(sender As Object, e As EventArgs) Handles Btn_Entendido.Click
        Me.Close()
    End Sub

    Private Sub Instrucciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtBox_instrucciones.Text = "A lo largo del juego te irán apareciendo múltiples pedidos." & vbCrLf & vbCrLf & "Tu función es seleccionar los objetos adecuados y arrastrarlos al carro. " & vbCrLf & "Una vez lo hagas, deberás marcar la cantidad correcta según te diga el enunciado." & vbCrLf & " Ten en cuenta que:" & vbCrLf & vbCrLf & "• No debes olvidarte de vigilar el almacén, puesto que no podrás vender más existencias de las que tienes." & vbCrLf & vbCrLf & "• Para añadir más existencias debes pulsar en el botón de 'Recargar Stock'." & vbCrLf & vbCrLf & "• La suma TOTAL de existencias de un producto nunca debe ser mayor de 50 productos. " & vbCrLf & vbCrLf & "• También has de saber que la cantidad que introduzcas será de paquetes, y en cada tipo de paquete viene una cantidad de productos diferentes que te pondrá encima de cada foto. " & vbCrLf & vbCrLf & "• Por último no tengas prisa por terminar, puesto que si finalizas el pedido sin haber cumplido el enunciado contará como un fallo. *Pista: Comprueba que tu pedido es igual al enunciado pulsando el botón de 'Ver cómo va nuestro pedido' " & vbCrLf & vbCrLf & "• Para finalizar el juego sin terminar tu pedido pulsa el botón 'Salir'."
        TxtBox_instrucciones.ReadOnly = True
    End Sub
End Class