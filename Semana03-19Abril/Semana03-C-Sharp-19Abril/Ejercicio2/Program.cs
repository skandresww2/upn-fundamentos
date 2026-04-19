using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menú de operaciones ===");
            Console.WriteLine("1. Calcular área de un círculo");
            Console.WriteLine("2. Calcular área de un cuadrado");
            Console.WriteLine("3. Calcular área de un triángulo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción (1–4): ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) // evalúa el valor de la variable
            {
                case 1:
                    Console.WriteLine("Área círculo = p × r²");
                    Console.Write("Ingrese p: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese r: ");
                    int r = int.Parse(Console.ReadLine());
                    double area = p * Math.Pow(r,2);
                    Console.WriteLine($"El area del circulo es: {area}");
                    break; // obligatorio en C# — termina el case
                case 2:
                    Console.WriteLine("Área cuadrado = lado²");
                    break;
                case 3:
                    Console.WriteLine("Área triángulo = (base × altura) / 2");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default: // si ningún case coincide
                    Console.WriteLine("Opción inválida. Ingresa un número del 1 al 4.");
                    break;
            }
        }
    }
}
