# Python no tiene do-while nativo.
# Se simula con while True y break.

while True:
    nota = int(input("Ingrese nota (0-20): "))

    # Si la nota está dentro del rango, se sale del bucle.
    if nota >= 0 and nota <= 20:
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

# Clasificación de la nota válida.
if nota >= 18:
    print("Clasificación: EXCELENTE")
elif nota >= 14:
    print("Clasificación: BUENO")
elif nota >= 11:
    print("Clasificación: REGULAR")
else:
    print("Clasificación: DESAPROBADO")