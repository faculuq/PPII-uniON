<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.grlGrilla = New System.Windows.Forms.DataGridView()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.Categoria)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 127)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(165, 68)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(88, 23)
        Me.cmdCancelar.TabIndex = 16
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(165, 40)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 23)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.Categoria.AutoSize = True
        Me.Categoria.Location = New System.Drawing.Point(6, 45)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(52, 13)
        Me.Categoria.TabIndex = 19
        Me.Categoria.Text = "Categoria"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(59, 96)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 20
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(59, 42)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(100, 21)
        Me.cboCategoria.TabIndex = 22
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(59, 70)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 23
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(59, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 28
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(6, 73)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 24
        Me.lblEstado.Text = "Estado"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(361, 344)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 58
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'grlGrilla
        '
        Me.grlGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla.Location = New System.Drawing.Point(12, 12)
        Me.grlGrilla.Name = "grlGrilla"
        Me.grlGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlGrilla.Size = New System.Drawing.Size(424, 150)
        Me.grlGrilla.TabIndex = 57
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 168)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 56
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(361, 168)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 55
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(280, 168)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 54
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 373)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 23)
        Me.Panel1.TabIndex = 60
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(4, 4)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(0, 13)
        Me.lblAccion.TabIndex = 0
        '
        'frmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.grlGrilla)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Name = "frmEstados"
        Me.Text = "Estados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents Categoria As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents grlGrilla As DataGridView
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAccion As Label
End Class
