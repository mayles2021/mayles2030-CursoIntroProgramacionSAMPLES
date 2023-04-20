using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // System.Console.WriteLine("Hello World!"); 

            // // Creacion de objeto
            // Vehiculo coche1 = new Vehiculo();

            // // Asignamos los valores, ya que no hay constructor
            // coche1.Matricula = "Se-1833";
            // coche1.Modelo = "Open Astra 33";
            // coche1.PotenciaCV = 100;

            // // // Definir para un futuro
            // // void AddPotencia(){
            // //     coche1.PotenciaCV += 5;
            // // }

            // // // Llamar o ejecutar
            // // AddPotencia();

            // // // Llamar al metodo de la clase
            // // coche1.AddPotencia();


            // // Obtener datos
            
            //     // Mode1
            //     Console.WriteLine(coche1.getMatricula());

            //     // Mode2
            //     string matriculaTemp = coche1.getMatricula();
            //     Console.WriteLine("Valor Matricula: " + matriculaTemp);

            //         // switch(matriculaTemp){
            //         //     // ... 
            //         // }

            //     coche1.setMatricula("Sevilla");
            //     coche1.setModelo("Xsara Picasso");
            //     coche1.setPotenciaCV(200);
            //     coche1.ShowMatriculaModeloPoetencia();

            //     // ... 

            //     coche1.setMatricula("Cadiz");
            //     coche1.setModelo("Xsara C4");
            //     coche1.setPotenciaCV(100);
            //     coche1.ShowMatriculaModeloPoetencia();



            // // Agrupacion UML
            // customer obj1 = new customer();
            // obj1.AddItemToOrder();
            // obj1.AddItemToOrder();
            // obj1.AddItemToOrder();
            // obj1.AddItemToOrder();
            // Console.WriteLine(obj1.CheckItems());


            string nombreProfe = "Miguel Angel";
            Console.WriteLine("Valor nombreProfe: " + nombreProfe);

            string nombrePequeño = nombreProfe.Substring(7, 5);
            Console.WriteLine("Valor reducido: " + nombrePequeño);

            string elQuijote = "En un lugar de la mancha de cuyo nombre no quiero acordarme";
            string resumeQuijote = elQuijote.Substring(0, 10);
            Console.WriteLine("El quijote: " + resumeQuijote);

            int numCaracteres = elQuijote.Length;
            Console.WriteLine("caracteres: " + numCaracteres);



        } 
    }
}