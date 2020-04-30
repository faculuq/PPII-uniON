Imports uniON.AD
Public Class frmEstados

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
                    DesHabililarEdicion()
                    DesHabililarComandos()
                    cmdAgregar.Enabled = True
                    cmdAceptar.Enabled = False
                    cmdCancelar.Enabled = False
                    grlGrilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lblAccion.Text = "Consultando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txtId.Enabled = False
                    cmdAceptar.Enabled = True
                    cmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Limpiar()
                    txtEstado.Focus()
                    Panel1.BackColor = Color.MediumAquamarine
                    lblAccion.Text = "Agregando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txtId.Enabled = False
                    cmdAceptar.Enabled = True
                    cmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Panel1.BackColor = Color.MediumAquamarine
                    lblAccion.Text = "Modificando"
                    lblAccion.ForeColor = Color.Black

            End Select
            eEstado = vNewValue
        End Set
    End Property
#End Region

#Region "Procedimientos"
    Private Sub CargarGrilla()
        BuscarTodos()
    End Sub

    Private Sub CargarCategorias()

        Dim oDs As New DataSet
        Dim oCategorias As New cCategorias

        oDs = oCategorias.BuscarTodos

        cboCategoria.DataSource = oDs.Tables(0)
        cboCategoria.ValueMember = oDs.Tables(0).Columns(0).ToString
        cboCategoria.DisplayMember = oDs.Tables(0).Columns(1).ToString

        oDs = Nothing
        oCategorias = Nothing
    End Sub

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim oEstados As New cEstados

        oDs = oEstados.BuscarTodos

        grlGrilla.DataSource = oDs.Tables(0)
        grlGrilla.Columns(0).HeaderText = "Cod."
        grlGrilla.Columns(0).Width = 50

        oDs = Nothing
        oEstados = Nothing
    End Sub

    Private Sub BuscarPorID(ByVal ID As Integer)

        Dim oDs As New DataSet
        Dim oEstado As New cEstados

        oDs = oEstado.BuscarPorID(ID)

        txtId.Text = oDs.Tables(0).Rows(0).Item("IdEstado")
        cboCategoria.SelectedValue = oDs.Tables(0).Rows(0).Item("IdCategoria")
        txtEstado.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        chkActivo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

        oDs = Nothing
        oEstado = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txtId.Text = ""
        txtEstado.Text = ""
        CargarCategorias()
        chkActivo.Checked = True


    End Sub

    Private Sub HabililarEdicion()

        txtId.Enabled = True
        txtEstado.Enabled = True
        cboCategoria.Enabled = True
        chkActivo.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txtId.Enabled = False
        txtEstado.Enabled = False
        cboCategoria.Enabled = False
        chkActivo.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        cmdAgregar.Enabled = True
        cmdModificar.Enabled = True

    End Sub

    Private Sub DesHabililarComandos()

        cmdAgregar.Enabled = False
        cmdModificar.Enabled = False

    End Sub
#End Region

#Region "Formulario"
    Private Sub frmEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub
#End Region

#Region "Botones de Comando"
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If Validar() = True Then

                Dim oEstado As New cEstados

                If Me.Estado = EstadodelFormulario.eEditar Then
                    oEstado.Modificar(txtId.Text, cboCategoria.SelectedValue, txtEstado.Text, chkActivo.Checked)
                    MsgBox("Se modificó correctamente el estado " + txtEstado.Text + " con el código nro: " + txtId.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oEstado.Agregar(cboCategoria.SelectedValue, txtEstado.Text, chkActivo.Checked)
                    MsgBox("Se agregó correctamente el estado " + txtEstado.Text + " con el código nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta
            End If
        Catch
            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If MsgBox("¿Está seguro que desea cancelar?" & vbCrLf &
               "Se perderán las últimas modificaciones",
               vbYesNo, "Confirmación de Acción") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If
        Exit Sub
    End Sub

    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub
#End Region

#Region "Funciones"
    Private Function Validar() As Boolean

        If txtEstado.Text = "" Then

            MsgBox("Complete el nombre del estado", MsgBoxStyle.Exclamation, "Mensaje")

            Return False
        End If
        Return True
    End Function
#End Region

#Region "Grilla"
    Private Sub grl_Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla.CellContentClick

        BuscarPorID(grlGrilla.CurrentRow.Cells(0).Value)
        cmdModificar.Enabled = True

    End Sub
#End Region

#Region "Salir"
    Private Sub cmd_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
#End Region

End Class