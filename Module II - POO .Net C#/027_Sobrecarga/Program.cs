using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 

            // Polimorfismo 
                Perro perro1 = new Perro();
                Console.WriteLine("perro1: " + perro1.Ladrar());

                chihuahua perro2 = new chihuahua();
                Console.WriteLine("perro2: " + perro2.Ladrar());

                Bulldog perro3 = new Bulldog();
                Console.WriteLine("perro3: " + perro3.Ladrar());
            // Polimorfismo 


            // HerenicaMultiple
                Model2 herenciaMulti1 = new Model2();
                herenciaMulti1.val1 = 3;
                herenciaMulti1.val2 = 5;
                herenciaMulti1.val3 = 7;
                Console.WriteLine("Valor Total: " + (herenciaMulti1.val1 + herenciaMulti1.val2 + herenciaMulti1.val3));
            // HerenicaMultiple


            // // Ejemplo de Composición
            //     Car obj1 = new Car();
            //     obj1.AddWheelToWheels();
            //     obj1.AddWheelToWheels();
            //     obj1.AddWheelToWheels();
            //     obj1.AddWheelToWheels();
            //     Console.WriteLine(obj1.CheckWheels());
            // // Ejemplo de Composición


            // // Ejemplo de Agregación
            //     Customer obj2 = new Customer();
            //     obj2.AddItemToOrder();
            //     obj2.AddItemToOrder();
            //     Console.WriteLine(obj2.CheckItems());
            // // Ejemplo de Agregación

        } 
    }
}