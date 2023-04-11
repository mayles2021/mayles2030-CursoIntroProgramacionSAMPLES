using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        public static string nombre;

        static void Main(string[] args) 
        { 
                Hijo obj1 = new Hijo();
                obj1.Saludar();
                obj1.nombre = "Miguel";
                obj1.edad = 48;

                Padre obj2 = new Padre();
                obj2.nombre = "Manuel";
                Console.WriteLine("Mi padre se llama " + obj2.nombre);
        } 
    }






    // Crear Clase Padre
    class Padre{
        public string nombre;
        public int edad;

        public void Saludar(){
            Console.WriteLine("Hola soy tu padre");
        }
    }

    class Hijo : Padre{

    }
}