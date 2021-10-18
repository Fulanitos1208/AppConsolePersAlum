using System;

namespace AppConsolePersAlum
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno d;
            d = new Alumno();
            Console.WriteLine(d.ToString());

            Console.ReadKey();
        }
    }
}
// public string datosAlumno(Alumno a)
//{
  //  string datosAlumno = a.nombre;
    //string datosAlumno1 = a.fecha;
    //string datosAlumno2 = a.carrera;
    //string datosAlumno3 = a.matricula;
    //a = Console.WriteLine(a.nombre + a.fecha + a.carrera + a.matricula);

    //return a;
//}
