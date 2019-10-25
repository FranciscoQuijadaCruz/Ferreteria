using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Negocio;

namespace Controlador
{
    class drProducto
    {
        public bool drAgregarPoducto(Producto producto) 
        {
            return new daoProducto().agregarProducto(producto);
        }

        public bool drEditarProducto(Producto producto) 
        {
            return new daoProducto().editar(producto);
        }

        public bool drEliminarProducto(int id)
        {
            return new daoProducto().eliminarProducto(id);
        }

        public List<Producto> drObtenerProductos()
        {
            return new daoProducto().obtenerProductos();
        }

        public Producto drObtenerProducto(int id) 
        {
            return new daoProducto().obtenerProducto(id);
        }

        public List<Producto> drObtenerProductosCategoria(int cat)
        {
            return new daoProducto().obtenerProductosCategoria(cat);
        }
    }
}
