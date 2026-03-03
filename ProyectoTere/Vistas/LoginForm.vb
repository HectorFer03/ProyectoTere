Imports ProyectoTere.Datos

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New AccesoDatos()
        Dim query As String = "SELECT id, username, rol FROM usuarios WHERE username = @user AND password = @pass"
        Dim params As New Dictionary(Of String, Object) From {
            {"@user", txtUsuario.Text},
            {"@pass", txtPassword.Text}
        }

        Dim dt = db.EjecutarConsulta(query, params)

        If dt.Rows.Count > 0 Then
            ' Guardar datos en la sesión estática
            SesionGlobal.UsuarioId = Convert.ToInt32(dt.Rows(0)("id"))
            SesionGlobal.Username = dt.Rows(0)("username").ToString()
            SesionGlobal.Rol = dt.Rows(0)("rol").ToString() ' Admin, Revisor o Vendedor

            Dim dashboard As New DashboardForm()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If
    End Sub
End Class