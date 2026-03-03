Imports ProyectoTere.Datos

Public Class ReportesAdminForm
    Private db As New AccesoDatos()

    Private Sub ReportesAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SesionGlobal.Rol <> "Admin" Then
            MessageBox.Show("Acceso denegado. Solo administradores.")
            Me.Close()
        End If
    End Sub

    Private Sub btnInventarioValorado_Click(sender As Object, e As EventArgs) Handles btnInventarioValorado.Click
        ' Inventario total valorado (Stock x Valor Mercado)
        Dim query As String = "SELECT tipo, SUM(stock) as Cantidad_Total, SUM(stock * valor_mercado) as Valor_Total FROM Productos WHERE estado_activo = 1 GROUP BY tipo"
        dgvReportes.DataSource = db.EjecutarConsulta(query)
    End Sub

    Private Sub btnMasVendido_Click(sender As Object, e As EventArgs) Handles btnMasVendido.Click
        ' Artículos más vendidos por categoría
        Dim query As String = "SELECT p.tipo, COUNT(v.id) as Ventas FROM VentasHistorico v JOIN Productos p ON v.id_articulo = p.id GROUP BY p.tipo ORDER BY Ventas DESC"
        dgvReportes.DataSource = db.EjecutarConsulta(query)
    End Sub

    Private Sub btnOrdenadosPorPrecio_Click(sender As Object, e As EventArgs) Handles btnOrdenadosPorPrecio.Click
        ' Stock que lleva más de 6 meses parado
        ' (Asume la existencia de una columna fecha_ultima_modificacion o fecha_entrada)
        Dim query As String = "SELECT id, franquicia, numero_serie, stock FROM Productos WHERE estado_activo = 1 AND fecha_ultima_modificacion < DATE_SUB(NOW(), INTERVAL 6 MONTH)"
        dgvReportes.DataSource = db.EjecutarConsulta(query)
    End Sub

    Private Sub btnVentasPorUsuario_Click(sender As Object, e As EventArgs) Handles btnVentasPorUsuario.Click
        ' Ventas por usuario vendedor
        Dim query As String = "SELECT u.username, COUNT(v.id) as Total_Ventas FROM VentasHistorico v JOIN usuarios u ON v.id_vendedor = u.id GROUP BY u.username"
        dgvReportes.DataSource = db.EjecutarConsulta(query)
    End Sub
End Class