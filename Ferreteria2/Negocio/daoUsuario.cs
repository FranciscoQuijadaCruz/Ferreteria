using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class daoUsuario
    {
       
        

        public bool agregarUsuario(Usuario user)
        {
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {

                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("ADD_USER", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", user.Nombre);
                cmdInsert.Parameters.AddWithValue("@EMAIL", user.Email);
                cmdInsert.Parameters.AddWithValue("@CONTRASENA", user.Contrasena);

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

        public bool editarUsuario(Usuario user)
        {
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("EDIT_USER", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@NOMBRE", user.Nombre);
                cmdInsert.Parameters.AddWithValue("@EMAIL", user.Email);
                cmdInsert.Parameters.AddWithValue("@CONTRASENA", user.Contrasena);
                cmdInsert.Parameters.AddWithValue("@ID_USER", user.Id);

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

        public bool eliminarUsuario(int id)
        {
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("DELETE_USER", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@ID_USER", id);

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

        public List<Usuario> obtenerUsuarios()
        {
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                //abrir Conexion
                conn.Open(); 

                SqlCommand cmdInsert = new SqlCommand("SEARCH_USERS", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                while (sdr.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = sdr["nombre"].ToString();
                    usuario.Email = sdr["email"].ToString();
                    usuario.Contrasena = sdr["contrasena"].ToString();
                    usuario.Id = Convert.ToInt32(sdr["id"].ToString());
                    usuarios.Add(usuario);
                }

                return usuarios;
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

        public Usuario obtenerUsuario(int id)
        {
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {
                Usuario usuario = new Usuario();
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("SEARCH_USER", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@ID_USER", id);
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                if(sdr.Read())
                {
                    
                    usuario.Nombre = sdr["nombre"].ToString();
                    usuario.Email = sdr["email"].ToString();
                    usuario.Contrasena = sdr["contrasena"].ToString();
                    usuario.Id = Convert.ToInt32(sdr["id"].ToString());
                   
                }

                return usuario;
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

        public Usuario login(string email,string contrasena)
        {
            
            SqlConnection conn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["conn"].ConnectionString
               );

            try
            {
                Usuario usuario = new Usuario();
                //abrir Conexion
                conn.Open();

                SqlCommand cmdInsert = new SqlCommand("LOGIN_USER", conn);
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;//Especificamos que es un procedimiento almacenado
                cmdInsert.Parameters.AddWithValue("@EMAIL", email);
                cmdInsert.Parameters.AddWithValue("@CONTRASENA", contrasena);
                SqlDataReader sdr = cmdInsert.ExecuteReader();

                if (sdr.Read())
                {

                    usuario.Nombre = sdr["nombre"].ToString();
                    usuario.Email = sdr["email"].ToString();
                    usuario.Contrasena = sdr["contrasena"].ToString();
                    usuario.Id = Convert.ToInt32(sdr["id"].ToString());

                }

                return usuario;
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
