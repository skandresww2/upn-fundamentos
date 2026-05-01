using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Depósito inicial: S/");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Meta a alcanzar: S/");
            double meta = double.Parse(Console.ReadLine());

            double tasa = 0.015;   // 1.5% mensual expresado como decimal
            int meses = 0;         // contador de meses transcurridos

            Console.WriteLine($"Mes 0: S/{saldo:F2}");   // estado inicial antes de aplicar interés

            // Sigue iterando mientras el saldo NO haya alcanzado la meta
            while (saldo < meta)
            {
                // Aplica interés compuesto: saldo nuevo = saldo + (saldo * tasa)
                // Equivale a saldo *= (1 + tasa)
                saldo = saldo + saldo * tasa;
                meses++;   // suma un mes por cada iteración
                Console.WriteLine($"Mes {meses}: S/{saldo:F2}");
            }

            Console.WriteLine($"Alcanzará la meta en {meses} meses.");
        }
    }
}
