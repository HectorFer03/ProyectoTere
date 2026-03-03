Imports ProyectoTere.Datos

Public Class Form1
    Private db As New AccesoDatos()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Ingrese usuario y contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "SELECT id, username, rol FROM usuarios WHERE username = @user AND password = @pass"
            Dim params As New Dictionary(Of String, Object) From {
                {"@user", txtUsuario.Text},
                {"@pass", txtPassword.Text}
            }
            Dim dt = db.EjecutarConsulta(query, params)

            If dt.Rows.Count > 0 Then
                SesionGlobal.UsuarioId = Convert.ToInt32(dt.Rows(0)("id"))
                SesionGlobal.Username = dt.Rows(0)("username").ToString()
                SesionGlobal.Rol = dt.Rows(0)("rol").ToString()

                Dim dashboard As New DashboardForm()
                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse cmbRol.SelectedItem Is Nothing Then
            MessageBox.Show("Complete todos los campos y seleccione un rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim checkQuery As String = "SELECT COUNT(*) FROM usuarios WHERE username = @user"
            Dim checkParams As New Dictionary(Of String, Object) From {{"@user", txtUsuario.Text}}
            Dim dtCheck = db.EjecutarConsulta(checkQuery, checkParams)

            If Convert.ToInt32(dtCheck.Rows(0)(0)) > 0 Then
                MessageBox.Show("El usuario ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim insertQuery As String = "INSERT INTO usuarios (username, password, rol) VALUES (@user, @pass, @rol)"
            Dim insertParams As New Dictionary(Of String, Object) From {
                {"@user", txtUsuario.Text},
                {"@pass", txtPassword.Text},
                {"@rol", cmbRol.SelectedItem.ToString()}
            }

            db.EjecutarComando(insertQuery, insertParams)
            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Clear()
            txtPassword.Clear()
            cmbRol.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
