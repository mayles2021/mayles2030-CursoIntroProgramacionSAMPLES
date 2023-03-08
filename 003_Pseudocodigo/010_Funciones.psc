
Funcion Saludar
	Escribir "Hola mundo!"
FinFuncion

// funcion que recibe un argumento por valor, y devuelve su doble
Funcion res <- CalcularDoble(num) 
	res <- num*2 // retorna el doble
FinFuncion


Algoritmo sin_titulo
	
	
	Escribir "Ingrese un valor numérico para x:"
	Leer x
	
	Escribir "Llamada a la función CalcularDoble (pasaje por valor)"
	Escribir "El doble de ",x," es ", CalcularDoble(x)


FinAlgoritmo
