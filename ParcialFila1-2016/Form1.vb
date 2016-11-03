Public Class Form1
    Private oRectangulo As New Rectangulo
    Private oCuadrado As New Cuadrado
    Private oTriangulo As New Triangulo(3, 3, 3)

    Private Sub btnFiguras_Click(sender As Object, e As EventArgs) Handles btnFiguras.Click
        'para mostrar polimorfismo nomas
        oRectangulo.Altura = txtAltura.Text
        oRectangulo.Base = txtBase.Text
        oCuadrado.Lado = txtLado.Text

        MsgBox("Perimetro del Rectangulo = " & oRectangulo.Perimetro() & "   -   " & "Area del Rectangulo = " & oRectangulo.Area())

        MsgBox("Perimetro del Cuadrado = " & oCuadrado.Perimetro() & "  -  " & "Area del Cuadrado = " & oCuadrado.Area())

        MsgBox("Perimetro del Triangulo = " & oTriangulo.Perimetro() & "  -  " & "Area del Triangulo = " & oTriangulo.Area())

    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        oTriangulo.LadoA = txtLadoA.Text
        oTriangulo.LadoB = txtLadoB.Text
        oTriangulo.LadoC = txtLadoC.Text

        oTriangulo.Perimetro()
        oTriangulo.Area()

        MsgBox("Perimetro del Triangulo = " & oTriangulo.Perimetro() & "  -  " & "Area del Triangulo = " & oTriangulo.Area())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        Form2.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
