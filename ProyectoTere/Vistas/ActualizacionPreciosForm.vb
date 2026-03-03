Public Class ActualizacionPreciosForm
    ' Dentro de ActualizacionPreciosForm.vb
    Private Sub btnActualizarMasivo_Click(sender As Object, e As EventArgs) Handles btnActualizarMasivo.Click
        ' Validar que sea Admin o Revisor
        If Datos.SesionGlobal.Rol = "Vendedor" Then
            MessageBox.Show("No tienes permisos para esto.")
            Return
        End If

        Dim categoria As String = cmbCategoria.SelectedItem.ToString() ' Ej: "Cartas TCG"
        Dim franquicia As String = txtFranquiciaObjetivo.Text ' Ej: "Pokémon"
        Dim porcentaje As Decimal = nudPorcentaje.Value / 100 ' Ej: 5% -> 0.05

        Dim db As New Datos.AccesoDatos()
        ' Aumentar o disminuir precio (1 + porcentaje)
        Dim query As String = "UPDATE Productos SET valor_mercado = valor_mercado * (1 + @porcentaje) WHERE tipo = @categoria AND franquicia = @franquicia"

        Dim params As New Dictionary(Of String, Object) From {
            {"@porcentaje", porcentaje},
            {"@categoria", categoria},
            {"@franquicia", franquicia}
        }

        Dim afectadas As Integer = db.EjecutarComando(query, params)
        MessageBox.Show($"Se han actualizado {afectadas} artículos.")
    End Sub
End Class