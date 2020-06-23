<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInicio.aspx.vb" Inherits="uniON.WEB.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <script src="https://kit.fontawesome.com/64d58efce2.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="css/style.css"/>

    <title>uniON</title>

    </head>
<body>
    <header>
        <div class="container">
            <input type="checkbox" name="" id="check">
            
            <div class="logo-container">
                <h3 class="logo">uniON</h3>
            </div>

            <div class="nav-btn">
                <div class="nav-links">
                    <ul>
                        <li class="nav-link" style="--i: .6s">
                            <a href="#">Mi Info</a>
                        </li>
                        <li class="nav-link" style="--i: .85s">
                            <a href="#">Eventos<i class="fas fa-caret-down"></i></a>
                            <div class="dropdown">
                                <ul>
                                    <li class="dropdown-link">
                                        <a href="#">Todos los Eventos</a>
                                    </li>
                                    <li class="dropdown-link">
                                        <a href="#">Mis Eventos</a>
                                    </li>
                                    <li class="dropdown-link">
                                        <a href="frmCrearEventos.aspx">Crear Evento</a>
                                    </li>
                                </ul>
                            </div>
                        </li>

                        <li class="nav-link" style="--i: 1.1s">
                            <a href="#">Premios<i class="fas fa-caret-down"></i></a>
                            <div class="dropdown">
                                <ul>
                                    <li class="dropdown-link">
                                        <a href="#">Todos los Premios</a>
                                    </li>
                                    <li class="dropdown-link">
                                        <a href="#">Mis Premios</a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <li class="nav-link" style="--i: 1.35s">
                            <a href="#"></a>
                        </li>
                    </ul>
                </div>
            </div>

            <div class="hamburger-menu-container">
                <div class="hamburger-menu">
                    <div></div>
                </div>
            </div>
        </div>
    </header>
    <main>
        <section>
            <div class="overlay">Bienvenidos a uniON</div>
        </section>
    </main>
</body>
</html>
