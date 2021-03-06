﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPrincipal.aspx.vb" Inherits="uniON.WEB.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>uniON</title>
    <link  rel="icon"   href="images/LogoUnion.png" type="image/png" />
    <!-- core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <link href="css/animate.min.css" rel="stylesheet">
    <link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.transitions.css" rel="stylesheet">
    <link href="css/prettyPhoto.css" rel="stylesheet">
    <link href="css/main.css" rel="stylesheet">
    <link href="css/responsive.css" rel="stylesheet">

    <style>
        .navbar-brand a:hover{
            color:#fff;
            transition:0.5s;
        }
        li a{
            transition:0.5s;
        }
    </style>
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
    <link rel="shortcut icon" href="images/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="images/ico/apple-touch-icon-57-precomposed.png">
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>

    <style>
        /*Boton/BotonHover*/
    .btn-success {
        background-color: #72C05B !important;
        border: 1px solid #72C05B !important;
        /*border: solid 1px #000 !important;*/
        border-radius: 2em !important;
    }

    .btn-success:hover {
        background-color: #627378 !important;
        border: 1px solid #627378 !important;
        /*border: solid 1px #000 !important;*/
        transition: 1s;
    }

    #contact-area .form-control:focus, #focusedInput {
    border: 1px solid #72C05B;
    box-shadow: none;
    }

    </style>
