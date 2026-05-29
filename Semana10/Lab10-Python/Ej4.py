# Función que cuenta cuántos dígitos tiene un número entero.
# No se usan cadenas; solo operaciones matemáticas.
def contar_digitos(codigo):
    # Contador de dígitos encontrados.
    contador = 0

    # abs convierte el número a positivo.
    # Esto evita problemas si el usuario ingresa un número negativo.
    codigo = abs(codigo)

    # El número 0 tiene 1 dígito.
    if codigo == 0:
        return 1

    # Mientras el código sea mayor que 0,
    # seguimos quitando dígitos.
    while codigo > 0:
        # Cada vuelta representa un dígito contado.
        contador = contador + 1

        # División entera entre 10.
        # Ejemplo: 123456 // 10 = 12345
        codigo = codigo // 10

    # Retornamos la cantidad total de dígitos.
    return contador


print("=== VALIDACIÓN DE COMPROBANTE ===")

# Entrada del código numérico.
codigo = int(input("Ingrese código de comprobante: "))

# Llamamos a la función para contar los dígitos.
digitos = contar_digitos(codigo)

print(f"Cantidad de dígitos: {digitos}")

# Un código válido debe tener entre 6 y 8 dígitos.
if digitos >= 6 and digitos <= 8:
    print("Código válido")
else:
    print("Código inválido")