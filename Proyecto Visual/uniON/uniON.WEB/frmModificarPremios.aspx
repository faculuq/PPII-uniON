<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmModificarPremios.aspx.vb" Inherits="uniON.WEB.frmModificarPremios" %>

<!DOCTYPE html>


<head runat="server">

    <%--ESTILOS CABECERA--%>


    <%--ESTILOS FORMULARIO--%>

    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>

    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">

    <title>uniON</title>
    <link  rel="icon"   href="images/LogoUnion.png" type="image/png" />
    <!--Morris Chart CSS -->
    <link rel="stylesheet" href="Formularios/assets/plugins/morris/morris.css">
    <!-- App css -->
    <link href="Formularios/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/pages.css" rel="stylesheet" type="text/css" />
    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->
    
    

    <!--ESTILOS MENU-->

    <script src="https://kit.fontawesome.com/64d58efce2.js" crossorigin="anonymous"></script>
    <%--<link rel="stylesheet" href="css/style.css"/>--%>

    <style>
        @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap');

*{
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body{
    font-family: 'Poppins', sans-serif;
    overflow: auto;
    background: #fff;
}

ul{
    list-style: none;
}

a{
    text-decoration: none;
}

header{
    position: sticky;
    top: 0px;
    background-color: #72C05B;
    width: 100%;
    z-index: 1000;
    height: 70px;

}

.logo-container{
    flex: 1;
    display: flex;
    align-items: center;
}

.nav-btn{
    flex: 3;
    display: flex;
}

.nav-links{
    flex: 2;
}

.log-sign{
    display: flex;
    justify-content: center;
    align-items: center;
    flex: 1;
}

.logo{
    color: #fff;
    font-size: 1.1rem;
    font-weight: 600;
    letter-spacing: 2px;
    text-transform: uppercase;
    line-height: 3rem;
}

.logo span{
    font-weight: 300;
}

.nav-links > ul{
    display: flex;
    justify-content: center;
    align-items: center;
}

.nav-link{
    position: relative;
}

.nav-link > a{
    line-height: 3rem;
    color: #fff;
    padding: 0 .8rem;
    letter-spacing: 1px;
    font-size: 15px;
    font-weight:500;
    margin-top: -15px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    transition: .5s;
}

.nav-link > a > i{
    margin-left: .2rem;
}

.nav-link:hover > a{
    transform: scale(1.1);
}

.dropdown{
    position: absolute;
    top: 100%;
    left: 0;
    width: 10rem;
    transform: translateY(10px);
    opacity: 0;
    pointer-events: none;
    transition: .5s;
}

.dropdown ul{
    position: relative;
}

.dropdown-link > a{
    display: flex;
    background-color: #fff;
    color: #5ca146;
    padding: .5rem 1rem;
    font-size: .9rem;
    align-items: center;
    justify-content: space-between;
    transition: .3s;
    font-size: 15px;
    
}

.dropdown-link:hover > a{
    background-color: #5ca146;
    color: #fff;
}

.dropdown-link:not(:nth-last-child(2)){
    border-bottom: 1px solid #efefef;
}

.dropdown-link i{
    transform: rotate(-90deg);
}

.arrow{
    position: absolute;
    width: 11px;
    height: 11px;
    top: -5.5px;
    left: 32px;
    background-color: #fff;
    transform: rotate(45deg);
    cursor: pointer;
    transition: .3s;
    z-index: -1;
}

.dropdown-link:first-child:hover ~ .arrow{
    background-color: #5ca146;
}

.dropdown-link{
    position: relative;
}

.dropdown.second{
    top: 0;
    left: 100%;
    padding-left: .8rem;
    cursor: pointer;
    transform: translateX(10px);
}

.dropdown.second .arrow{
    top: 10px;
    left: -5.5px;
}

.nav-link:hover > .dropdown,
.dropdown-link:hover > .dropdown{
    transform: translate(0, 0);
    opacity: 1;
    pointer-events: auto;
}

        .hamburger-menu-container {
            flex: 1;
            display: none;
            align-items: center;
            justify-content: flex-end;
        }

.hamburger-menu{
    width: 2.5rem;
    height: 2.5rem;
    display: flex;
    align-items: center;
    top: 0;
    margin-top: -25px;
    justify-content: flex-end;
}

        .hamburger-menu div {
            width: 1.6rem;
            height: 3px;
            border-radius: 3px;
            background-color: #fff;
            position: relative;
            z-index: 1001;
            transition: .5s;
        }

.hamburger-menu div:before,
.hamburger-menu div:after{
    content: '';
    position: absolute;
    width: inherit;
    height: inherit;
    background-color: #fff;
    border-radius: 3px;
    transition: .5s;
}

.hamburger-menu div:before{
    transform: translateY(-7px);
}

.hamburger-menu div:after{
    transform: translateY(7px);
}

        #check {
            position: absolute;
            top: 50%;
            right: 1.5rem;
            transform: translateY(-50%);
            width: 2.5rem;
            height: 2.5rem;
            z-index: 90000;
            cursor: pointer;
            opacity: 0;
            display: none;
        }