</head>
<body id="home" class="homepage">
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
                        <li class="scroll button"><a href="#home" data-section="#home">Inicio</a></li>
                        <li class="scroll"><a href="#about" data-section="#about">Acerca de</a></li>
                        <li class="scroll"><a href="#features" data-section="#features">Caracteristicas</a></li>
                        <li class="scroll"><a href="#portfolio" data-section="#portfolio">Galeria</a></li>
                        <li class="scroll"><a href="#contact-area" data-section="#contact-area">Contacto</a></li>
                        <%--<li class="scroll"><a href="#services" data-section="#services" style="color: #72C05B;">Servicios</a></li>--%>
                        <%--<li class="scroll"><a href="#portfolio" data-section="#portfolio" style="color: #72C05B;">Galeria</a></li>--%>
                        <%--<li class="scroll"><a href="#contact-area" data-section="#contact-area" style="color: #72C05B;">Contacto</a></li>--%>
                        
                        <div class="navbar-brand">
                            <a href="frmRegistro.aspx" style="">Registrate!</a>
                            <a href="#" style="font-size:20px"> |    </a>
                            <a href="frmLogin.aspx" style="">Inicia Sesión</a>
                        </div>
                        
                    </ul>
                </div>
            </nav>
            <!-- /main nav -->

        </div>
    </header>

    <section id="main-slider">
        <div class="owl-carousel">
            <div class="item" style="background-image: url(images/slider/bg1.jpg);">
                <div class="slider-inner">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="carousel-content text-center">
                                    <h2>Bienvenidos a uni<span>ON</span>.</h2>
                                    <p>La opción para armar tu evento y ayudar a la sociedad.</p>
                                    <!--<a class="btn btn-primary btn-lg" href="#">Read More</a>-->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.item-->
            <div class="item" style="background-image: url(images/slider/bg2.jpg);">
                <div class="slider-inner">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="carousel-content text-center">

                                    <h2>Bienvenidos a uni<span>ON</span>.</h2>
                                    <p>La opción para armar tu evento y ayudar a la sociedad.</p>
                                    <!--<a class="btn btn-primary btn-lg" href="#">Read More</a>-->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.item-->
            <div class="item" style="background-image: url(images/slider/bg3.jpg);">
                <div class="slider-inner">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="carousel-content text-center">
                                    <h2>Bienvenidos a uni<span>ON</span>.</h2>
                                    <p>La opción para armar tu evento y ayudar a la sociedad.</p>
                                    <!--<a class="btn btn-primary btn-lg" href="#">Read More</a>-->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.item-->

        </div>
        <!--/.owl-carousel-->
    </section>
    <!--/#main-slider-->

    <section id="about">
        <div class="container">

            <div class="section-header">
                <h2 class="section-title text-center wow fadeInDown">Acerca del software</h2>
                <hr>
                <!--<p class="text-center wow fadeInDown">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                    eiusmod tempor incididunt ut <br> et dolore magna aliqua. Ut enim ad minim veniam</p>-->
            </div>

            <div class="row">


                <div class="col-sm-6 wow fadeInRight">
                    <!--<h3 class="column-title">Un poco más sobre el software</h3>-->
                    <p>Lo que necesitas saber de este software es que personas, grupos,
                        empresas, comunidades, etc, que deseen iniciar una actividad
                        solidaria pueden promover o divulgar mediante el mismo,
                        teniendo la posibilidad de publicar su proyecto.</p>

                    <p>Aquel que se encuentre interesado con el evento podrá inscribirse
                        y recibir los datos pertinentes haciéndoles saber que al
                        participar en el mismo recibirá puntos en su celular que podrán
                        ser canjeados en distintos locales comerciales.</p>

                    <!--<a class="btn btn-primary" href="#">Discover Us</a>-->

                </div>
                <div class="col-sm-6 wow fadeInLeft">
                    <img class="img-responsive" src="images/undraw_takeout_boxes_ap54.svg" alt="">
                </div>
            </div>
        </div>
    </section>
    <!--/#about-->



    <section id="features">
        <div class="container">
            <div class="section-header">

                <h2 class="section-title text-center wow fadeInDown">Caracteristicas</h2>
                <hr>
                <!--<p class="text-center wow fadeInDown">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                    eiusmod tempor incididunt ut <br> et dolore magna aliqua. Ut enim ad minim veniam</p>-->
            </div>
            <div class="row">
                <div class="col-sm-6 wow fadeInLeft">
                    <img class="img-responsive" src="images/undraw_environment_iaus.svg" alt="">
                </div>
                <div class="col-sm-6">
                    <div class="media service-box wow fadeInRight">
                        <div class="pull-left">
                            <i class="far fa-handshake"></i>
                        </div>
                        <div class="media-body">
                            <h4 class="media-heading"></h4>
                            <p>Trabajo solidario ya sea de cuidado de ambiente, donaciones de ropa, comida, etc.</p>
                        </div>
                    </div>

                    <div class="media service-box wow fadeInRight">
                        <div class="pull-left">
                            <i class="far fa-handshake"></i>
                        </div>
                        <div class="media-body">
                            <h4 class="media-heading"></h4>
                            <p>Reunir grupos grandes de personas para ayudar.</p>
                        </div>
                    </div>

                    <div class="media service-box wow fadeInRight">
                        <div class="pull-left">
                            <i class="far fa-handshake"></i>
                        </div>
                        <div class="media-body">
                            <h4 class="media-heading"></h4>
                            <p>Promover la unión de las personas.</p>
                        </div>
                    </div>

                    <div class="media service-box wow fadeInRight">
                        <div class="pull-left">
                            <i class="far fa-handshake"></i>
                        </div>
                        <div class="media-body">
                            <h4 class="media-heading"></h4>
                            <p>Crear un compromiso.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!--<section id="cta2">
        <div class="container">
            <div class="text-center">
                <h2 class="wow fadeInUp" data-wow-duration="300ms" data-wow-delay="0ms">YOU'VE MADE A brave DECISION,
                    <span>WELCOME</span></h2>
                <p class="wow fadeInUp" data-wow-duration="300ms" data-wow-delay="100ms">Mauris pretium auctor quam.
                    Vestibulum et nunc id nisi fringilla <br />iaculis. Mauris pretium auctor quam.</p>
                <p class="wow fadeInUp" data-wow-duration="300ms" data-wow-delay="200ms"><a
                        class="btn btn-primary btn-lg" href="#">Get It Now</a></p>
            </div>
        </div>
    </section>-->

    <!--<section id="services">
        <div class="container">

            <div class="section-header">
                <h2 class="section-title text-center wow fadeInDown">Servicios</h2>
                <p class="text-center wow fadeInDown">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                    eiusmod tempor incididunt ut <br> et dolore magna aliqua. Ut enim ad minim veniam</p>
            </div>

            <div class="row">
                <div class="features">
                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms" data-wow-delay="0ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-bicycle"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="100ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-cubes"></i>
                            </div>
                            <h3 class="features-title font-alt">SEO Services</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="200ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-connectdevelop"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="300ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa  fa-diamond"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="400ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-user-secret"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="500ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-key"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="600ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-laptop"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                    <div class="col-sm-6 col-md-3 col-lg-3 wow fadeInUp" data-wow-duration="300ms"
                        data-wow-delay="700ms">
                        <div class="features-item">
                            <div class="features-icon">
                                <i class="fa fa-paw"></i>
                            </div>
                            <h3 class="features-title font-alt">Optimised for speed</h3>
                            Careful attention to detail and clean, well structured code ensures a smooth user experience
                            for all your visitors.
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>-->
    <!--/#services-->

    <section id="portfolio">
        <div class="container">
            <div class="section-header">
                <h2 class="section-title text-center wow fadeInDown">Galeria</h2>
                <p class="text-center wow fadeInDown">En esta sección le mostraremos imagenes de como es la interfaz de la aplicación y como funciona.</p>
            </div>

<%--            <div class="text-center">
                <ul class="portfolio-filter">
                    <li><a class="active" href="#" data-filter="*">All Works</a></li>
                    <li><a href="#" data-filter=".animation">Animation</a></li>
                    <li><a href="#" data-filter=".Business">Business</a></li>
                    <li><a href="#" data-filter=".art">Art</a></li>
                </ul>
            </div>--%>

            <div class="portfolio-items">
                <div class="portfolio-item animation">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/01.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 1</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">
                            </a>
                        </div>
                    </div>
                </div>


                <div class="portfolio-item Business art">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/02.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 2</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">
                            </a>
                        </div>
                    </div>
                </div>

                <div class="portfolio-item animation">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/03.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 3</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>

                <div class="portfolio-item Business">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/04.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 4</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>

                <div class="portfolio-item animation art">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/05.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 5</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>

                <div class="portfolio-item Business">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/06.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 6</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>

