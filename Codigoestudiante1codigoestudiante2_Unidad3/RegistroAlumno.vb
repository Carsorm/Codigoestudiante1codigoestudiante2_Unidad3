Public Class RegistroAlumno
    Dim alumno As New Alumno
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        alumno.datosAlumno(txtCodigo.Text,
                           txtNombre.Text,
                           txtApellido.Text,
                           txtSexo.Text,
                           txtDireccion.Text,
                           txtEdad.Text,
                           txtDui.Text,
                           txtCorreo.Text)

        datosAlumno.Rows.Add(txtCodigo.Text,
                             alumno.nombreAlumno,
                             alumno.apellidoAlumno,
                             alumno.sexoAlumno,
                             alumno.direccionAlumno,
                             alumno.edadAlumno,
                             alumno.duiAlumno,
                             alumno.correoAlumno)

        If alumno.datosAceptados Then
            MsgBox("Alumno" & alumno.nombreAlumno & "Registrado con Exito")
        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtSexo.Text = ""
        txtDireccion.Text = ""
        txtEdad.Text = ""
        txtDui.Text = ""
        txtCorreo.Text = ""

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")

        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)

        End If

    End Sub
End Class
