using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE MEDICAMENTO EN BOTICA ===");

            // Entrada de datos del medicamento.
            Console.Write("Ingrese nombre del medicamento: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese marca del medicamento: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese año de vencimiento: ");
            int anioVencimiento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año actual: ");
            int anioActual = int.Parse(Console.ReadLine());

            // Llamamos al método de la biblioteca para verificar si está vencido.
            bool vencido = UtilBotica.EstaVencido(anioVencimiento, anioActual);

            // Mostramos los datos usando un método void de la biblioteca.
            UtilBotica.MostrarDatos(nombre, marca, anioVencimiento);

            // Mostramos el estado final del medicamento.
            UtilBotica.MostrarEstado(vencido);
        }
    }
}
