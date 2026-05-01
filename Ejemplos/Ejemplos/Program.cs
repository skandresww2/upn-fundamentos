using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJ4S5();
            //EJ5S5();
            //EJ1S6();
            EJ2S6();
        }

        public static void EJ4S5()
        {
            // === ENTRADA INICIAL ===
            // Solicita al usuario cuántos empleados se procesarán
            Console.Write("Ingrese la cantidad de empleados: ");
            int n = int.Parse(Console.ReadLine()); // Convierte string -> int

            // Variable acumuladora: suma los sueldos netos de TODOS los empleados
            // Se declara FUERA del for para que conserve su valor en cada iteración
            double totalPlanilla = 0;

            // === BUCLE PRINCIPAL: se repite 'n' veces, una por cada empleado ===
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmpleado {i}");

                // --- Datos del empleado ---
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Horas trabajadas: ");
                int horasTrabajadas = int.Parse(Console.ReadLine());

                // --- Variables locales del cálculo (se reinician en cada empleado) ---
                int horasExtras;     // Horas que pasan de 160
                int horasNormales;   // Horas dentro del rango normal (máx 160)
                double sueldoBruto;  // Pago antes del descuento

                // === LÓGICA DE CÁLCULO ===
                if (horasTrabajadas <= 160)
                {
                    // CASO 1: trabajó 160h o menos -> no hay horas extra
                    horasNormales = horasTrabajadas;
                    horasExtras = 0;
                    sueldoBruto = horasTrabajadas * 12.50; // Tarifa normal: S/12.50
                }
                else
                {
                    // CASO 2: trabajó más de 160h -> separa normales y extras
                    horasNormales = 160;
                    horasExtras = horasTrabajadas - 160;
                    // 160h * 12.50 (normal) + extras * 25.00 (tarifa doble)
                    sueldoBruto = 160 * 12.50 + horasExtras * 25.00;
                }

                // === DESCUENTO Y NETO ===
                double descuento = sueldoBruto * 0.05;          // 5% del bruto
                double sueldoNeto = sueldoBruto - descuento;    // Lo que recibe

                // Suma este sueldo al acumulador global
                totalPlanilla += sueldoNeto;

                // === SALIDA: boleta del empleado ===
                // {variable:F2} -> formatea el número con 2 decimales
                Console.WriteLine("----- Boleta del empleado -----");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Horas normales: {horasNormales}");
                Console.WriteLine($"Horas extra: {horasExtras}");
                Console.WriteLine($"Sueldo bruto: S/{sueldoBruto:F2}");
                Console.WriteLine($"Descuento (5%): S/{descuento:F2}");
                Console.WriteLine($"Sueldo neto: S/{sueldoNeto:F2}");
            }

            // === SALIDA FINAL: total acumulado de toda la planilla ===
            Console.WriteLine($"\nTotal planilla: S/{totalPlanilla:F2}");
        }

        public static void EJ5S5()
        {
            // === ENTRADA INICIAL ===
            Console.Write("Ingrese la cantidad de días: ");
            int n = int.Parse(Console.ReadLine()); // N° de días a procesar

            // === VARIABLES ACUMULADORAS Y DE CONTROL ===
            double total = 0;                  // Suma de todas las ventas
            double mayor = 0;                  // Guarda la venta más alta encontrada
            double menor = double.MaxValue;    // Inicia con el MÁXIMO valor posible
                                               // Truco: así CUALQUIER venta real será menor
                                               // y se actualizará en la 1ra comparación
            int diaMayor = 0;                  // Día en que ocurrió la mayor venta
            int diaMenor = 0;                  // Día en que ocurrió la menor venta

            // === CONTADORES POR CATEGORÍA ===
            int excelente = 0;  // ventas >= 500
            int bueno = 0;      // 200 <= venta < 500
            int regular = 0;    // 50  <= venta < 200
            int malo = 0;       // venta < 50

            // === BUCLE PRINCIPAL: una iteración por día ===
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese la venta del día {i}: ");
                double venta = double.Parse(Console.ReadLine()); // double -> permite decimales

                // 1) Acumular la venta en el total
                total += venta;

                // 2) ¿Es la MAYOR venta hasta ahora? -> actualiza máximo y guarda el día
                if (venta > mayor)
                {
                    mayor = venta;
                    diaMayor = i;
                }

                // 3) ¿Es la MENOR venta hasta ahora? -> actualiza mínimo y guarda el día
                if (venta < menor)
                {
                    menor = venta;
                    diaMenor = i;
                }

                // 4) CLASIFICACIÓN con if-else if encadenado
                // Importante: el orden va de MAYOR a MENOR rango.
                // Como cada else if solo se evalúa si el anterior fue falso,
                // no hace falta escribir "venta >= 200 && venta < 500": ya está implícito.
                if (venta >= 500)
                {
                    excelente++;   // equivalente a: excelente = excelente + 1
                }
                else if (venta >= 200)
                {
                    bueno++;
                }
                else if (venta >= 50)
                {
                    regular++;
                }
                else
                {
                    malo++;        // cualquier valor < 50 (incluye 0 o negativos)
                }
            }

            // === CÁLCULO FINAL ===
            double promedio = total / n; // promedio = suma / cantidad

            // === SALIDA: resumen general ===
            Console.WriteLine("\n----- Resumen de ventas -----");
            Console.WriteLine($"Total de ventas: S/{total:F2}");        // :F2 -> 2 decimales
            Console.WriteLine($"Promedio diario: S/{promedio:F2}");
            Console.WriteLine($"Mayor venta: Día {diaMayor} con S/{mayor:F2}");
            Console.WriteLine($"Menor venta: Día {diaMenor} con S/{menor:F2}");
            Console.WriteLine($"Días Excelente: {excelente}");
            Console.WriteLine($"Días Bueno: {bueno}");
            Console.WriteLine($"Días Regular: {regular}");
            Console.WriteLine($"Días Malo: {malo}");
        }

        public static void EJ1S6()
        {
            //Encontrar la suma de n números ingresados por el teclado.
            // === INICIALIZACIÓN ===
            int suma = 0;       // ACUMULADOR: guardará la suma total
            int contador = 1;   // CONTADOR: lleva la cuenta de las vueltas

            // === LEER cuántos números se sumarán ===
            Console.Write("¿Cuántos números desea sumar? ");
            int n = int.Parse(Console.ReadLine());

            // === BUCLE WHILE: se repite mientras contador <= n ===
            while (contador <= n)
            {
                // Pedir un número al usuario
                Console.Write($"Ingrese el número {contador}: ");
                int numero = int.Parse(Console.ReadLine());

                // Acumular: sumar el número leído al total
                suma = suma + numero;   // equivale a: suma += numero;

                // ACTUALIZAR el contador → sin esto = bucle infinito ⚠️
                contador = contador + 1; // equivale a: contador++;
            }

            // === MOSTRAR resultado ===
            Console.WriteLine($"\nLa suma total es: {suma}");
        }

        public static void EJ2S6()
        {
            //Encontrar la suma de n números aleatorios.
            // === INICIALIZACIÓN ===
            int suma = 0;       // Acumulador
            int contador = 1;   // Contador de vueltas

            // Random: clase de C# para generar números aleatorios
            // Se crea UNA sola vez fuera del bucle (buena práctica)
            Random rnd = new Random();

            // === LEER cuántos números aleatorios se generarán ===
            Console.Write("¿Cuántos números aleatorios desea sumar? ");
            int n = int.Parse(Console.ReadLine());

            // === BUCLE WHILE ===
            while (contador <= n)
            {
                // Generar un número aleatorio entre 1 y 100
                // Next(1, 101) → el límite superior es EXCLUSIVO, por eso 101
                int numero = rnd.Next(1, 101);

                // Mostrar la vuelta actual y el número generado
                Console.WriteLine($"Número {contador}: {numero}");

                // Acumular el número en la suma
                suma += numero;        // equivale a: suma = suma + numero;

                // Actualizar el contador (¡clave!)
                contador++;            // equivale a: contador = contador + 1;
            }

            // === MOSTRAR resultado final ===
            Console.WriteLine($"\nLa suma total es: {suma}");
        }
    }
}
