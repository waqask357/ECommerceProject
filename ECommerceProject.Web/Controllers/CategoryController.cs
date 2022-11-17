using ECommerceProject.Entities;
using ECommerceProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService catService = new CategoryService();
        // GET: Category
        public ActionResult Index()
        {
            var categoriesList = catService.getCategories();
            return View(categoriesList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category categoryFromView)
        {
            catService.saveCategory(categoryFromView);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var category = catService.getCategoryById(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category categoryFromView)
        {
            catService.updateCategory(categoryFromView);
            return RedirectToAction("Index");
        }

    }
}