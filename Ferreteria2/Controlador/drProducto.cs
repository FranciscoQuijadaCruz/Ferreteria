using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Negocio;

namespace Controlador
{
    public class drProducto
    {
        public static bool drAgregarProducto(Producto producto)
        {
            return new daoProducto().agregarProducto(producto);
        }

        public static bool drEditarProducto(Producto producto)
        {
            return new daoProducto().editarProducto(producto);
        }

        public static bool drEliminarProducto(int id)
        {
            return new daoProducto().eliminarProducto(id);
        }

        public static List<Producto> drObtenerProductos()
        {
            return new daoProducto().obtenerProductos();
        }

        public static Producto drObtenerProducto(int id)
        {
            return new daoProducto().obtenerProducto(id);
        }

        public static List<Producto> drObtenerProductosCategoria(int cat)
        {
            return new daoProducto().obtenerProductosCategoria(cat);
        }

    }
}
