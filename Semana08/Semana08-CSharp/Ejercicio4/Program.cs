using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        // Variable estática porque es una regla fija del programa
        static double tipoCambio = 3.75;

        // Variable estática para la comisión del 2 %
        static double porcentajeComision = 0.02;
        static void Main(string[] args)
        {
            Console.WriteLine("=== CASA DE CAMBIO ===");

            Console.Write("Ingrese monto en soles: S/");
            double soles = double.Parse(Console.ReadLine());

            // Llamamos a la función que calcula la comisión
            double comision = CalcularComision(soles);

            // Llamamos a la función que calcula los soles disponibles después de descontar comisión
            double solesNetos = CalcularSolesNetos(soles, comision);

            // Llamamos a la función que convierte soles netos a dólares
            double dolares = ConvertirADolares(solesNetos);

            // Llamamos a un método void para mostrar el comprobante
            MostrarComprobante(soles, comision, solesNetos, dolares);
        }

        // Función con retorno: calcula el 2 % del monto ingresado
        static double CalcularComision(double soles)
        {
            double comision = soles * porcentajeComision;
            return comision;
        }

        // Función con retorno: resta la comisión al monto inicial
        static double CalcularSolesNetos(double soles, double comision)
        {
            double solesNetos = soles - comision;
            return solesNetos;
        }

        // Función con retorno: convierte los soles netos a dólares
        static double ConvertirADolares(double solesNetos)
        {
            double dolares = solesNetos / tipoCambio;
            return dolares;
        }

        // Método void: no retorna valor, solo muestra el comprobante
        static void MostrarComprobante(double soles, double comision, double solesNetos, double dolares)
        {
            Console.WriteLine("\n=== COMPROBANTE ===");
            Console.WriteLine($"Monto ingresado: S/{soles:F2}");
            Console.WriteLine($"Comisión (2%): S/{comision:F2}");
            Console.WriteLine($"Soles netos a cambiar: S/{solesNetos:F2}");
            Console.WriteLine($"Dólares recibidos: ${dolares:F2}");
        }
    }
}
