namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Precio unitario (S/.): ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());
            
            double subtotal = precio * cantidad; // antes del IGV
            double igv = subtotal * 0.18; // 18% del subtotal
            double total = subtotal + igv; // precio final
            
            Console.WriteLine("Subtotal (sin IGV): S/. " + subtotal);
            Console.WriteLine("IGV (18%): S/. " + igv);
            Console.WriteLine("Total a pagar: S/. " + total);
            // El formato :F2 (Fixed-point con 2 decimales) fuerza que el número
            // se muestre siempre con 2 cifras después del punto decimal.
            // Ejemplos: 118 → "118.00" | 233.0567 → "233.06" | 18.7 → "18.70"
        }
    }
}
