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
       ConfigurationManager.ConnectionStrings["conn"].ConnectionString
       );
        public bool agregarProducto(Producto producto)
        {
            try
            {
                //abrir Conexion
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
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool editarProducto(Producto producto)
        {
            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("EDIT_PRODUCT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", producto.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION_CORTA", producto.DescripcionCorta);
                cmdInsert.Parameters.AddWithValue("@CATEGORIA", producto.Categoria);
                cmdInsert.Parameters.AddWithValue("@PRECIO", producto.Precio);
                cmdInsert.Parameters.AddWithValue("@ID_PRODUCT", producto.Id);

                cmdInsert.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
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
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("DELETE_PRODUCT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@ID_PRODUCT", id);

                cmdInsert.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
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
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_PRODUCTS", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                while (sdr.Read())
                {
                    Producto producto = new Producto();
                    producto.Nombre = sdr["nombre"].ToString();
                    producto.Descripcion = sdr["descripcion"].ToString();
                    producto.DescripcionCorta = sdr["descripcionCorta"].ToString();
                    producto.Categoria = Convert.ToInt32(sdr["categoria"].ToString());
                    producto.Precio = Convert.ToDecimal(sdr["precio"].ToString());
                    producto.Id = Convert.ToInt32(sdr["id"].ToString());
                    productos.Add(producto);
                }

                return productos;
            }
            catch (Exception ex)
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
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_PRODUCTS_CAT", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", cat);
                
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                while (sdr.Read())
                {
                    Producto producto = new Producto();
                    producto.Nombre = sdr["nombre"].ToString();
                    producto.Descripcion = sdr["descripcion"].ToString();
                    producto.DescripcionCorta = sdr["descripcionCorta"].ToString();
                    producto.Categoria = Convert.ToInt32(sdr["categoria"].ToString());
                    producto.Precio = Convert.ToDecimal(sdr["precio"].ToString());
                    producto.Id = Convert.ToInt32(sdr["id"].ToString());
                    productos.Add(producto);
                }

                return productos;
            }
            catch (Exception ex)
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
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_PRODUCT", conn);
                cmdInsert.Parameters.AddWithValue("@ID_PRODUCT", id);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                if (sdr.Read())
                {
                    
                    producto.Nombre = sdr["nombre"].ToString();
                    producto.Descripcion = sdr["descripcion"].ToString();
                    producto.DescripcionCorta = sdr["descripcionCorta"].ToString();
                    producto.Categoria = Convert.ToInt32(sdr["categoria"].ToString());
                    producto.Precio = Convert.ToDecimal(sdr["precio"].ToString());
                    producto.Id = Convert.ToInt32(sdr["id"].ToString());
                    
                }

                return producto;
            }
            catch (Exception ex)
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
