Imports uniON.AD
Public Class frmModificarDatosEmpresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub

#Region "Combos"
    Private Sub CargarPaises()
        Dim oDs As New DataSet
        Dim oPais As New cPaises

        oDs = oPais.BuscarTodos

        ddlPais.DataSource = oDs.Tables(0)
        ddlPais.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        ddlPais.DataValueField = oDs.Tables(0).Columns("IdPais").ToString
        ddlPais.DataBind()

    End Sub

    Private Sub CargarProvincias()
        Dim oDs As New DataSet
        Dim oProvincia As New cProvincias

        oDs = oProvincia.BuscarPorPais(ddlPais.SelectedValue)

        ddlProvincia.DataSource = oDs.Tables(0)
        ddlProvincia.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        ddlProvincia.DataValueField = oDs.Tables(0).Columns("IdProvincia").ToString
        ddlProvincia.DataBind()

    End Sub

    Private Sub CargarCiudades()
        Dim oDs As New DataSet
        Dim oCiudad As New cCiudades

        oDs = oCiudad.BuscarPorIdProvincia(ddlProvincia.SelectedValue)

        ddlCiudad.DataSource = oDs.Tables(0)
        ddlCiudad.DataTextField = oDs.Tables(0).Columns("Nombre").ToString
        ddlCiudad.DataValueField = oDs.Tables(0).Columns("IdCiudad").ToString
        ddlCiudad.DataBind()

    End Sub

    Protected Sub ddlPais_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlPais.SelectedIndexChanged

        CargarProvincias()

    End Sub

    Protected Sub ddlProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlProvincia.SelectedIndexChanged

        CargarCiudades()

    End Sub


#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        ddlPais.SelectedIndex = 0
        ddlProvincia.SelectedIndex = 0
        ddlCiudad.SelectedIndex = 0
        TxtNombre.Text = Nothing
        CargarPaises()
        CargarProvincias()
        CargarCiudades()
        CargarDatos()
    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oPersona As New cEmpresas

        ods = oPersona.BuscarPorId(Session("IdEmpresa"))

        If ods.Tables(0).Rows.Count > 0 Then

            TxtNombre.Text = (ods.Tables(0).Rows(0).Item("Nombre"))
            ddlPais.SelectedValue = (ods.Tables(0).Rows(0).Item("IdPais"))
            ddlProvincia.SelectedValue = (ods.Tables(0).Rows(0).Item("IdProvincia"))
            ddlCiudad.SelectedValue = (ods.Tables(0).Rows(0).Item("IdCiudad"))
            Limpiar()
        End If


    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim oMusica As New cEmpresas

        If TxtNombre.Text <> Nothing Then
            oMusica.Modificar(TxtNombre.Text, ddlCiudad.Text)
            'MsgBox("Tema modificado correctamente", vbInformation, "Modificar")
            Limpiar()
        Else
            'MsgBox("Completar datos para modificar", vbInformation, "Cargar")
        End If
    End Sub
#End Region

End Class