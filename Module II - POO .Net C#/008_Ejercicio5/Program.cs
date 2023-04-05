using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            Console.Clear();
            Console.WriteLine("Ejercicio 5 \n\n");

            // stack obj1 = new stack();
            Tuple<string, double> obj1 = new Tuple<string, double>("Miguela", 9.5D);

            if(obj1.Item1 == "Miguel" && obj1.Item2 >= 5){
                Console.WriteLine("Bienvenido al curso: " + obj1.Item1);
                Console.WriteLine("Haz superado el curso: " + obj1.Item2);
            }

            Tuple<string, string, int> obj2 = new Tuple<string, string, int>("MJ", "Singer", 7);
            Tuple<string, string, int> obj3 = new Tuple<string, string, int>("Madonna", "Singer", 3);
            Tuple<string, string, int> obj4 = new Tuple<string, string, int>("Santana", "Singer", 2);

            Console.WriteLine(obj4.Item3);

        } 
    }
}