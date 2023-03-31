// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {

            // Array         0 1 2 3 4
            int[] array1 = { 1,3,5,7,80,90,7,8,9,20 };

            int TempIndex = array1.Length;
            Console.WriteLine("valorobj: " + TempIndex);

            // Cambia
             for(int x=0; x<TempIndex; x++){
                 Console.WriteLine(array1[x] = 9);
                 Console.ReadKey();
             }
            //Muestra
            for(int x=0; x<TempIndex; x++){
                Console.WriteLine("valor" + array1[x]);
            }

        }
    }
}