# Contraseña correcta que el usuario debe ingresar.
clave_correcta = "UPN2026"

# Número máximo de intentos permitidos.
max_intentos = 3

# Contador de intentos realizados.
intentos = 0

# Bandera lógica: indica si el usuario logró acceder.
acceso = False

# Python no tiene do-while nativo.
# Se simula con while True y se usa break para salir.
while True:
    # Cada vez que entra al ciclo, se cuenta un nuevo intento.
    intentos += 1

    clave = input(f"Intento {intentos}/{max_intentos} - Clave: ")

    # Si la clave ingresada coincide con la correcta, se activa el acceso.
    if clave == clave_correcta:
        acceso = True
    else:
        # Calcula cuántos intentos quedan.
        restantes = max_intentos - intentos

        # Solo muestra el mensaje si todavía quedan intentos disponibles.
        if restantes > 0:
            print(f"Clave incorrecta. Quedan {restantes} intentos.")

    # Condición de salida del do-while simulado:
    # salir si accedió o si agotó los intentos.
    if acceso or intentos >= max_intentos:
        break

# Al salir del ciclo, se verifica si salió porque acertó o porque agotó intentos.
if acceso:
    print("Acceso concedido. Bienvenido.")
else:
    print("Cuenta bloqueada. Contacte al administrador.")