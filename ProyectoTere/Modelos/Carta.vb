Namespace Modelos
    Public Class Carta
        Inherits Producto ' Aquí indicamos que es hija de Producto

        ' Propiedades exclusivas de las cartas
        Public Property Rareza As String
        Public Property Expansion As String
        Public Property EstadoGrading As String ' Ej: PSA 10, Near Mint, etc.
    End Class
End Namespace
