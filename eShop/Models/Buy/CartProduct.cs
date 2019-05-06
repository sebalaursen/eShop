using System;
using eShop.Models.Product;

namespace eShop.Models.Buy
{
    public class CartProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public double Price { get; set; }
        public int Ammount { get; set; }
        public ProductImage Image { get; set; }

        public double getSum()
        {
            return Price * Ammount;
        }
    }
}
