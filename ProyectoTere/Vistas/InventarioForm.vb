Imports ProyectoTere.Datos

Public Class InventarioForm
    Private db As New AccesoDatos()
    Private idProductoSeleccionado As Integer = 0

    Private Sub InventarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mantenemos la corrección anterior para evitar el error de los máximos
        nudPrecioCoste.Maximum = 1000000
        nudValorMercado.Maximum = 1000000
        nudPrecioCoste.DecimalPlaces = 2
        nudValorMercado.DecimalPlaces = 2

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
        ' 1. Evitar errores si no hay fila seleccionada o si hacen clic en la última fila vacía (NewRow)
        If DataGridView1.CurrentRow IsNot Nothing AndAlso Not DataGridView1.CurrentRow.IsNewRow Then

            Dim row As DataGridViewRow = DataGridView1.CurrentRow

            ' 2. Validación segura del ID
            If Not IsDBNull(row.Cells("id").Value) AndAlso row.Cells("id").Value IsNot Nothing Then
                idProductoSeleccionado = Convert.ToInt32(row.Cells("id").Value)
            Else
                idProductoSeleccionado = 0
            End If

            ' 3. Validaciones seguras usando If(IsDBNull(...)) por si vienen datos vacíos de la Base de Datos
            cmbTipo.Text = If(IsDBNull(row.Cells("tipo").Value), "", row.Cells("tipo").Value.ToString())
            txtFranquicia.Text = If(IsDBNull(row.Cells("franquicia").Value), "", row.Cells("franquicia").Value.ToString())
            txtNumSerie.Text = If(IsDBNull(row.Cells("numero_serie").Value), "", row.Cells("numero_serie").Value.ToString())

            nudPrecioCoste.Value = If(IsDBNull(row.Cells("precio_coste").Value), 0D, Convert.ToDecimal(row.Cells("precio_coste").Value))
            nudValorMercado.Value = If(IsDBNull(row.Cells("valor_mercado").Value), 0D, Convert.ToDecimal(row.Cells("valor_mercado").Value))

            txtDescripcion.Text = If(IsDBNull(row.Cells("descripcion").Value), "", row.Cells("descripcion").Value.ToString())
            txtStock.Text = If(IsDBNull(row.Cells("stock").Value), "0", row.Cells("stock").Value.ToString())

            ' Bloqueo de Franquicia y Número de serie para edición
            txtFranquicia.Enabled = False
            txtNumSerie.Enabled = False
        Else
            ' Si seleccionan la fila vacía, limpiamos todos los campos para prepararlo para un "Nuevo Producto"
            idProductoSeleccionado = 0
            cmbTipo.SelectedIndex = -1
            txtFranquicia.Clear()
            txtNumSerie.Clear()
            nudPrecioCoste.Value = 0
            nudValorMercado.Value = 0
            txtDescripcion.Clear()
            txtStock.Clear()

            ' Rehabilitar bloqueo en caso de querer ingresar un producto nuevo
            txtFranquicia.Enabled = True
            txtNumSerie.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Prevenir colapso si el usuario deja la caja de "Stock" vacía usando TryParse
        Dim stockActual As Integer = 0
        If Not Integer.TryParse(txtStock.Text, stockActual) Then
            MessageBox.Show("Por favor, asegúrese de ingresar un número válido en el campo Stock.")
            Return
        End If

        If idProductoSeleccionado > 0 Then
            ' Actualización permitiendo editar precio, descripción y stock
            Dim query As String = "UPDATE Productos SET precio_coste = @coste, valor_mercado = @mercado, descripcion = @desc, stock = @stock WHERE id = @id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@coste", nudPrecioCoste.Value},
                {"@mercado", nudValorMercado.Value},
                {"@desc", txtDescripcion.Text},
                {"@stock", stockActual},
                {"@id", idProductoSeleccionado}
            }
            db.EjecutarComando(query, params)
            MessageBox.Show("Producto actualizado correctamente.")
        Else
            ' Lógica para Insertar nuevo producto
            MessageBox.Show("Guarda desde el botón 'Nuevo' aún no implementado en la vista.")
        End If
        CargarInventario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Validar correctamente el stock antes de comprobar si es > 0
        Dim stockActual As Integer = 0
        Integer.TryParse(txtStock.Text, stockActual)

        If stockActual > 0 Then
            MessageBox.Show("Solo se pueden dar de baja artículos cuyo stock sea 0.")
            Return
        End If

        If idProductoSeleccionado > 0 Then
            Dim query As String = "UPDATE Productos SET estado_activo = 0 WHERE id = @id"
            Dim params As New Dictionary(Of String, Object) From {{"@id", idProductoSeleccionado}}
            db.EjecutarComando(query, params)
            MessageBox.Show("Artículo dado de baja correctamente.")
            CargarInventario()
        Else
            MessageBox.Show("Por favor, seleccione un artículo de la lista primero.")
        End If
    End Sub

End Class