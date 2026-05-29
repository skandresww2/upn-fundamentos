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
            Console.WriteLine("=== TIENDA - CÁLCULO DE DESCUENTO ===");

            // Entrada de datos: cantidad de productos.
            Console.Write("Ingrese cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Entrada de datos: precio unitario del producto.
            Console.Write("Ingrese precio unitario: S/");
            double precio = double.Parse(Console.ReadLine());

            // Llamamos al método de la clase UtilTienda para calcular el subtotal.
            double subtotal = UtilTienda.CalcularSubtotal(cantidad, precio);

            // Llamamos al método que evalúa si corresponde descuento.
            double descuento = UtilTienda.CalcularDescuento(subtotal);

            // Llamamos al método que calcula el total final.
            double total = UtilTienda.CalcularTotal(subtotal, descuento);

            Console.WriteLine("\n=== COMPROBANTE DE COMPRA ===");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: S/{precio:F2}");
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");
            Console.WriteLine($"Descuento: S/{descuento:F2}");
            Console.WriteLine($"Total a pagar: S/{total:F2}");
        }
    }
}
