<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="BancoPeru.Web.Prestamo.Prestamos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="../../css/bootstrap.css" rel="stylesheet" />
    <link href="../../css/font-awesome.css" rel="stylesheet" />
    <link href="../../css/style.css" rel="stylesheet" />
    <script src="../../js/bootstrap.js"></script>
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
            width: 139px;
        }
        .auto-style6 {
            width: 105px;
        }
        .auto-style7 {
            width: 97px;
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
                        <a href="../Cliente/Cliente.aspx"><i class="fa fa-sitemap "></i>Cliente <span class="fa arrow"></span></a>
                         <ul class="nav nav-second-level">
                             <li>
                                <a  href="../Cliente/MantenimientoCliente.aspx"><i class="fa fa-bullhorn "></i>Mantenimiento</a>
                            </li>
                             <li>
                                <a href="../Cliente/ConsultasCliente.aspx"><i class="fa fa-bullhorn "></i>Consultas</a>
                            </li>
                           

                                </ul>

                            </li>
                     
                     <li>
                        <a class="active-menu" href="Prestamos.aspx"><i class="fa fa-code "></i>Prestamos</a>
                    </li>
  
                </ul>                 
                    
                    
                   
            </div>

        </nav>
       
        <div id="page-wrapper" class="page-wrapper-cls">
            <div id="page-inner">
                <div class="row">
                    <div class="auto-style3">
                        <h1 class="page-head-line">Lista de Prestamos</h1>

                    </div>
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="row">
                <div class="auto-style3">
                  <!--   Kitchen Sink -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <table class="nav-justified">
                                <tr>
                                    <td class="auto-style4">Buscar Prestamos:</td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                    </td>
                                  
                                    <td class="auto-style6">
                                        <asp:Button ID="btnBuscarCliente" runat="server" Height="29px" OnClick="btnBuscarCliente_Click" Text="Buscar" Width="80px" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:Button ID="btnNuevo" runat="server" Height="29px" OnClick="btnNuevo_Click" Text="Consultar" Width="80px" />
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
                                        <asp:BoundField DataField="Nombre_Cliente" HeaderText="Nombre" />
                                        <asp:BoundField DataField="Fec_Prest" HeaderText="Fecha" DataFormatString="{0:d}" />
                                        <asp:BoundField DataField="Importe" HeaderText="Importe" />
                                        <asp:BoundField DataField="Interes_Importe" HeaderText="Interes" />
                                        <asp:BoundField DataField="Importe_Total" HeaderText="Total" />
                                        <asp:BoundField DataField="Est_Prest" HeaderText="Estado" />
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
                    <asp:LinkButton ID="btnPopup1" runat="server" Text="" />
                    <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="FondoAplicacion" PopupControlID="Panel1" TargetControlID="btnPopup1">
                    </cc1:ModalPopupExtender>
                    </div>

                <asp:Panel ID="Panel1" runat="server" align="center" CssClass="CajaDialogo" Style="display:table" Width="976px">
                <table cellpadding="0" cellspacing="0" class="auto-style2" style="border: Solid 3px #D55500; ">
                    <tr style="background-color: darkred">
                        <td align="center" class="auto-style9" colspan="2" style="color: White; font-weight: bold; font-size: larger">Buscar Deuda </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="right" class="labelContenido" style="width: 45%">&nbsp;</td>
                        <td align="left" class="auto-style8">&nbsp;</td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="right" class="labelContenido">Codigo Cliente: </td>
                        <td align="left" class="auto-style8">
                            <asp:TextBox ID="txtCod" runat="server" Width="250px" />
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="right" class="labelContenido">Fecha de Inicio: </td>
                        <td align="left" class="auto-style8">
                            <asp:TextBox ID="txtIni" runat="server" Width="250px" />
                            <cc1:CalendarExtender ID="txtIni_CalendarExtender" runat="server" BehaviorID="txtIni_CalendarExtender" TargetControlID="txtIni" />
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="right" class="labelContenido">Fecha de Fin: </td>
                        <td align="left" class="auto-style8">
                            <asp:TextBox ID="txtFin" runat="server" Width="250px" />
                            <cc1:CalendarExtender ID="txtFin_CalendarExtender" runat="server" BehaviorID="txtFin_CalendarExtender" TargetControlID="txtFin" />
                        </td>
                    </tr>
                    
                    <tr style="background-color: white">
                        <td align="right" class="labelContenido">&nbsp;</td>
                        <td align="left" class="auto-style8">
                            &nbsp;</td>
                    </tr>
                    <tr style="background-color: white">
                        <td></td>
                        <td class="auto-style8">
                            <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Buscar" Width="100px" />
                            <asp:Button ID="btnCerrar" runat="server" OnClick="btnCerrar_Click" Text="Cancelar" Width="100px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>

                

                </div>
            </div></div>

        <script src="../../js/bootstrap.js"></script>
        <script src="../../js/custom.js"></script>
        <script src="../../js/jquery-1.11.1.js"></script>
        <script src="../../js/jquery.metisMenu.js"></script>
    </form>
</body>
</html>
