<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtIdArticulo = New TextBox()
        txtIdVentaHistorico = New TextBox()
        txtEstadoEntrega = New TextBox()
        GroupBox1 = New GroupBox()
        btnVender = New Button()
        GroupBox2 = New GroupBox()
        btnDevolver = New Button()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Estado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 15)
        Label3.TabIndex = 2
        Label3.Text = "ID"
        ' 
        ' txtIdArticulo
        ' 
        txtIdArticulo.Location = New Point(94, 22)
        txtIdArticulo.Name = "txtIdArticulo"
        txtIdArticulo.Size = New Size(100, 23)
        txtIdArticulo.TabIndex = 3
        ' 
        ' txtIdVentaHistorico
        ' 
        txtIdVentaHistorico.Location = New Point(83, 26)
        txtIdVentaHistorico.Name = "txtIdVentaHistorico"
        txtIdVentaHistorico.Size = New Size(100, 23)
        txtIdVentaHistorico.TabIndex = 4
        ' 
        ' txtEstadoEntrega
        ' 
        txtEstadoEntrega.Location = New Point(94, 60)
        txtEstadoEntrega.Name = "txtEstadoEntrega"
        txtEstadoEntrega.Size = New Size(100, 23)
        txtEstadoEntrega.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnVender)
        GroupBox1.Controls.Add(txtEstadoEntrega)
        GroupBox1.Controls.Add(txtIdArticulo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(33, 67)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 127)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nueva Venta"
        ' 
        ' btnVender
        ' 
        btnVender.Location = New Point(52, 89)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(75, 23)
        btnVender.TabIndex = 7
        btnVender.Text = "Vender"
        btnVender.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnDevolver)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtIdVentaHistorico)
        GroupBox2.Location = New Point(33, 200)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Devoluciones"
        ' 
        ' btnDevolver
        ' 
        btnDevolver.Location = New Point(53, 55)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(75, 23)
        btnDevolver.TabIndex = 8
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19F)
        Label4.Location = New Point(33, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(268, 36)
        Label4.TabIndex = 8
        Label4.Text = "Ventas y devoluciones"
        ' 
        ' VentasForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "VentasForm"
        Text = "VentasForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtIdVentaHistorico As TextBox
    Friend WithEvents txtEstadoEntrega As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDevolver As Button
    Friend WithEvents Label4 As Label
End Class
