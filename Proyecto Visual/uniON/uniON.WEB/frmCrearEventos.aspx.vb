Imports uniON.AD
Public Class frmCrearEventos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '' CargarEventosTipos
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub

    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If TxtNombre.Text <> Nothing And TxtDescripcion.Text <> Nothing And cboCiudad.SelectedValue <> Nothing And cboPais.SelectedValue <> Nothing And cboProvincia.SelectedValue <> Nothing And cboTipoEvento.SelectedValue <> Nothing And TxtPuntos.Text <> Nothing And TxtFecha.Text <> Nothing Then

            'Dim oPersona As New cEventos
            'oPersona.CrearEventos(Session("IdPersona"), cboTipoEvento.SelectedValue, cboCiudad.SelectedValue, TxtNombre.Text, TxtDescripcion.Text, TxtPuntos.Text, TxtFecha.Text)
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)

        Else

            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If

    End Sub


#Region "Combos"


    Private Sub CargarEventosTipos()

        Dim oDs As New DataSet
        Dim oEventoTipo As New cEventosTipos

        oDs = oEventoTipo.BuscarTodos
        cboTipoEvento.DataSource = oDs.Tables(0)
        cboTipoEvento.DataValueField = oDs.Tables(0).Columns("IdTipoEvento").ToString
        cboTipoEvento.DataTextField = oDs.Tables(0).Columns("Descripcion").ToString
        cboTipoEvento.DataBind()


    End Sub

    Private Sub CargarPaises()
        Dim oDs As New DataSet
        Dim oPais As New cPaises

        oDs = oPais.BuscarTodos

        cboPais.DataSource = oDs.Tables(0)
        cboPais.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        cboPais.DataValueField = oDs.Tables(0).Columns("IdPais").ToString
        cboPais.DataBind()

    End Sub

    Private Sub CargarProvincias()
        Dim oDs As New DataSet
        Dim oProvincia As New cProvincias

        oDs = oProvincia.BuscarPorPais(cboPais.SelectedValue)

        cboProvincia.DataSource = oDs.Tables(0)
        cboProvincia.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        cboProvincia.DataValueField = oDs.Tables(0).Columns("IdProvincia").ToString
        cboProvincia.DataBind()

    End Sub

    Private Sub CargarCiudades()
        Dim oDs As New DataSet
        Dim oCiudad As New cCiudades

        oDs = oCiudad.BuscarPorProvincia(cboProvincia.SelectedValue)

        cboCiudad.DataSource = oDs.Tables(0)
        cboCiudad.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        cboCiudad.DataValueField = oDs.Tables(0).Columns("IdCiudad").ToString
        cboCiudad.DataBind()
    End Sub

    Protected Sub cboPais_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPais.SelectedIndexChanged

        CargarProvincias()

    End Sub

    Protected Sub cboProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboProvincia.SelectedIndexChanged

        CargarCiudades()

    End Sub


#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        cboPais.SelectedIndex = 0
        cboProvincia.SelectedIndex = 0
        cboCiudad.SelectedIndex = 0
        TxtDescripcion.Text = Nothing
        TxtNombre.Text = Nothing
        TxtPuntos.Text = Nothing
        TxtFecha.Text = Nothing
        CargarPaises()
        CargarProvincias()
        CargarCiudades()
        CargarEventosTipos()
    End Sub
#End Region


End Class