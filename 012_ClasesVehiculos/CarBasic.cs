using System;
namespace HelloWorld 
{ 
    class CarBasic 
    { 
        
        static string modeloCar = "Citroen Sara Picasso";
        enum carburante { gasolina, diesel };
        static string carburanteCar = "";

        double TestDecimal = 15.859899988D;

        public void acelerar(){
            Console.WriteLine("El coche puede acelerar");
            Console.WriteLine($"{TestDecimal:F7}");
        }

        public void setCarburante(){
            carburanteCar = carburante.diesel.ToString();
        }
        
        public void frenar(){
            Console.WriteLine("El coche puede frenar");
        }
        
        public void cargarObjetos(){
            Console.WriteLine("El coche puede cargarObjetos");
        }

        public void GetCarburante(){
            Console.WriteLine("El carburante es: " + carburanteCar);
        }

    }
}