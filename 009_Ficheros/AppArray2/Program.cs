// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            
            int[] array1 = {1,3,5,7,9};
            Console.WriteLine("indice0: " + array1[0]);

            array1[0] = 5;
            Console.WriteLine("indice0: " + array1[0]);

            Change(ref array1);

            void Change(ref int[] Temparray1){
                Temparray1[0] = 1942;
                Temparray1[1] = 1943;
                Console.WriteLine("Ultimo Valor: " + Temparray1[0]);
                Console.WriteLine("Ultimo Valor: " + Temparray1[1]);
            }

        }
    }
}