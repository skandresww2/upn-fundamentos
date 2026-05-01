import random
secreto = random.randint(1, 50)   # randint incluye AMBOS extremos: 1 y 50
intentos = 0
max_intentos = 7
adivino = False                   # bandera de victoria

print("Adivina el número (1-50). Tienes 7 intentos.")

# DOBLE CONDICIÓN con and: continúa solo si NO ha adivinado Y le quedan intentos
while not adivino and intentos < max_intentos:
    intentos += 1
    intento = int(input(f"Intento {intentos}: "))

    if intento == secreto:
        adivino = True            # activa bandera → el while terminará
    elif intento < secreto:       # intento por debajo del secreto
        print("El número es MAYOR.")
    else:                         # intento por encima del secreto
        print("El número es MENOR.")

# Diagnóstico final según cómo terminó el while
if adivino:
    print(f"¡Ganaste en {intentos} intentos!")
else:
    print(f"Perdiste. El número era {secreto}.")