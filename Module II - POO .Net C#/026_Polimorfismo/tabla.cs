using System;
namespace HelloWorld 
{ 
    class tabla 
    { 

        public int number;
        public double pivalue = 3.1416;

        public tabla(){
            number = 5;
        }

        public tabla(int varTemp){
            number = varTemp;
        }
        
        public tabla(int varTemp, string nameUser){
            number = varTemp;
        }

        public void showTable(){
            for(int i=0; i<=10; i++){
                Console.WriteLine(i + " x " + number + " = " + (i*number));
            }
        }

        public void showInfo(){
            string valstr1 = "a";
            string valstr2 = "b";
            Console.WriteLine("valueA: " + valstr1 + " - valueB: " + valstr2);
        }
        public void showInfo2(string a, string b){
            string valstr1 = a;
            string valstr2 = b;
            Console.WriteLine("valueA: " + valstr1 + " - valueB: " + valstr2);
        }
        public void showInfo3(string a, string b="Cadiz"){
            string valstr1 = a;
            string valstr2 = b;
            Console.WriteLine("valueA: " + valstr1 + " - valueB: " + valstr2);
        }

        public void showInfo4(string a){
            string valstr1 = a;
            string valstr2 = "Cadiz";
            Console.WriteLine("valueA: " + valstr1 + " - valueB: " + valstr2);
        }

        public void showPIvalue(){
            Console.WriteLine("Value of PI: " + pivalue);
        }
        public void showPIvalue(int x){
            int xTemp = x;
            Console.WriteLine("Value of PI: " + pivalue);
            Console.WriteLine("Value of X: " + xTemp);
        }


    }
}