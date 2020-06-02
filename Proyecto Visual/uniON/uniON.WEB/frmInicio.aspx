<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInicio.aspx.vb" Inherits="uniON.WEB.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <%--ESTILOS CABECERA--%>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <link href="css/animate.min.css" rel="stylesheet">
    <link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.transitions.css" rel="stylesheet">
    <link href="css/prettyPhoto.css" rel="stylesheet">
    <link href="css/main.css" rel="stylesheet">
    <link href="css/responsive.css" rel="stylesheet">
    <title>uniON</title>
    </head>
<body>
    <form id="form1" runat="server">
        <header id="top-header" class="navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <!-- responsive nav button -->
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <!-- /responsive nav button -->

                <!-- logo -->
                <div class="navbar-brand">
                    <a class="smooth-scroll" data-section="#home" href="#home">
                        <img src="images/logo.png" alt="">
                    </a>
                </div>
                <!-- /logo -->
            </div>

            <!-- main nav -->
            <nav class="collapse navbar-collapse navbar-right" role="navigation">
                <div class="main-menu">
                    <ul id="nav" class="nav navbar-nav">
                        <li class="scroll button"><a href="#home" data-section="#home">Eventos</a></li>
                        <li class="scroll"><a href="#about" data-section="#about">Premios</a></li>
                        <li class="scroll"><a href="frmModificardatosPersona.aspx" data-section="#features">Mi info</a></li>
                        <%--<li class="scroll"><a href="#services" data-section="#services" style="color: #72C05B;">Servicios</a></li>
                        <li class="scroll"><a href="#portfolio" data-section="#portfolio" style="color: #72C05B;">Galeria</a></li>
                        <li class="scroll"><a href="#contact-area" data-section="#contact-area" style="color: #72C05B;">Contacto</a></li>--%>
                        
                        
                        
                    </ul>
                </div>
            </nav>
            <!-- /main nav -->

        </div>
    </header>
    </form>
</body>
</html>
