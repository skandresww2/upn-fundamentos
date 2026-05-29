using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DE CONSUMO DE AGUA ===");

            // Entrada de datos.
            Console.Write("Ingrese consumo en m3: ");
            double m3 = double.Parse(Console.ReadLine());

            // Llamamos a la función que calcula el costo.
            double costo = CalcularCostoAgua(m3);

            // Llamamos al método que muestra el recibo.
            MostrarRecibo(m3, costo);
        }

        // Función con retorno.
        // Recibe el consumo en m3 y calcula el costo total según la tarifa por tramos.
        static double CalcularCostoAgua(double m3)
        {
            double costo;

            // Si el consumo es hasta 20 m3, todo se cobra a S/1.80 por m3.
            if (m3 <= 20)
            {
                costo = m3 * 1.80;
            }
            else
            {
                // Si supera 20 m3:
                // Los primeros 20 m3 cuestan S/1.80 cada uno.
                // El exceso se cobra a S/2.50 por m3.
                costo = 20 * 1.80 + (m3 - 20) * 2.50;
            }

            return costo;
        }

        // Método void.
        // No devuelve valor, solo muestra el recibo final.
        static void MostrarRecibo(double m3, double costo)
        {
            Console.WriteLine("\n=== RECIBO DE AGUA ===");
            Console.WriteLine($"Consumo: {m3:F2} m3");
            Console.WriteLine($"Costo total: S/{costo:F2}");
        }
    }
}
