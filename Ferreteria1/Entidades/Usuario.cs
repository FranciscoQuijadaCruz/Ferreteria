using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private int id;
        private String nombre = "";
        private String email = "";
        private String contrasena = "";

        public Usuario() { }



        public int Id

        {
            get { return id; }
            set { id = value; }
        }



        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

      

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        
    }
}
