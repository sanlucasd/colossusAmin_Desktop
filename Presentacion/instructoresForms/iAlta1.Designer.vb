<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iAlta1
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
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnNext = New System.Windows.Forms.Button()
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
        Me.Label2.TabIndex = 11
        Me.Label2.Tag = "0"
        Me.Label2.Text = "Datos Personales"
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
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.Lavender
        Me.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuit.Font = New System.Drawing.Font("Century Gothic", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.Silver
        Me.txtCuit.Location = New System.Drawing.Point(30, 245)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(251, 19)
        Me.txtCuit.TabIndex = 8
        Me.txtCuit.Tag = "1"
        Me.txtCuit.Text = "CUIT"
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtTelefono.TabIndex = 9
        Me.txtTelefono.Tag = "1"
        Me.txtTelefono.Text = "Telefono"
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(450, 400)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Global.Presentacion.My.Resources.Resources.next_w
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(291, 348)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 40)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Siguiente"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'iAlta1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "iAlta1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
