using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random permite generar números aleatorios.
            // En este caso se usará para que la computadora elija piedra, papel o tijera.
            Random rand = new Random();

            // Puntaje del jugador.
            int puntajeJ = 0;

            // Puntaje de la computadora.
            int puntajePC = 0;

            // Contador de rondas jugadas.
            int ronda = 0;

            // Se usa do-while porque el juego debe ejecutarse al menos una vez.
            do
            {
                // Aumenta el número de ronda en 1.
                ronda++;

                Console.WriteLine($"\n--- Ronda {ronda} ---");
                Console.Write("1=Piedra, 2=Papel, 3=Tijera: ");

                // Se lee la opción ingresada por el usuario.
                // 1 representa Piedra, 2 representa Papel y 3 representa Tijera.
                int jugador = int.Parse(Console.ReadLine());

                // rand.Next(1, 4) genera un número aleatorio desde 1 hasta 3.
                // El 4 no se incluye.
                int pc = rand.Next(1, 4);

                Console.WriteLine($"La PC eligió: {pc}");

                // Validamos que el usuario haya ingresado 1, 2 o 3.
                // Si jugador es menor que 1 o mayor que 3, la opción no es válida.
                if (jugador < 1 || jugador > 3)
                {
                    Console.WriteLine("Opción no válida. La ronda no cuenta.");

                    // Como la ronda no debe contarse, se resta 1 al contador de rondas.
                    ronda--;
                }
                else if (jugador == pc)
                {
                    // Si ambos eligieron lo mismo, no gana nadie y no se suma puntaje.
                    Console.WriteLine("Empate.");
                }
                else if ((jugador == 1 && pc == 3) ||
                         (jugador == 2 && pc == 1) ||
                         (jugador == 3 && pc == 2))
                {
                    // Esta condición contiene todas las formas en que gana el jugador:
                    // 1) Piedra vence a Tijera
                    // 2) Papel vence a Piedra
                    // 3) Tijera vence a Papel
                    // El operador || significa "o".
                    // Basta con que una de las tres condiciones sea verdadera.

                    Console.WriteLine("Ganaste esta ronda.");

                    // Se suma 1 punto al jugador.
                    puntajeJ++;
                }
                else
                {
                    // Si no hubo empate y el jugador no ganó,
                    // entonces necesariamente gana la computadora.
                    Console.WriteLine("Ganó la PC.");

                    // Se suma 1 punto a la computadora.
                    puntajePC++;
                }

                // Se muestra el marcador actualizado después de cada ronda.
                Console.WriteLine($"Marcador: Tú {puntajeJ} - PC {puntajePC}");

                // El ciclo se repite mientras ambos tengan menos de 3 puntos.
                // Cuando uno de los dos llegue a 3, el juego termina.
            } while (puntajeJ < 3 && puntajePC < 3);

            // Si el jugador llegó a 3 puntos, ganó el juego.
            if (puntajeJ == 3)
            {
                Console.WriteLine("GANASTE EL JUEGO.");
            }
            else
            {
                // Si el jugador no llegó a 3, entonces la computadora fue quien llegó primero.
                Console.WriteLine("GANÓ LA COMPUTADORA.");
            }
        }
    }
}
