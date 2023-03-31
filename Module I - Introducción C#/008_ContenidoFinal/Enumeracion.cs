using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static int varStatic;

        enum EstacionAnyo{
            Primavera,
            Verano,
            Otonyo,
            Invierno
        }

        const int EDAD = 48;
    
        static void Main(string[] args) 
        { 
            
            Console.WriteLine("Valor: " + EstacionAnyo.Primavera);
            Console.WriteLine("Estacion.Primavera: " + EstacionAnyo.Primavera.ToString().Equals("Primavera"));

            bool coincide = EstacionAnyo.Primavera.ToString().Equals("Primavera");
            
           Console.WriteLine("Contenido numerico: " + ((int)EstacionAnyo.Primavera));
           Console.WriteLine("Contenido numerico: " + ((int)EstacionAnyo.Verano));
           Console.WriteLine("Contenido numerico: " + ((int)EstacionAnyo.Otonyo));
           Console.WriteLine("Contenido numerico: " + ((int)EstacionAnyo.Invierno));
 
            int indiceValor = (int)EstacionAnyo.Primavera;
            

        } 
    }
}