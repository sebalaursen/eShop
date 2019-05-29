using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eShop.Models;
using eShop.Models.Repository;
using eShop.Models.Product;
using System.Linq;

namespace eShop.Controllers
{
    public class HomeController : Controller
    {
        private ProductRepository repository;
        public int PageSize = 6;

        public IActionResult Index(int productPage = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = repository.Products.OrderBy(p => p.Id).Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
        }

        public ViewResult List(int productPage = 1) => View(new ProductsListViewModel
         {
            Products = repository.Products.OrderBy(p => p.Id).Skip((productPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            }
        });

        public IActionResult About()
        {
            ViewData["Message"] = "Description of the website.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HomeController(ProductRepository repo)
        {
            repository = repo;
        }

       //public ViewResult Index() => View(repository.Products);
    }
}
