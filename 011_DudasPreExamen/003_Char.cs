using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static void Main(string[] args) 
        { 

            // Funciones Char = 'H';
            char ch = '1';
            if (char.IsUpper(ch)){
                Console.WriteLine("Letra en mayusc: " + ch);
            }

            if (char.IsLower(ch)){
                Console.WriteLine("Letra en minusc: " + ch);
            }
            
            if (char.IsDigit(ch)){
                Console.WriteLine("Letra en digito: " + ch);
            } else {
                Console.WriteLine("Letra es caracter: " + ch);
            }

        } 

    }
}