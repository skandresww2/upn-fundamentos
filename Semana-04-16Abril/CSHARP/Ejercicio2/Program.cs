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
            Console.WriteLine("====Menu de operaciones====");
            Console.WriteLine("1. Calcular área de un circulo");
            Console.WriteLine("2. Calcular el área de un cuadrado");
            Console.WriteLine("3. Calcular el área de un triangulo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción (1-4): ");

            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Area de un circulo = p*r²");                    
                    break;
                case 2:
                    Console.WriteLine("Area de un cuadrado = lado²");
                    break;
                case 3:
                    Console.WriteLine("Area de un traingulo = (base*altura)/2");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
