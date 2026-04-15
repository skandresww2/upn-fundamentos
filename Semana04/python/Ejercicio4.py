# Pedimos los datos al usuario
cat = input('Categoría (A/B/C): ').upper()
horas = float(input('Horas: '))
anios = int(input('Años de servicio: '))

# Según la categoría, asignamos la tarifa por hora
if cat == "A":
    tarifa = 33.50
elif cat == "B":
    tarifa = 29.80
elif cat == "C":
    tarifa = 25.70
else:
    print('Categoría inválida')
    exit()

# Según los años de servicio, asignamos la bonificación
if anios <= 3:
    bono = 0.00
elif anios <= 10:
    bono = 0.10
elif anios <= 17:
    bono = 0.20
else:
    bono = 0.30

# Calculamos el sueldo final
# Se multiplica tarifa por horas y luego se aplica el bono
print(f'Sueldo: S/. {tarifa * horas * (1 + bono):.2f}')