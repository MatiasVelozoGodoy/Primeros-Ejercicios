using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int MT, MC, MD, PMC, PMD;
            const int P = 100;
            Console.WriteLine("cuanto son los metros cuadrados totales?");
            MT = int.Parse(Console.ReadLine());
            Console.WriteLine("cuanto son los metros cuadrados cubiertos?");
            MC = int.Parse(Console.ReadLine());
            MD = MT - MC;
            PMD = MD * P / MT;
            PMC = MC * P / MT;
            Console.WriteLine("El porcentaje de metros cubiertos es de: " + PMC + "% y el porcentaje de metros descubiertos es de: " + PMD + "%");


        }
    }
}


// Hacer un programa para ingresar por teclado los metros cuadrados totales de
// un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
// pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
// metros cuadrados descubiertos.