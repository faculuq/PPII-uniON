Imports uniON.AD
Public Class frmLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim oUsuario As New cUsuarios
        Dim oPersona As New cPersonas
        Dim oEmpresa As New cEmpresas
        Dim oDs As New DataSet
        Dim ods2 As New DataSet

        If txtEmail.Text <> Nothing And txtPassword.Text <> Nothing Then

            oDs = oUsuario.BuscarPorLoginPass(txtEmail.Text, txtPassword.Text)

            If oDs.Tables(0).Rows.Count > 0 Then

                If oDs.Tables(0).Rows(0).Item("IdTipoUsuario") = 1 Then

                    ods2 = oPersona.BuscarPorIdUsuario(oDs.Tables(0).Rows(0).Item("IdUsuario"))
                    Session("IdPersona") = ods2.Tables(0).Rows(0).Item("IdPersona")
                    Session("IdUsuario") = oDs.Tables(0).Rows(0).Item("IdUsuario")
                    Response.Redirect("frmInicio.aspx")

                Else

                    ods2 = oEmpresa.BuscarPorIdUsuario(oDs.Tables(0).Rows(0).Item("IdUsuario"))
                    Session("IdPersona") = ods2.Tables(0).Rows(0).Item("IdEmpresa")
                    Session("IdUsuario") = oDs.Tables(0).Rows(0).Item("IdUsuario")
                    Response.Redirect("frmInicioEmpresa.aspx")

                End If

            Else

                ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)

            End If

        Else

            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaFracaso()", True)

        End If


    End Sub

End Class