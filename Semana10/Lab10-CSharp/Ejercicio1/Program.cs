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
            // Pedimos la cantidad de obreros que se van a registrar.
            Console.Write("Cantidad de obreros: ");
            int n = int.Parse(Console.ReadLine());

            // Acumulador: guardará la suma de todos los salarios.
            double totalPlanilla = 0;

            // Sirve para registrar a cada obrero.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nObrero {i}");

                // Pedimos el valor por hora del obrero actual.
                Console.Write("Valor por hora: S/");
                double vh = double.Parse(Console.ReadLine());

                // Pedimos las horas trabajadas en el mes.
                Console.Write("Horas trabajadas: ");
                int hmt = int.Parse(Console.ReadLine());

                // Llamamos a la función para calcular el salario del obrero.
                double salario = CalcularSalario(vh, hmt);

                // Sumamos el salario del obrero al total de la planilla.
                totalPlanilla += salario;

                // Mostramos el salario individual con dos decimales.
                Console.WriteLine($"Salario: S/{salario:F2}");
            }

            // Al finalizar el for, mostramos la suma total de todos los salarios.
            Console.WriteLine($"\nTotal de planilla: S/{totalPlanilla:F2}");
        }

        static double CalcularSalario(double valorHora, int horas)
        {
            // Si el obrero trabajó 192 horas o menos,
            if (horas <= 192)
            {
                return valorHora * horas;
            }

            // Calculamos cuántas horas exceden las 192 permitidas como normales.
            int horasExtra = horas - 192;

            // Calculamos el pago de las primeras 192 horas.
            double pagoNormal = valorHora * 192;

            // Calculamos el pago de las horas extra.
            double pagoExtra = horasExtra * valorHora * 1.50;

            // El salario total es la suma del pago normal más el pago extra.
            return pagoNormal + pagoExtra;
        }
    }
}
