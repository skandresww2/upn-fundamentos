# ======================================================
# EJERCICIO 2: División segura
# Nota: Python no usa out como C#.
# En Python podemos retornar dos valores: válido y resultado.
# ======================================================


def dividir_seguro(dividendo, divisor):
    # Si el divisor es cero, no se puede realizar la división.
    if divisor == 0:
        return False, 0

    # Si el divisor no es cero, se calcula el resultado.
    resultado = dividendo / divisor
    return True, resultado


# ==========================
# Programa principal
# ==========================

print("=== DIVISIÓN SEGURA ===")

dividendo = float(input("Ingrese el dividendo: "))
divisor = float(input("Ingrese el divisor: "))

# La función devuelve dos valores:
# valido indica si se pudo dividir.
# resultado guarda el valor de la división.
valido, resultado = dividir_seguro(dividendo, divisor)

if valido:
    print(f"Resultado: {resultado:.2f}")
else:
    print("No se puede dividir entre cero.")