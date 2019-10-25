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
    public partial class frmProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
            
            

           
            if (Request.QueryString["id"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Entidades.Producto producto = Controlador.drProducto.drObtenerProducto(id);


                Entidades.Categoria cat = Controlador.drCategoria.drObtenerCategoria(producto.Categoria);


                decimal d = producto.Precio;
                producto.Nombre = TextBox1.Text;
                producto.Descripcion = TextBox2.Text;
                producto.DescripcionCorta = TextBox3.Text;
                cat.Nombre = producto.Categoria.ToString();
                cat.Nombre = TextBox4.Text;
                producto.Precio = Convert.ToDecimal(TextBox5.Text);
                
                

                drProducto.drEditarProducto(producto);
                Response.Redirect("frmPrincipal.aspx");
            }

            
        }
    }
}