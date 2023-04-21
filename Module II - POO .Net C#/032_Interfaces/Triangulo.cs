using System;
namespace HelloWorld 
{ 
    class Triangulo : IFigura
    { 
        public void CalculaAreaFigura(){
            throw new NotImplementedException();
        }

        public void CalculaAreaFigura(int b, int altura){
            Console.WriteLine("El area del triangulo es: " + ( (b * altura) /2));
        }
        
    }
}