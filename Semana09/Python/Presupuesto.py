# presupuesto.py
# Este archivo funciona como un módulo propio.
# Aquí se agrupan funciones relacionadas con presupuesto familiar.

LIMITE_ALERTA = 0.80


def calcular_gastos(alimentos, servicios, transporte):
    # Calcula el total de gastos sumando las tres categorías.
    return alimentos + servicios + transporte


def calcular_saldo(ingreso, gastos):
    # Calcula cuánto dinero queda después de pagar los gastos.
    return ingreso - gastos


def evaluar_alerta(ingreso, gastos):
    # Retorna True si los gastos son mayores o iguales al 80 % del ingreso.
    return gastos >= ingreso * LIMITE_ALERTA