using System;
namespace HelloWorld 
{ 
    class customer{

        private Order _order;

        public customer(){
            _order = new Order();
        }

        public customer(Order order){
            _order = order;
        }

        public void SetOrder(Order order){
            _order = order;
        }

        public void AddItemToOrder(){
            _order.AddItem();
        }

        public int CheckItems(){
            return _order.CheckItems();
        }



    }
}