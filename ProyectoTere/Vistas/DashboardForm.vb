Imports ProyectoTere.Datos

Public Class DashboardForm

    ' Este evento ya lo tenías, se ejecuta al abrir el formulario
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

    ' EVENTO NUEVO: Abrir el Inventario
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim frmInventario As New InventarioForm()
        frmInventario.Show()
    End Sub

    ' EVENTO NUEVO: Abrir el formulario de Ventas
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim frmVentas As New VentasForm()
        frmVentas.Show()
    End Sub

    ' EVENTO NUEVO: Salir y cerrar la aplicación
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        ' Es importante usar Application.Exit() para matar el proceso, 
        ' ya que el Form1 (Login) está oculto (Me.Hide()) y no cerrado.
        Application.Exit()
    End Sub

End Class