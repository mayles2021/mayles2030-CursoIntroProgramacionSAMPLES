# clave : valor
# nombre : "Miguel"

edades = { "juan" : 22, "juana" : 23, "juanita" : 43}
print(edades)

# Imprimir solo las llaves
print(edades.keys())

# Imprimir solo los valores
print(edades.values())

# Añadir elementos
edades["Miguel"] = 48
print(edades)

# Modificar elementos
edades["Miguel"] = 22
print(edades)

# Borrar elementos  
del edades["Miguel"]
print(edades)