# Son estructuras de datos que pueden almacenar
# cualquier otro datos

# lista de enteros
calificaciones = [10, 9, 8, 7, 5]
print(calificaciones)

# Lista de string
nombres = ["Ana", "Juan", "Sofia", "Pablo", "Pepe"]
print(nombres)

# Lista de diferentes tipos de datos
mezclaValue = [ True, 10.5, "abc", [0,1,2]]
print(mezclaValue)

# indices de Listas
print("Nombre: ", nombres[2])       # sofia
print("Nombre: ", nombres[-1])      # Pepe ( ultimo )
print("Values: ", mezclaValue[2])   # abc

# Añadir elementos
nombres.append("Miguel")
nombres.append("Rafael")
print(nombres)

# Borrar elementos
nombres.remove("Rafael")
print(nombres)

# Convertir una lista en una tupla
print(tuple(nombres))











# From List to Tupla
print(tuple(nombres))

