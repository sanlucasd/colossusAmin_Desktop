Public Class pagosAlta
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
    Private Sub pagosAlta_Load(sender As Object, e As EventArgs) Handles Me.Load
        With cbInstructores.Items

            .Add("Nahuel Breitenbruch")
            .Add("Nicolas Ibañez")
            .Add("Gabriela Rivarola")
            .Add("Gustavo Breitenbruch")
            .Add("Alejandro Ramirez")
            .Add("Julio Sosa")
            .Add("Roberto JoseMaria Ramirez Fernandez Ortigoza")
        End With
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class