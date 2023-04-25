using System;
using System.Collections;
namespace HelloWorld 
{ 
    class Test{

        public void TestHashtable(){
            
            // Json
            // Keys : values

            Console.WriteLine("Testeando Hashtable");

            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "uno");
            numberNames.Add(2, "dos");
            numberNames.Add(3, "tres");
            numberNames.Add(4, "cuatro");
            numberNames.Add(5, "cinco");

            numberNames.Remove(5);

            foreach (DictionaryEntry X in numberNames){
                Console.WriteLine("LLave: {0}, value {1}", X.Key, X.Value);
            }

            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "New Delhi, Pune"}
            };

            cities.Remove("UK");                // Borrar el elemento
            cities["India"] = "Mumbai";         // Actualizar el valor


            foreach (DictionaryEntry X in cities){
                Console.WriteLine("LLave: {0}, value {1}", X.Key, X.Value);
            }

            if (!cities.ContainsKey("France"))
                cities["France"] = "Paris";

            Console.WriteLine(cities.Count);


            foreach (DictionaryEntry X in cities){
                Console.WriteLine("LLave: {0}, value {1}", X.Key, X.Value);
            }

        }
    }
}