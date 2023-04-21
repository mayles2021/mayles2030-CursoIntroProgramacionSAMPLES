using System;
namespace HelloWorld 
{ 

    public interface Alumnos{
        public void NotaAlumno();
    }

    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 

            // Clase Persona
            Persona obj1 = new Persona();
            obj1.nombre = "Antonio";
            obj1.apellidos = "Gomez";
            obj1.documento = "28617K";
            obj1.tipo = "B";
            Console.WriteLine("Nombre: " + obj1.nombre);
            Console.WriteLine("Apellidos: " + obj1.apellidos);
            Console.WriteLine("Documento: " + obj1.documento);
            Console.WriteLine("Tipo: " + obj1.tipo);

            // Clase Cliente
            Cliente obj2 = new Cliente();           // Constructor => Autoejecuta
            obj2.nombre = "Rafael";
            obj2.apellidos = "Anayas";
            obj2.documento = "2877K";
            obj2.tipo = "A";
            Console.WriteLine("Nombre: " + obj2.nombre);
            Console.WriteLine("Apellidos: " + obj2.apellidos);
            Console.WriteLine("Documento: " + obj2.documento);
            Console.WriteLine("Tipo: " + obj2.tipo);
            obj2.Saludar();

        } 
    }


    public class Persona{
        public string nombre = "Miguel";
        public string apellidos;
        public string documento;
        public string tipo;

        public virtual void Saludar(){
            Console.WriteLine("Saludando desde el Padre");
        }
    }

    public class Cliente : Persona, Alumnos{
        public string categoria;
        public int codigo;

        public Cliente(){
            base.Saludar();
        }

        public void GenerarCodigo(){
            Console.WriteLine("Generando codigo");
        }

        public override void Saludar(){
            Console.WriteLine("Saludando desde el Hijo");
        }

        public void NotaAlumno(){
            Console.WriteLine("Imprimiendo nota del alumno");
        }
    }




    public class Empleados : Persona{
        public string tipoContrato;
        public int sueldo;

        public void calcularSueldo(){
            Console.WriteLine("Calculando sueldo");
        }
    }



}