using System;

class Program
{
    static double ObtenerTarifa(int opcion)
    {
        if (__________)
        {
            return 30;
        }
        else if (__________)
        {
            return 60;
        }
        else if (__________)
        {
            return 90;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== SERVICIO TÉCNICO ===");
        Console.WriteLine("1. Diagnóstico - S/30");
        Console.WriteLine("2. Mantenimiento - S/60");
        Console.WriteLine("3. Reparación - S/90");

        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        // Obtenemos la tarifa según la opción elegida.
        double tarifa = ObtenerTarifa(__________);

        // Si la tarifa es 0, la opción no existe.
        if (__________)
        {
            Console.WriteLine("Datos no válidos.");
            return; // Termina el programa y no pide cantidad.
        }

        // Solo si la opción fue válida, pedimos la cantidad.
        Console.Write("Cantidad de equipos: ");
        int cantidad = int.Parse(Console.ReadLine());

        // La cantidad debe ser mayor que 0.
        if (__________)
        {
            double total = __________ * __________;
            Console.WriteLine($"Total a pagar: S/{total:F2}");
        }
        else
        {
            Console.WriteLine("Datos no válidos.");
        }
    }
}