<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="BancoPeru.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../css/bootstrap.css" rel="stylesheet" />
    <link href="../../css/font-awesome.css" rel="stylesheet" />
    <link href="../../css/style.css" rel="stylesheet" />
    <script src="../../js/bootstrap.js"></script>
    <script src="../../js/custom.js"></script>
    <script src="../../js/jquery.metisMenu.js"></script>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style4 {
            width: 102px;
        }
        .auto-style5 {
            width: 166px;
        }
        .auto-style6 {
            width: 105px;
        }
        .auto-style7 {
            width: 97px;
        }
        .auto-style8 {
            left: 0px;
            top: 0px;
        }
        .auto-style9 {
            left: 0px;
            top: 0px;
            width: 891px;
            height: 56px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-cls-top " role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a  class="navbar-brand" href="index.html">Diseños Isil 

                </a>
            </div>

            <div class="notifications-wrapper">
<ul class="nav">

              
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user-plus"></i>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li><a href="#"><i class="fa fa-user-plus"></i> My Profile</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="#"><i class="fa fa-sign-out"></i> Logout</a>
                        </li>
                    </ul>
                </li>
            </ul>
               
            </div>
        </nav>
        <nav  class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu">
                    <li>
                        <div class="user-img-div">        
                            <img src="../../img/user.jpg" />
                        </div>

                    </li>
                     <li>
                        <a  href="#"> <strong> Banco Peru </strong></a>
                    </li>

                    <li>
                        <a href="#"><i class="fa fa-dashboard "></i>Inicio</a>
                    </li>
                    <li>
                        <a href="../Empleado/Empleado.aspx"><i class="fa fa-venus "></i>Empleados</a>
                        
                    </li>
                    
                    <li>
                        <a href="#"><i class="fa fa-bolt "></i>Pagos</a>
                        
                    </li>
                   <li>
                        <a class="active-menu"  href="Cliente.aspx"><i class="fa fa-sitemap "></i>Cliente <span class="fa arrow"></span></a>
                         <ul class="nav nav-second-level">
                             <li>
                                <a href="MantenimientoCliente.aspx"><i class="fa fa-bullhorn "></i>Mantenimiento</a>
                            </li>
                             <li>
                                <a href="ConsultasCliente.aspx"><i class="fa fa-bullhorn "></i>Consultas</a>
                            </li>
                           

                                </ul>

                            </li>
                     
                     <li>
                        <a href="../Prestamo/Prestamos.aspx"><i class="fa fa-code "></i>Prestamos</a>
                    </li>
  
                </ul>                 
                    
                    
                   
            </div>

        </nav>
       
        <div id="page-wrapper" class="page-wrapper-cls">
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                        <h1 class="page-head-line">Nuestros Clientes</h1>

                    </div>
                </div>
                <div class="row">
                <div class="auto-style3">
                  <!--   Kitchen Sink -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <table class="nav-justified">
                                <tr>
                                    <td class="auto-style4">Buscar Cliente:</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="txtDni" runat="server" Height="22px" Width="143px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style6">
                                        <asp:Button ID="btnBuscarCliente" runat="server" Height="29px" OnClick="btnBuscarCliente_Click" Text="Buscar" Width="80px" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:Button ID="btnLimpiar" runat="server" Height="29px" OnClick="btnLimpiar_Click" Text="Limpiar" Width="80px" />
                                    </td>
                                    <td>
                                       <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="panel-body">
                            <div class="table-responsive">
                                <asp:GridView ID="grvDatos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="906px">
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Cli" HeaderText="Codigo" />
                                        <asp:BoundField DataField="Dni_Cli" HeaderText="Dni" />
                                        <asp:BoundField DataField="Nom_Cli" HeaderText="Nombre" />
                                        <asp:BoundField DataField="Dir_Cli" HeaderText="Direccion" />
                                        <asp:BoundField DataField="Tel_Cli" HeaderText="Telefono" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                     <!-- End  Kitchen Sink -->
                </div>
                    </div>
                </div>
            </div></div>

    </form>
</body>
</html>
