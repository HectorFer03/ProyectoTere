Imports ProyectoTere.Datos


Public Class CrearUsuarioForm
    Private db As New AccesoDatos()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validaciones básicas
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse cmbRol.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, complete todos los campos y seleccione un rol.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Verificar si el usuario ya existe
            Dim consultaExiste As String = "SELECT COUNT(*) FROM usuarios WHERE username = @user"
            Dim parametrosExiste As New Dictionary(Of String, Object) From {{"@user", txtUsuario.Text}}
            Dim resultado = db.EjecutarConsulta(consultaExiste, parametrosExiste)

            If Convert.ToInt32(resultado.Rows(0)(0)) > 0 Then
                MessageBox.Show("El nombre de usuario ya está registrado.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 3. Insertar nuevo usuario con el rol seleccionado
            Dim consultaInsertar As String = "INSERT INTO usuarios (username, password, rol) VALUES (@user, @pass, @rol)"
            Dim parametrosInsertar As New Dictionary(Of String, Object) From {
                {"@user", txtUsuario.Text},
                {"@pass", txtPassword.Text},
                {"@rol", cmbRol.SelectedItem.ToString()}
            }

            db.EjecutarComando(consultaInsertar, parametrosInsertar)
            MessageBox.Show("Nuevo usuario '" & txtUsuario.Text & "' creado con éxito como " & cmbRol.SelectedItem.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos
            txtUsuario.Clear()
            txtPassword.Clear()
            cmbRol.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al crear usuario: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class