# Acumulador: guarda la suma de todos los platos elegidos.
subtotal = 0

# Contador: guarda cuántos platos válidos se pidieron.
platos = 0

# Python no tiene do-while nativo.
# Se simula con while True y se sale con break.
while True:
    # El menú se muestra al menos una vez.
    print("\n=== MENÚ DEL RESTAURANTE ===")
    print("1. Lomo saltado - S/25.00")
    print("2. Ceviche - S/30.00")
    print("3. Ají de gallina - S/20.00")
    print("4. Pollo a la brasa - S/35.00")
    print("0. Pedir la cuenta")

    opcion = int(input("Elija una opción: "))

    # Decisión múltiple: se evalúa qué opción eligió el cliente.
    if opcion == 1:
        subtotal = subtotal + 25
        platos = platos + 1
        print("Agregado: Lomo saltado")

    elif opcion == 2:
        subtotal = subtotal + 30
        platos = platos + 1
        print("Agregado: Ceviche")

    elif opcion == 3:
        subtotal = subtotal + 20
        platos = platos + 1
        print("Agregado: Ají de gallina")

    elif opcion == 4:
        subtotal = subtotal + 35
        platos = platos + 1
        print("Agregado: Pollo a la brasa")

    elif opcion == 0:
        # break termina el ciclo y permite mostrar la cuenta.
        break

    else:
        print("Opción no válida.")

# Cálculo de la cuenta final.
igv = subtotal * 0.18
total = subtotal + igv

print("\n=== CUENTA ===")
print(f"Platos pedidos: {platos}")
print(f"Subtotal: S/{subtotal:.2f}")
print(f"IGV (18%): S/{igv:.2f}")
print(f"TOTAL: S/{total:.2f}")