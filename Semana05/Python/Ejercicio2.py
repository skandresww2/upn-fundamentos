# Pedimos al usuario el consumo de energía en kWh
kwh = int(input("Ingrese consumo en kWh: "))

# Variable donde guardaremos el monto final a pagar
monto = 0

# Validamos que el consumo sea mayor que cero
if kwh <= 0:
    print("Error: consumo debe ser positivo.")
# Primer tramo: hasta 100 kWh
elif kwh <= 100:
    # Todo el consumo se cobra a S/0.50
    monto = kwh * 0.50
# Segundo tramo: de 101 a 300 kWh
elif kwh <= 300:
    # Los primeros 100 kWh se cobran a S/0.50
    # El exceso sobre 100 se cobra a S/0.75
    monto = 100 * 0.50 + (kwh - 100) * 0.75
# Tercer tramo: más de 300 kWh
else:
    # Los primeros 100 kWh se cobran a S/0.50
    # Los siguientes 200 kWh se cobran a S/0.75
    # Lo que excede 300 se cobra a S/1.20
    monto = 100 * 0.50 + 200 * 0.75 + (kwh - 300) * 1.20

# Mostramos el monto final con 2 decimales
print(f"Monto a pagar: S/{monto:.2f}")