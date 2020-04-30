<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadosCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadosCategorias))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.grlGrilla = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 23)
        Me.Panel1.TabIndex = 59
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(4, 4)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(0, 13)
        Me.lblAccion.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 108)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(198, 25)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(91, 23)
        Me.cmdAceptar.TabIndex = 11
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(198, 52)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(91, 23)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(75, 55)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(109, 20)
        Me.txtDescripcion.TabIndex = 12
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 58)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 31)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(75, 81)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(75, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(109, 20)
        Me.txtID.TabIndex = 19
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(337, 342)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 57
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
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
        Me.cmdModificar.Location = New System.Drawing.Point(337, 168)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 55
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(256, 168)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 54
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'grlGrilla
        '
        Me.grlGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla.Location = New System.Drawing.Point(12, 12)
        Me.grlGrilla.Name = "grlGrilla"
        Me.grlGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlGrilla.Size = New System.Drawing.Size(400, 150)
        Me.grlGrilla.TabIndex = 53
        '
        'frmEstadosCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.grlGrilla)
        Me.Name = "frmEstadosCategorias"
        Me.Text = "Categorias de Estados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAccion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblID As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents grlGrilla As DataGridView
End Class
