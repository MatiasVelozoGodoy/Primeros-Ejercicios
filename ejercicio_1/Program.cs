using System;

namespace hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, resultado;
           Console.WriteLine("Dame el primero numero");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Dame el segundo numero");
           n2 = int.Parse(Console.ReadLine());
           resultado = n1 + n2;
           Console.WriteLine("el resultado es: " + resultado);
        }
    }
}