<%--                <div class="portfolio-item animation art">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/07.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 7</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>

                <div class="portfolio-item Business">
                    <div class="portfolio-item-inner">
                        <img class="img-responsive" src="images/portfolio/08.jpg" alt="">
                        <div class="portfolio-info">
                            <h3>Portfolio Item 8</h3>
                            <a class="preview" href="images/portfolio/full.jpg" rel="prettyPhoto">
                                <img src="images/portfolio/expand.png" alt="">

                            </a>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
    </section>


    <!--<section id="testimonial">
        <div class="container">
            <div class="row">
                <div class="col-sm-8 col-sm-offset-2">

                    <div id="carousel-testimonial" class="carousel slide text-center" data-ride="carousel">-->
    <!-- Wrapper for slides -->
    <!--<div class="carousel-inner" role="listbox">
                            <div class="item active">
                                <p><img class="img-circle img-thumbnail" src="images/testimonial/01.jpg" alt=""></p>
                                <h4>Louise S. Morgan</h4>
                                <small>Treatment, storage, and disposal (TSD) worker</small>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor
                                    incididunt ut et dolore magna aliqua. Ut enim ad minim veniam</p>
                            </div>
                            <div class="item">
                                <p><img class="img-circle img-thumbnail" src="images/testimonial/01.jpg" alt=""></p>
                                <h4>Louise S. Morgan</h4>
                                <small>Treatment, storage, and disposal (TSD) worker</small>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor
                                    incididunt ut et dolore magna aliqua. Ut enim ad minim veniam</p>
                            </div>
                        </div>-->

    <!-- Controls -->
    <!--<div class="btns">
                            <a class="btn btn-primary btn-sm" href="#carousel-testimonial" role="button"
                                data-slide="prev">
                                <span class="fa fa-angle-left" aria-hidden="true"></span>
                                <span class="sr-only">Previous</span>
                            </a>
                            <a class="btn btn-primary btn-sm" href="#carousel-testimonial" role="button"
                                data-slide="next">
                                <span class="fa fa-angle-right" aria-hidden="true"></span>
                                <span class="sr-only">Next</span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>-->
    <!--/#testimonial-->





    <section id="contact-area">
        <div class="container">
            <div class="row">
                <div class="section-header">
                    <h2 class="section-title text-center wow fadeInDown animated" style="visibility: visible;">Contacto
                    </h2>
                    <p class="text-center wow fadeInDown animated" style="visibility: visible;">Llena los campos y te contactaremos enseguida para resolver tus dudas</p>
                </div>
                <form id="main-contact-form" name="contact-form" method="post" action="sendemail.php">
                    <div class="col-lg-6 animated animate-from-left" style="opacity: 1; left: 0px;">

                        <div class="form-group">
                            <label for="name"></label>
                            <input id="name" type="text" name="name" style="border-radius:16px;" class="form-control" placeholder="Nombre" required>
                        </div>
                        <div class="form-group">
                            <label for="email"></label>
                            <input type="email" id="email" name="email" style="border-radius:16px;" class="form-control" placeholder="Email"
                                required>
                        </div>
                        <div class="form-group">
                            <label for="subject"></label>
                            <input type="text" id="subject" name="subject" style="border-radius:16px;" class="form-control" placeholder="Asunto"
                                required>
                        </div>

                    </div>
                    <div class="col-lg-6 animated animate-from-right" style="opacity: 1; right: 0px;">
                        <div class="form-group">
                            <label for="message"></label>
                            <textarea name="message" id="message" style="border-radius:16px;" class="form-control" rows="8" placeholder="Mensaje"
                                required></textarea>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="text-center">

                        <button type="submit" class="btn-success" style="width:30%; height:50px; color:white;">Enviar Mensaje</button>

                    </div>

                </form>

            </div>
        </div>

    </section>
    <!--/#bottom-->

    <footer id="footer">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <p class="text-center">
                        &copy; 2020. Todos los derechos reservados.
                        Las marcas mencionadas en este sitio web, son marcas registradas de sus
                        respectivas empresas. La información facilitada en este documento es
                        ostentativa, no tiene carácter vinculante y carece de valor contractual.
                        Políticas de Privacidad.
                    </p>

                    <ul class="social-icons text-center">
                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                        <li><a href="#"><i class="fa fa-instagram"></i></a></li>
                        <li><a href="#"><i class="fa fa-whatsapp"></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    <!--/#footer-->

    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/mousescroll.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/jquery.inview.min.js"></script>
    <script src="js/wow.min.js"></script>
    <script src="js/main.js"></script>

    <script src="https://kit.fontawesome.com/56ce229529.js" crossorigin="anonymous"></script>
    </form>
</body>
</html>
