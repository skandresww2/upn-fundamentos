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
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());
            // Validar primero si la edad es correcta
            if (edad < 0)
            {
                Console.WriteLine("Error: la edad no puede ser negativa.");
            }
            else
            {                
                if (edad <= 5)
                {
                    Console.WriteLine("Resultado: viaja gratis, no requiere medio pasaje.");
                }
                else
                {                    
                    if (edad <= 17)
                    {
                        Console.Write("¿Presenta carné de estudiante? (S/N): ");
                        string carnet = Console.ReadLine().ToUpper();

                        // dentro del bloque de edad escolar, evaluamos una nueva condición
                        if (carnet == "S")
                        {
                            Console.WriteLine("Resultado: sí accede al medio pasaje escolar.");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: no accede al beneficio porque no presentó carné.");
                        }
                    }
                    else
                    {                        
                        Console.WriteLine("Resultado: no accede al medio pasaje escolar por edad.");
                    }
                }
            }
        }
    }
}
