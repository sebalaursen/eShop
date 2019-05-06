using System;
using eShop.Models.Product;

namespace eShop.Models.Buy
{
    public class Cart
    {
        public CartProduct[] Products { get; set; }

        public double GetSum()
        {
            double res = 0;

            for(int i = 0; i < Products.Length; ++i)
            {
                res += Products[i].getSum();
            }

            return res;
        }
    }
}
