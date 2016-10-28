Public Class Rectangulo
    Private Altura As Double
    Private Base As Double

    Public Function Perimetro() As Double
        Return (2 * Base + 2 * Altura)
    End Function

    Public Function Area() As Double
        Return (Base * Altura) / 2
    End Function

End Class

Public Class Cuadrado
    Private Lado As Double

    Public Function Perimetro() As Double
        Return 4 * Lado
    End Function

    Public Function Area() As Double
        Return Math.Pow(Lado, 2)
    End Function

End Class

Public Class Triangulo

End Class


Public Class EntornoDB

    Private Conn As New OracleConnection

    Public Sub New()
        Conexion.ConnectionString = ""
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

    Public Function ObtenerDatosDesdeSQL() As DataTable


    End Function

End Class