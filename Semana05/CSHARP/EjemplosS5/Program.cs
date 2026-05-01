using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            //Ejemplo02();
            //Ejemplo03();
            Ejemplo04();
        }

        //Ejemplo 01
        public static void Ejemplo01()
        {
            Console.Write("Ingrese número entero: ");
            int num = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32(): también convierte a entero, pero pertenece a la clase Convert.

            if (num > 0)
            {
                Console.WriteLine("Número positivo.");
            } else
            {
                if(num < 0)
                {
                    Console.WriteLine("Número negativo.");
                } else
                {
                    Console.WriteLine("Número es CERO.");
                }
            }
        }

        //Ejemplo 02
        public static void Ejemplo02()
        {
            Console.Write("Número base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Hasta (limite del multiplicador): ");
            int limite = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{baseNum} * {i} = {baseNum*i}");
            }
        }

        //Ejemplo 03
        public static void Ejemplo03()
        {
            //Elabora un programa que muestre en pantalla la potencia al
            //cuadrado de los diez primeros números naturales, desde 1 hasta 10.
            // Recorremos los números del 1 al 10
            for (int i = 1; i <= 10; i++) 
            {
                // Calculamos la potencia al cuadrado usando Math.Pow
                double resultado = Math.Pow(i, 2);
                // Mostramos el número y su cuadrado
                Console.WriteLine($"{i}^2 = {resultado}");
            }
        }

        //Ejemplo 04
        public static void Ejemplo04()
        {
            //Elabora un programa que lea un número entero positivo
            //y muestre todos los números menores que él, en orden descendente,
            //hasta llegar a 0.
            Console.WriteLine("Ingrese número entero positivo: ");
            int n = int.Parse(Console.ReadLine());
           
            // Mostrar los números menores que n, desde n-1 hasta 0
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }

        }
    }
}
