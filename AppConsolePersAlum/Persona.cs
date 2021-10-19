using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsolePersAlum
{
    class Persona
   {
        protected string nombre;

        public string Nombre
            get 
            {
                return nombre; 
            }
            set
            {
                nombre = value;
            }
        }

        protected string fechaNacimiento;

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento; 
            }
            set 
            {
                fechaNacimiento = value; 
            }
        }
        public Persona()
        {
            nombre = " ";
            fechaNacimiento = " ";
        }
        public Persona(string nombre, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
            public override string ToString()
        {
            return" Nombre: " + nombre + " " + "\n Fecha de nacimiento: " + " " + fechaNacimiento;
        }
    }
}
