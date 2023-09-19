using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nacimiento, año, edad;
            Console.WriteLine("en que año naciste?");
            nacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("en que año estamos?");
            año = int.Parse(Console.ReadLine());
            edad = año - nacimiento;
            Console.WriteLine("Tienes " + edad + " años");

        }
    }
}
