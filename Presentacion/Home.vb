Public Class Home
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        openFormInPanel(inicio)
        ajustbtns("btnHome", "closeTabHome", "open")
        Login.Hide()

    End Sub

#Region "cerrarMinimizar_form"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

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

    Private Sub openFormInPanel(Of nuevoForm As {Form, New})(f As nuevoForm)
        Dim formulario As Form
        formulario = Container.Controls.OfType(Of nuevoForm)().FirstOrDefault() 'busca el formulario en el contenedor
        ' si el form no existe
        If formulario Is Nothing Then
            formulario = New nuevoForm
            formulario.TopLevel = False
            formulario.Dock = DockStyle.Fill
            Container.Controls.Add(formulario)
            Container.Tag = formulario
            formulario.Show()
        End If
        formulario.BringToFront()
    End Sub

    Private Sub closeFormToPanel(nombreForm As String)
        Application.OpenForms.Item(nombreForm).Close()
    End Sub

    Private Sub ajustbtns(btnName As String, closeTabName As String, action As String)
        Dim b As Button
        Dim p As PictureBox
        If action = "open" Then
            b = Me.Panel3.Controls.Find(btnName, True).First
            b.Width = 205
            p = Me.Panel3.Controls.Find(closeTabName, True).First
            p.Visible = True
        Else
            If action = "close" Then
                b = Me.Panel3.Controls.Find(btnName, True).First
                b.Width = 237
                p = Me.Panel3.Controls.Find(closeTabName, True).First
                p.Visible = False
            End If
        End If
    End Sub


#Region "Abrir desde Menu lateral"
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        openFormInPanel(inicio)
        ajustbtns("btnHome", "closeTabHome", "open")
    End Sub
    Private Sub btnActivdades_Click(sender As Object, e As EventArgs) Handles btnActivdades.Click
        openFormInPanel(ActividadesMain)
        ajustbtns("btnActivdades", "closeTabActiv", "open")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInstructores.Click
        openFormInPanel(InstructoresMain)
        ajustbtns("btnInstructores", "closeTabInst", "open")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        openFormInPanel(OperacionesMain)
        ajustbtns("btnOperaciones", "closeTabOp", "open")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        openFormInPanel(PagosMain)
        ajustbtns("btnPagos", "closeTabPagos", "open")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        openFormInPanel(ConsultasMain)
        ajustbtns("btnConsultas", "closeTabCons", "open")
    End Sub
#End Region
    

#Region "cerrar tabs"
    Private Sub closeTabHome_Click(sender As Object, e As EventArgs) Handles closeTabHome.Click
        closeFormToPanel("inicio")
        ajustbtns("btnHome", "closeTabHome", "close")
    End Sub
    Private Sub closeTabActiv_Click(sender As Object, e As EventArgs) Handles closeTabActiv.Click
        closeFormToPanel("ActividadesMain")
        ajustbtns("btnActivdades", "closeTabActiv", "close")
    End Sub
    Private Sub closeTabInst_Click(sender As Object, e As EventArgs) Handles closeTabInst.Click
        closeFormToPanel("InstructoresMain")
        ajustbtns("btnInstructores", "closeTabInst", "close")
    End Sub
    Private Sub closeTabOp_Click(sender As Object, e As EventArgs) Handles closeTabOp.Click
        closeFormToPanel("OperacionesMain")
        ajustbtns("btnOperaciones", "closeTabOp", "close")
    End Sub
    Private Sub closeTabPagos_Click(sender As Object, e As EventArgs) Handles closeTabPagos.Click
        closeFormToPanel("PagosMain")
        ajustbtns("btnPagos", "closeTabPagos", "close")
    End Sub
    Private Sub closeTabCons_Click(sender As Object, e As EventArgs) Handles closeTabCons.Click
        closeFormToPanel("ConsultasMain")
        ajustbtns("btnConsultas", "closeTabCons", "close")
    End Sub
#End Region







   
    

  

  
End Class