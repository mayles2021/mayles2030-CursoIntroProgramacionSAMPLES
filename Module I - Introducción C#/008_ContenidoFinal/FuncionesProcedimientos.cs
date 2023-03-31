using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            // Procedimiento
            void DardoblePROC(int Temp){
                Console.WriteLine(Temp*2);
            }

            // Funcion
            int Dardoble(int Temp){
                return (Temp*2);
            }

            Dardoble(2);                            // LLamada Funcion
            Console.WriteLine(Dardoble(2));         // Imprime lo que recibe return
            DardoblePROC(8);                        // LLamada Procedimiento
            

        } 


    }
}