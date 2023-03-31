using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static void Main(string[] args) 
        { 

            // FUNCION capaz de sumar 3 numeros
            int sumar3Num(int num1, int num2, int num3){
                return num1+num2+num3;
            }

            int result = sumar3Num(3,3,3);
            Console.WriteLine("Resultado: " + result);

        } 

    }
}