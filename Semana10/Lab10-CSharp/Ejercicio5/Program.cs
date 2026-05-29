using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        // Función con retorno.
        // Calcula el porcentaje de asistencia de una sesión.
        static double CalcularPorcentaje(int presentes, int matriculados)
        {
            // Multiplicamos por 100.0 para asegurar resultado decimal.
            return presentes * 100.0 / matriculados;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE ASISTENCIA A TALLER ===");

            // Acumulador de los porcentajes de las 4 sesiones.
            double sumaPorcentajes = 0;

            // El taller tiene exactamente 4 sesiones.
            for (int sesion = 1; sesion <= 4; sesion++)
            {
                Console.WriteLine($"\nSesión {sesion}");

                // Cantidad de estudiantes que asistieron.
                Console.Write("Estudiantes presentes: ");
                int presentes = int.Parse(Console.ReadLine());

                // Cantidad total de estudiantes matriculados.
                Console.Write("Estudiantes matriculados: ");
                int matriculados = int.Parse(Console.ReadLine());

                // Calculamos el porcentaje de asistencia de la sesión actual.
                double porcentaje = CalcularPorcentaje(presentes, matriculados);

                // Sumamos el porcentaje al acumulador.
                sumaPorcentajes += porcentaje;

                // Mostramos el porcentaje de la sesión.
                Console.WriteLine($"Porcentaje de asistencia: {porcentaje:F2}%");
            }

            // Calculamos el promedio de las 4 sesiones.
            double promedio = sumaPorcentajes / 4;

            Console.WriteLine($"\nPromedio de asistencia: {promedio:F2}%");

            // Si el promedio es al menos 75%, la participación es adecuada.
            if (promedio >= 75)
            {
                Console.WriteLine("Participación adecuada");
            }
            else
            {
                Console.WriteLine("Reforzar asistencia");
            }
        }
    }
}
