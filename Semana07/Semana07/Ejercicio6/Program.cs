using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contadores de votos para cada candidato.
            // Todos empiezan en 0 porque al inicio nadie tiene votos.
            int votosAna = 0;
            int votosCarlos = 0;
            int votosLucia = 0;

            // Contador para votos inválidos o nulos.
            int nulos = 0;

            // Variable donde se guardará el voto ingresado por cada votante.
            int voto;

            // Se usa do-while porque el menú debe mostrarse al menos una vez.
            // Luego se repite mientras el usuario no ingrese 0.
            do
            {
                Console.WriteLine("\n=== SISTEMA DE VOTACIÓN ===");
                Console.WriteLine("1. Ana Torres");
                Console.WriteLine("2. Carlos Mendoza");
                Console.WriteLine("3. Lucía Paredes");
                Console.WriteLine("0. Cerrar votación");
                Console.Write("Ingrese su voto: ");

                // Se lee el voto ingresado por el usuario.
                voto = int.Parse(Console.ReadLine());

                // Si el voto es 1, se suma un voto para Ana.
                if (voto == 1)
                {
                    votosAna++;
                }
                // Si el voto es 2, se suma un voto para Carlos.
                else if (voto == 2)
                {
                    votosCarlos++;
                }
                // Si el voto es 3, se suma un voto para Lucía.
                else if (voto == 3)
                {
                    votosLucia++;
                }
                // Si el voto no es 0, 1, 2 ni 3, se considera voto nulo.
                // El 0 no se cuenta como nulo porque solo sirve para cerrar la votación.
                else if (voto != 0)
                {
                    nulos++;
                    Console.WriteLine("Voto nulo.");
                }

                // El ciclo se repite mientras el usuario no ingrese 0.
            } while (voto != 0);

            // Se calcula el total de votantes.
            // Se suman los votos válidos y los votos nulos.
            int total = votosAna + votosCarlos + votosLucia + nulos;

            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine($"Ana Torres: {votosAna}");
            Console.WriteLine($"Carlos Mendoza: {votosCarlos}");
            Console.WriteLine($"Lucía Paredes: {votosLucia}");
            Console.WriteLine($"Votos nulos: {nulos}");
            Console.WriteLine($"Total de votantes: {total}");

            // Se compara si Ana tiene más votos que Carlos y más votos que Lucía.
            if (votosAna > votosCarlos && votosAna > votosLucia)
            {
                Console.WriteLine("Ganadora: Ana Torres");
            }
            // Se compara si Carlos tiene más votos que Ana y más votos que Lucía.
            else if (votosCarlos > votosAna && votosCarlos > votosLucia)
            {
                Console.WriteLine("Ganador: Carlos Mendoza");
            }
            // Se compara si Lucía tiene más votos que Ana y más votos que Carlos.
            else if (votosLucia > votosAna && votosLucia > votosCarlos)
            {
                Console.WriteLine("Ganadora: Lucía Paredes");
            }
            else
            {
                // Si nadie tiene más votos que los otros dos, entonces hay empate.
                // Puede ser empate entre dos candidatos o entre los tres.
                Console.WriteLine("Resultado: EMPATE");
            }
        }
    }
}
