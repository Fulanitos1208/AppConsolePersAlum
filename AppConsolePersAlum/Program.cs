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

