using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        static void Main(string[] args) 
        { 

            // funcion capaz sumar notas y sacarme media
            int mediaNotas(int num1, int num2, int num3){
                return ((num1+num2+num3)/3);
            }

            Console.WriteLine("Resultado NOTA MEDIA DEL ALUMNO Luis " + mediaNotas(5,7,8));
            Console.WriteLine("Resultado NOTA MEDIA DEL ALUMNO Lilen " + mediaNotas(10, 3, 7));


            double mediaNotas2(params double[] notas){
                double suma = 0;           // Acumuladores
                foreach(int x in notas){
                    suma = suma + x;
                }
                double result = suma / notas.Length;           // notas = array
                return result;
            }


            Console.WriteLine("Resultado NOTA MEDIA DEL ALUMNO Luis " + mediaNotas2(5,7,8));
            Console.WriteLine("Resultado NOTA MEDIA DEL ALUMNO Lilen " + mediaNotas2(10, 3, 7));



        } 

    }
}