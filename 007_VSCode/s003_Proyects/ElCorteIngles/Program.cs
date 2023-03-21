using System;

namespace HelloWorld
{
    class Hello {         
        static void Main()
        {

            // Guardar en 2 variables nombre y apellido de cantante
            // Mostrar valores de nombre y apellido

            string name = "Michael";
            string surname = "Jackson";

            Console.WriteLine("Artista: " + name + " " + surname);

            // Guardar en 3 variables tres valores
            // Se imprimiran las suma, resta, multiplicacion y 2division

            int var1 = 5;
            int var2 = 10;
            int var3 = 15;
            Console.WriteLine("suma: " + (var1+var2+var3));
            Console.WriteLine("Resta: " + ((var1-var2)-var3));
            Console.WriteLine("Multiplicacion: " + (var1*var2*var3));
            Console.WriteLine("Division: " + (var2/var1));

            // Prueba de división

            int tempResultado = var2 / var1;
            Console.WriteLine(tempResultado);

            // Mensaje, recibir por teclado y mostrar

            Console.WriteLine("Introducir su edad: ");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Su edad es: " + x);
        }
    }
}