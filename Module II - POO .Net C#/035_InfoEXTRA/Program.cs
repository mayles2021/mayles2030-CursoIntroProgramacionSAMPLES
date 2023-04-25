using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 

            SaveToFile obj1 = new SaveToFile();
            // obj1.showDate();
            obj1.ShowTime();

            // obj1.deleteFile();
            // obj1.copyFile();
            // obj1.moveFile();
            // obj1.Save("Miguel");
            // obj1.Save("Antonio");
            // obj1.Save("Francisco");
            // obj1.Save("Pepe");
        } 
    }
}