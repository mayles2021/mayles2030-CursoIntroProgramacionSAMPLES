using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        public static string nombreAlumno;
        private static int edadAlumno = 20;
        protected static double notaAlumno = 0.00;

        static void Main(string[] args) 
        { 
            AsignarNombre();
            ImprimirValores();

            Profesor obj1 = new Profesor();
            obj1.nombre = "Rafael";
            obj1.Imprimir();
        } 

        // Metodos fuera del MAIN siempre
        public static void AsignarNombre(){
            nombreAlumno = "Miguel";
        }

        public static void ImprimirValores(){
            Console.WriteLine("Nombre: " + nombreAlumno);
            Console.WriteLine("Edad: " + edadAlumno);
        }



    }





    class Profesor{
        public string nombre;

        public void Imprimir(){
            Console.WriteLine("Hola");
        }
    }

    class Hospital{
        public int pacientes = 100;
    }





}