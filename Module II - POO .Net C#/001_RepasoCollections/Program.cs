using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        public enum Days{
        Monday,  
        Tuesday,  
        Wednesday,  
        Thursday,  
        Friday,  
        Saturday,  
        Sunday            
        }

        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 
        
            // Crear una enumeracion con los dias de la semana
            // Imprimir 3 de sus valores

            Console.WriteLine("Dato: " + Days.Monday);
            Console.WriteLine("Dato: " + Days.Wednesday);
            Console.WriteLine("Dato: " + Days.Friday);

            // Imprimir el indice de los valores

            Console.WriteLine("Dato: " + (int)Days.Monday);
            Console.WriteLine("Dato: " + (int)Days.Wednesday);
            Console.WriteLine("Dato: " + (int)Days.Friday);

            int mondayValue = (int)Days.Monday;
            Console.WriteLine("Valor Indice: " + mondayValue);

            int mondayValue2 = Convert.ToInt32(Days.Monday);
            Console.WriteLine("Valor Indice2: " + mondayValue2);


        
        } 
    }
}