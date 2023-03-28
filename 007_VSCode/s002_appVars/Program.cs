using System;

namespace App1
{
    public class Program
    {
    public static string nameUser = "Miguel";

    public static void saludoTest(){
        Console.WriteLine("Hello World");
    }
    public static void saludoNameTest(string nameTemp){
        Console.WriteLine("Hello World, " + nameTemp);
    }

    public static int sumaEnteros(int num1, int num2){
        return num1+num2;
    }
    
    static void Main()
    {
        // Variables Estaticas
        Console.WriteLine("Valor: " + nameUser);

        saludoTest();
        saludoNameTest("Alicia");
        Console.WriteLine(sumaEnteros(2,3));

        // Variables de Instancia de otra clase mismo file
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model

        // Variablles de Instancia de otra clase otro file
        ClientesPrueba obj1 = new ClientesPrueba();
        Console.WriteLine(obj1.saludo());

        // Variables de Instancia de otra clase otro file
        Client obj2 = new Client();
        obj2.name = "Juaquin";
        obj2.surname = "Sabina";
        obj2.age = 60;
        Console.WriteLine(obj2.saludo());




        // Parametros de referencia
        int[] array1 = { 1, 2, 3, 4, 5};
        Console.WriteLine("Primer elemento: " + array1[0]);

        Change(ref array1);


        // Esperar para finalizar la aplicacion
        Console.Read();
    
    }
    
    public static void Change(ref int[] Array){
        Console.WriteLine(Array[0]); 

        Array[0] = 100;
        Console.WriteLine(Array[0]);    

        Array = new int[5] { -3, -2, -1, 0, 1 };
        Console.WriteLine(Array[0]);    
        
    }


    }

    
    class Car
    {
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }
    }
    // Outputs "Mustang"


}