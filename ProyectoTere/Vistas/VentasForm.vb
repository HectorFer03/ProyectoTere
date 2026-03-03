Imports ProyectoTere.Datos

Public Class VentasForm
    Private db As New AccesoDatos()

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim idArticulo As Integer
        If Integer.TryParse(txtIdArticulo.Text, idArticulo) Then

            ' Verificar stock usando parámetros
            Dim queryStock = "SELECT stock FROM Productos WHERE id = @id_articulo"
            Dim paramStock As New Dictionary(Of String, Object) From {{"@id_articulo", idArticulo}}
            Dim dt = db.EjecutarConsulta(queryStock, paramStock)

            If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)("stock")) > 0 Then

                ' Reducir stock
                Dim queryUpdate = "UPDATE Productos SET stock = stock - 1 WHERE id = @id_articulo"
                db.EjecutarComando(queryUpdate, paramStock)

                ' Guardar en histórico
                Dim queryHistorico As String = "INSERT INTO VentasHistorico (id_articulo, id_vendedor, estado_entrega, fecha) VALUES (@id_articulo, @vendedor, @estado, NOW())"
                Dim paramsHist As New Dictionary(Of String, Object) From {
                    {"@id_articulo", idArticulo},
                    {"@vendedor", SesionGlobal.UsuarioId},
                    {"@estado", txtEstadoEntrega.Text}
                }
                db.EjecutarComando(queryHistorico, paramsHist)

                MessageBox.Show("Artículo vendido y movido al histórico correctamente.")

                ' Limpiamos los campos para evitar confusiones
                txtIdArticulo.Clear()
                txtEstadoEntrega.Clear()
            Else
                MessageBox.Show("Stock insuficiente o artículo no encontrado en la base de datos.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID numérico válido.")
        End If
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        Dim idVenta As Integer
        If Integer.TryParse(txtIdVentaHistorico.Text, idVenta) Then

            ' Recuperar ID del artículo de la venta
            Dim querySelect = "SELECT id_articulo FROM VentasHistorico WHERE id = @id_venta"
            Dim paramSelect As New Dictionary(Of String, Object) From {{"@id_venta", idVenta}}
            Dim dt = db.EjecutarConsulta(querySelect, paramSelect)

            If dt.Rows.Count > 0 Then
                Dim idArticulo = Convert.ToInt32(dt.Rows(0)("id_articulo"))

                ' Devolver stock activo
                Dim queryUpdate = "UPDATE Productos SET stock = stock + 1, estado_activo = 1 WHERE id = @id_articulo"
                Dim paramUpdate As New Dictionary(Of String, Object) From {{"@id_articulo", idArticulo}}
                db.EjecutarComando(queryUpdate, paramUpdate)

                ' Eliminar del histórico
                Dim queryDelete = "DELETE FROM VentasHistorico WHERE id = @id_venta"
                db.EjecutarComando(queryDelete, paramSelect)

                MessageBox.Show("Artículo recuperado del histórico y devuelto al stock.")

                ' Limpiamos el campo
                txtIdVentaHistorico.Clear()
            Else
                MessageBox.Show("El ID de esa venta no existe en el histórico.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID de venta numérico válido.")
        End If
    End Sub
End Class