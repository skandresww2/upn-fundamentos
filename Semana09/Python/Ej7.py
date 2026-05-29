# main.py
# Programa principal.
# Importamos nuestro módulo propio botica.py.

import Botica

print("=== CONTROL DE MEDICAMENTO EN BOTICA ===")

# Entrada de datos del medicamento.
nombre = input("Ingrese nombre del medicamento: ")
marca = input("Ingrese marca del medicamento: ")
anio_vencimiento = int(input("Ingrese año de vencimiento: "))
anio_actual = int(input("Ingrese año actual: "))

# Llamamos a la función del módulo para verificar si está vencido.
vencido = Botica.esta_vencido(anio_vencimiento, anio_actual)

# Mostramos los datos del medicamento.
Botica.mostrar_datos(nombre, marca, anio_vencimiento)

# Mostramos el estado final.
Botica.mostrar_estado(vencido)