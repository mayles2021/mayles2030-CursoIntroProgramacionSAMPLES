using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Car obj1 = new Car();
            obj1.AddWheelToWheels();
            obj1.AddWheelToWheels();
            obj1.AddWheelToWheels();
            obj1.AddWheelToWheels();
            obj1.RemoveWheelToWheels();
            Console.WriteLine("Numero de ruedas: " + obj1.CheckWheelsCar());

        } 
    }
}