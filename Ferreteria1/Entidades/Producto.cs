using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private String nombre = "";
        private String descripcion = "";
        private String descripcionCorta = "";
        private int categoria = 0;
        private decimal precio = 0.00m;

        public Producto() { }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public String DescripcionCorta
        {
            get { return descripcionCorta; }
            set { descripcionCorta = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
