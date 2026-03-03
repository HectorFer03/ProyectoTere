<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        pnlMenu = New Panel()
        btnActualizar = New Button()
        btnSalir = New Button()
        btnConsultas = New Button()
        btnVentas = New Button()
        btnInventario = New Button()
        pnlContenedor = New Panel()
        pnlMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMenu
        ' 
        pnlMenu.Controls.Add(btnActualizar)
        pnlMenu.Controls.Add(btnSalir)
        pnlMenu.Controls.Add(btnConsultas)
        pnlMenu.Controls.Add(btnVentas)
        pnlMenu.Controls.Add(btnInventario)
        pnlMenu.Location = New Point(12, 12)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(200, 426)
        pnlMenu.TabIndex = 0
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = SystemColors.ActiveCaption
        btnActualizar.Location = New Point(3, 136)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(194, 40)
        btnActualizar.TabIndex = 5
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.IndianRed
        btnSalir.Location = New Point(3, 228)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(194, 40)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnConsultas
        ' 
        btnConsultas.BackColor = Color.Moccasin
        btnConsultas.Location = New Point(3, 182)
        btnConsultas.Name = "btnConsultas"
        btnConsultas.Size = New Size(194, 40)
        btnConsultas.TabIndex = 3
        btnConsultas.Text = "Consultas"
        btnConsultas.UseVisualStyleBackColor = False
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = Color.Moccasin
        btnVentas.Location = New Point(3, 88)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(194, 42)
        btnVentas.TabIndex = 2
        btnVentas.Text = "Ventas"
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnInventario
        ' 
        btnInventario.BackColor = SystemColors.ActiveCaption
        btnInventario.FlatAppearance.BorderColor = Color.White
        btnInventario.ForeColor = SystemColors.ActiveCaptionText
        btnInventario.Location = New Point(3, 44)
        btnInventario.Name = "btnInventario"
        btnInventario.Size = New Size(197, 38)
        btnInventario.TabIndex = 1
        btnInventario.Text = "Inventario"
        btnInventario.UseVisualStyleBackColor = False
        ' 
        ' pnlContenedor
        ' 
        pnlContenedor.Location = New Point(232, 12)
        pnlContenedor.Name = "pnlContenedor"
        pnlContenedor.Size = New Size(556, 426)
        pnlContenedor.TabIndex = 6
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlContenedor)
        Controls.Add(pnlMenu)
        Name = "DashboardForm"
        Text = "DashboardForm"
        pnlMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlContenedor As Panel
End Class
