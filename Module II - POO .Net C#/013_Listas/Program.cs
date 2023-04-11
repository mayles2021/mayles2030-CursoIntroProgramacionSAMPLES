using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           // Lista de entero con 5 valores
           List<int> list = new List<int>();

           // Añadir los elementos
           list.Add(1);
           list.Add(2);
           list.Add(2);
           list.Add(4);
           list.Add(5);

           // Borrado de elementos REPETIDOS
           list.RemoveAll(item => item == 2);

           foreach(int num in list){
                Console.WriteLine("Value: " + num);
           }

           // Preguntas
           Console.WriteLine("Si contiene: " + list.Contains(1));

           // Encontrar elementos FIND
           List<string> listCoches = new List<string>() { "BMw", "Citroen", "Seat" };
           listCoches.Add("Twingo");

           foreach(string num in listCoches){
                Console.WriteLine("Value: " + num);
           }

           Console.WriteLine("Found Car:" );
           Console.WriteLine(listCoches.Find(marca => marca == "Citroen"));

           List<string> ListFound = 
                listCoches.FindAll(elemento => elemento.Contains("w"));

           foreach(string num in ListFound){
                Console.WriteLine("Value: " + num);
           }


           // Comparar elementos de 2 listas
        List<string> first = new List<string>() { "A", "B", "C" };
        List<string> second = new List<string>() { "A", "B", "C" };
        bool isEqual = first.SequenceEqual(second);
        Console.WriteLine(isEqual);        // True

        } 
    }
}