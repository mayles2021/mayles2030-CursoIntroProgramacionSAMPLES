using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        // Var Staticas
        
        // Var Staticas

        static void Main(string[] args) 
        { 
            Console.WriteLine("Hello World!"); 
            function1_Saludar();
            function1_Saludar();
            function1_Saludar();

            Console.ReadKey();
            
            funcion2_CalcularAprobado();
            funcion3_CalcularDoble(8);
            int numeroNota = 10;
            funcion3_CalcularDoble(numeroNota);

            Console.WriteLine("Pulsar una tecla para continuar...");
            Console.ReadKey();


            // Funciones y Procedimientos

                void function1_Saludar(){   // Procedimiento ya que tiene void y no return
                    Console.WriteLine("Hola Miguel, buenos dias");
                    Console.WriteLine("Bienvenido al curso");
                }

                void funcion2_CalcularAprobado(){     // Procedimiento
                    int varTemp1 = 5;
                    if ( varTemp1 >= 5){
                        Console.WriteLine("Aprobado");
                    } else {
                        Console.WriteLine("Suspenso");
                    }
                }

                void funcion3_CalcularDoble(int TempVar){      // Procedimiento
                    Console.WriteLine(TempVar*2);
                }


            // Funciones y Procedimientos
            
        } 

        // Metodos

        // Metodos
        
    }
}