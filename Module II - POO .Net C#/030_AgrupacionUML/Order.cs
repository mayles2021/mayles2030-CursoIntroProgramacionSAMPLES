using System;
namespace HelloWorld 
{ 
    
    class Order{

        private int _items;

        public void AddItem(){
            _items += 1;
        }
        
        public void RemoveItem(){
            _items -= 1;
        }

        public int CheckItems(){
            return _items;
        }

    }
}