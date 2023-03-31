using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static void Main(string[] args) 
        { 

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine("Bienvenidos al curso");

            int num;
            Console.WriteLine("Introducir num, por favor");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");                // 3 lineas en blanco
            
            ParImpar(num);            
            Console.WriteLine("Fin de Programa");
            Console.ReadKey();




            void ParImpar(int Tempnum1){
                // Solucion Miguel
                    int x;
                    x = (Tempnum1 % 2);
                    if ( x == 0){
                        Console.WriteLine("Valor Par");
                    } else {
                        Console.WriteLine("Valor ImPar");    
                    }
                // Solucion Miguel

                // Solucion Ivan
                    if (Tempnum1 % 2 == 0){
                        Console.WriteLine("El número " + Tempnum1 + " es par");
                    } else {
                        Console.WriteLine("El número " + Tempnum1 + " es impar");
                    }
                // Solucion Ivan

                // Solucion Paulo
                    string resultado = (Tempnum1 % 2 == 0) ? "Es par" : "Es impar";
                    Console.WriteLine(resultado);
                // Solucion Paulo



            }


            
        } 

        
    }
}