using ECommerceProject.Entities;
using ECommerceProject.Services;
using ECommerceProject.Web.Models;
using ECommerceProject.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class ProductsController : Controller
    {
        //CategoryService categoryService = new CategoryService();
        //ProductService productService = new ProductService();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            NewProductViewModel model = new NewProductViewModel();

            model.AvailableCategories = CategoryService.Instance.getCategories();

            return View(model);
        }

        public ActionResult Create(NewProductViewModel model)
        {
            Product product = new Product();
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;

            product.Category = CategoryService.Instance.getCategoryById(model.CategoryId);
            ProductService.Instance.SaveProduct(product);

            return RedirectToAction("ProductsTable");
        }
        #region Updation
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            EditProductViewModel model = new EditProductViewModel();

            var product = ProductService.Instance.GetProduct(Id);

            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            model.CategoryId = product.Category.Id;
            model.AvailableCategories = CategoryService.Instance.getCategories();


            return PartialView(model);
        }
        [HttpPost]
        public ActionResult Edit(EditProductViewModel model)
        {
            var product = ProductService.Instance.GetProduct(model.Id);
            product.Id = model.Id;
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Category = CategoryService.Instance.getCategoryById(model.CategoryId);

            ProductService.Instance.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        #endregion
        [HttpGet]
        public ActionResult ProductsTable(string search, int? pageNo)
        {
            ProductSearchViewModel model = new ProductSearchViewModel();
            pageNo = pageNo.HasValue ? pageNo.Value > 0 ? pageNo.Value : 1 : 1;

            model.Products = ProductService.Instance.GetProducts(pageNo.Value);
            if (!string.IsNullOrEmpty(search))
            {
                model.SearchTerm = search;
                model.Products = model.Products.Where(p => p.Name.ToLower() == search.ToLower()).ToList();
            }

            return PartialView(model);
        }
    }
}