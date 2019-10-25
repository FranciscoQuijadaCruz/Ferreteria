<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ferreteria1.Principal1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
   
        List<Entidades.Producto> productos;
        if (Request.QueryString["cat"] != null)
        {
            int cat = Convert.ToInt32(Request.QueryString["cat"].ToString());
            productos = Controlador.drProducto.drObtenerProductosCategoria(cat);
        }
        else 
        {
            productos = Controlador.drProducto;
        }

        foreach (Entidades.Producto producto in productos)
        {
            hplProducto.NavigateUrl = "detalleProducto.aspx?id="+producto.Id;
    %>

        <div class="targetaProducto">
            <table>
                <tr>
                    <td colspan="2">
                        <h3<%= producto.Nombre%>></h3>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion</td>
                    <td<%= producto.DescripcionCorta %>>Descripcion
                    </td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion</td>
                    <td<%= producto.Precio %>>Descripcion
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:HyperLink ID="hplProducto" runat="server">Ver producto</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>

    <%
        }    
    %>

</asp:Content>
