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
            // Muestra un mensaje para pedir el precio unitario.
            Console.Write("Precio unitario: S/");

            // Lee el precio ingresado por el usuario.
            // Console.ReadLine() lee texto.
            // double.Parse convierte ese texto a número decimal.
            double precio = double.Parse(Console.ReadLine());

            // Muestra un mensaje para pedir la cantidad.
            Console.Write("Cantidad: ");

            // Lee la cantidad ingresada por el usuario.
            // int.Parse convierte el texto a número entero.
            int cantidad = int.Parse(Console.ReadLine());

            // Llama a la función CalcularSubtotal.
            // Envía precio y cantidad.
            // Guarda el resultado en la variable subtotal.
            double subtotal = CalcularSubtotal(precio, cantidad);

            // Llama a la función CalcularIGV.
            // Envía el subtotal.
            // Guarda el resultado en la variable igv.
            double igv = CalcularIGV(subtotal);

            // Llama a la función CalcularTotal.
            // Envía subtotal e igv.
            // Guarda el resultado en la variable total.
            double total = CalcularTotal(subtotal, igv);

            // Llama a la función MostrarBoleta.
            // Envía los valores calculados para mostrarlos en pantalla.
            MostrarBoleta(subtotal, igv, total);
        }

        // Constante o variable global de la clase.
        // Guarda el valor del IGV: 18%, que en decimal es 0.18.
        static double IGV = 0.18;

        // Función que calcula el subtotal.
        // Recibe dos datos:
        // precioUnitario: precio de un producto.
        // cantidad: número de productos comprados.
        // Devuelve un double porque el resultado puede tener decimales.
        static double CalcularSubtotal(double precioUnitario, int cantidad)
        {
            // Multiplica el precio unitario por la cantidad.
            // Este resultado todavía no incluye IGV.
            return precioUnitario * cantidad;
        }

        // Función que calcula el IGV.
        // Recibe el subtotal como dato de entrada.
        // Devuelve el monto del IGV.
        static double CalcularIGV(double subtotal)
        {
            // Multiplica el subtotal por 0.18.
            // Se usa la variable IGV para no escribir 0.18 directamente.
            return subtotal * IGV;
        }

        // Función que calcula el total a pagar.
        // Recibe el subtotal y el monto del IGV.
        // Devuelve la suma de ambos valores.
        static double CalcularTotal(double subtotal, double igv)
        {
            // El total se obtiene sumando subtotal más IGV.
            return subtotal + igv;
        }

        // Función que muestra la boleta en pantalla.
        // Es void porque no devuelve ningún valor.
        // Solo imprime información.
        static void MostrarBoleta(double subtotal, double igv, double total)
        {
            // Imprime una línea en blanco y el título de la boleta.
            Console.WriteLine("\n=== BOLETA ===");

            // Muestra el subtotal con 2 decimales.
            // F2 significa formato con 2 decimales.
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");

            // Muestra el IGV con 2 decimales.
            Console.WriteLine($"IGV (18%): S/{igv:F2}");

            // Muestra el total final con 2 decimales.
            Console.WriteLine($"TOTAL: S/{total:F2}");
        }
    }
}
