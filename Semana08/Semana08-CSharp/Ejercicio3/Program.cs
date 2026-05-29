using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario la cantidad de horas trabajadas.
            Console.Write("Horas trabajadas: ");

            // Leemos el dato ingresado y lo convertimos a número decimal.
            double horas = double.Parse(Console.ReadLine());

            // Llamamos a la función CalcularBruto y guardamos el resultado.
            double bruto = CalcularBruto(horas);

            // Llamamos a la función CalcularDescuento usando el sueldo bruto.
            double descuento = CalcularDescuento(bruto);

            // Llamamos a la función CalcularNeto usando bruto y descuento.
            double neto = CalcularNeto(bruto, descuento);

            // Mostramos el sueldo bruto con 2 decimales.
            Console.WriteLine($"Sueldo bruto: S/{bruto:F2}");

            // Mostramos el descuento con 2 decimales.
            Console.WriteLine($"Descuento: S/{descuento:F2}");

            // Mostramos el sueldo neto con 2 decimales.
            Console.WriteLine($"Sueldo neto: S/{neto:F2}");
        }

        // Función que calcula el sueldo bruto.
        // Recibe como parámetro la cantidad de horas trabajadas.
        static double CalcularBruto(double horas)
        {
            // La empresa paga S/12.50 por cada hora trabajada.
            return horas * 12.50;
        }

        // Función que calcula el descuento.
        // Recibe como parámetro el sueldo bruto.
        static double CalcularDescuento(double bruto)
        {
            // El descuento es el 5% del sueldo bruto.
            // 5% en decimal se escribe como 0.05.
            return bruto * 0.05;
        }

        // Función que calcula el sueldo neto.
        // Recibe el sueldo bruto y el descuento.
        static double CalcularNeto(double bruto, double descuento)
        {
            // El sueldo neto se obtiene restando el descuento al sueldo bruto.
            return bruto - descuento;
        }
    }
}
