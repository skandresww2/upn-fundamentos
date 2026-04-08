# ── Entrada ────────────────────────────────────────────────────
habitaciones = int(input('Cantidad de habitaciones: '))
banos = int(input('Cantidad de baños: '))
patios = int(input('Cantidad de patios: '))

# ── Proceso ────────────────────────────────────────────────────
# Cada ambiente tiene su precio fijo:
#   habitación = S/.30   |   baño = S/.10   |   patio = S/.15
total = (habitaciones * 30) + (banos * 10) + (patios * 15)

# ── Salida ─────────────────────────────────────────────────────
# :.2f para mostrar siempre 2 decimales (formato dinero).
print(f'Total a pagar: S/. {total:.2f}')