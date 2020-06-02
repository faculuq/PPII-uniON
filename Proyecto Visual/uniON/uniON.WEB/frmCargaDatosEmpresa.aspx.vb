Imports uniON.AD
Public Class frmCargaDatosEmpresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub

    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And cboCiudad.SelectedValue <> Nothing Then

            Dim oPersona As New cPersonas
            oPersona.CargarDatos(Session("IdPersona"), cboCiudad.SelectedValue, txtNombre.Text, txtApellido.Text)
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
            Response.Redirect("frmModificarDatosPersona.aspx")
        Else

            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If

    End Sub

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

#Region "Limpiar"
    Private Sub Limpiar()
        cboPais.SelectedIndex = 0
        cboProvincia.SelectedIndex = 0
        cboCiudad.SelectedIndex = 0
        txtApellido.Text = Nothing
        txtNombre.Text = Nothing
        CargarPaises()
        CargarProvincias()
        CargarCiudades()
    End Sub
#End Region

End Class