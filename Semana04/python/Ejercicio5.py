# 1) Solicitar la edad (entero) al usuario
edad = int(input("Ingrese su edad: "))
 
# 2) Condicional DOBLE: if-else cubre los dos casos posibles
if edad >= 18:
    # Rama VERDADERA
    print("Acceso permitido. Bienvenido.")
else:
    # Rama FALSA: calcular años faltantes con valor absoluto
    faltan = abs(18 - edad)
    print("Acceso denegado.")
    print(f"Te faltan {faltan} año(s) para registrarte.")
