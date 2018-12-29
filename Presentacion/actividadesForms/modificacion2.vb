Public Class modificacion2

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

    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        openFormInPanel(modificacion1)

    End Sub

    Private Sub alta2_Load(sender As Object, e As EventArgs) Handles Me.Load
        NumericUpDown1.Controls.RemoveAt(0)
        NumericUpDown2.Controls.RemoveAt(0)
        NumericUpDown3.Controls.RemoveAt(0)
        NumericUpDown4.Controls.RemoveAt(0)


        With ComboBox2.Items

            .Add("Nahuel Breitenbruch")
            .Add("Nicolas Ibañez")
            .Add("Gabriela Rivarola")
            .Add("Gustavo Breitenbruch")
            .Add("Alejandro Ramirez")
            .Add("Julio Sosa")
            .Add("Roberto JoseMaria Ramirez Fernandez Ortigoza")
        End With



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView2.Rows.Add(DataGridView2.Rows.Count, ComboBox1.SelectedItem.ToString, NumericUpDown1.Value.ToString + ":" + NumericUpDown2.Value.ToString, NumericUpDown4.Value.ToString + ":" + NumericUpDown3.Value.ToString, ComboBox2.SelectedItem.ToString)
    End Sub
End Class