using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsolePersAlum
{
    class Alumno : Persona
    {
        protected string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public Alumno() : base()
        {
            carrera =" ";
            matricula = " ";
        }
        public Alumno(string nombre, string fecha, string carrera, string matricula): base(nombre,fecha)
        {
            this.carrera = carrera;
            this.matricula = matricula;
        }
        public override string ToString()
        {
            return base.ToString() + " Carrera "+ carrera +" " + " Matricula " + " " + matricula;
        }
    }
}
