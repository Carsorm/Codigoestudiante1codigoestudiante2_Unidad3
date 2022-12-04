<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAlumno
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.lbldui = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.lblsexo = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.grpCodigo.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(204, 32)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(122, 21)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Location = New System.Drawing.Point(51, 12)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(332, 78)
        Me.grpCodigo.TabIndex = 2
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo Alumno"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(7, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(191, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtCorreo)
        Me.grpDatos.Controls.Add(Me.lblcorreo)
        Me.grpDatos.Controls.Add(Me.txtDui)
        Me.grpDatos.Controls.Add(Me.lbldui)
        Me.grpDatos.Controls.Add(Me.txtEdad)
        Me.grpDatos.Controls.Add(Me.lbledad)
        Me.grpDatos.Controls.Add(Me.btnAgregar)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.lbldireccion)
        Me.grpDatos.Controls.Add(Me.txtSexo)
        Me.grpDatos.Controls.Add(Me.lblsexo)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.lblapellido)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.lblnombre)
        Me.grpDatos.Location = New System.Drawing.Point(51, 96)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(686, 342)
        Me.grpDatos.TabIndex = 3
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumno"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(58, 231)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(268, 20)
        Me.txtCorreo.TabIndex = 14
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(15, 234)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblcorreo.TabIndex = 13
        Me.lblcorreo.Text = "Correo"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(58, 199)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(177, 20)
        Me.txtDui.TabIndex = 12
        '
        'lbldui
        '
        Me.lbldui.AutoSize = True
        Me.lbldui.Location = New System.Drawing.Point(12, 202)
        Me.lbldui.Name = "lbldui"
        Me.lbldui.Size = New System.Drawing.Size(26, 13)
        Me.lbldui.TabIndex = 11
        Me.lbldui.Text = "DUI"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(58, 168)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(62, 20)
        Me.txtEdad.TabIndex = 10
        '
        'lbledad
        '
        Me.lbledad.AutoSize = True
        Me.lbledad.Location = New System.Drawing.Point(9, 175)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(32, 13)
        Me.lbledad.TabIndex = 9
        Me.lbledad.Text = "Edad"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(543, 313)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(137, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(58, 138)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(340, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(9, 141)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 6
        Me.lbldireccion.Text = "Direccion"
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(58, 106)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(62, 20)
        Me.txtSexo.TabIndex = 5
        '
        'lblsexo
        '
        Me.lblsexo.AutoSize = True
        Me.lblsexo.Location = New System.Drawing.Point(9, 109)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(31, 13)
        Me.lblsexo.TabIndex = 4
        Me.lblsexo.Text = "Sexo"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(58, 73)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(268, 20)
        Me.txtApellido.TabIndex = 3
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(8, 76)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(44, 13)
        Me.lblapellido.TabIndex = 2
        Me.lblapellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(58, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(7, 42)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        '
        'RegistroAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Name = "RegistroAlumno"
        Me.Text = "Formulario de registro de alumnos"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbldireccion As Label
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents lblsexo As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblapellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lbledad As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents txtDui As TextBox
    Friend WithEvents lbldui As Label
End Class
