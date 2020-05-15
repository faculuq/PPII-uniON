<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmLogin.aspx.vb" Inherits="uniON.WEB.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8">
  <title>uniON</title>
  <!-- partial:index.partial.html -->
  <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,700' rel='stylesheet' type='text/css'>
  <link rel="stylesheet" href="css/login.css">

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


    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script>function alertaFracaso() {
            swal({
                title: "¡Algo salió mal!",
                text: "¡Corrobora que ambas contraseñas coincidan!",
                icon: "error",
                button: "Aceptar",
            });
        }</script>

    
</head>
<body>

   <div class="container">
    <div class="frame">
      <div class="nav">
        <ul class="links">
          <li class="signin-active"><a class="btn">Iniciar Secion</a></li>
          <li class="signup-inactive"><a href="frmRegistro.aspx" class ="btn">Registrarte</a></li>
        </ul>
      </div>
      <div ng-app ng-init="checked = false">
        <form class="form-signin" action="" method="post" name="form" runat="server">
          <label for="username">Email</label>
<%--          <input class="form-styling" type="text" name="username" placeholder="" />--%>
            <asp:TextBox id="txtEmail" class="form-styling" type="text" name="username"  runat="server"></asp:TextBox>
          <label for="password">Contraseña</label>
            <asp:TextBox id="txtPassword" class="form-styling" type="password" name="password" runat="server"></asp:TextBox>
          <%--<input class="form-styling" type="text" name="password" placeholder="" />--%>
          <input type="checkbox" id="checkbox" />
          <label for="checkbox"><span class="ui"></span>Mantenerme conectado</label>
            <asp:Button ID="btnRegistrarse" runat="server" style="cursor:pointer;padding-top: 0px;" Text="Iniciar Secion" CssClass="btn-signup"/>
          <%--<div class="btn-animate">
            <a class="btn-signin">Entrar</a>
          </div>--%>
        </form>
          </div>
        </div>
       </div>

   <%-- <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
  <script src='https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.3.14/angular.min.js'></script>--%>
  <%--<script src="js/login.js"></script>--%>
</body>
</html>
