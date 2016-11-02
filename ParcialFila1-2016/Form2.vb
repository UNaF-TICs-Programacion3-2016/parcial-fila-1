
Public Class Form2
    Private oEntornoDB As New EntornoDB

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVInmueble.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT * from INMUEBLE WHERE SUPERFICIE > 1500")
    End Sub
End Class