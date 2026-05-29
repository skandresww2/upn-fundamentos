# ======================================================
# EJERCICIO 5: Pago en caja con vuelto
# Tema en C#: ref y out
# Equivalente recomendado en Python: retornar varios valores
# ======================================================


def procesar_pago(saldo_caja, total_compra, pago_cliente):
    # Esta función procesa el pago de una compra.
    # Recibe:
    # saldo_caja: dinero actual en la caja
    # total_compra: monto que debe pagar el cliente
    # pago_cliente: dinero entregado por el cliente

    if pago_cliente >= total_compra:
        # Si el pago alcanza, se calcula el vuelto.
        vuelto = pago_cliente - total_compra

        # No falta dinero porque el cliente pagó lo suficiente.
        faltante = 0

        # La caja aumenta solo con el total de la compra.
        # No se suma todo el pago del cliente porque una parte puede devolverse como vuelto.
        saldo_caja = saldo_caja + total_compra

        # Retornamos cuatro valores:
        # True: indica que el pago fue válido.
        # saldo_caja: saldo actualizado.
        # vuelto: dinero que se devuelve al cliente.
        # faltante: 0 porque no falta dinero.
        return True, saldo_caja, vuelto, faltante

    else:
        # Si el pago no alcanza, no se completa la venta.
        vuelto = 0

        # Calculamos cuánto dinero falta para completar la compra.
        faltante = total_compra - pago_cliente

        # La caja no cambia porque no se realizó la venta.
        return False, saldo_caja, vuelto, faltante


# ==========================
# Programa principal
# ==========================

print("=== PAGO EN CAJA ===")

saldo_caja = float(input("Ingrese saldo inicial de caja: S/"))
total_compra = float(input("Ingrese total de la compra: S/"))
pago_cliente = float(input("Ingrese pago del cliente: S/"))

# La función devuelve cuatro valores.
# Python permite recibirlos en cuatro variables en el mismo orden.
ok, saldo_caja, vuelto, faltante = procesar_pago(
    saldo_caja,
    total_compra,
    pago_cliente
)

# ok cumple el papel del bool en C#.
# Si ok es True, el pago fue válido.
if ok:
    print("\nPago realizado correctamente.")
    print(f"Vuelto: S/{vuelto:.2f}")
    print(f"Saldo final de caja: S/{saldo_caja:.2f}")

# Si ok es False, el pago fue insuficiente.
else:
    print("\nPago insuficiente.")
    print(f"Falta pagar: S/{faltante:.2f}")
    print(f"Saldo final de caja: S/{saldo_caja:.2f}")