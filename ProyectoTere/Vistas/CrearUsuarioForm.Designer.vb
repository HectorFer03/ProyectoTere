<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuarioForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnGuardar = New Button()
        txtPassword = New TextBox()
        txtUsuario = New TextBox()
        cmbRol = New ComboBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19F)
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 36)
        Label4.TabIndex = 15
        Label4.Text = "Crear Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(26, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 14
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(26, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 13
        Label1.Text = "Usuario"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 9F)
        btnGuardar.Location = New Point(53, 169)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(142, 28)
        btnGuardar.TabIndex = 12
        btnGuardar.Text = "Crear Usuario"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.Location = New Point(99, 96)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(192, 23)
        txtPassword.TabIndex = 11
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 9F)
        txtUsuario.Location = New Point(99, 61)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 23)
        txtUsuario.TabIndex = 10
        ' 
        ' cmbRol
        ' 
        cmbRol.Font = New Font("Segoe UI", 9F)
        cmbRol.FormattingEnabled = True
        cmbRol.Items.AddRange(New Object() {"Admin", "Revisor", "Vendedor"})
        cmbRol.Location = New Point(99, 125)
        cmbRol.Name = "cmbRol"
        cmbRol.Size = New Size(192, 23)
        cmbRol.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(26, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 15)
        Label3.TabIndex = 17
        Label3.Text = "Rol"
        ' 
        ' CrearUsuarioForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(cmbRol)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGuardar)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Name = "CrearUsuarioForm"
        Text = "CrearUsuarioForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Label3 As Label
End Class
