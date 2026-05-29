# Ejemplo 2: Control de aforo en laboratorio

# Variable global.
# Representa el aforo máximo permitido.
AFORO_MAXIMO = 30


# Función con retorno booleano.
# Devuelve True si la cantidad está permitida.
# Devuelve False si supera el aforo.
def validar_aforo(cantidad_estudiantes):
    return cantidad_estudiantes <= AFORO_MAXIMO


# Procedimiento.
# No devuelve un valor, solo muestra un mensaje.
def mostrar_resultado(cantidad_estudiantes, permitido):
    print("\n=== CONTROL DE AFORO ===")
    print(f"Cantidad de estudiantes: {cantidad_estudiantes}")

    if permitido:
        print("Ingreso permitido.")
    else:
        print("Aforo excedido.")


# Programa principal
cantidad = int(input("Ingrese cantidad de estudiantes: "))

permitido = validar_aforo(cantidad)

mostrar_resultado(cantidad, permitido)