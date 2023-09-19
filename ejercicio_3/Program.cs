using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, velocidad, tiempo;
            Console.WriteLine("A cuantos km de distancia estan?");
            distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("A que velocidad vas?");
            velocidad = int.Parse(Console.ReadLine());
            tiempo = distancia/velocidad;
            Console.WriteLine("El tiempo que vas a tardar es de: " + tiempo + " horas");
        }
    }
}
