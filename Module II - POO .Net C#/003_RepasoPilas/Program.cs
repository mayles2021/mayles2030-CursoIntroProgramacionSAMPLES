using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // Pilas
            Stack obj1 = new Stack();
            obj1.Push("Plato1");
            obj1.Push("Plato2");
            obj1.Push("Plato3");
            obj1.Push("Plato4");
            obj1.Push("Plato5");

            // Numero de elementos
            Console.WriteLine("Numero Elementos: " + obj1.Count);

            // Recorrer los elementos
            foreach(string Temp in obj1){
                Console.WriteLine("Valores Primera Vez: " + Temp);
            }

            // Quitar elementos
            obj1.Pop();
            obj1.Pop();
            Console.WriteLine("Limpiando Plato" + obj1.Pop());

            // Recorrer los elementos
            foreach(string Temp in obj1){
                Console.WriteLine("Valores Segunda Vez: " + Temp);
            }

            PrintVales(obj1);

            void PrintVales(IEnumerable ObjTemp){
                foreach(string Temp in ObjTemp){
                    Console.WriteLine("Valores Tercera Vez: " + Temp);
                } 
            }


        } 
    }
}