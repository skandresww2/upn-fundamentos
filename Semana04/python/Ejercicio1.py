# 1) Pedir el monto al usuario y convertirlo a número decimal
monto = float(input("Ingrese el monto de la compra (S/): "))

# 2) Inicializar el descuento en 0 (caso por defecto)
descuento = 0

# 3) Condicional simple: solo SI se cumple la condición se ejecuta el bloque
if monto >= 100:
    descuento = monto * 0.10   # 10% del monto

# 4) Calcular el total restando el descuento
total = monto - descuento

# 5) f-string: permite insertar variables y formatear valores
# Mostrar el resultado con 2 decimales (round redondea el número)
print(f"Descuento aplicado: S/ {round(descuento, 2)}")
print(f"Total a pagar:      S/ {round(total, 2)}")
