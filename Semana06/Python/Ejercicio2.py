suma = 0
contador = 0
mayor = 0
menor = float("inf")  # Infinito: cualquier nota válida será menor

# Primera lectura antes del while (patrón centinela)
nota = float(input("Ingrese nota (-1 para terminar): "))

while nota != -1:  # -1 detiene el bucle
    if nota < 0 or nota > 20:
        print("Nota inválida (debe ser 0-20).")
    else:
        suma += nota
        contador += 1
        if nota > mayor: mayor = nota
        if nota < menor: menor = nota

    # CLAVE: lectura al mismo nivel que if/else, no dentro del else
    # Garantiza que se siga pidiendo tras nota inválida
    nota = float(input("Ingrese nota (-1 para terminar): "))

# Validar contador > 0 evita ZeroDivisionError
if contador > 0:
    promedio = suma / contador
    print(f"Notas ingresadas: {contador}")
    print(f"Nota más alta: {mayor}")
    print(f"Nota más baja: {menor}")
    print(f"Promedio: {promedio:.2f}")
else:
    print("No se ingresaron notas válidas.")