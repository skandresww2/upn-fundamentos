# Pedimos al usuario la nota del examen parcial
parcial = float(input("Ingrese examen parcial: "))

# Pedimos al usuario la nota del examen final
final = float(input("Ingrese examen final: "))

# Pedimos las 3 notas de práctica
p1 = float(input("Ingrese práctica 1: "))
p2 = float(input("Ingrese práctica 2: "))
p3 = float(input("Ingrese práctica 3: "))

# min() devuelve el valor más pequeño
# Aquí encontramos la práctica más baja para descartarla
menor = min(p1, p2, p3)

# Sumamos las 3 prácticas
# Restamos la práctica menor para eliminarla
# Dividimos entre 2 porque solo promediamos las 2 mejores prácticas
prom_prac = (p1 + p2 + p3 - menor) / 2

# Calculamos el promedio final
# Sumamos parcial, final y promedio de prácticas
# Luego dividimos entre 3 porque hay tres partes en el promedio
prom_final = (parcial + final + prom_prac) / 3

# Mostramos el promedio de prácticas redondeado a 2 decimales
print(f"Promedio de prácticas: {round(prom_prac, 2)}")

# Mostramos el promedio final redondeado a 2 decimales
print(f"Promedio final: {round(prom_final, 2)}")

# Clasificamos el promedio final según los rangos dados
# Empezamos por el valor más alto
if prom_final >= 18:
    print("Excelente")
elif prom_final >= 14:
    print("Bueno")
elif prom_final >= 10:
    print("Regular")
else:
    print("Deficiente")