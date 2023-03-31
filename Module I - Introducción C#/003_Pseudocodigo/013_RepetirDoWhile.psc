Algoritmo sin_titulo
	
	// Hacer App contador numerico y controlar acceso
	
	Definir ultimo Como Entero
	Definir contador Como Entero
	
	contador <- 0		// contador = 0
	
	Escribir "Numero de veces a imprimir hola"
	Leer ultimo
	
	Para i<-1 Hasta ultimo con paso 1 Hacer
		Escribir "hola ", i
	FinPara
	
	Repetir
		Escribir "hola"
		contador <- contador + 1
	Hasta Que ultimo = contador;
	
	
	
	
FinAlgoritmo
