using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            Ejemplo02();
        }

        //Ejemplo01
        public static void Ejemplo01()
        {
            //Encontrar la suma de n números ingresados por el teclado.
            int n, numero;
            int suma = 0;

            Console.Write("Ingrese cantidad de números que desea sumar: ");
            n = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= n)
            {
                Console.Write($"Ingrese el número {contador}: ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero; //suma +=numero;
                contador++;
            }
            Console.WriteLine($"La suma de los {n} números es: {suma} ");
        }

        //Ejemplo02
        public static void Ejemplo02()
        {
            //Encontrar la suma de n números aleatorios
            int n, suma = 0;
            Random random = new Random();

            Console.Write("¿Cuántos números aleatorios desea sumar?: ");
            n = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= n)
            {
                int numero = random.Next(1, 101);
                Console.WriteLine($"Número aleatorio {contador}: {numero}");
                suma += numero;
                contador++;
            }
            Console.WriteLine($"La suma de los {n} números aleatorios es: {suma}");
        }
    }
}
