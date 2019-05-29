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
        public string Category { get; set; }
        public int AmmountOfViews { get; set; }
        public ProductImage Image { get; set; }
    }
}
