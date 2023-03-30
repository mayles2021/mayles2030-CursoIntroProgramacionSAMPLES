using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static string NombreApp = "Pre-Examen";
        static int edad = 48;

        static void Main(string[] args) 
        { 

            Console.WriteLine("Contenido Var: " + NombreApp);
            string nombre = "MJ";
            Console.WriteLine("Contenido Var: " + nombre);
            sumar();

            void sumar(){
                int a = 3;
                int b = 5;

                Console.WriteLine("suma es: " + (a+b));
            }

        } 

        private void Saludar(){

        }
    }
}