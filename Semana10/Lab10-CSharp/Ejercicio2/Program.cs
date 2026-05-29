using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {

        // Devuelve el importe del pedido.
        static double CalcularImporte(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        // muestra el resumen de un pedido.
        static void MostrarPedido(string plato, int cantidad, double importe)
        {
            Console.WriteLine($"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:F2}");
        }
        static void Main(string[] args)
        {
            // Acumulador del total vendido
            double totalDia = 0;

            // Se registran exactamente 3 pedidos.
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nPedido {i}");

                Console.Write("Nombre del plato: ");
                string plato = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.Write("Precio unitario: S/");
                double precio = double.Parse(Console.ReadLine());

                // Calculamos el importe del pedido usando una función.
                double importe = CalcularImporte(cantidad, precio);

                // Acumulamos el importe en el total del día.
                totalDia += importe;

                // Mostramos el detalle del pedido actual.
                MostrarPedido(plato, cantidad, importe);
            }

            // Al terminar los 3 pedidos, mostramos el total acumulado.
            Console.WriteLine($"\nTotal vendido del día: S/{totalDia:F2}");
        }
    }
}
