using System;
namespace HelloWorld {

    class AnimalDelfin{

        public static string NombreAnimal = "Flipper";

        // Metodo, ya no se puede decir funcion o procedimiento
        public void Saludar(){
            Console.WriteLine("Hola soy un Delfin, me llamo " + NombreAnimal);
        }

        // Metodo2
        public void Nadar(){
            Console.WriteLine("Estoy Nadando ...");
        }
        
        // Metodo3
        public void Bucear(){
            Console.WriteLine("Estoy Buceando ...");
        }

    }

}