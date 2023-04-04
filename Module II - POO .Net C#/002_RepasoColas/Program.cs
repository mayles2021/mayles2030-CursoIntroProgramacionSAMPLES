using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            // Crear un objeto o instanciar un objeto
            // Crear una copia de una clase
            Queue cola1 = new Queue();
            cola1.Enqueue("Amanda");
            cola1.Enqueue("Vinicius");
            cola1.Enqueue("Adrian");
            cola1.Enqueue("Ivan");
            cola1.Enqueue("Tamara");


            // Similitud a un array "Almacen de Datos"
            // string[] prueba = new string[5];


            // Saber num elementos de la cola
            int totalCola = cola1.Count;
            Console.WriteLine("Numero de elementos: " + totalCola);

            foreach(string Temp in cola1){
                Console.WriteLine("Valor:" + Temp);
            }

            // Interrupción I
            Console.ReadKey();

            // Primer elemento para abandonar la cola
            string nextValue = cola1.Peek().ToString();
            Console.WriteLine("Proximo: " + nextValue);
            Console.ReadKey();

            // Eliminar el primero de la cola
            Console.WriteLine("Cafe entregado:" + cola1.Dequeue());
            Console.WriteLine("Cafe entregado: '{0}'", cola1.Dequeue());
            Console.WriteLine($"Cafe entregado: {cola1.Dequeue()}");

            // cola1.Dequeue();
            PrintValues(cola1);
            // foreach(string Temp in cola1){
            //     Console.WriteLine("Valor1:" + Temp);
            // }

            cola1.Dequeue();
            PrintValues(cola1);
            // foreach(string Temp in cola1){
            //     Console.WriteLine("Valor2:" + Temp);
            // }

            void PrintValues(IEnumerable myCollectionTemp){
                foreach(string Temp in myCollectionTemp){
                    Console.WriteLine("Valor2:" + Temp);
                }
            }


        } 
    }
}