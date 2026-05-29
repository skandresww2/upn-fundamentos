# Contadores de votos para cada candidato.
# Todos empiezan en 0 porque al inicio nadie tiene votos.
votos_ana = 0
votos_carlos = 0
votos_lucia = 0

# Contador para votos inválidos o nulos.
nulos = 0

# Python no tiene do-while nativo.
# Se simula con while True, que repite indefinidamente,
# y se usa break para salir cuando el usuario ingresa 0.
while True:
    print("\n=== SISTEMA DE VOTACIÓN ===")
    print("1. Ana Torres")
    print("2. Carlos Mendoza")
    print("3. Lucía Paredes")
    print("0. Cerrar votación")

    # Se lee el voto ingresado por el usuario.
    voto = int(input("Ingrese su voto: "))

    # Si se ingresa 0, se cierra la votación.
    # El 0 no se cuenta como voto nulo.
    if voto == 0:
        break

    # Decisión múltiple para registrar el voto.
    # Si el voto es 1, se suma un voto para Ana.
    if voto == 1:
        votos_ana += 1

    # Si el voto es 2, se suma un voto para Carlos.
    elif voto == 2:
        votos_carlos += 1

    # Si el voto es 3, se suma un voto para Lucía.
    elif voto == 3:
        votos_lucia += 1

    else:
        # Si no es 1, 2, 3 ni 0, se considera voto nulo.
        nulos += 1
        print("Voto nulo.")

# Se calcula el total de votantes.
# Se suman los votos válidos y los votos nulos.
total = votos_ana + votos_carlos + votos_lucia + nulos

print("\n=== RESULTADOS ===")
print(f"Ana Torres: {votos_ana}")
print(f"Carlos Mendoza: {votos_carlos}")
print(f"Lucía Paredes: {votos_lucia}")
print(f"Votos nulos: {nulos}")
print(f"Total de votantes: {total}")

# Se compara si Ana tiene más votos que Carlos y más votos que Lucía.
if votos_ana > votos_carlos and votos_ana > votos_lucia:
    print("Ganadora: Ana Torres")

# Se compara si Carlos tiene más votos que Ana y más votos que Lucía.
elif votos_carlos > votos_ana and votos_carlos > votos_lucia:
    print("Ganador: Carlos Mendoza")

# Se compara si Lucía tiene más votos que Ana y más votos que Carlos.
elif votos_lucia > votos_ana and votos_lucia > votos_carlos:
    print("Ganadora: Lucía Paredes")

else:
    # Si nadie tiene más votos que los otros dos, entonces hay empate.
    # Puede ser empate entre dos candidatos o entre los tres.
    print("Resultado: EMPATE")