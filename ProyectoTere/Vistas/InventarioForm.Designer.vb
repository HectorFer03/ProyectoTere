<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioForm
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
        DataGridView1 = New DataGridView()
        cmbTipo = New ComboBox()
        txtFranquicia = New TextBox()
        txtNumSerie = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        nudValorMercado = New NumericUpDown()
        nudPrecioCoste = New NumericUpDown()
        txtDescripcion = New TextBox()
        txtStock = New TextBox()
        btnGuardar = New Button()
        btnEliminar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudValorMercado, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrecioCoste, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-1, -2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(801, 452)
        DataGridView1.TabIndex = 0
        ' 
        ' cmbTipo
        ' 
        cmbTipo.FormattingEnabled = True
        cmbTipo.Location = New Point(89, 20)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(121, 23)
        cmbTipo.TabIndex = 1
        ' 
        ' txtFranquicia
        ' 
        txtFranquicia.Location = New Point(89, 49)
        txtFranquicia.Name = "txtFranquicia"
        txtFranquicia.Size = New Size(100, 23)
        txtFranquicia.TabIndex = 2
        ' 
        ' txtNumSerie
        ' 
        txtNumSerie.Location = New Point(89, 78)
        txtNumSerie.Name = "txtNumSerie"
        txtNumSerie.Size = New Size(100, 23)
        txtNumSerie.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 4
        Label1.Text = "Tipo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 5
        Label2.Text = "Nº Serie"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 6
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 7
        Label4.Text = "Franquicia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 136)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 8
        Label5.Text = "Valor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 9
        Label6.Text = "Stock"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 163)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 15)
        Label7.TabIndex = 10
        Label7.Text = "Descripcion"
        ' 
        ' nudValorMercado
        ' 
        nudValorMercado.Location = New Point(90, 134)
        nudValorMercado.Name = "nudValorMercado"
        nudValorMercado.Size = New Size(120, 23)
        nudValorMercado.TabIndex = 11
        ' 
        ' nudPrecioCoste
        ' 
        nudPrecioCoste.Location = New Point(89, 107)
        nudPrecioCoste.Name = "nudPrecioCoste"
        nudPrecioCoste.Size = New Size(120, 23)
        nudPrecioCoste.TabIndex = 12
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(90, 160)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(100, 23)
        txtDescripcion.TabIndex = 13
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(90, 189)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 14
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(46, 245)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 15
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(146, 245)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' InventarioForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(txtStock)
        Controls.Add(txtDescripcion)
        Controls.Add(nudPrecioCoste)
        Controls.Add(nudValorMercado)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNumSerie)
        Controls.Add(txtFranquicia)
        Controls.Add(cmbTipo)
        Controls.Add(DataGridView1)
        Name = "InventarioForm"
        Text = "InventarioForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudValorMercado, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrecioCoste, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents txtFranquicia As TextBox
    Friend WithEvents txtNumSerie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nudValorMercado As NumericUpDown
    Friend WithEvents nudPrecioCoste As NumericUpDown
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
End Class
