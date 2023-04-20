using System;
namespace HelloWorld 
{ 
    class Taxi : Vehiculo{

        public int numeroLicencia;

        public int getNumPlaza(){
            return numeroLicencia;
        }

        public void setNumPlaza(int tempPlaza){
            numeroLicencia = tempPlaza;
        }
    }

}