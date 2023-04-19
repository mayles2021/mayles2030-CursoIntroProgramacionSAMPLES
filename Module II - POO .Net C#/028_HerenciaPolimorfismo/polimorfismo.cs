using System;
namespace HelloWorld 
{ 

   // Objetos
   public class Perro{
        public string nameDog = "Lucas";
        public int age = 0;

        public string Ladrar(){
            return "Perro Ladrando";
        }
   }

   // Herencia, nos permite el polimorfismo ... 
   public class PerroPadre{
        public string nameDog = "Lucas";
        public int age = 30;

        public virtual string Ladrar(){      // virtual modifica metodos
            return "Perro Ladrando";
        }
   }

   public class chihuahua : PerroPadre{
        public override string Ladrar(){      // modifica metodos
            Console.WriteLine("Valor padre: " + base.Ladrar());
            Console.WriteLine("Nombre Padre: " + base.nameDog);
            return "Chihuahua Ladrando";
        }   
   }

   public class Bulldog : PerroPadre{

   }


}