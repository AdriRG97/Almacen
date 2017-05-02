
Imports System.IO
Imports CapaDatos

Public Class Usus
    Private ruta = ".\usuarios.txt"
    ' TODO: Mantenimiento de usuarios
    Public Property Usuarios As New List(Of ClUsuario)
    Public Sub New() ' TODO Falta controlar los posibles errores
        Dim sline2 As String = ""
        If Not System.IO.File.Exists("usuarios.txt") Then
            System.IO.File.Create("usuarios.txt")
        End If
        Dim objReaderInicial As New StreamReader(".\usuarios.txt")
        sline2 = objReaderInicial.ReadLine

        If sline2 = "" Then
            My.Computer.FileSystem.WriteAllText(ruta, "usuario:miriam" & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(ruta, "contraseña;miriam" & vbCrLf, True)
        End If


        objReaderInicial.Close()

        Dim sline As String = ""
        Dim objReader As New StreamReader(".\usuarios.txt")
        Dim arrayDatos() As String
        Dim arraydatos2() As String


        Do
            Dim usu As New ClUsuario
            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains(":") Then
                    arrayDatos = sline.Split(":")
                    usu.Usuario = arrayDatos(1)
                End If
            End If

            sline = objReader.ReadLine
            If Not sline = "" Then
                If sline.Contains(";") Then
                    arraydatos2 = sline.Split(";")
                    usu.Contraseña = arraydatos2(1)

                End If
            End If
            Usuarios.Add(usu)
        Loop Until sline = "" OrElse IsNothing(sline)

        objReader.Close()
    End Sub

End Class
