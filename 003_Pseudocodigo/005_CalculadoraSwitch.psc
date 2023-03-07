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
	
	Segun Operador Hacer
		"+":
			Escribir "suma:", ( Num1 + Num2)
		"-":
			Escribir "Resta:", ( Num1 - Num2 )	
		"/":
			Escribir "División:", ( Num1 / Num2)
		"*":
			Escribir "Multiplicacion:", ( Num1 * Num2 )	
		De Otro Modo:
			Escribir "Operador Incorrecto"
	FinSegun
FinAlgoritmo
