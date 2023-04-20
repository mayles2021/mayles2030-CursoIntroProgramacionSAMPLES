using System;
namespace HelloWorld 
{ 

    class Vehiculo{

        // Variables
        // Puede o no tener constructor
        // Metodos

        public string Matricula;
        public string Modelo;
        public int PotenciaCV;

        public string getMatricula(){
            return Matricula;
        }

        public void setMatricula(string tempMat){
            Matricula = tempMat;
        }
        
        public string getModelo(){
            return Modelo;
        }
        
        public void setModelo(string tempMod){
            Modelo = tempMod;
        }
        
        public int getPotenciaCV(){
            return PotenciaCV;
        }
        
        public void setPotenciaCV(int tempPotencia){
            PotenciaCV = tempPotencia;
        }

        public void ShowMatriculaModeloPoetencia(){
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("PotenciaCV: " + PotenciaCV);
        }

        public void AddPotencia(){
            PotenciaCV += 10;
        }

        public void RemovePotencia(){
            PotenciaCV -= 10;
        }
        
    }

}