#Nota: Python no usa ref como C#. 
# Para lograr un comportamiento equivalente, 
# la función retorna el nuevo valor y el programa principal 
# lo reasigna a la variable original.

def simular_venta(stock, venta):
    # Esta función recibe el stock y la venta.
    # Calcula cómo quedaría el stock, pero NO modifica el stock real.
    stock_simulado = stock - venta

    print(f"Simulación: el stock quedaría en {stock_simulado}")


def confirmar_venta(stock, venta):
    # Esta función confirma la venta.
    # Calcula el nuevo stock y lo retorna al programa principal.
    nuevo_stock = stock - venta

    print("Confirmación: venta realizada correctamente.")

    return nuevo_stock


# ==========================
# Programa principal
# ==========================

print("=== CONTROL DE STOCK ===")

stock = int(input("Ingrese stock actual: "))
venta = int(input("Ingrese cantidad vendida: "))

# Primero verificamos si hay suficiente stock para realizar la venta.
if venta <= stock:
    # Simulamos la venta.
    # El stock real no cambia porque solo mostramos un cálculo posible.
    simular_venta(stock, venta)

    print(f"Stock real después de simular: {stock}")

    # Confirmamos la venta.
    # Como Python no usa ref, actualizamos el stock con el valor retornado.
    stock = confirmar_venta(stock, venta)

    print(f"Stock real después de confirmar: {stock}")

else:
    print("No se confirma venta por falta de stock.")