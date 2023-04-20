using System;
namespace HelloWorld 
{ 

    // Aquí, un Customer agrupa 0, 1 o muchas Orders.
    
    public class Customer
    {
        private Order _order;

        public Customer()
        {
            _order = new Order();
        }

        public Customer(Order order)
        {
            _order = order;
        }
            
        public void SetOrder(Order order)
        {
            _order = order;
        }

        public void AddItemToOrder()
        {
            _order.AddItem();
        }

        public int CheckItems()
        {
            return _order.CheckItems();
        }
    }

    public class Order
    {
        private int _items;

        public void AddItem()
        {
            _items += 1;
        }

        public int CheckItems()
        {
            return _items;
        }
    }

}