using System;
using System.IO;                // Ficheros TXT

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            // 0 - 1, bits => bytes
            // StreamWriter => Escribir en TXT
            // StreamReader => Leer en TXT
            // File dentro System.IO ( crear, copiar, mover, eliminar, abrir )

            // // Crear Archivo TEXTO
            // StreamWriter Escritura1 = File.CreateText("ejemplo.txt");
            // Escritura1.WriteLine("Nota Ivan: 9");
            // Escritura1.WriteLine("Nota Lilen: 10");
            // Escritura1.WriteLine("Nota Luis: 10");
            // Escritura1.Close();


            // // Crear y Editar Añadiendo contenido en Archivo TEXTO
            // string nombre = "";
            // byte nota = 0;

            // // Perdir datos al usuario
            // Console.WriteLine("Introducir nombre: ");
            // nombre = Console.ReadLine();

            // Console.WriteLine("Introducir Nota del Alumno ");
            // // 0 - 255, usa 1 byte
            // nota = byte.Parse(Console.ReadLine());

            // // Crear Archivo TXT
            // StreamWriter Escritura2 = File.AppendText("ejemplo.txt");

            // Escritura2.WriteLine("Nota " + nombre + ": " + nota);
            // Escritura2.Close();



            // Leer el archivo
            StreamReader lectura1 = File.OpenText("ejemplo.txt");

            try {

                string linea = lectura1.ReadLine();
                while ( linea != null ){
                    Console.WriteLine(linea);
                    linea = lectura1.ReadLine();
                }
                lectura1.Close();

            } catch {
                lectura1.Close();
            }



        } 
    }
}