# math contiene ceil() y floor(). round() e int() son funciones
# nativas de Python, no necesitan import.
import math

# ── Entrada ────────────────────────────────────────────────────
monto = float(input('Monto en soles: '))

# ── Proceso ────────────────────────────────────────────────────
# math.ceil(x) → redondea SIEMPRE hacia arriba ("ceiling" = techo).
# Equivalente a Math.Ceiling de C#.
# Ejemplo: 7.1 → 8, 7.9 → 8
hacia_arriba = math.ceil(monto)

# math.floor(x) → redondea SIEMPRE hacia abajo ("floor" = piso).
# Equivalente a Math.Floor de C#.
# Ejemplo: 7.1 → 7, 7.9 → 7
hacia_abajo = math.floor(monto)

# int(x) → descarta los decimales (truncado, no redondeo).
# Equivalente al casting (int) de C#.
# Ejemplo: 7.9 → 7
# OJO: con negativos -7.9 → -7 (corta hacia el cero),
# mientras que math.floor(-7.9) → -8 (más negativo).
truncado = int(monto)

# round(x, n) → redondea matemáticamente a n decimales.
# Función nativa de Python, no necesita math.
# Ejemplo: round(7.856, 2) → 7.86
redondeado = round(monto, 2)

# ── Salida ─────────────────────────────────────────────────────
print(f'Monto original:           {monto}')
print(f'Ceiling (hacia arriba):   {hacia_arriba}')
print(f'Floor   (hacia abajo):    {hacia_abajo}')
print(f'Truncado (int):           {truncado}')
print(f'Redondeado (2 decimales): {redondeado}')