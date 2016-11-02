Imports Oracle.DataAccess.Client

Public MustInherit Class Figuras
    'Viendo los atributos que tiene en comun las Clases hijas los nombre en la clase padre...Son los lados,Perimetro,Area
    'Podria haber hecho lo mismo con los Property pero en la consigna dice para cada clase
    Protected Perimetro As Double
    Protected Area As Double
    Protected Lado_A, Lado_B, Lado_C As Double
    Public MustOverride Function CalcularArea() As Double
    Public MustOverride Function CalcularSemiperiodo() As Double
End Class

Public Class Triangulo
    Inherits Figuras
    'Metodos de Acceso a los atributos
    Public WriteOnly Property IngresarLadoA() As Double
        Set(ByVal value As Double)
            Lado_A = value
        End Set
    End Property
    Public WriteOnly Property IngresarLadoB() As Double
        Set(ByVal value As Double)
            Lado_B = value
        End Set
    End Property
    Public WriteOnly Property IngresarLadoC() As Double
        Set(ByVal value As Double)
            Lado_C = value
        End Set
    End Property
    'Sobrecarga Del Constructor
    Public Sub New()

    End Sub
    Public Sub New(LadoA As Double, LadoB As Double, LadoC As Double)
        Lado_A = LadoA
        Lado_B = LadoB
        Lado_C = LadoC
    End Sub
    'Fin de la sobrecarga

    'Metodos Heredados
    Public Overrides Function CalcularArea() As Double
        Area = (Perimetro * (Perimetro - Lado_A) * (Perimetro - Lado_B) * (Perimetro - Lado_C))
        Return Math.Sqrt(Area)
    End Function
    Public Overrides Function CalcularSemiperiodo() As Double
        Perimetro = (Lado_A + Lado_B + Lado_C) / 2
        Return Perimetro
    End Function
    'Metodos Propios
    Public Function MostrarArea() As String
        Return ("Area = " + CalcularArea().ToString)
    End Function
    Public Function MostrarPerimetro() As String
        Return ("Perimetro = " + CalcularSemiperiodo().ToString)
    End Function
End Class
Public Class Rectangulo
    Inherits Figuras
    'Metodos de Acceso a los atributos

    Public WriteOnly Property IngresarLadoA() As Double
        Set(ByVal value As Double)
            Lado_A = value
        End Set
    End Property
    Public WriteOnly Property IngresarLadoB() As Double
        Set(ByVal value As Double)
            Lado_B = value
        End Set
    End Property
    'Metodos Heredados
    Public Overrides Function CalcularSemiperiodo() As Double
        Return 2 * (Lado_A + Lado_B)
    End Function
    Public Overrides Function CalcularArea() As Double
        Return (Lado_A * Lado_B)
    End Function
End Class
Public Class Cuadrado

    Inherits Figuras
    'Medoto de Acceso a los atributos
    Public WriteOnly Property IngresarLadoA() As Double
        Set(ByVal value As Double)
            Lado_A = value
        End Set
    End Property
    'Metodos Heredados
    Public Overrides Function CalcularSemiperiodo() As Double
        Return 4 * Lado_A
    End Function
    Public Overrides Function CalcularArea() As Double
        Return Math.Pow(Lado_A, 2)
    End Function

End Class

Public Class EntornoDB

    Private Conexion As New OracleConnection
    Private Sub Conectar()
        Try
            Conexion.ConnectionString = "Data Source= 192.168.0.106;" _
                                        + "User Id=JOEL;" _
                                        + "Password=jjbm5526;"
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
    Public Function ObtenerDatosDesdeSQL(SenteciaSQL) As DataTable
        Dim InmuebleDS As New DataSet
        Dim Adaptador As New OracleDataAdapter(SenteciaSQL, Conexion)
        Dim Tabla As New DataTable
        Try
            Conectar()
            Adaptador.Fill(InmuebleDS, "Inmueble")
            Tabla = InmuebleDS.Tables("Inmueble")
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Tabla
    End Function

End Class