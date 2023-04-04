using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            Queue obj1 = new Queue();
            obj1.Enqueue("Miguel");
            obj1.Enqueue("Rafael");
            obj1.Enqueue("Antonio");
            obj1.Enqueue("Luis");
            obj1.Enqueue("Enrique");

            Console.WriteLine("Numero de elementos: {0}", obj1.Count);

            foreach(string temp in obj1){
                Console.WriteLine("Valor: " + temp);
            }

            // Crear una tabla
            object[] copiaCola = new object[5];
            // transforme cola en array desde index 0
            obj1.CopyTo(copiaCola, 0);   

            for(int i=0; i<5; i++){
                Console.WriteLine("Valor Array: " + copiaCola[i]);
            }

            for(int i=0; i<5; i=i+2){
                Console.WriteLine("Valor ImPar: " + copiaCola[i]);
            }
            
            for(int i=1; i<5; i=i+2){
                Console.WriteLine("Valor Par: " + copiaCola[i]);
            }

            foreach(string temp in copiaCola){
                Console.WriteLine("Imprimiendo Array: " + temp);
            }

        } 
    }
}