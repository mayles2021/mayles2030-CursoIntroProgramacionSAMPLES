using System;
namespace HelloWorld 
{ 
    class Hello 
{ 
        int a;
        int b;

        // Constructor
            public Hello(int x, int y){
                a = x;
                b = y;
            }
        // Constructor

        // Metodos

            public int Suma(){
                return a + b;       // Estaticas, internas de la clase
            }

        // Metodos

        static void Main(string[] args) 
        { 

            Hello obj1 = new Hello(2,3);
            Console.WriteLine(obj1.Suma());

            Taxi obj2 = new Taxi();
            Console.WriteLine("valor Nuevo: " + obj2.IsInitialized);
            Console.WriteLine("valor Nuevo: " + obj2.nombreConductor);

        } 
    }


    public class Taxi{
        public bool IsInitialized = false;
        public string nombreConductor;

        public Taxi(){
            IsInitialized = true; // set => Cambiar
            nombreConductor = "Antonio";
        }
    }
}