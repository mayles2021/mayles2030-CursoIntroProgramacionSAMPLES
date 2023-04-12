using System;
namespace HelloWorld 
{ 
    class Delfin 
    { 
        public string nombre;       // Propiedades de la clase
        public int velocidadNadar;  // Propiedades de la clase

        private int edad = 3;
        public int edad2 = 4;
        private double PI = 3.1416;

        // metodos => procedimiento o funciones que MAIN()
        public void Saludar(){
            Console.WriteLine("Hola soy Flipper");
        }

        public void ShowInfo(){
            Console.WriteLine("Valor de edad: " + edad);
        }

    }
}