Public Class iAlta1

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        openFormInPanel(iAlta2)
    End Sub

    Private Sub openFormInPanel(Of nuevoForm As {Form, New})(f As nuevoForm)
        Dim formulario As Form
        formulario = instructorAlta.container.Controls.OfType(Of nuevoForm)().FirstOrDefault() 'busca el formulario en el contenedor
        ' si el form no existe
        If formulario Is Nothing Then
            formulario = New nuevoForm
            formulario.TopLevel = False
            formulario.Dock = DockStyle.Fill
            instructorAlta.container.Controls.Add(formulario)
            instructorAlta.container.Tag = formulario
            formulario.Show()
        End If
        formulario.BringToFront()
    End Sub
End Class