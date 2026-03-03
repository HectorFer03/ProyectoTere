Imports ProyectoTere.Datos

Public Class Registro
    Private db As New AccesoDatos()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Validar que no haya campos vacíos
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Comprobar si el nombre de usuario ya existe
            Dim checkQuery As String = "SELECT COUNT(*) FROM usuarios WHERE username = @user"
            Dim checkParams As New Dictionary(Of String, Object) From {{"@user", txtUsuario.Text}}
            Dim dtCheck = db.EjecutarConsulta(checkQuery, checkParams)

            If Convert.ToInt32(dtCheck.Rows(0)(0)) > 0 Then
                MessageBox.Show("El nombre de usuario ya existe. Elija otro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 3. Insertar el nuevo usuario asignando un ROL POR DEFECTO
            Dim insertQuery As String = "INSERT INTO usuarios (username, password, rol) VALUES (@user, @pass, @rol)"
            Dim insertParams As New Dictionary(Of String, Object) From {
                {"@user", txtUsuario.Text},
                {"@pass", txtPassword.Text},
                {"@rol", "Vendedor"} ' <--- AQUÍ ASIGNAMOS EL ROL POR DEFECTO AUTOMÁTICAMENTE
            }

            db.EjecutarComando(insertQuery, insertParams)
            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Limpiamos y cerramos la ventana para volver al Login
            txtUsuario.Clear()
            txtPassword.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class