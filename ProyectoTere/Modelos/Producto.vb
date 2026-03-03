Namespace Modelos
    Public MustInherit Class Producto
        Public Property Id As Integer
        Public Property Franquicia As String ' No modificable después de creado
        Public Property NumeroSerie As String ' No modificable después de creado
        Public Property PrecioCoste As Decimal
        Public Property ValorMercado As Decimal
        Public Property Descripcion As String
        Public Property Stock As Integer
        Public Property EstadoActivo As Boolean

        ' Método virtual que las clases hijas pueden sobreescribir
        Public Overridable Function ObtenerDetalles() As String
            Return $"Franquicia: {Franquicia}, Serie: {NumeroSerie}"
        End Function
    End Class
End Namespace
