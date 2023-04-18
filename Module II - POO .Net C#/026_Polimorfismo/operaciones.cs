using System;
namespace HelloWorld 
{ 
    class operator2 
    { 
        
        int val1;
        int val2;
        string val3;

        public operator2(int a, int b, string z){
            val1 = a;
            val2 = b;
            val3 = z;
        }

        public void showInfo(){
            Console.WriteLine("value: " + val1);
            Console.WriteLine("value: " + val2);
            Console.WriteLine("value: " + val3);

            if (val3 == "+"){
                Console.WriteLine("La suma es: " + (val1+val2));
            }
            if (val3 == "-"){
                Console.WriteLine("La suma es: " + (val1-val2));
            }
        }
    }
}