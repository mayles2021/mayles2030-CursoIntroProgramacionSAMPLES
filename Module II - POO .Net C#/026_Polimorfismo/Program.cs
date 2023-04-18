using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            tabla obj1 = new tabla();
            obj1.showTable();
            obj1.showInfo();

            tabla obj2 = new tabla(3);
            obj2.showTable();
            obj2.showInfo();
            obj2.showInfo2("Sevilla", "Valencia");
            obj2.showInfo3("Sevilla");
            obj2.showInfo4("Sevilla");
            obj2.showPIvalue();

            tabla obj3 = new tabla(5, "Rafael");
            obj3.showInfo2("hola", "adios");

            operator2 obj4 = new operator2(1,2, "+");
            obj4.showInfo();
            
            operator2 obj5 = new operator2(1,2, "-");
            obj5.showInfo();

            TablaMultiplicar obj6 = new TablaMultiplicar(3);
            obj6.showInfo();

        } 
    }
}