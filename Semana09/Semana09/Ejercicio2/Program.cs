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
            Console.WriteLine("=== DIVISIÓN SEGURA ===");

            Console.Write("Ingrese el dividendo: ");
            double dividendo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            double divisor = double.Parse(Console.ReadLine());

            // Declaramos la variable donde se guardará el resultado.
            // No es necesario asignarle valor inicial porque el método la recibirá con out.
            double resultado;

            // DividirSeguro devuelve true si la división fue válida.
            // Además, guarda el resultado en la variable resultado usando out.
            bool valido = DividirSeguro(dividendo, divisor, out resultado);

            if (valido)
            {
                Console.WriteLine($"Resultado: {resultado:F2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }

        // Método con retorno bool y parámetro out.
        // Retorna true si la división se puede realizar.
        // Retorna false si el divisor es cero.
        static bool DividirSeguro(double dividendo, double divisor, out double resultado)
        {
            if (divisor == 0)
            {
                // Aunque la división no sea válida, en C# un parámetro out debe recibir un valor.
                resultado = 0;
                return false;
            }

            // Si el divisor no es cero, se realiza la división.
            resultado = dividendo / divisor;
            return true;
        }
    }
}
