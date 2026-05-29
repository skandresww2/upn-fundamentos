using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class UtilPresupuesto
    {
        // Constante que representa el límite de alerta.
        // 0.80 equivale al 80 % del ingreso.
        public const double LIMITE_ALERTA = 0.80;

        // Calcula el total de gastos de la familia.
        // Recibe tres gastos y retorna la suma total.
        public static double CalcularGastos(double alimentos, double servicios, double transporte)
        {
            return alimentos + servicios + transporte;
        }

        // Calcula el saldo disponible.
        // El saldo es lo que queda después de restar los gastos al ingreso.
        public static double CalcularSaldo(double ingreso, double gastos)
        {
            return ingreso - gastos;
        }

        // Evalúa si los gastos son altos.
        // Retorna true si los gastos son mayores o iguales al 80 % del ingreso.
        // Retorna false si los gastos están por debajo del límite.
        public static bool EvaluarAlerta(double ingreso, double gastos)
        {
            return gastos >= ingreso * LIMITE_ALERTA;
        }
    }
}
