Imports System.IO

Public Class frmAñadirPedido

    Private pedido As String = ""

    Private Sub frmAñadirPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPedidos()
    End Sub



    Public Sub ActualizarPedidos()
        Dim lector As New StreamReader(".\Ficheros\Pedidos.txt", True)
        Dim lectorStr As String
        Dim pedidos() As String = {}
        Dim pedido As String = ""

        Do
            lectorStr = lector.ReadLine

            If IsNothing(lectorStr) Then
                Exit Do
            End If
            pedidos = lectorStr.Split(";")
            For i = 0 To pedidos.Length - 1
                pedido += pedidos(i) & "  "
            Next
            lstPedidos.Items.Add(pedido)

        Loop Until lector.EndOfStream
        lector.Close()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        If String.IsNullOrWhiteSpace(lblProductoSeleccionado.Text) Then
            MsgBox("Selecciona un producto primero")
        Else
            pedido += lblProductoSeleccionado.Text & ":" & NumericUpDown1.Value & ";"
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click
        Dim picture As PictureBox = TryCast(sender, PictureBox)
        lblProductoSeleccionado.Text = picture.Tag
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim grabador As New StreamWriter(".\Ficheros\Pedidos.txt", True)
        Dim pedidoBueno As String
        pedidoBueno = pedido.Substring(0, pedido.Length - 1)
        grabador.WriteLine(pedidoBueno)
        grabador.Close()
        lstPedidos.Items.Clear()
        ActualizarPedidos()
        pedido = ""
    End Sub
End Class