Imports ProyectoTere.Datos

Public Class VentasForm
    Private db As New AccesoDatos()

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim idArticulo As Integer
        If Integer.TryParse(txtIdArticulo.Text, idArticulo) Then
            ' Verificar stock
            Dim dt = db.EjecutarConsulta("SELECT stock FROM Productos WHERE id = " & idArticulo)
            If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)("stock")) > 0 Then

                ' Reducir stock
                db.EjecutarComando("UPDATE Productos SET stock = stock - 1 WHERE id = " & idArticulo)

                ' Guardar en histórico de ventas finalizadas con el estado de la entrega
                Dim queryHistorico As String = "INSERT INTO VentasHistorico (id_articulo, id_vendedor, estado_entrega, fecha) VALUES (@id_articulo, @vendedor, @estado, NOW())"
                Dim params As New Dictionary(Of String, Object) From {
                    {"@id_articulo", idArticulo},
                    {"@vendedor", SesionGlobal.UsuarioId},
                    {"@estado", txtEstadoEntrega.Text}
                }
                db.EjecutarComando(queryHistorico, params)

                MessageBox.Show("Artículo vendido y movido al histórico.")
            Else
                MessageBox.Show("Stock insuficiente o artículo no encontrado.")
            End If
        End If
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        Dim idVenta As Integer
        If Integer.TryParse(txtIdVentaHistorico.Text, idVenta) Then
            ' Recuperar ID del artículo de la venta
            Dim dt = db.EjecutarConsulta("SELECT id_articulo FROM VentasHistorico WHERE id = " & idVenta)
            If dt.Rows.Count > 0 Then
                Dim idArticulo = dt.Rows(0)("id_articulo")

                ' Devolver stock activo
                db.EjecutarComando("UPDATE Productos SET stock = stock + 1, estado_activo = 1 WHERE id = " & idArticulo)

                ' Marcar venta como devuelta o eliminar del histórico (según diseño, aquí eliminamos)
                db.EjecutarComando("DELETE FROM VentasHistorico WHERE id = " & idVenta)

                MessageBox.Show("Artículo recuperado del histórico y disponible en el stock activo.")
            Else
                MessageBox.Show("Venta no encontrada.")
            End If
        End If
    End Sub
End Class