using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float MT, a;
            const float descuento = 0.85F;
            Console.WriteLine("Cuanto es el monto total?");
            MT = float.Parse(Console.ReadLine());
            a = MT * descuento;
            Console.WriteLine("el monto total es " + a.ToString ("0.00") + "$");
        }
    }
}

// Una importante cadena de delivery cuenta con una promoción por tiempo
// limitado en la que otorga un 15% de descuento sobre el total del valor de la
// compra realizada. Hacer un programa para solicitar el monto total y el mismo
// calcule y emita por pantalla el total a cobrar con el descuento aplicado.