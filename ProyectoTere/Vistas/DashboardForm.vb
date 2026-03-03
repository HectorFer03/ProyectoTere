Imports ProyectoTere.Datos

Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar interfaz según el rol
        Select Case SesionGlobal.Rol
            Case "Vendedor"
                ' El vendedor no puede actualizar precios masivos ni ver reportes de admin
                btnInventario.Text = "Consultar Inventario"
                ' Ocultar botones de reportes si los añades
            Case "Revisor"
                ' El revisor gestiona estados y precios
                btnVentas.Enabled = False ' Por ejemplo, no hace ventas
            Case "Admin"
                ' Control total, todo habilitado
        End Select
    End Sub
End Class