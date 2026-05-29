# main.py
# Programa principal.
# Importamos el módulo propio tienda.py.

import Tienda

print("=== TIENDA - CÁLCULO DE DESCUENTO ===")

cantidad = int(input("Ingrese cantidad de productos: "))
precio = float(input("Ingrese precio unitario: S/"))

# Llamamos a las funciones del módulo tienda.
subtotal = Tienda.calcular_subtotal(cantidad, precio)
descuento = Tienda.calcular_descuento(subtotal)
total = Tienda.calcular_total(subtotal, descuento)

print("\n=== COMPROBANTE DE COMPRA ===")
print(f"Cantidad: {cantidad}")
print(f"Precio unitario: S/{precio:.2f}")
print(f"Subtotal: S/{subtotal:.2f}")
print(f"Descuento: S/{descuento:.2f}")
print(f"Total a pagar: S/{total:.2f}")