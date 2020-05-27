Imports uniON.AD
Public Class frmCargaPremios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub
    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If TxtTitulo.Text <> Nothing And cboTipoPremio.SelectedValue <> Nothing And TxtDescripcion.Text <> Nothing And TxtCantidad.Text <> Nothing And TxtCosto.Text <> Nothing Then

            Dim oPremios As New cPremios
            oPremios.Agregar(1, cboTipoPremio.SelectedValue, TxtTitulo.Text, TxtDescripcion.Text, TxtCantidad.Text, TxtCosto.Text)
            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)

        Else

            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If

    End Sub
#Region "Combos"
    Private Sub CargarPremiosTipos()
        Dim oDs As New DataSet
        Dim oPremiosTipos As New cPremiosTipo

        oDs = oPremiosTipos.BuscarTodos

        cboTipoPremio.DataSource = oDs.Tables(0)
        cboTipoPremio.DataTextField = oDs.Tables(0).Columns(1).ToString
        cboTipoPremio.DataValueField = oDs.Tables(0).Columns(0).ToString
        cboTipoPremio.DataBind()

    End Sub
#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        cboTipoPremio.SelectedIndex = 0
        CargarPremiosTipos()

    End Sub
#End Region

End Class