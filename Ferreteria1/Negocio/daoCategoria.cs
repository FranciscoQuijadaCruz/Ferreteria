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
                ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public bool agregarCategoria(Categoria categoria)
        {
            try
            {
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("ADD_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", categoria.Nombre);
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", categoria.Descripcion);

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

        public bool editar(Categoria categoria)
        {
            try
            {
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("EDIT_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", categoria.Nombre.ToString());
                cmdInsert.Parameters.AddWithValue("@DESCRIPCION", categoria.Descripcion.ToString());
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", categoria.Id.ToString());

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

        public bool eliminarCategoria(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("DELETE_CATEGORY", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsert.Parameters.AddWithValue("@ID_CATEGORY", id);
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

        public List<Categoria> obtenerCategorias()
        {
            try
            {
                List<Categoria> categorias = new List<Categoria>();
                conn.Open();

                SqlCommand cmdDelete = new SqlCommand("SEARCH_CATEGORIES", conn);
                cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr2 = cmdDelete.ExecuteReader();

                while (dr2.Read())
                {

                    Categoria categoria1 = new Categoria();

                    categoria1.Nombre = Convert.ToString(dr2["nombre"].ToString());
                    categoria1.Descripcion = Convert.ToString(dr2["descripcion"].ToString());
                    categoria1.Id = Convert.ToInt32(dr2["id"].ToString());

                    categorias.Add(categoria1);

                }

                

                return categorias;
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



        public Categoria obtenerCategoria(int id)
        {
            try
            {
                Categoria categoria = new Categoria();
                conn.Open();

                SqlCommand cmdDelete = new SqlCommand("SEARCH_CATEGORY", conn);
                cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
                cmdDelete.Parameters.AddWithValue("@ID_Category", categoria.Id);



                SqlDataReader dr2 = cmdDelete.ExecuteReader();

                if (dr2.Read())
                {

                    

                    categoria.Nombre = Convert.ToString(dr2["nombre"].ToString());
                    categoria.Id = Convert.ToInt32(dr2["id"].ToString());



                }

                cmdDelete.ExecuteNonQuery();

                return categoria;
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
