<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAuto
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
        Me.grpGenerar = New System.Windows.Forms.GroupBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.grpAgregar = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.datosAuto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpGenerar.SuspendLayout()
        Me.grpAgregar.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        CType(Me.datosAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGenerar
        '
        Me.grpGenerar.Controls.Add(Me.btnGenerar)
        Me.grpGenerar.Controls.Add(Me.txtPlaca)
        Me.grpGenerar.Location = New System.Drawing.Point(13, 13)
        Me.grpGenerar.Name = "grpGenerar"
        Me.grpGenerar.Size = New System.Drawing.Size(565, 100)
        Me.grpGenerar.TabIndex = 0
        Me.grpGenerar.TabStop = False
        Me.grpGenerar.Text = "Generar Placa"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(290, 43)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(238, 20)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar Placa"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(51, 43)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.ReadOnly = True
        Me.txtPlaca.Size = New System.Drawing.Size(214, 20)
        Me.txtPlaca.TabIndex = 0
        '
        'grpAgregar
        '
        Me.grpAgregar.Controls.Add(Me.btnAgregar)
        Me.grpAgregar.Location = New System.Drawing.Point(634, 12)
        Me.grpAgregar.Name = "grpAgregar"
        Me.grpAgregar.Size = New System.Drawing.Size(304, 100)
        Me.grpAgregar.TabIndex = 1
        Me.grpAgregar.TabStop = False
        Me.grpAgregar.Text = "Agregar auto"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(43, 43)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(232, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar auto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtColor)
        Me.grpDatos.Controls.Add(Me.txtAño)
        Me.grpDatos.Controls.Add(Me.txtCapacidad)
        Me.grpDatos.Controls.Add(Me.lblColor)
        Me.grpDatos.Controls.Add(Me.lblCapacidad)
        Me.grpDatos.Controls.Add(Me.lblAño)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.lblDireccion)
        Me.grpDatos.Controls.Add(Me.txtModelo)
        Me.grpDatos.Controls.Add(Me.txtTipo)
        Me.grpDatos.Controls.Add(Me.lblTipo)
        Me.grpDatos.Controls.Add(Me.lblModelo)
        Me.grpDatos.Controls.Add(Me.txtMarca)
        Me.grpDatos.Controls.Add(Me.lblMarca)
        Me.grpDatos.Location = New System.Drawing.Point(13, 120)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(925, 182)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos del auto"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(7, 20)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(51, 20)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(214, 20)
        Me.txtMarca.TabIndex = 1
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(523, 23)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 2
        Me.lblModelo.Text = "Modelo"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 60)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(51, 57)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(214, 20)
        Me.txtTipo.TabIndex = 5
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(571, 20)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(214, 20)
        Me.txtModelo.TabIndex = 6
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(513, 60)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 7
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(571, 57)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(214, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(7, 93)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(26, 13)
        Me.lblAño.TabIndex = 9
        Me.lblAño.Text = "Año"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Location = New System.Drawing.Point(507, 93)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(58, 13)
        Me.lblCapacidad.TabIndex = 10
        Me.lblCapacidad.Text = "Capacidad"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(7, 125)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 11
        Me.lblColor.Text = "Color"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(571, 90)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(92, 20)
        Me.txtCapacidad.TabIndex = 12
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(51, 93)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(92, 20)
        Me.txtAño.TabIndex = 13
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(51, 122)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(214, 20)
        Me.txtColor.TabIndex = 14
        '
        'datosAuto
        '
        Me.datosAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAuto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.datosAuto.Location = New System.Drawing.Point(13, 309)
        Me.datosAuto.Name = "datosAuto"
        Me.datosAuto.Size = New System.Drawing.Size(925, 122)
        Me.datosAuto.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Placa"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Marca"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Modelo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Tipo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Direccion"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Año"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Capacidad"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Color"
        Me.Column8.Name = "Column8"
        '
        'RegistroAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 443)
        Me.Controls.Add(Me.datosAuto)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpAgregar)
        Me.Controls.Add(Me.grpGenerar)
        Me.Name = "RegistroAuto"
        Me.Text = "Formulario de registro de vehiculos"
        Me.grpGenerar.ResumeLayout(False)
        Me.grpGenerar.PerformLayout()
        Me.grpAgregar.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.datosAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpGenerar As GroupBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents grpAgregar As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents datosAuto As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
