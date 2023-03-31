using System;

class Program
{
    static void Main() {

        byte c1 = 120;             // byte from 0 to 255, usa 1 byte
        Console.WriteLine("Valor byte: " + c1);

        sbyte c2 = 126;           // sbyte from -128 al 127 usa 1 byte
        Console.WriteLine("Valor sbyte: " + c2);

        short b1 = 300;          // short from -31768 al 32767 usa 2 byte
        Console.WriteLine("Valor short: " + b1);

        ushort b2 = 300;        // ushort from 0 al 65535 usa 2 bytes
        Console.WriteLine("Valor ushort: " + b2);

        int stockItems = 2546;  // Integer from -2147483648 to 2147483647 usa 4 bits
        Console.WriteLine("valor int " + stockItems);

        uint b3 = 5;            // uint from 0 a 4294967.295 usa 4 bytes
        Console.WriteLine("valor uint " + b3);

        char notaAlumns = 'F';  // usa 2 bytes
        Console.WriteLine("valor char " + notaAlumns);

        bool gameOver = false;  // True or False usa 2 bytes
        Console.WriteLine("valor booleano " + gameOver);

        decimal dec1 = 5.25M;       //  Decimal from −7.9228162514264337593543950335 a +7.9228162514264337593543950335 usa 16 bytes
        Console.WriteLine("valor decimal " + dec1);

        float precio1 = 8.50F;  // Float from ±1.401298E−45 a ±3.402823E+38 7 usa 4 bytes
        Console.WriteLine("valor float " + precio1);

        double precio2 = 49.85D;
        Console.WriteLine("valor double: " + precio2);  // Double from ±4.94065645841246E−324 a ±1.79769313486232E+308 usa 4 bytes

        long saldo = 7300000L;      // Long from -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 usa 8 bytes
        Console.WriteLine("valor Long: " + saldo);

        ulong saldo2 = 6400000;     // // Ulong from 0 a 18.446.744.073.709.551.615 usa 8 bytes
        Console.WriteLine("valor ulong: " + saldo2);
    }
}