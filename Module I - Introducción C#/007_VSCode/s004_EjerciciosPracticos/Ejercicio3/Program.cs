using System;

namespace EjerciciosPracticos
{
    class Program
    {
    static void Main(string[] args)
    {

        int lado = 5;
        Console.WriteLine("Superficie: " + (lado*lado));
        saludar();  // llamar a la funcion
        adios();

        dudaIvan(lado);

    }

    public static void saludar(){
        Console.WriteLine("hola soy un robot");
    }

    public static void adios(){
        Console.WriteLine("Adios, hasta mañana ...");
    }

    public static void dudaIvan(int Tempval1){
        Console.WriteLine("resultado" + (Tempval1*Tempval1));
    }



    }
}