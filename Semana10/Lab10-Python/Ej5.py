# Función con retorno.
# Calcula el porcentaje de asistencia de una sesión.
def calcular_porcentaje(presentes, matriculados):
    return presentes * 100 / matriculados


print("=== CONTROL DE ASISTENCIA A TALLER ===")

# Acumulador de los porcentajes de las 4 sesiones.
suma_porcentajes = 0

# El taller tiene exactamente 4 sesiones.
for sesion in range(1, 5):
    print(f"\nSesión {sesion}")

    # Cantidad de estudiantes que asistieron.
    presentes = int(input("Estudiantes presentes: "))

    # Cantidad total de estudiantes matriculados.
    matriculados = int(input("Estudiantes matriculados: "))

    # Calculamos el porcentaje de asistencia de la sesión actual.
    porcentaje = calcular_porcentaje(presentes, matriculados)

    # Sumamos el porcentaje al acumulador.
    suma_porcentajes += porcentaje

    # Mostramos el porcentaje de la sesión.
    print(f"Porcentaje de asistencia: {porcentaje:.2f}%")

# Calculamos el promedio de las 4 sesiones.
promedio = suma_porcentajes / 4

print(f"\nPromedio de asistencia: {promedio:.2f}%")

# Si el promedio es al menos 75%, la participación es adecuada.
if promedio >= 75:
    print("Participación adecuada")
else:
    print("Reforzar asistencia")