using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario la nota del examen parcial
            Console.Write("Ingrese examen parcial: ");
            double parcial = double.Parse(Console.ReadLine());

            // Pedimos al usuario la nota del examen final
            Console.Write("Ingrese examen final: ");
            double final = double.Parse(Console.ReadLine());

            // Pedimos las 3 notas de práctica
            Console.Write("Ingrese práctica 1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese práctica 2: ");
            double p2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese práctica 3: ");
            double p3 = double.Parse(Console.ReadLine());

            // Math.Min sirve para encontrar el menor valor
            // Aquí buscamos la práctica más baja entre p1, p2 y p3
            // Primero compara p2 con p3, y luego compara ese resultado con p1
            double menor = Math.Min(p1, Math.Min(p2, p3));

            // Sumamos las 3 prácticas
            // Luego restamos la menor práctica para descartarla
            // Finalmente dividimos entre 2 porque solo quedan las 2 mejores prácticas
            double promPrac = (p1 + p2 + p3 - menor) / 2;

            // Calculamos el promedio final
            // Se suman:
            // 1) examen parcial
            // 2) examen final
            // 3) promedio de las 2 mejores prácticas
            // Luego dividimos entre 3 porque son tres componentes
            double promFinal = (parcial + final + promPrac) / 3;

            // Mostramos el promedio de prácticas redondeado a 2 decimales
            Console.WriteLine($"Promedio de prácticas: {Math.Round(promPrac, 2)}");

            // Mostramos el promedio final redondeado a 2 decimales
            Console.WriteLine($"Promedio final: {Math.Round(promFinal, 2)}");

            // Clasificamos el promedio final
            // Se empieza por el rango más alto
            if (promFinal >= 18)
            {
                Console.WriteLine("Excelente");
            }
            else if (promFinal >= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (promFinal >= 10)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Deficiente");
            }
        }
    }
}
