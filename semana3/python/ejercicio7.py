# ── Constantes ─────────────────────────────────────────────────
# En Python no existe la palabra 'const', pero por convención
# las constantes se escriben en MAYÚSCULAS para indicar que
# NO debemos modificarlas durante el programa.
CARGO_FIJO = 5.00
PRECIO_KWH = 0.55
TASA_IGV = 0.18

# ── Entrada ────────────────────────────────────────────────────
# float() porque el consumo puede tener decimales (ej: 150.5 kWh).
kwh = float(input('Consumo en kWh: '))

# ── Proceso ────────────────────────────────────────────────────
# Subtotal = cargo fijo mensual + (kWh consumidos × precio por kWh)
subtotal = CARGO_FIJO + (kwh * PRECIO_KWH)

# IGV = 18% del subtotal
igv = subtotal * TASA_IGV

# Total = subtotal + IGV
total = subtotal + igv

# ── Salida ─────────────────────────────────────────────────────
print(f'Subtotal:      S/. {subtotal:.2f}')
print(f'IGV (18%):     S/. {igv:.2f}')
print(f'Total a pagar: S/. {total:.2f}')