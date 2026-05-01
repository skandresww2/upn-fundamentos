# Pedimos la cantidad de empleados
n = int(input("Ingrese la cantidad de empleados: "))

# Acumulador para guardar la suma de todos los sueldos netos
total_planilla = 0

# Recorremos a cada empleado
for i in range(1, n + 1):
    print(f"\nEmpleado {i}")

    # Leer nombre del empleado
    nombre = input("Nombre: ")

    # Leer horas trabajadas
    horas_trabajadas = int(input("Horas trabajadas: "))

    # Si trabajó 160 horas o menos, todo se paga como horas normales
    if horas_trabajadas <= 160:
        horas_normales = horas_trabajadas
        horas_extras = 0
        sueldo_bruto = horas_trabajadas * 12.50
    else:
        # Si supera 160, calculamos las horas extra
        horas_normales = 160
        horas_extras = horas_trabajadas - 160

        # Las horas normales van a S/12.50
        # Las horas extra van a S/25.00
        sueldo_bruto = 160 * 12.50 + horas_extras * 25.00

    # Calculamos el descuento del 5%
    descuento = sueldo_bruto * 0.05

    # Calculamos el sueldo neto
    sueldo_neto = sueldo_bruto - descuento

    # Acumulamos el sueldo neto al total de planilla
    total_planilla += sueldo_neto

    # Mostramos los resultados del empleado
    print("----- Boleta del empleado -----")
    print(f"Nombre: {nombre}")
    print(f"Horas normales: {horas_normales}")
    print(f"Horas extra: {horas_extras}")
    print(f"Sueldo bruto: S/{sueldo_bruto:.2f}")
    print(f"Descuento (5%): S/{descuento:.2f}")
    print(f"Sueldo neto: S/{sueldo_neto:.2f}")

# Mostrar el total general de la planilla
print(f"\nTotal planilla: S/{total_planilla:.2f}")