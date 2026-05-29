using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        // Función que cuenta cuántos dígitos tiene un número entero.
        // No se usan cadenas; solo operaciones matemáticas.
        static int ContarDigitos(int codigo)
        {
            // Contador de dígitos encontrados.
            int contador = 0;

            // Math.Abs convierte el número a positivo.
            // Esto evita problemas si el usuario ingresa un número negativo.
            codigo = Math.Abs(codigo);

            // El número 0 tiene 1 dígito.
            if (codigo == 0)
            {
                return 1;
            }

            // Mientras el código sea mayor que 0,
            // seguimos quitando dígitos.
            while (codigo > 0)
            {
                // Cada vuelta representa un dígito contado.
                contador = contador + 1;

                // Dividir entre 10 elimina el último dígito.
                // Ejemplo: 123456 / 10 = 12345
                codigo = codigo / 10;
            }

            // Retornamos la cantidad total de dígitos.
            return contador;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== VALIDACIÓN DE COMPROBANTE ===");

            // Entrada del código numérico.
            Console.Write("Ingrese código de comprobante: ");
            int codigo = int.Parse(Console.ReadLine());

            // Llamamos a la función para contar los dígitos.
            int digitos = ContarDigitos(codigo);

            Console.WriteLine($"Cantidad de dígitos: {digitos}");

            // Un código válido debe tener entre 6 y 8 dígitos.
            if (digitos >= 6 && digitos <= 8)
            {
                Console.WriteLine("Código válido");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }
        }
    }
}
