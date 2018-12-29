<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iAlta2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMontoCupon = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Tag = "0"
        Me.Label2.Text = "Datos de Usuario"
        '
        'txtMontoCupon
        '
        Me.txtMontoCupon.BackColor = System.Drawing.Color.Lavender
        Me.txtMontoCupon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoCupon.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtMontoCupon.ForeColor = System.Drawing.Color.Silver
        Me.txtMontoCupon.Location = New System.Drawing.Point(30, 245)
        Me.txtMontoCupon.Name = "txtMontoCupon"
        Me.txtMontoCupon.Size = New System.Drawing.Size(251, 19)
        Me.txtMontoCupon.TabIndex = 13
        Me.txtMontoCupon.Tag = "1"
        Me.txtMontoCupon.Text = "Repetir Contraseña"
        Me.txtMontoCupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Lavender
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Silver
        Me.txtTelefono.Location = New System.Drawing.Point(30, 180)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(250, 19)
        Me.txtTelefono.TabIndex = 14
        Me.txtTelefono.Tag = "1"
        Me.txtTelefono.Text = "Contraseña"
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Lavender
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(30, 115)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 19)
        Me.txtUsername.TabIndex = 15
        Me.txtUsername.Tag = "1"
        Me.txtUsername.Text = "Usuario"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Orange
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 30
        Me.LineShape1.X2 = 280
        Me.LineShape1.Y1 = 136
        Me.LineShape1.Y2 = 136
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Orange
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 30
        Me.LineShape2.X2 = 280
        Me.LineShape2.Y1 = 201
        Me.LineShape2.Y2 = 201
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Orange
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 30
        Me.LineShape3.X2 = 280
        Me.LineShape3.Y1 = 266
        Me.LineShape3.Y2 = 266
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(450, 400)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Image = Global.Presentacion.My.Resources.Resources.previous_w
        Me.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrev.Location = New System.Drawing.Point(1, 348)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(150, 40)
        Me.btnPrev.TabIndex = 19
        Me.btnPrev.Text = "Anterior"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(190, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Tag = "0"
        Me.Label1.Text = "2 de 2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.save_w
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(291, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Finalizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'iAlta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMontoCupon)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "iAlta2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCupon As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
