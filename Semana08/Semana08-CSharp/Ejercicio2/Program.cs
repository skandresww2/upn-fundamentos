using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        // Método principal del programa.
        // La ejecución inicia aquí.
        static void Main(string[] args)
        {
            // Solicita el nombre del estudiante.
            Console.Write("Nombre del estudiante: ");

            // Lee el texto ingresado y lo guarda en la variable nombre.
            string nombre = Console.ReadLine();

            // Solicita la primera nota.
            Console.Write("Nota 1: ");

            // Lee la nota como texto y la convierte a double.
            double n1 = double.Parse(Console.ReadLine());

            // Solicita la segunda nota.
            Console.Write("Nota 2: ");

            // Lee la segunda nota y la convierte a double.
            double n2 = double.Parse(Console.ReadLine());

            // Solicita la tercera nota.
            Console.Write("Nota 3: ");

            // Lee la tercera nota y la convierte a double.
            double n3 = double.Parse(Console.ReadLine());

            // Llama a la función CalcularPromedio.
            // Envía las tres notas.
            // El resultado se guarda en la variable promedio.
            double promedio = CalcularPromedio(n1, n2, n3);

            // Llama a la función ClasificarPromedio.
            // Envía el promedio calculado.
            // El resultado será "Aprobado" o "Desaprobado".
            string estado = ClasificarPromedio(promedio);

            // Llama a la función ImprimirReporte.
            // Envía el nombre, el promedio y el estado.
            // Esta función solo muestra los datos en pantalla.
            ImprimirReporte(nombre, promedio, estado);
        }

        // Variable estática de clase.
        // Representa la nota mínima para aprobar.
        // Se puede usar en cualquier método de esta clase.
        static double NOTA_APROBATORIA = 11;

        // Función con retorno.
        // Recibe tres notas como parámetros.
        // Devuelve un valor double, que será el promedio.
        static double CalcularPromedio(double n1, double n2, double n3)
        {
            // Se suman las tres notas y se dividen entre 3.
            // La variable promedio es local:
            // solo existe dentro de esta función.
            double promedio = (n1 + n2 + n3) / 3;

            // return devuelve el resultado calculado
            // al lugar donde se llamó la función.
            return promedio;
        }

        // Función con retorno de tipo string.
        // Recibe el promedio y devuelve un texto:
        // "Aprobado" o "Desaprobado".
        static string ClasificarPromedio(double promedio)
        {
            // Si el promedio es mayor o igual a la nota aprobatoria,
            // el estudiante aprueba.
            if (promedio >= NOTA_APROBATORIA)
            {
                return "Aprobado";
            }
            else
            {
                // Si el promedio es menor que la nota aprobatoria,
                // el estudiante desaprueba.
                return "Desaprobado";
            }
        }

        // Función void.
        // No devuelve ningún valor.
        // Solo recibe datos y los muestra en pantalla.
        static void ImprimirReporte(string estudiante, double promedio, string estado)
        {
            // Muestra el título del reporte.
            Console.WriteLine("\n=== REPORTE DE NOTAS ===");

            // Muestra el nombre del estudiante.
            Console.WriteLine($"Estudiante: {estudiante}");

            // Muestra el promedio con 2 decimales.
            // F2 significa formato con 2 decimales.
            Console.WriteLine($"Promedio: {promedio:F2}");

            // Muestra si está aprobado o desaprobado.
            Console.WriteLine($"Estado: {estado}");
        }
    }
}
