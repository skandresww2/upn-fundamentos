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
            // Stock inicial del almacén (cantidad disponible al empezar)
            int stock = 500;
            // Acumulador: suma todas las ventas válidas registradas
            int totalVendido = 0;

            // LECTURA ADELANTADA: se pide la primera venta ANTES del while
            // Necesario para que el while pueda evaluar la condición en la 1ª iteración
            Console.Write("Unidades vendidas (0 para salir): ");
            int venta = int.Parse(Console.ReadLine());

            // Centinela = 0 → mientras la venta sea distinta de 0, sigue el bucle
            while (venta != 0)
            {
                // VALIDACIÓN 1: número negativo no tiene sentido como venta
                if (venta < 0)
                {
                    Console.WriteLine("Error: cantidad no puede ser negativa.");
                    // No se descuenta nada, no se suma nada
                }
                // VALIDACIÓN 2: no se puede vender más de lo que hay en stock
                else if (venta > stock)
                {
                    Console.WriteLine($"Error: stock insuficiente. Quedan {stock}");
                    // Se rechaza la venta: stock y totalVendido no cambian
                }
                // CASO VÁLIDO: venta entre 1 y stock disponible
                else
                {
                    stock -= venta;          // Descuenta del inventario
                    totalVendido += venta;   // Acumula al total vendido
                    Console.WriteLine($"Venta registrada. Stock: {stock}");
                }

                // RELECTURA al final del while (mismo nivel que el if/else)
                // Garantiza que se siga pidiendo aunque la venta anterior fuera inválida
                Console.Write("Unidades vendidas (0 para salir): ");
                venta = int.Parse(Console.ReadLine());
            }

            // Reporte final tras salir del bucle (cuando se ingresó 0)
            Console.WriteLine($"Stock restante: {stock}");
            Console.WriteLine($"Total vendido: {totalVendido}");
        }
    }
}
