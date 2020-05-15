<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRegistro.aspx.vb" Inherits="uniON.WEB.frmRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8">
  <title>uniON</title>
  <!-- partial:index.partial.html -->
  <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,700' rel='stylesheet' type='text/css'/>
  <link rel="stylesheet" href="css/login.css"/>

    <style>
        .btn-signup:hover {
            cursor: pointer
        }
        .btn-signup:hover {
            background-color: #65AB50
        }
        .btn-signup:hover {
            transition: background-color .5s
        }
    </style>

        <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>
      <script> function alertaExito() {
              Swal.fire(
                  '¡Bienvenido a uniON!',
                  'Tu registro se completó exitosamente',
                  'success'
              )
          }
          function alertaPass() {
              Swal.fire(
                  '¡Algo salió mal!',
                  'Ambas contraseñas deben coincidir',
                  'error'
              )
          }
          function alertaCampos() {
              Swal.fire(
                  '¡Algo salió mal!',
                  'Completar todos los campos requeridos',
                  'error'
              )
          }
        </script>

</head>
<body>
   <div class="container">
    <div class="frame">
      <div class="nav">
        <ul class="links">
            <li class="signup-active"><a  class ="btn">Registrarte</a></li>
          <li class="signin-inactive"><a href="frmLogin.aspx" class="btn">Iniciar Secion</a></li>
          
        </ul>
      </div>
      <div ng-app ng-init="checked = false">
        <form class="form-signin" action="" method="post" name="form" runat="server">
         <%-- <label for="username">Nombre de usuario</label>
          <input class="form-styling" type="text" runat="server" name="username" placeholder="" />--%>
            <label for="email">Correo electrónico</label>
            <asp:TextBox ID="txtEmail" runat="server" class="form-styling" type="text" name="email"></asp:TextBox>
          <%--<input id="txtEmail" runat="server" class="form-styling" type="text" name="email" placeholder="" />--%>
          <label  for="password">Contraseña</label>
            <asp:TextBox id="txtPassword" runat="server" class="form-styling" type="password" name="password"></asp:TextBox>
<%--          <input id="txtPassword" runat="server" class="form-styling" type="text" name="password" placeholder="" />--%>
          <label for="confirmpassword">Confirmar contraseña</label>
            <asp:TextBox  id="txtPasswordConfirmar" runat="server" class="form-styling" type="password" name="confirmpassword"></asp:TextBox>
          <%--<input id="txtPasswordConfirmar" runat="server" class="form-styling" type="text" name="confirmpassword" placeholder="" />--%>
         <%-- <input id="checkbox" type="checkbox"  />--%>
            <asp:CheckBox type="checkbox" id="chkTipo" runat="server" />
          <label for="checkbox"><span class="ui"></span>Registrarse como Empresa</label>
          <%--<div class="btn-animate">
            <a class="btn-signin">Registrarse</a>--%>
            
              <asp:Button CssClass="btn-signup" ID="btnRegistrarse" runat="server" Text="Registrarse" style="cursor:pointer;;padding-top: 0px;"/>
        <%--  </div>--%>
        </form>
          </div>
        </div>
       </div>
 <%--   <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
  <script src='https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.3.14/angular.min.js'></script>--%>
  <script src="js/login.js"></script>
    

  

</body>
</html>
