using System;
namespace eShop.Models.Product
{
    public class ProductCell
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public double Price { get; set; }
        public ProductImage Image { get; set; }
    }
}
