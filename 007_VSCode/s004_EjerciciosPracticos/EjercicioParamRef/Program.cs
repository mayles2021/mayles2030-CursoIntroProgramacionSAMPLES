// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main()
        {

            int num1 = 7;
            Console.WriteLine("Valor: " + num1);

                            // 0,  1,  2, 3,  4,  5
            int[] loteria = { 23, 11, 13, 7, 16, 33 };
            ChangeArray(ref loteria);

            // Funcion, reciba array por refencia
            void ChangeArray(ref int[] pArray){
                pArray[0] = 77;
                for(int x=0; x<=5; x++){
                    Console.Write(pArray[x] + ", ");
                }   

            }







           //  Console.WriteLine(loteria[2] + " " + loteria[1]);
            
            // Modo1
            // Console.WriteLine(loteria[0]);
            // Console.WriteLine(loteria[1]);
            // Console.WriteLine(loteria[2]);
            // Console.WriteLine(loteria[3]);
            // Console.WriteLine(loteria[4]);
            // Console.WriteLine(loteria[5]);

            // Modo 2 profesional
            for(int x=0; x<=5; x++){
                Console.Write(loteria[x] + ", ");
            }




        }
    }
}