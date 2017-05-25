Public Class frmStock
    Private Sub btnPedir_Click(sender As Object, e As EventArgs) Handles btnPedir.Click
        Dim cantidades As String() = {txtCuad.Text, txtSub.Text, txtBolis.Text, txtLapiz.Text, txtPerf.Text, txtGrap.Text, txtCarp.Text, txtCalc.Text, txtTelf.Text}
        Dim num As Integer = 0
        For i = 0 To nuestroAlmacen.Count - 1
            If Not Integer.TryParse(cantidades(i), num) OrElse num * paquetesProductos(i) < 0 OrElse num * paquetesProductos(i) > 50 Then
                cantidades(i) = 0
            Else
                Integer.TryParse(cantidades(i), num)
                If (nuestroAlmacen.Item(i).Stock + num * paquetesProductos(i)) <= 50 Then
                    nuestroAlmacen.Item(i).Stock += num * paquetesProductos(i)
                Else
                    MsgBox("Error, el número total de existencias jamás puede superar las 50 unidades", MsgBoxStyle.Critical)
                    erroresPorStock += 1
                    My.Computer.Audio.Play(My.Resources._error, AudioPlayMode.Background)
                End If
            End If
        Next
        Close()
    End Sub

   
End Class