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
        public bool drAgregarUsuario(Usuario usuario)
        {
            return new daoUsuario().agregarUsuario(usuario);
        }
        public bool drEditarUsuario(Usuario usuario)
        {
            return new daoUsuario().editarUsuario(usuario);
        }
        public bool drEliminarUsuario(int id)
        {
            return new daoUsuario().eliminarUsuario(id);
        }
        public List<Usuario> drObtenerUsuarios()
        {
            return new daoUsuario().obtenerUsuarios();
        }
        public Usuario drObtenerUsuario(int id)
        {
            return new daoUsuario().obtenerUsuario(id);
        }
        public Usuario drLogin(string email, string contrasena)
        {
            return new daoUsuario().login(email, contrasena);
        }
    }
}