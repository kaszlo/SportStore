using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repo;

        public ProductController(IProductRepository repository)
        {
            repo = repository;
        }

        public ViewResult List() => View(repo.Products);
    }
}
