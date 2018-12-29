<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructoresMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDetailActividad = New System.Windows.Forms.Button()
        Me.btnDeleteActividad = New System.Windows.Forms.Button()
        Me.btnUpdateActividad = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddInstructor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearchAct = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.dgvInstructores = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInstructores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnDetailActividad)
        Me.Panel3.Controls.Add(Me.btnDeleteActividad)
        Me.Panel3.Controls.Add(Me.btnUpdateActividad)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(500, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 471)
        Me.Panel3.TabIndex = 8
        '
        'btnDetailActividad
        '
        Me.btnDetailActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnDetailActividad.FlatAppearance.BorderSize = 0
        Me.btnDetailActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnDetailActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnDetailActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetailActividad.Font = New System.Drawing.Font("Century Gothic", 3.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.btnDetailActividad.ForeColor = System.Drawing.Color.White
        Me.btnDetailActividad.Image = Global.Presentacion.My.Resources.Resources.detailsw_x1
        Me.btnDetailActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailActividad.Location = New System.Drawing.Point(16, 78)
        Me.btnDetailActividad.Name = "btnDetailActividad"
        Me.btnDetailActividad.Size = New System.Drawing.Size(110, 30)
        Me.btnDetailActividad.TabIndex = 0
        Me.btnDetailActividad.Text = "Detalles"
        Me.btnDetailActividad.UseVisualStyleBackColor = False
        '
        'btnDeleteActividad
        '
        Me.btnDeleteActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnDeleteActividad.FlatAppearance.BorderSize = 0
        Me.btnDeleteActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnDeleteActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnDeleteActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteActividad.Font = New System.Drawing.Font("Century Gothic", 3.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.btnDeleteActividad.ForeColor = System.Drawing.Color.White
        Me.btnDeleteActividad.Image = Global.Presentacion.My.Resources.Resources.deletew_x1
        Me.btnDeleteActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteActividad.Location = New System.Drawing.Point(16, 42)
        Me.btnDeleteActividad.Name = "btnDeleteActividad"
        Me.btnDeleteActividad.Size = New System.Drawing.Size(110, 30)
        Me.btnDeleteActividad.TabIndex = 0
        Me.btnDeleteActividad.Text = "Eliminar"
        Me.btnDeleteActividad.UseVisualStyleBackColor = False
        '
        'btnUpdateActividad
        '
        Me.btnUpdateActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnUpdateActividad.FlatAppearance.BorderSize = 0
        Me.btnUpdateActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnUpdateActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnUpdateActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateActividad.Font = New System.Drawing.Font("Century Gothic", 3.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.btnUpdateActividad.ForeColor = System.Drawing.Color.White
        Me.btnUpdateActividad.Image = Global.Presentacion.My.Resources.Resources.editw_x1
        Me.btnUpdateActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateActividad.Location = New System.Drawing.Point(16, 6)
        Me.btnUpdateActividad.Name = "btnUpdateActividad"
        Me.btnUpdateActividad.Size = New System.Drawing.Size(110, 30)
        Me.btnUpdateActividad.TabIndex = 0
        Me.btnUpdateActividad.Text = "Editar"
        Me.btnUpdateActividad.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAddInstructor)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtSearchAct)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 40)
        Me.Panel2.TabIndex = 7
        '
        'btnAddInstructor
        '
        Me.btnAddInstructor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddInstructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddInstructor.FlatAppearance.BorderSize = 0
        Me.btnAddInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnAddInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddInstructor.Font = New System.Drawing.Font("Century Gothic", 3.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.btnAddInstructor.ForeColor = System.Drawing.Color.White
        Me.btnAddInstructor.Image = Global.Presentacion.My.Resources.Resources.add_w13
        Me.btnAddInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddInstructor.Location = New System.Drawing.Point(518, 5)
        Me.btnAddInstructor.Name = "btnAddInstructor"
        Me.btnAddInstructor.Size = New System.Drawing.Size(110, 30)
        Me.btnAddInstructor.TabIndex = 0
        Me.btnAddInstructor.Text = "Agregar"
        Me.btnAddInstructor.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.search_w
        Me.PictureBox1.Location = New System.Drawing.Point(370, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtSearchAct
        '
        Me.txtSearchAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.txtSearchAct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchAct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAct.ForeColor = System.Drawing.Color.Silver
        Me.txtSearchAct.Location = New System.Drawing.Point(3, 9)
        Me.txtSearchAct.Name = "txtSearchAct"
        Me.txtSearchAct.Size = New System.Drawing.Size(369, 20)
        Me.txtSearchAct.TabIndex = 1
        Me.txtSearchAct.Text = "Buscar"
        Me.txtSearchAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(640, 40)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "lnSearch"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 369
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 33
        '
        'dgvInstructores
        '
        Me.dgvInstructores.AllowUserToAddRows = False
        Me.dgvInstructores.AllowUserToDeleteRows = False
        Me.dgvInstructores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInstructores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInstructores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInstructores.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvInstructores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInstructores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInstructores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInstructores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInstructores.ColumnHeadersHeight = 40
        Me.dgvInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInstructores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Telefono, Me.CUIT})
        Me.dgvInstructores.EnableHeadersVisualStyles = False
        Me.dgvInstructores.GridColor = System.Drawing.Color.Orange
        Me.dgvInstructores.Location = New System.Drawing.Point(0, 90)
        Me.dgvInstructores.Name = "dgvInstructores"
        Me.dgvInstructores.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInstructores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInstructores.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvInstructores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInstructores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstructores.Size = New System.Drawing.Size(500, 471)
        Me.dgvInstructores.TabIndex = 6
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'CUIT
        '
        Me.CUIT.HeaderText = "CUIT"
        Me.CUIT.Name = "CUIT"
        Me.CUIT.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Instructores"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 50)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.instructores_w
        Me.PictureBox2.Location = New System.Drawing.Point(10, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'InstructoresMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 560)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvInstructores)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InstructoresMain"
        Me.Text = "InstructoresMain"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInstructores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDetailActividad As System.Windows.Forms.Button
    Friend WithEvents btnDeleteActividad As System.Windows.Forms.Button
    Friend WithEvents btnUpdateActividad As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddInstructor As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchAct As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dgvInstructores As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUIT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
