# tienda.py
# Este archivo funciona como un módulo propio.
# Aquí colocamos funciones relacionadas con cálculos de tienda.

def calcular_subtotal(cantidad, precio):
    # Calcula el subtotal multiplicando cantidad por precio unitario.
    return cantidad * precio


def calcular_descuento(subtotal):
    # Si el subtotal supera S/200, aplica 10% de descuento.
    if subtotal > 200:
        return subtotal * 0.10
    else:
        return 0


def calcular_total(subtotal, descuento):
    # Calcula el total final restando el descuento al subtotal.
    return subtotal - descuento