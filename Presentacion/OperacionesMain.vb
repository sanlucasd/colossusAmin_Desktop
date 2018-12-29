Public Class OperacionesMain

    Private Sub OperacionesMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvOperaciones.Rows.Add("Registro de Usuario", "+")
        dgvOperaciones.Rows.Add("Renovacion Cuota", "+")
        dgvOperaciones.Rows.Add("Pago a Instructores", "-")





    End Sub

   
    Private Sub btnAddOperacion_Click(sender As Object, e As EventArgs) Handles btnAddOperacion.Click
        operacionesAlta.ShowDialog()

    End Sub

    Private Sub btnUpdateOperacion_Click(sender As Object, e As EventArgs) Handles btnUpdateOperacion.Click
        operacionesModif.ShowDialog()

    End Sub
End Class