using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Negocio;

namespace Controlador
{
    public class drCategoria
    {
        public static bool drAgregarCategoria(Categoria categoria)
        {
            return new daoCategoria().agregarCategoria(categoria);
        }

        public static bool drEditarCategoria(Categoria categoria)
        {
            return new daoCategoria().editarCategoria(categoria);
        }

        public static bool drEliminarCategoria(int id)
        {
            return new daoCategoria().eliminarCategoria(id);
        }

        public static List<Categoria> drObtenerCategorias()
        {
            return new daoCategoria().obtenerCategorias();
        }

        public static Categoria drObtenerCategoria(int id)
        {
            return new daoCategoria().obtenerCategoria(id);
        }

    }
}
