# botica.py
# Este archivo funciona como un módulo propio.
# Aquí se agrupan funciones relacionadas con el control de medicamentos.


def esta_vencido(anio_vencimiento, anio_actual):
    # Retorna True si el medicamento está vencido.
    # Está vencido cuando el año de vencimiento es menor al año actual.
    return anio_vencimiento < anio_actual


def mostrar_datos(nombre, marca, anio_vencimiento):
    # Esta función solo muestra información.
    # No retorna ningún valor.
    print("\n=== DATOS DEL MEDICAMENTO ===")
    print(f"Nombre: {nombre}")
    print(f"Marca: {marca}")
    print(f"Año de vencimiento: {anio_vencimiento}")


def mostrar_estado(vencido):
    # Recibe True o False y muestra el estado correspondiente.
    if vencido:
        print("Estado: Medicamento vencido.")
    else:
        print("Estado: Medicamento vigente.")