using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            
            // // // Aleatorio
            // Random r1 = new Random();
            // int num1 = r1.Next(1,99);
            // Console.WriteLine(num1);

            // // Loteria AUTO
            // Random r2 = new Random();

            // for(int j=0; j<=6; j++){
            //     // Console.WriteLine("hola");
            //     // Console.WriteLine("valor: " + r2.Next(1,49));
            //     // Console.WriteLine("valor: " + r2.NextDouble());
            //     Console.WriteLine("valor: " + r2.Next(100,300));

            // }



            // Math => Funciones matemáticas

            // Calculo num maximo
            int a = 10;
            int b = 5;
            if ( a > b )
                Console.WriteLine("mayor es a " + a);


            // FuncionMax
            Console.WriteLine("max " + Math.Max(10,5));
            Console.WriteLine("min " + Math.Min(10,5));
            Console.WriteLine("Raiz cuadrada " + Math.Sqrt(25));
            Console.WriteLine("Valor ABS " + Math.Abs(-4.7));
            Console.WriteLine("Redondear " + Math.Round(9.99));
            Console.WriteLine("Redondear " + Math.Round(4.3));
            Console.WriteLine("Redondear " + Math.Round(4.51));
            



        }
    }
}