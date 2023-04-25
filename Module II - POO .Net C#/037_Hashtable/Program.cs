using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!");

            customer obj1 = new customer(){
                EmpID = 1,
                EmpName = "Microsoft",
                EmpSalary = 50000
            };

            customer obj2 = new customer(){
                EmpID = 2,
                EmpName = "Apple",
                EmpSalary = 70000
            };

            Console.WriteLine(obj1.EmpID);
            Console.WriteLine(obj1.EmpName);
            Console.WriteLine(obj1.EmpSalary);

            // Pasar los objetos a un array
            customer[] arrayCustomer = new customer[2];
            arrayCustomer[0] = obj1;
            arrayCustomer[1] = obj2;

            for(int x=0; x<=1; x++){
                Console.WriteLine(arrayCustomer[x].EmpID);
                Console.WriteLine(arrayCustomer[x].EmpName);
                Console.WriteLine(arrayCustomer[x].EmpSalary);
            }


            // List

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Adios Mundo");

            // Test obj1 = new Test();
            // obj1.TestHashtable();

        } 
    }
}