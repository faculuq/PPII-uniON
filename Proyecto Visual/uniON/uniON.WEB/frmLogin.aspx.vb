Imports uniON.AD
Public Class frmLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        Dim oUsuario As New cUsuarios
        Dim oDs As New DataSet

        If txtEmail.Text <> Nothing And txtPassword.Text <> Nothing Then

            oDs = oUsuario.BuscarPorLoginPass(txtEmail.Text, txtPassword.Text)

            If oDs.Tables(0).Rows.Count > 0 Then

                Session("IdUsuario") = oDs.Tables(0).Rows(0).Item("IdUsuario")
                Response.Redirect("frmInicio.aspx")

            Else
                ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)
            End If
        Else
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)
        End If


    End Sub
End Class