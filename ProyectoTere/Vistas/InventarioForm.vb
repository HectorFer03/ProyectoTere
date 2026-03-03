Imports ProyectoTere.Datos

Public Class InventarioForm
    Private db As New AccesoDatos()
    Private idProductoSeleccionado As Integer = 0

    Private Sub InventarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInventario()
        ConfigurarPermisos()
    End Sub

    Private Sub ConfigurarPermisos()
        ' Los revisores y admin pueden editar. Vendedores solo consultan.
        If SesionGlobal.Rol = "Vendedor" Then
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub CargarInventario()
        ' Se muestra el Valor de Mercado comparado con el Precio de Coste
        Dim query As String = "SELECT id, tipo, franquicia, numero_serie, precio_coste, valor_mercado, descripcion, stock FROM Productos WHERE estado_activo = 1"
        DataGridView1.DataSource = db.EjecutarConsulta(query)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow IsNot Nothing Then
            idProductoSeleccionado = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
            cmbTipo.Text = DataGridView1.CurrentRow.Cells("tipo").Value.ToString()
            txtFranquicia.Text = DataGridView1.CurrentRow.Cells("franquicia").Value.ToString()
            txtNumSerie.Text = DataGridView1.CurrentRow.Cells("numero_serie").Value.ToString()
            nudPrecioCoste.Value = Convert.ToDecimal(DataGridView1.CurrentRow.Cells("precio_coste").Value)
            nudValorMercado.Value = Convert.ToDecimal(DataGridView1.CurrentRow.Cells("valor_mercado").Value)
            txtDescripcion.Text = DataGridView1.CurrentRow.Cells("descripcion").Value.ToString()
            txtStock.Text = DataGridView1.CurrentRow.Cells("stock").Value.ToString()

            ' Bloqueo de Franquicia y Número de serie para edición
            txtFranquicia.Enabled = False
            txtNumSerie.Enabled = False
        End If
    End Sub

    ' NOTA: Debes agregar un botón btnGuardar y btnEliminar en el diseño del Formulario
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If idProductoSeleccionado > 0 Then
            ' Actualización permitiendo editar precio, descripción y stock
            Dim query As String = "UPDATE Productos SET precio_coste = @coste, valor_mercado = @mercado, descripcion = @desc, stock = @stock WHERE id = @id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@coste", nudPrecioCoste.Value},
                {"@mercado", nudValorMercado.Value},
                {"@desc", txtDescripcion.Text},
                {"@stock", Convert.ToInt32(txtStock.Text)},
                {"@id", idProductoSeleccionado}
            }
            db.EjecutarComando(query, params)
            MessageBox.Show("Producto actualizado correctamente.")
        Else
            ' Lógica para Insertar nuevo producto (aquí sí se permite franquicia y serie)
            ' (Se debe implementar un botón 'Nuevo' que limpie los campos y habilite franquicia y num serie)
        End If
        CargarInventario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Convert.ToInt32(txtStock.Text) > 0 Then
            MessageBox.Show("Solo se pueden dar de baja artículos cuyo stock sea 0.")
            Return
        End If

        Dim query As String = "UPDATE Productos SET estado_activo = 0 WHERE id = @id"
        Dim params As New Dictionary(Of String, Object) From {{"@id", idProductoSeleccionado}}
        db.EjecutarComando(query, params)
        MessageBox.Show("Artículo dado de baja correctamente.")
        CargarInventario()
    End Sub


End Class