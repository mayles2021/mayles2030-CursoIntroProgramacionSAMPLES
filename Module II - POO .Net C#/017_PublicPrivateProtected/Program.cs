using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // // Programa principal
            // Delfin obj1 = new Delfin();     // Instacia
            // obj1.nombre = "Flipper";        // Propiedades o Variables
            // obj1.velocidadNadar = 3;        // Propiedades o Variables
            // obj1.ShowInfo();

            // Console.WriteLine("Valor nombre: " + obj1.nombre);
            // obj1.Saludar();

            // Delfin obj2 = new Delfin();     // Instacia
            // obj2.nombre = "Jackson";        // Propiedades o Variables
            // obj2.velocidadNadar = 5;        // Propiedades o Variables

            // Console.WriteLine("Valor nombre: " + obj2.nombre);


            // Encapsulacion obj3 = new Encapsulacion();

            // primera obj4 = new primera();
            // obj4.valor1 = 5;

            // segunda obj5 = new segunda();
            // obj5.valor1 = 7;

            // tercera obj7 = new tercera();
            // obj7.valor1 = 10;
            // obj7.valor4 = 7;
            // Console.WriteLine("valor: " + obj7.valor1);
            // obj7.Saludo();



            primera obj8 = new primera();
            obj8.valor1 = 10;
            Console.WriteLine(obj8.valor1);

            segunda obj9 = new segunda();
            // obj9.valor2 = 8;                 // ERROR: es privada

            segundaSolucion obj10 = new segundaSolucion(10);
            int temp = obj10.getvalor2();
            Console.WriteLine(temp);
            Console.WriteLine(obj10.getvalor2());
            

        } 
    }
}