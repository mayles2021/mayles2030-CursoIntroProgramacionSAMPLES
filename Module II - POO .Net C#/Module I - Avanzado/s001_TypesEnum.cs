using System;

class Program
{

    enum operaciones {SUMA, RESTA, MULTIPLICACION, DIVISION};
    enum respuesta {NO, SI};
    enum diassemana {LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO};
    enum tipoventa {MAYORISTAS, MINORISTAS};
    enum dispositivos {TECLADO, MOUSE, CAMARA};
    enum boolean {FALSE, TRUE};

    enum meses { Enero = 1, Febrero = 2, Marzo = 3 };
    enum meses { escudo = 1, poMagica = 2, Espasa = 3 };

    enum playerState { alive, dead, running, fighing };
    
    
    static void Main() {
            
        Console.WriteLine("Valor: " + operaciones.SUMA);

        string Temp = operaciones.SUMA.ToString();

        Console.WriteLine(meses.Enero);
        Console.WriteLine((int)meses.Enero);
    }


}