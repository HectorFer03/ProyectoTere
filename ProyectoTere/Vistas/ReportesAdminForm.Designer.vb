<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesAdminForm
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
        dgvReportes = New DataGridView()
        btnInventarioValorado = New Button()
        btnOrdenadosPorPrecio = New Button()
        btnMasVendido = New Button()
        btnVentasPorUsuario = New Button()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReportes
        ' 
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Location = New Point(-2, 51)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.Size = New Size(571, 400)
        dgvReportes.TabIndex = 0
        ' 
        ' btnInventarioValorado
        ' 
        btnInventarioValorado.Location = New Point(1, -1)
        btnInventarioValorado.Name = "btnInventarioValorado"
        btnInventarioValorado.Size = New Size(115, 26)
        btnInventarioValorado.TabIndex = 1
        btnInventarioValorado.Text = "Ver Inventario"
        btnInventarioValorado.UseVisualStyleBackColor = True
        ' 
        ' btnOrdenadosPorPrecio
        ' 
        btnOrdenadosPorPrecio.Location = New Point(137, -1)
        btnOrdenadosPorPrecio.Name = "btnOrdenadosPorPrecio"
        btnOrdenadosPorPrecio.Size = New Size(137, 26)
        btnOrdenadosPorPrecio.TabIndex = 2
        btnOrdenadosPorPrecio.Text = "Mayor a menor precio"
        btnOrdenadosPorPrecio.UseVisualStyleBackColor = True
        ' 
        ' btnMasVendido
        ' 
        btnMasVendido.Location = New Point(296, -1)
        btnMasVendido.Name = "btnMasVendido"
        btnMasVendido.Size = New Size(144, 26)
        btnMasVendido.TabIndex = 3
        btnMasVendido.Text = "Articulos Mas Vendidos"
        btnMasVendido.UseVisualStyleBackColor = True
        ' 
        ' btnVentasPorUsuario
        ' 
        btnVentasPorUsuario.Location = New Point(454, -1)
        btnVentasPorUsuario.Name = "btnVentasPorUsuario"
        btnVentasPorUsuario.Size = New Size(115, 26)
        btnVentasPorUsuario.TabIndex = 4
        btnVentasPorUsuario.Text = "Ventas por Usuario"
        btnVentasPorUsuario.UseVisualStyleBackColor = True
        ' 
        ' ReportesAdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 450)
        Controls.Add(btnVentasPorUsuario)
        Controls.Add(btnMasVendido)
        Controls.Add(btnOrdenadosPorPrecio)
        Controls.Add(btnInventarioValorado)
        Controls.Add(dgvReportes)
        Name = "ReportesAdminForm"
        Text = "ReportesAdminForm"
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents btnInventarioValorado As Button
    Friend WithEvents btnOrdenadosPorPrecio As Button
    Friend WithEvents btnMasVendido As Button
    Friend WithEvents btnVentasPorUsuario As Button
End Class
