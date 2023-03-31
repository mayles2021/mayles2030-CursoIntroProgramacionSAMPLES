using System;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {

        int[] notas = { 5, 7, 6, 10, 10, 7, 7 };

        for ( int x=0; x<notas.Length; x++){
            Console.WriteLine("Nota: " + notas[x]);

            if ( notas[x] == 7){
                break;
            }

        }


    }
    }
}