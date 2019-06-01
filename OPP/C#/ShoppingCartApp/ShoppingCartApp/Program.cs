using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Printinfo();
        }

        private static void Printinfo()
        {
            Product product1 = new Product(100, "Mobile", 10000, 2000);
            Product product2 = new Product(101, "Case", 1000, 50);
          //  Console.WriteLine("Product Name:{0} Product cost:{1}", product1.Name, product1.FindCost());
          //  Console.WriteLine("Product Name:{0} Product cost:{1}", product1.Name, product2.FindCost());
            Cart cart1 = new Cart(1, product1, 2);
            Cart cart2 = new Cart(2, product2, 3);
          //  Console.WriteLine("Product Name:{0}  Quantity:{1} TotalCartCost:{2}", product1.Name, cart1.Quantity, cart1.TotalCartCost());
          //  Console.WriteLine("Product Name:{0}  Quantity:{1} TotalCartCost:{2}", product2.Name, cart2.Quantity, cart2.TotalCartCost());
            Order order1 = new Order(11, DateTime.Today);
            order1.Additem(cart2);
            order1.Additem(cart1);
  //        Console.WriteLine("Product Name{0} ProductQuantity:{1} Orderid:{2}  Order Date:{3} Checkout Cost:{4}",cart1.ProductDetails.Name,cart1.Quantity, order1.Orderid, order1.OrderDate, order1.Checkoutcost());
            Order order2 = new Order(12, DateTime.Now);
            order2.Additem(cart2);
           
   //       Console.WriteLine("Orderid:{0}  Order Date:{1} Checkout Cost:{2}", order2.Orderid, order2.OrderDate, order2.Checkoutcost());
            Customer customer1 = new Customer("priyank");
            Console.WriteLine("Customer Name:{0}", customer1.CustomerName);
            customer1.AddOrders(order1);
          
            customer1.AddOrders(order2);
            customer1.DisplayOrderDetails();
          //  order2.DisplayItem();
         
        }


    }
}
