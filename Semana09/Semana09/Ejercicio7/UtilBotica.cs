using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class UtilBotica
    {
        // Método que verifica si un medicamento está vencido.
        // Retorna true si el año de vencimiento es menor al año actual.
        public static bool EstaVencido(int anioVencimiento, int anioActual)
        {
            return anioVencimiento < anioActual;
        }

        // Método que muestra los datos básicos del medicamento.
        // Es void porque solo imprime información, no devuelve un valor.
        public static void MostrarDatos(string nombre, string marca, int anioVencimiento)
        {
            Console.WriteLine("\n=== DATOS DEL MEDICAMENTO ===");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Año de vencimiento: {anioVencimiento}");
        }

        // Método que muestra el estado del medicamento.
        // Recibe true o false según la evaluación realizada previamente.
        public static void MostrarEstado(bool vencido)
        {
            if (vencido)
            {
                Console.WriteLine("Estado: Medicamento vencido.");
            }
            else
            {
                Console.WriteLine("Estado: Medicamento vigente.");
            }
        }
    }
}
