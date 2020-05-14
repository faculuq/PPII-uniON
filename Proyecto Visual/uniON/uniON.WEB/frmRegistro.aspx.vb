Imports uniON.AD

Public Class frmRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        Dim oUsuario As New cUsuarios
        Dim oPersona As New cPersonas
        Dim oEmpresa As New cEmpresas

        If txtEmail.Text <> Nothing And txtPassword.Text <> Nothing And txtPasswordConfirmar.Text <> Nothing Then
            If txtPassword.Text = txtPasswordConfirmar.Text Then
                If chkTipo.Checked = False Then
                    Dim iduser As Integer
                    iduser = oUsuario.Agregar(txtEmail.Text, txtPassword.Text, 1)
                    oPersona.Agregar(iduser)
                    ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
                Else
                    Dim iduser As Integer
                    iduser = oUsuario.Agregar(txtEmail.Text, txtPassword.Text, 1)
                    oEmpresa.Agregar(iduser)
                    ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaExito()", True)
                End If

            Else
                ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaPass()", True)
            End If


        Else
            ScriptManager.RegisterClientScriptBlock(Me, GetType(String), "mensaje", "alertaCampos()", True)
        End If

    End Sub
End Class