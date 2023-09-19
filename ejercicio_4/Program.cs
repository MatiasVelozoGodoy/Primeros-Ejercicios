using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float total;
            const float sueldoFijo = 15000;
            const float comision = 0.05F;
            Console.WriteLine("Cuanto facturaste?");
            total = float.Parse(Console.ReadLine());
            total = total * comision + sueldoFijo;
            Console.WriteLine("El sueldo es " + total);
        }
    }
}



//Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
//Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.