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
        public Alumno(string nombre, string fechaNacimiento, string carrera, string matricula): base(nombre, fechaNacimiento)
        {
            this.carrera = carrera;
            this.matricula = matricula;
        }
        public override string ToString()
        {
            return "Nombre del alumno:"+ nombre + "\nfecha de nacimientp" + fechaNacimiento + "\nCarrera "+ carrera +" " + "\nMatricula " + " " + matricula;
        }
    }
}
