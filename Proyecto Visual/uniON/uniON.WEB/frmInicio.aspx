<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInicio.aspx.vb" Inherits="uniON.WEB.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

 
    <%--   BOOTSTRAP--%>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>

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
            <nav class="navbar navbar-expand-sm navbar-right" role="navigation">
                <div class="main-menu">
                    <ul id="nav" class="nav navbar-nav">
                        <%--<li style="margin-left:10px" class="drop"><a href="frmInicio.aspx" class="nav-link">Home</a></li>--%>
                       <li style="margin-left:10px" class="drop"><a href="frmModificarDatosPersona.aspx" class="nav-link">Mi Info</a></li>
                        <li style="margin-left:10px" class="drop"><a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">Eventos</a>
                            <div class="dropdown-menu">
                                <a href="#" class="dropdown-item">Todos los Eventos</a>
                                <a href="#" class="dropdown-item">Mis Eventos</a>
                                <a href="frmCrearEventos.aspx" class="dropdown-item">Crear Evento</a>
                            </div>
                        </li>
                       <li style="margin-left:10px" class="drop"><a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">Premios</a>
                            <div class="dropdown-menu">
                                <a href="#" class="dropdown-item">Todos los Premios</a>
                                <a href="#" class="dropdown-item">Mis Premios</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>

           
            

            <!-- /main nav -->

        </div>
    </header>
    </form>
</body>
</html>
