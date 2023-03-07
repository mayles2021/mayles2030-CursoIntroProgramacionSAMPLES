Algoritmo sin_titulo
	
	// Tipos de datos Definiciones
	definir Num1 Como real
	definir Num2 Como real
	
	Escribir "Ingrese numero 1:"
	Leer Num1
	
	Escribir "Ingrese numero 2:"
	Leer Num2
	
	Escribir "Ingrese Operador (+, -, /, *)"
	Leer Operador
	
	Si Operador = "+" Entonces
		resultado = Num1 + Num2
	Fin Si
	
	Si Operador = "-" Entonces
		resultado = Num1 - Num2
	Fin Si
	
	Si Operador = "/" Entonces
		resultado = Num1 / Num2
	Fin Si
	
	Si Operador = "*" Entonces
		resultado = Num1 * Num2
	Fin Si
	
	Escribir "Resultado: ", resultado
	
FinAlgoritmo
