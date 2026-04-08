namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Constantes ─────────────────────────────────────────────
            // 'const' significa que estos valores NO pueden cambiar
            // durante la ejecución. Es buena práctica para "números mágicos".
            const double CARGO_FIJO = 5.00;
            const double PRECIO_KWH = 0.55;
            const double TASA_IGV = 0.18;

            // ── Entrada ────────────────────────────────────────────────
            // Los kWh pueden tener decimales (ej: 150.5), por eso double.
            Console.Write("Consumo en kWh: ");
            double kwh = double.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // Subtotal = cargo fijo + (consumo × precio del kWh)
            double subtotal = CARGO_FIJO + (kwh * PRECIO_KWH);

            // IGV = 18% del subtotal
            double igv = subtotal * TASA_IGV;

            // Total = subtotal + IGV
            double total = subtotal + igv;

            // ── Salida ─────────────────────────────────────────────────
            Console.WriteLine($"Subtotal:      S/. {subtotal:F2}");
            Console.WriteLine($"IGV (18%):     S/. {igv:F2}");
            Console.WriteLine($"Total a pagar: S/. {total:F2}");
        }
    }
}
