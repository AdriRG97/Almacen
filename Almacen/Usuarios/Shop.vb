Imports System.IO

Public Class Shop





    Public Function DevolverPedidos() As List(Of String)
        Dim listaPedido As New List(Of String)
        Dim cont As Integer = 0
        Dim ruta = "Ficheros/Pedidos.txt"
        Dim sline As String = ""
        Dim objReader As New StreamReader(ruta)
        Do
            sline = objReader.ReadLine
            If cont <> 0 Then
                listaPedido.Add(sline)
            End If
            cont += 1
        Loop Until sline = "" OrElse IsNothing(sline)
        objReader.Close()

        Return listaPedido
    End Function


End Class
