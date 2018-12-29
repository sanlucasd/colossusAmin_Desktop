Public Class modificacion1

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        openFormInPanel(modificacion2)
    End Sub

    Private Sub openFormInPanel(Of nuevoForm As {Form, New})(f As nuevoForm)
        Dim formulario As Form
        formulario = actividadModificacion.container.Controls.OfType(Of nuevoForm)().FirstOrDefault() 'busca el formulario en el contenedor
        ' si el form no existe
        If formulario Is Nothing Then
            formulario = New nuevoForm
            formulario.TopLevel = False
            formulario.Dock = DockStyle.Fill
            actividadModificacion.container.Controls.Add(formulario)
            actividadModificacion.container.Tag = formulario
            formulario.Show()
        End If
        formulario.BringToFront()
    End Sub


    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        If (txtNombre.Text = "Nombre") Then
            txtNombre.Text = ""
            txtNombre.ForeColor = Color.White
        End If

    End Sub

    Private Sub txtMontoCuota_Enter(sender As Object, e As EventArgs) Handles txtMontoCuota.Enter
        If (txtMontoCuota.Text = "Precio de Cuota") Then
            txtMontoCuota.Text = ""
            txtMontoCuota.ForeColor = Color.White
        End If
    End Sub


    Private Sub txtMontoCupon_Enter(sender As Object, e As EventArgs) Handles txtMontoCupon.Enter
        If (txtMontoCupon.Text = "Valor Uniitario de Cupón") Then
            txtMontoCupon.Text = ""
            txtMontoCupon.ForeColor = Color.White
        End If
    End Sub
End Class