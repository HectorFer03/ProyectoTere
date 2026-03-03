Imports ProyectoTere.Datos

Public Class Form1
    Private db As New AccesoDatos()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Ingrese usuario y contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query = "SELECT id, username, rol FROM usuarios WHERE username = @user AND password = @pass"
            Dim params As New Dictionary(Of String, Object) From {
                {"@user", txtUsuario.Text},
                {"@pass", txtPassword.Text}
            }
            Dim dt = db.EjecutarConsulta(query, params)

            If dt.Rows.Count > 0 Then
                SesionGlobal.UsuarioId = Convert.ToInt32(dt.Rows(0)("id"))
                SesionGlobal.Username = dt.Rows(0)("username").ToString
                SesionGlobal.Rol = dt.Rows(0)("rol").ToString

                Dim dashboard As New DashboardForm
                dashboard.Show()
                Hide()
            Else
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
