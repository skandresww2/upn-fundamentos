using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE STOCK ===");

            Console.Write("Ingrese stock actual: ");
            int stock = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad vendida: ");
            int venta = int.Parse(Console.ReadLine());

            // Primero validamos si hay stock suficiente.
            if (venta <= stock)
            {
                // Esta función trabaja por valor.
                // Simula cómo quedaría el stock, pero NO modifica la variable original.
                SimularVenta(stock, venta);

                Console.WriteLine($"Stock real después de simular: {stock}");

                // Esta función trabaja por referencia.
                // Aquí sí se modifica el stock real.
                ConfirmarVenta(ref stock, venta);

                Console.WriteLine($"Stock real después de confirmar: {stock}");
            }
            else
            {
                Console.WriteLine("No se confirma venta por falta de stock.");
            }
        }

        // Parámetro por valor:
        // stock recibe una copia del valor original.
        // Aunque aquí se modifique stock, el stock real del Main no cambia.
        static void SimularVenta(int stock, int venta)
        {
            stock = stock - venta;
            Console.WriteLine($"Simulación: el stock quedaría en {stock}");
        }

        // Parámetro por referencia:
        // ref permite modificar directamente la variable original enviada desde Main.
        static void ConfirmarVenta(ref int stock, int venta)
        {
            stock = stock - venta;
            Console.WriteLine($"Confirmación: venta realizada correctamente.");
        }
    }
}
