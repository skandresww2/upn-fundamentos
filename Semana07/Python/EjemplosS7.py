def Ejemplo():
        # Acumulador: aquí se irá guardando la suma de los números impares.
    suma = 0

    # Contador: indica cuántos números impares ya se han sumado.
    # Empieza en 0 porque todavía no se ha sumado ningún número.
    contador = 0

    # Variable que representa el número impar actual.
    # Se inicia en 1 porque el primer número impar positivo es 1.
    numero = 1

    # Python no tiene do-while nativo.
    # Por eso se simula usando while True y break.
    while True:
        # Sumamos el número impar actual al acumulador.
        suma = suma + numero

        # Aumentamos el contador porque ya se sumó un número impar.
        contador = contador + 1

        # Avanzamos al siguiente número impar.
        # Los impares aumentan de 2 en 2: 1, 3, 5, 7, 9...
        numero = numero + 2

        # Condición de salida:
        # si ya se sumaron 100 impares o el siguiente número ya no es menor que 500,
        # se termina el ciclo.
        if contador >= 100 or numero >= 500:
            break

    print("=== RESULTADO ===")
    print(f"Cantidad de impares sumados: {contador}")
    print(f"Siguiente impar después del ciclo: {numero}")
    print(f"La suma de los primeros 100 números impares menores a 500 es: {suma}")

def Ejemplo01():
    # Variable para guardar el mayor número encontrado.
    # Se inicia en None porque todavía no se ha ingresado ningún número válido.
    mayor = None

    # Contador para saber cuántos números válidos se ingresaron.
    # Es necesario porque el usuario podría ingresar 0 desde el inicio.
    contador = 0

    # Python no tiene estructura do-while nativa.
    # Por eso se simula usando while True y break.
    while True:
        # Solicitar número al usuario.
        numero = int(input("Ingrese un número entero (0 para terminar): "))

        # El número 0 es el valor centinela.
        # Sirve para terminar el ciclo y no debe evaluarse como dato válido.
        if numero == 0:
            break

        # Si es el primer número válido, mayor todavía vale None.
        # También se actualiza si el número ingresado supera al mayor actual.
        if mayor is None or numero > mayor:
            mayor = numero

        # Como el número fue válido, aumentamos el contador.
        contador = contador + 1

    print("\n=== RESULTADO ===")

    # Si el contador es mayor que 0, significa que sí hubo datos válidos.
    if contador > 0:
        print(f"El mayor número ingresado es: {mayor}")
    else:
        # Esto ocurre cuando el usuario ingresó 0 desde el primer intento.
        print("No se ingresaron números válidos.")


def Ejemplo02():
    # Acumulador para sumar los números mayores a 500.
    suma_mayor_500 = 0

    # Acumulador para sumar los números menores a 500.
    suma_menor_500 = 0

    # Contador para saber cuántos números mayores a 500 se ingresaron.
    contador_mayor_500 = 0

    # Contador para saber cuántos números menores a 500 se ingresaron.
    contador_menor_500 = 0

    # Python no tiene do-while nativo.
    # Por eso usamos while True, que repite indefinidamente,
    # y usamos break para salir cuando el usuario ingrese 0.
    while True:
        # Se pide un número al usuario.
        numero = int(input("Ingrese un número (0 para terminar): "))

        # El 0 funciona como valor centinela.
        # Un valor centinela es un dato especial que sirve para terminar el ciclo.
        if numero == 0:
            break

        # Si el número ingresado es mayor que 500,
        # pertenece al grupo de números mayores a 500.
        if numero > 500:
            # Se suma el número al acumulador de mayores a 500.
            suma_mayor_500 += numero

            # Se aumenta en 1 la cantidad de números mayores a 500.
            contador_mayor_500 += 1

        # Si el número ingresado es menor que 500,
        # pertenece al grupo de números menores a 500.
        elif numero < 500:
            # Se suma el número al acumulador de menores a 500.
            suma_menor_500 += numero

            # Se aumenta en 1 la cantidad de números menores a 500.
            contador_menor_500 += 1

        # Si el número es exactamente 500, no entra en ningún grupo.
        # No se suma ni se cuenta.

    print("\n=== RESULTADOS ===")

    # Antes de calcular el promedio, verificamos si hay números mayores a 500.
    # Esto evita dividir entre cero.
    if contador_mayor_500 > 0:
        # Fórmula del promedio:
        # promedio = suma de valores / cantidad de valores
        promedio_mayor_500 = suma_mayor_500 / contador_mayor_500

        # :.2f muestra el resultado con 2 decimales.
        print(f"Promedio de números mayores a 500: {promedio_mayor_500:.2f}")
    else:
        # Si el contador es 0, significa que no se ingresaron números mayores a 500.
        print("No se ingresaron números mayores a 500.")

    # Ahora hacemos la misma validación para los números menores a 500.
    if contador_menor_500 > 0:
        # Se calcula el promedio de los números menores a 500.
        promedio_menor_500 = suma_menor_500 / contador_menor_500

        # :.2f muestra el resultado con 2 decimales.
        print(f"Promedio de números menores a 500: {promedio_menor_500:.2f}")
    else:
        # Si el contador es 0, significa que no se ingresaron números menores a 500.
        print("No se ingresaron números menores a 500.")


if __name__ == "__main__":
    #Ejemplo();
    Ejemplo01();
    #Ejemplo02();