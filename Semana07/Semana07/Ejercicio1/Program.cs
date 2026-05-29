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
            // Acumulador: guarda la suma de todos los platos elegidos.
            double subtotal = 0;

            // Contador: guarda cuántos platos válidos se pidieron.
            int platos = 0;

            // Se declara fuera del do-while porque se usará también en la condición final.
            int opcion;

            do
            {
                // El menú se muestra al menos una vez.
                Console.WriteLine("\n=== MENÚ DEL RESTAURANTE ===");
                Console.WriteLine("1. Lomo saltado - S/25.00");
                Console.WriteLine("2. Ceviche - S/30.00");
                Console.WriteLine("3. Ají de gallina - S/20.00");
                Console.WriteLine("4. Pollo a la brasa - S/35.00");
                Console.WriteLine("0. Pedir la cuenta");
                Console.Write("Elija una opción: ");

                opcion = int.Parse(Console.ReadLine());

                // Decisión múltiple: se evalúa qué opción eligió el cliente.
                if (opcion == 1)
                {
                    subtotal = subtotal + 25;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Lomo saltado");
                }
                else if (opcion == 2)
                {
                    subtotal = subtotal + 30;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Ceviche");
                }
                else if (opcion == 3)
                {
                    subtotal = subtotal + 20;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Ají de gallina");
                }
                else if (opcion == 4)
                {
                    subtotal = subtotal + 35;
                    platos = platos + 1;
                    Console.WriteLine("Agregado: Pollo a la brasa");
                }
                else if (opcion != 0)
                {
                    // Si no eligió 0 y tampoco una opción válida, se muestra error.
                    Console.WriteLine("Opción no válida.");
                }

                // Si opcion es diferente de 0, el menú se vuelve a mostrar.
            } while (opcion != 0);

            // Cálculo de la cuenta final.
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            Console.WriteLine("\n=== CUENTA ===");
            Console.WriteLine($"Platos pedidos: {platos}");
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/{igv:F2}");
            Console.WriteLine($"TOTAL: S/{total:F2}");
        }
    }
}
