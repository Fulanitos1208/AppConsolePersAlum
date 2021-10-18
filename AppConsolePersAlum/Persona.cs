using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsolePersAlum
{
    class Persona
    {
        protected string nombre;

        public string Nombre
        {
            get 
            {
                return nombre; 
            }
            set
            {
                nombre = value;
            }
        }

        protected string fecha;

        public string Fecha
        {
            get
            {
                return fecha; 
            }
            set 
            {
                fecha = value; 
            }
        }
        public Persona()
        {
            nombre = " ";
            fecha = " ";
        }
        public Persona(string nombre, string fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }
            public override string ToString()
        {
            return" Nombre: " + nombre + " " + "\n Fecha de nacimiento: " + " " + fecha;
        }
    }
}
