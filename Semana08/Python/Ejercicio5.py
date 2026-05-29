# Función con retorno booleano.
# Verifica si la nota ingresada está dentro del rango válido: 0 a 20.
def es_nota_valida(nota):
    return nota >= 0 and nota <= 20


# Función con retorno string.
# Recibe una nota válida y devuelve su clasificación.
def clasificar_nota(nota):
    # Si la nota es 18 o más, se considera excelente.
    if nota >= 18:
        return "Excelente"

    # Si no fue excelente, pero es 14 o más, se considera bueno.
    elif nota >= 14:
        return "Bueno"

    # Si no fue bueno, pero es 11 o más, se considera regular.
    elif nota >= 11:
        return "Regular"

    # Si la nota está entre 0 y 10, queda desaprobado.
    else:
        return "Desaprobado"


# Procedimiento.
# No retorna ningún valor; solo muestra el reporte final.
def mostrar_reporte(nota, clasificacion):
    print("\n=== REPORTE ACADÉMICO ===")
    print(f"Nota ingresada: {nota:.2f}")
    print(f"Clasificación: {clasificacion}")


print("=== SISTEMA DE CLASIFICACIÓN DE NOTAS ===")

# Solicitar la nota final al usuario.
nota = float(input("Ingrese nota final (0-20): "))

# Primero validamos la nota antes de clasificarla.
if es_nota_valida(nota):
    # Si la nota es válida, llamamos a la función que clasifica.
    clasificacion = clasificar_nota(nota)

    # Luego mostramos el reporte usando un procedimiento.
    mostrar_reporte(nota, clasificacion)
else:
    # Si la nota no está entre 0 y 20, se muestra un mensaje de error.
    print("Error: la nota debe estar entre 0 y 20.")