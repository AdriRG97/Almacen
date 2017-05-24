Public Class Instrucciones
    Private Sub Btn_Entendido_Click(sender As Object, e As EventArgs) Handles Btn_Entendido.Click
        Me.Close()
    End Sub

    Private Sub Instrucciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtBox_instrucciones.Text = "A lo largo del juego te irán apareciendo múltiples pedidos." & vbCrLf & vbCrLf & "Tu función es seleccionar los objetos adecuados y arrastrarlos al carro. " & vbCrLf & "Una vez lo hagas, deberás marcar la cantidad correcta según te diga el enunciado. Pero... ¡Cuidado!" & vbCrLf & vbCrLf & "• No debes olvidarte de vigilar el almacén, puesto que no podrás vender más existencias de las que tienes. Para añadir más existencias tan sólo debes pulsar en el botón de 'Recargar Stock'. " & vbCrLf & vbCrLf & "• Tampoco debes olvidar que la cantidad que introduzcas será de paquetes, y en cada tipo de paquete viene una cantidad de productos diferentes que te pondrá encima de cada foto. "

    End Sub
End Class