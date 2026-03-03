Imports MySql.Data.MySqlClient
Imports System.Data

Namespace Datos
    Public Class AccesoDatos
        ' Cambia el puerto o contraseña según tu XAMPP/MySQL
        Private ReadOnly connectionString As String = "Server=localhost;Port=3306;Database=proyectotere_db;Uid=root;Pwd=root;"

        Public Function EjecutarConsulta(query As String, Optional parametros As Dictionary(Of String, Object) = Nothing) As DataTable
            Dim tabla As New DataTable()
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    If parametros IsNot Nothing Then
                        For Each kvp In parametros
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                        Next
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(tabla)
                    End Using
                End Using
            End Using
            Return tabla
        End Function

        Public Function EjecutarComando(query As String, Optional parametros As Dictionary(Of String, Object) = Nothing) As Integer
            Dim filasAfectadas As Integer = 0
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    If parametros IsNot Nothing Then
                        For Each kvp In parametros
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                        Next
                    End If
                    filasAfectadas = cmd.ExecuteNonQuery()
                End Using
            End Using
            Return filasAfectadas
        End Function
    End Class

    ' Clase estática para saber quién ha iniciado sesión y su rol
    Public Class SesionGlobal
        Public Shared UsuarioId As Integer
        Public Shared Username As String
        Public Shared Rol As String ' Admin, Revisor o Vendedor
    End Class
End Namespace
