using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Cart
    {
        private int _cartid,_quantity;
        private Product _product;
        public Cart(int cartid,Product product,int quantity)
        {
            this._cartid = cartid;
            this._product = product;
            this._quantity = quantity;
        }
        public int Cartid { get { return _cartid; } }
        public int Quantity { get { return _quantity; } }
        public Product ProductDetails { get { return _product; } }
        public Double TotalCartCost()
        {
            double totalcost = _product.FindCost() * _quantity;
            return totalcost;
        }

    }
}
