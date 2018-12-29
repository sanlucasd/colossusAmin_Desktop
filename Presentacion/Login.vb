Imports Entidades
Imports Negocios
Imports Datos



Public Class Login
    Dim ex, ey, e2x, e2y As Integer
    Dim Arrastre, arrastre2 As Boolean

    Public _nUsuario As New Nusuario



 
#Region "EfectoPlaceHolder_TextBox"
    Private Sub txtuser_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter
        If (txtuser.Text = "USUARIO") Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black

        End If

    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        If (txtuser.Text = "") Then
            txtuser.Text = "USUARIO"
            txtuser.ForeColor = Color.Silver

        End If

    End Sub

    Private Sub txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter
        If (txtpass.Text = "PASSWORD") Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        If (txtpass.Text = "") Then
            txtpass.Text = "PASSWORD"
            txtpass.ForeColor = Color.Silver
            txtpass.UseSystemPasswordChar = False

        End If

    End Sub
#End Region

#Region "CerrarMinimizar_Form"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "MoverFormulario_desdePanel"
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

#Region "MoverFormulario_desdeForm"
    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        e2x = e.X

        e2y = e.Y

        arrastre2 = True
    End Sub

    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        arrastre2 = False
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If arrastre2 Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - e2x, Me.MousePosition.Y - Me.Location.Y - e2y))
    End Sub
#End Region

    Private Sub btnacceder_Click(sender As Object, e As EventArgs) Handles btnacceder.Click
        Dim _Usuario As New Usuario
        _Usuario.username = txtuser.Text
        _Usuario.passwordH = txtpass.Text

        If _nUsuario.validarDatos(_Usuario) Then
            MessageBox.Show(_Usuario.username)
            Dim dt As DataTable = _nUsuario.datosUsuario()
            If Not IsNothing(dt) Then
                test.DataGridView1.DataSource = dt
            Else
                PopUp.ShowDialog()

            End If
            'Dim nombre As String
            'nombre = dt.Rows(0).Item(0)
            'Home.lblUsername.Text = nombre
            'Home.Show()

            'test.Show()
            'test.DataGridView1.DataSource = dt

        Else
            MessageBox.Show("datos incompletos")

        End If



    End Sub

   
End Class