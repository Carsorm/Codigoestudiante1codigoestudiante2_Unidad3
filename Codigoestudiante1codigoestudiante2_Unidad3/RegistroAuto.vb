Public Class RegistroAuto
    Dim auto As New Auto
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        auto.datosAuto(txtPlaca.Text,
                           txtMarca.Text,
                           txtModelo.Text,
                           txtTipo.Text,
                           txtDireccion.Text,
                           txtColor.Text,
                           txtCapacidad.Text,
                           txtAño.Text)

        datosAuto.Rows.Add(txtPlaca.Text,
                             auto.marcaAuto,
                             auto.modeloAuto,
                             auto.tipoAuto,
                             auto.direccionAuto,
                             auto.colorAuto,
                             auto.capacidadAuto,
                             auto.añoAuto)

        If auto.datosAceptados Then
            MsgBox("Vehiculo" & auto.marcaAuto & "Registrado con Exito")
        End If

        txtPlaca.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtTipo.Text = ""
        txtDireccion.Text = ""
        txtColor.Text = ""
        txtCapacidad.Text = ""
        txtAño.Text = ""

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtMarca.Text = "" Then
            MsgBox("Debe ingresar la marca")

        Else
            txtPlaca.Text = auto.generarCodigo(txtMarca.Text)

        End If

    End Sub

    Private Sub lblCapacidad_Click(sender As Object, e As EventArgs) Handles lblCapacidad.Click

    End Sub
End Class