using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario el promedio
            Console.Write("Promedio (0–20): ");
            double promedio = double.Parse(Console.ReadLine());

            // Evaluamos en qué rango se encuentra el promedio
            if (promedio >= 0 && promedio <= 5)
            {
                Console.WriteLine("Deficiente");
            }
            else if (promedio >= 6 && promedio <= 10)
            {
                Console.WriteLine("Regular");
            }
            else if (promedio >= 11 && promedio <= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (promedio >= 15 && promedio <= 20)
            {
                Console.WriteLine("Excelente");
            }
            else
            {
                // Si el valor está fuera del rango 0 a 20
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
