using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class daoProducto
    {

         SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["conn"] .ConnectionString);
    
        public bool agregarProducto(Producto producto)
        {
            try
            {
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("ADD_PRODUCT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", producto.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION_CORTA", producto.DescripcionCorta);
                cmdInsert.Parameters.AddWithValue("@CATEGORIA", producto.Categoria);
                cmdInsert.Parameters.AddWithValue("@PRECIO", producto.Precio);

                cmdInsert.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            

        }

        public bool editar(Producto producto)
        {
            try
            {
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("EDIT_PRODUCT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", producto.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION_CORTA", producto.DescripcionCorta);
                cmdInsert.Parameters.AddWithValue("@CATEGORIA", producto.Categoria);
                cmdInsert.Parameters.AddWithValue("@PRECIO", producto.Precio);

                cmdInsert.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            

        }

        public bool eliminarProducto(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("DELETE_PRODUCT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsert.Parameters.AddWithValue("@ID_PRODUCT", id);
                cmdInsert.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Producto> obtenerProductos()
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                conn.Open();

                SqlCommand cmdDelete = new SqlCommand("SEARCH_PRODUCTS", conn);
                cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr2 = cmdDelete.ExecuteReader();

                while (dr2.Read())
                {

                    Producto producto1 = new Producto();

                    producto1.Nombre = Convert.ToString(dr2["nombre"].ToString());
                    producto1.Descripcion = Convert.ToString(dr2["descripcion"].ToString());
                    producto1.DescripcionCorta = Convert.ToString(dr2["descripcionCorta"].ToString());
                    producto1.Categoria = Convert.ToInt32(dr2["categoria"].ToString());
                    producto1.Precio = Convert.ToDecimal(dr2["precio"].ToString());
                    producto1.Id = Convert.ToInt32(dr2["id"].ToString());

                    productos.Add(producto1);

                }

                cmdDelete.ExecuteNonQuery();

                return productos;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }



        public Producto obtenerProducto(int id)
        {
            try
            {
                Producto producto = new Producto();
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("SEARCH_PRODUCT", conn);
                cmdInsert.Parameters.AddWithValue("@ID_PRODUCT", id);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                if (sdr.Read())
                {
                    producto.Nombre = sdr["nombre"].ToString();
                    producto.Descripcion = sdr["descripcion"].ToString();
                    producto.DescripcionCorta = sdr["descripcionCorta"].ToString();
                    producto.Categoria = Convert.ToInt32(sdr["categoria"].ToString());
                    producto.Precio = Convert.ToInt32(sdr["precio"].ToString());
                    producto.Id = Convert.ToInt32(sdr["id"].ToString());
                }
                return producto;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Producto> obtenerProductosCategoria(int cat)
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                conn.Open();

                SqlCommand cmdDelete = new SqlCommand("SEARCH_PRODUCTS_CAT", conn);
                cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
                cmdDelete.Parameters.AddWithValue("@ID_CATEGORY",cat);

                SqlDataReader dr2 = cmdDelete.ExecuteReader();

                while (dr2.Read())
                {

                    Producto producto1 = new Producto();

                    producto1.Nombre = Convert.ToString(dr2["nombre"].ToString());
                    producto1.Descripcion = Convert.ToString(dr2["descripcion"].ToString());
                    producto1.DescripcionCorta = Convert.ToString(dr2["descripcionCorta"].ToString());
                    producto1.Categoria = Convert.ToInt32(dr2["categoria"].ToString());
                    producto1.Precio = Convert.ToDecimal(dr2["precio"].ToString());
                    producto1.Id = Convert.ToInt32(dr2["id"].ToString());

                    productos.Add(producto1);

                }

                cmdDelete.ExecuteNonQuery();

                return productos;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

       
    }
}
