<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCargaDatosPersona.aspx.vb" Inherits="uniON.WEB.frmCargaDatosPersona" %>

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




    <%--ESTILOS FORMULARIO--%>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">
   
    <title>uniON</title>
    <!--Morris Chart CSS -->
    <link rel="stylesheet" href="Formularios/assets/plugins/morris/morris.css">
    <!-- App css -->
    <link href="Formularios/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/pages.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/menu.css" rel="stylesheet" type="text/css" />
    <link href="Formularios/assets/css/responsive.css" rel="stylesheet" type="text/css" />
    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->
    <script src="Formularios/assets/js/modernizr.min.js"></script>

      <link href="Formularios/css/wowCss.css" rel="stylesheet" type="text/css" />

     <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>
      <script> function alertaExito() {
              Swal.fire(
                  '¡Bien hecho!',
                  'Tus datos se cargaron correctamente',
                  'success'
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
<style>
    
     /* Paste this css to your style sheet file or under head tag */
/* This only works with JavaScript, 
if it's not present, don't show loader */
.no-js #loader { display: none;  }
.js #loader { display: block; position: absolute; left: 100px; top: 0; }
.se-pre-con {
	position: fixed;
	left: 0px;
	top: 0px;
	width: 100%;
	height: 100%;
	z-index: 9999;
	background: url(https://gifimage.net/wp-content/uploads/2018/04/loading-gif-orange-8.gif) center no-repeat #fff;
	 background-size:100px 100px;
}
    
 #FondoProgeso {
  width: 100%; height: 100%; min-height:100%; 
  background: white;
    
     overflow: hidden;
    position: absolute;
    z-index:999;
     top: 0;
    right: 0;
    bottom: 0;
    left: 0;"
}

 .StatusModal
      {
          
     background:white;  
      box-shadow: 0 10px 20px rgba(0,0,0,0.19), 0 6px 6px rgba(0,0,0,0.23);
  height:300px; 
    width:100%; 
    max-width:300px; 
    border-radius:15px; 
    padding: 15px  15px 15px 15px;
       margin-top:250px;
        } 
        
        
        .icon-list-demo .col-md-4:hover {
     background-color: transparent;
}


input[type=checkbox], input[type=radio] {
    margin: 11px 0 0;
    margin-top: 1px\9;
    line-height: normal;
    cursor:pointer;
}



.BigCheckBox input
        {
            width: 24px;
            height: 24px;
            vertical-align: middle !important;
            -webkit-appearance: none;
  -moz-appearance: none;
  background: lightgray;
  appearance: none;
    border:1px solid #ef7f2d;
        }
        
        .BigCheckBox input[type=checkbox]:checked + label
        {
            color: #ef7f2d !important;
            
        }
        
      
      input[type="checkbox"]:checked {
  background: #ef7f2d;
  
}

input[type="checkbox"]:hover {
  filter: brightness(90%);
}



input[type="checkbox"]:disabled {
  background: #e6e6e6;
  opacity: 0.6;
  
  pointer-events: none;
  
}

input[type="checkbox"]:after {
  content: '';
  position: relative;
  
  left: 40%;
  top: 16%;
  width: 25%;
  height: 50%;
  border: solid #fff;
  border-width: 0 2px 2px 0;
  transform: rotate(45deg);
  display: none;
}

input[type="checkbox"]:checked:after {
  display: block;
  
}

input[type="checkbox"]:disabled:after {
  border-color: #7b7b7b;
 
}

.Status
{  width: 100%;
    height: 100%;
     min-height:100%; 
background-color:rgba(0, 0, 0, 0.5);
    
     overflow: hidden;
    position: absolute;
    z-index:99999;
     top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    }
      
    .navbar-brand a:hover{
    color:#fff;
    transition:0.5s;
    }
    li a{
    transition:0.5s;
    }

        /*Boton/BotonHover*/
    .btn-success {
        background-color: #72C05B !important;
        border: 1px solid #72C05B !important;
        border:solid 1px #627378 !important;
        border-radius:2em !important;
    }
    .btn-success:hover{
        background-color: #627378  !important;
        border: 1px solid #627378  !important;
        border:solid 1px #72C05B !important;
        transition: 1s;
    }
    </style>


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
                        uniON
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
                        <!--<li class="scroll"><a href="#services" data-section="#services" style="color: #72C05B;">Servicios</a></li>
                        <li class="scroll"><a href="#portfolio" data-section="#portfolio" style="color: #72C05B;">Galeria</a></li>
                        <li class="scroll"><a href="#contact-area" data-section="#contact-area" style="color: #72C05B;">Contacto</a></li>-->
                        
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
                                      
                                       <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Nombre</span>
                                             <asp:TextBox ID="txtNombre" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>
                                      
                                       <div class="col col-md-6">
                                           <span style="color:#72C05B; font-size:18px; ">Apellido</span>
                                             <asp:TextBox ID="txtApellido" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                      </div>

                                           </div>

<%--                                            <div class="row">

                                           <div class="col col-md-12">
                                           <span runat="server" id="Span1" style="color:#72C05B; font-size:18px;  " >Descripción</span>
                                             <asp:TextBox ID="TxtDescripcion" TextMode="MultiLine" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="200px" Width="100%"></asp:TextBox>
                                      </div>
</div>--%>
                                            <br />

                                             <div class="row">
                                      
                                       <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">País</span>
                                             <asp:DropDownList ID="cboPais"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:DropDownList>
                                       </div>

                                                 <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Provincia/Estado</span>
<asp:DropDownList ID="cboProvincia"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:DropDownList>
                                             
                                       </div>
                                                 
</div>
                                                
                                                 <br />


                                                 <div class="row">
                                                 <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Ciudad</span>
                                             <asp:DropDownList ID="cboCiudad"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:DropDownList>
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


                                              <%-- <div class="row">
                                      
                                       <div class="col col-md-4">
                                         <span style="color:#72C05B; font-size:18px; ">Texto 1</span>
                                             <asp:TextBox ID="TxtTooltip1" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>
                                                    <div class="col col-md-4">
                                         <span style="color:#72C05B; font-size:18px; ">Texto 2</span>
                                             <asp:TextBox ID="TxtTooltip2" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>
                                                    <div class="col col-md-4">
                                         <span style="color:#72C05B; font-size:18px; ">Texto 3</span>
                                             <asp:TextBox ID="TxtTooltip3" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>



</div>--%>
                                             <%--<div class="row">
                                      
                                       <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Texto 4</span>
                                             <asp:TextBox ID="TxtTooltip4" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>
                                                    <div class="col col-md-6">
                                         <span style="color:#72C05B; font-size:18px; ">Texto 5</span>
                                             <asp:TextBox ID="TxtTooltip5" required runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>
                                       </div>


</div>--%>


                                            <br />
                                       

                                        <div class="row">

                                             <div class="col col-md-12">
                                           <br />
                                                 <asp:Button style="width:50%;color:white;" 
                                                     class="btn-success" 
                                                     ID="btnAceptar"  
                                                     Text="Aceptar" 
                                                     runat="server"></asp:Button>

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
                                       
                                       </div>
                                       </section>

                    </div>
                </div>
                
                
                </div>
            </div>
     
                <!-- container -->
            </div>
            <!-- content -->
            <footer class="footer text-right">
                     2020 © uniON.
                </footer>
        </div>
    </form>
</body>
        </html>
