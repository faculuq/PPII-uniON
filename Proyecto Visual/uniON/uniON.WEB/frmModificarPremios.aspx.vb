Imports uniON.AD
Public Class frmModificarPremios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If TxtTitulo.Text <> Nothing And cboTipoPremio.SelectedValue <> Nothing And TxtDescripcion.Text <> Nothing And TxtCantidad.Text <> Nothing And TxtCosto.Text <> Nothing Then

            Dim oPremios As New cPremios
            oPremios.Agregar(1, cboTipoPremio.SelectedValue, TxtTitulo.Text, TxtDescripcion.Text, TxtCantidad.Text, TxtCosto.Text)
            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)

        Else

            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If TxtTitulo.Text <> Nothing And cboTipoPremio.SelectedValue <> Nothing And TxtDescripcion.Text <> Nothing And TxtCantidad.Text <> Nothing And TxtCosto.Text <> Nothing Then

            Dim oPremios As New cPremios
            oPremios.Modificar(1, 1, cboTipoPremio.SelectedValue, TxtTitulo.Text, TxtDescripcion.Text, TxtCantidad.Text, TxtCosto.Text)
            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)

        Else

            'ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If
    End Sub
    Private Sub CargarDatos()
        Dim ods As New DataSet
        Dim oPremio As New cPremios
        ods = oPremio.BuscarPorId(1)

        If ods.Tables(0).Rows.Count > 0 Then

            TxtTitulo.Text = (ods.Tables(0).Rows(0).Item("Titulo"))
            cboTipoPremio.SelectedValue = (ods.Tables(0).Rows(0).Item("IdTipoPremio"))
            TxtDescripcion.Text = (ods.Tables(0).Rows(0).Item("Descripcion"))
            TxtCantidad.Text = (ods.Tables(0).Rows(0).Item("Cantidad"))
            TxtCosto.Text = (ods.Tables(0).Rows(0).Item("CostoPuntos"))

        End If

#Region "Combos"
    End Sub
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
        CargarDatos()

    End Sub
#End Region
End Class