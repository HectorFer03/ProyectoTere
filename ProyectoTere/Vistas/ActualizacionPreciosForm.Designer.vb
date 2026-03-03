<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizacionPreciosForm
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
        cmbCategoria = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFranquiciaObjetivo = New TextBox()
        nudPorcentaje = New NumericUpDown()
        btnActualizarMasivo = New Button()
        CType(nudPorcentaje, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Items.AddRange(New Object() {"Cartas TGC", "Figuras", "Comics/Manga"})
        cmbCategoria.Location = New Point(118, 12)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(121, 23)
        cmbCategoria.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 1
        Label1.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 2
        Label2.Text = "Franquicia"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 3
        Label3.Text = "Porcentaje Act."
        ' 
        ' txtFranquiciaObjetivo
        ' 
        txtFranquiciaObjetivo.Location = New Point(119, 49)
        txtFranquiciaObjetivo.Name = "txtFranquiciaObjetivo"
        txtFranquiciaObjetivo.Size = New Size(100, 23)
        txtFranquiciaObjetivo.TabIndex = 4
        ' 
        ' nudPorcentaje
        ' 
        nudPorcentaje.Location = New Point(119, 83)
        nudPorcentaje.Name = "nudPorcentaje"
        nudPorcentaje.Size = New Size(120, 23)
        nudPorcentaje.TabIndex = 5
        ' 
        ' btnActualizarMasivo
        ' 
        btnActualizarMasivo.Location = New Point(80, 137)
        btnActualizarMasivo.Name = "btnActualizarMasivo"
        btnActualizarMasivo.Size = New Size(75, 23)
        btnActualizarMasivo.TabIndex = 6
        btnActualizarMasivo.Text = "Actualizar"
        btnActualizarMasivo.UseVisualStyleBackColor = True
        ' 
        ' ActualizacionPreciosForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnActualizarMasivo)
        Controls.Add(nudPorcentaje)
        Controls.Add(txtFranquiciaObjetivo)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbCategoria)
        Name = "ActualizacionPreciosForm"
        Text = "ActualizacionPreciosForm"
        CType(nudPorcentaje, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFranquiciaObjetivo As TextBox
    Friend WithEvents nudPorcentaje As NumericUpDown
    Friend WithEvents btnActualizarMasivo As Button
End Class
