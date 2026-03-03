<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsuario = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 29F)
        Label4.Location = New Point(278, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 52)
        Label4.TabIndex = 14
        Label4.Text = "Registro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19F)
        Label2.Location = New Point(233, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 36)
        Label2.TabIndex = 13
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F)
        Label1.Location = New Point(233, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 36)
        Label1.TabIndex = 12
        Label1.Text = "Usuario"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 19F)
        btnLogin.Location = New Point(304, 303)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(183, 45)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Registrar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 19F)
        txtPassword.Location = New Point(375, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(192, 41)
        txtPassword.TabIndex = 10
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 19F)
        txtUsuario.Location = New Point(375, 185)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 41)
        txtUsuario.TabIndex = 9
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Name = "Registro"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
