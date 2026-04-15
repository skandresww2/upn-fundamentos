# Pedimos al usuario el promedio
promedio = float(input('Promedio (0–20): '))

# Evaluamos en qué rango se encuentra el promedio
if 0 <= promedio <= 5:
    print('Malo')
elif 6 <= promedio <= 10:
    print('Regular')
elif 11 <= promedio <= 14:
    print('Bueno')
elif 15 <= promedio <= 20:
    print('Excelente')
else:
    # Si el valor está fuera del rango 0 a 20
    print('Valor inválido')