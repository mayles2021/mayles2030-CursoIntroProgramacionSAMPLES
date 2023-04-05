using System;
namespace HelloWorld
{
    class Hello
    {
        enum estadoCivil
        {
            Soltero,
            Casado,
            Divorciado,
            Viudo
        }

        public static string nombre = "";
        public static string apellidos = "";
        public static int edad = 0;
        public static string estadoCivilVar = "";

        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio\n\n");

            // Console.WriteLine("\tAlumno \tMod1 \tMod2");
            // Console.WriteLine("\tMiguel \t10 \t10");
            // Console.WriteLine("\tAna \t9 \t8");

            // Console.WriteLine("\n\n");

            // Teclado
            Console.WriteLine("Introducir nombre, por favor");
            nombre = Console.ReadLine();
            Console.WriteLine("Introducir apellidos, por favor");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introducir edad, por favor");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir estado civil (S,C,D,V), por favor");
            estadoCivilVar = Console.ReadLine();

            string edadValue;
            if (edad > 18)
            {
                edadValue = "Mayor de Edad";
            }
            else
            {
                edadValue = "Menor de Edad";
            }

            switch (estadoCivilVar)
            {
                case "S":
                    estadoCivilVar = estadoCivil.Soltero.ToString();
                    break;
                case "C":
                    estadoCivilVar = estadoCivil.Casado.ToString();
                    break;
                case "D":
                    estadoCivilVar = estadoCivil.Divorciado.ToString();
                    break;
                case "V":
                    estadoCivilVar = estadoCivil.Viudo.ToString();
                    break;
                default:
                    estadoCivilVar = "Valor incorrecto, no se puede guardar en BBDD";
                    break;
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Edad: " + edadValue);
            Console.WriteLine("Estado Civil: " + estadoCivilVar);
            Console.ReadKey();


            // Teclado

        }
    }
}

