using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {

        private int id = 0;
        private string nombre = "";
        private string email = "";
        private string contrasena = "";


        public Usuario() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

    }
}