#check:checked ~ .hamburger-menu-container .hamburger-menu div{
    background-color: transparent;
}

#check:checked ~ .hamburger-menu-container .hamburger-menu div:before{
    transform: translateY(0) rotate(-45deg);
}

#check:checked ~ .hamburger-menu-container .hamburger-menu div:after{
    transform: translateY(0) rotate(45deg);
}

@keyframes animation{
    from{
        opacity: 0;
        transform: translateY(15px);
    }
    to{
        opacity: 1;
        transform: translateY(0px);
    }
}

@media (max-width: 920px){
    .hamburger-menu-container{
        display: flex;
    }

    #check{
        display: block;
    }

    .nav-btn{
        position: fixed;
        height: calc(100vh - 3rem);
        top: 3rem;
        left: 0;
        width: 100%;
        background-color: #73c05bd0;
        flex-direction: column;
        align-items: center;
        justify-content: space-between;
        overflow-x: hidden;
        overflow-y: auto;
        transform: translateX(100%);
        transition: .65s;
    }

    #check:checked ~ .nav-btn{
        transform: translateX(0);
    }

    #check:checked ~ .nav-btn .nav-link,
    #check:checked ~ .nav-btn .log-sign{
        animation: animation .5s ease forwards var(--i);
    }

    .nav-links{
        flex: initial;
        width: 100%;
    }

    .nav-links > ul{
        flex-direction: column;
    }

    .nav-link{
        width: 100%;
        opacity: 0;
        transform: translateY(15px);
    }

    .nav-link > a{
        line-height: 1;
        padding: 1.6rem 2rem;
        margin-top: 25px;
    }

    .nav-link:hover > a{
        transform: scale(1);
        background-color: #548f42;
    }

    .dropdown, .dropdown.second{
        position: initial;
        top: initial;
        left: initial;
        transform: initial;
        opacity: 1;
        pointer-events: auto;
        width: 100%;
        padding: 0;
        background-color: #3f6d32;
        display: none;
    }
    
    .nav-link:hover > .dropdown,
    .dropdown-link:hover > .dropdown{
        display: block;
    }

    .nav-link:hover > a > i,
    .dropdown-link:hover > a > i{
        transform: rotate(360deg);
    }

    .dropdown-link > a{
        background-color: transparent;
        color: #fff;
        padding: 1.2rem 2rem;
        line-height: 1;
    }

    .dropdown.second .dropdown-link > a{
        padding: 1.2rem 2rem 1.2rem 3rem;
    }

    .dropdown.second .dropdown.second .dropdown-link > a{
        padding: 1.2rem 2rem 1.2rem 4rem;
    }

    .dropdown-link:not(:nth-last-child(2)){
        border-bottom: none;
    }

    .arrow{
        z-index: 1;
        background-color: #73c05bd0;
        left: 10%;
        transform: scale(1.1) rotate(45deg);
        transition: .5s;
    }

    .nav-link:hover .arrow{
        background-color: #548f42;
    }

    .dropdown .dropdown .arrow{
        display: none;
    }

    .dropdown-link:hover > a{
        background-color: #397a27;
    }

    .dropdown-link:first-child:hover ~ .arrow{
        background-color: #548f42;
    }

    .nav-link > a > i{
        font-size: 1.1rem;
        transform: rotate(-90deg);
        transition: .7s;
    }

    .dropdown i{
        font-size: 1rem;
        transition: .7s;
    }

    .log-sign{
        flex: initial;
        width: 100%;
        padding: 1.5rem 1.9rem;
        justify-content: flex-start;
        opacity: 0;
        transform: translateY(15px);
    }
}
    </style>

    <!-- FIN -->


    <script src="Formularios/assets/js/modernizr.min.js"></script>

      <link href="Formularios/css/wowCss.css" rel="stylesheet" type="text/css" />

    <style>
    /*Boton/BotonHover*/
    .btn-success {
        background-color: #72C05B !important;
        border: 1px solid #72C05B !important;
        /*border:solid 1px #627378 !important;*/
        border-radius:2em !important;
    }
    .btn-success:hover{
        background-color: #627378  !important;
        border: 1px solid #627378  !important;
        /*border:solid 1px #72C05B !important;*/
        transition: 1s;
    }
    </style>


