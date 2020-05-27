Imports uniON.AD
Public Class frmModificarDatosPersona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Inicio()

        End If

    End Sub

#Region "Botones"
    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And cboCiudad.SelectedValue <> Nothing Then

            Dim oPersona As New cPersonas
            oPersona.ModificarDatos(Session("IdPersona"), cboCiudad.SelectedValue, txtNombre.Text, txtApellido.Text)
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)

        Else

            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If

    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        HabilitarEdicion()

    End Sub

#End Region

#Region "Combos"
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

#Region "Funciones"
    Private Sub HabilitarEdicion()
        txtApellido.Enabled = True
        txtNombre.Enabled = True
        cboCiudad.Enabled = True
        cboPais.Enabled = True
        cboProvincia.Enabled = True
        btnAceptar.Enabled = True
    End Sub

    Private Sub DeshabilitarEdicion()
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        cboCiudad.Enabled = False
        cboPais.Enabled = False
        cboProvincia.Enabled = False
        btnAceptar.Enabled = False
    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oPersona As New cPersonas

        ods = oPersona.BuscarPorId(Session("IdPersona"))

        If ods.Tables(0).Rows.Count > 0 Then

            txtNombre.Text = (ods.Tables(0).Rows(0).Item("Nombre"))
            txtApellido.Text = (ods.Tables(0).Rows(0).Item("Apellido"))
            cboPais.SelectedValue = (ods.Tables(0).Rows(0).Item("IdPais"))
            cboProvincia.SelectedValue = (ods.Tables(0).Rows(0).Item("IdProvincia"))
            cboCiudad.SelectedValue = (ods.Tables(0).Rows(0).Item("IdCiudad"))

        End If


    End Sub

    Private Sub Inicio()

        CargarDatos()
        CargarPaises()
        CargarProvincias()
        CargarCiudades()
        DeshabilitarEdicion()

    End Sub



#End Region



End Class