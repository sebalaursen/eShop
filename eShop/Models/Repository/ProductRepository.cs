using System;
using System.Linq;
using eShop.Models.Product;

namespace eShop.Models.Repository
{
    public interface ProductRepository
    {
        IQueryable<ProductInfo> Products { get; }
    }
}
