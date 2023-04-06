using System;
using System.Collections;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
             // Stack obj1 = new Stack();       // Ejemplo   
             ArrayList obj1 = new ArrayList();

             // Meter datos
             obj1.Add("Pan");
             obj1.Add("Lechuga");
             obj1.Add("Leche");
             obj1.Add("Huevos");

            // Imprimir
            foreach(string x in obj1){
                Console.WriteLine("Cosas a comprar en el super: " + x);
            }

            // Quitar elementos de la Lista
            obj1.Remove("Leche");
            obj1.RemoveAt(0);           // Pan

            // Imprimir
            
            Console.WriteLine("==================================");
            foreach(string x in obj1){
                Console.WriteLine("Cosas a comprar en el super: " + x);
            }


        } 
    }
}