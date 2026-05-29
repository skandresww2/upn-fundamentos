# Importamos el módulo random para generar números aleatorios.
# Lo usaremos para que la computadora elija piedra, papel o tijera.
import random

# Puntaje del jugador.
puntaje_j = 0

# Puntaje de la computadora.
puntaje_pc = 0

# Contador de rondas jugadas.
ronda = 0

# Python no tiene do-while nativo.
# Por eso usamos while True, que crea un ciclo infinito,
# y luego usamos break para salir cuando alguien llegue a 3 puntos.
while True:
    # Aumenta el número de ronda en 1.
    ronda += 1

    print(f"\n--- Ronda {ronda} ---")

    # Se pide al usuario que ingrese su jugada.
    # 1 representa Piedra, 2 representa Papel y 3 representa Tijera.
    jugador = int(input("1=Piedra, 2=Papel, 3=Tijera: "))

    # random.randint(1, 3) genera un número aleatorio entre 1 y 3.
    # A diferencia de range, aquí sí incluye el 3.
    pc = random.randint(1, 3)

    print(f"La PC eligió: {pc}")

    # Validamos que el usuario haya ingresado 1, 2 o 3.
    # Si jugador es menor que 1 o mayor que 3, la opción no es válida.
    if jugador < 1 or jugador > 3:
        print("Opción no válida. La ronda no cuenta.")

        # Como la ronda no debe contarse, se resta 1 al contador.
        ronda -= 1

    elif jugador == pc:
        # Si ambos eligieron lo mismo, hay empate.
        # No se suma puntaje a nadie.
        print("Empate.")

    elif (jugador == 1 and pc == 3) or \
         (jugador == 2 and pc == 1) or \
         (jugador == 3 and pc == 2):
        # Esta condición contiene todas las formas en que gana el jugador:
        # 1) Piedra vence a Tijera
        # 2) Papel vence a Piedra
        # 3) Tijera vence a Papel
        #
        # El operador "and" significa "y".
        # El operador "or" significa "o".
        # Basta con que una de las tres combinaciones sea verdadera.

        print("Ganaste esta ronda.")

        # Se suma 1 punto al jugador.
        puntaje_j += 1

    else:
        # Si no hubo empate y el jugador no ganó,
        # entonces gana la computadora.
        print("Ganó la PC.")

        # Se suma 1 punto a la computadora.
        puntaje_pc += 1

    # Se muestra el marcador actualizado después de cada ronda.
    print(f"Marcador: Tú {puntaje_j} - PC {puntaje_pc}")

    # Condición de salida del ciclo.
    # Si el jugador llega a 3 puntos o la PC llega a 3 puntos,
    # se usa break para terminar el while True.
    if puntaje_j == 3 or puntaje_pc == 3:
        break

# Al salir del ciclo, se verifica quién llegó primero a 3 puntos.
if puntaje_j == 3:
    print("GANASTE EL JUEGO.")
else:
    print("GANÓ LA COMPUTADORA.")