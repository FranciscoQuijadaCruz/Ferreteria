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
        public bool drAgregarCategoria(Categoria categoria) 
        {
            return new daoCategoria().agregarCategoria(categoria);
        }

        public bool drEditarCategoria(Categoria categoria) 
        {
            return new daoCategoria().editar(categoria);
        }

        public bool drEliminarCategoria(int id)
        {
            return new daoCategoria().eliminarCategoria(id);
        }

        public List<Categoria> drObtenerCategorias()
        {
            return new daoCategoria().obtenerCategorias();
        }

        public Categoria drObtenerCategoria(int id)
        {
            return new daoCategoria().obtenerCategoria(id);
        }

       
    }
}
