Imports ProyectoTere.Datos

Public Class Form1
    ' Instancia para conectarnos a la base de datos
    Private db As New AccesoDatos()

    ' LÓGICA DE INICIO DE SESIÓN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña.")
            Return
        End If

        ' Consultar si existe el usuario con esa contraseña
        Dim query As String = "SELECT id, username, rol FROM usuarios WHERE username = @user AND password = @pass"
        Dim params As New Dictionary(Of String, Object) From {
            {"@user", txtUsuario.Text},
            {"@pass", txtPassword.Text}
        }

        Dim dt = db.EjecutarConsulta(query, params)

        If dt.Rows.Count > 0 Then
            ' Guardar datos en la sesión estática global
            SesionGlobal.UsuarioId = Convert.ToInt32(dt.Rows(0)("id"))
            SesionGlobal.Username = dt.Rows(0)("username").ToString()
            SesionGlobal.Rol = dt.Rows(0)("rol").ToString() ' Admin, Revisor o Vendedor

            ' Abrir el Dashboard principal y ocultar el Login
            Dim dashboard As New DashboardForm()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If
    End Sub

    ' LÓGICA DE REGISTRO DE NUEVO USUARIO
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse cmbRol.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, complete todos los campos (Usuario, Contraseña y seleccione un Rol) para registrarse.")
            Return
        End If

        ' Verificar si el nombre de usuario ya existe en la base de datos
        Dim checkQuery As String = "SELECT COUNT(*) FROM usuarios WHERE username = @user"
        Dim checkParams As New Dictionary(Of String, Object) From {{"@user", txtUsuario.Text}}
        Dim dtCheck = db.EjecutarConsulta(checkQuery, checkParams)

        If Convert.ToInt32(dtCheck.Rows(0)(0)) > 0 Then
            MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.")
            Return
        End If

        ' Insertar el nuevo usuario en la tabla
        Dim insertQuery As String = "INSERT INTO usuarios (username, password, rol) VALUES (@user, @pass, @rol)"
        Dim insertParams As New Dictionary(Of String, Object) From {
            {"@user", txtUsuario.Text},
            {"@pass", txtPassword.Text},
            {"@rol", cmbRol.SelectedItem.ToString()}
        }

        Dim filasAfectadas As Integer = db.EjecutarComando(insertQuery, insertParams)

        If filasAfectadas > 0 Then
            MessageBox.Show("Usuario registrado con éxito. Ahora puede iniciar sesión con sus credenciales.")
            ' Limpiamos los campos después de registrar
            txtUsuario.Clear()
            txtPassword.Clear()
            cmbRol.SelectedIndex = -1
        Else
            MessageBox.Show("Ocurrió un error al registrar el usuario.")
        End If
    End Sub
End Class
