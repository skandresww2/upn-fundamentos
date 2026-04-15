using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Solicitar la edad (entero) al usuario
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            // 2) Condicional DOBLE: if-else cubre los dos casos posibles
            if (edad >= 18)
            {
                // Rama VERDADERA
                Console.WriteLine("Acceso permitido. Bienvenido.");
            }
            else
            {
                // Rama FALSA: calcular años faltantes con valor absoluto
                int faltan = Math.Abs(18 - edad);
                Console.WriteLine("Acceso denegado.");
                Console.WriteLine($"Te faltan {faltan} año(s) para registrarte.");
            }

        }
    }
}
