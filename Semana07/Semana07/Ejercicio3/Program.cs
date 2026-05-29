using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            // Se usa do-while porque primero se pide la nota y luego se valida.
            do
            {
                Console.Write("Ingrese nota (0-20): ");
                nota = int.Parse(Console.ReadLine());

                // La nota es inválida si está fuera del rango 0 a 20.
                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Error: nota debe ser entre 0 y 20.");
                }

            } while (nota < 0 || nota > 20); // Repetir mientras la nota sea inválida.

            // Clasificación de la nota válida.
            if (nota >= 18)
            {
                Console.WriteLine("Clasificación: EXCELENTE");
            }
            else if (nota >= 14)
            {
                Console.WriteLine("Clasificación: BUENO");
            }
            else if (nota >= 11)
            {
                Console.WriteLine("Clasificación: REGULAR");
            }
            else
            {
                Console.WriteLine("Clasificación: DESAPROBADO");
            }
        }
    }
}
