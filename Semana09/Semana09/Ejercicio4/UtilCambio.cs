using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class UtilCambio
    {
        // Constante de tipo de cambio.
        // Se usa const porque este valor representa una regla fija del ejercicio.
        public const double TIPO_CAMBIO = 3.75;

        // Constante de comisión: 2% se representa como 0.02.
        public const double COMISION = 0.02;

        // Método con retorno.
        // Recibe el monto en soles y calcula la comisión del 2%.
        public static double CalcularComision(double soles)
        {
            return soles * COMISION;
        }

        // Método con retorno.
        // Recibe el monto en soles y la comisión.
        // Primero calcula los soles netos y luego los convierte a dólares.
        public static double ConvertirADolares(double soles, double comision)
        {
            double solesNetos = soles - comision;
            return solesNetos / TIPO_CAMBIO;
        }

        // Método con retorno.
        // Calcula los soles netos después de descontar la comisión.
        // Lo agregamos para mostrar el comprobante con más claridad.
        public static double CalcularSolesNetos(double soles, double comision)
        {
            return soles - comision;
        }
    }
}
