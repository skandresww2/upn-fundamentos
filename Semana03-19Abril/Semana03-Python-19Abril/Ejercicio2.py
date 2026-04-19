# Ejercicio 2: Menú de opciones usando match-case en Python

# Paso 1: Mostrar las opciones del menú
print("=== Menú de operaciones ===")
print("1. Calcular área de un círculo")
print("2. Calcular área de un cuadrado")
print("3. Calcular área de un triángulo")
print("4. Salir")

# Paso 2: Pedir al usuario una opción
# input() siempre devuelve texto
# por eso usamos int() para convertir ese texto a número entero
opcion = int(input("Seleccione una opción (1–4): "))

# Paso 3: Evaluar la opción elegida
# match-case es parecido a switch-case en C#
match opcion:
    case 1:
        print("Elegiste círculo")
        print("Área del círculo = π × r²")

    case 2:
        print("Elegiste cuadrado")
        print("Área del cuadrado = lado²")

    case 3:
        print("Elegiste triángulo")
        print("Área del triángulo = (base × altura) / 2")

    case 4:
        print("Saliendo del programa...")

    case _:
        # case _ significa "cualquier otro valor"
        print("Opción inválida. Ingresa un número del 1 al 4.")