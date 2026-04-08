# ── Entrada ────────────────────────────────────────────────────
celsius = float(input('Temperatura en Celsius: '))

# ── Proceso ────────────────────────────────────────────────────
# En Python NO existe el problema del 9/5 que tiene C#.
# Aquí 9 / 5 da 1.8 directamente (porque '/' siempre da decimal).
# Aun así, escribir 9.0 / 5 también funciona y deja claro
# que estamos trabajando con decimales.
fahrenheit = celsius * (9 / 5) + 32

# Kelvin: solo sumar 273.15 (la diferencia exacta entre escalas).
kelvin = celsius + 273.15

# ── Salida ─────────────────────────────────────────────────────
print(f'{celsius:.2f} °C equivalen a:')
print(f'  {fahrenheit:.2f} °F')
print(f'  {kelvin:.2f} K')