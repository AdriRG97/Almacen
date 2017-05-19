Imports CapaDatos

Public Class Usuario : Implements IEquatable(Of Usuario)

    Public Property Usuario As String
    Public Property Contraseña As String

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return Me.Usuario = other.Usuario AndAlso Me.Contraseña = other.Contraseña
    End Function
End Class
