<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="Ferreteria2.frmProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
     <%
        
         if (Request.QueryString["id"] != null)
         {
             int id = Convert.ToInt32(Request.QueryString["id"]);
             Entidades.Producto producto = Controlador.drProducto.drObtenerProducto(id);
             

             Entidades.Categoria cat = Controlador.drCategoria.drObtenerCategoria(producto.Categoria);

          
           decimal d = producto.Precio;
           TextBox1.Text = producto.Nombre;
              TextBox2.Text = producto.Descripcion;
           TextBox3.Text = producto.DescripcionCorta;
           TextBox4.Text = cat.Nombre;
           TextBox5.Text = producto.Precio.ToString();
    %>

    <div  class="card bg-light " style="float: left; margin:1.5%; width: 45%; height: 25.5;" >
            <div style="margin:2%;">
            <table>
                <tr>
                    <td style="font-weight:bold;">Nombre:</td>
                    <td>
                          <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion Corta:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Categoria:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Precio:</td>
                    <td> <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr><td>&nbsp</td><td>&nbsp</td></tr>
                <tr>
                <td>&nbsp</td>
                    <td colspan="2">
                        
                        <center><asp:Button class="btn btn-success" ID="Button1" runat="server" Text="Guardar Cambios" onclick="Button1_Click" /></center>
                    </td>
                </tr>
            </table>
            </div>
        </div>

    
   

    
    
   
    <%
        }
    %>

</asp:Content>
