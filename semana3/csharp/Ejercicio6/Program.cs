namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Entrada ────────────────────────────────────────────────
            // Las cantidades son cantidades enteras (no existen "1.5 baños"),
            // por eso usamos int.
            Console.Write("Cantidad de habitaciones: ");
            int habitaciones = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de baños: ");
            int banos = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de patios: ");
            int patios = int.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // Multiplicamos cada cantidad por su precio unitario y sumamos.
            // Usamos double en el total para poder formatearlo a 2 decimales
            // (la inmobiliaria muestra "S/. 125.00", no "S/. 125").
            double total = (habitaciones * 30) + (banos * 10) + (patios * 15);

            // ── Salida ─────────────────────────────────────────────────
            Console.WriteLine($"Total a pagar: S/. {total:F2}");
        }
    }
}
