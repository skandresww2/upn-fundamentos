namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Entrada ────────────────────────────────────────────────
            Console.Write("Monto en soles: ");
            double monto = double.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // Math.Ceiling(x) → redondea SIEMPRE hacia arriba.
            // Ejemplo: 7.1 → 8, 7.9 → 8, 7.0 → 7
            // "Ceiling" en inglés significa "techo" (te empuja al techo).
            double haciaArriba = Math.Ceiling(monto);

            // Math.Floor(x) → redondea SIEMPRE hacia abajo.
            // Ejemplo: 7.1 → 7, 7.9 → 7, 7.0 → 7
            // "Floor" en inglés significa "piso" (te empuja al piso).
            double haciaAbajo = Math.Floor(monto);

            // (int)x → "casting" a entero: descarta los decimales,
            // NO redondea, simplemente los corta.
            // Ejemplo: 7.9 → 7 (cuidado: con negativos -7.9 → -7,
            // mientras que Math.Floor(-7.9) → -8)
            int truncado = (int)monto;

            // Math.Round(x, n) → redondea matemáticamente a n decimales.
            // Si el siguiente dígito es ≥ 5 sube, si es < 5 baja.
            // Ejemplo: 7.856 con 2 decimales → 7.86
            //          7.854 con 2 decimales → 7.85
            double redondeado = Math.Round(monto, 2);

            // ── Salida ─────────────────────────────────────────────────
            Console.WriteLine($"Monto original:           {monto}");
            Console.WriteLine($"Ceiling (hacia arriba):   {haciaArriba}");
            Console.WriteLine($"Floor   (hacia abajo):    {haciaAbajo}");
            Console.WriteLine($"Truncado (casting int):   {truncado}");
            Console.WriteLine($"Redondeado (2 decimales): {redondeado}");
        }
    }
}
