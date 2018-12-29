<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificacion1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoCupon = New System.Windows.Forms.TextBox()
        Me.txtMontoCuota = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Tag = "0"
        Me.Label2.Text = "Datos de Actividad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(190, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "0"
        Me.Label1.Text = "1 de 2"
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
        Me.txtMontoCupon.TabIndex = 8
        Me.txtMontoCupon.Tag = "1"
        Me.txtMontoCupon.Text = "Valor Uniitario de Cupón"
        Me.txtMontoCupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoCuota
        '
        Me.txtMontoCuota.BackColor = System.Drawing.Color.Lavender
        Me.txtMontoCuota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoCuota.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtMontoCuota.ForeColor = System.Drawing.Color.Silver
        Me.txtMontoCuota.Location = New System.Drawing.Point(30, 180)
        Me.txtMontoCuota.Name = "txtMontoCuota"
        Me.txtMontoCuota.Size = New System.Drawing.Size(250, 19)
        Me.txtMontoCuota.TabIndex = 9
        Me.txtMontoCuota.Tag = "1"
        Me.txtMontoCuota.Text = "Precio de Cuota"
        Me.txtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Lavender
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtNombre.Location = New System.Drawing.Point(30, 115)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 19)
        Me.txtNombre.TabIndex = 10
        Me.txtNombre.Tag = "1"
        Me.txtNombre.Text = "Nombre "
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext2
        '
        Me.btnNext2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatAppearance.BorderSize = 0
        Me.btnNext2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnNext2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext2.ForeColor = System.Drawing.Color.White
        Me.btnNext2.Image = Global.Presentacion.My.Resources.Resources.next_w
        Me.btnNext2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext2.Location = New System.Drawing.Point(280, 347)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(150, 40)
        Me.btnNext2.TabIndex = 7
        Me.btnNext2.Text = "Siguiente"
        Me.btnNext2.UseVisualStyleBackColor = False
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
        Me.LineShape1.Y2 = 135
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
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'modificacion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMontoCupon)
        Me.Controls.Add(Me.txtMontoCuota)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "modificacion1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCupon As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
