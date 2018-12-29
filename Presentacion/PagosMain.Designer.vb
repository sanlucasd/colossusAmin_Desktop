<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDetailActividad = New System.Windows.Forms.Button()
        Me.btnDeleteActividad = New System.Windows.Forms.Button()
        Me.btnUpdateActividad = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddPago = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearchAct = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Instructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.pagos_w
        Me.PictureBox2.Location = New System.Drawing.Point(10, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pagos"
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
        Me.Panel2.Controls.Add(Me.btnAddPago)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtSearchAct)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 40)
        Me.Panel2.TabIndex = 7
        '
        'btnAddPago
        '
        Me.btnAddPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddPago.FlatAppearance.BorderSize = 0
        Me.btnAddPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnAddPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAddPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPago.Font = New System.Drawing.Font("Century Gothic", 3.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.btnAddPago.ForeColor = System.Drawing.Color.White
        Me.btnAddPago.Image = Global.Presentacion.My.Resources.Resources.add_w13
        Me.btnAddPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPago.Location = New System.Drawing.Point(518, 5)
        Me.btnAddPago.Name = "btnAddPago"
        Me.btnAddPago.Size = New System.Drawing.Size(110, 30)
        Me.btnAddPago.TabIndex = 0
        Me.btnAddPago.Text = "Agregar"
        Me.btnAddPago.UseVisualStyleBackColor = False
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
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPagos.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(98, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPagos.ColumnHeadersHeight = 40
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Instructor, Me.Monto, Me.Fecha})
        Me.dgvPagos.EnableHeadersVisualStyles = False
        Me.dgvPagos.GridColor = System.Drawing.Color.Orange
        Me.dgvPagos.Location = New System.Drawing.Point(0, 90)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPagos.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPagos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPagos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(500, 471)
        Me.dgvPagos.TabIndex = 6
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Instructor
        '
        Me.Instructor.HeaderText = "instructor"
        Me.Instructor.Name = "Instructor"
        Me.Instructor.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'PagosMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 560)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PagosMain"
        Me.Text = "PagosMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDetailActividad As System.Windows.Forms.Button
    Friend WithEvents btnDeleteActividad As System.Windows.Forms.Button
    Friend WithEvents btnUpdateActividad As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddPago As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchAct As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instructor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
