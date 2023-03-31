Algoritmo sin_titulo

	Definir a como entero;
	Definir b como entero;
	Definir tb como entero;
	
	Escribir "Ingrese el valor de uno de los numeros a los que sacara el MCD";
	Leer a;
	
	Escribir "Ingrese el valor del otro numero: ";
	Leer b;
	
	Mientras b <> 0 Hacer
		tb <- b;
		b <- a % b;
		a <- tb;
	FinMientras
	
	Escribir "El MCD es :", a;
FinAlgoritmo
