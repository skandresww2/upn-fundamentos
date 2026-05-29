# Función con retorno.
# Calcula la venta de un turno multiplicando cantidad por precio.
def calcular_venta_turno(cantidad, precio):
    return cantidad * precio


print("=== VENTA DE PRODUCTOS POR TURNOS ===")

# Acumulador del total vendido durante todo el día.
total_dia = 0

# Se registran exactamente 3 turnos.
# range(1, 4) genera: 1, 2 y 3.
for turno in range(1, 4):
    print(f"\nTurno {turno}")

    # Validar cantidad.
    # El while True permite repetir hasta que el dato sea correcto.
    while True:
        cantidad = int(input("Cantidad de productos vendidos: "))

        if cantidad > 0:
            break  # Sale del ciclo si la cantidad es válida.
        else:
            print("Error: la cantidad debe ser mayor que 0.")

    # Validar precio.
    # Se repite hasta que el precio sea mayor que 0.
    while True:
        precio = float(input("Precio unitario: S/"))

        if precio > 0:
            break  # Sale del ciclo si el precio es válido.
        else:
            print("Error: el precio debe ser mayor que 0.")

    # Calculamos la venta del turno usando la función.
    venta = calcular_venta_turno(cantidad, precio)

    # Acumulamos la venta del turno en el total del día.
    total_dia = total_dia + venta

    print(f"Venta del turno {turno}: S/{venta:.2f}")

# Al finalizar los 3 turnos, mostramos el total acumulado.
print(f"\nTotal vendido del día: S/{total_dia:.2f}")