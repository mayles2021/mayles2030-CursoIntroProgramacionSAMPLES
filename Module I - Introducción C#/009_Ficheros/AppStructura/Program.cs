// Hello World! program
namespace HelloWorld
{

    struct tipoAlumno{
        public string nombre;
        public int edad;
        public double nota;
        public string notafinal;
        public char sexo;           // H, M, ?

    }

    public enum EnumNotas{
        suspenso,
        aprobado,
        repesca
    }

    class Hello {         
        static void Main(string[] args)
        {

            tipoAlumno persona;
            persona.nombre = "Miguel";
            persona.edad = 48;
            persona.nota = 9.5D;
            persona.sexo = 'H';
            persona.sexo = 'M';

            string TempNota = EnumNotas.suspenso.ToString();
            persona.notafinal = TempNota;
            Console.WriteLine(persona.notafinal);

             
            // //Console.Write("edad " + persona.edad);
            // Console.Write("Empleado: " + persona.nombre + "sexo: " + persona.sexo);
            // Console.ReadKey();

            // Console.Write("Empleado: {0}, tiene {1} ha sacado en matematica {2}", 
            //     persona.nombre, persona.edad, persona.nota);
            // Console.ReadKey();

            // Console.Write($"Empleado: {persona.nombre}, tiene {persona.edad}");
            // Console.ReadKey();
        }
    }
}