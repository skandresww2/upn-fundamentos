using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        // Función con retorno.
        // Calcula la venta de un turno multiplicando cantidad por precio.
        static double CalcularVentaTurno(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== VENTA DE PRODUCTOS POR TURNOS ===");

            // Acumulador del total vendido durante todo el día.
            double totalDia = 0;

            // Se registran exactamente 3 turnos.
            for (int turno = 1; turno <= 3; turno++)
            {
                Console.WriteLine($"\nTurno {turno}");

                int cantidad;

                // Validar cantidad.
                // Se repite mientras la cantidad ingresada sea menor o igual a 0.
                do
                {
                    Console.Write("Cantidad de productos vendidos: ");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad <= 0)
                    {
                        Console.WriteLine("Error: la cantidad debe ser mayor que 0.");
                    }

                } while (cantidad <= 0);

                double precio;

                // Validar precio.
                // Se repite mientras el precio ingresado sea menor o igual a 0.
                do
                {
                    Console.Write("Precio unitario: S/");
                    precio = double.Parse(Console.ReadLine());

                    if (precio <= 0)
                    {
                        Console.WriteLine("Error: el precio debe ser mayor que 0.");
                    }

                } while (precio <= 0);

                // Calculamos la venta del turno usando la función.
                double venta = CalcularVentaTurno(cantidad, precio);

                // Acumulamos la venta del turno en el total del día.
                totalDia = totalDia + venta;

                Console.WriteLine($"Venta del turno {turno}: S/{venta:F2}");
            }

            // Al finalizar los 3 turnos, mostramos el total acumulado.
            Console.WriteLine($"\nTotal vendido del día: S/{totalDia:F2}");
        }
    }
}
