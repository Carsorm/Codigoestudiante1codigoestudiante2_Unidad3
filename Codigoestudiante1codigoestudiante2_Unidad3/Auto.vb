Public Class Auto
    'Declaracion de propiedades
    Private placa As String
    Private marca As String
    Private modelo As String
    Private tipo As String
    Private direccion As String
    Private color As String
    Private capacidad As String
    Private año As String

    'indica si los datos ingresaados estan completos
    Private datosCompletos As Boolean

    'Metodos de propiedad
    'Metodo para la marca del auto
    Public Property marcaAuto() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    'metodo para el modelo del auto
    Public Property modeloAuto() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    'metodo para el tipo de auto
    Public Property tipoAuto() As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'Metodo para la direccion del dueño
    Public Property direccionAuto() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Metodo para el color del auto
    Public Property colorAuto() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    'Metodo para la capacidad del auto
    Public Property capacidadAuto() As String
        Get
            Return capacidad
        End Get
        Set(value As String)
            capacidad = value
        End Set
    End Property

    'Metodo para el año del auto
    Public Property añoAuto() As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property


    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property

    'Metodos
    'Constructor de la clase
    Public Sub New()
        datosCompletos = False
        'determina si los datos aun no han sido ingresados
    End Sub

    'determina si los datos ingresados son correctos y asigna atributos de la clase
    Public Sub datosAuto(ByVal placaA As String,
                           ByVal marcaA As String,
                           ByVal modeloA As String,
                           ByVal tipoA As String,
                           ByVal direccionA As String,
                           ByVal colorA As String,
                           ByVal capacidadA As String,
                           ByVal añoA As String)
        datosCompletos = False 'asume que los datos recibidos son incorrectos

        If placaA.Length = 0 Then
            MsgBox("Debe generar el numero de placa del vehiculo")
            Exit Sub
        Else
            placa = placaA
        End If

        If marcaA.Length = 0 Then
            MsgBox("Debe escribir la marca del vehiculo")
            Exit Sub
        Else
            marca = marcaA
        End If

        If modeloA.Length = 0 Then
            MsgBox("Debe escribir el modelo del vehiculo")
            Exit Sub
        Else
            modelo = modeloA
        End If

        If tipoA.Length = 0 Then
            MsgBox("Debe escribir el tipo de vehiculo")
            Exit Sub
        Else
            tipo = tipoA
        End If

        If direccionA.Length = 0 Then
            MsgBox("Debe escribir la direccion del dueño")
            Exit Sub
        Else
            direccion = direccionA
        End If

        If colorA.Length = 0 Then
            MsgBox("Debe ingresar el color del vehiculo")
        Else
            color = colorA
        End If

        If capacidadA.Length = 0 Then
            MsgBox("Debe ingresar la capacidad del vehiculo")
        Else
            capacidad = capacidadA
        End If

        If añoA.Length = 0 Then
            MsgBox("Debe ingresar el año del vehiculo")
        Else
            año = añoA
            datosCompletos = True
        End If

    End Sub

    Public Function generarCodigo(ByVal marca As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(marca, 1))
        valor2 = Right(marca, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2
    End Function
End Class
