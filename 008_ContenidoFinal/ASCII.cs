using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Codigo ASCII");

            for(byte a=33; a<=126; a++){
                Console.Write((char)a);
                Console.WriteLine(" => " + (a) );
            }

        } 
    }
}