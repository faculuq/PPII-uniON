Imports uniON.AD

Public Class frmPremiosTipo
#Region "Variables"
    Private eEstado As EstadodelFormulario
#End Region

#Region "Enumeraciones"
    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
    End Enum
#End Region

#Region "Propiedades"
    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)

            Select Case vNewValue

                Case EstadodelFormulario.eConsulta

                    Limpiar()
                    DesHabilitarEdicion()
                    DesHabilitarComandos()
                    cmbAgregar.Enabled = True
                    cmbAceptar.Enabled = False
                    cmbCancelar.Enabled = False
                    grl_grilla.Enabled = True
                    Panel.BackColor = Color.White
                    lblAccion.Text = "Consultando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabilitarEdicion()
                    txtIdPremio.Enabled = False
                    cmbAceptar.Enabled = True
                    cmbCancelar.Enabled = True
                    DesHabilitarComandos()
                    grl_grilla.Enabled = False
                    Limpiar()
                    txtDescripcion.Focus()
                    Panel.BackColor = Color.MediumAquamarine
                    lblAccion.Text = "Agregando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabilitarEdicion()
                    txtIdPremio.Enabled = False
                    cmbAceptar.Enabled = True
                    cmbCancelar.Enabled = True
                    DesHabilitarComandos()
                    grl_grilla.Enabled = False
                    Panel.BackColor = Color.MediumAquamarine
                    lblAccion.Text = "Modificando"
                    lblAccion.ForeColor = Color.Black

            End Select
            eEstado = vNewValue
        End Set
    End Property



#End Region

#Region "Formulario"

    Private Sub frmPremiosTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta

    End Sub

#End Region

#Region "Procedimientos"
    Private Sub CargarGrilla()
        BuscarTodos()
    End Sub

    Private Sub BuscarTodos()
        Dim oDs As New DataSet
        Dim oPremioTipo As New cPremiosTipo

        oDs = oPremioTipo.BuscarTodos

        grl_grilla.DataSource = oDs.Tables(0)

        grl_grilla.Columns(0).HeaderText = "Cod."
        grl_grilla.Columns(0).Width = 50

        oDs = Nothing
        oPremioTipo = Nothing
    End Sub

    Private Sub BuscarPorID(ByVal IdTipoPremio As Integer)
        Dim oDs As New DataSet
        Dim oPremioTipo As New cPremiosTipo

        oDs = oPremioTipo.BuscarPorId(IdTipoPremio)

        txtIdPremio.Text = oDs.Tables(0).Rows(0).Item("IdTipoPremio")
        txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

        oDs = Nothing
        oPremioTipo = Nothing
    End Sub

    Private Sub Limpiar()
        CargarGrilla()
        txtIdPremio.Text = ""
        txtDescripcion.Text = ""
        chkActivo.Checked = True
    End Sub

    Private Sub HabilitarEdicion()
        txtIdPremio.Enabled = True
        txtDescripcion.Enabled = True
        chkActivo.Enabled = True
    End Sub

    Private Sub DesHabilitarEdicion()
        txtIdPremio.Enabled = False
        txtDescripcion.Enabled = False
        chkActivo.Enabled = False
    End Sub

    Private Sub HabilitarComandos()
        cmbAgregar.Enabled = True
        cmbModificar.Enabled = True
    End Sub

    Private Sub DesHabilitarComandos()
        cmbAgregar.Enabled = False
        cmbModificar.Enabled = False
    End Sub


#End Region

#Region "Botones de comando"
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs)
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmbModificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmbAceptar.Click
        Try
            If Validar() = True Then

                Dim oPremioTipo As New cPremiosTipo

                If Me.Estado = EstadodelFormulario.eEditar Then
                    oPremioTipo.Modificar(txtIdPremio.Text, txtDescripcion.Text, chkActivo.Checked)
                    MsgBox("Se modificó correctamente el país con el código nro: " + txtIdPremio.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oPremioTipo.Agregar(txtDescripcion.Text, chkActivo.Checked)
                    MsgBox("Se agregó correctamente el país " + txtDescripcion.Text + " con el código nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta
            End If
        Catch
            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmbCancelar.Click
        If MsgBox("¿Está seguro que desea cancelar?" & vbCrLf &
            "Se perderán las últimas modificaciones",
            vbYesNo, "Confirmación de acción") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If
        Exit Sub
    End Sub


    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmbLimpiar.Click

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub


#End Region

#Region "Funciones"
    Private Function Validar() As Boolean
        If txtDescripcion.Text = "" Then

            MsgBox("Complete el nombre del país", MsgBoxStyle.Exclamation, "Mensaje")

            Return False
        End If
        Return True
    End Function


#End Region

#Region "Grilla"

    Private Sub grlGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grl_grilla.CellContentClick
        BuscarPorID(grl_grilla.CurrentRow.Cells(0).Value)
        cmbModificar.Enabled = True
    End Sub

#End Region

End Class