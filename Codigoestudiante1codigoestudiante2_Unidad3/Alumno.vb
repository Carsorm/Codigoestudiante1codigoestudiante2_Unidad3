Public Class Alumno
    'Declaracion de propiedades
    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private sexo As String
    Private direccion As String
    Private dui As String
    Private edad As String
    Private correo As String

    'indica si los datos ingresaados estan completos
    Private datosCompletos As Boolean

    'Metodos de propiedad
    'Metodo para nombre del alumno
    Public Property nombreAlumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    'metodo para apellido del alumno
    Public Property apellidoAlumno() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    'metodo para el sexo del alumno
    Public Property sexoAlumno() As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    'Metodo para direccion del alumno
    Public Property direccionAlumno() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Metodo para el dui del alumno
    Public Property duiAlumno() As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    'Metodo para la edad del alumno
    Public Property edadAlumno() As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    'Metodo para el correo del alumno
    Public Property correoAlumno() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
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
    Public Sub datosAlumno(ByVal codigoA As String,
                           ByVal nombreA As String,
                           ByVal apellidoA As String,
                           ByVal sexoA As String,
                           ByVal direccionA As String,
                           ByVal duiA As String,
                           ByVal edadA As String,
                           ByVal correoA As String)
        datosCompletos = False 'asume que los datos recibidos son incorrectos

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo del alumno")
            Exit Sub
        Else
            codigo = codigoA
        End If

        If nombreA.Length = 0 Then
            MsgBox("Debe escribir el nombre del alumno")
            Exit Sub
        Else
            nombre = nombreA
        End If

        If apellidoA.Length = 0 Then
            MsgBox("Debe escribir el apellido del alumno")
            Exit Sub
        Else
            apellido = apellidoA
        End If

        If sexoA.Length = 0 Then
            MsgBox("Debe escribir el sexo del alumno")
            Exit Sub
        Else
            sexo = sexoA
        End If
        If sexoA = "F" Or sexoA = "M" Then
        Else
            MsgBox("Debe escribir F para femenino o M para masculino")
            Exit Sub
        End If

        If direccionA.Length = 0 Then
            MsgBox("Debe escribir la direccion del alumno")
            Exit Sub
        Else
            direccion = direccionA
        End If

        If duiA.Length = 0 Then
            MsgBox("Debe ingresar un numero de dui valido")
        Else
            dui = duiA
        End If

        If edadA.Length = 0 Then
            MsgBox("Debe ingresar su edad")
        Else
            edad = edadA
        End If

        If correoA.Length = 0 Then
            MsgBox("Debe ingresar una direccion de correo")
        Else
            correo = correoA
            datosCompletos = True
        End If

    End Sub

    Public Function generarCodigo(ByVal nombre As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2
    End Function
End Class