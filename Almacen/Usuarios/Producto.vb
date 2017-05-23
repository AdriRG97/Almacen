
Public Class Producto : Implements IEquatable(Of Producto)
    Public Property Nombre As String
    Private _Stock As Integer
    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property
    Public Property CantPedida As Integer

    Public Function Restock(ByVal cantidadPedida As Integer) As String
        Stock += cantidadPedida
        Return "Stock actualizado correctamente"
    End Function
    Public Overloads Function Equals(other As Producto) As Boolean Implements IEquatable(Of Producto).Equals
        Return other IsNot Nothing AndAlso Me.Nombre.ToUpper = other.Nombre.ToUpper
    End Function
    Public Sub New(nombre As String)
        Me.Nombre = nombre
        Stock = 50
    End Sub


End Class
