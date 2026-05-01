# Pedimos la cantidad de días a analizar
n = int(input("Ingrese la cantidad de días: "))

# Variables acumuladoras y de control
total = 0
mayor = 0
menor = float('inf')  # Valor muy grande para iniciar la menor venta
dia_mayor = 0
dia_menor = 0

# Contadores por categoría
excelente = 0
bueno = 0
regular = 0
malo = 0

# Recorremos cada día
for i in range(1, n + 1):
    venta = float(input(f"Ingrese la venta del día {i}: "))

    # Acumular la venta al total
    total += venta

    # Verificar si es la mayor venta registrada hasta ahora
    if venta > mayor:
        mayor = venta
        dia_mayor = i

    # Verificar si es la menor venta registrada hasta ahora
    if venta < menor:
        menor = venta
        dia_menor = i

    # Clasificar la venta y aumentar su contador
    if venta >= 500:
        excelente += 1
    elif venta >= 200:
        bueno += 1
    elif venta >= 50:
        regular += 1
    else:
        malo += 1

# Calcular el promedio
promedio = total / n

# Mostrar el resumen final
print("\n----- Resumen de ventas -----")
print(f"Total de ventas: S/{total:.2f}")
print(f"Promedio diario: S/{promedio:.2f}")
print(f"Mayor venta: Día {dia_mayor} con S/{mayor:.2f}")
print(f"Menor venta: Día {dia_menor} con S/{menor:.2f}")
print(f"Días Excelente: {excelente}")
print(f"Días Bueno: {bueno}")
print(f"Días Regular: {regular}")
print(f"Días Malo: {malo}")