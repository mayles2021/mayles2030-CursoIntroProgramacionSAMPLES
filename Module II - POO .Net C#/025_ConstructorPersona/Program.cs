using System;
namespace HelloWorld 
{ 
    class Alumno 
    { 
        public string nombre;
        public int edad;
        public string direccion;
        public string email;  

        // public Alumno(){
        //     // valores fijos
        //     nombre = "Lemming";
        // }

        public Alumno(string x, int y, string z, string ab){
            nombre = x;
            edad = y;
            direccion = z;
            email = ab;
        }

        static void Main(string[] args) 
        { 
            Alumno obj1 = new Alumno("Miguel", 20, "sevilla", "notengo");
            Console.WriteLine("Valor: " + obj1.nombre);

            Alumno obj2 = new Alumno("Antonio@ola", 32, "malaga", "notengo");
            Console.WriteLine("Valor: " + obj2.nombre);




            // Alumno obj2 = new Alumno();
            // Console.WriteLine("Valor: " + obj2.nombre);

        } 
    }
}