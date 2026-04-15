using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos los datos al usuario
            Console.Write("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            // Fórmula del IMC: peso / estatura²
            // Math.Pow(estatura, 2) significa estatura elevada al cuadrado
            double imc = peso / Math.Pow(estatura, 2);

            // Redondeamos el resultado a 2 decimales
            double imcRed = Math.Round(imc, 2);

            // Mostramos el IMC
            Console.WriteLine($"IMC: {imcRed}");

            // Clasificamos según los rangos dados
            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }
        }
    }
}
