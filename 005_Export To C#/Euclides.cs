// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double a;
			double b;
			double mayor;
			double menor;
			double r;
			// 100 // 26 // 18 // 9 // 1500 // 200
			a = 33;
			// 10 // 4 // 9 // 3  // 32      // 3
			b = 1;
			if ((a>b)) {
				mayor = a;
				menor = b;
			} else {
				mayor = b;
				menor = a;
			}
			Console.WriteLine("El mayor es "+mayor);
			Console.WriteLine("El menor es "+menor);
			while ((menor!=0)) {
				Console.WriteLine("mayor "+mayor+" Dividido por "+menor);
				// Te quedas con el resto
				r = mayor%menor;
				Console.WriteLine("Da como resto "+r);
				// cambias el valor de la variable
				mayor = menor;
				// guardas el resto en menor
				menor = r;
				// Escribir "mayor => ", mayor, " n => menor ", menor, " r => resto ", r
			}
			Console.WriteLine("Maximo Comun Divisor "+mayor);
		}

	}

}

