# Función que calcula el sueldo bruto.
# Recibe como parámetro la cantidad de horas trabajadas.
def calcular_bruto(horas):
    # La empresa paga S/12.50 por cada hora trabajada.
    return horas * 12.50


# Función que calcula el descuento.
# Recibe como parámetro el sueldo bruto.
def calcular_descuento(bruto):
    # El descuento es el 5% del sueldo bruto.
    # 5% en decimal se escribe como 0.05.
    return bruto * 0.05


# Función que calcula el sueldo neto.
# Recibe el sueldo bruto y el descuento.
def calcular_neto(bruto, descuento):
    # El sueldo neto se obtiene restando el descuento al sueldo bruto.
    return bruto - descuento


# Pedimos al usuario la cantidad de horas trabajadas.
# input() lee texto y float() lo convierte a número decimal.
horas = float(input("Horas trabajadas: "))

# Llamamos a la función calcular_bruto y guardamos el resultado.
bruto = calcular_bruto(horas)

# Llamamos a la función calcular_descuento usando el sueldo bruto.
descuento = calcular_descuento(bruto)

# Llamamos a la función calcular_neto usando bruto y descuento.
neto = calcular_neto(bruto, descuento)

# Mostramos el sueldo bruto con 2 decimales.
print(f"Sueldo bruto: S/{bruto:.2f}")

# Mostramos el descuento con 2 decimales.
print(f"Descuento: S/{descuento:.2f}")

# Mostramos el sueldo neto con 2 decimales.
print(f"Sueldo neto: S/{neto:.2f}")