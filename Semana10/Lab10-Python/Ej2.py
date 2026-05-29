# Función con retorno.
# Recibe la cantidad y el precio unitario.
# Devuelve el importe del pedido.
def calcular_importe(cantidad, precio):
    return cantidad * precio


# Procedimiento.
# No retorna datos, solo muestra el resumen de un pedido.
def mostrar_pedido(plato, cantidad, importe):
    print(f"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:.2f}")


print("=== CONTROL DE PEDIDOS DEL DÍA ===")

# Acumulador del total vendido durante el día.
total_dia = 0

# Se registran exactamente 5 pedidos.
# range(1, 6) genera los valores 1, 2 y 3
for i in range(1, 4):
    print(f"\nPedido {i}")

    # Entrada del nombre del plato.
    plato = input("Nombre del plato: ")

    # Entrada de la cantidad solicitada.
    cantidad = int(input("Cantidad: "))

    # Entrada del precio unitario del plato.
    precio = float(input("Precio unitario: S/"))

    # Calculamos el importe del pedido usando una función.
    importe = calcular_importe(cantidad, precio)

    # Acumulamos el importe en el total del día.
    total_dia += importe

    # Mostramos el detalle del pedido actual.
    mostrar_pedido(plato, cantidad, importe)

# Al terminar los 3 pedidos, mostramos el total acumulado.
print(f"\nTotal vendido del día: S/{total_dia:.2f}")