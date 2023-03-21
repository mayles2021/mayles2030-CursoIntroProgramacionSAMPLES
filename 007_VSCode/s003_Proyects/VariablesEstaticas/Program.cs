using System;

namespace VariablesEstaticas
{
    public class Program
    {
        // Estatica
        public static string name = "Miguel";
        public static string surname = "Jackson";
        public static string styleMusic;
        // Estatica

        static void Main(string[] args)
        {
            
            // Uso de variable static
            Console.WriteLine(name);

            styleMusic = "POP";
            Console.WriteLine("Estilo: " + styleMusic);
            // Uso de variable static

            // Variable Local
            string nameDisc = "BAD";
            Console.WriteLine("Disco: " + nameDisc);
            // Variable Local
        }
    }
}