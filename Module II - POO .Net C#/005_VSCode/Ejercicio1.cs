using System;

namespace EjerciciosClase
{
    internal class Ejercicio1
    {

        enum prueba
        {
            rojo,
            amarillo,
            verde
        }

        public void Solucion()
        {
            System.Console.WriteLine("Accediento a los Datos");

            Console.WriteLine("Valor Rojo: " + prueba.rojo);
            Console.WriteLine("Valor Amarillo: " + prueba.amarillo);
            Console.WriteLine("Valor Verde: " + prueba.verde);
        }



    }
}
