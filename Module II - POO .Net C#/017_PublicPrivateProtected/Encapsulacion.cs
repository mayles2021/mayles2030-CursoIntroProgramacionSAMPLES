using System;
namespace HelloWorld 
{ 
    class Encapsulacion 
    { 


    }

    public class primera{
        public int valor1;
        protected int valor2;
    }

    public class segunda{
        public int valor1;
        private int valor2;
    }

    public class segundaSolucion{
        public int valor1;
        private int valor2;

        // Constructor de la clase, acceder para encapsuladas
        public segundaSolucion(int valor){
            valor2 = valor;
        }

        public int getvalor2(){
            return valor2;
        }


    }

    public class tercera : primera {
        private int valor3;
        public int valor4;

        private void Saludar(){
            Console.WriteLine("hola");
        }
        
        public void Saludo(){
            Console.WriteLine("hola");
        }
    }
}