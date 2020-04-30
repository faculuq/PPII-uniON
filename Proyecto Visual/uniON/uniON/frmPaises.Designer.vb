<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaises))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.grlGrilla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 103)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(156, 26)
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
        Me.cmdCancelar.Location = New System.Drawing.Point(156, 55)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(91, 23)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(41, 52)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(109, 20)
        Me.txtPais.TabIndex = 12
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(-1, 55)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(29, 13)
        Me.lblPais.TabIndex = 13
        Me.lblPais.Text = "País"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(10, 31)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(41, 78)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(41, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(109, 20)
        Me.txtID.TabIndex = 19
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(337, 344)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 41
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 168)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 40
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(337, 168)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 39
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(256, 168)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 38
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
        Me.grlGrilla.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 23)
        Me.Panel1.TabIndex = 43
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(4, 4)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(0, 13)
        Me.lblAccion.TabIndex = 0
        '
        'frmPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 397)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.grlGrilla)
        Me.Name = "frmPaises"
        Me.Text = "Paises"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents txtPais As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents lblID As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents grlGrilla As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAccion As Label
End Class
