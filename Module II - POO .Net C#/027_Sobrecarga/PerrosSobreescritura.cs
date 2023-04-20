using System;
namespace HelloWorld 
{ 
    public class Perro 
    { 
        public virtual string Ladrar(){
            return "Perro Ladrando";
        }

    }

    public class chihuahua : Perro{
        public override string Ladrar()
        {
            return base.Ladrar();
        }
    }
    public class Bulldog : Perro{
        public override string Ladrar()
        {
            return "Bulldog Ladrando";
        }
    }
}