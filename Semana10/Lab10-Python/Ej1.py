# Función que calcula el salario de un obrero.
# Recibe:
# valor_hora: cuánto se paga por cada hora.
# horas: cantidad de horas trabajadas en el mes.
def calcular_salario(valor_hora, horas):

    # Si trabajó 192 horas o menos,
    # todas las horas se pagan con tarifa normal.
    if horas <= 192:
        return valor_hora * horas

    # Si el programa llega aquí, significa que hay horas extra.

    # Calculamos las horas que exceden las 192 horas normales.
    horas_extra = horas - 192

    # Pago correspondiente a las primeras 192 horas.
    pago_normal = valor_hora * 192

    # Pago de las horas extra con 50% adicional.
    # 1.50 significa 150% del valor normal.
    pago_extra = horas_extra * valor_hora * 1.50

    # Retornamos el salario total.
    return pago_normal + pago_extra


print("=== PLANILLA INDUSTRIAL ===")

# Pedimos la cantidad de obreros que se registrarán.
n = int(input("Cantidad de obreros: "))

# Acumulador para sumar todos los salarios.
total_planilla = 0

# El range(1, n + 1) permite contar desde 1 hasta n.
for i in range(1, n + 1):
    print(f"\nObrero {i}")

    # Entrada del valor por hora.
    vh = float(input("Valor por hora: S/"))

    # Entrada de horas trabajadas.
    hmt = int(input("Horas trabajadas: "))

    # Llamamos a la función para calcular el salario.
    salario = calcular_salario(vh, hmt)

    # Acumulamos el salario en el total de la planilla.
    total_planilla += salario

    # Mostramos el salario individual.
    print(f"Salario: S/{salario:.2f}")

# Mostramos el total acumulado de la planilla.
print(f"\nTotal de planilla: S/{total_planilla:.2f}")