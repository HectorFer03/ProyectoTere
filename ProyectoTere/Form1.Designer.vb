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
        btnLogin = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        btnRegistrar = New Button()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 19F)
        txtUsuario.Location = New Point(310, 117)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 41)
        txtUsuario.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 19F)
        txtPassword.Location = New Point(310, 174)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(192, 41)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 19F)
        btnLogin.Location = New Point(168, 232)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(183, 45)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Iniciar Sesion"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F)
        Label1.Location = New Point(168, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 36)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19F)
        Label2.Location = New Point(168, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 36)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 29F)
        Label4.Location = New Point(213, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(237, 52)
        Label4.TabIndex = 8
        Label4.Text = "Fothel Cards"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Font = New Font("Segoe UI", 19F)
        btnRegistrar.Location = New Point(383, 232)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(183, 45)
        btnRegistrar.TabIndex = 9
        btnRegistrar.Text = "Registro"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 311)
        Controls.Add(btnRegistrar)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistrar As Button

End Class
