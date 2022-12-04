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

        If alumno.datosAceptados Then
            MsgBox("Alumno" & alumno.nombreAlumno & "Registrado")
        Else

        End If

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")

        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)
        End If
    End Sub

    Private Sub lblapellido_Click(sender As Object, e As EventArgs) Handles lblapellido.Click

    End Sub

    Private Sub RegistroAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
