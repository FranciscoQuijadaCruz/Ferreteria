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
    public partial class frmAgregarProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            
                drProducto c = new drProducto();

                Producto p = new Producto();


                Entidades.Categoria cat = Controlador.drCategoria.drObtenerCategoria(p.Categoria);


               
                p.Nombre = TxtNombre.Text;
                p.Descripcion = TxtD.Text;
                p.DescripcionCorta = txtDC.Text;
                
                p.Categoria = Convert.ToInt32(TxtCategoria.Text);
                p.Precio = Convert.ToDecimal(TxtCategoria.Text);

               

                drProducto.drAgregarProducto(p);
                Response.Redirect("frmPrincipal.aspx");

                if (TxtNombre.Text == "" || TxtD.Text == "" || txtDC.Text == "" 
                    || TxtCategoria.Text == "" || TxtCategoria.Text== "" ) 
                {
                        lblMensaje.Text = "Error: Ingrese datos validos";
                        lblMensaje.Visible = true;
                }
            
            
        }
    }
}