</head>

<body>

    <!-- menu -->
       <header>
        <div class="container">
            <input type="checkbox" name="" id="check">
            
            <div class="logo-container">
                <h3 class="logo">uniON</h3>
            </div>

            <div class="nav-btn">
                <div class="nav-links">
                    <ul>

                        <li class="nav-link" style="--i: .4s">
                            <a href="frmInicio.aspx">Home</a>
                        </li>

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
    <!--  -->

    <form id="form1" runat="server">
        <br />
        <br />
        <div class="content-page" style="margin-top:-40px; margin-left:auto;">
            <!-- Start content -->
            <div class="content">
                 <div class="content">
                <div style="padding:0 0 0 0;" class="container">
                    <div class="row"  runat="server" id="PanelControles">
                        <div class="col-lg-12">
                            <div class="card-box">
                                <section class="icon-list-demo">
                                   <%--EMPIEZO BACKEND--%>
                             
                                    <center>
                                        <br />
                                    
                                        <div  class="form-group">

                                            <div class="row">
                                                    <div class="col col-md-12">
                                                        <span
                                                            style="color:#72C05B; font-size:28px; font-weight:700;">Modifica los Premios</span>
                                                    </div>
                                                </div>

                                                <br />
                                          
                                       <div class="row">
                                      
                                       <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Título</span>
                                             <asp:TextBox ID="TxtTitulo" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="70%"></asp:TextBox>
                                       </div>
                                           <div class="col col-md-6">
                                               <span style="color:#72C05B; font-size:18px; ">Tipo Premio</span>
<asp:DropDownList ID="cboTipoPremio" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="70%"></asp:DropDownList>
                                           </div>

                                            <div class="row">

                                           <div class="col col-md-12">
                                           <span runat="server" id="Span1" style="color:#72C05B; font-size:18px;  " >Descripción</span>
                                             <asp:TextBox ID="TxtDescripcion" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="100px" Width="85%"></asp:TextBox>
                                      </div>
                                                </div> 

                                             <div class="row">

                                           <div class="col col-md-6">
                                           <span runat="server" id="Span2" style="color:#72C05B; font-size:18px;  " >Cantidad</span>
                                             <asp:TextBox ID="TxtCantidad" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="70%"></asp:TextBox>
                                      </div>
                                           

                                           <div class="col col-md-6">
                                           <span runat="server" id="Span3" style="color:#72C05B; font-size:18px;  " >Costo(puntos)</span>
                                             <asp:TextBox ID="TxtCosto" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="70%"></asp:TextBox>
                                      </div>
