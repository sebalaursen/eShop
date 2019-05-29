using System;
using System.Collections.Generic;
using System.Linq;
using eShop.Models.Repository;
using eShop.Models.Product;

namespace eShop.Models
{
    public class EFProductRepository: ProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ProductInfo> Products => context.Products;
    }
}
