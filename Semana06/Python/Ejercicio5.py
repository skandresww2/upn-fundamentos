saldo = float(input("Depósito inicial: S/"))
meta = float(input("Meta a alcanzar: S/"))

tasa = 0.015     # 1.5% mensual
meses = 0        # contador de meses

print(f"Mes 0: S/{saldo:.2f}")   # estado inicial

# Continúa mientras el saldo aún no llegue a la meta
while saldo < meta:
    # Interés compuesto: capital crece sobre sí mismo cada mes
    saldo = saldo + saldo * tasa
    meses += 1
    print(f"Mes {meses}: S/{saldo:.2f}")

print(f"Alcanzará la meta en {meses} meses.")