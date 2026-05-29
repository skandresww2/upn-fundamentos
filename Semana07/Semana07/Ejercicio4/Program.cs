using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subtotal = 0;      // Acumulador del monto de la compra
            int totalArticulos = 0;   // Contador de artículos comprados
            int opcion;

            do
            {
                Console.WriteLine("\n--- TIENDA TECH ---");
                Console.WriteLine("1. USB 32GB - S/25");
                Console.WriteLine("2. Mouse inalámbrico - S/45");
                Console.WriteLine("3. Audífonos - S/60");
                Console.WriteLine("0. Finalizar compra");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                // Solo si la opción es 1, 2 o 3 se pide cantidad
                if (opcion >= 1 && opcion <= 3)
                {
                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    double precio = 0;

                    // Asignar precio según el producto elegido
                    if (opcion == 1)
                    {
                        precio = 25;
                    }
                    else if (opcion == 2)
                    {
                        precio = 45;
                    }
                    else if (opcion == 3)
                    {
                        precio = 60;
                    }

                    // Acumular el costo del producto elegido
                    subtotal = subtotal + precio * cantidad;

                    // Acumular la cantidad total de artículos
                    totalArticulos = totalArticulos + cantidad;
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opción no válida.");
                }

            } while (opcion != 0); // Repetir hasta elegir 0

            double descuento = 0;

            // Aplicar descuento solo si el subtotal supera S/100
            if (subtotal > 100)
            {
                descuento = subtotal * 0.10;
            }

            double total = subtotal - descuento;

            Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
            Console.WriteLine($"Artículos: {totalArticulos}");
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");
            Console.WriteLine($"Descuento: S/{descuento:F2}");
            Console.WriteLine($"TOTAL: S/{total:F2}");
        }
    }
}
