using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {

        // Recibe la opción elegida por el usuario y devuelve la tarifa correspondiente.
        static double ObtenerTarifa(int opcion)
        {
            // Si elige 1, corresponde al servicio de diagnóstico.
            if (opcion == 1)
            {
                return 30;
            }
            // Si elige 2, corresponde al servicio de mantenimiento.
            else if (opcion == 2)
            {
                return 60;
            }
            // Si elige 3, corresponde al servicio de reparación.
            else if (opcion == 3)
            {
                return 90;
            }
            // Si la opción no existe, retornamos 0 para indicar error.
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Diagnóstico - S/30");
            Console.WriteLine("2. Mantenimiento - S/60");
            Console.WriteLine("3. Reparación - S/90");

            // Entrada de la opción elegida.
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            // Obtenemos la tarifa inmediatamente después de leer la opción.
            double tarifa = ObtenerTarifa(opcion);

            // En ese caso, no tiene sentido pedir la cantidad de equipos.
            if (tarifa == 0)
            {
                Console.WriteLine("Datos no válidos.");
                return; // Termina el método Main y ya no continúa el programa.
            }

            // Solo si la opción fue válida, pedimos la cantidad de equipos.
            Console.Write("Cantidad de equipos: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Validamos que la cantidad sea positiva.
            if (cantidad > 0)
            {
                double total = tarifa * cantidad;
                Console.WriteLine($"Total a pagar: S/{total:F2}");
            }
            else
            {
                Console.WriteLine("Datos no válidos.");
            }
        }
    }
}
