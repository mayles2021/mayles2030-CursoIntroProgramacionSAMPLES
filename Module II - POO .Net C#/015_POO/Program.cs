using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
                // funcion o procedimiento

                // Instanciar .... "Hacer una copia de un clase"
                AnimalDelfin obj1 = new AnimalDelfin();
                AnimalDelfin obj2 = new AnimalDelfin();
                AnimalDelfin obj3 = new AnimalDelfin();

                // Llamar al metodo de la instancia
                obj1.Saludar();
                obj1.Nadar();
                obj1.Bucear();

                obj2.Saludar();
                obj2.Nadar();

                obj3.Nadar();
                obj3.Bucear();

                Persona obj4 = new Persona();
                obj4.Saludar();

                Estudiantes obj5 = new Estudiantes();
                obj5.Saludar();



        } 
    }
}