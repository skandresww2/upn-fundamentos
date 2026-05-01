using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos la cantidad de empleados
            Console.Write("Ingrese la cantidad de empleados: ");
            int n = int.Parse(Console.ReadLine());

            // Acumulador para guardar la suma de todos los sueldos netos
            double totalPlanilla = 0;

            // Recorremos a cada empleado
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmpleado {i}");

                // Leer nombre del empleado
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                // Leer horas trabajadas
                Console.Write("Horas trabajadas: ");
                int horasTrabajadas = int.Parse(Console.ReadLine());

                // Variables para el cálculo
                int horasExtras;
                int horasNormales;
                double sueldoBruto;

                // Si trabajó 160 horas o menos, todo se paga como horas normales
                if (horasTrabajadas <= 160)
                {
                    horasNormales = horasTrabajadas;
                    horasExtras = 0;
                    sueldoBruto = horasTrabajadas * 12.50;
                }
                else
                {
                    // Si supera 160, calculamos las horas extra
                    horasNormales = 160;
                    horasExtras = horasTrabajadas - 160;

                    // Las horas normales van a S/12.50
                    // Las horas extra van a S/25.00
                    sueldoBruto = 160 * 12.50 + horasExtras * 25.00;
                }

                // Calculamos el descuento del 5%
                double descuento = sueldoBruto * 0.05;

                // Calculamos el sueldo neto
                double sueldoNeto = sueldoBruto - descuento;

                // Acumulamos el sueldo neto al total de planilla
                totalPlanilla += sueldoNeto;

                // Mostramos los resultados del empleado
                Console.WriteLine("----- Boleta del empleado -----");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Horas normales: {horasNormales}");
                Console.WriteLine($"Horas extra: {horasExtras}");
                Console.WriteLine($"Sueldo bruto: S/{sueldoBruto:F2}");
                Console.WriteLine($"Descuento (5%): S/{descuento:F2}");
                Console.WriteLine($"Sueldo neto: S/{sueldoNeto:F2}");
            }

            // Mostrar el total general de la planilla
            Console.WriteLine($"\nTotal planilla: S/{totalPlanilla:F2}");
        }
    }
}
