# main.py
# Programa principal.
# Importamos el módulo propio presupuesto.py.

import Presupuesto

print("=== PRESUPUESTO FAMILIAR MENSUAL ===")

# Entrada del ingreso mensual.
ingreso = float(input("Ingrese ingreso mensual: S/"))

# Entrada de gastos principales.
alimentos = float(input("Ingrese gasto en alimentos: S/"))
servicios = float(input("Ingrese gasto en servicios: S/"))
transporte = float(input("Ingrese gasto en transporte: S/"))

# Llamamos a las funciones del módulo presupuesto.
gastos = Presupuesto.calcular_gastos(alimentos, servicios, transporte)
saldo = Presupuesto.calcular_saldo(ingreso, gastos)
alerta = Presupuesto.evaluar_alerta(ingreso, gastos)

print("\n=== REPORTE DE PRESUPUESTO ===")
print(f"Ingreso mensual: S/{ingreso:.2f}")
print(f"Total de gastos: S/{gastos:.2f}")
print(f"Saldo disponible: S/{saldo:.2f}")

# Mostrar mensaje según el resultado de la alerta.
if alerta:
    print("Alerta: gastos altos.")
else:
    print("Sin alerta: gastos dentro del rango recomendado.")