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
            public int nivelStudio;

            // alumnoAUTOESCUELA.nombre;
        }


        static void Main(string[] args) 
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 3\n\n");
            
            // Creo el objeto struct1 del tipo alumoAUTOESCUELA
            alumnoAUTOESCUELA[] struct1 = new alumnoAUTOESCUELA[2];

            Console.WriteLine("Introducir nombre: ");
            struct1[0].nombre = Console.ReadLine();

            // Testear ... 
            // Console.WriteLine("Dato almacenado: " + struct1.nombre);

            Console.WriteLine("Introducir apellidos: ");
            struct1[0].apellidos = Console.ReadLine();

            Console.WriteLine("Introducir edad: ");
            struct1[0].edad = int.Parse(Console.ReadLine());

            // string TempValue;
            // do {
            //     Console.WriteLine("Introducir Estudios ( E(eso), F1(fp1), F2(fp2), U(Universitario) ): ");
            //     // struct1[0].nivelStudio = Console.ReadLine();
            //     TempValue = Console.ReadLine();
            //     Console.WriteLine("Valor: " + TempValue);

            // } while ( TempValue != "E" );
            
                int num;
                do{
                    Console.WriteLine("Introducir Estudios ( 1(eso), 2(fp1), 3(fp2), 4(Universitario) ): ");
                    num = int.Parse(Console.ReadLine());    
                } while ( num > 4);



            switch(struct1[0].nivelStudio){
                case 1:
                    struct1[0].nivelStudio = 1;
                    break;
                case 2:
                    struct1[0].nivelStudio = 2;
                    break;
                case 3:
                    struct1[0].nivelStudio = 3;
                    break;
                case 4:
                    struct1[0].nivelStudio = 4;
                    break;
                default:
                    struct1[0].nivelStudio = 0;
                    break;
            }

            if ( struct1[0].nivelStudio == 1 ){
                string temp = estudioLevel.ESO.ToString();
            }
            if ( struct1[0].nivelStudio == 2 ){
                string temp = estudioLevel.FP1.ToString();
            }


            Console.WriteLine("Ejercicio 3 \n");
            Console.WriteLine("Nombre: " + struct1[0].nombre);
            Console.WriteLine("apellidos: " + struct1[0].apellidos);
            Console.WriteLine("edad: " + struct1[0].edad);
            Console.WriteLine("Estudios: " + struct1[0].nivelStudio);
            Console.ReadKey();




            struct1[1].nombre = "Miguel";
            struct1[1].apellidos = "Gomez";
            struct1[1].edad = 18;
            struct1[1].nivelStudio = 0;




            // Mejora de ejercicio con duda surgida en clase
                for ( int i= 0; i<2; i++){
                    Console.WriteLine("For:");
                    Console.WriteLine(struct1[i].nombre);
                    Console.WriteLine(struct1[i].apellidos);
                    Console.WriteLine(struct1[i].edad);
                    Console.WriteLine(struct1[i].nivelStudio);
                }
            // Mejora de ejercicio con duda surgida en clase

            Console.ReadKey();

            foreach(var x in struct1){
                Console.WriteLine("Valor ForEach: " + x.nombre);
            }
            
            Console.ReadKey();

        } 
    }
}