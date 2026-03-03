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
        btnSalir = New Button()
        btnVentas = New Button()
        btnInventario = New Button()
        pnlMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMenu
        ' 
        pnlMenu.Controls.Add(btnSalir)
        pnlMenu.Controls.Add(btnVentas)
        pnlMenu.Controls.Add(btnInventario)
        pnlMenu.Location = New Point(12, 12)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(200, 426)
        pnlMenu.TabIndex = 0
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(0, 136)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(194, 40)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnVentas
        ' 
        btnVentas.Location = New Point(3, 88)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(194, 42)
        btnVentas.TabIndex = 2
        btnVentas.Text = "Ventas"
        btnVentas.UseVisualStyleBackColor = True
        ' 
        ' btnInventario
        ' 
        btnInventario.Location = New Point(3, 44)
        btnInventario.Name = "btnInventario"
        btnInventario.Size = New Size(197, 38)
        btnInventario.TabIndex = 1
        btnInventario.Text = "Inventario"
        btnInventario.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlMenu)
        Name = "DashboardForm"
        Text = "DashboardForm"
        pnlMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnInventario As Button
End Class
