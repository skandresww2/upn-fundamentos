namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Entrada ────────────────────────────────────────────────
            // La temperatura puede tener decimales (ej: 36.5 °C),
            // por eso usamos double.
            Console.Write("Temperatura en Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // ¡ATENCIÓN! En C# escribir 9/5 da como resultado 1 (entero),
            // porque ambos números son enteros. Para obtener 1.8 hay que
            // forzar al menos uno a decimal: usamos 9.0/5 (o 9/5.0).
            // Si escribieras solo 9/5, todas las temperaturas saldrían mal.
            double fahrenheit = celsius * (9.0 / 5) + 32;

            // Kelvin es más simple: solo se suma 273.15 al valor en Celsius.
            // 273.15 ya es decimal, así que no hay riesgo de pérdida.
            double kelvin = celsius + 273.15;

            // ── Salida ─────────────────────────────────────────────────
            // :F2 → 2 decimales para presentación limpia.
            Console.WriteLine($"{celsius:F2} °C equivalen a:");
            Console.WriteLine($"  {fahrenheit:F2} °F");
            Console.WriteLine($"  {kelvin:F2} K");
        }
    }
}
