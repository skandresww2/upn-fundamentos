# Precio fijo de cada cuaderno
precio_unitario = 5.00

# Mostrar encabezado de la tabla
print("Cant | Subtotal | Desc% | Total")
print("-----|----------|-------|--------")

# Recorremos las cantidades desde 1 hasta 20
for cant in range(1, 21):
    # Calcular subtotal: cantidad por precio unitario
    subtotal = cant * precio_unitario

    # Determinar el descuento según la cantidad comprada
    if cant <= 5:
        # De 1 a 5 unidades no hay descuento
        descuento = 0
    elif cant <= 12:
        # De 6 a 12 unidades se aplica 10%
        descuento = 0.10
    else:
        # Más de 12 unidades se aplica 20%
        descuento = 0.20

    # Calcular total final aplicando el descuento
    total = subtotal * (1 - descuento)

    # Mostrar una fila de la tabla con formato
    print(f" {cant:3} | S/{subtotal:6.2f} | {descuento*100:3.0f}% | S/{total:6.2f}")