Algoritmo sin_titulo
	
	a <- 33	// 100 // 26 // 18 // 9 // 1500	// 200
	b <- 1	// 10	// 4 // 9 // 3 	// 32      // 3
	Definir mayor Como real
	Definir menor Como real
	
	si ( a > b )
		mayor <-a
		menor <-b
	sino 
		mayor <-b
		menor <-a
	FinSi
	
	Escribir "El mayor es ", mayor
	Escribir "El menor es ", menor
	
	Mientras (menor <> 0) Hacer
		
		Escribir  "mayor ", mayor, " Dividido por ", menor
		
		r = mayor mod menor		// Te quedas con el resto
		
		Escribir "Da como resto ", r
		
		mayor = menor				// cambias el valor de la variable
		menor = r					// guardas el resto en menor
		
		// Escribir "mayor => ", mayor, " n => menor ", menor, " r => resto ", r
	Fin Mientras
	
	Escribir "Maximo Comun Divisor ", mayor
	
	
FinAlgoritmo
