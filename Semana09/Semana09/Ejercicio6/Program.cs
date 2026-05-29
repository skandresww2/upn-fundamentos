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
            Console.WriteLine("=== PRESUPUESTO FAMILIAR MENSUAL ===");

            // Entrada del ingreso mensual.
            Console.Write("Ingrese ingreso mensual: S/");
            double ingreso = double.Parse(Console.ReadLine());

            // Entrada de los gastos principales.
            Console.Write("Ingrese gasto en alimentos: S/");
            double alimentos = double.Parse(Console.ReadLine());

            Console.Write("Ingrese gasto en servicios: S/");
            double servicios = double.Parse(Console.ReadLine());

            Console.Write("Ingrese gasto en transporte: S/");
            double transporte = double.Parse(Console.ReadLine());

            // Llamamos a la clase UtilPresupuesto para calcular el total de gastos.
            double gastos = UtilPresupuesto.CalcularGastos(alimentos, servicios, transporte);

            // Calculamos el saldo disponible después de los gastos.
            double saldo = UtilPresupuesto.CalcularSaldo(ingreso, gastos);

            // Evaluamos si los gastos alcanzan o superan el 80 % del ingreso.
            bool alerta = UtilPresupuesto.EvaluarAlerta(ingreso, gastos);

            Console.WriteLine("\n=== REPORTE DE PRESUPUESTO ===");
            Console.WriteLine($"Ingreso mensual: S/{ingreso:F2}");
            Console.WriteLine($"Total de gastos: S/{gastos:F2}");
            Console.WriteLine($"Saldo disponible: S/{saldo:F2}");

            // Mostrar mensaje según el resultado de la alerta.
            if (alerta)
            {
                Console.WriteLine("Alerta: gastos altos.");
            }
            else
            {
                Console.WriteLine("Sin alerta: gastos dentro del rango recomendado.");
            }
        }
    }
}
