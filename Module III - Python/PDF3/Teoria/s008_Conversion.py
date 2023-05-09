# Traducir o convertir de un tipo de variable a otra

# int to Float
entero = 50
flotante1 = float(entero)
print(flotante1)

# float to int
entero2 = int(flotante1)
print(entero2)

# int to str
print(str(entero2)) # no podemos hacer calculos matemáticos

# str to int
cadena = "1000"
print(int(cadena))
print(int(cadena)+1)
cadena2 = (int(cadena)+1)
print(cadena2)
print(type(cadena2))
# print(cadena+1)             # error


deletrear = "Estamos dominando Python"
val1 = tuple(deletrear)
print(val1)

val2 = list(deletrear)
print(val2)

print(deletrear[0])
print(deletrear[1])
print(deletrear[2])
print(deletrear[3])

final = int(deletrear.count)
for i in range(final):
    print(deletrear[i])