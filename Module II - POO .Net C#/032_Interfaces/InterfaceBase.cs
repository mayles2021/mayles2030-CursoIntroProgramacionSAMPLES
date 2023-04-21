using System;
namespace HelloWorld 
{ 
    public interface IVolador{
        public void Volar();
    }

    public class Murcielago : IVolador{
        public void Volar(){
            Console.WriteLine("Soy un Murcielago y esto volando");
        }
    }
}