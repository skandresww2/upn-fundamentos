# Ejemplo 1: Cálculo de propina en restaurante

# Función con retorno.
# Recibe el consumo y devuelve la propina.
def calcular_propina(consumo):
    return consumo * 0.10


# Función con retorno.
# Recibe el consumo y la propina, y devuelve el total a pagar.
def calcular_total(consumo, propina):
    return consumo + propina


# Programa principal
consumo = float(input("Ingrese el consumo: S/"))

propina = calcular_propina(consumo)
total = calcular_total(consumo, propina)

print("\n=== RESTAURANTE ===")
print(f"Consumo: S/{consumo:.2f}")
print(f"Propina: S/{propina:.2f}")
print(f"Total a pagar: S/{total:.2f}")