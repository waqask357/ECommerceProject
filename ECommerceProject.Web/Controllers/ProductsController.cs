using ECommerceProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            CategoryService categoryService = new CategoryService();
            var categoriesList = categoryService.getCategories();

            return View(categoriesList);
        }
    }
}