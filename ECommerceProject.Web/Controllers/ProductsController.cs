using ECommerceProject.Entities;
using ECommerceProject.Services;
using ECommerceProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class ProductsController : Controller
    {
        CategoryService categoryService = new CategoryService();
        ProductService productService = new ProductService();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            var categoriesList = categoryService.getCategories();

            return View(categoriesList);
        }

        public ActionResult Create(NewProductViewModels model)
        {
            Product product = new Product();
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;

            product.Category = categoryService.getCategoryById(model.CategoryId);
            productService.SaveProduct(product);

            return RedirectToAction("ProductsTable");
        }
        [HttpGet]
        public ActionResult ProductsTable()
        {
            var products = productService.getProducts();

            return PartialView(products);
        }
    }
}