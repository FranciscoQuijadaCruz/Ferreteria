using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Controlador;

namespace Ferreteria2
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["user"] != null)
            {
                Response.Redirect("frmPrincipal.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblMensaje.Text = "Error: No ha ingresado el Email";
                lblMensaje.Visible = true;
            }
            else if (txtPassword.Text == "")
            {
                lblMensaje.Text = "Error: No ha ingresado su password";
                lblMensaje.Visible = true;
            }
            else if (txtPassword.Text.Length < 4)
            {
                lblMensaje.Text = "Error: El password debe tener al menos 4 digitos";
                lblMensaje.Visible = true;
            }
            else
            {
                drUsuario drUser = new drUsuario();
                
                Usuario user = drUser.drLogin(txtEmail.Text, txtPassword.Text);
                if (user != null)
                {
                    Session["user"] = user;
                    Response.Redirect("frmPrincipal.aspx");
                }
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}