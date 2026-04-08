namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Entrada ────────────────────────────────────────────────
            // Pedimos las 4 coordenadas: dos puntos en el plano cartesiano.
            // Usamos double porque las coordenadas pueden tener decimales.
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // ── Proceso ────────────────────────────────────────────────
            // Paso 1: calcular las diferencias en cada eje (los "catetos"
            // del triángulo rectángulo que forman los dos puntos).
            double dx = x2 - x1;   // diferencia horizontal
            double dy = y2 - y1;   // diferencia vertical

            // Paso 2: aplicar Pitágoras → d = √(dx² + dy²)
            // Math.Pow(base, exponente) eleva un número a una potencia.
            // Math.Pow(dx, 2) es lo mismo que dx * dx, pero más legible
            // cuando el exponente es mayor (ej: Math.Pow(x, 5)).
            // Math.Sqrt(x) calcula la raíz cuadrada de x.
            double distancia = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

            // ── Salida ─────────────────────────────────────────────────
            // Formato :F2 → muestra el resultado con 2 decimales.
            Console.WriteLine($"Distancia entre los puntos: {distancia:F2}");
        }
    }
}
