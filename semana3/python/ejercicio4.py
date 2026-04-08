# Importamos math para acceder a la constante pi y otras funciones.
# En Python pi se escribe en MINÚSCULA: math.pi (no math.PI).
import math

# ── Entrada ────────────────────────────────────────────────────
# float() porque el radio puede tener decimales.
radio = float(input('Radio del círculo: '))

# ── Proceso ────────────────────────────────────────────────────
# math.pi es la constante π en Python (≈ 3.14159265...).
# Para elevar al cuadrado usamos el operador ** (potencia):
#   radio ** 2  es lo mismo que  radio * radio
# También funcionaría math.pow(radio, 2), pero ** es más "pythónico".
area = math.pi * radio ** 2

# Perímetro (circunferencia) = 2 × π × r
perimetro = 2 * math.pi * radio

# ── Salida ─────────────────────────────────────────────────────
# Formato :.4f → muestra 4 decimales (equivalente a :F4 de C#).
print(f'Área: {area:.4f}')
print(f'Perímetro: {perimetro:.4f}')