using System;
using System.Collections.Generic;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            //          // key, value
            // Dictionary<int, string> numberNames = new Dictionary<int, string>();
            // numberNames.Add(1, "One");      // 0
            // numberNames.Add(2, "Two");      // 1
            // numberNames.Add(3, "Three");    // 2

            // // Borrado
            // numberNames.Remove(3);          // Borra el dato 3 key

            // // Recorrer diccionarios
            // foreach (KeyValuePair<int, string> gato in numberNames){
            //     Console.WriteLine("Key: " + gato.Key + " - value: " + gato.Value);
            // }


            // key string, value string
            var cities = new Dictionary<string, string>(){
                // {"string", "string"},
                {"UK", "London"},
                {"USA", "Chicago"},
                {"India", "New Delhi"}
            };

            foreach (KeyValuePair<string, string> gato in cities){
                 Console.WriteLine("Key: " + gato.Key + " - value: " + gato.Value);
             }

             cities.Remove("India");        // LLave de borrado
             // value => KeyNotFoundException

            foreach (KeyValuePair<string, string> gato in cities){
                 Console.WriteLine("Key: " + gato.Key + " - value: " + gato.Value);
             }

             if ( cities.ContainsKey("France")){
                Console.WriteLine("Si existe");
             } else {
                Console.WriteLine("No existe");   
             }

             cities.Clear();            // Clear All elements




        } 
    }
}