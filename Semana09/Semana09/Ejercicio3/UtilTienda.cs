using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    // Agrupa funciones relacionadas con cálculos de tienda.
    internal class UtilTienda
    {
        // Método estático con retorno.
        // Calcula el subtotal multiplicando la cantidad por el precio unitario.
        public static double CalcularSubtotal(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        // Método estático con retorno.
        // Calcula el descuento solo si el subtotal supera S/200.
        public static double CalcularDescuento(double subtotal)
        {
            if (subtotal > 200)
            {
                return subtotal * 0.10;
            }
            else
            {
                return 0;
            }
        }

        // Método estático con retorno.
        // Calcula el total final restando el descuento al subtotal.
        public static double CalcularTotal(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
