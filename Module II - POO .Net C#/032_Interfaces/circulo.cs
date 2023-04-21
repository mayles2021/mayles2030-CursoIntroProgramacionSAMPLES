using System;
namespace HelloWorld 
{ 

    class Circulo : IFigura{
        int radio;

        public Circulo(int radio){
            this.radio = radio;
        }

        public void CalculaAreaFigura(){
            Console.WriteLine("Area del circulo es; ");
            Console.WriteLine(Math.PI * (radio * radio));
        }

        public void CalculaAreaFigura(int a, int b){
            throw new NotImplementedException();                // Sin definir o dar forma
        }
    }
}