using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            Ejemplo02();
        }

        public static void Ejemplo01()
        {
            // Declaración de variables: n (cantidad), suma (acumulador inicializado en 0), numero (valor leído)
            int n, suma = 0, numero;

            // Solicita al usuario la cantidad de números a sumar
            Console.Write("Ingrese cantidad de números que desea sumar: ");
            n = int.Parse(Console.ReadLine());   // Convierte el texto leído a entero

            int contador = 1;   // Inicializa el contador del bucle

            // Repite mientras contador no supere n (se ejecuta n veces)
            while (contador <= n)
            {
                // Pide el número actual mostrando el índice del contador
                Console.Write($"Ingrese el número {contador}: ");
                numero = int.Parse(Console.ReadLine());   // Lee y convierte el número

                suma += numero;   // Acumula: suma = suma + numero
                contador++;       // Incrementa el contador (evita bucle infinito)
            }

            // Muestra el resultado final con interpolación de cadenas
            Console.WriteLine($"La suma de los {n} números es: {suma} ");
        }

        public static void Ejemplo02()
        {
            int n, suma = 0;
            Random random = new Random();   // instancia para generar aleatorios

            Console.Write("Ingrese cuántos números aleatorios desea sumar: ");
            n = int.Parse(Console.ReadLine());   // cantidad de números a generar

            int contador = 1;
            while (contador <= n)   // repite n veces
            {
                int numero = random.Next(1, 101);   // aleatorio entre 1 y 100 (101 excluido)
                Console.WriteLine("Número aleatorio {0}: {1}", contador, numero);
                suma += numero;     // acumula
                contador++;         // avanza
            }
            Console.WriteLine("La suma de los {0} números aleatorios es {1}", n, suma);
        }
    }
}
