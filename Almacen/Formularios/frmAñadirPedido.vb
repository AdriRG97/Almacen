Imports System.IO
Imports CapaDatos

Public Class frmAñadirPedido

    Private pedido As String = ""
    Private ultLinea As String

    Private Sub frmAñadirPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPedidos()
    End Sub

    Dim cesta As New List(Of String)



    Public Sub ActualizarPedidos()
        Dim lector As New StreamReader(".\Ficheros\Pedidos.txt", True)
        Dim lectorStr As String
        Dim pedidos() As String = {}
        Dim pedido As String = ""
        Dim pedidoValido As String
        Dim cantidad As Integer



        Do
            lectorStr = lector.ReadLine

            If IsNothing(lectorStr) Then
                Exit Do
            End If


            pedidos = lectorStr.Split(";")
            For i = 0 To pedidos.Length - 1
                pedido += pedidos(i)
            Next
            If Not lstPedidos.Items.Contains(pedido) Then
                lstPedidos.Items.Add(pedido)
            End If



            ultLinea = UltimaLineas()
            lstPedidos.Items.Add(ultLinea)
            Exit Do





        Loop Until lector.EndOfStream
        lector.Close()

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        If String.IsNullOrWhiteSpace(lblProductoSeleccionado.Text) Then
            MsgBox("Selecciona un producto primero", MsgBoxStyle.Exclamation, Title:="Atención")

        End If

        If cesta.Contains(lblProductoSeleccionado.Text) Then
            MsgBox("Error, el producto ya ha sido almacenado.", MsgBoxStyle.Critical, Title:="ERROR")

        Else
            cesta.Add(lblProductoSeleccionado.Text)
            pedido += lblProductoSeleccionado.Text & ":" & NumericUpDown1.Value & ";"
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click
        Dim picture As PictureBox = TryCast(sender, PictureBox)
        lblProductoSeleccionado.Text = picture.Tag
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If cesta.Count <> 0 Then
            Dim grabador As New StreamWriter(".\Ficheros\Pedidos.txt", True)
            Dim pedidoBueno As String
            pedidoBueno = pedido.Substring(0, pedido.Length - 1)
            grabador.WriteLine(pedidoBueno)
            grabador.Close()
            lstPedidos.Items.Clear()
            ActualizarPedidos()
            pedido = ""
            For i = 0 To cesta.Count - 1
                cesta(i) = ""
            Next

        Else

            MsgBox("Añade un producto antes de guardar el pedido.", MsgBoxStyle.Exclamation, Title:="Atención")

        End If



    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Me.Close()
    End Sub


    Private Function UltimaLineas() As String
        Dim fulltext As String = File.ReadAllText(".\Ficheros\Pedidos.txt")

        Dim partes() As String = fulltext.Split(Environment.NewLine)

        Dim ultimalinea As String = partes(partes.Length - 2)
        Return ultimalinea
    End Function
End Class