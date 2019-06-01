using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Order
    {
        private int _orderid;
        private DateTime _orderdate;
        public static List<Cart> orderlist =new List<Cart>();
        public Order(int orderid,DateTime date)
        {
            _orderid = orderid;
            _orderdate = date;
            
        }
        public int Orderid { get { return _orderid; } }
        public DateTime OrderDate { get { return _orderdate; } }
        public void Additem(Cart cartitem)
        {
            orderlist.Add(cartitem);
            
        }
    
        public double Checkoutcost()
        {
            double checkoutcost=0;
            foreach(var order in orderlist)
            {
                checkoutcost = checkoutcost + order.TotalCartCost();
            }
            return checkoutcost;
        }

    }
}
