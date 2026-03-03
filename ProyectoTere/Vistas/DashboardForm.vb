Imports ProyectoTere.Datos

Public Class DashboardForm

    ' Variable para recordar qué ventana está abierta actualmente en el panel
    Private formularioActivo As Form = Nothing

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar interfaz según el rol
        Select Case SesionGlobal.Rol
            Case "Vendedor"
                btnInventario.Text = "Consultar Inventario"
                btnActualizar.Enabled = False
                btnConsultas.Enabled = False
                btnGestionUsuarios.Enabled = False
            Case "Revisor"
                btnVentas.Enabled = False
                btnGestionUsuarios.Enabled = False
            Case "Admin"
                ' Control total, todo habilitado
        End Select
    End Sub

    ' Función para abrir formularios dentro del pnlContenedor que creaste en el diseñador
    Private Sub AbrirFormularioHijo(formHijo As Form)
        ' Si ya hay un formulario abierto, lo cerramos
        If formularioActivo IsNot Nothing Then
            formularioActivo.Close()
        End If

        ' Configuramos el nuevo formulario para que se comporte como un control interno
        formularioActivo = formHijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        ' Lo añadimos al panel y lo mostramos
        pnlContenedor.Controls.Add(formHijo)
        pnlContenedor.Tag = formHijo
        formHijo.BringToFront()
        formHijo.Show()
    End Sub

    ' EVENTOS DE LOS BOTONES
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        AbrirFormularioHijo(New InventarioForm)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormularioHijo(New VentasForm)
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        AbrirFormularioHijo(New ReportesAdminForm)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        AbrirFormularioHijo(New ActualizacionPreciosForm)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        AbrirFormularioHijo(New CrearUsuarioForm())
    End Sub
End Class