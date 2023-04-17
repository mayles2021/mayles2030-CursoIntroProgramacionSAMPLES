using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            // Personal obj1 = new Personal();

            Profesor profe1 = new Profesor(1, "Miguel", "Yllanes");
            Console.WriteLine("valor: " + profe1._Nombre);
            Console.WriteLine("valor: " + profe1.Nombre);

            profe1.Id = 7;
        

        } 
    }


    public class Personal{

        private int _id;
        public string _Nombre;
        private string _Apellidos;

        // Getter y Setter
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Nombre
            {
                get { return _Nombre; }
                set { _Nombre = value; }
            }

            public string Apellidos
            {
                get { return _Apellidos; }
                set { _Apellidos = value; }
            }

        // Getter y Setter

        // Constructor

            public Personal(int pId, string pNombre, string pApellidos){
                _id = pId;
                _Nombre = pNombre;
                _Apellidos = pApellidos;
            }

        // Constructor

    }


    // Herencia

    class Profesor : Personal {

        // public int nueva;
        public Profesor(int pId, string pNombre, string pApellidos) 
            : base(pId, pNombre, pApellidos){

            // nueva = 7;
        }
    }

    // Herencia

}
