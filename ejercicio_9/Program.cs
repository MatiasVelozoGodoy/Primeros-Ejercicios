using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int hombres , mujeres, total;
            float PH, PM;
            const int P = 100;
            Console.WriteLine("cuantos hombres hay?");
            hombres = int.Parse(Console.ReadLine());
            Console.WriteLine("cuantas mujeres hay?");
            mujeres = int.Parse(Console.ReadLine());
            total = hombres + mujeres;
            PH = (hombres * P) / total;
            PM = (mujeres * P) / total;
            Console.WriteLine("El porcentaje de hombres que hay es de: " + PH + "%. Y el porcentaje de mujeres que hay es de: " + PM + "%");
    


        }
    }
}

// Una universidad desea conocer los porcentajes de mujeres y hombres en las
// carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
// mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
// los porcentajes correspondientes.