</div>
                                            <div class="row">

                                                    <div class="col col-md-6">
                                                   <br />
                                            <span style="color:#72C05B; font-size:18px; ">Subir Imágen</span>
                                        
                                        <script type="text/javascript">
                                            function readURL(input) {
                                                if (input.files && input.files[0]) {
                                                    var reader = new FileReader();

                                                    reader.onload = function (e) {
                                                        $('#ImgQS')
                                                            .attr('src', e.target.result)
                                                            .width(300)
                                                            .height(100);
                                                    };

                                                    reader.readAsDataURL(input.files[0]);
                                                }
                                            }
                                        </script>


                                    

                                    <div alt="Cargando Imagen..." style="background-image:url('Imagenes/subir.png');background-size: cover;height:50px;width:50px;cursor:pointer;decoration:none;" required="" name="imagen" id="files" type="file" accept="image/*">
      <center> <asp:FileUpload style="background-image:url('Imagenes/ErrorTickets.png');background-size: cover; opacity: 0; height:80px;width:80px;cursor:pointer;margin-top:-5px;decoration:none;"  runat="server" id="btnSubirImg"  onchange="readURL(this);" runat="server"></asp:FileUpload></center></div>



                                                       

                                             </div>

                                                  <div class="col col-md-6">
                                        <br />
                                        <img src="" id="ImgQS" runat="server"  style=" width:300px;  height:100px;border: 8px solid #fff;
    box-shadow: 0px 0px 30px rgba(0, 0, 0, 0.2); object-fit:cover;" />

                                       </div>
                                  


                                            </div>
                                       

                                         <div  class="row">
                                             <br />
                                             <div class="col col-md-6">
                                                 
                             <asp:Button style="width:30%;color:white;background-color:#72C05B;border:solid 1px #627378;border-radius:2em; margin-bottom:10px"  class="btn-success" ID="btnModificar" Text="Modificar" runat="server"></asp:Button>
                                                 </div>
                                             <div class="col col-md-6">
<asp:Button style="width:30%;color:white;background-color:#72C05B;border:solid 1px #627378;border-radius:2em" class="btn-success" ID="btnAceptar"  Text="Aceptar" runat="server"></asp:Button>
                                             </div>
</div>




                                     
                                       </div>
                                     
                                      
                                                  
                                                
                                                
                                                
                                                
                                                
                                                  

                            </div>
                            
                           
                        </div>
                       
                      
                       <%-- <asp:HiddenField ID="HfID_Rubro" runat="server" />
                          <asp:HiddenField ID="HfID_MenuWeb" runat="server" />--%>
                      
                        <br />
                        <asp:Label ID="lblError" class="lbl2" ForeColor="Red" runat="server" Text=""></asp:Label>
                        <br />
                        <br />
                        </center>


                        <%--TERMINO BACKEND--%>
                        </section>
                    </div>
                    
                    
                    <div class="row" runat="server" id="PanelVolver" visible="false">
                    
                       <div class="card-box" style="    min-height: 200px;">
                                <section class="icon-list-demo" >
                      <div class="col col-md-12">


                                       <br />
                                       <%--<center>
                                        <button  type="button" style="                                                width: 50%;
                                                background: #ef7f2d !important;
                                                border: 1px solid #ef7f2d !important;" id="btnVolver" runat="server" class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5">
                    VOLVER A QUIENES SOMOS</button>
                    </center>
                                       </div>--%>
                                       </section>

                    </div>
                </div>
                
                
                </div>
            </div>
     
                <!-- container -->
            </div>
            <!-- content -->
            <%--<footer class="footer text-right">
                     2020 © uniON.
                </footer>--%>
        </div>
    </form>
</body>
</html>
