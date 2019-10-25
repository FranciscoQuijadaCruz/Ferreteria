<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmAgregarProd.aspx.cs" Inherits="Ferreteria2.frmAgregarProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
 <div  class="card bg-light " style="float: left; margin:1.5%; width: 45%; height: 25.5;" >
            <div style="margin:2%;">
            <table>
                <tr>
                    <td style="font-weight:bold;">Nombre:</td>
                    <td>
                          <asp:TextBox ID="TxtNombre" runat="server" class="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion:</td>
                    <td><asp:TextBox ID="TxtD" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Descripcion Corta:</td>
                    <td><asp:TextBox ID="txtDC" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Categoria:</td>
                    <td><asp:TextBox ID="TxtCategoria" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-weight:bold;">Precio:</td>
                    <td> <asp:TextBox ID="TxtPrecio" runat="server" class="form-control"></asp:TextBox></td>
                </tr>
                <tr><td>&nbsp</td><td>&nbsp<asp:Label ID="lblMensaje" ForeColor="Red" runat="server" ></asp:Label></td></tr>
                <tr>
                <td>&nbsp</td>
                    <td colspan="2">
                        
                        <center><asp:Button class="btn btn-success" ID="Button2" runat="server" 
                                Text="Agregar" onclick="Button2_Click" /></center>
                    </td>
                </tr>
            </table>
            </div>
        </div>
</asp:Content>
