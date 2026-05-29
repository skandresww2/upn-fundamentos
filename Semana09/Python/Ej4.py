# main.py
# Programa principal.
# Importamos nuestro módulo propio cambio.py.

import Cambio

print("=== CASA DE CAMBIO ===")

soles = float(input("Ingrese monto en soles: S/"))

# Llamamos a las funciones del módulo cambio.
comision = Cambio.calcular_comision(soles)
soles_netos = Cambio.calcular_soles_netos(soles, comision)
dolares = Cambio.convertir_a_dolares(soles, comision)

print("\n=== COMPROBANTE DE CAMBIO ===")
print(f"Monto ingresado: S/{soles:.2f}")
print(f"Comisión (2%): S/{comision:.2f}")
print(f"Soles netos: S/{soles_netos:.2f}")
print(f"Dólares recibidos: ${dolares:.2f}")