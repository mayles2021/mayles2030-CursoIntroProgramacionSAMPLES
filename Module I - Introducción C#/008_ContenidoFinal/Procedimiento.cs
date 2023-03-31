using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

// Procedimientos 

            // Funcion que no devuelve valor "PROCEDIMIENTO"
            void DarDoble(int TempNum){
                Console.WriteLine(TempNum*2);
            }

            // Llamar Procedimiento
            int temp1 = 8;
            DarDoble(temp1);

// Procedimientos 


            // Variables
            int num1 = 5;
            Console.WriteLine("valor1 => " + (num1*2));
            Console.WriteLine("valor2 => " + (2*num1));

        } 
    }
}