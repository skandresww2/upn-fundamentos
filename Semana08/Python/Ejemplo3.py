# Ejemplo 3: Cálculo de delivery según distancia

# Variable global.
# Representa el límite para considerar una distancia cercana.
LIMITE_CERCANO = 5


# Función con retorno.
# Recibe la distancia y devuelve el costo del delivery.
def calcular_delivery(distancia):
    if distancia <= LIMITE_CERCANO:
        return 6.00
    else:
        return 10.00


# Procedimiento.
# Solo muestra el resultado final.
def mostrar_delivery(distancia, costo_delivery):
    print("\n=== DELIVERY ===")
    print(f"Distancia: {distancia:.2f} km")
    print(f"Costo de delivery: S/{costo_delivery:.2f}")


# Programa principal
distancia = float(input("Ingrese la distancia en km: "))

costo = calcular_delivery(distancia)

mostrar_delivery(distancia, costo)