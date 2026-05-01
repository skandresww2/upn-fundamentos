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
            // Pedimos la cantidad de días a analizar
            Console.Write("Ingrese la cantidad de días: ");
            int n = int.Parse(Console.ReadLine());

            // Variables acumuladoras y de control
            double total = 0;
            double mayor = 0;
            double menor = double.MaxValue; // Valor muy grande para iniciar la menor venta
            int diaMayor = 0;
            int diaMenor = 0;

            // Contadores por categoría
            int excelente = 0;
            int bueno = 0;
            int regular = 0;
            int malo = 0;

            // Recorremos cada día
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese la venta del día {i}: ");
                double venta = double.Parse(Console.ReadLine());

                // Acumular la venta al total
                total += venta;

                // Verificar si es la mayor venta registrada hasta ahora
                if (venta > mayor)
                {
                    mayor = venta;
                    diaMayor = i;
                }

                // Verificar si es la menor venta registrada hasta ahora
                if (venta < menor)
                {
                    menor = venta;
                    diaMenor = i;
                }

                // Clasificar la venta y aumentar su contador
                if (venta >= 500)
                {
                    excelente++;
                }
                else if (venta >= 200)
                {
                    bueno++;
                }
                else if (venta >= 50)
                {
                    regular++;
                }
                else
                {
                    malo++;
                }
            }

            // Calcular el promedio
            double promedio = total / n;

            // Mostrar el resumen final
            Console.WriteLine("\n----- Resumen de ventas -----");
            Console.WriteLine($"Total de ventas: S/{total:F2}");
            Console.WriteLine($"Promedio diario: S/{promedio:F2}");
            Console.WriteLine($"Mayor venta: Día {diaMayor} con S/{mayor:F2}");
            Console.WriteLine($"Menor venta: Día {diaMenor} con S/{menor:F2}");
            Console.WriteLine($"Días Excelente: {excelente}");
            Console.WriteLine($"Días Bueno: {bueno}");
            Console.WriteLine($"Días Regular: {regular}");
            Console.WriteLine($"Días Malo: {malo}");
        }
    }
}
