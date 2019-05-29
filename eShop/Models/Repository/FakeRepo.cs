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
            new ProductInfo { Title = "Running shoes", Description = "Description 3", Price = 95 },
            new ProductInfo { Title = "Football1", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board1", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Football2", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board2", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Football3", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board3", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Footbal4", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board4", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Football5", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board5", Description = "Description 2", Price = 179 },
            new ProductInfo { Title = "Football6", Description = "Description 1", Price = 25 },
            new ProductInfo { Title = "Surf board6", Description = "Description 2", Price = 179 },
        }.AsQueryable<ProductInfo>();

        public FakeRepo()
        {
        }
    }
}
