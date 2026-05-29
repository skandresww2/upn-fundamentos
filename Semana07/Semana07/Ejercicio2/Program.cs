using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contraseña correcta que el usuario debe ingresar.
            string claveCorrecta = "UPN2026";

            // Número máximo de intentos permitidos.
            int maxIntentos = 3;

            // Contador de intentos realizados.
            int intentos = 0;

            // Bandera lógica: indica si el usuario logró acceder.
            bool acceso = false;

            // Se declara fuera del do-while para poder usarla dentro del ciclo.
            string clave;

            do
            {
                // Cada vez que entra al ciclo, se cuenta un nuevo intento.
                intentos++;

                Console.Write($"Intento {intentos}/{maxIntentos} - Clave: ");
                clave = Console.ReadLine();

                // Si la clave ingresada coincide con la correcta, se activa el acceso.
                if (clave == claveCorrecta)
                {
                    acceso = true;
                }
                else
                {
                    // Calcula cuántos intentos quedan.
                    int restantes = maxIntentos - intentos;

                    // Solo muestra el mensaje si todavía quedan intentos disponibles.
                    if (restantes > 0)
                    {
                        Console.WriteLine($"Clave incorrecta. Quedan {restantes} intentos.");
                    }
                }

                // Repite mientras NO haya acceso y aún queden intentos.
            } while (!acceso && intentos < maxIntentos);

            // Al salir del ciclo, se verifica si salió porque acertó o porque agotó intentos.
            if (acceso)
            {
                Console.WriteLine("Acceso concedido. Bienvenido.");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada. Contacte al administrador.");
            }
        }
    }
}
