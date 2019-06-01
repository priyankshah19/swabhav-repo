using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Customer
    {
        private string _name;
     
        private List<Cart> finalcartlist = Order.orderlist;
     
        private List<Order> CustomerOrderList = new List<Order>();
        public Customer(string name)
        {
            this._name = name;
            


        }
        public String CustomerName { get { return _name; } }
        
        public void AddOrders(Order customerorder)
        {
            CustomerOrderList.Add(customerorder);

        }
     


        public void DisplayOrderDetails()
        {
            foreach (var e in CustomerOrderList)
            {

               
                Console.WriteLine("Orderid:{0} OrderDate:{1} Checkoutcost:{2}", e.Orderid, e.OrderDate, e.Checkoutcost());
             
            }

            foreach (var v in finalcartlist)
            {
                Console.WriteLine("Product Name:{0} Product Quantity:{1} TotalcartCost:{2}", v.ProductDetails.Name, v.Quantity, v.TotalCartCost());
            }

        }

        


    }
}
