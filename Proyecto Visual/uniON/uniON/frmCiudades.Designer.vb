<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiudades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCiudades))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.cboPais = New System.Windows.Forms.ComboBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.grlGrilla = New System.Windows.Forms.DataGridView()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(449, 23)
        Me.Panel1.TabIndex = 56
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
        Me.GroupBox1.Controls.Add(Me.lblProvincia)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.cboPais)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.lblCiudad)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 183)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(6, 78)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 30
        Me.lblProvincia.Text = "Provincia"
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(59, 75)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(100, 21)
        Me.cboProvincia.TabIndex = 31
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
        Me.cmdCancelar.Location = New System.Drawing.Point(165, 101)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(165, 73)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 23)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(6, 45)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(29, 13)
        Me.lblPais.TabIndex = 19
        Me.lblPais.Text = "País"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(59, 131)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 20
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cboPais
        '
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Location = New System.Drawing.Point(59, 42)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(100, 21)
        Me.cboPais.TabIndex = 22
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(59, 105)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudad.TabIndex = 23
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(59, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 28
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(6, 108)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(40, 13)
        Me.lblCiudad.TabIndex = 24
        Me.lblCiudad.Text = "Ciudad"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(361, 335)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 54
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'grlGrilla
        '
        Me.grlGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla.Location = New System.Drawing.Point(12, 3)
        Me.grlGrilla.Name = "grlGrilla"
        Me.grlGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlGrilla.Size = New System.Drawing.Size(424, 150)
        Me.grlGrilla.TabIndex = 53
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 159)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 52
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(361, 159)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 51
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(280, 159)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 50
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'frmCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.grlGrilla)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Name = "frmCiudades"
        Me.Text = "frmCiudades"
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
    Friend WithEvents lblProvincia As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents lblPais As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents cboPais As ComboBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblCiudad As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents grlGrilla As DataGridView
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdAgregar As Button
End Class
