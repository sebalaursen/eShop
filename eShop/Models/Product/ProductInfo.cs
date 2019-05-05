using System;
namespace eShop.Models.Product
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Raiting { get; set; }
        //enum category
        //views int
        public ProductImage Image { get; set; }
    }
}
