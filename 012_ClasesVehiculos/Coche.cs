using System;
namespace HelloWorld 
{ 
    class Coche 
    { 
        static string marca = "Seat";
        static string modelo = "Ibiza";
        static int numpuertas = 3;

        static bool arrancarCar = false;

        public void ShowInfo(){
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Numero de Puertas: " + numpuertas);
            Console.WriteLine("Coche Arrancado: " + arrancarCar);
        }

        public void ChangeNumPuertas(){
            numpuertas = 5;
        }

        public string GetMarca(){
            return marca;
        }

        public bool arrancarCarF(bool arrancar){
            arrancarCar = true;
            return arrancar;
        }
    }
}