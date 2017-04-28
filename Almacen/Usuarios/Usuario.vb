Imports CapaDatos

Public Class ClUsuario : Implements IEquatable(Of ClUsuario)

    Public Property Usuario As String
    Public Property Contraseña As String

    Public Overloads Function Equals(other As ClUsuario) As Boolean Implements IEquatable(Of ClUsuario).Equals
        Return Me.Usuario = other.Usuario AndAlso Me.Contraseña = other.Contraseña
    End Function
End Class
