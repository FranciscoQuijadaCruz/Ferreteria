using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Negocio;

namespace Controlador
{
    public class drUsuario
    {

        public static bool drAgregarUsuario(Usuario usuario)
        {
            return new daoUsuario().agregarUsuario(usuario);
        }

        public static bool drEditarUsuario(Usuario usuario)
        {
            return new daoUsuario().editarUsuario(usuario);
        }

        public static bool drEliminarUsuario(int id)
        {
            return new daoUsuario().eliminarUsuario(id);
        }

        public static List<Usuario> drObtenerUsuarios()
        {
            return new daoUsuario().obtenerUsuarios();
        }

        public static Usuario drObtenerUsuario(int id)
        {
            return new daoUsuario().obtenerUsuario(id);
        }

        public Usuario drLogin(string email, string contrasena)
        {
            return new daoUsuario().login(email, contrasena);
        }

    }
}
