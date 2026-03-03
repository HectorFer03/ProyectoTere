<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        cmbRol = New ComboBox()
        btnLogin = New Button()
        btnRegistrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 19F)
        txtUsuario.Location = New Point(154, 9)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 41)
        txtUsuario.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 19F)
        txtPassword.Location = New Point(154, 66)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(192, 41)
        txtPassword.TabIndex = 1
        ' 
        ' cmbRol
        ' 
        cmbRol.Font = New Font("Segoe UI", 19F)
        cmbRol.FormattingEnabled = True
        cmbRol.Items.AddRange(New Object() {"Admin", "Revisor", "Vendedor"})
        cmbRol.Location = New Point(154, 132)
        cmbRol.Name = "cmbRol"
        cmbRol.Size = New Size(192, 43)
        cmbRol.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 19F)
        btnLogin.Location = New Point(12, 195)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(183, 45)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Iniciar Sesion"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Font = New Font("Segoe UI", 19F)
        btnRegistrar.Location = New Point(201, 195)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(162, 45)
        btnRegistrar.TabIndex = 4
        btnRegistrar.Text = "Registrarse"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 36)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19F)
        Label2.Location = New Point(12, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 36)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 19F)
        Label3.Location = New Point(12, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 36)
        Label3.TabIndex = 7
        Label3.Text = "Rol"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 250)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRegistrar)
        Controls.Add(btnLogin)
        Controls.Add(cmbRol)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
