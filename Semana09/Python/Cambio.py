# cambio.py
# Este archivo funciona como un módulo propio.
# Aquí agrupamos funciones relacionadas con la casa de cambio.

TIPO_CAMBIO = 3.75
COMISION = 0.02


def calcular_comision(soles):
    # Calcula el 2% de comisión sobre el monto ingresado.
    return soles * COMISION


def calcular_soles_netos(soles, comision):
    # Calcula el monto que realmente se convertirá a dólares.
    return soles - comision


def convertir_a_dolares(soles, comision):
    # Primero se descuentan los soles de comisión.
    soles_netos = soles - comision

    # Luego los soles netos se convierten a dólares.
    return soles_netos / TIPO_CAMBIO