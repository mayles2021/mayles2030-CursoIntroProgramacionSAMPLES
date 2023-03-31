using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static void Main(string[] args) 
        { 

            
            int num1 = 5;
            int num2 = 10;


            // App que usando funciones hagan operaciones matematicas
            int suma(int num1, int num2){
                return num1+num2;
            }
            
            int resta(int num1, int num2){
                return num1-num2;
            }

            int multi(int num1, int num2){
                return num1*num2;
            }
            
            int Div(int num1, int num2){
                return num1/num2;
            }

            int ResDiv(int num1, int num2){
                return num1%num2;
            }

            suma(2,3);                      // Valores
            suma(num1, num2);               // variables

            Console.WriteLine(suma(2,3));
            Console.WriteLine(resta(10,5));
            Console.WriteLine(multi(10,5));
            Console.WriteLine(Div(10,5));
            Console.WriteLine(ResDiv(10,5));


        } 

    }
}