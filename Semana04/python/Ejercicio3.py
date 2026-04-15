# Pedimos los datos al usuario
peso = float(input("Ingrese el peso en kg: "))
estatura = float(input("Ingrese la estatura en metros: "))

# Fórmula del IMC: peso / estatura²
# En Python, ** significa "elevado a"
imc = peso / (estatura ** 2)

# Redondeamos el resultado a 2 decimales
imc_red = round(imc, 2)

# Mostramos el IMC
print(f"IMC: {imc_red}")

# Clasificamos según los rangos dados
if imc < 18.5:
    print("Bajo peso")
elif imc < 25:
    print("Normal")
elif imc < 30:
    print("Sobrepeso")
else:
    print("Obesidad")