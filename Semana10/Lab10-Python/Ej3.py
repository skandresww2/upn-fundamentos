# Función con retorno.
# Recibe la opción elegida y devuelve la tarifa correspondiente.
def obtener_tarifa(opcion):
    # Opción 1: diagnóstico.
    if opcion == 1:
        return 30

    # Opción 2: mantenimiento.
    elif opcion == 2:
        return 60

    # Opción 3: reparación.
    elif opcion == 3:
        return 90

    # Si la opción no existe, retornamos 0 para indicar error.
    else:
        return 0


print("=== SERVICIO TÉCNICO ===")
print("1. Diagnóstico - S/30")
print("2. Mantenimiento - S/60")
print("3. Reparación - S/90")

# Entrada de la opción elegida.
opcion = int(input("Opción: "))

# Obtenemos la tarifa inmediatamente después de leer la opción.
tarifa = obtener_tarifa(opcion)

# Si la tarifa es 0, significa que la opción no existe.
# En ese caso, no pedimos la cantidad de equipos.
if tarifa == 0:
    print("Datos no válidos.")

else:
    # Solo si la opción fue válida, pedimos la cantidad de equipos.
    cantidad = int(input("Cantidad de equipos: "))

    # Validamos que la cantidad sea positiva.
    if cantidad > 0:
        total = tarifa * cantidad
        print(f"Total a pagar: S/{total:.2f}")
    else:
        print("Datos no válidos.")