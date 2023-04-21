using System;
namespace HelloWorld 
{ 
    
    public interface IFigura{
        void CalculaAreaFigura();
        void CalculaAreaFigura(int b, int altura);
    }

    public interface IFigura2{
        void CalculaAreaFigura2();
        void CalculaAreaFigura2(int b, int altura);
    }
 
    public class Cuadrado : IFigura, IFigura2{
        int lado;

        public Cuadrado(int ladoTemp){
            this.lado = ladoTemp;   // Valor variable
        }

        public Cuadrado(){
            this.lado = 25;     // Valor Fijo
        }

        public void CalculaAreaFigura(){
            Console.WriteLine("El area del cuadrado es: " + ( lado * lado ));
        }

        public void CalculaAreaFigura(int b, int altura){
            throw new NotImplementedException();
        }

        public void CalculaAreaFigura2(){
            Console.WriteLine("El area del cuadrado es: " + ( lado * lado ));
        }

        public void CalculaAreaFigura2(int b, int altura){
            throw new NotImplementedException();
        }
    }




    // public abstract class CA_Figura{

    //     public string nombre;

    //     void CalculaAreaFigura();
    //     void CalculaAreaFigura(int b, int altura);
    // }




}