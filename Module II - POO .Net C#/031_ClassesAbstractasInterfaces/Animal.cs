using System;
namespace HelloWorld 
{ 
    abstract class Animal{

        string nombre = "Lucas";
        int edad;

        // Metodo de siempre
            public void animalSound2(){
                Console.WriteLine("Intentado imprimir sonido del animal");
            }
        // Metodo de siempre

        // Metodo abstracto
        public abstract void animalSound();
        public abstract void animalOjos();
        public abstract void animalPatas();
        
    }

    class perro : Animal{
        public override void animalSound()
        {
            Console.WriteLine("El perro hay guay !! ");
        }
        public override void animalOjos()
        {
            Console.WriteLine("El perro tiene 2 ojos !! ");
        }
        public override void animalPatas()
        {
            Console.WriteLine("El perro tiene 4 patas !! ");
        }
    }
    

}