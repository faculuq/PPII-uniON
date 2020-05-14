Public Class frmLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)
    End Sub
End Class