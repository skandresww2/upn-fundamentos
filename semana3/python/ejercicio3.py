# Importamos el módulo math, que contiene funciones matemáticas
# como sqrt (raíz cuadrada), pow (potencia), pi, etc.
# A diferencia de C# donde Math está disponible siempre,
# en Python hay que pedirlo explícitamente con "import".
import math

# ── Entrada ────────────────────────────────────────────────────
# Pedimos las 4 coordenadas. Usamos float() porque las
# coordenadas pueden tener decimales (ej: 1.5, -2.3).
x1 = float(input('x1: '))
y1 = float(input('y1: '))
x2 = float(input('x2: '))
y2 = float(input('y2: '))

# ── Proceso ────────────────────────────────────────────────────
# Paso 1: calcular las diferencias en cada eje (los "catetos").
dx = x2 - x1   # diferencia horizontal
dy = y2 - y1   # diferencia vertical

# Paso 2: aplicar Pitágoras → d = √(dx² + dy²)
# En Python tenemos DOS formas de elevar al cuadrado:
#   a) dx ** 2     ← operador ** (potencia), nativo de Python
#   b) math.pow(dx, 2)  ← función equivalente a Math.Pow de C#
# Usamos ** porque es más corto y "pythónico". Las dos dan lo mismo.
# math.sqrt(x) calcula la raíz cuadrada, equivalente a Math.Sqrt de C#.
distancia = math.sqrt(dx ** 2 + dy ** 2)

# ── Salida ─────────────────────────────────────────────────────
# Formato :.2f → muestra el resultado con 2 decimales.
print(f'Distancia entre los puntos: {distancia:.2f}')