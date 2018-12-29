Public Class PagosMain

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
#Region "moverForm"
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X

        ey = e.Y

        Arrastre = True
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))

    End Sub
#End Region

    Private Sub PagosMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Alejandro Ramirez", 700, "25/09")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Julio Sosa", 500, "15/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Gabriela Rivarola", 500, "18/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Nicolas Ibañez", 700, "18/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Julio Sosa", 250, "18/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Alejandro Ramirez", 500, "18/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Nahuel Breitenbruch", 1000, "23/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Gustavo Breitenbruch", 1500, "23/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Nicolas Ibañez", 800, "23/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Gabriela Rivarola", 700, "23/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Alejandro Ramirez", 300, "23/10")
        dgvPagos.Rows.Add(dgvPagos.Rows.Count + 1, "Julio Sosa", 1000, "23/10")
        

    End Sub

    Private Sub btnAddActividad_Click(sender As Object, e As EventArgs) Handles btnAddPago.Click
        pagosAlta.ShowDialog()
    End Sub
End Class