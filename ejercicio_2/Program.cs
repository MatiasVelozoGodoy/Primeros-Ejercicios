using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Dame un numero para devolvertelo al cubo");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("el cubo de su numero es: " + n1 * n1* n1);
        }
    }
}
