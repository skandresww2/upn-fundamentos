# Constante global.
# Guarda el valor del IGV: 18%, que en decimal es 0.18.
IGV = 0.18

# Definimos una función para calcular el subtotal.
# La función recibe:
# precio_unitario: precio de un producto.
# cantidad: número de productos comprados.
def calcular_subtotal(precio_unitario, cantidad):
    # Multiplica el precio unitario por la cantidad.
    # Este resultado todavía no incluye IGV.
    return precio_unitario * cantidad

# Definimos una función para calcular el IGV.
# Recibe el subtotal como dato de entrada.
def calcular_igv(subtotal):
    # Multiplica el subtotal por 0.18.
    # Se usa la constante IGV para no escribir 0.18 varias veces.
    return subtotal * IGV

# Definimos una función para calcular el total.
# Recibe el subtotal y el monto del IGV.
def calcular_total(subtotal, igv):
    # El total se obtiene sumando subtotal más IGV.
    return subtotal + igv

# Definimos una función para mostrar la boleta.
# Esta función no devuelve un valor.
# Solo imprime información en pantalla.
def mostrar_boleta(subtotal, igv, total):
    # Imprime una línea en blanco y el título de la boleta.
    print("\n=== BOLETA ===")

    # Muestra el subtotal con 2 decimales.
    # :.2f significa mostrar el número con 2 decimales.
    print(f"Subtotal: S/{subtotal:.2f}")

    # Muestra el IGV con 2 decimales.
    print(f"IGV (18%): S/{igv:.2f}")

    # Muestra el total final con 2 decimales.
    print(f"TOTAL: S/{total:.2f}")

# Pide al usuario el precio unitario.
# input() lee texto.
# float() convierte ese texto a número decimal.
precio = float(input("Precio unitario: S/"))

# Pide al usuario la cantidad.
# int() convierte el texto ingresado a número entero.
cantidad = int(input("Cantidad: "))

# Llama a la función calcular_subtotal.
# Envía precio y cantidad.
# Guarda el resultado en la variable subtotal.
subtotal = calcular_subtotal(precio, cantidad)

# Llama a la función calcular_igv.
# Envía el subtotal.
# Guarda el resultado en la variable igv.
igv = calcular_igv(subtotal)

# Llama a la función calcular_total.
# Envía subtotal e igv.
# Guarda el resultado en la variable total.
total = calcular_total(subtotal, igv)

# Llama a la función mostrar_boleta.
# Envía los valores calculados para imprimir la boleta.
mostrar_boleta(subtotal, igv, total)