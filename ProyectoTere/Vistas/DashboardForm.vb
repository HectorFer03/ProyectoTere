Imports ProyectoTere.Datos

Public Class DashboardForm

    ' Este evento se ejecuta al abrir el formulario
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar interfaz según el rol
        Select Case SesionGlobal.Rol
            Case "Vendedor"
                ' El vendedor no puede actualizar precios masivos ni ver reportes de admin
                btnInventario.Text = "Consultar Inventario"
                btnActualizar.Enabled = False
                btnConsultas.Enabled = False
            Case "Revisor"
                ' El revisor gestiona estados y precios
                btnVentas.Enabled = False
            Case "Admin"
                ' Control total, todo habilitado
        End Select
    End Sub

    ' EVENTO: Abrir el Inventario
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim frmInventario As New InventarioForm()
        frmInventario.Show()
    End Sub

    ' EVENTO: Abrir el formulario de Ventas
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim frmVentas As New VentasForm()
        frmVentas.Show()
    End Sub

    ' EVENTO: Abrir Reportes/Consultas (Corregido el nombre del Sub agregando _Click)
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        Dim frmReportes As New ReportesAdminForm()
        frmReportes.Show()
    End Sub

    ' EVENTO: Abrir Actualización de precios (Corregido el nombre del Sub agregando _Click)
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim frmPrecios As New ActualizacionPreciosForm()
        frmPrecios.Show()
    End Sub

    ' EVENTO: Salir y cerrar la aplicación
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

End Class