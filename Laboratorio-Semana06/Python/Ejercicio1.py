saldo = 1000.00  # Saldo inicial
retiros = 0       # Contador de retiros exitosos

print("=== CAJERO AUTOMÁTICO ===")
print(f"Saldo disponible: S/{saldo:.2f}")

# Primera lectura antes del while
monto = float(input("Monto a retirar (0 para salir): "))

while monto != 0:
    if monto < 0:
        print("Error: monto inválido.")
    elif monto > saldo:
        print("Error: saldo insuficiente.")
    else:
        saldo -= monto
        retiros += 1
        print(f"Retiro exitoso. Saldo: S/{saldo:.2f}")

    # Nueva lectura para evitar bucle infinito
    monto = float(input("Monto a retirar (0 para salir): "))

print("--- RESUMEN ---")
print(f"Retiros realizados: {retiros}")
print(f"Saldo final: S/{saldo:.2f}")