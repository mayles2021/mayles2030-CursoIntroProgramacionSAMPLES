using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            LinkedList<string> my_list = new LinkedList<string>();
            my_list.AddLast("Miguel");
            my_list.AddLast("Rafael");
            my_list.AddLast("Antonio");
            my_list.AddLast("Pepe");
           
            foreach(string str1 in my_list){
                Console.WriteLine(str1);
            }

            my_list.RemoveLast();
            my_list.RemoveFirst();
            my_list.Remove("Pepe");
            
            foreach(string str1 in my_list){
                Console.WriteLine(str1);
            }

        } 
    }
}