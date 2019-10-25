<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Ferreteria1.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" margin="300px auto">
    <table>
        <tr>
            <th colspan="2">Acceso Usuario</th>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail"  runat="server" TextMode="Email"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" Text="[Msg]" ForeColor="Red" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
             <td> 
                 <asp:Button ID="btnLogin" runat="server" Text="Button" onclick="btnLogin_Click" 
                     Width="62px" /></td>
            
               
        </table>
    </form>
</body>
</html>

