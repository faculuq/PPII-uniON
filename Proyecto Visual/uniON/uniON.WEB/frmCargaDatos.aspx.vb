Imports uniON.AD
Public Class frmCargaDatos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub

#Region "Combos"
    Private Sub CargarPais()
        Dim oDs As New DataSet
        Dim oPais As New cPaises

        oDs = oPais.BuscarTodos

        ddlPais.DataSource = oDs.Tables(0)
        ddlPais.DataTextField = oDs.Tables(0).Columns(1).ToString
        ddlPais.DataValueField = oDs.Tables(0).Columns(0).ToString
        ddlPais.DataBind()

    End Sub

    Private Sub CargarProvincia()
        Dim oDs As New DataSet
        Dim oProvincia As New cProvincias

        oDs = oProvincia.BuscarTodos

        ddlProvincia.DataSource = oDs.Tables(0)
        ddlProvincia.DataTextField = oDs.Tables(0).Columns(2).ToString
        ddlProvincia.DataValueField = oDs.Tables(0).Columns(0).ToString
        ddlProvincia.DataBind()

    End Sub

    Private Sub CargarCiudad()
        Dim oDs As New DataSet
        Dim oCiudad As New cCiudades

        oDs = oCiudad.BuscarTodos

        ddlCiudad.DataSource = oDs.Tables(0)
        ddlCiudad.DataTextField = oDs.Tables(0).Columns(2).ToString
        ddlCiudad.DataValueField = oDs.Tables(0).Columns(0).ToString
        ddlCiudad.DataBind()

    End Sub
#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        ddlPais.SelectedIndex = 0
        ddlProvincia.SelectedIndex = 0
        ddlCiudad.SelectedIndex = 0
        CargarPais()
        CargarProvincia()
        CargarCiudad()
    End Sub
#End Region

    Protected Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class