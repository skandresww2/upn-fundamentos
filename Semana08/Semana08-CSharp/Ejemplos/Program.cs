using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        // Variable estática del Ejemplo 2.
        // Representa una regla general del laboratorio.
        static int aforoMaximo = 30;

        // Variable estática del Ejemplo 3.
        // Representa la distancia límite para considerar un envío cercano.
        static double limiteCercano = 5;

        static void Main(string[] args)
        {
            // El programa siempre inicia aquí.

            Ejemplo01_Propina();
            //Ejemplo02_Aforo();
            //Ejemplo03_Delivery();
        }

        // ======================================================
        // EJEMPLO 1: Cálculo de propina en restaurante
        // Tema: funciones con retorno y parámetros
        // ======================================================

        static void Ejemplo01_Propina()
        {
            Console.WriteLine("=== EJEMPLO 1: CÁLCULO DE PROPINA ===");

            Console.Write("Ingrese el consumo del cliente: S/");
            double consumo = double.Parse(Console.ReadLine());

            // Llamamos a una función que calcula y retorna la propina.
            double propina = CalcularPropina(consumo);

            // Llamamos a una función que calcula y retorna el total a pagar.
            double total = CalcularTotalPropina(consumo, propina);

            Console.WriteLine("\n=== RESUMEN ===");
            Console.WriteLine($"Consumo: S/{consumo:F2}");
            Console.WriteLine($"Propina sugerida (10%): S/{propina:F2}");
            Console.WriteLine($"Total a pagar: S/{total:F2}");
        }

        static double CalcularPropina(double consumo)
        {
            // Retorna el 10% del consumo.
            return consumo * 0.10;
        }

        static double CalcularTotalPropina(double consumo, double propina)
        {
            // Retorna la suma del consumo más la propina.
            return consumo + propina;
        }

        // ======================================================
        // EJEMPLO 2: Control de aforo en laboratorio
        // Tema: función con retorno bool, variable estática y método void
        // ======================================================

        static void Ejemplo02_Aforo()
        {
            Console.WriteLine("=== EJEMPLO 2: CONTROL DE AFORO ===");

            Console.Write("Ingrese cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            // Esta función devuelve true si el aforo es válido, o false si se excede.
            bool permitido = ValidarAforo(cantidadEstudiantes);

            // Este método no retorna valor; solo muestra el resultado.
            MostrarResultadoAforo(cantidadEstudiantes, permitido);
        }

        static bool ValidarAforo(int cantidadEstudiantes)
        {
            // Compara la cantidad ingresada con la variable estática aforoMaximo.|||
            return cantidadEstudiantes <= aforoMaximo;
        }

        static void MostrarResultadoAforo(int cantidadEstudiantes, bool permitido)
        {
            Console.WriteLine("\n=== RESULTADO DE AFORO ===");
            Console.WriteLine($"Estudiantes registrados: {cantidadEstudiantes}");
            Console.WriteLine($"Aforo máximo permitido: {aforoMaximo}");

            if (permitido)
            {
                Console.WriteLine("Ingreso permitido.");
            }
            else
            {
                Console.WriteLine("Aforo excedido. No se permite el ingreso.");
            }
        }

        // ======================================================
        // EJEMPLO 3: Cálculo de delivery según distancia
        // Tema: variable estática, función con retorno y condicional
        // ======================================================

        static void Ejemplo03_Delivery()
        {
            Console.WriteLine("=== EJEMPLO 3: CÁLCULO DE DELIVERY ===");

            Console.Write("Ingrese distancia del pedido en km: ");
            double distancia = double.Parse(Console.ReadLine());

            // La función calcula el costo según la distancia ingresada.
            double costoDelivery = CalcularDelivery(distancia);

            // Este método muestra el resumen final.
            MostrarResumenDelivery(distancia, costoDelivery);
        }

        static double CalcularDelivery(double distancia)
        {
            // Si la distancia es menor o igual al límite cercano, cobra S/6.
            if (distancia <= limiteCercano)
            {
                return 6.00;
            }
            else
            {
                // Si supera el límite cercano, cobra S/10.
                return 10.00;
            }
        }

        static void MostrarResumenDelivery(double distancia, double costoDelivery)
        {
            Console.WriteLine("\n=== RESUMEN DE DELIVERY ===");
            Console.WriteLine($"Distancia: {distancia:F2} km");
            Console.WriteLine($"Costo de delivery: S/{costoDelivery:F2}");
        }
    }
}

