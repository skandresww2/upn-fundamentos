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
            Random rand = new Random();
            int secreto = rand.Next(1, 51);   // genera número entre 1 y 50 (51 es exclusivo)
            int intentos = 0;
            int maxIntentos = 7;
            bool adivino = false;             // bandera: ¿ya acertó?

            Console.WriteLine("Adivina el número (1-50). Tienes 7 intentos.");

            // DOBLE CONDICIÓN: sigue mientras NO haya adivinado Y le queden intentos
            // Si cualquiera de las dos falla, sale del bucle
            while (!adivino && intentos < maxIntentos)
            {
                intentos++;   // se cuenta antes de leer (intento 1, 2, 3...)
                Console.Write($"Intento {intentos}: ");
                int intento = int.Parse(Console.ReadLine());

                if (intento == secreto)
                {
                    adivino = true;   // bandera en true → la condición !adivino falla y sale del while
                }
                else if (intento < secreto)   // el intento fue muy bajo
                {
                    Console.WriteLine("El número es MAYOR.");
                }
                else                          // intento > secreto
                {
                    Console.WriteLine("El número es MENOR.");
                }
            }

            // Después del while: ¿salió por victoria o por agotar intentos?
            if (adivino)
                Console.WriteLine($"¡Ganaste en {intentos} intentos!");
            else
                Console.WriteLine($"Perdiste. El número era {secreto}.");
        }
    }
}
