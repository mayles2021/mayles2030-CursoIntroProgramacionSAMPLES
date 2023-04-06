using System;
using System.Collections;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            // Listas + TipoDatos
            List<string> obj1 = new List<String>();
            string[] objString = new string[5];

            // Añadir datos al array modelos coches
            objString[0] = "BMW";
            objString[1] = "Renault";
            objString[2] = "Citroen";
            objString[3] = "Mercedes";
            objString[4] = "Ferrari";

            // Imprimir
            for(int i=0; i<=4; i++){
                Console.WriteLine("Valor: " + objString[i]);
            }

            // Rellenar Lista con los valores array
            obj1.AddRange(objString);

            // Imprimir Lista
            foreach(string x in obj1) {
                Console.WriteLine(x);
            }
            Console.ReadKey();

        } 
    }
}