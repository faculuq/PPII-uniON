<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosTipo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.cmbCancelar = New System.Windows.Forms.Button()
        Me.cmbAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdPremio = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbModificar = New System.Windows.Forms.Button()
        Me.cmbAgregar = New System.Windows.Forms.Button()
        Me.cmbLimpiar = New System.Windows.Forms.Button()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.Panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lblAccion)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 416)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(827, 24)
        Me.Panel.TabIndex = 35
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(4, 4)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(0, 13)
        Me.lblAccion.TabIndex = 0
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(735, 376)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(84, 34)
        Me.cmbCancelar.TabIndex = 34
        Me.cmbCancelar.Text = "Cancelar"
        Me.cmbCancelar.UseVisualStyleBackColor = True
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(608, 376)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(84, 34)
        Me.cmbAceptar.TabIndex = 33
        Me.cmbAceptar.Text = "Aceptar"
        Me.cmbAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtIdPremio)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 179)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(342, 100)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 3
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(342, 59)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(177, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtIdPremio
        '
        Me.txtIdPremio.Location = New System.Drawing.Point(342, 22)
        Me.txtIdPremio.Name = "txtIdPremio"
        Me.txtIdPremio.Size = New System.Drawing.Size(177, 20)
        Me.txtIdPremio.TabIndex = 0
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(241, 62)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(44, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'cmbModificar
        '
        Me.cmbModificar.Location = New System.Drawing.Point(730, 133)
        Me.cmbModificar.Name = "cmbModificar"
        Me.cmbModificar.Size = New System.Drawing.Size(84, 34)
        Me.cmbModificar.TabIndex = 32
        Me.cmbModificar.Text = "Modificar"
        Me.cmbModificar.UseVisualStyleBackColor = True
        '
        'cmbAgregar
        '
        Me.cmbAgregar.Location = New System.Drawing.Point(608, 133)
        Me.cmbAgregar.Name = "cmbAgregar"
        Me.cmbAgregar.Size = New System.Drawing.Size(84, 34)
        Me.cmbAgregar.TabIndex = 31
        Me.cmbAgregar.Text = "Agregar"
        Me.cmbAgregar.UseVisualStyleBackColor = True
        '
        'cmbLimpiar
        '
        Me.cmbLimpiar.Location = New System.Drawing.Point(5, 133)
        Me.cmbLimpiar.Name = "cmbLimpiar"
        Me.cmbLimpiar.Size = New System.Drawing.Size(84, 34)
        Me.cmbLimpiar.TabIndex = 30
        Me.cmbLimpiar.Text = "Limpiar"
        Me.cmbLimpiar.UseVisualStyleBackColor = True
        '
        'grl_grilla
        '
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(0, 6)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.Size = New System.Drawing.Size(814, 121)
        Me.grl_grilla.TabIndex = 29
        '
        'frmUsuariosTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 440)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbModificar)
        Me.Controls.Add(Me.cmbAgregar)
        Me.Controls.Add(Me.cmbLimpiar)
        Me.Controls.Add(Me.grl_grilla)
        Me.Name = "frmUsuariosTipo"
        Me.Text = "Usuarios Tipo"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents lblAccion As Label
    Friend WithEvents cmbCancelar As Button
    Friend WithEvents cmbAceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtIdPremio As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbModificar As Button
    Friend WithEvents cmbAgregar As Button
    Friend WithEvents cmbLimpiar As Button
    Friend WithEvents grl_grilla As DataGridView
End Class
