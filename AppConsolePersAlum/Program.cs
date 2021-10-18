using System;

namespace AppConsolePersAlum
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al;
            al = new Alumno();
            Console.WriteLine("Nombre completo");
            al.Nombre = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento");
            al.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Carrera que cursa");
            al.Carrera = Console.ReadLine();

            Console.WriteLine("Matricula");
            al.Matricula = Console.ReadLine();
            Console.WriteLine(al.ToString());

            Console.ReadKey();
        }
    }
}