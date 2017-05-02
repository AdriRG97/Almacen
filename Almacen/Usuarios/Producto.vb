Public Class Producto : Implements IEquatable(Of Producto)
    Public Property Nombre As String
    Public Property Stock As Integer
    Public Property CantPedida As Integer
    Public Overloads Function Equals(other As Producto) As Boolean Implements IEquatable(Of Producto).Equals
        Return other IsNot Nothing AndAlso Me.Nombre.ToUpper = other.Nombre.ToUpper
    End Function
    Public Sub New(nombre As String, stock As Integer)
        CantPedida = 0
        Me.Nombre = nombre
        Me.Stock = stock
    End Sub
End Class
