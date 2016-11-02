Public Class Form1
    Private oTriangulo As New Triangulo(1, 1, 1)

    Private Sub Cmd_AreaT_Click(sender As Object, e As EventArgs) Handles CmdMostrar.Click
        'Mostrara el perimetro y area del triangulo con valores Predeterminados (2,4,7)
        If TxtA.Text = Nothing And TxtB.Text = Nothing And TxtC.Text = Nothing Then
            MsgBox(oTriangulo.MostrarPerimetro + " " + oTriangulo.MostrarArea)
            Exit Sub
        End If
        'Mostrar el perimetro y area del triangulo con los valores ingresados en pantalla
        oTriangulo.IngresarLadoA = CDbl(TxtA.Text)
        oTriangulo.IngresarLadoB = CDbl(TxtB.Text)
        oTriangulo.IngresarLadoC = CDbl(TxtC.Text)

        MsgBox(oTriangulo.MostrarArea + " " + oTriangulo.MostrarPerimetro)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdCargar.Click
        Form2.Show()
    End Sub
End Class
