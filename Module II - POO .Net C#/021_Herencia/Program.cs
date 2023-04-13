using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
                Animal obj1 = new Animal();
                obj1.edad = 3;
                obj1.peso = 10;
                Console.WriteLine("Edad: " + obj1.edad);

                Perro obj2 = new Perro();
                obj2.edad = 3;
                obj2.peso = 10;
                Console.WriteLine("Edad: " + obj2.edad);
        } 
    }



    class Animal{
        public int edad;
        public int peso;
    }

    class Perro : Animal{
        public int numpatas;
        public string nombre;
    }






}