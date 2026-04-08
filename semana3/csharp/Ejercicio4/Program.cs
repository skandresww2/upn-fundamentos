namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Entrada ────────────────────────────────────────────────
            // El radio puede tener decimales (ej: 2.5), por eso usamos double.
            Console.Write("Radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // Math.PI es la constante π ya definida en C# (≈ 3.14159265...).
            // NUNCA escribas 3.14 a mano: pierdes precisión decimal.
            // Math.Pow(radio, 2) eleva el radio al cuadrado (radio²).
            // Es equivalente a escribir: radio * radio
            double area = Math.PI * Math.Pow(radio, 2);

            // Perímetro (también llamado circunferencia) = 2 × π × r
            double perimetro = 2 * Math.PI * radio;

            // ── Salida ─────────────────────────────────────────────────
            // Formato :F4 → muestra 4 decimales (porque π es irracional
            // y queremos buena precisión en el resultado).
            Console.WriteLine($"Área: {area:F4}");
            Console.WriteLine($"Perímetro: {perimetro:F4}");
        }
    }
}
