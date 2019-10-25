using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferreteria2
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }
            else
            {
                Entidades.Usuario user = (Entidades.Usuario)Session["user"];
                lblNombre.Text = user.Nombre;
            }
            hplAgregar.NavigateUrl = "frmAgregarProd.aspx";
            hplInicio.NavigateUrl = "frmPrincipal.aspx";
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("frmLogin.aspx");
        }

        
    }
}