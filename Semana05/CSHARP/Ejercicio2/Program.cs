using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario el consumo de energía en kWh
            Console.Write("Ingrese consumo en kWh: ");
            int kwh = int.Parse(Console.ReadLine());

            // Variable donde guardaremos el monto final a pagar
            double monto = 0;

            // Validamos que el consumo sea mayor que cero
            if (kwh <= 0)
            {
                Console.WriteLine("Error: consumo debe ser positivo.");
            }
            // Primer tramo: hasta 100 kWh
            else if (kwh <= 100)
            {
                // Todo el consumo se cobra a S/0.50
                monto = kwh * 0.50;
            }
            // Segundo tramo: de 101 a 300 kWh
            else if (kwh <= 300)
            {
                // Los primeros 100 kWh se cobran a S/0.50
                // El exceso sobre 100 se cobra a S/0.75
                monto = 100 * 0.50 + (kwh - 100) * 0.75;
            }
            // Tercer tramo: más de 300 kWh
            else
            {
                // Los primeros 100 kWh se cobran a S/0.50
                // Los siguientes 200 kWh se cobran a S/0.75
                // Lo que excede 300 se cobra a S/1.20
                monto = 100 * 0.50 + 200 * 0.75 + (kwh - 300) * 1.20;
            }

            // Mostramos el monto final con 2 decimales
            Console.WriteLine($"Monto a pagar: S/{monto:F2}");
        }
    }
}
