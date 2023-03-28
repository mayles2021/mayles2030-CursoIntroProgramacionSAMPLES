
/*
@autor: Miguel Angel
@empresa: El Corte Ingles
@ejercicio: funciones
@fecha: 2023/03/28
*/

using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        // Var Staticas
        
        // Var Staticas

        static void Main(string[] args) 
        { 
            Console.WriteLine("Hello World!"); 
            function1_Saludar();                                            // return "...";
            Console.WriteLine(function1_Saludar());                         // return "...";
            
                // Modo1
                Console.WriteLine(funcionCIFEmpresa());

                // Modo2
                string TempCIF = funcionCIFEmpresa();
                Console.WriteLine(TempCIF);

                // ... guardarlo en un archivo

            int varMts = 30;
            Console.WriteLine(funcion2_CalcularAprobado());
            Console.WriteLine(funcion3_CalcularDoble(varMts));



            // Funciones y Procedimientos

                string function1_Saludar(){                 // Funcion aparece RETURN y definimos tipo var salida
                    return "Hola Miguel, buenos dias";
                }

                string funcionCIFEmpresa(){
                    /*
                    Esta funcion imprime el cif de la empresa
                    */
                    return "B-122355889";
                }

                string funcion2_CalcularAprobado(){           // Funcion
                    int varTemp1 = 5;
                    string msg = "";
                    if ( varTemp1 >= 5){
                         msg = "Aprobado";
                    } else {
                        msg = "Suspenso";
                    }
                    return msg;
                }



                int funcion3_CalcularDoble(int TempVar){      // Funcion
                    return (TempVar*2);
                }

                int num1 = 10; 
                int num2 = 4;
                resta(num1, num2);
                resta(4, 5);

                int resta(int Tempnum1, int Tempnum2)
                {
                    return Tempnum1 - Tempnum2;
                }

            // Funciones y Procedimientos
            
        } 

        // Metodos

        // Metodos
        
    }
}