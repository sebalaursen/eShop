using System;
using eShop.Models.Product;
using System.Collections.Generic;

namespace eShop.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductInfo> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public ProductsListViewModel()
        {

        }
    }
}
