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
            Console.WriteLine("=== SISTEMA DE CLASIFICACIÓN DE NOTAS ===");

            // Solicitar la nota final al usuario.
            Console.Write("Ingrese nota final (0-20): ");
            double nota = double.Parse(Console.ReadLine());

            // Primero validamos la nota antes de clasificarla.
            if (EsNotaValida(nota))
            {
                // Si la nota es válida, llamamos a la función que clasifica.
                string clasificacion = ClasificarNota(nota);

                // Luego mostramos el reporte usando un método void.
                MostrarReporte(nota, clasificacion);
            }
            else
            {
                // Si la nota no está entre 0 y 20, se muestra un mensaje de error.
                Console.WriteLine("Error: la nota debe estar entre 0 y 20.");
            }
        }

        // Función con retorno bool.
        // Verifica si la nota ingresada está dentro del rango válido: 0 a 20.
        static bool EsNotaValida(double nota)
        {
            return nota >= 0 && nota <= 20;
        }

        // Función con retorno string.
        // Recibe una nota válida y devuelve su clasificación.
        static string ClasificarNota(double nota)
        {
            // Si la nota es 18 o más, se considera excelente.
            if (nota >= 18)
            {
                return "Excelente";
            }
            // Si no fue excelente, pero es 14 o más, se considera bueno.
            else if (nota >= 14)
            {
                return "Bueno";
            }
            // Si no fue bueno, pero es 11 o más, se considera regular.
            else if (nota >= 11)
            {
                return "Regular";
            }
            // Si la nota está entre 0 y 10, queda desaprobado.
            else
            {
                return "Desaprobado";
            }
        }

        // Método void.
        // No devuelve ningún valor; solo muestra el reporte final.
        static void MostrarReporte(double nota, string clasificacion)
        {
            Console.WriteLine("\n=== REPORTE ACADÉMICO ===");
            Console.WriteLine($"Nota ingresada: {nota:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }

    }
}
