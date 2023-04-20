using System;
namespace HelloWorld 
{ 
    class A 
    { 
        public int val1;
    }
    class B 
    { 
        public int val2;
    }

    // No se permite la herencia multiple
    // class C : A, B 
    // { 
    //     public int val3;
    // }

    // Ejemplo de herencia multiple
        public class ModelBase{
            public int val1;
        }

        public class Model1 : ModelBase {
            public int val2;
        }

        public class Model2 : Model1 {
            public int val3;

        }
    // Ejemplo de herencia multiple

}