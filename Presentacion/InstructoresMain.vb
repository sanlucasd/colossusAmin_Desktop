Public Class InstructoresMain

    Private Sub InstructoresMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvInstructores.Rows.Add("Nahuel Breitenbruch", "3764829371", "20367891453")
        dgvInstructores.Rows.Add("Nicolas Ibañez", "3764347694", "20357102583")
        dgvInstructores.Rows.Add("Gabriela Rivarola", "3764857036", "27328701492")
        dgvInstructores.Rows.Add("Gustavo Breitenbruch", "3764859317", "256983714")
        dgvInstructores.Rows.Add("Alejandro Ramirez", "3764859170", "20327458206")
        dgvInstructores.Rows.Add("Julio Sosa", "3764931820", "2030752349")
        

    End Sub




   
    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        instructorAlta.ShowDialog()
    End Sub

    Private Sub btnUpdateActividad_Click(sender As Object, e As EventArgs) Handles btnUpdateActividad.Click
        iModificacion.ShowDialog()
    End Sub
End Class