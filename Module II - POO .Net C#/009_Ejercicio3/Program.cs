using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        enum estudioLevel{
            ESO,
            FP1,
            FP2,
            Universitarios
        }

        struct alumnoAUTOESCUELA{
            public string nombre;
            public string apellidos;
            public int edad;
            public string nivelStudio;

            // alumnoAUTOESCUELA.nombre;
        }


        static void Main(string[] args) 
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 3\n\n");
            
            // Creo el objeto struct1 del tipo alumoAUTOESCUELA
            alumnoAUTOESCUELA struct1;

            Console.WriteLine("Introducir nombre: ");
            struct1.nombre = Console.ReadLine();

            // Testear ... 
            // Console.WriteLine("Dato almacenado: " + struct1.nombre);

            Console.WriteLine("Introducir apellidos: ");
            struct1.apellidos = Console.ReadLine();

            Console.WriteLine("Introducir edad: ");
            struct1.edad = int.Parse(Console.ReadLine());

            // do {
            //     Console.WriteLine("Introducir Estudios ( E(eso), F1(fp1), F2(fp2), U(Universitario) ): ");
            //     struct1.nivelStudio = Console.ReadLine();
            // } while ( struct1.nivelStudio != "E");
            
                Console.WriteLine("Introducir Estudios ( E(eso), F1(fp1), F2(fp2), U(Universitario) ): ");
                struct1.nivelStudio = Console.ReadLine();



            switch(struct1.nivelStudio){
                case "E":
                    struct1.nivelStudio = estudioLevel.ESO.ToString();
                    break;
                case "F1":
                    struct1.nivelStudio = estudioLevel.FP1.ToString();
                    break;
                case "F2":
                    struct1.nivelStudio = estudioLevel.FP2.ToString();
                    break;
                case "U":
                    struct1.nivelStudio = estudioLevel.Universitarios.ToString();
                    break;
                default:
                    struct1.nivelStudio = "LLamar al alumno, no se ha enterao";
                    break;
            }


            Console.WriteLine("Ejercicio 3 \n");
            Console.WriteLine("Nombre: " + struct1.nombre);
            Console.WriteLine("apellidos: " + struct1.apellidos);
            Console.WriteLine("edad: " + struct1.edad);
            Console.WriteLine("Estudios: " + struct1.nivelStudio);
            Console.ReadKey();

        } 
    }
}