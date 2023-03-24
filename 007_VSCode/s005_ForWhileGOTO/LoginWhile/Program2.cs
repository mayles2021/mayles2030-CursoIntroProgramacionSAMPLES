using System;

namespace EspacioPrueba
{
    class LoginWhile {         
        static void Main(string[] args)
        {

            string pass = "";
            
            while(pass != "Password"){
                Console.WriteLine("Introducir Pwd: ");
                pass = Convert.ToString(Console.ReadLine());

                if (pass == "Password") {
                    Console.WriteLine("Ok, bienvenido");
                } else {
                    Console.WriteLine("No entra en Facebook");
                }

            }

        }
    }
}