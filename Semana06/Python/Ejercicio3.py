# Stock inicial del almacén
stock = 500
# Acumulador de unidades vendidas
total_vendido = 0

# LECTURA ADELANTADA: primera venta antes del while (patrón centinela)
venta = int(input("Unidades vendidas (0 para salir): "))

# Centinela = 0 → el bucle continúa mientras venta sea distinta de 0
while venta != 0:
    # VALIDACIÓN 1: rechaza cantidades negativas
    if venta < 0:
        print("Error: cantidad no puede ser negativa.")
    # VALIDACIÓN 2: rechaza ventas que superen el stock disponible
    elif venta > stock:
        print(f"Error: stock insuficiente. Quedan {stock}")
    # CASO VÁLIDO: descuenta del stock y acumula
    else:
        stock -= venta           # Resta unidades vendidas al inventario
        total_vendido += venta   # Suma al total vendido
        print(f"Venta registrada. Stock: {stock}")

    # RELECTURA al mismo nivel que if/elif/else (NO dentro del else)
    # Si estuviera dentro del else, una venta inválida congelaría el programa
    venta = int(input("Unidades vendidas (0 para salir): "))

# Reporte final al salir del bucle
print(f"Stock restante: {stock}")
print(f"Total vendido: {total_vendido}")