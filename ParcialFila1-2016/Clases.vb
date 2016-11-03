Imports Oracle.DataAccess.Client
Public MustInherit Class Figuras
    Public MustOverride Function Perimetro() As Double
    Public MustOverride Function Area() As Double

End Class

Public Class Rectangulo
    Inherits Figuras
    Private vAltura As Double
    Private vBase As Double
    Public Property Altura() As Double
        Get
            Return vAltura
        End Get
        Set(value As Double)
            vAltura = value
        End Set
    End Property
    Public Property Base() As Double
        Get
            Return vBase
        End Get
        Set(value As Double)
            vBase = value
        End Set
    End Property

    Public Overrides Function Perimetro() As Double
        Return (2 * Base + 2 * Altura)
    End Function

    Public Overrides Function Area() As Double
        Return (Base * Altura)
    End Function

End Class

Public Class Cuadrado
    Inherits Figuras
    Private vLado As Double

    Public Property Lado() As Double
        Get
            Return vLado
        End Get
        Set(value As Double)
            vLado = value
        End Set
    End Property

    Public Overrides Function Perimetro() As Double
        Return 4 * Lado
    End Function

    Public Overrides Function Area() As Double
        Return Math.Pow(Lado, 2)
    End Function
End Class

Public Class Triangulo
    Inherits Figuras
    Private vLadoA As Double
    Private vLadoB As Double
    Private vLadoC As Double

    Public Property LadoA() As Double
        Get
            Return vLadoA
        End Get
        Set(value As Double)
            vLadoA = value
        End Set
    End Property

    Public Property LadoB() As Double
        Get
            Return vLadoB
        End Get
        Set(value As Double)
            vLadoB = value
        End Set
    End Property

    Public Property LadoC() As Double
        Get
            Return vLadoC
        End Get
        Set(value As Double)
            vLadoC = value
        End Set
    End Property

    Public Overrides Function Area() As Double
        Dim S As Double
        S = (LadoA + LadoB + LadoC) / 2
        Return Math.Sqrt(S * ((S - LadoA) * (S - LadoB) * (S - LadoC)))
    End Function

    Public Overrides Function Perimetro() As Double
        Return (LadoA + LadoB + LadoC)
    End Function

    Sub New()

    End Sub

    Sub New(a As Double, b As Double, c As Double)
        LadoA = a
        LadoB = b
        LadoC = c
    End Sub
End Class


Public Class EntornoDB

    Private Conn As New OracleConnection

    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=SYSTEM;" _
                                        + "Password=123456;"
    End Sub

    Public ReadOnly Property Conexion As OracleConnection
        Get
            Return Conn
        End Get
    End Property

    Private Sub Conectar()
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desconectar()
        Try
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ObtenerDatosDesdeSQL(SQL As String) As DataTable

        Dim Inmueble As New DataSet
        Dim Tabla As New DataTable
        Dim Adaptador As New OracleDataAdapter(SQL, Conexion)

        Adaptador.Fill(Inmueble, "inmueble")

        Tabla = Inmueble.Tables("inmueble")

        Return Tabla

    End Function

End Class
