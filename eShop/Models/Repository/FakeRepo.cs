using System;
using System.Linq;
using eShop.Models.Product;
using System.Collections.Generic;

namespace eShop.Models.Repository
{
    public class FakeRepo: ProductRepository
    {
        public IQueryable<ProductInfo> Products => new List<ProductInfo> {
            new ProductInfo { Title = "Football", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Running shoes", Description = "Description 3", Price = 95 }
        }.AsQueryable<ProductInfo>();

        public FakeRepo()
        {
        }
    }
}
