monto = float(input('Ingrese el monto de la compra S/.: '))
dsct = 0

if monto >= 100:
    dsct = monto*0.10

total = monto - dsct

print(f"Descuento aplicado: S/. {round(dsct,2)}")
print(f"Total a pagar : S/. {round(total,2)}")