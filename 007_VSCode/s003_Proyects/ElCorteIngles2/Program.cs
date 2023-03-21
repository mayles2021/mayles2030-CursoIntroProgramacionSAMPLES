using System;

namespace ElCorteIngles2
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Datos de Artistas");

        string name = "Michael";
        string surname = "Jackon";
        int edad = 50;
        string styleMusic = "POP";
        string nameDisc = "BAD";
        double priceDisc = 10.55D;
        char letterDisc = 'A';          // A internacional, B nacional
        bool stockDisc = true;

        Console.WriteLine("Info");
        Console.WriteLine("Artista: " + name + " " + surname);
        Console.WriteLine("Disco: " + nameDisc + " " + styleMusic);
        Console.WriteLine("Precio: " + priceDisc + "€ " + stockDisc);
        
    }
    }
}