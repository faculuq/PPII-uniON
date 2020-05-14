Public Class frmRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        If txtEmail.Text <> Nothing Then
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
        Else
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)
        End If

    End Sub
End Class