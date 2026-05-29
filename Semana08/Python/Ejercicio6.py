# Función con retorno.
# Recibe el consumo en m3 y calcula el costo total según la tarifa por tramos.
def calcular_costo_agua(m3):
    # Si el consumo es hasta 20 m3, todo se cobra a S/1.80 por m3.
    if m3 <= 20:
        costo = m3 * 1.80
    else:
        # Si supera 20 m3:
        # Los primeros 20 m3 cuestan S/1.80 cada uno.
        # El exceso se cobra a S/2.50 por m3.
        costo = 20 * 1.80 + (m3 - 20) * 2.50

    return costo


# Procedimiento.
# No retorna valor, solo muestra el recibo final.
def mostrar_recibo(m3, costo):
    print("\n=== RECIBO DE AGUA ===")
    print(f"Consumo: {m3:.2f} m3")
    print(f"Costo total: S/{costo:.2f}")


print("=== CÁLCULO DE CONSUMO DE AGUA ===")

# Entrada de datos.
m3 = float(input("Ingrese consumo en m3: "))

# Llamamos a la función que calcula el costo.
costo = calcular_costo_agua(m3)

# Llamamos al procedimiento que muestra el recibo.
mostrar_recibo(m3, costo)