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
            double suma = 0;
            int contador = 0;
            double mayor = 0;
            double menor = double.MaxValue;  // Inicializar en máximo: cualquier nota válida será menor

            // Primera lectura ANTES del while (patrón centinela)
            Console.Write("Ingrese nota (-1 para terminar): ");
            double nota = double.Parse(Console.ReadLine());

            while (nota != -1)  // -1 = valor(centinela) especial que marca el fin de la entrada de datos en un bucle.
            {
                if (nota < 0 || nota > 20)
                    Console.WriteLine("Nota inválida (debe ser 0-20).");
                else
                {
                    suma += nota;
                    contador++;
                    if (nota > mayor) mayor = nota;   // Actualiza máximo
                    if (nota < menor) menor = nota;   // Actualiza mínimo
                }

                // CLAVE: lectura al final del while, fuera del if/else
                // Así se sigue pidiendo aunque la nota anterior fuera inválida
                Console.Write("Ingrese nota (-1 para terminar): ");
                nota = double.Parse(Console.ReadLine());
            }

            // Solo calcular promedio si hubo notas válidas (evita división por 0)
            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"Notas ingresadas: {contador}");
                Console.WriteLine($"Nota más alta: {mayor}");
                Console.WriteLine($"Nota más baja: {menor}");
                Console.WriteLine($"Promedio: {promedio:F2}");  // F2 = 2 decimales
            }
            else
                Console.WriteLine("No se ingresaron notas válidas.");
        }
    }
}
