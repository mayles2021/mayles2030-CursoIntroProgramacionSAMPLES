using System;

namespace App1
{
    public class ClientesPrueba
    {
        public static string name = "MJ";

        public string saludo(){
            return "hola " + name;
        }
    }

    public class Client{
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public ushort age { get; set; }

        public string saludo(){
            return "Hello " + name + " " + surname;
        }
    }

}