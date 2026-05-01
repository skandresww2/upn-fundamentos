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
            // Precio fijo de cada cuaderno
            double precioUnitario = 5.00;

            // Mostrar encabezado de la tabla
            Console.WriteLine("Cant | Subtotal | Desc% | Total");
            Console.WriteLine("-----|----------|-------|--------");

            // Recorremos las cantidades desde 1 hasta 20
            for (int cant = 1; cant <= 20; cant++)
            {
                // Calcular subtotal: cantidad por precio unitario
                double subtotal = cant * precioUnitario;

                // Variable donde guardaremos el porcentaje de descuento
                double descuento;

                // Determinar el descuento según la cantidad comprada
                if (cant <= 5)
                {
                    // De 1 a 5 unidades no hay descuento
                    descuento = 0;
                }
                else if (cant <= 12)
                {
                    // De 6 a 12 unidades se aplica 10%
                    descuento = 0.10;
                }
                else
                {
                    // Más de 12 unidades se aplica 20%
                    descuento = 0.20;
                }

                // Calcular total final aplicando el descuento
                double total = subtotal * (1 - descuento);

                // Mostrar una fila de la tabla con formato
                Console.WriteLine($" {cant,3} | S/{subtotal,6:F2} | {descuento * 100,3:F0}% | S/{total,6:F2}");
            }
        }
    }
}
