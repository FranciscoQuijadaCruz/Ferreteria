using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class daoCategoria
    {
        SqlConnection conn = new SqlConnection(
       ConfigurationManager.ConnectionStrings["conn"].ConnectionString
       );
        public bool agregarCategoria(Categoria categoria)
        {
            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("ADD_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", categoria.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", categoria.Descripcion);

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

        public bool editarCategoria(Categoria categoria)
        {

            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("EDIT_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", categoria.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", categoria.Descripcion);
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", categoria.Id);

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

        public bool eliminarCategoria(int id)
        {
            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("DELETE_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", id);

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

        public List<Categoria> obtenerCategorias()
        {
            try
            {
                List<Categoria> categorias = new List<Categoria>();
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_CATEGORIES", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                while (sdr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Nombre = sdr["nombre"].ToString();
                    categoria.Descripcion = sdr["descripcion"].ToString();
                    categoria.Id = Convert.ToInt32(sdr["id"].ToString());
                    categorias.Add(categoria);
                }

                return categorias;
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

        public Categoria obtenerCategoria(int id)
        {
            try
            {
                Categoria categoria = new Categoria();
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_CATEGORY", conn);
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", id);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                if (sdr.Read())
                {
                    
                    categoria.Nombre = sdr["nombre"].ToString();
                    categoria.Descripcion = sdr["descripcion"].ToString();
                    categoria.Id = Convert.ToInt32(sdr["id"].ToString());
                }

                return categoria;
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
