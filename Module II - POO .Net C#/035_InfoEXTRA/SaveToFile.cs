using System;
namespace HelloWorld 
{ 
   
    class SaveToFile{

        public void Save(string stringTemp){

                try{

                    Console.WriteLine("Hola " + stringTemp);

                    // StreamWriter estructura1 = File.CreateText("SaveToFile.txt");
                    StreamWriter estructura1 = File.AppendText("SaveToFile.txt");
                    estructura1.WriteLine(stringTemp);
                    estructura1.Close();

                } catch ( Exception ex ){
                    Console.WriteLine("Error actual: {0}", ex.Message);
                } finally {
                    Console.WriteLine("Terminado el proceso try ... ");
                }

        }

        public void readFile(){

            try {
                StreamReader lectura = File.OpenText("SaveToFile.txt");
                string linea = lectura.ReadLine();
                while (linea != null){
                    Console.WriteLine(linea);
                    linea = lectura.ReadLine();
                }
                lectura.Close();
            } catch {
                Console.WriteLine("Error al leer el archivo");
            }
        }

        public void deleteFile(){
            if (File.Exists("SaveToFile.txt"))
                File.Delete("SaveToFile.txt");
        }

        public void copyFile(){
                File.Copy("SaveToFile.txt", 
                    "CopiaSeguridad/SaveToFile2.txt");
        }

        public void moveFile(){
                File.Move("SaveToFile.txt", 
                    "CopiaSeguridad/SaveToFile.txt");
        }

        public void showDate(){
            DateTime now = DateTime.Now;
            Console.WriteLine("La Fecha actual es: " + now);
        }
        public void ShowTime(){
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("La Hora actual es: " + time);
        }
    }

}