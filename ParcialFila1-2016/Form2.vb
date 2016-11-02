Public Class Form2
    Private OEntornoBD As New EntornoDB
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = (OEntornoBD.ObtenerDatosDesdeSQL(" Select * from INMUEBLE WHERE SUPERFICIE > 1500"))
    End Sub

End Class