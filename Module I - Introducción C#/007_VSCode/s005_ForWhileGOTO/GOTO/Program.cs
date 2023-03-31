// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {

            Console.WriteLine("Texto reconocido");
            goto destino1;
            Console.WriteLine("No Imprimible");

            destino1:
                Console.WriteLine("He dado salto");

        }
    }
}