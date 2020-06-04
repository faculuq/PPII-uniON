Imports uniON.AD

Public Class frmRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        Dim oUsuario As New cUsuarios
        Dim oPersona As New cPersonas
        Dim oEmpresa As New cEmpresas
        Dim iduser As Integer
        Dim existencia As Integer

        If txtEmail.Text <> Nothing And txtPassword.Text <> Nothing And txtPasswordConfirmar.Text <> Nothing Then

            If txtPassword.Text = txtPasswordConfirmar.Text Then

                existencia = oUsuario.ComprobarExistencia(txtEmail.Text)

                If existencia = 1 Then

                    If checkbox.Checked = False Then

                        Dim idpersona As Integer
                        iduser = oUsuario.Agregar(txtEmail.Text, txtPassword.Text, 1)
                        idpersona = oPersona.Agregar(iduser)
                        Session("IdUsuario") = iduser
                        Session("IdPersona") = idpersona
                        ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
                        Response.Redirect("frmCargaDatosPersona.aspx")

                    Else

                        Dim idempresa As Integer
                        iduser = oUsuario.Agregar(txtEmail.Text, txtPassword.Text, 2)
                        idempresa = oEmpresa.Agregar(iduser)
                        Session("IdUsuario") = iduser
                        Session("IdEmpresa") = idempresa
                        ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
                        Response.Redirect("frmCargaDatosEmpresa.aspx")

                    End If
                Else

                    MsgBox("Este mail ya se encuentra registrado")

                End If

            Else

                    ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaPass()", True)

            End If


        Else

            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)

        End If

    End Sub
End Class