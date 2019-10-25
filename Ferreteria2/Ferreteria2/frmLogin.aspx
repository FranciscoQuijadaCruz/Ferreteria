<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Ferreteria2.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

</head>

<body style="background-color:#DCDCDC;">
<div style="background-color: #ffffff; align-content:center; margin: 10%; margin-left: 33%; margin-right: 30%; font-family: calibri;
              box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.15); padding: 80px 40px; border: none; border-radius: 2px;">
       <center>
    <form id="form1" runat="server" style="marginl:10%;">
        
        <table >
            <tr">
                <th colspan="2" style="text-align:center; font-size:20px;">Acceso Usuario</th>
                
            </tr>

            <tr style="">
                <td></td>
                <td> <center></center></td>
            </tr>
            <tr><td>Email:</td></tr>
            <tr>
                
                <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" class="form-control" 
                        ontextchanged="txtEmail_TextChanged"></asp:TextBox></td>
            </tr>
            <tr><td>Password:</td></tr>
            <tr>
                
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control"></asp:TextBox> </td>
            </tr>
            <tr>
                <td colspan="2">
                    <center><asp:Label ID="lblMensaje" runat="server" Text="[Msg]" Visible="false" ForeColor="Red" ></center></asp:Label> 
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
            </tr>
            <tr>
                
                <td><center>
                    <asp:Button ID="btnLogin" runat="server" Text="Acceder" 
                        onclick="btnLogin_Click"  class="btn btn-success" style="Width:200px;"/>
                        </center> 
                </td>
            </tr>
        </table>
    </form>
    </center>
    </div>
</body>
</html>
