<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="Ferreteria2.frmPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
       
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
        

   
    <%
        
        List<Entidades.Producto> productos;
        if (Request.QueryString["cat"] != null)
        {
            //Reemplazarlo por busqueda de productos por categoria
            int cat = Convert.ToInt32(Request.QueryString["cat"].ToString());
            productos = Controlador.drProducto.drObtenerProductosCategoria(cat);
        }
        else
        {
            productos = Controlador.drProducto.drObtenerProductos();
        }

        foreach (Entidades.Producto producto in productos)
        {

            hplProducto.NavigateUrl = "frmDetalleProducto.aspx?id=" + producto.Id;
    %>
    
        
        <div  class="card bg-light " style="float: left; margin:1.5%; width: 45%; height: 25.5;" >
            <div style="margin:2%;">
            <table>
                <tr>
                    <td colspan="2">
                        <h3><%= producto.Nombre %></h3>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion:</td>
                    <td><%= producto.DescripcionCorta %></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Precio:</td>
                    <td><%= producto.Precio %></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:HyperLink ID="hplProducto" runat="server" style="text-decoration:none">Ver Producto</asp:HyperLink>
                    </td>
                </tr>
            </table>
            </div>
        </div>

    <%
        }    
    %>
    
</asp:Content>
