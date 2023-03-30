using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(myInt);
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToInt64(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            Console.WriteLine("Pedir dato: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Pedir dato: ");
            double b = double.Parse(Console.ReadLine());

            double result = a + b;
            Console.WriteLine(result);


        } 
    }
}