// Hello World! program
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            // objeto var = objeto
            var Loteria2 = new List<int> { 23, 11, 13, 7, 16, 33};
            var Loteria3 = new List<int> { 23, 11, 13};  

            // in recurre, tempValue una varTemp
            foreach(int TempValue in Loteria2){
                Console.WriteLine($"{TempValue}");
            }

        }
    }
}