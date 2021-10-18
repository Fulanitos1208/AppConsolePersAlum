using System;

namespace AppConsolePersAlum
{
    class Program
    {
         static void Main(string[] args)
        {
            Alumno ca;
            ca = new Alumno();
            Console.WriteLine("Nombre completo");
            ca.Nombre = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento");
            ca.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Carrera que cursa");
            ca.Carrera = Console.ReadLine();

            Console.WriteLine("Matricula");
            ca.Matricula = Console.ReadLine();
            Console.WriteLine(ca.ToString());

            Console.ReadKey();
        }
    }
}
