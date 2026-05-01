edad = int(input("Ingrese la edad: "))

# Validar primero si la edad es correcta
if edad < 0:
    print("Error: la edad no puede ser negativa.")
else:
    # Si la edad está entre 0 y 5 años, viaja gratis
    if edad <= 5:
        print("Resultado: viaja gratis, no requiere medio pasaje.")
    else:
        # Si tiene entre 6 y 17 años, recién evaluamos el carné
        if edad <= 17:
            carnet = input("¿Presenta carné de estudiante? (S/N): ").upper()

            # dentro del caso de edad escolar, evaluamos si tiene carné
            if carnet == "S":
                print("Resultado: sí accede al medio pasaje escolar.")
            else:
                print("Resultado: no accede al beneficio porque no presentó carné.")
        else:
            # Si tiene 18 o más, no aplica el beneficio escolar
            print("Resultado: no accede al medio pasaje escolar por edad.")