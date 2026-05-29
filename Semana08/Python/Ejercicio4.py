# Variable global porque representa una regla fija del programa
TIPO_CAMBIO = 3.75

# Variable global para la comisión del 2 %
PORCENTAJE_COMISION = 0.02


# Función con retorno: calcula el 2 % del monto ingresado
def calcular_comision(soles):
    comision = soles * PORCENTAJE_COMISION
    return comision


# Función con retorno: resta la comisión al monto inicial
def calcular_soles_netos(soles, comision):
    soles_netos = soles - comision
    return soles_netos


# Función con retorno: convierte los soles netos a dólares
def convertir_a_dolares(soles_netos):
    dolares = soles_netos / TIPO_CAMBIO
    return dolares


# Procedimiento: no retorna valor, solo muestra el comprobante
def mostrar_comprobante(soles, comision, soles_netos, dolares):
    print("\n=== COMPROBANTE ===")
    print(f"Monto ingresado: S/{soles:.2f}")
    print(f"Comisión (2%): S/{comision:.2f}")
    print(f"Soles netos a cambiar: S/{soles_netos:.2f}")
    print(f"Dólares recibidos: ${dolares:.2f}")


# Programa principal
print("=== CASA DE CAMBIO ===")

soles = float(input("Ingrese monto en soles: S/"))

# Llamamos a la función que calcula la comisión
comision = calcular_comision(soles)

# Llamamos a la función que calcula los soles disponibles después de descontar comisión
soles_netos = calcular_soles_netos(soles, comision)

# Llamamos a la función que convierte soles netos a dólares
dolares = convertir_a_dolares(soles_netos)

# Llamamos al procedimiento que muestra el comprobante
mostrar_comprobante(soles, comision, soles_netos, dolares)