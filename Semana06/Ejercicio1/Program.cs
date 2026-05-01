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
            double saldo = 1000.00; // Saldo inicial
            int retiros = 0;       // Contador de retiros exitosos

            Console.WriteLine("=== CAJERO AUTOMÁTICO ===");
            Console.WriteLine($"Saldo disponible: S/{saldo:F2}");

            // Primera lectura antes del while
            Console.Write("Monto a retirar (0 para salir): ");
            double monto = double.Parse(Console.ReadLine());

            while (monto != 0)
            {
                if (monto < 0)
                {
                    Console.WriteLine("Error: monto inválido.");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Error: saldo insuficiente.");
                }
                else
                {
                    saldo -= monto;
                    retiros++;
                    Console.WriteLine($"Retiro exitoso. Saldo: S/{saldo:F2}");
                }

                // Nueva lectura para evitar bucle infinito
                Console.Write("Monto a retirar (0 para salir): ");
                monto = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("--- RESUMEN ---");
            Console.WriteLine($"Retiros realizados: {retiros}");
            Console.WriteLine($"Saldo final: S/{saldo:F2}");
        }
    }
}
