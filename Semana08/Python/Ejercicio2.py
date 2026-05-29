# Constante global.
# Representa la nota mínima para aprobar.
NOTA_APROBATORIA = 11

# Función con retorno.
# Recibe tres notas como parámetros.
def calcular_promedio(n1, n2, n3):
    # Se suman las tres notas y se dividen entre 3.
    # promedio es una variable local:
    # solo existe dentro de esta función.
    promedio = (n1 + n2 + n3) / 3

    # return devuelve el resultado calculado
    # al lugar donde se llamó la función.
    return promedio

# Función con retorno.
# Recibe el promedio y devuelve un texto:
# "Aprobado" o "Desaprobado".
def clasificar_promedio(promedio):
    # Si el promedio es mayor o igual a la nota aprobatoria,
    # el estudiante aprueba.
    if promedio >= NOTA_APROBATORIA:
        return "Aprobado"
    else:
        # Si el promedio es menor que la nota aprobatoria,
        # el estudiante desaprueba.
        return "Desaprobado"

# Función sin retorno explícito.
# En Python no usamos void.
# Esta función solo imprime el reporte en pantalla.
def imprimir_reporte(estudiante, promedio, estado):
    # Muestra el título del reporte.
    print("\n=== REPORTE DE NOTAS ===")

    # Muestra el nombre del estudiante.
    print(f"Estudiante: {estudiante}")

    # Muestra el promedio con 2 decimales.
    # :.2f significa formato con 2 decimales.
    print(f"Promedio: {promedio:.2f}")

    # Muestra si está aprobado o desaprobado.
    print(f"Estado: {estado}")

# Solicita el nombre del estudiante.
nombre = input("Nombre del estudiante: ")

# Solicita la primera nota.
# input() lee texto.
# float() convierte ese texto a número decimal.
n1 = float(input("Nota 1: "))

# Solicita la segunda nota y la convierte a decimal.
n2 = float(input("Nota 2: "))

# Solicita la tercera nota y la convierte a decimal.
n3 = float(input("Nota 3: "))

# Llama a la función calcular_promedio.
# Envía las tres notas.
# Guarda el resultado en la variable promedio.
promedio = calcular_promedio(n1, n2, n3)

# Llama a la función clasificar_promedio.
# Envía el promedio.
# Guarda el texto "Aprobado" o "Desaprobado".
estado = clasificar_promedio(promedio)

# Llama a la función imprimir_reporte.
# Envía el nombre, promedio y estado.
# Esta función solo muestra los datos en pantalla.
imprimir_reporte(nombre, promedio, estado)