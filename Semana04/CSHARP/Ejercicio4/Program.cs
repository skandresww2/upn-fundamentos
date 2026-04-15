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
            // Pedimos los datos al usuario
            Console.Write("Categoría (A/B/C): ");
            string cat = Console.ReadLine().ToUpper();

            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Años de servicio: ");
            int anios = int.Parse(Console.ReadLine());

            double tarifa = 0;

            // Según la categoría, asignamos la tarifa por hora
            if (cat == "A") tarifa = 33.50;
            else if (cat == "B") tarifa = 29.80;
            else if (cat == "C") tarifa = 25.70;
            else
            {
                Console.WriteLine("Categoría inválida");
                return;
            }

            double bono = 0;

            // Según los años de servicio, asignamos la bonificación
            if (anios <= 3) bono = 0.00;
            else if (anios >= 4 && anios <= 10) bono = 0.10;
            else if (anios >= 11 && anios <= 17) bono = 0.20;
            else bono = 0.30;

            // Calculamos el sueldo final
            double sueldoFinal = tarifa * horas * (1 + bono);

            Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");
        }
    }
}
