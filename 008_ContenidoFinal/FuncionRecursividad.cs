using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // Recursividad
            Console.WriteLine(recursividad1(3));

            // Recursividad
            int recursividad1(int num){
                if (num == 0) return 1;
                return num * recursividad1(num -1);
            }
        } 
    }
}