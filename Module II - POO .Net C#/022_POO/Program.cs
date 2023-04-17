using System;
namespace HelloWorld
{
    class Car
    {

        static void Main(string[] args)
        {

            Primera obj1 = new Primera();
            Console.WriteLine("Valor1: " + obj1.val1);
            Console.WriteLine("Valor2: " + obj1.val2);
            obj1.Sumar();
            obj1.val1 = 200;
            obj1.val2 = 300;
            Console.WriteLine("SumarImprimir: " + obj1.SumarImprimir());

            Segunda obj2 = new Segunda();
            obj2.sumar(100,200);
            
        }
    }


    class Primera{
        public int val1 = 5;
        public int val2 = 7;

        public void Sumar(){
            Console.WriteLine("Suma: " + (val1+val2));
        }

        public int SumarImprimir(){
            return (val1+val2);
        }

        
    }

    class Segunda{
        public int val3 = 8;

        public void sumar(int val1, int val2){
            Console.WriteLine("Suma: " + (val1 + val2));
        }
    }

}