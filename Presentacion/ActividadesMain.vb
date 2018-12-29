Public Class ActividadesMain

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearchAct.Enter
        If (txtSearchAct.Text = "Buscar") Then
            txtSearchAct.Text = ""
            txtSearchAct.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearchAct.Leave
        If (txtSearchAct.Text = "") Then
            txtSearchAct.Text = "Buscar"
            txtSearchAct.ForeColor = Color.Silver
        End If
    End Sub


    Private Sub ActividadesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActividades.Rows.Add("Spinning", "500")
        dgvActividades.Rows.Add("Zumba", "600")
        dgvActividades.Rows.Add("Crossfit", "750")
        dgvActividades.Rows.Add("Funcional", "500")
        dgvActividades.Rows.Add("Complementos", "500")
    End Sub


    Private Sub btnAddActividad_Click(sender As Object, e As EventArgs) Handles btnAddActividad.Click
        actividadAlta.ShowDialog()
    End Sub

    Private Sub btnUpdateActividad_Click(sender As Object, e As EventArgs) Handles btnUpdateActividad.Click
        actividadModificacion.ShowDialog()

    End Sub

    Private Sub btnDeleteActividad_Click(sender As Object, e As EventArgs) Handles btnDeleteActividad.Click
   
        PopUp.ShowDialog()
    End Sub


End Class