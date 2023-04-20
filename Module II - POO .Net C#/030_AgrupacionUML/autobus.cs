using System;
namespace HelloWorld 
{ 
    class autobus : Vehiculo{

        public int numeroPlaza;

        public autobus(){
            numeroPlaza = 50;           // Inicializar las variables
        }

        public int getNumPlaza(){
            return numeroPlaza;
        }

        public void setNumPlaza(int tempPlaza){
            numeroPlaza = tempPlaza;
        }

    }
}