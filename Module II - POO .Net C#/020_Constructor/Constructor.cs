using System;
namespace HelloWorld 
{ 
    class Constructor
    { 

        public static string nombre;
        public static int edad;

        public Constructor(){
            nombre = "Miguel";
            edad = 48;
        }

        public void VerDatos(){
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
        

    }
}