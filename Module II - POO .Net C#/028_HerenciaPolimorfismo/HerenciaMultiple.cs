using System;
namespace HelloWorld 
{ 
    
    // Herencia Multiple

        // Error
            class A{
                public int val1;
            }

            class B{
                public int val2;
            }

            // class C : A, B{
            //     public int val3;
            // }
        // Error

        
        public class Abuelo {
            public int val1;
        }

        public class Padre : Abuelo{
            public int val2;
        }

        public class hijo : Padre {
            public int val3;
        }


}