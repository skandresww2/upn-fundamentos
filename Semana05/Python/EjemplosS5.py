def ejemplo01():
    # Leer un número entero y clasificarlo como positivo, negativo o cero
    num = int(input("Ingrese número entero: "))

    if num > 0:
        print("Número positivo.")
    else:
        if num < 0:
            print("Número negativo.")
        else:
            print("Número es CERO.")

def ejemplo02():
    # Mostrar la tabla de multiplicar de un número hasta un límite dado
    base_num = int(input("Número base: "))
    limite = int(input("Hasta (límite del multiplicador): "))

    for i in range(1, limite + 1):
        print(f"{base_num} * {i} = {base_num * i}")


def ejemplo03():
    # Mostrar la potencia al cuadrado de los diez primeros 
    # números naturales
    for i in range(1, 11): #para i desde 1 hasta 10
        resultado = pow(i, 2)
        print(f"{i}^2 = {resultado}")


def ejemplo04():
    # Leer un número entero positivo y mostrar los menores que él
    # en orden descendente hasta llegar a 0
    n = int(input("Ingrese número entero positivo: "))
    
    # para i desde n - 1 hasta 0, decrementando de 1 en 1
    for i in range(n - 1, -1, -1): #range(inicio, fin, paso)
        print(i)


if __name__ == "__main__":
    # Descomenta el ejemplo que quieras ejecutar

    # ejemplo01()
    #ejemplo02()
    #ejemplo03()
    ejemplo04()