using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejemplo();
            //Ejemplo01();
            //Ejemplo02();
        }

        //Ejemplo
        static void Ejemplo()
        {
            // Acumulador: aquí se irá guardando la suma de los números impares.
            int suma = 0;

            // Contador: indica cuántos números impares ya se han sumado.
            // Empieza en 0 porque todavía no se ha sumado ningún número.
            int contador = 0;

            // Variable que representa el número impar actual.
            // Se inicia en 1 porque el primer número impar positivo es 1.
            int numero = 1;

            // Se usa do-while porque primero se ejecuta el bloque
            // y luego se evalúa si debe repetirse.
            do
            {
                // Sumamos el número impar actual al acumulador.
                suma = suma + numero;

                // Aumentamos el contador porque ya se sumó un número impar.
                contador = contador + 1;

                // Avanzamos al siguiente número impar.
                // Los impares aumentan de 2 en 2: 1, 3, 5, 7, 9...
                numero = numero + 2;

            } while (contador < 100 && numero < 500);
            // El ciclo continúa mientras:
            // 1. todavía se hayan sumado menos de 100 números impares;
            // 2. el siguiente número impar siga siendo menor que 500.

            Console.WriteLine("=== RESULTADO ===");
            Console.WriteLine($"Cantidad de impares sumados: {contador}");
            Console.WriteLine($"Siguiente impar después del ciclo: {numero}");
            Console.WriteLine($"La suma de los primeros 100 números impares menores a 500 es: {suma}");
        }

        //Ejemplo01
        static void Ejemplo01()
        {
            // Variable donde se guardará cada número ingresado por el usuario.
            int numero;

            // Variable para guardar el mayor número encontrado.
            // Se inicia con el menor valor posible de un entero.
            // Así, cualquier número válido ingresado podrá ser mayor que este valor inicial.
            int mayor = int.MinValue;

            // Contador para saber cuántos números válidos se ingresaron.
            // Es necesario porque el usuario podría ingresar 0 desde el inicio.
            int contador = 0;

            // Se usa do-while porque el programa debe pedir un número al menos una vez.
            do
            {
                // Solicitar número al usuario.
                Console.Write("Ingrese un número entero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                // El número 0 es el valor centinela.
                // Sirve para terminar el ciclo y no debe evaluarse como dato válido.
                if (numero != 0)
                {
                    // Si el número ingresado es mayor que el mayor actual,
                    // entonces actualizamos la variable mayor.
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }

                    // Como el número fue válido, aumentamos el contador.
                    contador = contador + 1;
                }

                // El ciclo se repite mientras el número ingresado sea diferente de 0.
            } while (numero != 0);

            Console.WriteLine("\n=== RESULTADO ===");

            // Si el contador es mayor que 0, significa que sí hubo datos válidos.
            if (contador > 0)
            {
                Console.WriteLine($"El mayor número ingresado es: {mayor}");
            }
            else
            {
                // Esto ocurre cuando el usuario ingresó 0 desde el primer intento.
                Console.WriteLine("No se ingresaron números válidos.");
            }
        }

        //Ejemplo02
        static void Ejemplo02()
        {
            // Variable donde se guardará cada número ingresado por el usuario.
            int numero;

            // Acumulador para sumar los números mayores a 500.
            double sumaMayor500 = 0;

            // Acumulador para sumar los números menores a 500.
            double sumaMenor500 = 0;

            // Contador para saber cuántos números mayores a 500 se ingresaron.
            int contadorMayor500 = 0;

            // Contador para saber cuántos números menores a 500 se ingresaron.
            int contadorMenor500 = 0;

            // Se usa do-while porque se necesita pedir al menos un número.
            // El ciclo se repetirá hasta que el usuario ingrese 0.
            do
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                // Si el número ingresado es mayor que 500,
                // se agrega al grupo de números mayores a 500.
                if (numero > 500)
                {
                    // Se acumula el número en la suma de mayores a 500.
                    sumaMayor500 += numero;

                    // Se incrementa el contador de números mayores a 500.
                    contadorMayor500++;
                }

                // Si el número ingresado es menor que 500 y además no es 0,
                // se agrega al grupo de números menores a 500.
                else if (numero < 500 && numero != 0)
                {
                    // Se acumula el número en la suma de menores a 500.
                    sumaMenor500 += numero;

                    // Se incrementa el contador de números menores a 500.
                    contadorMenor500++;
                }

                // Si el número es exactamente 500, no entra a ningún grupo.
                // Si el número es 0, no se cuenta porque sirve para terminar el ciclo.

            } while (numero != 0);

            Console.WriteLine("\n=== RESULTADOS ===");

            // Antes de calcular el promedio, verificamos que exista al menos
            // un número mayor a 500. Esto evita dividir entre cero.
            if (contadorMayor500 > 0)
            {
                // Fórmula del promedio:
                // promedio = suma de valores / cantidad de valores
                double promedioMayor500 = sumaMayor500 / contadorMayor500;

                // F2 muestra el resultado con 2 decimales.
                Console.WriteLine($"Promedio de números mayores a 500: {promedioMayor500:F2}");
            }
            else
            {
                // Este mensaje aparece si no se ingresó ningún número mayor a 500.
                Console.WriteLine("No se ingresaron números mayores a 500.");
            }

            // Verificamos que exista al menos un número menor a 500
            // antes de calcular su promedio.
            if (contadorMenor500 > 0)
            {
                // Se calcula el promedio de los números menores a 500.
                double promedioMenor500 = sumaMenor500 / contadorMenor500;

                // F2 muestra el resultado con 2 decimales.
                Console.WriteLine($"Promedio de números menores a 500: {promedioMenor500:F2}");
            }
            else
            {
                // Este mensaje aparece si no se ingresó ningún número menor a 500.
                Console.WriteLine("No se ingresaron números menores a 500.");
            }
        }

    }
}
