// Hello World! program
namespace HelloWorld
{
    class Hello {   

        static string nameAlumn = "Pepe";

        static void Main()
        {
            string name1 = "Jose";
            Console.WriteLine("Buenos Dias !!" + name1);
            Console.WriteLine("Buenos dias !!");
            Console.WriteLine(dudaResto());
            Console.WriteLine(dudaSaludo());

            int dudaResto()
            {
                int numTemp = 7;
                return numTemp-3;
            }

            string dudaSaludo(){
                return "hola";
            }




            // suma(5);
            // sumar2(5,7);

            // void suma(int numTemp){
            //     Console.WriteLine(2 + numTemp);
            // }

            // void sumar2(int Temp1, int temp2){
            //     Console.WriteLine(Temp1 + temp2);
            // }


            // saludar();
            // despedirme();
            // despedirme();

            // void saludar(){
            //     Console.WriteLine("Hola, soy pepe");
            // }

            // void despedirme(){
            //     Console.WriteLine("Adios, hasta mañana");
            // }

            
        }

    }
}