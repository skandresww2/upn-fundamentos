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
            // 1) Pedir el monto al usuario y convertirlo a número decimal
            Console.Write("Ingrese el monto de la compra (S/): ");
            double monto = double.Parse(Console.ReadLine());

            // 2) Inicializar el descuento en 0 (caso por defecto)
            double descuento = 0;

            // 3) Condicional simple: solo SI se cumple la condición se ejecuta el bloque
            if (monto >= 100)
            {
                descuento = monto * 0.10;  // 10% del monto
            }

            // 4) Calcular el total restando el descuento
            double total = monto - descuento;

            // 5) Mostrar el resultado con 2 decimales usando formato F2
            Console.WriteLine($"Descuento aplicado: S/ {descuento:F2}");
            Console.WriteLine($"Total a pagar:      S/ {total:F2}");

        }
    }
}
