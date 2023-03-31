using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            CarBasic obj1 = new CarBasic();
            obj1.acelerar();
            obj1.frenar();
            obj1.cargarObjetos();
            obj1.setCarburante();
            obj1.GetCarburante();


            // Coche car1 = new Coche();
            // car1.ShowInfo();
            // car1.ChangeNumPuertas();
            // car1.ShowInfo();
            // Console.ReadKey();
            
            // Console.WriteLine(car1.GetMarca());
            // car1.ShowInfo();
            // Console.ReadKey();

            // car1.arrancarCarF(true);
            // bool arrancadoCoche = car1.arrancarCarF(true);
            // Console.WriteLine(arrancadoCoche);
            // Console.ReadKey();
            
            // car1.ShowInfo();
            // Console.ReadKey();
        } 
    }
}