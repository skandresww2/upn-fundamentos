subtotal = 0       # Acumulador del monto de la compra
total_articulos = 0  # Contador de artículos comprados

# Python no tiene do-while nativo.
# Se simula con while True y break.
while True:
    print("\n--- TIENDA TECH ---")
    print("1. USB 32GB - S/25")
    print("2. Mouse inalámbrico - S/45")
    print("3. Audífonos - S/60")
    print("0. Finalizar compra")

    opcion = int(input("Opción: "))

    # Solo si la opción es 1, 2 o 3 se pide cantidad
    if opcion >= 1 and opcion <= 3:
        cantidad = int(input("Cantidad: "))

        precio = 0

        # Asignar precio según el producto elegido
        if opcion == 1:
            precio = 25
        elif opcion == 2:
            precio = 45
        elif opcion == 3:
            precio = 60

        # Acumular el costo del producto elegido
        subtotal = subtotal + precio * cantidad

        # Acumular la cantidad total de artículos
        total_articulos = total_articulos + cantidad

    elif opcion == 0:
        break

    else:
        print("Opción no válida.")

descuento = 0

# Aplicar descuento solo si el subtotal supera S/100
if subtotal > 100:
    descuento = subtotal * 0.10

total = subtotal - descuento

print("\n--- RESUMEN DE COMPRA ---")
print(f"Artículos: {total_articulos}")
print(f"Subtotal: S/{subtotal:.2f}")
print(f"Descuento: S/{descuento:.2f}")
print(f"TOTAL: S/{total:.2f}")