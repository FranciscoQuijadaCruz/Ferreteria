<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmDetalleProducto.aspx.cs" Inherits="Ferreteria2.frmDetalleProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
       
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
        </head>
<%
    if(Request.QueryString["id"] !=null)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);

        Entidades.Producto producto = Controlador.drProducto.drObtenerProducto(id);

        Entidades.Categoria cat = Controlador.drCategoria.drObtenerCategoria(producto.Categoria);

        hplEditar.NavigateUrl = "frmProducto.aspx?id=" + producto.Id;
        
        
    
%>
    
    
    <div class="card bg-light " style="float: left; margin:1.5%; width: 45%; height: 25.5;" >

    <table style="width:40%; margin:2%;">
        <tr>
            <th colspan="2" style="font-size:20px;"><%= producto.Nombre %></th>
        </tr>
        <tr>
            <td style="font-weight:bold;">Descripcion:</td>
            <td></td>
        </tr>
        <tr>
            <td colspan="2"><%= producto.Descripcion %></td>
        </tr>
        <tr>
            <td style="font-weight:bold;"">Categoria:</td>
            <td><%= cat.Nombre%></td>
        </tr>
        <tr>
            <td style="font-weight:bold;">Precio:</td>
            <td><%= producto.Precio %></td>
        </tr>
        <tr> <td><asp:HyperLink ID="hplEditar" runat="server">Editar Producto</asp:HyperLink></td></tr>
       
    </table>
    </div>

    <%
        }
    %>
</asp:Content>
